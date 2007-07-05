//
// LegendURLType.cs
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

namespace capabilities_1_3_0.wms
{
	public class LegendURLType : Altova.Xml.Node
	{
		#region Documentation
	/*
		public static string GetAnnoDocumentation() { return ""; }
	 */ 
		#endregion

		#region Forward constructors

		public LegendURLType() : base() { SetCollectionParents(); }

		public LegendURLType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public LegendURLType(XmlNode node) : base(node) { SetCollectionParents(); }
		public LegendURLType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public LegendURLType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Attribute, "", "width" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Attribute, "", "width", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Attribute, "", "height" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Attribute, "", "height", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.opengis.net/wms", "Format" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.opengis.net/wms", "Format", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.opengis.net/wms", "OnlineResource" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.opengis.net/wms", "OnlineResource", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
				new OnlineResourceType(DOMNode).AdjustPrefix();
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "wms:LegendURL");
		}


		#region width Documentation
/*
		public static string GetwidthAnnoDocumentation()
		{
			return "";		
		}
 */ 
		public static string GetwidthDefault()
		{
			return "";		
		}
		#endregion

		#region width accessor methods
		public static int GetwidthMinCount()
		{
			return 0;
		}

		public static int widthMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetwidthMaxCount()
		{
			return 1;
		}

		public static int widthMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetwidthCount()
		{
			return DomChildCount(NodeType.Attribute, "", "width");
		}

		public int widthCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "width");
			}
		}

		public bool Haswidth()
		{
			return HasDomChild(NodeType.Attribute, "", "width");
		}

		public SchemaLong Newwidth()
		{
			return new SchemaLong();
		}

		public SchemaLong GetwidthAt(int index)
		{
			return new SchemaLong(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "width", index)));
		}

		public XmlNode GetStartingwidthCursor()
		{
			return GetDomFirstChild( NodeType.Attribute, "", "width" );
		}

		public XmlNode GetAdvancedwidthCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Attribute, "", "width", curNode );
		}

		public SchemaLong GetwidthValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaLong( curNode.Value );
		}


		public SchemaLong Getwidth()
		{
			return GetwidthAt(0);
		}

		public SchemaLong width
		{
			get
			{
				return GetwidthAt(0);
			}
		}

		public void RemovewidthAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "width", index);
		}

		public void Removewidth()
		{
			RemovewidthAt(0);
		}

		public XmlNode Addwidth(SchemaLong newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Attribute, "", "width", newValue.ToString());
			return null;
		}

		public void InsertwidthAt(SchemaLong newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Attribute, "", "width", index, newValue.ToString());
		}

		public void ReplacewidthAt(SchemaLong newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "width", index, newValue.ToString());
		}
		#endregion // width accessor methods

		#region width collection
        public widthCollection	Mywidths = new widthCollection( );

        public class widthCollection: IEnumerable
        {
            LegendURLType parent;
            public LegendURLType Parent
			{
				set
				{
					parent = value;
				}
			}
			public widthEnumerator GetEnumerator() 
			{
				return new widthEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class widthEnumerator: IEnumerator 
        {
			int nIndex;
			LegendURLType parent;
			public widthEnumerator(LegendURLType par) 
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
				return(nIndex < parent.widthCount );
			}
			public SchemaLong  Current 
			{
				get 
				{
					return(parent.GetwidthAt(nIndex));
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

        #endregion // width collection

		#region height Documentation
/*
		public static string GetheightAnnoDocumentation()
		{
			return "";		
		}
 */ 
		public static string GetheightDefault()
		{
			return "";		
		}
		#endregion

		#region height accessor methods
		public static int GetheightMinCount()
		{
			return 0;
		}

		public static int heightMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetheightMaxCount()
		{
			return 1;
		}

		public static int heightMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetheightCount()
		{
			return DomChildCount(NodeType.Attribute, "", "height");
		}

		public int heightCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "height");
			}
		}

		public bool Hasheight()
		{
			return HasDomChild(NodeType.Attribute, "", "height");
		}

		public SchemaLong Newheight()
		{
			return new SchemaLong();
		}

		public SchemaLong GetheightAt(int index)
		{
			return new SchemaLong(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "height", index)));
		}

		public XmlNode GetStartingheightCursor()
		{
			return GetDomFirstChild( NodeType.Attribute, "", "height" );
		}

		public XmlNode GetAdvancedheightCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Attribute, "", "height", curNode );
		}

		public SchemaLong GetheightValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaLong( curNode.Value );
		}


		public SchemaLong Getheight()
		{
			return GetheightAt(0);
		}

		public SchemaLong height
		{
			get
			{
				return GetheightAt(0);
			}
		}

		public void RemoveheightAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "height", index);
		}

		public void Removeheight()
		{
			RemoveheightAt(0);
		}

		public XmlNode Addheight(SchemaLong newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Attribute, "", "height", newValue.ToString());
			return null;
		}

		public void InsertheightAt(SchemaLong newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Attribute, "", "height", index, newValue.ToString());
		}

		public void ReplaceheightAt(SchemaLong newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "height", index, newValue.ToString());
		}
		#endregion // height accessor methods

		#region height collection
        public heightCollection	Myheights = new heightCollection( );

        public class heightCollection: IEnumerable
        {
            LegendURLType parent;
            public LegendURLType Parent
			{
				set
				{
					parent = value;
				}
			}
			public heightEnumerator GetEnumerator() 
			{
				return new heightEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class heightEnumerator: IEnumerator 
        {
			int nIndex;
			LegendURLType parent;
			public heightEnumerator(LegendURLType par) 
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
				return(nIndex < parent.heightCount );
			}
			public SchemaLong  Current 
			{
				get 
				{
					return(parent.GetheightAt(nIndex));
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

        #endregion // height collection

		#region Format Documentation
/*
		public static string GetFormatAnnoDocumentation()
		{
			return "
        A container for listing an available format's MIME type.
      ";		
		}
 */ 
		public static string GetFormatDefault()
		{
			return "";		
		}
		#endregion

		#region Format accessor methods
		public static int GetFormatMinCount()
		{
			return 1;
		}

		public static int FormatMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetFormatMaxCount()
		{
			return 1;
		}

		public static int FormatMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFormatCount()
		{
			return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Format");
		}

		public int FormatCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Format");
			}
		}

		public bool HasFormat()
		{
			return HasDomChild(NodeType.Element, "http://www.opengis.net/wms", "Format");
		}

		public SchemaString NewFormat()
		{
			return new SchemaString();
		}

		public SchemaString GetFormatAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Format", index)));
		}

		public XmlNode GetStartingFormatCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.opengis.net/wms", "Format" );
		}

		public XmlNode GetAdvancedFormatCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.opengis.net/wms", "Format", curNode );
		}

		public SchemaString GetFormatValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaString( curNode.InnerText );
		}


		public SchemaString GetFormat()
		{
			return GetFormatAt(0);
		}

		public SchemaString Format
		{
			get
			{
				return GetFormatAt(0);
			}
		}

		public void RemoveFormatAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Format", index);
		}

		public void RemoveFormat()
		{
			RemoveFormatAt(0);
		}

		public XmlNode AddFormat(SchemaString newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.opengis.net/wms", "Format", newValue.ToString());
			return null;
		}

		public void InsertFormatAt(SchemaString newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Format", index, newValue.ToString());
		}

		public void ReplaceFormatAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Format", index, newValue.ToString());
		}
		#endregion // Format accessor methods

		#region Format collection
        public FormatCollection	MyFormats = new FormatCollection( );

        public class FormatCollection: IEnumerable
        {
            LegendURLType parent;
            public LegendURLType Parent
			{
				set
				{
					parent = value;
				}
			}
			public FormatEnumerator GetEnumerator() 
			{
				return new FormatEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class FormatEnumerator: IEnumerator 
        {
			int nIndex;
			LegendURLType parent;
			public FormatEnumerator(LegendURLType par) 
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
				return(nIndex < parent.FormatCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetFormatAt(nIndex));
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

        #endregion // Format collection

		#region OnlineResource Documentation
/*
		public static string GetOnlineResourceAnnoDocumentation()
		{
			return "
        An OnlineResource is typically an HTTP URL.  The URL is placed in
        the xlink:href attribute, and the value "simple" is placed in the
        xlink:type attribute.
      ";		
		}
 */ 
		public static string GetOnlineResourceDefault()
		{
			return "";		
		}
		#endregion

		#region OnlineResource accessor methods
		public static int GetOnlineResourceMinCount()
		{
			return 1;
		}

		public static int OnlineResourceMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetOnlineResourceMaxCount()
		{
			return 1;
		}

		public static int OnlineResourceMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetOnlineResourceCount()
		{
			return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource");
		}

		public int OnlineResourceCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource");
			}
		}

		public bool HasOnlineResource()
		{
			return HasDomChild(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource");
		}

		public OnlineResourceType NewOnlineResource()
		{
			return new OnlineResourceType(domNode.OwnerDocument.CreateElement("OnlineResource", "http://www.opengis.net/wms"));
		}

		public OnlineResourceType GetOnlineResourceAt(int index)
		{
			return new OnlineResourceType(GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource", index));
		}

		public XmlNode GetStartingOnlineResourceCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.opengis.net/wms", "OnlineResource" );
		}

		public XmlNode GetAdvancedOnlineResourceCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.opengis.net/wms", "OnlineResource", curNode );
		}

		public OnlineResourceType GetOnlineResourceValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new OnlineResourceType( curNode );
		}


		public OnlineResourceType GetOnlineResource()
		{
			return GetOnlineResourceAt(0);
		}

		public OnlineResourceType OnlineResource
		{
			get
			{
				return GetOnlineResourceAt(0);
			}
		}

		public void RemoveOnlineResourceAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource", index);
		}

		public void RemoveOnlineResource()
		{
			RemoveOnlineResourceAt(0);
		}

		public XmlNode AddOnlineResource(OnlineResourceType newValue)
		{
			return AppendDomElement("http://www.opengis.net/wms", "OnlineResource", newValue);
		}

		public void InsertOnlineResourceAt(OnlineResourceType newValue, int index)
		{
			InsertDomElementAt("http://www.opengis.net/wms", "OnlineResource", index, newValue);
		}

		public void ReplaceOnlineResourceAt(OnlineResourceType newValue, int index)
		{
			ReplaceDomElementAt("http://www.opengis.net/wms", "OnlineResource", index, newValue);
		}
		#endregion // OnlineResource accessor methods

		#region OnlineResource collection
        public OnlineResourceCollection	MyOnlineResources = new OnlineResourceCollection( );

        public class OnlineResourceCollection: IEnumerable
        {
            LegendURLType parent;
            public LegendURLType Parent
			{
				set
				{
					parent = value;
				}
			}
			public OnlineResourceEnumerator GetEnumerator() 
			{
				return new OnlineResourceEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class OnlineResourceEnumerator: IEnumerator 
        {
			int nIndex;
			LegendURLType parent;
			public OnlineResourceEnumerator(LegendURLType par) 
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
				return(nIndex < parent.OnlineResourceCount );
			}
			public OnlineResourceType  Current 
			{
				get 
				{
					return(parent.GetOnlineResourceAt(nIndex));
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

        #endregion // OnlineResource collection

        private void SetCollectionParents()
        {
            Mywidths.Parent = this; 
            Myheights.Parent = this; 
            MyFormats.Parent = this; 
            MyOnlineResources.Parent = this; 
	}
}
}
