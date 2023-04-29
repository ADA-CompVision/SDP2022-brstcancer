using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using breastcancer.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace breastcancer
{
    public partial class Form4 : Form
    {
        bool picBoxDraw = false;
        bool penClick = false;
        int picNum4;
        bool downFlag4;
        int c4;
        int sx1 = 0, sy1 = 0, sw = 0, sh = 0;
        string textCom = "Write a comment...";
        string textEmp = String.Empty;
        string pathCol, pathOri, pathJson;
        public Form4()
        {
            InitializeComponent();

            this.picNum4 = Form2.picNum;
            this.downFlag4 = Form2.downFlag;
            this.c4 = Form2.c;
        }

        string[] files, filesOriginal, filesColored;

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


            buttonClean.FlatAppearance.BorderColor = System.Drawing.Color.Blue;

            buttonClean.ForeColor = System.Drawing.Color.Blue;
            //Color.FromArgb(161, 161, 161);
            buttonClean.BackColor = Color.FromArgb(66, 66, 66);
            buttonClean.FlatStyle = FlatStyle.Flat;
            buttonClean.FlatAppearance.BorderSize = 0;
            IntPtr ptrClean = NativeMethods.CreateRoundRectRgn(-2, -2, this.buttonClean.Width + 2, this.buttonClean.Height + 2, 100, 100);
            this.buttonClean.Region = System.Drawing.Region.FromHrgn(ptrClean);
            NativeMethods.DeleteObject(ptrClean);

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

            string directory = Directory.GetCurrentDirectory();

            pathJson = directory + "\\path.json";
            pathCol = directory + "\\Patients\\Colored";
            pathOri = directory + "\\Patients\\Original";
            //filePath = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\path.json";


            //string filePathOriginal = pathOri;//@"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Original";
            //string filePathColored = pathCol;//@"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Colorized";

            if (!downFlag4)
            {
                filepath = pathOri;
                label3.Text = "Original";
            }
            else
            {
                filepath = pathCol;
                label3.Text = "Colored";
            }

            //////////////////////

      
            files = Directory.GetDirectories(filepath);

            filesColored = Directory.GetFiles(pathCol);
            string[] dirsIMG = Directory.GetFiles(files[c4]);



            //////////////////////////
            sx1 = 0;
            sy1 = 0;
            sw = 0;
            sh = 0;

            //if (picNum4 == 0)
            //{
            //    pictureBox1.Image = Image.FromFile(files[c4]);

            //    sx1 = (int)(StaticData.DataList1.Rect1X1 / 6);
            //    sy1 = (int)(StaticData.DataList1.Rect1Y1 / 6);
            //    sw = (int)((StaticData.DataList1.Rect1X2 - StaticData.DataList1.Rect1X1) / 6);
            //    sh = (int)((StaticData.DataList1.Rect1Y2 - StaticData.DataList1.Rect1Y1) / 6);
            //}
            //else if (picNum4 == 1)
            //{
            //    pictureBox1.Image = Image.FromFile(files[c4 + 1]);
            //    sx1 = (int)(StaticData.DataList1.Rect2X1 / 6);
            //    sy1 = (int)(StaticData.DataList1.Rect2Y1 / 6);
            //    sw = (int)((StaticData.DataList1.Rect2X2 - StaticData.DataList1.Rect2X1) / 6);
            //    sh = (int)((StaticData.DataList1.Rect2Y2 - StaticData.DataList1.Rect2Y1) / 6);
            //}
            //else if (picNum4 == 2)
            //{
            //    pictureBox1.Image = Image.FromFile(files[c4 + 2]);
            //    sx1 = (int)(StaticData.DataList1.Rect3X1 / 6);
            //    sy1 = (int)(StaticData.DataList1.Rect3Y1 / 6);
            //    sw = (int)((StaticData.DataList1.Rect3X2 - StaticData.DataList1.Rect3X1) / 6);
            //    sh = (int)((StaticData.DataList1.Rect3Y2 - StaticData.DataList1.Rect3Y1) / 6);
            //}
            //else if (picNum4 == 3)
            //{
            //    pictureBox1.Image = Image.FromFile(files[c4 + 3]);
            //    sx1 = (int)(StaticData.DataList1.Rect4X1 / 6);
            //    sy1 = (int)(StaticData.DataList1.Rect4Y1 / 6);
            //    sw = (int)((StaticData.DataList1.Rect4X2 - StaticData.DataList1.Rect4X1) / 6);
            //    sh = (int)((StaticData.DataList1.Rect4Y2 - StaticData.DataList1.Rect4Y1) / 6);
            //}

            if (picNum4 == 0)
            {
                picBoxDraw = true;
                pictureBox1.Image = Image.FromFile(dirsIMG[0]);
                sx1 = (int)Math.Abs(StaticData.DataList1.Rect1X1 / 6);
                sy1 = (int)Math.Abs(StaticData.DataList1.Rect1Y1 / 6);
                sw = (int)Math.Abs((StaticData.DataList1.Rect1X2 - StaticData.DataList1.Rect1X1) / 6);
                sh = (int)Math.Abs((StaticData.DataList1.Rect1Y2 - StaticData.DataList1.Rect1Y1) / 6);

                //sx1 = (int)(StaticData.DataList1.Rect1X1 * divX) / 11;
                //sy1 = (int)(StaticData.DataList1.Rect1Y1 * divY) / 11;
                //sw = (int)((StaticData.DataList1.Rect1X2 - StaticData.DataList1.Rect1X1) * divX) / 11;
                //sh = (int)((StaticData.DataList1.Rect1Y2 - StaticData.DataList1.Rect1Y1) * divY) / 11;
                //MessageBox.Show("locax", pictureBox1.Location.X.ToString());
                //MessageBox.Show("size ", pictureBox1.Size.Width.ToString());
                //MessageBox.Show("size h", pictureBox1.Size.Height.ToString());

               // MessageBox.Show("sw = " + sw.ToString() + " sh = " + sh.ToString());
            }
            if (picNum4 == 1)
            {
                picBoxDraw = true;

                pictureBox1.Image = Image.FromFile(dirsIMG[1]);
                sx1 = (int)(StaticData.DataList1.Rect2X1 / 6);
                sy1 = (int)(StaticData.DataList1.Rect2Y1 / 6);
                sw = (int)((StaticData.DataList1.Rect2X2 - StaticData.DataList1.Rect2X1) / 6);
                sh = (int)((StaticData.DataList1.Rect2Y2 - StaticData.DataList1.Rect2Y1) / 6);
              //  MessageBox.Show("sw = " + sw.ToString());

            }
            if (picNum4 == 2)
            {
                picBoxDraw = true;

                pictureBox1.Image = Image.FromFile(dirsIMG[2]);
                sx1 = (int)(StaticData.DataList1.Rect3X1 / 6);
                sy1 = (int)(StaticData.DataList1.Rect3Y1 / 6);
                sw = (int)((StaticData.DataList1.Rect3X2 - StaticData.DataList1.Rect3X1) / 6);
                sh = (int)((StaticData.DataList1.Rect3Y2 - StaticData.DataList1.Rect3Y1) / 6);
             //   MessageBox.Show("sw = " + sw.ToString());

            }
            if (picNum4 == 3)
            {
                picBoxDraw = true;

                pictureBox1.Image = Image.FromFile(dirsIMG[3]);
                sx1 = (int)(StaticData.DataList1.Rect4X1 / 6);
                sy1 = (int)(StaticData.DataList1.Rect4Y1 / 6);
                sw = (int)((StaticData.DataList1.Rect4X2 - StaticData.DataList1.Rect4X1) / 6);
                sh = (int)((StaticData.DataList1.Rect4Y2 - StaticData.DataList1.Rect4Y1) / 6);
              //  MessageBox.Show("sw = " + sw.ToString());

            }

            string[] dirs = Directory.GetDirectories(pathOri);
            string dirName = new DirectoryInfo(dirs[c4]).Name;
            label1.Text = "Patient: " + dirName;

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

        private void radioButtonPositive_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPencil_Click(object sender, EventArgs e)
        {
            this.Close();
            //picBoxDraw = true;

            //if (!penClick)
            //{
            //    var bitmap = (Bitmap)Image.FromFile(@"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Logo\minipencil.png");//dlg.FileName);
            //    this.Cursor = CreateCursor(bitmap, new Size(bitmap.Width / 15, bitmap.Height / 15));
            //    penClick = true;
            //}
            //else
            //{
            //    this.Cursor = Cursors.Default;
            //    penClick = false;
            //}
        }
        public Cursor CreateCursor(Bitmap bitmap, Size size)
        {
            bitmap = new Bitmap(bitmap, size);
            return new Cursor(bitmap.GetHicon());
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            downFlag4 = true;
            //labelRight.Text = "Not Resized";
            //label4.Text = "Brightened";
            //label5.Text = "Highly Brightened";
            //label12.Text = "Darkened";
            this.Close();

            //if (picNum4 == 0)
            //    pictureBox1.Image = Image.FromFile(filesColored[c4]);
            //else if (picNum4 == 1)
            //    pictureBox1.Image = Image.FromFile(filesColored[c4 + 1]);
            //else if (picNum4 == 2)
            //    pictureBox1.Image = Image.FromFile(filesColored[c4 + 2]);
            //else if (picNum4 == 3)
            //    pictureBox1.Image = Image.FromFile(filesColored[c4 + 3]);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Close();


            // picBoxDraw = true;
            downFlag4 = false;
            //labelRight.Text = "Not Resized";
            //label4.Text = "Brightened";
            //label5.Text = "Highly Brightened";
            //label12.Text = "Darkened";

            //if (picNum4 == 0)
            //    pictureBox1.Image = Image.FromFile(filesOriginal[c4]);
            //else if (picNum4 == 1)
            //    pictureBox1.Image = Image.FromFile(filesOriginal[c4 + 1]);
            //else if (picNum4 == 2)
            //    pictureBox1.Image = Image.FromFile(filesOriginal[c4 + 2]);
            //else if (picNum4 == 3)
            //    pictureBox1.Image = Image.FromFile(filesOriginal[c4 + 3]);

            //label1.Text = c + 1 + " out of " + filesOriginal.Length + " images \n";
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
            if (picBoxDraw)
            {
                // e.Graphics.DrawRectangle(Pens.Red, new Rectangle(205, 203, 153, 171));
                Pen pen = new Pen(Color.Red, 3);
                e.Graphics.DrawRectangle(pen, new Rectangle(sx1, sy1, sw, sh));//StaticData.DataList1.RectX1, StaticData.DataList1.RectY1, StaticData.DataList1.RectX2 - StaticData.DataList1.RectX1, StaticData.DataList1.RectY2 - StaticData.DataList1.RectY1));

                // e.Graphics.DrawRectangle(Pens.Red, GetRect());
                Rectangle rect1 = this.pictureBox1.ClientRectangle;
            }
        }
    }
}