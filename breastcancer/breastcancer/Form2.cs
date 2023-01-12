using Newtonsoft.Json;
using breastcancer.Service;

namespace breastcancer
{
    //2800x3518 sekil olcusu
    //215x270 picbobx olcusu
    //13 e bolub seyapmisiq
    //form4 de size 467, 586   yeni 2800/6
    public partial class Form2 : Form
    {
        public static Point LocationXY, LocationX1Y1;
        Rectangle rect;
        bool IsMouseDown = false;
        List<Data> dataList = new List<Data>();
        bool penClick = false;
        string textCom = "Write a comment...";
        string textEmp = "";

        bool btnNavLR = true;

        int ii = 0;
        int prev = 0;
        int d = 0;
        int diagnosisInt = 0;
        int fileCount;
        string[] filesOriginal, filesColored;
        string filePath = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\path.json";
        string jsonData;

        public static int c = 0;
        public static int j;  //when clicked gets the j's value of the list
        public static int picNum;
        public static bool downFlag = false;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
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
            labelMa.ForeColor = Color.White;
            labelMa.BackColor = Color.Transparent;
            labelNotes.ForeColor = Color.White;
            labelNotes.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(161, 161, 161);
            labelRight.ForeColor = Color.FromArgb(161, 161, 161);
            labelLeft.ForeColor = Color.FromArgb(161, 161, 161);
            labelRightM.ForeColor = Color.FromArgb(161, 161, 161);
            labelLeftM.ForeColor = Color.FromArgb(161, 161, 161);

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

            string filePathOriginal = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Original";
            filesOriginal = Directory.GetFiles(filePathOriginal);
            string filePathColored = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Colorized";
            filesColored = Directory.GetFiles(filePathColored);

            fileCount = Directory.GetFiles(filePathOriginal).Length;

            pictureBox1.Image = Image.FromFile(filesOriginal[c]);
            pictureBox2.Image = Image.FromFile(filesOriginal[c + 1]);
            pictureBox3.Image = Image.FromFile(filesOriginal[c + 2]);
            pictureBox4.Image = Image.FromFile(filesOriginal[c + 3]);

            label1.Text = c + 1 + " out of " + filesOriginal.Length / 4 + " images \n";


            if (c == 0) //changed it here
                buttonPrevious.Enabled = false;
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            string str = "";
            buttonPreviousFunction();
            drawPic();
            for (int n = 0; n < dataList.Count; n++)
                str += "id: " + dataList[n].ImageId.ToString() + "\n" + "comm: " + dataList[n].Comment.ToString() + "\n" + "diag: " + dataList[n].Diagnosis.ToString() + "\n" +
                   "rectx1: " + dataList[n].RectX1 + "\nrectX2: " + dataList[n].RectX2 + "\nrecty1:" + dataList[n].RectY1 + "\nrecty2" + dataList[n].RectY2;
            MessageBox.Show(str);
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            string str = "";
            if (c + 4 == fileCount)
                buttonNext.Enabled = false;
            buttonNextFunction();
            for (int n = 0; n < dataList.Count; n++)
                str += "id: " + dataList[n].ImageId.ToString() + "\n" + "comm: " + dataList[n].Comment.ToString() + "\n" + "diag: " + dataList[n].Diagnosis.ToString() + "\n" +
                   "rectx1: " + dataList[n].RectX1 + "\nrectX2: " + dataList[n].RectX2 + "\nrecty1:" + dataList[n].RectY1 + "\nrecty2" + dataList[n].RectY2;

