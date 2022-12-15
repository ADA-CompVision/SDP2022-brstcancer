using Newtonsoft.Json;
using breastcancer.Service;

namespace breastcancer
{
    public partial class Form2 : Form
    {
        public static Point LocationXY, LocationX1Y1;
        Rectangle rect;
        bool IsMouseDown = false;
        List<Data> dataList = new List<Data>();
        bool penClick = false;
        string textCom = "Write a comment...";
        string textEmp = "";

        int ii = 0;
        int prev = 0;
        int d = 0;
        int diagnosisInt = 0;
        string[] filesNotResized, filesBrightened, filesDarked, filesHighlyBrightened, filesColor1_600, filesColor2_600, filesColor3_600;
        string[] filesColor1, filesColor2, filesColor3, filesColor4, filesColor5, filesResizedTo511, filesResizedTo255, filesResizedTo1000, filesResizedTo1023;
        string filePath = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\path.json";
        string jsonData;

        public static int c = 0;
        public static int j;  //when clicked gets the j's value of the list
        public static int picNum;
        public static bool downFlag = false;

        Control control = new Control();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
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
            label3.Text = "Original";
            label4.ForeColor = Color.FromArgb(161, 161, 161);
            label4.Text = "Brightened";
            label5.ForeColor = Color.FromArgb(161, 161, 161);
            label5.Text = "Highly Brightened";
            label12.ForeColor = Color.FromArgb(161, 161, 161);
            label12.Text = "Darkened";
            label8.ForeColor = Color.FromArgb(161, 161, 161);
            label8.Text = "Resized to 255";
            label7.ForeColor = Color.FromArgb(161, 161, 161);
            label7.Text = "Resized to 511";
            label6.ForeColor = Color.FromArgb(161, 161, 161);
            label6.Text = "Resized to 1000";
            label11.ForeColor = Color.FromArgb(161, 161, 161);
            label11.Text = "Resized to 1023";

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

            // Read existing json data
            jsonData = System.IO.File.ReadAllText(filePath);
            // De-serialize to object or create new list
            dataList = JsonConvert.DeserializeObject<List<Data>>(jsonData)
                                  ?? new List<Data>();



            string filePathBrightened = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Brightened";
            filesBrightened = Directory.GetFiles(filePathBrightened);
            string filePathColor1 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color1";
            filesColor1 = Directory.GetFiles(filePathColor1);
            string filePathColor1_600 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color1_600";
            filesColor1_600 = Directory.GetFiles(filePathColor1_600);
            string filePathColor2 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color2";
            filesColor2 = Directory.GetFiles(filePathColor2);
            string filePathColor2_600 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color2_600";
            filesColor2_600 = Directory.GetFiles(filePathColor2_600);
            string filePathColor3 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color3";
            filesColor3 = Directory.GetFiles(filePathColor3);
            string filePathColor3_600 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color3_600";
            filesColor3_600 = Directory.GetFiles(filePathColor3_600);
            string filePathColor4 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color4";
            filesColor4 = Directory.GetFiles(filePathColor4);
            string filePathColor5 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color5";
            filesColor5 = Directory.GetFiles(filePathColor5);
            string filePathDarked = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Darked";
            filesDarked = Directory.GetFiles(filePathDarked);
            string filePathHighlyBrightened = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\HighlyBrightened";
            filesHighlyBrightened = Directory.GetFiles(filePathHighlyBrightened);
            string filePathNotResized = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\NotResized";
            filesNotResized = Directory.GetFiles(filePathNotResized);
            string filePathResizedTo255 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo255";
            filesResizedTo255 = Directory.GetFiles(filePathResizedTo255);
            string filePathResizedTo511 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo511";
            filesResizedTo511 = Directory.GetFiles(filePathResizedTo511);
            string filePathResizedTo1000 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo1000";
            filesResizedTo1000 = Directory.GetFiles(filePathResizedTo1000);
            string filePathResizedTo1023 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo1023";
            filesResizedTo1023 = Directory.GetFiles(filePathResizedTo1023);


