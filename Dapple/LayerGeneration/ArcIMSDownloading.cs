using System;
using System.Collections.Generic;
using System.Text;
using WorldWind.Renderable;
using WorldWind.Net;
using WorldWind;
using System.Net;
using System.Xml;
using System.IO;
using Utility;
using System.Drawing;

namespace Dapple.LayerGeneration
{
   public class ArcIMSDownloadRequest : GeoSpatialDownloadRequest
   {      
      public ArcIMSDownloadRequest(IGeoSpatialDownloadTile oTile, ArcIMSImageStore oImageStore, string strLocalFilePath)
         : base(oTile, oImageStore, strLocalFilePath, oImageStore.ServerUri.ToBaseUri())
      {
      }

      public override void StartDownload()
      {
         Log.Write(Log.Levels.Debug, "AGDR", "Starting download for ArcIMS server " + ((ArcIMSImageStore)m_imageStore).ServerUri.ToBaseUri());
         Log.Write(Log.Levels.Debug, "AGDR", "Dataset Name: " + ((ArcIMSImageStore)m_imageStore).ServiceName);
         Log.Write(Log.Levels.Debug, "AGDR", "West: " + Tile.West + " South: " + Tile.South + " East: " + Tile.East + " North: " + Tile.North);
         Log.Write(Log.Levels.Debug, "AGDR", "to be stored in " + m_imageStore.GetLocalPath(Tile));

         Tile.IsDownloadingImage = true;

         Directory.CreateDirectory(Path.GetDirectoryName(m_localFilePath));
         download = new ArcIMSImageDownload(m_imageStore as ArcIMSImageStore, new Geosoft.Dap.Common.BoundingBox(Tile.East, Tile.North, Tile.West, Tile.South), 0);
         download.DownloadType = DownloadType.Unspecified;
         download.SavedFilePath = m_localFilePath + ".tmp";
         download.ProgressCallback += new DownloadProgressHandler(UpdateProgress);
         download.CompleteCallback += new WorldWind.Net.DownloadCompleteHandler(DownloadComplete);
         download.BackgroundDownloadMemory();
      }

