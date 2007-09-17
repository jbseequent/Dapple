using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dapple.Extract
{
   /// <summary>
   /// Gather the extract parameters for downloading the selected datasets
   /// </summary>
   public partial class DownloadSettings : Form
   {
      public enum DownloadCoordinateSystem
      {
         Native,
         OriginalMap
      }

      public enum DownloadClip
      {
         None,
         ViewedArea,
         OriginalMap
      }

      #region Member Variables
      private List<DownloadOptions> m_oDownloadSettings = new List<DownloadOptions>();
      private DownloadOptions m_oCurUserControl = null;
      #endregion

      /// <summary>
      /// Default constructor
      /// </summary>
      /// <param name="oLayersToDownload"></param>
      public DownloadSettings(List<Dapple.LayerGeneration.LayerBuilderContainer> oLayersToDownload)
      {
         InitializeComponent();

         if (!MainForm.OpenMap)
         {
            rbClipMapExtent.Enabled = false;
            rbReproject.Enabled = false;
         }

         if (string.IsNullOrEmpty(tbDestination.Text))
            tbDestination.Text = MainForm.MontajInterface.BaseDirectory();

         lvDatasets.SmallImageList = MainForm.DataTypeImageList;
         lvDatasets.LargeImageList = MainForm.DataTypeImageList;

         foreach (Dapple.LayerGeneration.LayerBuilderContainer oContainer in oLayersToDownload)
         {
            int iImageIndex = 0;

            if (oContainer.Builder is Dapple.LayerGeneration.DAPQuadLayerBuilder)
            {
               Dapple.LayerGeneration.DAPQuadLayerBuilder oDAPbuilder = (Dapple.LayerGeneration.DAPQuadLayerBuilder)oContainer.Builder;

               iImageIndex = MainForm.ImageIndex(oDAPbuilder.DAPType.ToLower());
               if (iImageIndex == -1)
                  MainForm.ImageListIndex("layer");
            }
            else if (oContainer.Builder is Dapple.LayerGeneration.VEQuadLayerBuilder)
               iImageIndex = MainForm.ImageListIndex("live");
            else if (oContainer.Builder is Dapple.LayerGeneration.GeorefImageLayerBuilder)
               iImageIndex = MainForm.ImageListIndex("georef_image");
            else
               iImageIndex = MainForm.ImageListIndex("layer");


            ListViewItem oItem = new ListViewItem(oContainer.Name);
            oItem.ImageIndex = iImageIndex;
            oItem.Tag = oContainer;

            
            // --- create the user control ---

            DownloadOptions oControl = CreateUserControl(oContainer.Builder);
            if (oControl != null)
            {

               // --- no errors, add this dataset to the list ---

               lvDatasets.Items.Add(oItem);
               m_oDownloadSettings.Add(oControl);
               
               oControl.Visible = false;
               oControl.Dock = DockStyle.Fill;
               oControl.ResolutionEnabled = false;
               pSettings.Controls.Add(oControl);
            }
         }

         if (lvDatasets.Items.Count > 0)
         {
            lvDatasets.Items[0].Selected = true;
         }
      }

      #region Private Methods
      /// <summary>
      /// Create the correct control for this dataset
      /// </summary>
      /// <param name="oContainer"></param>
      /// <returns></returns>
      private DownloadOptions CreateUserControl(Dapple.LayerGeneration.LayerBuilder oBuilder)
      {
         DownloadOptions oControl = null;
         if (oBuilder is Dapple.LayerGeneration.DAPQuadLayerBuilder)
         {
            Dapple.LayerGeneration.DAPQuadLayerBuilder oDAPbuilder = (Dapple.LayerGeneration.DAPQuadLayerBuilder)oBuilder;
            
            if (oDAPbuilder.DAPType.ToLower() == "map") {
               oControl = new HyperMAP(oDAPbuilder);
            }
            else if (oDAPbuilder.DAPType.ToLower() == "grid")
            {
               oControl = new Grid(oDAPbuilder);
            }
            else if (oDAPbuilder.DAPType.ToLower() == "picture")
            {
               oControl = new Picture(oDAPbuilder);
            }               
            else if (oDAPbuilder.DAPType.ToLower() == "point")
            {
               oControl = new HyperXYZ(oDAPbuilder);
            }
            else if (oDAPbuilder.DAPType.ToLower() == "database")
            {
               oControl = new Database(oDAPbuilder);
            }
            else if (oDAPbuilder.DAPType.ToLower() == "document")
            {
               oControl = new Document(oDAPbuilder);
            }
            else if (oDAPbuilder.DAPType.ToLower() == "spf")
            {
               oControl = new GIS(oDAPbuilder);
            }
            else if (oDAPbuilder.DAPType.ToLower() == "generic")
            {
               oControl = new Generic(oDAPbuilder);
            }
            else if (oDAPbuilder.DAPType.ToLower() == "voxel")
            {
               oControl = new Voxel(oDAPbuilder);
            }
            else if (oDAPbuilder.DAPType.ToLower() == "arcgis")
            {
               oControl = new PictureWithoutResolution(oDAPbuilder);
            }
            else if (oDAPbuilder.DAPType.ToLower() == "imageserver")
            {
               oControl = new PictureWithoutResolution(oDAPbuilder);
            }
            else if (oDAPbuilder.DAPType.ToLower() == "picturesection")
            {
               oControl = new Picture(oDAPbuilder);
            }
            else if (oDAPbuilder.DAPType.ToLower() == "gridsection")
            {
               oControl = new Grid(oDAPbuilder);
            }
         }
         else 
         {
            oControl = new PictureWithoutResolution(oBuilder);
         }         
         return oControl;
      }
      #endregion

      #region Event Handler
      /// <summary>
      /// The selected dataset has changed, display its extract parameters
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void lvDatasets_SelectedIndexChanged(object sender, EventArgs e)
      {
         DownloadOptions oControl = null;

         if (m_oCurUserControl != null)
            m_oCurUserControl.Visible = false;

         if (lvDatasets.SelectedIndices.Count == 1)
         {
            oControl = m_oDownloadSettings[lvDatasets.SelectedIndices[0]];
            oControl.Visible = true;
            m_oCurUserControl = oControl;
         }
      }      

      /// <summary>
      /// Select the directory to save all the datasets to
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void bBrowseDestination_Click(object sender, EventArgs e)
      {
         FolderBrowserDialog oSelectFolder = new FolderBrowserDialog();
         oSelectFolder.Description = "Select the folder to save the selected datasets to";
         oSelectFolder.SelectedPath = tbDestination.Text;
         oSelectFolder.ShowNewFolderButton = true;
         if (oSelectFolder.ShowDialog() == DialogResult.OK)
            tbDestination.Text = oSelectFolder.SelectedPath;
      }
      
      /// <summary>
      /// Download all the datasets
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void bDownload_Click(object sender, EventArgs e)
      {
         DownloadClip eClip = DownloadClip.None;
         DownloadCoordinateSystem eCS = DownloadCoordinateSystem.Native;


         // --- setup the global settings ---

         if (rbClipMapExtent.Checked)
            eClip = DownloadClip.OriginalMap;
         else if (rbClipViewedArea.Checked)
            eClip = DownloadClip.ViewedArea;

         if (rbReproject.Checked)
            eCS = DownloadCoordinateSystem.OriginalMap;


         System.Xml.XmlDocument oExtractDoc = new System.Xml.XmlDocument();
         System.Xml.XmlElement oRootElement = oExtractDoc.CreateElement("geosoft_xml");
         System.Xml.XmlElement oExtractElement = oExtractDoc.CreateElement("extract");

         oExtractDoc.AppendChild(oRootElement);
         oRootElement.AppendChild(oExtractElement);


         // --- verify inputs ---



         // --- create xml document for each dataset ---

         foreach (DownloadOptions oDataset in m_oDownloadSettings)
         {
            System.Xml.XmlElement oDatasetElement = oExtractDoc.CreateElement("dataset");

            if (oDataset.Save(oDatasetElement, tbDestination.Text, eClip, eCS))
            {
               oExtractElement.AppendChild(oDatasetElement);
            }
         }

         DownloadingForm oPopup = new DownloadingForm();
         oPopup.Show(this);
         Application.DoEvents();

         MainForm.MontajInterface.Download(oExtractDoc.OuterXml);

         oPopup.Hide();

         MessageBox.Show(this, "The datasets have finished downloading.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
         this.Close();
      }

      /// <summary>
      /// Handle user changing the resolution
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void Resolution_Changed(object sender, EventArgs e)
      {
         if (rbDefault.Checked)
         {
            foreach (DownloadOptions oDataset in m_oDownloadSettings)
            {
               oDataset.ResolutionEnabled = false;
               oDataset.SetDefaultResolution();
            }
         }
         else if (rbOriginal.Checked)
         {
            foreach (DownloadOptions oDataset in m_oDownloadSettings)
            {
               oDataset.ResolutionEnabled = false;
               oDataset.SetNativeResolution();
            }
         }
         else if (rbCustom.Checked)
         {
            foreach (DownloadOptions oDataset in m_oDownloadSettings)
            {
               oDataset.ResolutionEnabled = true;
            }
         }
      }
      #endregion

      
   }
}