//
// Type_ImageTileService.cs
//
// This file was generated by XMLSpy 2007r3 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;
using Altova.Types;

namespace LayerSet
{
	public class Type_ImageTileService : Altova.Xml.Node
	{
		#region Documentation
		public static string GetAnnoDocumentation() { return ""; }
		#endregion

		#region Forward constructors

		public Type_ImageTileService() : base() { SetCollectionParents(); }

		public Type_ImageTileService(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public Type_ImageTileService(XmlNode node) : base(node) { SetCollectionParents(); }
		public Type_ImageTileService(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public Type_ImageTileService(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "ServerUrl" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "ServerUrl", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "DataSetName" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "DataSetName", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "CacheExpirationTime" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "CacheExpirationTime", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
				new Type_SimpleTimeSpan(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "ServerLogoFilePath" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "ServerLogoFilePath", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "Type_ImageTileService");
		}


		#region ServerUrl Documentation
		public static string GetServerUrlAnnoDocumentation()
		{
			return "";		
		}
		public static string GetServerUrlDefault()
		{
			return "";		
		}
		#endregion

		#region ServerUrl accessor methods
		public static int GetServerUrlMinCount()
		{
			return 1;
		}

		public static int ServerUrlMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetServerUrlMaxCount()
		{
			return 1;
		}

		public static int ServerUrlMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetServerUrlCount()
		{
			return DomChildCount(NodeType.Element, "", "ServerUrl");
		}

		public int ServerUrlCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "ServerUrl");
			}
		}

		public bool HasServerUrl()
		{
			return HasDomChild(NodeType.Element, "", "ServerUrl");
		}

		public SchemaString NewServerUrl()
		{
			return new SchemaString();
		}

