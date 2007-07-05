//
// latitudeType.cs
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

namespace capabilities_1_3_0.wms
{

	public class latitudeType : SchemaDouble
	{

		public latitudeType() : base()
		{
		}

		public latitudeType(string newValue) : base(newValue)
		{
			Validate();
		}

		public latitudeType(SchemaDouble newValue) : base(newValue)
		{
			Validate();
		}


		#region Documentation
/*
		public static string GetAnnoDocumentation()
		{
			return "";
		}
 */ 
		#endregion

		public  void Validate()
		{

			if (CompareTo(GetMaxInclusive()) > 0)
				throw new System.Exception("Value of latitudeType is out of range.");

			if (CompareTo(GetMinInclusive()) < 0)
				throw new System.Exception("Value of latitudeType is out of range.");
		}
		public  SchemaDouble GetMaxInclusive()
		{
			return new SchemaDouble("90");
		}
		public  SchemaDouble GetMinInclusive()
		{
			return new SchemaDouble("-90");
		}
	}
}
