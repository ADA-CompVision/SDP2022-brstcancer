using System;
using System.Drawing;
using System.Windows.Forms;

using System.IO;

using Leadtools;
using Leadtools.Dicom;
using Leadtools.MedicalViewer;


namespace Desktop_App
{

    public partial class Form1 : Form
    {

        private DicomDataSet _dataSet;
        private MedicalViewer _medicalViewer;
        private MedicalViewerMultiCell _cell;
        private RasterImage _image;


        private void Form1_Load(object sender, EventArgs e)
        {
            _medicalViewer = new MedicalViewer(1, 1);
            _medicalViewer.Dock = DockStyle.Fill;
            Controls.Add(_medicalViewer);

            DicomEngine.Startup();
            _dataSet = new DicomDataSet();
        }


    /*    private void loadDICOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.InitialDirectory = @"E:\OneDrive - ADA University\Homework\Fall2022\SDP\Mammograms\Anonomis\s0";
                dlg.Filter = "DICOM DataSets (*.dcm)|*.dcm";
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _dataSet.Load(dlg.FileName, DicomDataSetLoadFlags.LoadAndClose);

                    InitializeMultiCell();

                    if (_cell != null)
                    {
                        SetTags();

                        if (_medicalViewer.Cells.Count > 0)
                            _medicalViewer.Cells.Clear();

                        _medicalViewer.Cells.Add(_cell);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }*/
        private void InitializeMultiCell()
        {
            int dataSet_TotalPages = 0;

            DicomElement pixelDataElement = _dataSet.FindFirstElement(null, DicomTag.PixelData, false);
            if (pixelDataElement != null)
            {
                dataSet_TotalPages = _dataSet.GetImageCount(pixelDataElement);
                if (dataSet_TotalPages != 0)
                {
                    // Get image(s) from DICOM file 
                    _image = _dataSet.GetImages(pixelDataElement, 0, dataSet_TotalPages, 0, RasterByteOrder.Gray, DicomGetImageFlags.AutoApplyModalityLut | DicomGetImageFlags.AutoApplyVoiLut);

                    // Initialize Medical Viewer MultiCell 
                    _cell = new MedicalViewerMultiCell(_image, true, 1, 1);

                    _cell.Rows = 1;
                    _cell.Columns = 1;
                    _cell.Frozen = false;
                    _cell.DisplayRulers = MedicalViewerRulers.Both;
                    _cell.ApplyOnIndividualSubCell = false;
                    _cell.ApplyActionOnMove = true;
                    _cell.FitImageToCell = true;
                    _cell.Selected = true;
                    _cell.ShowTags = true;

                    // Set Mouse and Keyboard actions 
                    SetActions();
                }
                else
                {
                    MessageBox.Show("This DataSet's Pixel Data Element does not contain any image data");
                    _cell = null;
                }
            }
            else
            {
                MessageBox.Show("This DataSet does not contain a Pixel Data Element");
                _cell = null;
            }
        }



        private void SetActions()
        {
            // Add some actions that will be used to change the properties of the images inside the control.  
            _cell.AddAction(MedicalViewerActionType.WindowLevel);
            _cell.AddAction(MedicalViewerActionType.Offset);
            _cell.AddAction(MedicalViewerActionType.Stack);

            // Assign the added actions to a mouse button, meaning that when the user clicks and drags the mouse button, the associated action will be activated.  
            _cell.SetAction(MedicalViewerActionType.Offset, MedicalViewerMouseButtons.Right, MedicalViewerActionFlags.Active);
            _cell.SetAction(MedicalViewerActionType.WindowLevel, MedicalViewerMouseButtons.Left, MedicalViewerActionFlags.Active);
            _cell.SetAction(MedicalViewerActionType.Stack, MedicalViewerMouseButtons.Wheel, MedicalViewerActionFlags.Active);

            // Assign the added actions to a keyboard keys that will work like the mouse.  
            MedicalViewerKeys medicalKeys = new MedicalViewerKeys(Keys.Down, Keys.Up, Keys.Left, Keys.Right, MedicalViewerModifiers.None);
            _cell.SetActionKeys(MedicalViewerActionType.Offset, medicalKeys);
            medicalKeys.Modifiers = MedicalViewerModifiers.Ctrl;
            _cell.SetActionKeys(MedicalViewerActionType.WindowLevel, medicalKeys);
        }


        private void SetTags()
        {
            // Extract tags from DICOM file 
            string dpatientID = GetDicomTag(_dataSet, DicomTag.PatientID);
            string dpatientName = GetDicomTag(_dataSet, DicomTag.PatientName);
            string dpatientAge = GetDicomTag(_dataSet, DicomTag.PatientAge);
            string dpatientBirthDate = GetDicomTag(_dataSet, DicomTag.PatientBirthDate);
            string dpatientSex = GetDicomTag(_dataSet, DicomTag.PatientSex);

            // Set tags in MultiCell 
            _cell.SetTag(1, MedicalViewerTagAlignment.TopRight, MedicalViewerTagType.UserData, "Name: " + dpatientName);
            _cell.SetTag(2, MedicalViewerTagAlignment.TopRight, MedicalViewerTagType.UserData, "ID: " + dpatientID);
            _cell.SetTag(3, MedicalViewerTagAlignment.TopRight, MedicalViewerTagType.UserData, "DOB: " + dpatientBirthDate);
            _cell.SetTag(4, MedicalViewerTagAlignment.TopRight, MedicalViewerTagType.UserData, "Age: " + dpatientAge);
            _cell.SetTag(5, MedicalViewerTagAlignment.TopRight, MedicalViewerTagType.UserData, "Sex: " + dpatientSex);

            _cell.SetTag(4, MedicalViewerTagAlignment.TopLeft, MedicalViewerTagType.Frame);
            _cell.SetTag(6, MedicalViewerTagAlignment.TopLeft, MedicalViewerTagType.Scale);
            _cell.SetTag(2, MedicalViewerTagAlignment.BottomLeft, MedicalViewerTagType.WindowLevelData);
            _cell.SetTag(1, MedicalViewerTagAlignment.BottomLeft, MedicalViewerTagType.FieldOfView);
            _cell.SetTag(0, MedicalViewerTagAlignment.BottomLeft, MedicalViewerTagType.RulerUnit);
        }

        private string GetDicomTag(DicomDataSet ds, long tag)
        {
            DicomElement patientElement = ds.FindFirstElement(null, tag, true);

            if (patientElement != null)
                return ds.GetConvertValue(patientElement);

            return null;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.InitialDirectory = @"E:\OneDrive - ADA University\Homework\Fall2022\SDP\Mammograms\Anonomis\s0";
                dlg.Filter = "DICOM DataSets (*.dcm)|*.dcm";
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    _dataSet.Load(dlg.FileName, DicomDataSetLoadFlags.LoadAndClose);

                    InitializeMultiCell();

                    if (_cell != null)
                    {
                        SetTags();

                        if (_medicalViewer.Cells.Count > 0)
                            _medicalViewer.Cells.Clear();

                        _medicalViewer.Cells.Add(_cell);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}