﻿using System;
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
        int sx1, sy1, sw, sh;
        string textCom = "Write a comment...";
        string textEmp = String.Empty;
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

            string filePathOriginal = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Original";
            string filePathColored = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Colorized";

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

            if (!downFlag4)
            {
                filepath = filePathOriginal;
                label3.Text = "Original";
            }
            else
            {
                filepath = filePathColored;
                label3.Text = "Colored";
            }

            files = Directory.GetFiles(filepath);

            if (picNum4 == 0)
            {
                pictureBox1.Image = Image.FromFile(files[c4]);

                sx1 = (int)(StaticData.DataList1.Rect1X1 / 6);
                sy1 = (int)(StaticData.DataList1.Rect1Y1 / 6);
                sw = (int)((StaticData.DataList1.Rect1X2 - StaticData.DataList1.Rect1X1) / 6);
                sh = (int)((StaticData.DataList1.Rect1Y2 - StaticData.DataList1.Rect1Y1) / 6);
            }
            else if (picNum4 == 1)
            {
                pictureBox1.Image = Image.FromFile(files[c4 + 1]);
                sx1 = (int)(StaticData.DataList1.Rect2X1 / 6);
                sy1 = (int)(StaticData.DataList1.Rect2Y1 / 6);
                sw = (int)((StaticData.DataList1.Rect2X2 - StaticData.DataList1.Rect2X1) / 6);
                sh = (int)((StaticData.DataList1.Rect2Y2 - StaticData.DataList1.Rect2Y1) / 6);
            }
            else if (picNum4 == 2)
            {
                pictureBox1.Image = Image.FromFile(files[c4 + 2]);
                sx1 = (int)(StaticData.DataList1.Rect3X1 / 6);
                sy1 = (int)(StaticData.DataList1.Rect3Y1 / 6);
                sw = (int)((StaticData.DataList1.Rect3X2 - StaticData.DataList1.Rect3X1) / 6);
                sh = (int)((StaticData.DataList1.Rect3Y2 - StaticData.DataList1.Rect3Y1) / 6);
            }
            else if (picNum4 == 3)
            {
                pictureBox1.Image = Image.FromFile(files[c4 + 3]);
                sx1 = (int)(StaticData.DataList1.Rect4X1 / 6);
                sy1 = (int)(StaticData.DataList1.Rect4Y1 / 6);
                sw = (int)((StaticData.DataList1.Rect4X2 - StaticData.DataList1.Rect4X1) / 6);
                sh = (int)((StaticData.DataList1.Rect4Y2 - StaticData.DataList1.Rect4Y1) / 6);
            }

            label1.Text = filepath.TrimStart('\\');

          //  drawPic();
        }

        //private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        //{
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
        //}

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
            //    Graphics g = pictureBox1.CreateGraphics();

            //    // g.DrawRectangle(Pens.Red, new Rectangle(dataList[n].RectX1, dataList[n].RectY1, dataList[n].RectX2 - dataList[n].RectX1, dataList[n].RectY2 - dataList[n].RectY1));
            //    g.DrawRectangle(Pens.Red, new Rectangle(StaticData.DataList1.Rect1X1 / 6, StaticData.DataList1.RectY1 / 6, (StaticData.DataList1.RectX2 - StaticData.DataList1.RectX1) / 6, (StaticData.DataList1.RectY2 - StaticData.DataList1.RectY1) / 6));

            //    Rectangle rect1 = this.pictureBox1.ClientRectangle;
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
            // e.Graphics.DrawRectangle(Pens.Red, new Rectangle(205, 203, 153, 171));
            Pen pen = new Pen(Color.Red, 3);
            e.Graphics.DrawRectangle(pen, new Rectangle(sx1, sy1, sw, sh));//StaticData.DataList1.RectX1, StaticData.DataList1.RectY1, StaticData.DataList1.RectX2 - StaticData.DataList1.RectX1, StaticData.DataList1.RectY2 - StaticData.DataList1.RectY1));

            // e.Graphics.DrawRectangle(Pens.Red, GetRect());
            Rectangle rect1 = this.pictureBox1.ClientRectangle;
        }
    }
}