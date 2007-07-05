//
// KeywordType.cs
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
	public class KeywordType : Altova.Xml.Node
	{
		#region Documentation
	/*
		public static string GetAnnoDocumentation() { return ""; }
	 */ 
		#endregion

		#region Forward constructors

		public KeywordType() : base() { SetCollectionParents(); }

		public KeywordType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public KeywordType(XmlNode node) : base(node) { SetCollectionParents(); }
		public KeywordType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public KeywordType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		#region Value accessor methods
		public SchemaString GetValue()
		{
			return new SchemaString(GetDomNodeValue(domNode));
		}

		public void SetValue(ISchemaType newValue)
		{
			SetDomNodeValue(domNode, newValue.ToString());
		}

		public void Assign(ISchemaType newValue)
		{
			SetValue(newValue);
		}

		public SchemaString Value
		{
			get
			{
				return new SchemaString(GetDomNodeValue(domNode));
			}
			set
			{
				SetDomNodeValue(domNode, value.ToString());
			}
		}
		#endregion // Value accessor methods

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Attribute, "", "vocabulary" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Attribute, "", "vocabulary", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, false);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "wms:Keyword");
		}


		#region vocabulary Documentation
/*
		public static string GetvocabularyAnnoDocumentation()
		{
			return "";		
		}
 */ 
		public static string GetvocabularyDefault()
		{
			return "";		
		}
		#endregion

		#region vocabulary accessor methods
		public static int GetvocabularyMinCount()
		{
			return 0;
		}

		public static int vocabularyMinCount
		{
			get
			{
				return 0;
			}
		}

		public static int GetvocabularyMaxCount()
		{
			return 1;
		}

		public static int vocabularyMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetvocabularyCount()
		{
			return DomChildCount(NodeType.Attribute, "", "vocabulary");
		}

		public int vocabularyCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "vocabulary");
			}
		}

		public bool Hasvocabulary()
		{
			return HasDomChild(NodeType.Attribute, "", "vocabulary");
		}

		public SchemaString Newvocabulary()
		{
			return new SchemaString();
		}

		public SchemaString GetvocabularyAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "vocabulary", index)));
		}

		public XmlNode GetStartingvocabularyCursor()
		{
			return GetDomFirstChild( NodeType.Attribute, "", "vocabulary" );
		}

		public XmlNode GetAdvancedvocabularyCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Attribute, "", "vocabulary", curNode );
		}

		public SchemaString GetvocabularyValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaString( curNode.Value );
		}


		public SchemaString Getvocabulary()
		{
			return GetvocabularyAt(0);
		}

		public SchemaString vocabulary
		{
			get
			{
				return GetvocabularyAt(0);
			}
		}

		public void RemovevocabularyAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "vocabulary", index);
		}

		public void Removevocabulary()
		{
			RemovevocabularyAt(0);
		}

		public XmlNode Addvocabulary(SchemaString newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Attribute, "", "vocabulary", newValue.ToString());
			return null;
		}

		public void InsertvocabularyAt(SchemaString newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Attribute, "", "vocabulary", index, newValue.ToString());
		}

		public void ReplacevocabularyAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "vocabulary", index, newValue.ToString());
		}
		#endregion // vocabulary accessor methods

		#region vocabulary collection
        public vocabularyCollection	Myvocabularys = new vocabularyCollection( );

        public class vocabularyCollection: IEnumerable
        {
            KeywordType parent;
            public KeywordType Parent
			{
				set
				{
					parent = value;
				}
			}
			public vocabularyEnumerator GetEnumerator() 
			{
				return new vocabularyEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class vocabularyEnumerator: IEnumerator 
        {
			int nIndex;
			KeywordType parent;
			public vocabularyEnumerator(KeywordType par) 
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
				return(nIndex < parent.vocabularyCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetvocabularyAt(nIndex));
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

        #endregion // vocabulary collection

        private void SetCollectionParents()
        {
            Myvocabularys.Parent = this; 
	}
}
}