            pictureBox1.Image = Image.FromFile(filesNotResized[c]);
            pictureBox2.Image = Image.FromFile(filesBrightened[c]);
            pictureBox3.Image = Image.FromFile(filesHighlyBrightened[c]);
            pictureBox4.Image = Image.FromFile(filesDarked[c]);
            pictureBox5.Image = Image.FromFile(filesResizedTo255[c]);
            pictureBox6.Image = Image.FromFile(filesResizedTo511[c]);
            pictureBox7.Image = Image.FromFile(filesResizedTo1000[c]);
            pictureBox8.Image = Image.FromFile(filesResizedTo1023[c]);

            label1.Text = c + 1 + " out of " + filesNotResized.Length + " images \n";
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            string str = "";
            buttonPreviousFunction();
            for (int n = 0; n < dataList.Count; n++)
                str += "id: " + dataList[n].ImageId.ToString() + "\n" + "comm: " + dataList[n].Comment.ToString() + "\n" + "diag: " + dataList[n].Diagnosis.ToString() + "\n" + "\n";
            MessageBox.Show(str);
            drawPicAll(c);
        }


        //private void buttonPreviousFunctionDraw()
        //{
        //this function is gonna work in the next updates after checking the lists
        //buttonPreviousFunction();
        //string str = "";