      protected override void DownloadComplete(WebDownload downloadInfo)
      {
         Log.Write(Log.Levels.Debug, "AGDR", "GET_IMAGE response received.");

         XmlDocument oArcXMLResponse = new XmlDocument();

         try
         {
            downloadInfo.Verify();

            if (downloadInfo.Exception != null)
            {
               Log.Write(downloadInfo.Exception);
               return;
            }

            System.Xml.XmlDocument hResponseDocument = new System.Xml.XmlDocument();
            System.Xml.XmlReaderSettings oSettings = new System.Xml.XmlReaderSettings();
            oSettings.IgnoreWhitespace = true;
            System.Xml.XmlReader oResponseXmlStream = System.Xml.XmlReader.Create(downloadInfo.ContentStream, oSettings);
            hResponseDocument.Load(oResponseXmlStream);
            downloadInfo.ContentStream.Close();

            // Get the URL, save the image
            XmlElement nOutputElement = hResponseDocument.SelectSingleNode("/ARCXML/RESPONSE/IMAGE/OUTPUT") as XmlElement;
            if (nOutputElement != null)
            {
               String imageURL = nOutputElement.GetAttribute("url");
               Log.Write(Log.Levels.Debug, "ADGR", "Downloading file " + imageURL);
               // ---------------------------
               downloadImage(imageURL, downloadInfo.SavedFilePath);
            }
            else
            {
               XmlElement nErrorElement = hResponseDocument.SelectSingleNode("/ARCXML/RESPONSE/ERROR") as XmlElement;
               Log.Write(Log.Levels.Debug, "ADGR", nErrorElement.InnerText);
            }

            m_tile.TileSet.NumberRetries = 0;
            if (m_tile.IsValidTile(downloadInfo.SavedFilePath) && nOutputElement != null)
            {
               // Rename temp file to real name
               File.Delete(m_localFilePath);

               // Convert the image to a PNG from a GIF so DirectX doesn't throw a hissy fit trying to load gifs
               if (downloadInfo.SavedFilePath.EndsWith(".gif"))
               {
                  Image oConverter = Image.FromFile(downloadInfo.SavedFilePath);
                  oConverter.Save(m_localFilePath, System.Drawing.Imaging.ImageFormat.Png);
                  oConverter.Dispose();
                  File.Delete(downloadInfo.SavedFilePath);
               }
               else
               {
                  File.Move(downloadInfo.SavedFilePath, m_localFilePath);
               }

               // Make the tile reload the new image
               m_tile.DownloadRequests.Remove(this);
               m_tile.Initialize();
            }
            else
            {
               using (File.Create(m_localFilePath + ".txt"))
               { }
               if (File.Exists(downloadInfo.SavedFilePath))
               {
                  try
                  {
                     File.Delete(downloadInfo.SavedFilePath);
                  }
                  catch (Exception e)
                  {
                     Log.Write(Log.Levels.Error, "AGDR", "could not delete file " + downloadInfo.SavedFilePath + ":");
                     Log.Write(e);
                  }
               }
            }
         }
         catch (System.Net.WebException caught)
         {
            System.Net.HttpWebResponse response = caught.Response as System.Net.HttpWebResponse;
            if (response != null && response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
               using (File.Create(m_localFilePath + ".txt"))
               { }
               return;
            }
            m_tile.TileSet.NumberRetries++;
         }
         catch
         {
            using (File.Create(m_localFilePath + ".txt"))
            { }
            if (File.Exists(downloadInfo.SavedFilePath))
            {
               try
               {
                  File.Delete(downloadInfo.SavedFilePath);
               }
               catch (Exception e)
               {
                  Log.Write(Log.Levels.Error, "AGDR", "could not delete file " + downloadInfo.SavedFilePath + ":");
                  Log.Write(e);
               }
            }
         }
         finally
         {
            if (download != null)
               download.IsComplete = true;

            // Immediately queue next download
            m_tile.TileSet.RemoveFromDownloadQueue(this, true);
         }
      }

      private void downloadImage(String strURL, String strFilename)
      {
         WebRequest oRequest = HttpWebRequest.Create(strURL);
         oRequest.Proxy = ProxyHelper.DetermineProxyForUrl(
              strURL,
              WorldWind.Net.WebDownload.useWindowsDefaultProxy,
              WorldWind.Net.WebDownload.useDynamicProxy,
              WorldWind.Net.WebDownload.proxyUrl,
              WorldWind.Net.WebDownload.proxyUserName,
              WorldWind.Net.WebDownload.proxyPassword);

         WebResponse oResponse = oRequest.GetResponse();
         FileStream hLocalFile = new FileStream(strFilename, FileMode.Create);

         byte[] abData = new byte[oResponse.ContentLength];
         int read = 0;
         while (read < abData.Length)
         {
            int readThisLoop = oResponse.GetResponseStream().Read(abData, read, abData.Length - read);
            read += readThisLoop;
         }
         oResponse.Close();

         hLocalFile.Write(abData, 0, abData.Length);
         hLocalFile.Close();
      }
   }

   public abstract class ArcIMSDownload : IndexedWebDownload
   {
      protected ArcIMSServerUri m_oUri;

      protected abstract XmlDocument RequestDocument { get; }
      protected abstract String TargetUrl { get; }

      protected ArcIMSDownload(ArcIMSServerUri oUri, int iIndexNumber) : base(oUri.ToBaseUri(), iIndexNumber)
      {
         m_oUri = oUri;
      }

