using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace breastcancer
{
    public partial class Form4 : Form
    {
        int picNum4;
        bool downFlag4;

        public Form4()
        {
            InitializeComponent();
            this.picNum4 = Form2.picNum;
            this.downFlag4 = Form2.downFlag;
        }

        int c = 0;
        string[] files;

        private Font fnt = new Font("Arial", 10);
        string filepath;

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // Dock the PictureBox to the form and set its background to white.
        //    pictureBox1.Image = Image.FromFile(@"E:\OneDrive - ADA University\Homework\Fall2022\SDP\Images\image0.png"); // Use a valid image path

        //    // pictureBox1.Dock = DockStyle.Fill;
        //    // pictureBox1.BackColor = Color.White;
        //    // Connect the Paint event of the PictureBox to the event handler method.
        //    //    pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

        //    // Add the PictureBox control to the Form.
        //    //    this.Controls.Add(pictureBox1);
        //}

        //private void pictureBox1_Paint(object sender, PaintEventArgs e)
        //{
        //    // Create a local version of the graphics object for the PictureBox.
        //    //Graphics g = e.Graphics;

        //    //// Draw a string on the PictureBox.
        //    //g.DrawString("This is a diagonal line drawn on the control",
        //    //    fnt, System.Drawing.Brushes.Blue, new Point(30, 30));
        //    //// Draw a line in the PictureBox.
        //    //g.DrawLine(System.Drawing.Pens.Red, pictureBox1.Left, pictureBox1.Top,
        //    //    pictureBox1.Right, pictureBox1.Bottom);
        //}

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(34, 34, 34);
            //  string filePath;// = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Photos\NotResized";


            string filePathBrightened = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Brightened";
            string filePathColor1 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color1";
            string filePathColor2 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color2";
            string filePathColor3 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color3";
            string filePathColor4 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color4";
            string filePathColor5 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color5";
            string filePathDarked = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Darked";
            string filePathHighlyBrightened = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\HighlyBrightened";
            string filePathNotResized = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\NotResized";
            string filePathResizedTo255 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo255";
            string filePathResizedTo511 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo511";
            string filePathResizedTo1000 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo1000";
            string filePathResizedTo1023 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo1023";

            if (picNum4 == 0)
            {
                if (!downFlag4)
                    filepath = filePathNotResized;
                else
                    filepath = filePathColor1;
            }
            else if (picNum4 == 1)
            {
                if (!downFlag4)
                    filepath = filePathBrightened;
                else
                    filepath = filePathColor2;
            }
            else if (picNum4 == 2)
            {
                if (!downFlag4)
                    filepath = filePathHighlyBrightened;
                else
                    filepath = filePathColor3;
            }
            else if (picNum4 == 3)
            {
                if (!downFlag4)
                    filepath = filePathDarked;
                else
                    filepath = filePathColor4;
            }
            else if (picNum4 == 4)
            {
                if (!downFlag4)
                    filepath = filePathResizedTo255;
                else
                    filepath = filePathColor5;
            }
            else if (picNum4 == 5)
            {
                filepath = filePathResizedTo511;
            }
            else if (picNum4 == 6)
            {
                filepath = filePathResizedTo1000;
            }
            else if (picNum4 == 7)
            {
                filepath = filePathResizedTo1023;
            }


            files = Directory.GetFiles(filepath);
            pictureBox1.Image = Image.FromFile(files[c]);
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //new Form2().Show();
            this.Close();

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                if (e.Delta <= 0)
                {
                    //set minimum size to zoom
                    if (pictureBox1.Width < 50)
                        // lbl_Zoom.Text = pictureBox1.Image.Size; 
                        return;
                }
                else
                {
                    //set maximum size to zoom
                    if (pictureBox1.Width > 1000)
                        return;
                }
                pictureBox1.Width += Convert.ToInt32(pictureBox1.Width * e.Delta / 1000);
                pictureBox1.Height += Convert.ToInt32(pictureBox1.Height * e.Delta / 1000);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {

            // pictureBox3.Image = Image.FromFile(filesNotResized[c]);

        }

        //private void pictureBox1_Paint(object sender, PaintEventArgs e)
        //{
        //    Create a local version of the graphics object for the PictureBox.

        //   Graphics g = e.Graphics;

        //    Draw a string on the PictureBox.
        //    g.DrawString("This is a diagonal line drawn on the control",
        //        fnt, Brushes.Blue, new Point(30, 30));
        //    Draw a line in the PictureBox.
        //    g.DrawLine(Pens.Red, pictureBox1.Left, pictureBox1.Top,
        //        pictureBox1.Right, pictureBox1.Bottom);
        //}
    }
}