            MessageBox.Show(str);
            if (c != dataList.Count)
                drawPic();
            if (c + 4 == fileCount)
                buttonNext.Enabled = false;
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
            if (rect.Width != 0 && btnNavLR)
            {
                Pen pen = new Pen(Color.Red, 3);
                e.Graphics.DrawRectangle(pen, GetRect());
                Rectangle rect1 = pictureBox2.ClientRectangle;
            }
        }
        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            if (rect.Width != 0 && btnNavLR)
            {
                Pen pen = new Pen(Color.Red, 3);
                e.Graphics.DrawRectangle(pen, GetRect());
                Rectangle rect1 = pictureBox2.ClientRectangle;
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
            if (rect.Width != 0 && btnNavLR)
            {
                Pen pen = new Pen(Color.Red, 3);
                e.Graphics.DrawRectangle(pen, GetRect());
                Rectangle rect1 = pictureBox2.ClientRectangle;
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
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (rect != null && btnNavLR)
            {
                Pen pen = new Pen(Color.Red, 3);
                e.Graphics.DrawRectangle(pen, GetRect());
                Rectangle rect1 = pictureBox1.ClientRectangle;

                //pictureBox1.Invalidate(rect1);
                //pictureBox1.Update();
            }
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (rect != null && btnNavLR)
            {
                Pen pen = new Pen(Color.Red, 3);
                e.Graphics.DrawRectangle(pen, GetRect());
                Rectangle rect1 = pictureBox2.ClientRectangle;
            }
        }
        private void radioButtonPositive_CheckedChanged(object sender, EventArgs e)
        {
            diagnosisInt = 1;
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
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((radioButtonNegative.Checked == true || radioButtonPositive.Checked == true || radioButtonPotential.Checked == true))
                Update(ii);
            JsonSave();
        }
        private void buttonPencil_Click(object sender, EventArgs e)
        {
            btnNavLR = true;

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

        private void drawPic()
        {
            btnNavLR = true;
        }
        private void downCheckFunction(bool downFlag)
        {
            if (!downFlag)
            {
                pictureBox1.Image = Image.FromFile(filesOriginal[c]);
                pictureBox2.Image = Image.FromFile(filesOriginal[c + 1]);
                pictureBox3.Image = Image.FromFile(filesOriginal[c + 2]);
                pictureBox4.Image = Image.FromFile(filesOriginal[c + 3]);
            }
            else
            {
                pictureBox1.Image = Image.FromFile(filesColored[c]);
                pictureBox2.Image = Image.FromFile(filesColored[c + 1]);
                pictureBox3.Image = Image.FromFile(filesColored[c + 2]);
                pictureBox4.Image = Image.FromFile(filesColored[c + 3]);
            }
        }
        private void AddToDataList()
        {
            int cou = 0;
            if (ii >= dataList.Count)
            {
                cou++;
                int id = 1;

                if (dataList.Count == 0 || ii == (dataList.Count))
                {
                    id = dataList.Count + 1;

                    // Add any new data
                    dataList.Add(new Data()
                    {
                        ImageId = id,// w,//get last image id from json file then ++ and assign
                        ImageName = filesOriginal[c].TrimEnd('\\'),
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
            else
            {
                var item = dataList[ii];
                item.RectX1 = LocationXY.X * 13;
                item.RectY1 = LocationXY.Y * 13;
                item.RectX2 = LocationX1Y1.X * 13;
                item.RectY2 = LocationX1Y1.Y * 13;
                //LocationXY.X = 0;
                //LocationXY.Y = 0;
                //LocationX1Y1.X = 0;
                //LocationX1Y1.Y = 0;
            }
        }
        private void buttonNextFunction()
        {
            penClick = false;
            btnNavLR = false;
            prev = 0;
            if (radioButtonNegative.Checked == false && radioButtonPositive.Checked == false && radioButtonPotential.Checked == false)
            {
                //MessageBox.Show("You need to choose one option");
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
                        ImageName = filesOriginal[c].TrimEnd('\\'),
                        Diagnosis = diagnosisInt,
                        Comment = textBoxComment.Text,
                        DoctorId = 1,
                        RectX1 = LocationXY.X * 13,
                        RectY1 = LocationXY.Y * 13,
                        RectX2 = LocationX1Y1.X * 13,
                        RectY2 = LocationX1Y1.Y * 13
                    });
                    Update(ii);

                    textBoxComment.Text = textEmp;

                    radioButtonPositive.Checked = false;
                    radioButtonPotential.Checked = false;
                    radioButtonNegative.Checked = false;


                    if (c == filesOriginal.Length - 1)
                        buttonNext.Enabled = false;
                    else
                    {
                        c += 4;
                        buttonPrevious.Enabled = true;
                        label1.Text = c + 1 + " out of " + filesOriginal.Length + " images \n";// + files[c];

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
                        LocationXY.X = item.RectX1 / 13; //////////added later
                        LocationXY.Y = item.RectY1 / 13;
                        LocationX1Y1.X = item.RectX2 / 13;
                        LocationX1Y1.Y = item.RectY2 / 13;

                        if (c == filesOriginal.Length - 1)
                            buttonNext.Enabled = false;
                        else
                        {
                            c++;
                            buttonPrevious.Enabled = true;
                            label1.Text = c + 1 + " out of " + filesOriginal.Length + " images \n";// + files[c];

                            downCheckFunction(downFlag);
                        }
                    }
                    else
                    {
                        //end of file so we are clearing the data

                        textBoxComment.Text = textEmp;

                        radioButtonPositive.Checked = false;
                        radioButtonPotential.Checked = false;
                        radioButtonNegative.Checked = false;

                        //added later
                        c += 4;
                        buttonPrevious.Enabled = true;
                        label1.Text = c + 1 + " out of " + filesOriginal.Length + " images \n";// + files[c];

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
            //item.RectX1 = LocationXY.X * 13;
            //item.RectY1 = LocationXY.Y * 13;
            //item.RectX2 = LocationX1Y1.X * 13;
            //item.RectY2 = LocationX1Y1.Y * 13;
            if (ii == dataList.Count - 1)
            {
                LocationXY.X = 0;
                LocationXY.Y = 0;
                LocationX1Y1.X = 0;
                LocationX1Y1.Y = 0;
            }
        }
        private void buttonUpFunction()
        {
            btnNavLR = true;
            downFlag = false;
            //labelRight.Text = "Not Resized";
            //label4.Text = "Brightened";
            //label5.Text = "Highly Brightened";
            //label12.Text = "Darkened";


            pictureBox1.Image = Image.FromFile(filesOriginal[c]);
            pictureBox2.Image = Image.FromFile(filesOriginal[c + 1]);
            pictureBox3.Image = Image.FromFile(filesOriginal[c + 2]);
            pictureBox4.Image = Image.FromFile(filesOriginal[c + 3]);

            label1.Text = c + 1 + " out of " + filesOriginal.Length + " images \n";
        }
        private void buttonDownFunction()
        {
            downFlag = true;
            btnNavLR = true;

            //labelRight.Text = "Color 1";
            //label4.Text = "Color 2";
            //label5.Text = "Color 3";
            //label12.Text = "Color 4";

            pictureBox1.Image = Image.FromFile(filesColored[c]);
            pictureBox2.Image = Image.FromFile(filesColored[c + 1]);
            pictureBox3.Image = Image.FromFile(filesColored[c + 2]);
            pictureBox4.Image = Image.FromFile(filesColored[c + 3]);

            label1.Text = c + 1 + " out of " + filesColored.Length + " images \n";
        }
        private void buttonPreviousFunction()
        {
            penClick = false;
            btnNavLR = false;
            if (c == 0) //changed it here
                buttonPrevious.Enabled = false;
            else
            {
                if (ii >= dataList.Count())
                {
                }
                else
                {
                    Update(ii);
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
                LocationXY.X = item.RectX1 / 13;
                LocationXY.Y = item.RectY1 / 13;
                LocationX1Y1.X = item.RectX2 / 13;
                LocationX1Y1.Y = item.RectY2 / 13;

                c -= 4;
                buttonNext.Enabled = true;
                label1.Text = c + 1 + " out of " + filesColored.Length + " images \n";// + filesNotResized[c];
                                                                                      //    MessageBox.Show(c.ToString());

                downCheckFunction(downFlag);
            }
            if (prev > 0) prev--;
            if (c == 0) //changed it here
                buttonPrevious.Enabled = false;

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