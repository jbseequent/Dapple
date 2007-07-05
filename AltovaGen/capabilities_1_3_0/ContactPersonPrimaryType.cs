//
// ContactPersonPrimaryType.cs
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
	public class ContactPersonPrimaryType : Altova.Xml.Node
	{
		#region Documentation
	/*
		public static string GetAnnoDocumentation() { return ""; }
	 */ 
		#endregion

		#region Forward constructors

		public ContactPersonPrimaryType() : base() { SetCollectionParents(); }

		public ContactPersonPrimaryType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public ContactPersonPrimaryType(XmlNode node) : base(node) { SetCollectionParents(); }
		public ContactPersonPrimaryType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public ContactPersonPrimaryType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.opengis.net/wms", "ContactPerson" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.opengis.net/wms", "ContactPerson", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "http://www.opengis.net/wms", "ContactOrganization" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "http://www.opengis.net/wms", "ContactOrganization", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "wms:ContactPersonPrimary");
		}


		#region ContactPerson Documentation
/*
		public static string GetContactPersonAnnoDocumentation()
		{
			return "";		
		}
 */ 
		public static string GetContactPersonDefault()
		{
			return "";		
		}
		#endregion

		#region ContactPerson accessor methods
		public static int GetContactPersonMinCount()
		{
			return 1;
		}

		public static int ContactPersonMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetContactPersonMaxCount()
		{
			return 1;
		}

		public static int ContactPersonMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetContactPersonCount()
		{
			return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "ContactPerson");
		}

		public int ContactPersonCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "ContactPerson");
			}
		}

		public bool HasContactPerson()
		{
			return HasDomChild(NodeType.Element, "http://www.opengis.net/wms", "ContactPerson");
		}

		public SchemaString NewContactPerson()
		{
			return new SchemaString();
		}

		public SchemaString GetContactPersonAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "ContactPerson", index)));
		}

		public XmlNode GetStartingContactPersonCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.opengis.net/wms", "ContactPerson" );
		}

		public XmlNode GetAdvancedContactPersonCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.opengis.net/wms", "ContactPerson", curNode );
		}

		public SchemaString GetContactPersonValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaString( curNode.InnerText );
		}


		public SchemaString GetContactPerson()
		{
			return GetContactPersonAt(0);
		}

		public SchemaString ContactPerson
		{
			get
			{
				return GetContactPersonAt(0);
			}
		}

		public void RemoveContactPersonAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "ContactPerson", index);
		}

		public void RemoveContactPerson()
		{
			RemoveContactPersonAt(0);
		}

		public XmlNode AddContactPerson(SchemaString newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.opengis.net/wms", "ContactPerson", newValue.ToString());
			return null;
		}

		public void InsertContactPersonAt(SchemaString newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "ContactPerson", index, newValue.ToString());
		}

		public void ReplaceContactPersonAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "ContactPerson", index, newValue.ToString());
		}
		#endregion // ContactPerson accessor methods

		#region ContactPerson collection
        public ContactPersonCollection	MyContactPersons = new ContactPersonCollection( );

        public class ContactPersonCollection: IEnumerable
        {
            ContactPersonPrimaryType parent;
            public ContactPersonPrimaryType Parent
			{
				set
				{
					parent = value;
				}
			}
			public ContactPersonEnumerator GetEnumerator() 
			{
				return new ContactPersonEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ContactPersonEnumerator: IEnumerator 
        {
			int nIndex;
			ContactPersonPrimaryType parent;
			public ContactPersonEnumerator(ContactPersonPrimaryType par) 
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
				return(nIndex < parent.ContactPersonCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetContactPersonAt(nIndex));
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

        #endregion // ContactPerson collection

		#region ContactOrganization Documentation
/*
		public static string GetContactOrganizationAnnoDocumentation()
		{
			return "";		
		}
 */ 
		public static string GetContactOrganizationDefault()
		{
			return "";		
		}
		#endregion

		#region ContactOrganization accessor methods
		public static int GetContactOrganizationMinCount()
		{
			return 1;
		}

		public static int ContactOrganizationMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetContactOrganizationMaxCount()
		{
			return 1;
		}

		public static int ContactOrganizationMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetContactOrganizationCount()
		{
			return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "ContactOrganization");
		}

		public int ContactOrganizationCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "ContactOrganization");
			}
		}

		public bool HasContactOrganization()
		{
			return HasDomChild(NodeType.Element, "http://www.opengis.net/wms", "ContactOrganization");
		}

		public SchemaString NewContactOrganization()
		{
			return new SchemaString();
		}

		public SchemaString GetContactOrganizationAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "ContactOrganization", index)));
		}

		public XmlNode GetStartingContactOrganizationCursor()
		{
			return GetDomFirstChild( NodeType.Element, "http://www.opengis.net/wms", "ContactOrganization" );
		}

		public XmlNode GetAdvancedContactOrganizationCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "http://www.opengis.net/wms", "ContactOrganization", curNode );
		}

		public SchemaString GetContactOrganizationValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaString( curNode.InnerText );
		}


		public SchemaString GetContactOrganization()
		{
			return GetContactOrganizationAt(0);
		}

		public SchemaString ContactOrganization
		{
			get
			{
				return GetContactOrganizationAt(0);
			}
		}

		public void RemoveContactOrganizationAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "ContactOrganization", index);
		}

		public void RemoveContactOrganization()
		{
			RemoveContactOrganizationAt(0);
		}

		public XmlNode AddContactOrganization(SchemaString newValue)
		{
			if( newValue.IsNull() == false )
				return AppendDomChild(NodeType.Element, "http://www.opengis.net/wms", "ContactOrganization", newValue.ToString());
			return null;
		}

		public void InsertContactOrganizationAt(SchemaString newValue, int index)
		{
			if( newValue.IsNull() == false )
				InsertDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "ContactOrganization", index, newValue.ToString());
		}

		public void ReplaceContactOrganizationAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "ContactOrganization", index, newValue.ToString());
		}
		#endregion // ContactOrganization accessor methods

		#region ContactOrganization collection
        public ContactOrganizationCollection	MyContactOrganizations = new ContactOrganizationCollection( );

        public class ContactOrganizationCollection: IEnumerable
        {
            ContactPersonPrimaryType parent;
            public ContactPersonPrimaryType Parent
			{
				set
				{
					parent = value;
				}
			}
			public ContactOrganizationEnumerator GetEnumerator() 
			{
				return new ContactOrganizationEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ContactOrganizationEnumerator: IEnumerator 
        {
			int nIndex;
			ContactPersonPrimaryType parent;
			public ContactOrganizationEnumerator(ContactPersonPrimaryType par) 
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
				return(nIndex < parent.ContactOrganizationCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetContactOrganizationAt(nIndex));
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

        #endregion // ContactOrganization collection

        private void SetCollectionParents()
        {
            MyContactPersons.Parent = this; 
            MyContactOrganizations.Parent = this; 
	}
}
}
