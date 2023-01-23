﻿using breastcancer.Service;
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

namespace breastcancer
{
    public partial class FormZoom : Form
    {
        bool btnNavLR = false;
        bool penClick = false;
        int picNum4;
        bool downFlag4;
        int c4;
        int sx1, sy1, sw, sh;
        int width, height;
        public FormZoom(int w, int h)
        {
            InitializeComponent();

            this.picNum4 = Form2.picNum;
            this.downFlag4 = Form2.downFlag;
            this.c4 = Form2.c;
            this.width = w;
            this.height = h;
        }


        string[] files;

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
            e.Graphics.DrawRectangle(pen, new Rectangle(sx1, sy1, sw, sh));
            Rectangle rect1 = this.pictureBox1.ClientRectangle;
        }

        private Font fnt = new Font("Arial", 10);
        string filepath;

        private void FormZoom_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox1.Size.Width = this.WindowState / this.pictureBox1.Size.Width;
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
            this.BackColor = Color.FromArgb(34, 34, 34);


            string filePathOriginal = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Original";
            string filePathColored = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Colorized";


            if (!downFlag4)
            {
                filepath = filePathOriginal;
                //label3.Text = "Original";
            }
            else
            {
                filepath = filePathColored;
                // label3.Text = "Colored";
            }

            files = Directory.GetFiles(filepath);
            int divX = pictureBox1.Size.Width / width;
            int divY = pictureBox1.Size.Height / height;

            //sx1 = (int)(StaticData.DataList1.Rect1X2 - StaticData.DataList1.Rect1X1) / pictureBox1.Size.Width;
            //sy1 = (int)(StaticData.DataList1.Rect1Y2 - StaticData.DataList1.Rect1Y1) / pictureBox1.Size.Height;

            //sx1 = (int)(StaticData.DataList1.Rect1X1 / (StaticData.DataList1.Rect1X2 - StaticData.DataList1.Rect1X1));
            //sy1 = (int)(StaticData.DataList1.Rect1Y1 / (StaticData.DataList1.Rect1X2 - StaticData.DataList1.Rect1X1));

            if (picNum4 == 0)
            {
                pictureBox1.Image = Image.FromFile(files[c4]);

                sx1 = (int)(StaticData.DataList1.Rect1X1 * divX)/11;
                sy1 = (int)(StaticData.DataList1.Rect1Y1 * divY)/11;
                sw = (int)((StaticData.DataList1.Rect1X2 - StaticData.DataList1.Rect1X1) * divX)/11;
                sh = (int)((StaticData.DataList1.Rect1Y2 - StaticData.DataList1.Rect1Y1) * divY) / 11;
            }
            else if (picNum4 == 1)
            {
                pictureBox1.Image = Image.FromFile(files[c4 + 1]);
                //sx1 = (int)(StaticData.DataList1.Rect2X1 / 6);
                //sy1 = (int)(StaticData.DataList1.Rect2Y1 / 6);
                //sw = (int)((StaticData.DataList1.Rect2X2 - StaticData.DataList1.Rect2X1) / 6);
                //sh = (int)((StaticData.DataList1.Rect2Y2 - StaticData.DataList1.Rect2Y1) / 6);
            }
            else if (picNum4 == 2)
            {
                pictureBox1.Image = Image.FromFile(files[c4 + 2]);
                //sx1 = (int)(StaticData.DataList1.Rect3X1 / 6);
                //sy1 = (int)(StaticData.DataList1.Rect3Y1 / 6);
                //sw = (int)((StaticData.DataList1.Rect3X2 - StaticData.DataList1.Rect3X1) / 6);
                //sh = (int)((StaticData.DataList1.Rect3Y2 - StaticData.DataList1.Rect3Y1) / 6);
            }
            else if (picNum4 == 3)
            {
                pictureBox1.Image = Image.FromFile(files[c4 + 3]);
                //sx1 = (int)(StaticData.DataList1.Rect4X1 / 6);
                //sy1 = (int)(StaticData.DataList1.Rect4Y1 / 6);
                //sw = (int)((StaticData.DataList1.Rect4X2 - StaticData.DataList1.Rect4X1) / 6);
                //sh = (int)((StaticData.DataList1.Rect4Y2 - StaticData.DataList1.Rect4Y1) / 6);
            }
        }
    }
}


