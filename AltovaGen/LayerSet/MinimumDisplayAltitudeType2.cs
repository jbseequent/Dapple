//
// MinimumDisplayAltitudeType2.cs
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

namespace LayerSet
{

	public class MinimumDisplayAltitudeType2 : SchemaDouble
	{

		public MinimumDisplayAltitudeType2() : base()
		{
		}

		public MinimumDisplayAltitudeType2(string newValue) : base(newValue)
		{
			Validate();
		}

		public MinimumDisplayAltitudeType2(SchemaDouble newValue) : base(newValue)
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

			if (CompareTo(GetMinInclusive()) < 0)
				throw new System.Exception("Value of MinimumDisplayAltitude is out of range.");
		}
		public  SchemaDouble GetMinInclusive()
		{
			return new SchemaDouble("0");
		}
	}
}