      protected override HttpWebRequest BuildRequest()
      {
         XmlDocument oRequestDoc = RequestDocument;

         // Create the request object.
         request = (HttpWebRequest)WebRequest.Create(TargetUrl);
         request.UserAgent = UserAgent;
         request.Pipelined = false;

         request.Proxy = ProxyHelper.DetermineProxyForUrl(
                       TargetUrl,
                       WorldWind.Net.WebDownload.useWindowsDefaultProxy,
                       WorldWind.Net.WebDownload.useDynamicProxy,
                       WorldWind.Net.WebDownload.proxyUrl,
                       WorldWind.Net.WebDownload.proxyUserName,
                       WorldWind.Net.WebDownload.proxyPassword);


         // --- Encode the document into ascii ---

         System.Text.UTF8Encoding hRequestEncoding = new System.Text.UTF8Encoding();

         byte[] byte1 = hRequestEncoding.GetBytes(oRequestDoc.OuterXml);

         // --- Setup the HTTP Request ---

         request.Method = "POST";

         if (WorldWind.Net.WebDownload.useProto == WorldWind.Net.WebDownload.HttpProtoVersion.HTTP1_1)
            request.ProtocolVersion = HttpVersion.Version11;
         else
            request.ProtocolVersion = HttpVersion.Version10;

         request.KeepAlive = false;
         request.ContentType = "application/x-www-form-urlencoded";
         request.ContentLength = byte1.Length;

         // --- Serialize the XML document request onto the wire ---

         System.IO.Stream hRequestStream = request.GetRequestStream();
         hRequestStream.Write(byte1, 0, byte1.Length);
         hRequestStream.Close();

         // --- Turn off connection keep-alives. ---

         request.KeepAlive = false;

         return request;
      }
   }

   public class ArcIMSImageDownload : ArcIMSDownload
   {
      public static readonly String TILE_SIZE = "256";

      private ArcIMSImageStore m_oImageStore;
      private Geosoft.Dap.Common.BoundingBox m_oEnvelope;

      public ArcIMSImageDownload(ArcIMSImageStore oImageStore, Geosoft.Dap.Common.BoundingBox oEnvelope, int iIndexNumber)
         :base(oImageStore.ServerUri, iIndexNumber)
      {
         m_oImageStore = oImageStore;
         m_oEnvelope = oEnvelope;
      }

      protected override XmlDocument RequestDocument
      {
         get
         {
            XmlDocument oRequestDoc = new XmlDocument();

            XmlNode nXmlNode = oRequestDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            oRequestDoc.AppendChild(nXmlNode);

            XmlElement nArcIMSElement = oRequestDoc.CreateElement("ARCXML", oRequestDoc.NamespaceURI);
            nArcIMSElement.SetAttribute("version", "1.1");
            XmlElement nRequestElement = oRequestDoc.CreateElement("REQUEST", oRequestDoc.NamespaceURI);
            XmlElement nGetImageElement = oRequestDoc.CreateElement("GET_IMAGE", oRequestDoc.NamespaceURI);
            XmlElement nPropertiesElement = oRequestDoc.CreateElement("PROPERTIES", oRequestDoc.NamespaceURI);

            XmlElement nEnvelopeElement = oRequestDoc.CreateElement("ENVELOPE", oRequestDoc.NamespaceURI);
            nEnvelopeElement.SetAttribute("minx", m_oEnvelope.MinX.ToString());
            nEnvelopeElement.SetAttribute("miny", m_oEnvelope.MinY.ToString());
            nEnvelopeElement.SetAttribute("maxx", m_oEnvelope.MaxX.ToString());
            nEnvelopeElement.SetAttribute("maxy", m_oEnvelope.MaxY.ToString());
            nPropertiesElement.AppendChild(nEnvelopeElement);

            XmlElement nImageSizeElement = oRequestDoc.CreateElement("IMAGESIZE", oRequestDoc.NamespaceURI);
            nImageSizeElement.SetAttribute("width", TILE_SIZE);
            nImageSizeElement.SetAttribute("height", TILE_SIZE);
            nPropertiesElement.AppendChild(nImageSizeElement);

            XmlElement nFeatureCoordSysElement = oRequestDoc.CreateElement("FEATURECOORDSYS", oRequestDoc.NamespaceURI);
            nFeatureCoordSysElement.SetAttribute("id", "4326");
            nPropertiesElement.AppendChild(nFeatureCoordSysElement);

            XmlElement nFilterCoordSys = oRequestDoc.CreateElement("FILTERCOORDSYS", oRequestDoc.NamespaceURI);
            nFilterCoordSys.SetAttribute("id", "4326");
            nPropertiesElement.AppendChild(nFilterCoordSys);

            nGetImageElement.AppendChild(nPropertiesElement);
            nRequestElement.AppendChild(nGetImageElement);
            nArcIMSElement.AppendChild(nRequestElement);
            oRequestDoc.AppendChild(nArcIMSElement);

            return oRequestDoc;
         }
      }

