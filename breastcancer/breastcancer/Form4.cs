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
        // Rectangle rect;

        int sx1, sy1, sw, sh;
        string textCom = "Write a comment...";
        string textEmp = "";


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
            this.KeyPreview = true;
            this.BackColor = Color.FromArgb(34, 34, 34);

            panel1.BackColor = Color.FromArgb(45, 45, 45);
            panel2.BackColor = Color.FromArgb(55, 55, 55);
            panel4.BackColor = Color.FromArgb(45, 45, 45);

            radioButtonNegative.BackColor = Color.FromArgb(55, 55, 55);
            radioButtonNegative.ForeColor = Color.White;
            radioButtonPositive.BackColor = Color.FromArgb(55, 55, 55);
            radioButtonPositive.ForeColor = Color.White;
            radioButtonPotential.BackColor = Color.FromArgb(55, 55, 55);
            radioButtonPotential.ForeColor = Color.White;

            textBoxComment.Text = textCom;
            textBoxComment.ForeColor = Color.White;
            textBoxComment.BackColor = Color.FromArgb(55, 55, 55);

            label2.AutoSize = false;
            label2.Height = 1;
            label2.ForeColor = Color.FromArgb(161, 161, 161);
            label2.Width = 10000;
            label2.BorderStyle = BorderStyle.Fixed3D;
            labelMark.BackColor = Color.Transparent;
            labelMark.ForeColor = Color.White;
            labelDComment.ForeColor = Color.White;
            labelDComment.BackColor = Color.Transparent;
            labelNotes.ForeColor = Color.White;
            labelNotes.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(161, 161, 161);
            label3.ForeColor = Color.FromArgb(161, 161, 161);

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
            string filePathColor1_600 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color1_600";
            string filePathColor2_600 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color2_600";
            string filePathColor3_600 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color3_600";
            string filePathColor4 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color4";
            string filePathColor5 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color5";
            string filePathDarked = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Darked";
            string filePathHighlyBrightened = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\HighlyBrightened";
            string filePathNotResized = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\NotResized";
            string filePathResizedTo255 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo255";
            string filePathResizedTo511 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo511";
            string filePathResizedTo1000 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo1000";
            string filePathResizedTo1023 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo1023";


            buttonPrevious.ForeColor = Color.WhiteSmoke;
            buttonPrevious.BackColor = Color.FromArgb(45, 45, 45);
            IntPtr ptrPre = NativeMethods.CreateRoundRectRgn(2, 2, this.buttonPrevious.Width, this.buttonPrevious.Height, 5, 5);
            this.buttonPrevious.Region = System.Drawing.Region.FromHrgn(ptrPre);
            NativeMethods.DeleteObject(ptrPre);

            buttonNext.ForeColor = Color.WhiteSmoke;
            buttonNext.BackColor = Color.FromArgb(45, 45, 45);
            IntPtr ptrNext = NativeMethods.CreateRoundRectRgn(2, 2, this.buttonNext.Width, this.buttonNext.Height, 5, 5);
            this.buttonNext.Region = System.Drawing.Region.FromHrgn(ptrNext);
            NativeMethods.DeleteObject(ptrNext);

            buttonUp.ForeColor = Color.WhiteSmoke;
            buttonUp.BackColor = Color.FromArgb(66, 66, 66);
            buttonUp.FlatStyle = FlatStyle.Flat;
            buttonUp.FlatAppearance.BorderSize = 0;
            IntPtr ptrUp = NativeMethods.CreateRoundRectRgn(-1, -1, this.buttonUp.Width + 2, this.buttonUp.Height + 2, 100, 100);
            this.buttonUp.Region = System.Drawing.Region.FromHrgn(ptrUp);
            NativeMethods.DeleteObject(ptrUp);

            buttonDown.ForeColor = Color.WhiteSmoke;
            buttonDown.BackColor = Color.FromArgb(66, 66, 66);
            buttonDown.FlatStyle = FlatStyle.Flat;
            buttonDown.FlatAppearance.BorderSize = 0;
            IntPtr ptrDown = NativeMethods.CreateRoundRectRgn(-1, -1, this.buttonDown.Width + 2, this.buttonDown.Height + 2, 100, 100);
            this.buttonDown.Region = System.Drawing.Region.FromHrgn(ptrDown);
            NativeMethods.DeleteObject(ptrDown);

            buttonQuestionM.ForeColor = Color.FromArgb(161, 161, 161);
            buttonQuestionM.BackColor = Color.FromArgb(66, 66, 66);
            buttonQuestionM.FlatStyle = FlatStyle.Flat;
            buttonQuestionM.FlatAppearance.BorderSize = 0;
            IntPtr ptrQues = NativeMethods.CreateRoundRectRgn(0, 0, this.buttonQuestionM.Width + 1, this.buttonQuestionM.Height + 1, 100, 100);
            this.buttonQuestionM.Region = System.Drawing.Region.FromHrgn(ptrQues);
            NativeMethods.DeleteObject(ptrQues);

            buttonPencil.ForeColor = Color.FromArgb(161, 161, 161);
            buttonPencil.BackColor = Color.FromArgb(66, 66, 66);
            buttonPencil.FlatStyle = FlatStyle.Flat;
            buttonPencil.FlatAppearance.BorderSize = 0;
            IntPtr ptrPencil = NativeMethods.CreateRoundRectRgn(-1, -1, this.buttonPencil.Width + 2, this.buttonPencil.Height + 2, 100, 100);
            this.buttonPencil.Region = System.Drawing.Region.FromHrgn(ptrPencil);
            NativeMethods.DeleteObject(ptrPencil);

            IntPtr ptr = NativeMethods.CreateRoundRectRgn(2, 2, this.textBoxComment.Width - 1, this.textBoxComment.Height - 1, 5, 5); //play with these values till you are happy
            this.textBoxComment.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);


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
                if (!downFlag4)
                {
                    filepath = filePathResizedTo511;
                    label3.Text = "Resized To 511";
                }
                else
                {
                    filepath = filePathColor1_600;
                    label3.Text = "1 Resized To 600";
                }
            }
            else if (picNum4 == 6)
            {
                if (downFlag4)
                {
                    filepath = filePathColor2_600;
                    label3.Text = "2 Resized To 600";
                }
                else
                {
                    filepath = filePathResizedTo1000;
                    label3.Text = "Resized To 511";
                }
            }
            else if (picNum4 == 7)
            {
                if (!downFlag4)
                {
                    filepath = filePathResizedTo1023;
                    label3.Text = "Resized To 1023";
                }
                else
                {
                    filepath = filePathColor3_600;
                    label3.Text = "3 Resized To 600";
                }
            }

            files = Directory.GetFiles(filepath);
            pictureBox1.Image = Image.FromFile(files[c4]);
            label1.Text = filepath.TrimStart('\\');

            drawPic();//c4);


        }

        /* private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
         {
         //    if (e.Delta != 0)
         //    {
         //        if (e.Delta <= 0)
         //        {
         //            //set minimum size to zoom
         //            if (pictureBox1.Width < 50)
         //                // lbl_Zoom.Text = pictureBox1.Image.Size; 
         //                return;
         //        }
         //        else
         //        {
         //            //set maximum size to zoom
         //            if (pictureBox1.Width > 1000)
         //                return;
         //        }
         //        pictureBox1.Width += Convert.ToInt32(pictureBox1.Width * e.Delta / 1000);
         //        pictureBox1.Height += Convert.ToInt32(pictureBox1.Height * e.Delta / 1000);
         //    }
         }*/

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(3, 3, this.panel4.Width, this.panel4.Height, 11, 11); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.panel4.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }

        //private Rectangle GetRect()
        //{
        //    rect = new Rectangle();
        //    rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
        //    rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);

        //    rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
        //    rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);

        //    return rect;
        //}

        private void drawPic()//PictureBox pb, int n)
        {


            // g.DrawRectangle(Pens.Red, new Rectangle(dataList[n].RectX1, dataList[n].RectY1, dataList[n].RectX2 - dataList[n].RectX1, dataList[n].RectY2 - dataList[n].RectY1));
            // g.DrawRectangle(Pens.Red, new Rectangle(StaticData.DataList1.RectX1, StaticData.DataList1.RectY1, StaticData.DataList1.RectX2 - StaticData.DataList1.RectX1, StaticData.DataList1.RectY2 - StaticData.DataList1.RectY1));



            sx1 = (int)(StaticData.DataList1.RectX1 / 6);
            sy1 = (int)(StaticData.DataList1.RectY1 / 6);
            sw = (int)((StaticData.DataList1.RectX2 - StaticData.DataList1.RectX1) / 6);
            sh = (int)((StaticData.DataList1.RectY2 - StaticData.DataList1.RectY1) / 6);
            Graphics g = pictureBox1.CreateGraphics();

            // e.Graphics.DrawRectangle(Pens.Red, new Rectangle(205, 203, 153, 171));
            g.DrawRectangle(Pens.Red, new Rectangle(sx1, sy1, sw, sh));//StaticData.DataList1.RectX1, StaticData.DataList1.RectY1, StaticData.DataList1.RectX2 - StaticData.DataList1.RectX1, StaticData.DataList1.RectY2 - StaticData.DataList1.RectY1));

            // e.Graphics.DrawRectangle(Pens.Red, GetRect());
            Rectangle rect1 = pictureBox1.ClientRectangle;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(3, 3, this.panel2.Width, this.panel2.Height, 11, 11); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.panel2.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }

        private void textBoxComment_Enter(object sender, EventArgs e)
        {
            if (this.textBoxComment.Text.Equals(textCom))
            {
                this.textBoxComment.Text = textEmp;
            }
        }

        private void textBoxComment_Leave(object sender, EventArgs e)
        {
            if (textBoxComment.Text.Equals(textEmp))
            {
                textBoxComment.Text = textCom;
            }
        }

        //private void drawPic()//int n)
        //{
        //    Graphics g = pictureBox1.CreateGraphics();

        //    g.DrawRectangle(Pens.Red, new Rectangle(StaticData.DataList1.RectX1, StaticData.DataList1.RectY1, StaticData.DataList1.RectX2 - StaticData.DataList1.RectX1, StaticData.DataList1.RectY2 - StaticData.DataList1.RectY1));
        //    Rectangle rect1 = pictureBox1.ClientRectangle;
        //}

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

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            sx1 = (int)(StaticData.DataList1.RectX1 / 6);
            sy1 = (int)(StaticData.DataList1.RectY1 / 6);
            sw = (int)((StaticData.DataList1.RectX2 - StaticData.DataList1.RectX1) / 6);
            sh = (int)((StaticData.DataList1.RectY2 - StaticData.DataList1.RectY1) / 6);
            // e.Graphics.DrawRectangle(Pens.Red, new Rectangle(205, 203, 153, 171));
            e.Graphics.DrawRectangle(Pens.Red, new Rectangle(sx1, sy1, sw, sh));//StaticData.DataList1.RectX1, StaticData.DataList1.RectY1, StaticData.DataList1.RectX2 - StaticData.DataList1.RectX1, StaticData.DataList1.RectY2 - StaticData.DataList1.RectY1));

            // e.Graphics.DrawRectangle(Pens.Red, GetRect());
            Rectangle rect1 = pictureBox1.ClientRectangle;


        }
    }
}