using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Dapple.Extract
{
   /// <summary>
   /// Set the options for download acquire datasets
   /// </summary>
   public partial class Disabled : DownloadOptions
   {
      public Disabled(String szReason)
			:base(null)
		{
			InitializeComponent();

			lNoOptions.Text = szReason;
		}

		public override bool OpenInMap
		{
			get { return false; }
		}

      /// <summary>
      /// Write out settings for the acquire dataset
      /// </summary>
      /// <param name="oDatasetElement"></param>
      /// <param name="strDestFolder"></param>
      /// <param name="bDefaultResolution"></param>
      /// <returns></returns>
		public override ExtractSaveResult Save(System.Xml.XmlElement oDatasetElement, string strDestFolder, DownloadSettings.DownloadCoordinateSystem eCS)
      {
			return ExtractSaveResult.Ignore;         
      }
   }
}