      protected override string TargetUrl
      {
         get
         {
            return m_oUri.ToServiceUri(m_oImageStore.ServiceName);
         }
      }
   }

   public class ArcIMSCatalogDownload : ArcIMSDownload
   {
      public ArcIMSCatalogDownload(ArcIMSServerUri serverUri, int iIndexNumber)
         :base(serverUri, iIndexNumber)
      {
      }

      protected override XmlDocument RequestDocument
      {
         get
         {
            XmlDocument oRequestDoc = new XmlDocument();
            oRequestDoc.AppendChild(oRequestDoc.CreateXmlDeclaration("1.0", "UTF-8", null));
            oRequestDoc.AppendChild(oRequestDoc.CreateElement("GETCLIENTSERVICES", oRequestDoc.NamespaceURI));

            return oRequestDoc;
         }
      }

      protected override string TargetUrl
      {
         get
         {
            return m_oUri.ToCatalogUri();
         }
      }
   }

   public class ArcIMSServiceDownload : ArcIMSDownload
   {
      private String m_strServiceName;

      public ArcIMSServiceDownload(ArcIMSServerUri oUri, String serviceName, int iIndexNumber)
         : base(oUri, iIndexNumber)
      {
         m_strServiceName = serviceName;
      }

      protected override XmlDocument RequestDocument
      {
         get
         {
            XmlDocument oRequestDoc = new XmlDocument();

            XmlNode nXmlNode = oRequestDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
            oRequestDoc.AppendChild(nXmlNode);

            XmlElement nArcIMSElement = oRequestDoc.CreateElement("ARCXML", oRequestDoc.NamespaceURI);
            nArcIMSElement.SetAttribute("version", "1.1");
            XmlElement nRequestElement = oRequestDoc.CreateElement("REQUEST", oRequestDoc.NamespaceURI);
            XmlElement nGetServiceInfoElement = oRequestDoc.CreateElement("GET_SERVICE_INFO", oRequestDoc.NamespaceURI);
            nRequestElement.AppendChild(nGetServiceInfoElement);
            nArcIMSElement.AppendChild(nRequestElement);
            oRequestDoc.AppendChild(nArcIMSElement);

            return oRequestDoc;
         }
      }

      protected override string TargetUrl
      {
         get
         {
            return m_oUri.ToServiceUri(m_strServiceName) ;
         }
      }
   }

   public class ArcIMSImageStore : ImageStore
   {
      private String m_strServiceName;
      private ArcIMSServerUri m_oUri;

      public ArcIMSImageStore(String strServiceName, ArcIMSServerUri oUri)
      {
         m_oUri = oUri;
         m_strServiceName = strServiceName;
      }

      public String ServiceName
      {
         get { return m_strServiceName; }
      }

      public ArcIMSServerUri ServerUri
      {
         get { return m_oUri; }
      }

      public override bool IsDownloadableLayer
      {
         get { return true; }
      }

      protected override void QueueDownload(IGeoSpatialDownloadTile oTile, string strLocalFilePath)
      {
         oTile.TileSet.AddToDownloadQueue(oTile.TileSet.Camera,
            new ArcIMSDownloadRequest(oTile, this, strLocalFilePath));
      }
   }
}