        //for (int n = 0; n < dataList.Count; n++)
        //    str += "id: " + dataList[n].ImageId.ToString() + "\n" + "comm: " + dataList[n].Comment.ToString() + "\n" + "diag: " + dataList[n].Diagnosis.ToString() + "\n" + "\n";
        //MessageBox.Show(str);
        //drawPicAll(c);
        //}
        private void buttonNext_Click(object sender, EventArgs e)
        {
            string str = "";
            buttonNextFunction();
            for (int n = 0; n < dataList.Count; n++)
                str += "id: " + dataList[n].ImageId.ToString() + "\n" + "comm: " + dataList[n].Comment.ToString() + "\n" + "diag: " + dataList[n].Diagnosis.ToString() + "\n" + "\n";

            MessageBox.Show(str);
            if (c != dataList.Count)
                drawPicAll(c);
        }
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.buttonUp.Focus();
                buttonUpFunction();
            }
            else if (e.KeyCode == Keys.Down)
            {
                this.buttonDown.Focus();
                buttonDownFunction();
            }
            else if (e.KeyCode == Keys.Right)
            {
                //if(!this.textBoxComment.Focus())
                this.buttonNext.Focus();
                buttonNextFunction();
            }
            else if (e.KeyCode == Keys.Left)
            {
                this.buttonPrevious.Focus();
                buttonPreviousFunction();
            }
        }
        private void JsonSave()
        {
            // Update json data string
            jsonData = JsonConvert.SerializeObject(dataList, Formatting.Indented);
            System.IO.File.WriteAllText(filePath, jsonData);
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (penClick)
            {
                IsMouseDown = true;
                LocationXY = e.Location;
            }
        }
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                Refresh();
            }
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                IsMouseDown = false;
            }
        }
        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            if (rect != null)// && penClick)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
                Rectangle rect1 = pictureBox3.ClientRectangle;
            }
        }
        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {

            if (rect != null)// && penClick)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
                Rectangle rect1 = pictureBox4.ClientRectangle;
            }
        }
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (penClick)
            {
                IsMouseDown = true;
                LocationXY = e.Location;
            }
        }
        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                IsMouseDown = false;
            }
        }
        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                Refresh();
            }
        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            if (penClick)
            {
                IsMouseDown = true;
                LocationXY = e.Location;
            }
        }
        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                Refresh();
            }
        }
        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                IsMouseDown = false;
            }
        }
        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {

            if (rect != null)// && penClick)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
                Rectangle rect1 = pictureBox5.ClientRectangle;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(3, 3, this.panel1.Width, this.panel1.Height, 11, 11); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.panel1.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(3, 3, this.panel2.Width, this.panel2.Height, 11, 11); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.panel2.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(3, 3, this.panel4.Width, this.panel4.Height, 11, 11); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.panel4.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }
        public Cursor CreateCursor(Bitmap bitmap, Size size)
        {
            bitmap = new Bitmap(bitmap, size);
            return new Cursor(bitmap.GetHicon());
        }
        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            if (penClick)
            {
                IsMouseDown = true;
                LocationXY = e.Location;
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (penClick)
            {
                IsMouseDown = true;
                LocationXY = e.Location;
            }
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (penClick)
            {
                IsMouseDown = true;
                LocationXY = e.Location;
            }
        }
        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            if (penClick)
            {
                IsMouseDown = true;
                LocationXY = e.Location;
            }
        }
        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            if (penClick)
            {
                IsMouseDown = true;
                LocationXY = e.Location;
            }
        }
        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                Refresh();
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                Refresh();
            }
        }
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                Refresh();
            }
        }
        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                Refresh();
            }
        }
        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                Refresh();
            }
        }
        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                IsMouseDown = false;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                IsMouseDown = false;
            }
        }
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                IsMouseDown = false;
            }
        }
        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                IsMouseDown = false;
            }
        }
        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                IsMouseDown = false;
            }
        }
        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {

            if (rect != null)// && penClick)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
                Rectangle rect1 = pictureBox7.ClientRectangle;
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            if (rect != null)// && penClick)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
                Rectangle rect1 = pictureBox1.ClientRectangle;
            }
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {

            if (rect != null)// && penClick)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
                Rectangle rect1 = pictureBox2.ClientRectangle;
            }
        }
        private void radioButtonPositive_CheckedChanged(object sender, EventArgs e)
        {
            diagnosisInt = 1;
        }
        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {

            if (rect != null)// && penClick)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
                Rectangle rect1 = pictureBox6.ClientRectangle;
            }
        }
        private void radioButtonPotential_CheckedChanged(object sender, EventArgs e)
        {
            diagnosisInt = 2;
        }
        private void radioButtonNegative_CheckedChanged(object sender, EventArgs e)
        {
            diagnosisInt = 3;
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
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            picNum = 0;
            AddToDataList();
            CreateStaticData(ii);
            Form4 frm4 = new Form4();
            frm4.Show();
        }
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            picNum = 1;
            AddToDataList();
            CreateStaticData(ii);
            Form4 frm4 = new Form4();
            frm4.Show();
        }
        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            picNum = 2;
            AddToDataList();
            CreateStaticData(ii);
            Form4 frm4 = new Form4();
            frm4.Show();
        }
        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            picNum = 3;
            AddToDataList();
            CreateStaticData(ii);
            Form4 frm4 = new Form4();
            frm4.Show();
        }
        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            picNum = 4;
            AddToDataList();
            CreateStaticData(ii);
            Form4 frm4 = new Form4();
            frm4.Show();
        }
        private void pictureBox6_DoubleClick(object sender, EventArgs e)
        {
            picNum = 5;
            AddToDataList();
            CreateStaticData(ii);
            Form4 frm4 = new Form4();
            frm4.Show();
        }
        private void pictureBox7_DoubleClick(object sender, EventArgs e)
        {
            picNum = 6;
            AddToDataList();
            CreateStaticData(ii);
            Form4 frm4 = new Form4();
            frm4.Show();
        }
        private void pictureBox8_DoubleClick(object sender, EventArgs e)
        {
            picNum = 6;
            AddToDataList();
            CreateStaticData(ii);
            Form4 frm4 = new Form4();
            frm4.Show();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((radioButtonNegative.Checked == true || radioButtonPositive.Checked == true || radioButtonPotential.Checked == true))
                Update(ii);
            JsonSave();
        }
        private void pictureBox8_Paint(object sender, PaintEventArgs e)
        {

            if (rect != null)// && penClick)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
                Rectangle rect1 = pictureBox8.ClientRectangle;
            }
        }
        private void buttonPencil_Click(object sender, EventArgs e)
        {
            if (!penClick)
            {
                var bitmap = (Bitmap)Image.FromFile(@"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Logo\minipencil.png");//dlg.FileName);
                this.Cursor = CreateCursor(bitmap, new Size(bitmap.Width / 15, bitmap.Height / 15));
                penClick = true;
            }
            else
            {
                this.Cursor = Cursors.Default;
                penClick = false;
            }
        }
        private void buttonUp_Click(object sender, EventArgs e)
        {
            buttonUpFunction();
        }
        private void Form2_Activated(object sender, EventArgs e)
        {
            CopyStaticDataToDataList();
        }
        private void buttonDown_Click(object sender, EventArgs e)
        {
            buttonDownFunction();
        }
        private Rectangle GetRect()
        {
            rect = new Rectangle();
            rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
            rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);

            rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
            rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);

            return rect;
        }
        private void drawPicAll(int c)
        {
            drawPic(pictureBox1, c);
            drawPic(pictureBox2, c);
            drawPic(pictureBox3, c);
            drawPic(pictureBox4, c);
            drawPic(pictureBox5, c);
            drawPic(pictureBox6, c);
            drawPic(pictureBox7, c);
            drawPic(pictureBox8, c);
        }
        private void drawPic(PictureBox pb, int n)
        {
            Graphics g = pb.CreateGraphics();

            g.DrawRectangle(Pens.Red, new Rectangle(dataList[n].RectX1, dataList[n].RectY1, dataList[n].RectX2 - dataList[n].RectX1, dataList[n].RectY2 - dataList[n].RectY1));
            // Rectangle rect1 = pb.ClientRectangle;
        }
        private void downCheckFunction(bool downFlag)
        {
            if (!downFlag)
            {
                pictureBox1.Image = Image.FromFile(filesNotResized[c]);
                pictureBox2.Image = Image.FromFile(filesBrightened[c]);
                pictureBox3.Image = Image.FromFile(filesHighlyBrightened[c]);
                pictureBox4.Image = Image.FromFile(filesDarked[c]);
                pictureBox5.Image = Image.FromFile(filesResizedTo255[c]);
                pictureBox6.Image = Image.FromFile(filesResizedTo511[c]);
                pictureBox7.Image = Image.FromFile(filesResizedTo1000[c]);
                pictureBox8.Image = Image.FromFile(filesResizedTo1023[c]);
            }
            else
            {
                pictureBox1.Image = Image.FromFile(filesColor1[c]);
                pictureBox2.Image = Image.FromFile(filesColor2[c]);
                pictureBox3.Image = Image.FromFile(filesColor3[c]);
                pictureBox4.Image = Image.FromFile(filesColor4[c]);
                pictureBox5.Image = Image.FromFile(filesColor5[c]);
                pictureBox6.Image = Image.FromFile(filesColor1_600[c]);
                pictureBox7.Image = Image.FromFile(filesColor2_600[c]);
                pictureBox8.Image = Image.FromFile(filesColor3_600[c]);
            }
        }
        private void AddToDataList()
        {
            if (ii >= dataList.Count)
            {
                int id = 1;

                if (dataList.Count == 0 || ii == (dataList.Count))
                {
                    id = dataList.Count + 1;

                    // Add any new data
                    dataList.Add(new Data()
                    {
                        ImageId = id,// w,//get last image id from json file then ++ and assign
                        ImageName = filesNotResized[c].TrimEnd('\\'),
                        Diagnosis = diagnosisInt,
                        Comment = textBoxComment.Text,
                        DoctorId = 1,
                        RectX1 = LocationXY.X * 13,
                        RectY1 = LocationXY.Y * 13,
                        RectX2 = LocationX1Y1.X * 13,
                        RectY2 = LocationX1Y1.Y * 13
                    });
                }
            }
        }
        private void buttonNextFunction()
        {
            penClick = false;
            prev = 0;
            if (radioButtonNegative.Checked == false && radioButtonPositive.Checked == false && radioButtonPotential.Checked == false)
            {
                MessageBox.Show("You need to choose one option");
            }
            else
            {
                int id = 1;
                if (dataList.Count == 0 || ii == (dataList.Count))
                {
                    id = dataList.Count + 1;

                    // Add any new data
                    dataList.Add(new Data()
                    {
                        ImageId = id,// w,//get last image id from json file then ++ and assign
                        ImageName = filesNotResized[c].TrimEnd('\\'),
                        Diagnosis = diagnosisInt,
                        Comment = textBoxComment.Text,
                        DoctorId = 1,
                        RectX1 = LocationXY.X * 13,
                        RectY1 = LocationXY.Y * 13,
                        RectX2 = LocationX1Y1.X * 13,
                        RectY2 = LocationX1Y1.Y * 13
                    });
                    Update(ii);

                    textBoxComment.Text = "";

                    radioButtonPositive.Checked = false;
                    radioButtonPotential.Checked = false;
                    radioButtonNegative.Checked = false;


                    if (c == filesNotResized.Length - 1)
                        buttonNext.Enabled = false;
                    else
                    {
                        c++;
                        buttonPrevious.Enabled = true;
                        label1.Text = c + 1 + " out of " + filesNotResized.Length + " images \n";// + files[c];

                        downCheckFunction(downFlag);
                    }
                    ii++;
                }
                else
                {
                    Update(ii);
                    ii++;
                    if (ii < dataList.Count)
                    {
                        var item = dataList[ii];

                        this.textBoxComment.Text = item.Comment;

                        if (item.Diagnosis == 1)
                        {
                            this.radioButtonPositive.Checked = true;
                            d = 1;
                        }
                        else if (item.Diagnosis == 2)
                        {
                            this.radioButtonPotential.Checked = true;
                            d = 2;
                        }
                        else if (item.Diagnosis == 3)
                        {
                            this.radioButtonNegative.Checked = true;
                            d = 3;
                        }

                        if (c == filesNotResized.Length - 1)
                            buttonNext.Enabled = false;
                        else
                        {
                            c++;
                            buttonPrevious.Enabled = true;
                            label1.Text = c + 1 + " out of " + filesNotResized.Length + " images \n";// + files[c];

                            downCheckFunction(downFlag);
                        }
                    }
                    else
                    {
                        //end of file so we are clearing the data

                        textBoxComment.Text = "";

                        radioButtonPositive.Checked = false;
                        radioButtonPotential.Checked = false;
                        radioButtonNegative.Checked = false;

                        //added later
                        c++;
                        buttonPrevious.Enabled = true;
                        label1.Text = c + 1 + " out of " + filesNotResized.Length + " images \n";// + files[c];

                        downCheckFunction(downFlag);
                    }
                }
            }
        }
        private void Update(int i)
        {
            //update
            var item = dataList[i];

            item.Comment = this.textBoxComment.Text;

            if (this.radioButtonPositive.Checked)
            {
                item.Diagnosis = 1;
            }
            else if (this.radioButtonPotential.Checked)
            {
                item.Diagnosis = 2;
            }
            else if (this.radioButtonNegative.Checked)
            {
                item.Diagnosis = 3;
            }
            item.RectX1 = LocationXY.X;
            item.RectY1 = LocationXY.Y;
            item.RectX2 = LocationX1Y1.X;
            item.RectY2 = LocationX1Y1.Y;
        }
        private void buttonUpFunction()
        {
            downFlag = false;
            label3.Text = "Not Resized";
            label4.Text = "Brightened";
            label5.Text = "Highly Brightened";
            label12.Text = "Darkened";
            label8.Text = "Resized to 255";
            label7.Text = "Resized to 511";
            label6.Text = "Resized to 1000";
            label11.Text = "Resized to 1023";

            pictureBox1.Image = Image.FromFile(filesNotResized[c]);
            pictureBox2.Image = Image.FromFile(filesBrightened[c]);
            pictureBox3.Image = Image.FromFile(filesHighlyBrightened[c]);
            pictureBox4.Image = Image.FromFile(filesDarked[c]);
            pictureBox5.Image = Image.FromFile(filesResizedTo255[c]);
            pictureBox6.Image = Image.FromFile(filesResizedTo511[c]);
            pictureBox7.Image = Image.FromFile(filesResizedTo1000[c]);
            pictureBox8.Image = Image.FromFile(filesResizedTo1023[c]);


            label1.Text = c + 1 + " out of " + filesNotResized.Length + " images \n";
        }
        private void buttonDownFunction()
        {
            downFlag = true;
            label3.Text = "Color 1";
            label4.Text = "Color 2";
            label5.Text = "Color 3";
            label12.Text = "Color 4";
            label8.Text = "Color 5";
            label7.Text = "1 Resized to 600";
            label6.Text = "2 Resized to 600";
            label11.Text = "3 Resized to 600";

            pictureBox1.Image = Image.FromFile(filesColor1[c]);
            pictureBox2.Image = Image.FromFile(filesColor2[c]);
            pictureBox3.Image = Image.FromFile(filesColor3[c]);
            pictureBox4.Image = Image.FromFile(filesColor4[c]);
            pictureBox5.Image = Image.FromFile(filesColor5[c]);
            pictureBox6.Image = Image.FromFile(filesColor1_600[c]);
            pictureBox7.Image = Image.FromFile(filesColor2_600[c]);
            pictureBox8.Image = Image.FromFile(filesColor3_600[c]);

            label1.Text = c + 1 + " out of " + filesNotResized.Length + " images \n";
        }
        private void buttonPreviousFunction()
        {
            penClick = false;

            if (c == 0)
                buttonPrevious.Enabled = false;
            else
            {
                if (ii >= dataList.Count())
                {
                    //ii = dataList.Count - 1;
                }
                else
                {
                    Update(ii);
                    //JsonSave();test
                }
                ii--;

                var item = dataList[ii];
                this.textBoxComment.Text = item.Comment;

                if (item.Diagnosis == 1)
                {
                    this.radioButtonPositive.Checked = true;
                    d = 1;
                }
                else if (item.Diagnosis == 2)
                {
                    this.radioButtonPotential.Checked = true;
                    d = 2;
                }
                else if (item.Diagnosis == 3)
                {
                    this.radioButtonNegative.Checked = true;
                    d = 3;
                }

                item = dataList[ii];

                c--;
                buttonNext.Enabled = true;
                label1.Text = c + 1 + " out of " + filesNotResized.Length + " images \n";// + filesNotResized[c];

                downCheckFunction(downFlag);
                //if (!u1)
                //    ii--;
            }
            if (prev > 0) prev--;
        }
        private void CreateStaticData(int i)
        {
            j = i;
            var item1 = dataList[i];
            StaticData.DataList1.ImageId = item1.ImageId;
            StaticData.DataList1.DoctorId = item1.DoctorId;
            StaticData.DataList1.Diagnosis = item1.Diagnosis;
            StaticData.DataList1.Comment = item1.Comment;
            StaticData.DataList1.RectX1 = item1.RectX1;
            StaticData.DataList1.RectY1 = item1.RectY1;
            StaticData.DataList1.RectX2 = item1.RectX2;
            StaticData.DataList1.RectY2 = item1.RectY2;
        }
        private void CopyStaticDataToDataList()
        {
            if (j < dataList.Count && StaticData.DataList1.Diagnosis != 0)
            {
                var item1 = dataList[j];
                item1.ImageId = StaticData.DataList1.ImageId;
                item1.DoctorId = StaticData.DataList1.DoctorId;
                item1.Diagnosis = StaticData.DataList1.Diagnosis;
                item1.Comment = StaticData.DataList1.Comment;
                item1.RectX1 = StaticData.DataList1.RectX1;
                item1.RectY1 = StaticData.DataList1.RectY1;
                item1.RectX2 = StaticData.DataList1.RectX2;
                item1.RectY2 = StaticData.DataList1.RectY2;
            }
        }
    }
}