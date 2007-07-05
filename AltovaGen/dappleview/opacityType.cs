//
// opacityType.cs
//
// This file was generated by XMLSpy 2007r3 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using Altova.Types;

namespace dappleview
{

	public class opacityType : SchemaInt
	{

		public opacityType() : base()
		{
		}

		public opacityType(string newValue) : base(newValue)
		{
			Validate();
		}

		public opacityType(SchemaInt newValue) : base(newValue)
		{
			Validate();
		}


		#region Documentation
		public static string GetAnnoDocumentation()
		{
			return "";
		}
		#endregion

		public  void Validate()
		{

			if (CompareTo(GetMaxInclusive()) > 0)
				throw new System.Exception("Value of opacity is out of range.");

			if (CompareTo(GetMinInclusive()) < 0)
				throw new System.Exception("Value of opacity is out of range.");
		}
		public  SchemaInt GetMaxInclusive()
		{
			return new SchemaInt("255");
		}
		public  SchemaInt GetMinInclusive()
		{
			return new SchemaInt("0");
		}
	}
}
