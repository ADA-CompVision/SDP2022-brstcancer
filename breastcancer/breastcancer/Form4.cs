using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using breastcancer.Service;

namespace breastcancer
{
    public partial class Form4 : Form
    {
        int picNum4;
        bool downFlag4;
        int c4;

        public Form4()
        {
            InitializeComponent();
            
            this.picNum4 = Form2.picNum;
            this.downFlag4 = Form2.downFlag;
            this.c4 = Form2.c;
        }

        string[] files;

        private Font fnt = new Font("Arial", 10);
        string filepath;

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(34, 34, 34);

            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel4.BackColor = Color.FromArgb(45, 45, 45);

            label2.AutoSize = false;
            label2.Height = 1;
            label2.ForeColor = Color.FromArgb(161, 161, 161);
            label2.Width = 10000;
            label2.BorderStyle = BorderStyle.Fixed3D;

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
                {
                    filepath = filePathNotResized;
                    label3.Text = "Not Resized";
                }
                else
                {
                    filepath = filePathColor1;
                    label3.Text = "Color1";
                }
            }
            else if (picNum4 == 1)
            {
                if (!downFlag4)
                {
                    filepath = filePathBrightened;
                    label3.Text = "Brightened";
                }
                else
                {
                    filepath = filePathColor2;
                    label3.Text = "Color2";
                }
            }
            else if (picNum4 == 2)
            {
                if (!downFlag4)
                {
                    filepath = filePathHighlyBrightened;
                    label3.Text = "Highly Brightened";
                }
                else
                {
                    filepath = filePathColor3;
                    label3.Text = "Color3";
                }
            }
            else if (picNum4 == 3)
            {
                if (!downFlag4)
                {
                    filepath = filePathDarked;
                    label3.Text = "Darkened";
                }
                else
                {
                    filepath = filePathColor4;
                    label3.Text = "Color4";
                }
            }
            else if (picNum4 == 4)
            {
                if (!downFlag4)
                {
                    filepath = filePathResizedTo255;
                    label3.Text = "Resized To 255";
                }
                else
                {
                    filepath = filePathColor5;
                    label3.Text = "Color5";
                }
            }
            else if (picNum4 == 5)
            {
                filepath = filePathResizedTo511;
                label3.Text = "Resized To 511";
            }
            else if (picNum4 == 6)
            {
                filepath = filePathResizedTo1000;
                label3.Text = "Resized To 1000";
            }
            else if (picNum4 == 7)
            {
                filepath = filePathResizedTo1023;
                label3.Text = "Resized To 1023";
            }

            files = Directory.GetFiles(filepath);
            pictureBox1.Image = Image.FromFile(files[c4]);
            drawPic(c4);
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(3, 3, this.panel4.Width, this.panel4.Height, 11, 11); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.panel4.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }

        private void drawPic(int n)
        {
            Graphics g = pictureBox1.CreateGraphics();

            g.DrawRectangle(Pens.Red, new Rectangle(StaticData.DataList1.RectX1, StaticData.DataList1.RectY1, StaticData.DataList1.RectX2 - StaticData.DataList1.RectX1, StaticData.DataList1.RectY2 - StaticData.DataList1.RectY1));
            Rectangle rect1 = pictureBox1.ClientRectangle;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(3, 3, this.panel1.Width, this.panel1.Height, 11, 11); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.panel1.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