		public SchemaString GetServerUrlAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "ServerUrl", index)));
		}

		public XmlNode GetStartingServerUrlCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "ServerUrl" );
		}

		public XmlNode GetAdvancedServerUrlCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "ServerUrl", curNode );
		}

		public SchemaString GetServerUrlValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaString( curNode.InnerText );
		}


		public SchemaString GetServerUrl()
		{
			return GetServerUrlAt(0);
		}

		public SchemaString ServerUrl
		{
			get
			{
				return GetServerUrlAt(0);
			}
		}

		public void RemoveServerUrlAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "ServerUrl", index);
		}

		public void RemoveServerUrl()
		{
			RemoveServerUrlAt(0);
		}

		public XmlNode AddServerUrl(SchemaString newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "ServerUrl", newValue.ToString());
			return null;
		}

		public void InsertServerUrlAt(SchemaString newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "ServerUrl", index, newValue.ToString());
		}

		public void ReplaceServerUrlAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "ServerUrl", index, newValue.ToString());
		}
		#endregion // ServerUrl accessor methods

		#region ServerUrl collection
        public ServerUrlCollection	MyServerUrls = new ServerUrlCollection( );

        public class ServerUrlCollection: IEnumerable
        {
            Type_ImageTileService parent;
            public Type_ImageTileService Parent
			{
				set
				{
					parent = value;
				}
			}
			public ServerUrlEnumerator GetEnumerator() 
			{
				return new ServerUrlEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ServerUrlEnumerator: IEnumerator 
        {
			int nIndex;
			Type_ImageTileService parent;
			public ServerUrlEnumerator(Type_ImageTileService par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.ServerUrlCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetServerUrlAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // ServerUrl collection

		#region DataSetName Documentation
		public static string GetDataSetNameAnnoDocumentation()
		{
			return "";		
		}
		public static string GetDataSetNameDefault()
		{
			return "";		
		}
		#endregion

		#region DataSetName accessor methods
		public static int GetDataSetNameMinCount()
		{
			return 1;
		}

		public static int DataSetNameMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetDataSetNameMaxCount()
		{
			return 1;
		}

		public static int DataSetNameMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDataSetNameCount()
		{
			return DomChildCount(NodeType.Element, "", "DataSetName");
		}

		public int DataSetNameCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "DataSetName");
			}
		}

		public bool HasDataSetName()
		{
			return HasDomChild(NodeType.Element, "", "DataSetName");
		}

		public SchemaString NewDataSetName()
		{
			return new SchemaString();
		}

		public SchemaString GetDataSetNameAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "DataSetName", index)));
		}

		public XmlNode GetStartingDataSetNameCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "DataSetName" );
		}

		public XmlNode GetAdvancedDataSetNameCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "DataSetName", curNode );
		}

		public SchemaString GetDataSetNameValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaString( curNode.InnerText );
		}


		public SchemaString GetDataSetName()
		{
			return GetDataSetNameAt(0);
		}

		public SchemaString DataSetName
		{
			get
			{
				return GetDataSetNameAt(0);
			}
		}

		public void RemoveDataSetNameAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "DataSetName", index);
		}

		public void RemoveDataSetName()
		{
			RemoveDataSetNameAt(0);
		}

		public XmlNode AddDataSetName(SchemaString newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "DataSetName", newValue.ToString());
			return null;
		}

		public void InsertDataSetNameAt(SchemaString newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "DataSetName", index, newValue.ToString());
		}

		public void ReplaceDataSetNameAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "DataSetName", index, newValue.ToString());
		}
		#endregion // DataSetName accessor methods

		#region DataSetName collection
        public DataSetNameCollection	MyDataSetNames = new DataSetNameCollection( );

        public class DataSetNameCollection: IEnumerable
        {
            Type_ImageTileService parent;
            public Type_ImageTileService Parent
			{
				set
				{
					parent = value;
				}
			}
			public DataSetNameEnumerator GetEnumerator() 
			{
				return new DataSetNameEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class DataSetNameEnumerator: IEnumerator 
        {
			int nIndex;
			Type_ImageTileService parent;
			public DataSetNameEnumerator(Type_ImageTileService par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.DataSetNameCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetDataSetNameAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // DataSetName collection

		#region CacheExpirationTime Documentation
		public static string GetCacheExpirationTimeAnnoDocumentation()
		{
			return "";		
		}
		public static string GetCacheExpirationTimeDefault()
		{
			return "";		
		}
		#endregion

		#region CacheExpirationTime accessor methods
		public static int GetCacheExpirationTimeMinCount()
		{
			return 0;
		}

		public static int CacheExpirationTimeMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetCacheExpirationTimeMaxCount()
		{
			return 1;
		}

		public static int CacheExpirationTimeMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCacheExpirationTimeCount()
		{
			return DomChildCount(NodeType.Element, "", "CacheExpirationTime");
		}

		public int CacheExpirationTimeCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "CacheExpirationTime");
			}
		}

		public bool HasCacheExpirationTime()
		{
			return HasDomChild(NodeType.Element, "", "CacheExpirationTime");
		}

		public Type_SimpleTimeSpan NewCacheExpirationTime()
		{
			return new Type_SimpleTimeSpan(domNode.OwnerDocument.CreateElement("CacheExpirationTime", ""));
		}

		public Type_SimpleTimeSpan GetCacheExpirationTimeAt(int index)
		{
			return new Type_SimpleTimeSpan(GetDomChildAt(NodeType.Element, "", "CacheExpirationTime", index));
		}

		public XmlNode GetStartingCacheExpirationTimeCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "CacheExpirationTime" );
		}

		public XmlNode GetAdvancedCacheExpirationTimeCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "CacheExpirationTime", curNode );
		}

		public Type_SimpleTimeSpan GetCacheExpirationTimeValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new Type_SimpleTimeSpan( curNode );
		}


		public Type_SimpleTimeSpan GetCacheExpirationTime()
		{
			return GetCacheExpirationTimeAt(0);
		}

		public Type_SimpleTimeSpan CacheExpirationTime
		{
			get
			{
				return GetCacheExpirationTimeAt(0);
			}
		}

		public void RemoveCacheExpirationTimeAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "CacheExpirationTime", index);
		}

		public void RemoveCacheExpirationTime()
		{
			RemoveCacheExpirationTimeAt(0);
		}

		public XmlNode AddCacheExpirationTime(Type_SimpleTimeSpan newValue)
		{
			return AppendDomElement("", "CacheExpirationTime", newValue);
		}

		public void InsertCacheExpirationTimeAt(Type_SimpleTimeSpan newValue, int index)
		{
			InsertDomElementAt("", "CacheExpirationTime", index, newValue);
		}

		public void ReplaceCacheExpirationTimeAt(Type_SimpleTimeSpan newValue, int index)
		{
			ReplaceDomElementAt("", "CacheExpirationTime", index, newValue);
		}
		#endregion // CacheExpirationTime accessor methods

		#region CacheExpirationTime collection
        public CacheExpirationTimeCollection	MyCacheExpirationTimes = new CacheExpirationTimeCollection( );

        public class CacheExpirationTimeCollection: IEnumerable
        {
            Type_ImageTileService parent;
            public Type_ImageTileService Parent
			{
				set
				{
					parent = value;
				}
			}
			public CacheExpirationTimeEnumerator GetEnumerator() 
			{
				return new CacheExpirationTimeEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class CacheExpirationTimeEnumerator: IEnumerator 
        {
			int nIndex;
			Type_ImageTileService parent;
			public CacheExpirationTimeEnumerator(Type_ImageTileService par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.CacheExpirationTimeCount );
			}
			public Type_SimpleTimeSpan  Current 
			{
				get 
				{
					return(parent.GetCacheExpirationTimeAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // CacheExpirationTime collection

		#region ServerLogoFilePath Documentation
		public static string GetServerLogoFilePathAnnoDocumentation()
		{
			return "";		
		}
		public static string GetServerLogoFilePathDefault()
		{
			return "";		
		}
		#endregion

		#region ServerLogoFilePath accessor methods
		public static int GetServerLogoFilePathMinCount()
		{
			return 0;
		}

		public static int ServerLogoFilePathMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetServerLogoFilePathMaxCount()
		{
			return 1;
		}

		public static int ServerLogoFilePathMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetServerLogoFilePathCount()
		{
			return DomChildCount(NodeType.Element, "", "ServerLogoFilePath");
		}

		public int ServerLogoFilePathCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "ServerLogoFilePath");
			}
		}

		public bool HasServerLogoFilePath()
		{
			return HasDomChild(NodeType.Element, "", "ServerLogoFilePath");
		}

		public SchemaString NewServerLogoFilePath()
		{
			return new SchemaString();
		}

		public SchemaString GetServerLogoFilePathAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "ServerLogoFilePath", index)));
		}

		public XmlNode GetStartingServerLogoFilePathCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "ServerLogoFilePath" );
		}

		public XmlNode GetAdvancedServerLogoFilePathCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "ServerLogoFilePath", curNode );
		}

		public SchemaString GetServerLogoFilePathValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaString( curNode.InnerText );
		}


		public SchemaString GetServerLogoFilePath()
		{
			return GetServerLogoFilePathAt(0);
		}

		public SchemaString ServerLogoFilePath
		{
			get
			{
				return GetServerLogoFilePathAt(0);
			}
		}

		public void RemoveServerLogoFilePathAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "ServerLogoFilePath", index);
		}

		public void RemoveServerLogoFilePath()
		{
			RemoveServerLogoFilePathAt(0);
		}

		public XmlNode AddServerLogoFilePath(SchemaString newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "ServerLogoFilePath", newValue.ToString());
			return null;
		}

		public void InsertServerLogoFilePathAt(SchemaString newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "ServerLogoFilePath", index, newValue.ToString());
		}

		public void ReplaceServerLogoFilePathAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "ServerLogoFilePath", index, newValue.ToString());
		}
		#endregion // ServerLogoFilePath accessor methods

		#region ServerLogoFilePath collection
        public ServerLogoFilePathCollection	MyServerLogoFilePaths = new ServerLogoFilePathCollection( );

        public class ServerLogoFilePathCollection: IEnumerable
        {
            Type_ImageTileService parent;
            public Type_ImageTileService Parent
			{
				set
				{
					parent = value;
				}
			}
			public ServerLogoFilePathEnumerator GetEnumerator() 
			{
				return new ServerLogoFilePathEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ServerLogoFilePathEnumerator: IEnumerator 
        {
			int nIndex;
			Type_ImageTileService parent;
			public ServerLogoFilePathEnumerator(Type_ImageTileService par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.ServerLogoFilePathCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetServerLogoFilePathAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // ServerLogoFilePath collection

        private void SetCollectionParents()
        {
            MyServerUrls.Parent = this; 
            MyDataSetNames.Parent = this; 
            MyCacheExpirationTimes.Parent = this; 
            MyServerLogoFilePaths.Parent = this; 
	}
}
}
