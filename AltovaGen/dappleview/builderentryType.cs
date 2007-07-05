//
// builderentryType.cs
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
	public class builderentryType : Altova.Xml.Node
	{
		#region Documentation
		public static string GetAnnoDocumentation() { return ""; }
		#endregion

		#region Forward constructors

		public builderentryType() : base() { SetCollectionParents(); }

		public builderentryType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public builderentryType(XmlNode node) : base(node) { SetCollectionParents(); }
		public builderentryType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		public builderentryType(Altova.Xml.Document doc, string namespaceURI, string prefix, string name) : base(doc, namespaceURI, prefix, name) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "builderdirectory" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "builderdirectory", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
				new builderdirectoryType(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "dapcatalog" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "dapcatalog", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
				new dapcatalogType(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "wmscatalog" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "wmscatalog", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
				new wmscatalogType(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "localfilesystem" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "localfilesystem", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
				new localfilesystemType(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "tileserverset" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "tileserverset", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
				new tileserversetType(DOMNode).AdjustPrefix();
			}

		    for (	XmlNode DOMNode = GetDomFirstChild( NodeType.Element, "", "virtualearth" );
					DOMNode != null; 
					DOMNode = GetDomNextChild( NodeType.Element, "", "virtualearth", DOMNode )
				)
			{
				InternalAdjustPrefix(DOMNode, true);
				new virtualearthType(DOMNode).AdjustPrefix();
			}
		}

		public void SetXsiType()
		{
 			XmlElement el = (XmlElement) domNode;
			el.SetAttribute("type", "http://www.w3.org/2001/XMLSchema-instance", "builderentry");
		}


		#region builderdirectory Documentation
		public static string GetbuilderdirectoryAnnoDocumentation()
		{
			return "";		
		}
		public static string GetbuilderdirectoryDefault()
		{
			return "";		
		}
		#endregion

		#region builderdirectory accessor methods
		public static int GetbuilderdirectoryMinCount()
		{
			return 1;
		}

		public static int builderdirectoryMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetbuilderdirectoryMaxCount()
		{
			return 1;
		}

		public static int builderdirectoryMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetbuilderdirectoryCount()
		{
			return DomChildCount(NodeType.Element, "", "builderdirectory");
		}

		public int builderdirectoryCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "builderdirectory");
			}
		}

		public bool Hasbuilderdirectory()
		{
			return HasDomChild(NodeType.Element, "", "builderdirectory");
		}

		public builderdirectoryType Newbuilderdirectory()
		{
			return new builderdirectoryType(domNode.OwnerDocument.CreateElement("builderdirectory", ""));
		}

		public builderdirectoryType GetbuilderdirectoryAt(int index)
		{
			return new builderdirectoryType(GetDomChildAt(NodeType.Element, "", "builderdirectory", index));
		}

		public XmlNode GetStartingbuilderdirectoryCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "builderdirectory" );
		}

		public XmlNode GetAdvancedbuilderdirectoryCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "builderdirectory", curNode );
		}

		public builderdirectoryType GetbuilderdirectoryValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new builderdirectoryType( curNode );
		}


		public builderdirectoryType Getbuilderdirectory()
		{
			return GetbuilderdirectoryAt(0);
		}

		public builderdirectoryType builderdirectory
		{
			get
			{
				return GetbuilderdirectoryAt(0);
			}
		}

		public void RemovebuilderdirectoryAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "builderdirectory", index);
		}

		public void Removebuilderdirectory()
		{
			RemovebuilderdirectoryAt(0);
		}

		public XmlNode Addbuilderdirectory(builderdirectoryType newValue)
		{
			return AppendDomElement("", "builderdirectory", newValue);
		}

		public void InsertbuilderdirectoryAt(builderdirectoryType newValue, int index)
		{
			InsertDomElementAt("", "builderdirectory", index, newValue);
		}

		public void ReplacebuilderdirectoryAt(builderdirectoryType newValue, int index)
		{
			ReplaceDomElementAt("", "builderdirectory", index, newValue);
		}
		#endregion // builderdirectory accessor methods

		#region builderdirectory collection
        public builderdirectoryCollection	Mybuilderdirectorys = new builderdirectoryCollection( );

        public class builderdirectoryCollection: IEnumerable
        {
            builderentryType parent;
            public builderentryType Parent
			{
				set
				{
					parent = value;
				}
			}
			public builderdirectoryEnumerator GetEnumerator() 
			{
				return new builderdirectoryEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class builderdirectoryEnumerator: IEnumerator 
        {
			int nIndex;
			builderentryType parent;
			public builderdirectoryEnumerator(builderentryType par) 
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
				return(nIndex < parent.builderdirectoryCount );
			}
			public builderdirectoryType  Current 
			{
				get 
				{
					return(parent.GetbuilderdirectoryAt(nIndex));
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

        #endregion // builderdirectory collection

		#region dapcatalog Documentation
		public static string GetdapcatalogAnnoDocumentation()
		{
			return "";		
		}
		public static string GetdapcatalogDefault()
		{
			return "";		
		}
		#endregion

		#region dapcatalog accessor methods
		public static int GetdapcatalogMinCount()
		{
			return 1;
		}

		public static int dapcatalogMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetdapcatalogMaxCount()
		{
			return 1;
		}

		public static int dapcatalogMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetdapcatalogCount()
		{
			return DomChildCount(NodeType.Element, "", "dapcatalog");
		}

		public int dapcatalogCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "dapcatalog");
			}
		}

		public bool Hasdapcatalog()
		{
			return HasDomChild(NodeType.Element, "", "dapcatalog");
		}

		public dapcatalogType Newdapcatalog()
		{
			return new dapcatalogType(domNode.OwnerDocument.CreateElement("dapcatalog", ""));
		}

		public dapcatalogType GetdapcatalogAt(int index)
		{
			return new dapcatalogType(GetDomChildAt(NodeType.Element, "", "dapcatalog", index));
		}

		public XmlNode GetStartingdapcatalogCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "dapcatalog" );
		}

		public XmlNode GetAdvanceddapcatalogCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "dapcatalog", curNode );
		}

		public dapcatalogType GetdapcatalogValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new dapcatalogType( curNode );
		}


		public dapcatalogType Getdapcatalog()
		{
			return GetdapcatalogAt(0);
		}

		public dapcatalogType dapcatalog
		{
			get
			{
				return GetdapcatalogAt(0);
			}
		}

		public void RemovedapcatalogAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "dapcatalog", index);
		}

		public void Removedapcatalog()
		{
			RemovedapcatalogAt(0);
		}

		public XmlNode Adddapcatalog(dapcatalogType newValue)
		{
			return AppendDomElement("", "dapcatalog", newValue);
		}

		public void InsertdapcatalogAt(dapcatalogType newValue, int index)
		{
			InsertDomElementAt("", "dapcatalog", index, newValue);
		}

		public void ReplacedapcatalogAt(dapcatalogType newValue, int index)
		{
			ReplaceDomElementAt("", "dapcatalog", index, newValue);
		}
		#endregion // dapcatalog accessor methods

		#region dapcatalog collection
        public dapcatalogCollection	Mydapcatalogs = new dapcatalogCollection( );

        public class dapcatalogCollection: IEnumerable
        {
            builderentryType parent;
            public builderentryType Parent
			{
				set
				{
					parent = value;
				}
			}
			public dapcatalogEnumerator GetEnumerator() 
			{
				return new dapcatalogEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class dapcatalogEnumerator: IEnumerator 
        {
			int nIndex;
			builderentryType parent;
			public dapcatalogEnumerator(builderentryType par) 
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
				return(nIndex < parent.dapcatalogCount );
			}
			public dapcatalogType  Current 
			{
				get 
				{
					return(parent.GetdapcatalogAt(nIndex));
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

        #endregion // dapcatalog collection

		#region wmscatalog Documentation
		public static string GetwmscatalogAnnoDocumentation()
		{
			return "";		
		}
		public static string GetwmscatalogDefault()
		{
			return "";		
		}
		#endregion

		#region wmscatalog accessor methods
		public static int GetwmscatalogMinCount()
		{
			return 1;
		}

		public static int wmscatalogMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetwmscatalogMaxCount()
		{
			return 1;
		}

		public static int wmscatalogMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetwmscatalogCount()
		{
			return DomChildCount(NodeType.Element, "", "wmscatalog");
		}

		public int wmscatalogCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "wmscatalog");
			}
		}

		public bool Haswmscatalog()
		{
			return HasDomChild(NodeType.Element, "", "wmscatalog");
		}

		public wmscatalogType Newwmscatalog()
		{
			return new wmscatalogType(domNode.OwnerDocument.CreateElement("wmscatalog", ""));
		}

		public wmscatalogType GetwmscatalogAt(int index)
		{
			return new wmscatalogType(GetDomChildAt(NodeType.Element, "", "wmscatalog", index));
		}

		public XmlNode GetStartingwmscatalogCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "wmscatalog" );
		}

		public XmlNode GetAdvancedwmscatalogCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "wmscatalog", curNode );
		}

		public wmscatalogType GetwmscatalogValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new wmscatalogType( curNode );
		}


		public wmscatalogType Getwmscatalog()
		{
			return GetwmscatalogAt(0);
		}

		public wmscatalogType wmscatalog
		{
			get
			{
				return GetwmscatalogAt(0);
			}
		}

		public void RemovewmscatalogAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "wmscatalog", index);
		}

		public void Removewmscatalog()
		{
			RemovewmscatalogAt(0);
		}

		public XmlNode Addwmscatalog(wmscatalogType newValue)
		{
			return AppendDomElement("", "wmscatalog", newValue);
		}

		public void InsertwmscatalogAt(wmscatalogType newValue, int index)
		{
			InsertDomElementAt("", "wmscatalog", index, newValue);
		}

		public void ReplacewmscatalogAt(wmscatalogType newValue, int index)
		{
			ReplaceDomElementAt("", "wmscatalog", index, newValue);
		}
		#endregion // wmscatalog accessor methods

		#region wmscatalog collection
        public wmscatalogCollection	Mywmscatalogs = new wmscatalogCollection( );

        public class wmscatalogCollection: IEnumerable
        {
            builderentryType parent;
            public builderentryType Parent
			{
				set
				{
					parent = value;
				}
			}
			public wmscatalogEnumerator GetEnumerator() 
			{
				return new wmscatalogEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class wmscatalogEnumerator: IEnumerator 
        {
			int nIndex;
			builderentryType parent;
			public wmscatalogEnumerator(builderentryType par) 
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
				return(nIndex < parent.wmscatalogCount );
			}
			public wmscatalogType  Current 
			{
				get 
				{
					return(parent.GetwmscatalogAt(nIndex));
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

        #endregion // wmscatalog collection

		#region localfilesystem Documentation
		public static string GetlocalfilesystemAnnoDocumentation()
		{
			return "";		
		}
		public static string GetlocalfilesystemDefault()
		{
			return "";		
		}
		#endregion

		#region localfilesystem accessor methods
		public static int GetlocalfilesystemMinCount()
		{
			return 1;
		}

		public static int localfilesystemMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetlocalfilesystemMaxCount()
		{
			return 1;
		}

		public static int localfilesystemMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetlocalfilesystemCount()
		{
			return DomChildCount(NodeType.Element, "", "localfilesystem");
		}

		public int localfilesystemCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "localfilesystem");
			}
		}

		public bool Haslocalfilesystem()
		{
			return HasDomChild(NodeType.Element, "", "localfilesystem");
		}

		public localfilesystemType Newlocalfilesystem()
		{
			return new localfilesystemType(domNode.OwnerDocument.CreateElement("localfilesystem", ""));
		}

		public localfilesystemType GetlocalfilesystemAt(int index)
		{
			return new localfilesystemType(GetDomChildAt(NodeType.Element, "", "localfilesystem", index));
		}

		public XmlNode GetStartinglocalfilesystemCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "localfilesystem" );
		}

		public XmlNode GetAdvancedlocalfilesystemCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "localfilesystem", curNode );
		}

		public localfilesystemType GetlocalfilesystemValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new localfilesystemType( curNode );
		}


		public localfilesystemType Getlocalfilesystem()
		{
			return GetlocalfilesystemAt(0);
		}

		public localfilesystemType localfilesystem
		{
			get
			{
				return GetlocalfilesystemAt(0);
			}
		}

		public void RemovelocalfilesystemAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "localfilesystem", index);
		}

		public void Removelocalfilesystem()
		{
			RemovelocalfilesystemAt(0);
		}

		public XmlNode Addlocalfilesystem(localfilesystemType newValue)
		{
			return AppendDomElement("", "localfilesystem", newValue);
		}

		public void InsertlocalfilesystemAt(localfilesystemType newValue, int index)
		{
			InsertDomElementAt("", "localfilesystem", index, newValue);
		}

		public void ReplacelocalfilesystemAt(localfilesystemType newValue, int index)
		{
			ReplaceDomElementAt("", "localfilesystem", index, newValue);
		}
		#endregion // localfilesystem accessor methods

		#region localfilesystem collection
        public localfilesystemCollection	Mylocalfilesystems = new localfilesystemCollection( );

        public class localfilesystemCollection: IEnumerable
        {
            builderentryType parent;
            public builderentryType Parent
			{
				set
				{
					parent = value;
				}
			}
			public localfilesystemEnumerator GetEnumerator() 
			{
				return new localfilesystemEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class localfilesystemEnumerator: IEnumerator 
        {
			int nIndex;
			builderentryType parent;
			public localfilesystemEnumerator(builderentryType par) 
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
				return(nIndex < parent.localfilesystemCount );
			}
			public localfilesystemType  Current 
			{
				get 
				{
					return(parent.GetlocalfilesystemAt(nIndex));
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

        #endregion // localfilesystem collection

		#region tileserverset Documentation
		public static string GettileserversetAnnoDocumentation()
		{
			return "";		
		}
		public static string GettileserversetDefault()
		{
			return "";		
		}
		#endregion

		#region tileserverset accessor methods
		public static int GettileserversetMinCount()
		{
			return 1;
		}

		public static int tileserversetMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GettileserversetMaxCount()
		{
			return 1;
		}

		public static int tileserversetMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GettileserversetCount()
		{
			return DomChildCount(NodeType.Element, "", "tileserverset");
		}

		public int tileserversetCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "tileserverset");
			}
		}

		public bool Hastileserverset()
		{
			return HasDomChild(NodeType.Element, "", "tileserverset");
		}

		public tileserversetType Newtileserverset()
		{
			return new tileserversetType(domNode.OwnerDocument.CreateElement("tileserverset", ""));
		}

		public tileserversetType GettileserversetAt(int index)
		{
			return new tileserversetType(GetDomChildAt(NodeType.Element, "", "tileserverset", index));
		}

		public XmlNode GetStartingtileserversetCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "tileserverset" );
		}

		public XmlNode GetAdvancedtileserversetCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "tileserverset", curNode );
		}

		public tileserversetType GettileserversetValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new tileserversetType( curNode );
		}


		public tileserversetType Gettileserverset()
		{
			return GettileserversetAt(0);
		}

		public tileserversetType tileserverset
		{
			get
			{
				return GettileserversetAt(0);
			}
		}

		public void RemovetileserversetAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "tileserverset", index);
		}

		public void Removetileserverset()
		{
			RemovetileserversetAt(0);
		}

		public XmlNode Addtileserverset(tileserversetType newValue)
		{
			return AppendDomElement("", "tileserverset", newValue);
		}

		public void InserttileserversetAt(tileserversetType newValue, int index)
		{
			InsertDomElementAt("", "tileserverset", index, newValue);
		}

		public void ReplacetileserversetAt(tileserversetType newValue, int index)
		{
			ReplaceDomElementAt("", "tileserverset", index, newValue);
		}
		#endregion // tileserverset accessor methods

		#region tileserverset collection
        public tileserversetCollection	Mytileserversets = new tileserversetCollection( );

        public class tileserversetCollection: IEnumerable
        {
            builderentryType parent;
            public builderentryType Parent
			{
				set
				{
					parent = value;
				}
			}
			public tileserversetEnumerator GetEnumerator() 
			{
				return new tileserversetEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class tileserversetEnumerator: IEnumerator 
        {
			int nIndex;
			builderentryType parent;
			public tileserversetEnumerator(builderentryType par) 
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
				return(nIndex < parent.tileserversetCount );
			}
			public tileserversetType  Current 
			{
				get 
				{
					return(parent.GettileserversetAt(nIndex));
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

        #endregion // tileserverset collection

		#region virtualearth Documentation
		public static string GetvirtualearthAnnoDocumentation()
		{
			return "";		
		}
		public static string GetvirtualearthDefault()
		{
			return "";		
		}
		#endregion

		#region virtualearth accessor methods
		public static int GetvirtualearthMinCount()
		{
			return 1;
		}

		public static int virtualearthMinCount
		{
			get
			{
				return 1;
			}
		}

		public static int GetvirtualearthMaxCount()
		{
			return 1;
		}

		public static int virtualearthMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetvirtualearthCount()
		{
			return DomChildCount(NodeType.Element, "", "virtualearth");
		}

		public int virtualearthCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "virtualearth");
			}
		}

		public bool Hasvirtualearth()
		{
			return HasDomChild(NodeType.Element, "", "virtualearth");
		}

		public virtualearthType Newvirtualearth()
		{
			return new virtualearthType(domNode.OwnerDocument.CreateElement("virtualearth", ""));
		}

		public virtualearthType GetvirtualearthAt(int index)
		{
			return new virtualearthType(GetDomChildAt(NodeType.Element, "", "virtualearth", index));
		}

		public XmlNode GetStartingvirtualearthCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "virtualearth" );
		}

		public XmlNode GetAdvancedvirtualearthCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "virtualearth", curNode );
		}

		public virtualearthType GetvirtualearthValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new virtualearthType( curNode );
		}


		public virtualearthType Getvirtualearth()
		{
			return GetvirtualearthAt(0);
		}

		public virtualearthType virtualearth
		{
			get
			{
				return GetvirtualearthAt(0);
			}
		}

		public void RemovevirtualearthAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "virtualearth", index);
		}

		public void Removevirtualearth()
		{
			RemovevirtualearthAt(0);
		}

		public XmlNode Addvirtualearth(virtualearthType newValue)
		{
			return AppendDomElement("", "virtualearth", newValue);
		}

		public void InsertvirtualearthAt(virtualearthType newValue, int index)
		{
			InsertDomElementAt("", "virtualearth", index, newValue);
		}

		public void ReplacevirtualearthAt(virtualearthType newValue, int index)
		{
			ReplaceDomElementAt("", "virtualearth", index, newValue);
		}
		#endregion // virtualearth accessor methods

		#region virtualearth collection
        public virtualearthCollection	Myvirtualearths = new virtualearthCollection( );

        public class virtualearthCollection: IEnumerable
        {
            builderentryType parent;
            public builderentryType Parent
			{
				set
				{
					parent = value;
				}
			}
			public virtualearthEnumerator GetEnumerator() 
			{
				return new virtualearthEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class virtualearthEnumerator: IEnumerator 
        {
			int nIndex;
			builderentryType parent;
			public virtualearthEnumerator(builderentryType par) 
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
				return(nIndex < parent.virtualearthCount );
			}
			public virtualearthType  Current 
			{
				get 
				{
					return(parent.GetvirtualearthAt(nIndex));
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

        #endregion // virtualearth collection

        private void SetCollectionParents()
        {
            Mybuilderdirectorys.Parent = this; 
            Mydapcatalogs.Parent = this; 
            Mywmscatalogs.Parent = this; 
            Mylocalfilesystems.Parent = this; 
            Mytileserversets.Parent = this; 
            Myvirtualearths.Parent = this; 
	}
}
}
