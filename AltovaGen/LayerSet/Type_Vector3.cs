//
// Type_Vector3.cs
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
	public class Type_Vector3 : Altova.Xml.Node
	{
		#region Documentation
		public static string GetAnnoDocumentation() { return ""; }
		#endregion

		#region Forward constructors

		public Type_Vector3() : base() { SetCollectionParents(); }

		public Type_Vector3(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public Type_Vector3(XmlNode node) : base(node) { SetCollectionParents(); }
		public Type_Vector3(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public Type_Vector3(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "x" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "x", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "y" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "y", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "z" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "z", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "Type_Vector3");
		}


		#region x Documentation
		public static string GetxAnnoDocumentation()
		{
			return "";		
		}
		public static string GetxDefault()
		{
			return "";		
		}
		#endregion

		#region x accessor methods
		public static int GetxMinCount()
		{
			return 1;
		}

		public static int xMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetxMaxCount()
		{
			return 1;
		}

		public static int xMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetxCount()
		{
			return DomChildCount(NodeType.Element, "", "x");
		}

		public int xCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "x");
			}
		}

		public bool Hasx()
		{
			return HasDomChild(NodeType.Element, "", "x");
		}

		public SchemaDouble Newx()
		{
			return new SchemaDouble();
		}

		public SchemaDouble GetxAt(int index)
		{
			return new SchemaDouble(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "x", index)));
		}

		public XmlNode GetStartingxCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "x" );
		}

		public XmlNode GetAdvancedxCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "x", curNode );
		}

		public SchemaDouble GetxValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaDouble( curNode.InnerText );
		}


		public SchemaDouble Getx()
		{
			return GetxAt(0);
		}

		public SchemaDouble x
		{
			get
			{
				return GetxAt(0);
			}
		}

		public void RemovexAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "x", index);
		}

		public void Removex()
		{
			RemovexAt(0);
		}

		public XmlNode Addx(SchemaDouble newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "x", newValue.ToString());
			return null;
		}

		public void InsertxAt(SchemaDouble newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "x", index, newValue.ToString());
		}

		public void ReplacexAt(SchemaDouble newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "x", index, newValue.ToString());
		}
		#endregion // x accessor methods

		#region x collection
        public xCollection	Myxs = new xCollection( );

        public class xCollection: IEnumerable
        {
            Type_Vector3 parent;
            public Type_Vector3 Parent
			{
				set
				{
					parent = value;
				}
			}
			public xEnumerator GetEnumerator() 
			{
				return new xEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class xEnumerator: IEnumerator 
        {
			int nIndex;
			Type_Vector3 parent;
			public xEnumerator(Type_Vector3 par) 
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
				return(nIndex < parent.xCount );
			}
			public SchemaDouble  Current 
			{
				get 
				{
					return(parent.GetxAt(nIndex));
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

        #endregion // x collection

		#region y Documentation
		public static string GetyAnnoDocumentation()
		{
			return "";		
		}
		public static string GetyDefault()
		{
			return "";		
		}
		#endregion

		#region y accessor methods
		public static int GetyMinCount()
		{
			return 1;
		}

		public static int yMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetyMaxCount()
		{
			return 1;
		}

		public static int yMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetyCount()
		{
			return DomChildCount(NodeType.Element, "", "y");
		}

		public int yCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "y");
			}
		}

		public bool Hasy()
		{
			return HasDomChild(NodeType.Element, "", "y");
		}

		public SchemaDouble Newy()
		{
			return new SchemaDouble();
		}

		public SchemaDouble GetyAt(int index)
		{
			return new SchemaDouble(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "y", index)));
		}

		public XmlNode GetStartingyCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "y" );
		}

		public XmlNode GetAdvancedyCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "y", curNode );
		}

		public SchemaDouble GetyValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaDouble( curNode.InnerText );
		}


		public SchemaDouble Gety()
		{
			return GetyAt(0);
		}

		public SchemaDouble y
		{
			get
			{
				return GetyAt(0);
			}
		}

		public void RemoveyAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "y", index);
		}

		public void Removey()
		{
			RemoveyAt(0);
		}

		public XmlNode Addy(SchemaDouble newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "y", newValue.ToString());
			return null;
		}

		public void InsertyAt(SchemaDouble newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "y", index, newValue.ToString());
		}

		public void ReplaceyAt(SchemaDouble newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "y", index, newValue.ToString());
		}
		#endregion // y accessor methods

		#region y collection
        public yCollection	Myys = new yCollection( );

        public class yCollection: IEnumerable
        {
            Type_Vector3 parent;
            public Type_Vector3 Parent
			{
				set
				{
					parent = value;
				}
			}
			public yEnumerator GetEnumerator() 
			{
				return new yEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class yEnumerator: IEnumerator 
        {
			int nIndex;
			Type_Vector3 parent;
			public yEnumerator(Type_Vector3 par) 
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
				return(nIndex < parent.yCount );
			}
			public SchemaDouble  Current 
			{
				get 
				{
					return(parent.GetyAt(nIndex));
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

        #endregion // y collection

		#region z Documentation
		public static string GetzAnnoDocumentation()
		{
			return "";		
		}
		public static string GetzDefault()
		{
			return "";		
		}
		#endregion

		#region z accessor methods
		public static int GetzMinCount()
		{
			return 1;
		}

		public static int zMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetzMaxCount()
		{
			return 1;
		}

		public static int zMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetzCount()
		{
			return DomChildCount(NodeType.Element, "", "z");
		}

		public int zCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "z");
			}
		}

		public bool Hasz()
		{
			return HasDomChild(NodeType.Element, "", "z");
		}

		public SchemaDouble Newz()
		{
			return new SchemaDouble();
		}

		public SchemaDouble GetzAt(int index)
		{
			return new SchemaDouble(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "z", index)));
		}

		public XmlNode GetStartingzCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "z" );
		}

		public XmlNode GetAdvancedzCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "z", curNode );
		}

		public SchemaDouble GetzValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaDouble( curNode.InnerText );
		}


		public SchemaDouble Getz()
		{
			return GetzAt(0);
		}

		public SchemaDouble z
		{
			get
			{
				return GetzAt(0);
			}
		}

		public void RemovezAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "z", index);
		}

		public void Removez()
		{
			RemovezAt(0);
		}

		public XmlNode Addz(SchemaDouble newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "", "z", newValue.ToString());
			return null;
		}

		public void InsertzAt(SchemaDouble newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "", "z", index, newValue.ToString());
		}

		public void ReplacezAt(SchemaDouble newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "z", index, newValue.ToString());
		}
		#endregion // z accessor methods

		#region z collection
        public zCollection	Myzs = new zCollection( );

        public class zCollection: IEnumerable
        {
            Type_Vector3 parent;
            public Type_Vector3 Parent
			{
				set
				{
					parent = value;
				}
			}
			public zEnumerator GetEnumerator() 
			{
				return new zEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class zEnumerator: IEnumerator 
        {
			int nIndex;
			Type_Vector3 parent;
			public zEnumerator(Type_Vector3 par) 
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
				return(nIndex < parent.zCount );
			}
			public SchemaDouble  Current 
			{
				get 
				{
					return(parent.GetzAt(nIndex));
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

        #endregion // z collection

        private void SetCollectionParents()
        {
            Myxs.Parent = this; 
            Myys.Parent = this; 
            Myzs.Parent = this; 
	}
}
}
