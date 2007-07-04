using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

using WorldWind;
using WorldWind.Net;
using WorldWind.Renderable;
using WorldWind.Net.Wms;

using WorldWind.PluginEngine;

using Geosoft.DotNetTools;

namespace Dapple.LayerGeneration
{
   public class WMSCatalogBuilder : BuilderDirectory
   {
      #region Delegates
      public delegate void LoadingCompletedCallbackHandler(WMSServerBuilder builder);
      public delegate void LoadingFailedCallbackHandler(WMSServerBuilder builder, string message);
      #endregion

      #region Constants
      protected const string CATALOG_CACHE = "WMS Catalog Cache";
      #endregion

      private WorldWindow m_WorldWindow;
      private System.Collections.Hashtable m_oTable = new System.Collections.Hashtable();
      private System.Collections.Hashtable m_oServers = new System.Collections.Hashtable();
      private System.Threading.Semaphore sem = new System.Threading.Semaphore(1, 1, "builderList");

      public LoadingCompletedCallbackHandler LoadingCompleted = null;
      public LoadingFailedCallbackHandler LoadingFailed = null;

      public static void TrimCapabilitiesURL(ref string serverUrl)
      {
         // Clean up URL first (URL is case sensitive on some servers)
         int iIndex;
         
         string strTemp = serverUrl.ToLower();
         iIndex = strTemp.IndexOf("request=getcapabilities");
         
         if (iIndex != -1)
            serverUrl = serverUrl.Substring(0, iIndex) + serverUrl.Substring(iIndex + "request=getcapabilities".Length);

         strTemp = serverUrl.ToLower();
         iIndex = strTemp.IndexOf("service=wms");
         if (iIndex != -1)
            serverUrl = serverUrl.Substring(0, iIndex) + serverUrl.Substring(iIndex + "service=wms".Length);

         while (serverUrl.IndexOf("&&") != -1)
            serverUrl = serverUrl.Replace("&&", "&");
         serverUrl = serverUrl.TrimEnd(new char[] { '?' });
         serverUrl = serverUrl.TrimEnd(new char[] { '&' });
         serverUrl = serverUrl.Trim();
      }

      public WMSCatalogBuilder(string appDir, WorldWindow worldWindow, string strName, IBuilder parent)
         : base(strName, parent, false)
      {
         m_WorldWindow = worldWindow;
      }

      public bool IsFinishedLoading
      {
         get
         {
            return m_oTable.Count == 0;
         }
      }

      public BuilderDirectory AddServer(string serverUrl, BuilderDirectory builderdir)
      {
         TrimCapabilitiesURL(ref serverUrl);

         // create the cache directory
         string savePath = Path.Combine(Path.Combine(MainApplication.Settings.CachePath, CATALOG_CACHE), WMSQuadLayerBuilder.GetServerFileNameFromUrl(serverUrl));
         Directory.CreateDirectory(savePath);

         // download the catalog
         string xmlPath = Path.Combine(savePath, "capabilities.xml");
         string url = serverUrl +
            (serverUrl.IndexOf("?") > 0 ? "&" : "?") + "request=GetCapabilities&service=WMS";

         WebDownload download = new WebDownload(url, true);
         download.SavedFilePath = xmlPath;
         download.CompleteCallback += new DownloadCompleteHandler(CatalogDownloadCompleteCallback);

         WMSServerBuilder dir = new WMSServerBuilder(this, serverUrl, xmlPath);
         SubList.Add(dir);
         
         m_oTable.Add(download, dir);
         download.BackgroundDownloadFile();

         return dir;
      }

      public WMSList FindServer(string url)
      {
         return m_oServers[url.ToLower()] as WMSList;
      }

      public bool IsServerAdded(string url)
      {
         if (m_oServers.ContainsKey(url.ToLower())) return true;

         foreach (WMSServerBuilder builder in m_oTable.Values)
         {
            if (builder.URL.ToLower().Equals(url.ToLower())) return true;
         }
         return false;
      }

      public void RemoveServer(string url)
      {
         WMSList oServer = m_oServers[url.ToLower()] as WMSList;
         if (oServer != null)
            m_oServers.Remove(url.ToLower());
      }

