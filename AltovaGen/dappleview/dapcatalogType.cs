//
// dapcatalogType.cs
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

namespace dappleview
{
	public class dapcatalogType : Altova.Xml.Node
	{
		#region Documentation
		public static string GetAnnoDocumentation() { return ""; }
		#endregion

		#region Forward constructors

		public dapcatalogType() : base() { SetCollectionParents(); }

		public dapcatalogType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public dapcatalogType(XmlNode node) : base(node) { SetCollectionParents(); }
		public dapcatalogType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public dapcatalogType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Attribute, "", "url" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Attribute, "", "url", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "dapcatalog");
		}


		#region url Documentation
		public static string GeturlAnnoDocumentation()
		{
			return "";		
		}
		public static string GeturlDefault()
		{
			return "";		
		}
		#endregion

		#region url accessor methods
		public static int GeturlMinCount()
		{
			return 1;
		}

		public static int urlMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GeturlMaxCount()
		{
			return 1;
		}

		public static int urlMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GeturlCount()
		{
			return DomChildCount(NodeType.Attribute, "", "url");
		}

		public int urlCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "url");
			}
		}

		public bool Hasurl()
		{
			return HasDomChild(NodeType.Attribute, "", "url");
		}

		public SchemaString Newurl()
		{
			return new SchemaString();
		}

		public SchemaString GeturlAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "url", index)));
		}

		public XmlNode GetStartingurlCursor()
		{
			return GetDomFirstChild( NodeType.Attribute, "", "url" );
		}

		public XmlNode GetAdvancedurlCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Attribute, "", "url", curNode );
		}

		public SchemaString GeturlValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaString( curNode.Value );
		}


		public SchemaString Geturl()
		{
			return GeturlAt(0);
		}

		public SchemaString url
		{
			get
			{
				return GeturlAt(0);
			}
		}

		public void RemoveurlAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "url", index);
		}

		public void Removeurl()
		{
			RemoveurlAt(0);
		}

		public XmlNode Addurl(SchemaString newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Attribute, "", "url", newValue.ToString());
			return null;
		}

		public void InserturlAt(SchemaString newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Attribute, "", "url", index, newValue.ToString());
		}

		public void ReplaceurlAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "url", index, newValue.ToString());
		}
		#endregion // url accessor methods

		#region url collection
        public urlCollection	Myurls = new urlCollection( );

        public class urlCollection: IEnumerable
        {
            dapcatalogType parent;
            public dapcatalogType Parent
			{
				set
				{
					parent = value;
				}
			}
			public urlEnumerator GetEnumerator() 
			{
				return new urlEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class urlEnumerator: IEnumerator 
        {
			int nIndex;
			dapcatalogType parent;
			public urlEnumerator(dapcatalogType par) 
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
				return(nIndex < parent.urlCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GeturlAt(nIndex));
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

        #endregion // url collection

        private void SetCollectionParents()
        {
            Myurls.Parent = this; 
	}
}
}
