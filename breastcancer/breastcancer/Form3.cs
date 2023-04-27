using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace breastcancer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
            this.BackColor = Color.FromArgb(34, 34, 34);

            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel2.BackColor = Color.FromArgb(55, 55, 55);
            panel4.BackColor = Color.FromArgb(45, 45, 45);

            labelAbout.ForeColor = Color.White;
            labelAbout.BackColor = Color.Transparent;

            labelTextAbout.Text = "The Breast Cancer Diagnosis Application is a novel tool developed in Azerbaijan for the classification and labeling of" +
                                "\nbreast  cancer  images. The application  features built-in functionalities  for converting DICOM images to PNG format," +
                                "\ngrouping  images  per  patient  by  assigning unique IDs,  and  allowing users  to draw squares on images for marking." +
                                "\nThe application also allows for the  selection of negative,  positive,  and potential  options for each  marked image." +
                          "\r\n\r\nA config file is included in the application which displays the directory of original DICOMs on the doctor's ncomputer" +
                                "\nThe built-in function in the application loads the DICOMs from that directory, converts them to PNG format, saves them" +
                                "\nand removes the DICOMs. The application starts from where it was left off and checks whether the JSON file is empty or" + 
                                "\nnot. As the user clicks \"back\" or \"next\" buttons, labeled or original images are  displayed accordingly. Different" +
                                "\nimage formats are available, and users can view them using up and down buttons." +
                          "\r\n\r\nPen and  eraser buttons  are included  for drawing  squares and erasing them as necessary. The predict button provides" +
                                "\npredictions for each image based on the ML models built.Doctors can also add comments or notes in the textbox.Clicking" +
                                "\nthe \"back\" or \"next\" buttons automatically saves the changes made.Overall, the Breast Cancer Diagnosis Application" +
                                "\noffers an efficient and user-friendly solution for  breast cancer classification and labeling, filling a need for such" +
                                "\na tool in Azerbaijan.";
            labelTextAbout.ForeColor = Color.White;
            labelTextAbout.BackColor = Color.Transparent;
            labelTextAbout.Width = 1000;

            label2.AutoSize = false;
            label2.Height = 1;
            label2.ForeColor = Color.FromArgb(161, 161, 161);
            label2.Width = 10000;
            label2.BorderStyle = BorderStyle.Fixed3D;

            labelSt1.ForeColor = Color.White;
            labelSt1.BackColor = Color.Transparent;
            labelSt2.ForeColor = Color.White;
            labelSt2.BackColor = Color.Transparent;
            labelSt3.ForeColor = Color.White;
            labelSt3.BackColor = Color.Transparent;
        }
    }
}