      private void CatalogDownloadCompleteCallback(WebDownload download)
      {
         WMSServerBuilder serverDir = m_oTable[download] as WMSServerBuilder;

         if (!File.Exists(serverDir.CapabilitiesFilePath))
         {
            LoadFailed(serverDir.Name, "Could not retrieve configuration");
            return;
         }

         WMSList oServer = null;
         try
         {
            oServer = new WMSList(serverDir.URL,
                 serverDir.CapabilitiesFilePath);
            serverDir.ChangeName(oServer.Name);
         }
         catch(Exception e)
         {
            LoadFailed(serverDir.Name, e.Message);
            return;
         }

         if (oServer.Layers == null)
         {
            LoadFailed(serverDir.Name, "Could not retrieve the catalog.");
            return;
         }

         foreach (WMSLayer layer in oServer.Layers)
         {
            ProcessWMSLayer(layer, serverDir);
         }

         if (!m_oServers.Contains(serverDir.URL.ToLower()))
            m_oServers.Add(serverDir.URL.ToLower(), oServer);
         else
            oServer = m_oServers[serverDir.URL.ToLower()] as WMSList;

         lock (m_oTable.SyncRoot)
         {
            m_oTable.Remove(download);
         }
         if (LoadingCompleted != null)
         {
            LoadingCompleted(serverDir);
         }
         if (LoadingCompleted != null)
         {
            LoadingCompleted(serverDir);
         }
      }

      private void LoadFailed(string serverName, string message)
      {
         if (LoadingFailed != null)
         {
            foreach (WMSServerBuilder dir in SubList)
            {
               if (dir.Name == serverName)
               {
                  LoadingFailed(dir, message);
                  break;
               }
            }            
         }
      }

      private void ProcessWMSLayer(WMSLayer layer, BuilderDirectory directory)
      {
         if (layer.ChildLayers != null)
         {
            BuilderDirectory childDir = new BuilderDirectory(layer.Title, directory, false);
            directory.SubList.Add(childDir);

            foreach (WMSLayer childLayer in layer.ChildLayers)
            {
               ProcessWMSLayer(childLayer, childDir);
            }
         }
         else
         {
            IBuilder parentServer = directory;
            while (parentServer != null && !(parentServer is WMSServerBuilder))
               parentServer = parentServer.Parent;

            WMSQuadLayerBuilder builder = new WMSQuadLayerBuilder(layer, m_WorldWindow.CurrentWorld,
               MainApplication.Settings.CachePath, parentServer as WMSServerBuilder, directory);
            sem.WaitOne();
            directory.LayerBuilders.Add(builder);
            sem.Release();
         }

      }
   }

   public class WMSServerBuilder : ServerBuilder
   {
      string m_strCapabilitiesFilePath;

      public WMSServerBuilder(IBuilder parent, string url, string CapabilitiesFilePath)
         : base(url, parent, url)
      {
         m_strCapabilitiesFilePath = CapabilitiesFilePath;
      }

      public string CapabilitiesFilePath
      {
         get
         {
            return m_strCapabilitiesFilePath;
         }
         set
         {
            m_strCapabilitiesFilePath = value;
         }
      }

      public override bool SupportsMetaData
      {
         get
         {
            return File.Exists(m_strCapabilitiesFilePath);
         }
      }

      public override XmlNode GetMetaData(XmlDocument oDoc)
      {
         XmlDocument responseDoc = new XmlDocument();
         XmlReaderSettings oSettings = new System.Xml.XmlReaderSettings();
         oSettings.IgnoreWhitespace = true;
         oSettings.ProhibitDtd = false;
         oSettings.XmlResolver = null;
         oSettings.ValidationType = ValidationType.None;
         using (XmlReader oResponseXmlStream = XmlReader.Create(m_strCapabilitiesFilePath, oSettings))
         {
            responseDoc.Load(oResponseXmlStream);
         }
         XmlNode oNode = responseDoc.DocumentElement;
         XmlNode newNode = oDoc.CreateElement(oNode.Name);
         newNode.InnerXml = oNode.InnerXml;
         return newNode;
      }

      public override string StyleSheetName
      {
         get
         {
            return "wms_cap_meta.xslt";
         }
      }

      public WMSQuadLayerBuilder FindLayerBuilder(WMSLayer layer, BuilderDirectory dir)
      {
         foreach (WMSQuadLayerBuilder layerBuilder in dir.LayerBuilders)
         {
            if (layerBuilder.m_wmsLayer == layer)
               return layerBuilder;
         }

         foreach (BuilderDirectory subdir in dir.SubList)
         {
            WMSQuadLayerBuilder layerBuilderSub = FindLayerBuilder(layer, subdir);
            if (layerBuilderSub != null)
               return layerBuilderSub;
         }

         return null;
      }

      public WMSQuadLayerBuilder FindLayerBuilder(WMSLayer layer)
      {
         return FindLayerBuilder(layer, this);
      }
   }
}
