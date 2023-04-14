using Newtonsoft.Json;
using breastcancer.Service;
using System.Reflection;
using System.Diagnostics;
using System.IO;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using static IronPython.Modules._ast;
using System.Linq;
using IronPython.Runtime;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace breastcancer
{
    //2800x3518 sekil olcusu
    //255x320 picbobx olcusu
    //11 e bolub seyapmisiq                      11e boleceyik
    //form4 de size 467, 586   yeni 2800/6
    public partial class Form2 : Form
    {
        //kohne public static Point LocationXY, LocationX1Y1;
        //teze
        public static Point Location1XY, Location2XY, Location3XY, Location4XY;
        public static Point Location1X1Y1, Location2X1Y1, Location3X1Y1, Location4X1Y1;
        public bool[] PictureBoxClicked = new bool[4];
        //teze end
        Rectangle rect;
        bool IsMouseDown = false;
        List<Data> dataList = new List<Data>();

        Data tempData = new Data();

        bool penClick = false;
        string textCom = "Write a comment...";
        string textEmp = "";

        bool btnNavLR = true;

        int ii;// = 0;
        int prev = 0;
        int d = 0;
        int diagnosisInt = 0;
        int fileCount;
        string[] filesOriginal, filesColored;

        // string filePath = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\path.json";
        string jsonData;

        public static int c = 0;
        public static int j;  //when clicked gets the j's value of the list
        public static int picNum;
        public static bool downFlag = false;
        string pathJson, pathCol, pathOri, filePath, pathPencil;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dcm_to_png();

            String patientId = "";

            string directory = Directory.GetCurrentDirectory();
            //var parentName = Directory.GetParent(directory).FullName;
            //parentName = Directory.GetParent(parentName).FullName;
            //parentName = Directory.GetParent(parentName).FullName;
            //parentName = Directory.GetParent(parentName).FullName;
            //parentName = Directory.GetParent(parentName).FullName;        //E:\OneDrive\Desktop\SDP2022-brstcancer

            pathJson = directory + "\\path.json";
            pathCol = directory + "\\Augmentation\\Colorized";
            pathOri = directory + "\\Patients\\";

            LoadData();
        }
        private void dcm_to_png()
        {
            string directory = Directory.GetCurrentDirectory();
            //var parentName = Directory.GetParent(directory).FullName;
            //parentName = Directory.GetParent(parentName).FullName;
            //parentName = Directory.GetParent(parentName).FullName;
            //parentName = Directory.GetParent(parentName).FullName;
            //parentName = Directory.GetParent(parentName).FullName;        //E:\OneDrive - ADA University\Homework\SDP2022-brstcancer


            var psi = new ProcessStartInfo();
            psi.FileName = @"E:\User\anaconda3\python.exe";

            var script = directory + "\\dcm_to_png.py";               //@"E:\OneDrive\Desktop\dcm_to_png.py";
                                                                                //var fname = parentName + "\\test.png";                              // @"E:\OneDrive\Desktop\test.png";
                                                                                //var pth =  parentName+ "\\dicoms\\";              
                                                                                //   MessageBox.Show(pth);
            psi.Arguments = $"\"{script}\"";             // \"{pth}\"";    // \"{filename}\"";


            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            var errors = "";
            var results = "";

            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }
            Console.WriteLine("ERRORS:");
            MessageBox.Show(errors, " Errors");
            Console.WriteLine(errors);
            Console.WriteLine();
            Console.WriteLine("Results:");
            Console.WriteLine(results);
            MessageBox.Show(results, " results");

        }
        private void LoadData()
        {
            ii = dataList.Count();
            PictureBoxClicked[0] = false;
            PictureBoxClicked[1] = false;
            PictureBoxClicked[2] = false;
            PictureBoxClicked[3] = false;

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
            lbl_lpm_prediction.ForeColor = Color.FromArgb(161, 161, 161);
            lbl_lp_prediction.ForeColor = Color.FromArgb(161, 161, 161);
            lbl_rpm_prediction.ForeColor = Color.FromArgb(161, 161, 161);
            lbl_rp_prediction.ForeColor = Color.FromArgb(161, 161, 161);
            lbl_patient.ForeColor = Color.FromArgb(161, 161, 161);

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

            buttonTest.ForeColor = Color.FromArgb(161, 161, 161);
            buttonTest.BackColor = Color.FromArgb(66, 66, 66);
            buttonTest.FlatStyle = FlatStyle.Flat;
            buttonTest.FlatAppearance.BorderSize = 0;
            IntPtr ptrTest = NativeMethods.CreateRoundRectRgn(-2, -2, this.buttonTest.Width + 2, this.buttonTest.Height + 2, 100, 100);
            this.buttonTest.Region = System.Drawing.Region.FromHrgn(ptrTest);
            NativeMethods.DeleteObject(ptrTest);

            IntPtr ptr = NativeMethods.CreateRoundRectRgn(2, 2, this.textBoxComment.Width - 1, this.textBoxComment.Height - 1, 5, 5); //play with these values till you are happy
            this.textBoxComment.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);

            // Read existing json data
            jsonData = System.IO.File.ReadAllText(pathJson);
            // De-serialize to object or create new list
            dataList = JsonConvert.DeserializeObject<List<Data>>(jsonData)
                                  ?? new List<Data>();

            //string filePathOriginal = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Original";


            //string filePathColored = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Colorized";
            filesColored = Directory.GetFiles(pathCol);//filePathColored);


            string[] dirs = Directory.GetDirectories(pathOri);
            // MessageBox.Show(String.Join(Environment.NewLine, dirs));


            //if (c == 0)
            //{
            //    filesOriginal = Directory.GetFiles(dirs[0]);
            //    pictureBox1.Image = Image.FromFile(filesOriginal[c]);
            //    pictureBox2.Image = Image.FromFile(filesOriginal[c + 1]);
            //    pictureBox3.Image = Image.FromFile(filesOriginal[c + 2]);
            //    pictureBox4.Image = Image.FromFile(filesOriginal[c + 3]);
            //    fileCount = Directory.GetFiles(dirs[0]).Length;//filePathOriginal).Length;
            //}
            // while (c < dirs.Length)
            //{
            if (dirs[ii].Length != 0)
            {
                filesOriginal = Directory.GetFiles(dirs[ii]);
                pictureBox1.Image = Image.FromFile(filesOriginal[0]);
                pictureBox2.Image = Image.FromFile(filesOriginal[1]);
                pictureBox3.Image = Image.FromFile(filesOriginal[2]);
                pictureBox4.Image = Image.FromFile(filesOriginal[3]);
            }
            fileCount = dirs.Length;//Directory.GetFiles(dirs.Count);
                                    //  MessageBox.Show("filecount: " + fileCount);

            string dirName = new DirectoryInfo(dirs[ii]).Name;
            //new DirectoryInfo(@"C:\Users\me\Projects\myProject\").Name;

            lbl_patient.Text = "Patient: " + dirName;
            //c++;
            //ii++;
            //}
            //fileCount = Directory.GetFiles(pathOri).Length;//filePathOriginal).Length;

            //pictureBox1.Image = Image.FromFile(filesOriginal[c]);
            //pictureBox2.Image = Image.FromFile(filesOriginal[c + 1]);
            //pictureBox3.Image = Image.FromFile(filesOriginal[c + 2]);
            //pictureBox4.Image = Image.FromFile(filesOriginal[c + 3]);

            ////////////////////
            CheckIfWeHave();
            ////////////////////

            label1.Text = c + 1 + " out of " + filesOriginal.Length / 4 + " images \n";

            if (c == 0) //changed it here
                buttonPrevious.Enabled = false;
        }
        int ch = 0;
        private void CheckIfWeHave()
        {
            int jd = dataList.Count;
            if (jd > ii)
            {
                Update(ii);
                var item = dataList[ch];

                if (File.Exists(item.Image1Name.ToString()))
                {
                    // var item = dataList[ii];
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
                    //MessageBox.Show(btnNavLR.ToString());
                    //if (btnNavLR == false)
                    //{
                    Location1XY.X = item.Rect1X1 / 11;
                    Location1XY.Y = item.Rect1Y1 / 11;      // indi bagladim
                    Location1X1Y1.X = item.Rect1X2 / 11;
                    Location1X1Y1.Y = item.Rect1Y2 / 11;
                    PictureBoxClicked[0] = true;

                    Location2XY.X = item.Rect2X1 / 11;
                    Location2XY.Y = item.Rect2Y1 / 11;      // indi bagladim
                    Location2X1Y1.X = item.Rect2X2 / 11;
                    Location2X1Y1.Y = item.Rect2Y2 / 11;
                    PictureBoxClicked[1] = true;

                    Location3XY.X = item.Rect3X1 / 11;
                    Location3XY.Y = item.Rect3Y1 / 11;      // indi bagladim
                    Location3X1Y1.X = item.Rect3X2 / 11;
                    Location3X1Y1.Y = item.Rect3Y2 / 11;
                    PictureBoxClicked[2] = true;

                    Location4XY.X = item.Rect4X1 / 11;
                    Location4XY.Y = item.Rect4Y1 / 11;      // indi bagladim
                    Location4X1Y1.X = item.Rect4X2 / 11;
                    Location4X1Y1.Y = item.Rect4Y2 / 11;
                    PictureBoxClicked[3] = true;
                    //}
                    //else
                    //{
                    //    item.Rect1X1 = Location1XY.X * 11;    //bunu da bagladim su an
                    //    item.Rect1Y1 = Location1XY.Y * 11;
                    //    item.Rect1X2 = Location1X1Y1.X * 11;
                    //    item.Rect1Y2 = Location1X1Y1.Y * 11;

                    //    item.Rect2X1 = Location2XY.X * 11;       //bunu da bagladim su an
                    //    item.Rect2Y1 = Location2XY.Y * 11;
                    //    item.Rect2X2 = Location2X1Y1.X * 11;
                    //    item.Rect2Y2 = Location2X1Y1.Y * 11;

                    //    item.Rect3X1 = Location3XY.X * 11; //bunu da bagladim su an
                    //    item.Rect3Y1 = Location3XY.Y * 11;
                    //    item.Rect3X2 = Location3X1Y1.X * 11;
                    //    item.Rect3Y2 = Location3X1Y1.Y * 11;

                    //    item.Rect4X1 = Location4XY.X * 11;       //bunu da bagladim su an
                    //    item.Rect4Y1 = Location4XY.Y * 11;
                    //    item.Rect4X2 = Location4X1Y1.X * 11;
                    //    item.Rect4Y2 = Location4X1Y1.Y * 11;
                    //}
                    drawPic();
                }
            }
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("before ii: " + ii.ToString());
            string str = "";
            buttonPreviousFunction();
            // CheckIfWeHave();
            drawPic();
            for (int n = 0; n < dataList.Count; n++)
                str += "id: " + dataList[n].Image1Name.ToString() + "\n" + "comm: " + dataList[n].Comment.ToString() + "\n" + "diag: " + dataList[n].Diagnosis.ToString() + "\n";
            //"rectx1: " + dataList[n].RectX1 + "\nrectX2: " + dataList[n].RectX2 + "\nrecty1:" + dataList[n].RectY1 + "\nrecty2" + dataList[n].RectY2;
            // MessageBox.Show(str);
            //  MessageBox.Show("After ii: " + ii.ToString());
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            string[] dirs = Directory.GetDirectories(pathOri);

            if (c == fileCount - 1)
            {
                buttonNext.Enabled = false;
            }
            buttonNextFunction();

            String str = "";
            for (int n = 0; n < dataList.Count; n++)
                str += "id: " + dataList[n].Image1Name.ToString() + "\n" + "comm: " + dataList[n].Comment.ToString() + "\n" + "diag: " + dataList[n].Diagnosis.ToString() + "\n";

            if (c != dataList.Count)     //sonra bax buna
                drawPic();

            if (c == fileCount - 1) //artirdim
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
            System.IO.File.WriteAllText(pathJson, jsonData);
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBoxClicked[2] = true;
            if (penClick)
            {
                IsMouseDown = true;
                Location3XY = e.Location;
                tempData.Rect3X1 = e.Location.X;
                tempData.Rect3Y1 = e.Location.Y;
            }
        }
        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                Location3X1Y1 = e.Location;
                tempData.Rect3X2 = e.Location.X;
                tempData.Rect3Y2 = e.Location.Y;
                Refresh();
            }
        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                Location3X1Y1 = e.Location;
                tempData.Rect3X2 = e.Location.X;
                tempData.Rect3Y2 = e.Location.Y;
                IsMouseDown = false;
            }
        }
        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            if (btnNavLR && PictureBoxClicked[2] == true)
            {
                Pen pen = new Pen(Color.Red, 3);
                e.Graphics.DrawRectangle(pen, GetRect(Location3XY, Location3X1Y1));
                Rectangle rect1 = pictureBox3.ClientRectangle;
            }
        }
        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            if (btnNavLR && PictureBoxClicked[3] == true)
            {
                Pen pen = new Pen(Color.Red, 3);
                e.Graphics.DrawRectangle(pen, GetRect(Location4XY, Location4X1Y1));
                Rectangle rect1 = pictureBox4.ClientRectangle;
            }
        }
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBoxClicked[3] = true;
            if (penClick)
            {
                IsMouseDown = true;
                Location4XY = e.Location;
                tempData.Rect4X1 = e.Location.X;
                tempData.Rect4Y1 = e.Location.Y;
            }
        }
        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                Location4X1Y1 = e.Location;
                tempData.Rect4X2 = e.Location.X;
                tempData.Rect4Y2 = e.Location.Y;
                IsMouseDown = false;
            }
        }
        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                Location4X1Y1 = e.Location;
                tempData.Rect3X2 = e.Location.X;
                tempData.Rect3Y2 = e.Location.Y;
                Refresh();
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
            btnNavLR = true;
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
            PictureBoxClicked[0] = true;
            if (penClick)
            {
                IsMouseDown = true;
                Location1XY = e.Location;
                tempData.Rect1X1 = e.Location.X;
                tempData.Rect1Y1 = e.Location.Y;
            }
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBoxClicked[1] = true;
            if (penClick)
            {
                IsMouseDown = true;
                Location2XY = e.Location;
                tempData.Rect2X1 = e.Location.X;
                tempData.Rect2Y1 = e.Location.Y;
            }
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                Location1X1Y1 = e.Location;
                tempData.Rect1X2 = e.Location.X;
                tempData.Rect1Y2 = e.Location.Y;
                Refresh();
            }
        }
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                Location2X1Y1 = e.Location;
                tempData.Rect2X2 = e.Location.X;
                tempData.Rect2Y2 = e.Location.Y;
                Refresh();
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                Location1X1Y1 = e.Location;
                tempData.Rect1X2 = e.Location.X;
                tempData.Rect1Y2 = e.Location.Y;
                IsMouseDown = false;
            }
        }
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                Location2X1Y1 = e.Location;
                tempData.Rect2X2 = e.Location.X;
                tempData.Rect2Y2 = e.Location.Y;
                IsMouseDown = false;
            }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (rect != null && btnNavLR && PictureBoxClicked[0] == true)
            {
                Pen pen = new Pen(Color.Red, 3);
                e.Graphics.DrawRectangle(pen, GetRect(Location1XY, Location1X1Y1));
                Rectangle rect1 = pictureBox1.ClientRectangle;

                //pictureBox1.Invalidate(rect1);
                //pictureBox1.Update();
            }
        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (rect != null && btnNavLR && PictureBoxClicked[1] == true)
            {
                Pen pen = new Pen(Color.Red, 3);
                e.Graphics.DrawRectangle(pen, GetRect(Location2XY, Location2X1Y1));
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
            // MessageBox.Show("Double clik to the zoomed photo to get back");

            picNum = 0;
            AddToDataList();
            CreateStaticData(ii);
            //int width = pictureBox1.Width;
            //int height = pictureBox1.Height;
            Form4 form4 = new Form4();
            form4.Show();
            //FormZoom formZoom = new FormZoom(wiheight);
            //formZoom.Show();

        }
        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            //   MessageBox.Show("Double clik to the zoomed photo to get back");
            picNum = 1;
            AddToDataList();
            CreateStaticData(ii);
            //int width = pictureBox2.Width;
            //int height = pictureBox2.Height;
            Form4 form4 = new Form4();
            form4.Show();
        }
        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            //  MessageBox.Show("Double clik to the zoomed photo to get back");
            picNum = 2;
            AddToDataList();
            CreateStaticData(ii);
            //int width = pictureBox3.Width;
            //int height = pictureBox3.Height;
            Form4 form4 = new Form4();
            form4.Show();
        }
        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            // MessageBox.Show("Double clik to the zoomed photo to get back");
            picNum = 3;
            AddToDataList();
            CreateStaticData(ii);
            //int width = pictureBox4.Width;
            //int height = pictureBox4.Height;
            Form4 form4 = new Form4();
            form4.Show();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckIfWeHave();
            if ((radioButtonNegative.Checked == true || radioButtonPositive.Checked == true || radioButtonPotential.Checked == true))
            {
                string[] dirs = Directory.GetDirectories(pathOri);

                if (ii == dirs.Length - 1)
                {
                    int id;
                    //  MessageBox.Show(ii.ToString());
                    id = dataList.Count * 4 + 1;
                    // MessageBox.Show("C; " + c);


                    // Add any new data
                    dataList.Add(new Data()
                    {
                        Image1Id = id,// w,//get last image id from json file then ++ and assign
                        Image1Name = Path.GetFileName(filesOriginal[0]),

                        Image2Id = id + 1,// w,//get last image id from json file then ++ and assign
                        Image2Name = Path.GetFileName(filesOriginal[1]),

                        Image3Id = id + 2,// w,//get last image id from json file then ++ and assign
                        Image3Name = Path.GetFileName(filesOriginal[2]),

                        Image4Id = id + 3,// w,//get last image id from json file then ++ and assign
                        Image4Name = Path.GetFileName(filesOriginal[3]),

                        Diagnosis = diagnosisInt,
                        Comment = textBoxComment.Text,
                        DoctorId = 1,
                        Rect1X1 = Location1XY.X * 11,       //bunu da bagladim su an
                        Rect1Y1 = Location1XY.Y * 11,
                        Rect1X2 = Location1X1Y1.X * 11,
                        Rect1Y2 = Location1X1Y1.Y * 11,

                        Rect2X1 = Location2XY.X * 11,       //bunu da bagladim su an
                        Rect2Y1 = Location2XY.Y * 11,
                        Rect2X2 = Location2X1Y1.X * 11,
                        Rect2Y2 = Location2X1Y1.Y * 11,

                        Rect3X1 = Location3XY.X * 11,       //bunu da bagladim su an
                        Rect3Y1 = Location3XY.Y * 11,
                        Rect3X2 = Location3X1Y1.X * 11,
                        Rect3Y2 = Location3X1Y1.Y * 11,

                        Rect4X1 = Location4XY.X * 11,       //bunu da bagladim su an
                        Rect4Y1 = Location4XY.Y * 11,
                        Rect4X2 = Location4X1Y1.X * 11,
                        Rect4Y2 = Location4X1Y1.Y * 11
                    });
                    Update(ii);
                }
            }
            JsonSave();
            Application.Exit();
        }
        private void buttonPencil_Click(object sender, EventArgs e)
        {
            btnNavLR = true;

            if (!penClick)
            {
                string directory = Directory.GetCurrentDirectory();
                pathPencil = directory + "\\minipencil.png";

                //var parentName = Directory.GetParent(directory).FullName;
                //parentName = Directory.GetParent(parentName).FullName;
                //parentName = Directory.GetParent(parentName).FullName;
                //parentName = Directory.GetParent(parentName).FullName;
                //parentName = Directory.GetParent(parentName).FullName;        //E:\OneDrive - ADA University\Homework\SDP2022-brstcancer

                // pathPencil = parentName + "\\Logo\\minipencil.png";
                var bitmap = (Bitmap)Image.FromFile(pathPencil);//dlg.FileName);
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
        private Rectangle GetRect(Point LocationXY, Point LocationX1Y1)
        {
            /*if (PictureBoxClicked[0] == true)
            {
                LocationXY = Location1XY;
                LocationX1Y1 = Location1X1Y1;
            }
            else if (PictureBoxClicked[1] == true)
            {
                LocationXY = Location2XY;
                LocationX1Y1 = Location2X1Y1;
            }
            else if (PictureBoxClicked[2] == true)
            {
                LocationXY = Location3XY;
                LocationX1Y1 = Location3X1Y1;
            }
            else if (PictureBoxClicked[3] == true)
            {
                LocationXY = Location4XY;
                LocationX1Y1 = Location4X1Y1;
            }*/
            rect = new Rectangle();
            rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
            rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);

            rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
            rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);

            return rect;
        }
        private void buttonTest_Click(object sender, EventArgs e)
        {

            if (radioButtonNegative.Checked == false && radioButtonPositive.Checked == false && radioButtonPotential.Checked == false)
            {
                string message = "You need to choose one option!";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            }
            else
            {
                run_cmd();
                readText();
            }
        }
        public void run_cmd()
        {
            string directory = Directory.GetCurrentDirectory();
            //var parentName = Directory.GetParent(directory).FullName;
            //parentName = Directory.GetParent(parentName).FullName;
            //parentName = Directory.GetParent(parentName).FullName;
            //parentName = Directory.GetParent(parentName).FullName;
            //parentName = Directory.GetParent(parentName).FullName;        //E:\OneDrive - ADA University\Homework\SDP2022-brstcancer

            var psi = new ProcessStartInfo();
            psi.FileName = @"E:\User\anaconda3\python.exe";

            var script = directory + "\\model_test.py";               //@"E:\OneDrive\Desktop\dcm_to_png.py";
            var filename = directory + "\\finalized_model.sav";       // @"E:\OneDrive\Desktop\finalized_model.sav";
                                                                                // var fname1 = parentName + "\\PyFiles\\test.png";                              // @"E:\OneDrive\Desktop\test.png";

            string[] dirs = Directory.GetDirectories(pathOri);

            filesOriginal = Directory.GetFiles(dirs[ii]);
            var fname1 = filesOriginal[0];
            var fname2 = filesOriginal[1];
            var fname3 = filesOriginal[2];
            var fname4 = filesOriginal[3];

            //   MessageBox.Show(fname1.ToString());

            psi.Arguments = $"\"{script}\" \"{fname1}\" \"{fname2}\" \"{fname3}\" \"{fname4}\" \"{filename}\"";




            //psi.Arguments = $"\"{script}\" \"{fname}\" \"{filename}\"";


            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            var errors = "";
            var results = "";

            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }
            Console.WriteLine("ERRORS:");
            //MessageBox.Show(errors, " Errors");
            Console.WriteLine(errors);
            Console.WriteLine();
            Console.WriteLine("Results:");
            Console.WriteLine(results);
            // MessageBox.Show(results, " results");
        }
        private void readText()
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("pred.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    string[] lblT = line.Split(' ');

                    lbl_rp_prediction.Text = "Prediction: " + lblT[0];
                    lbl_lp_prediction.Text = "Prediction: " + lblT[1];
                    lbl_rpm_prediction.Text = "Prediction: " + lblT[2];
                    lbl_lpm_prediction.Text = "Prediction: " + lblT[3];
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        private void drawPic()
        {
            btnNavLR = true;
        }
        private void downCheckFunction(bool downFlag)
        {
            string dirName = "";
            if (!downFlag)
            {
                //MessageBox.Show("c, ii: " + c + " " + ii);
                // filesOriginal = Directory.GetFiles(dirs[ii]);
                // MessageBox.Show("filesOri: " + filesOriginal[ii]);

                string[] dirs = Directory.GetDirectories(pathOri);
                // MessageBox.Show(String.Join(Environment.NewLine, dirs));
                if (c < dirs.Length)
                {
                    filesOriginal = Directory.GetFiles(dirs[c]);
                    pictureBox1.Image = Image.FromFile(filesOriginal[0]);
                    pictureBox2.Image = Image.FromFile(filesOriginal[1]);
                    pictureBox3.Image = Image.FromFile(filesOriginal[2]);
                    pictureBox4.Image = Image.FromFile(filesOriginal[3]);
                    fileCount = dirs.Length;//Directory.GetFiles(dirs.Count);
                                            //  MessageBox.Show("filecount: " + fileCount);
                    if (ii < dirs.Length)
                        dirName = new DirectoryInfo(dirs[ii + 1]).Name;
                }
                // MessageBox.Show("ii: " + ii + " c: " + c);
                //new DirectoryInfo(@"C:\Users\me\Projects\myProject\").Name;

                lbl_patient.Text = "Patient: " + dirName;
                //lbl_patient.Text = "Patient: " + dirs[c];
                lbl_rp_prediction.Text = "Prediction: ";
                lbl_lp_prediction.Text = "Prediction: ";
                lbl_rpm_prediction.Text = "Prediction: ";
                lbl_lpm_prediction.Text = "Prediction: ";
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
                    id = dataList.Count * 4 + 1;
                    // Add any new data

                    dataList.Add(new Data()
                    {
                        Image1Id = id,// w,//get last image id from json file then ++ and assign
                        Image2Id = id + 1,
                        Image3Id = id + 2,
                        Image4Id = id + 3,
                        Image1Name = filesOriginal[c].TrimEnd('\\'),
                        Image2Name = filesOriginal[c + 1].TrimEnd('\\'),
                        Image3Name = filesOriginal[c + 2].TrimEnd('\\'),
                        Image4Name = filesOriginal[c + 3].TrimEnd('\\'),
                        Diagnosis = diagnosisInt,
                        Comment = textBoxComment.Text,
                        DoctorId = 1,
                        Rect1X1 = Location1XY.X * 11,
                        Rect1Y1 = Location1XY.Y * 11,       // bun uda indi bagladim
                        Rect1X2 = Location1X1Y1.X * 11,
                        Rect1Y2 = Location1X1Y1.Y * 11,

                        Rect2X1 = Location1XY.X * 11,
                        Rect2Y1 = Location1XY.Y * 11,       // bun uda indi bagladim
                        Rect2X2 = Location1X1Y1.X * 11,
                        Rect2Y2 = Location1X1Y1.Y * 11,

                        Rect3X1 = Location1XY.X * 11,
                        Rect3Y1 = Location1XY.Y * 11,       // bun uda indi bagladim
                        Rect3X2 = Location1X1Y1.X * 11,
                        Rect3Y2 = Location1X1Y1.Y * 11,

                        Rect4X1 = Location1XY.X * 11,
                        Rect4Y1 = Location1XY.Y * 11,       // bun uda indi bagladim
                        Rect4X2 = Location1X1Y1.X * 11,
                        Rect4Y2 = Location1X1Y1.Y * 11,
                    });
                }
            }
            else
            {
                var item = dataList[ii];
                item.Rect1X1 = Location1XY.X * 11;
                item.Rect1Y1 = Location1XY.Y * 11;
                item.Rect1X2 = Location1X1Y1.X * 11;
                item.Rect1Y2 = Location1X1Y1.Y * 11; //indi bagladim

                item.Rect2X1 = Location2XY.X * 11;
                item.Rect2Y1 = Location2XY.Y * 11;
                item.Rect2X2 = Location2X1Y1.X * 11;
                item.Rect2Y2 = Location2X1Y1.Y * 11; //indi bagladim

                item.Rect3X1 = Location3XY.X * 11;
                item.Rect3Y1 = Location3XY.Y * 11;
                item.Rect3X2 = Location3X1Y1.X * 11;
                item.Rect3Y2 = Location3X1Y1.Y * 11; //indi bagladim

                item.Rect4X1 = Location4XY.X * 11;
                item.Rect4Y1 = Location4XY.Y * 11;
                item.Rect4X2 = Location4X1Y1.X * 11;
                item.Rect4Y2 = Location4X1Y1.Y * 11; //indi bagladim


                //LocationXY.X = 0;
                //LocationXY.Y = 0;
                //LocationX1Y1.X = 0;
                //LocationX1Y1.Y = 0;
            }
        }
        private void CheckTemp()
        {
            int jd = dataList.Count;
            if (jd > ii)
            {
                var curitem = dataList[ch];

                if (tempData.Rect1X1 > 0)
                {
                    curitem.Rect1X1 = tempData.Rect1X1 * 11;
                    curitem.Rect1X2 = tempData.Rect1X2 * 11;
                    curitem.Rect1Y1 = tempData.Rect1Y1 * 11;
                    curitem.Rect1Y2 = tempData.Rect1Y2 * 11;
                }
                if (tempData.Rect2X1 > 0)
                {
                    curitem.Rect2X1 = tempData.Rect2X1 * 11;
                    curitem.Rect2X2 = tempData.Rect2X2 * 11;
                    curitem.Rect2Y1 = tempData.Rect2Y1 * 11;
                    curitem.Rect2Y2 = tempData.Rect2Y2 * 11;
                }
                if (tempData.Rect3X1 > 0)
                {
                    curitem.Rect3X1 = tempData.Rect3X1 * 11;
                    curitem.Rect3X2 = tempData.Rect3X2 * 11;
                    curitem.Rect3Y1 = tempData.Rect3Y1 * 11;
                    curitem.Rect3Y2 = tempData.Rect3Y2 * 11;
                }
                if (tempData.Rect4X1 > 0)
                {
                    curitem.Rect4X1 = tempData.Rect4X1 * 11;
                    curitem.Rect4X2 = tempData.Rect4X2 * 11;
                    curitem.Rect4Y1 = tempData.Rect4Y1 * 11;
                    curitem.Rect4Y2 = tempData.Rect4Y2 * 11;
                }


                tempData = new Data();
            }
        }
        private void buttonNextFunction()
        {
            CheckIfWeHave();
            penClick = false;
            btnNavLR = false;
            prev = 0;

            CheckTemp();

            ch++;


            if (radioButtonNegative.Checked == false && radioButtonPositive.Checked == false && radioButtonPotential.Checked == false)
            {
                string message = "You need to choose one option!";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            }
            else
            {
                int id = 1;
                if (dataList.Count == 0 || ii == (dataList.Count))
                {
                    id = dataList.Count * 4 + 1;

                    string[] dirs = Directory.GetDirectories(pathOri);
                    // MessageBox.Show(String.Join(Environment.NewLine, dirs));

                    //filesOriginal = Directory.GetFiles(dirs[ii]);
                    //pictureBox1.Image = Image.FromFile(filesOriginal[0]);
                    //pictureBox2.Image = Image.FromFile(filesOriginal[1]);
                    //pictureBox3.Image = Image.FromFile(filesOriginal[2]);
                    //pictureBox4.Image = Image.FromFile(filesOriginal[3]);
                    //fileCount = dirs.Length;

                    string dirName= new DirectoryInfo(dirs[ii]).Name;
                    
                   // lbl_patient.Text = "Patient: " + dirName;

                    // Add any new data
                    dataList.Add(new Data()
                    {
                        Image1Id = id,// w,//get last image id from json file then ++ and assign

                        //    lbl_patient.Text = "Patient: " + dirName;
                        Image1Name = Path.GetFileName(filesOriginal[0]),//.TrimEnd(Path.GetFileName(dirName)),//filesOriginal[0].TrimEnd('\\'),

                        Image2Id = id + 1,// w,//get last image id from json file then ++ and assign
                        Image2Name = Path.GetFileName(filesOriginal[1]),//.TrimEnd('\\'),

                        Image3Id = id + 2,// w,//get last image id from json file then ++ and assign
                        Image3Name = Path.GetFileName(filesOriginal[2]),

                        Image4Id = id + 3,// w,//get last image id from json file then ++ and assign
                        Image4Name = Path.GetFileName(filesOriginal[3]),

                        Diagnosis = diagnosisInt,
                        Comment = textBoxComment.Text,
                        DoctorId = 1,
                        Rect1X1 = Location1XY.X * 11,       //bunu da bagladim su an
                        Rect1Y1 = Location1XY.Y * 11,
                        Rect1X2 = Location1X1Y1.X * 11,
                        Rect1Y2 = Location1X1Y1.Y * 11,

                        Rect2X1 = Location2XY.X * 11,       //bunu da bagladim su an
                        Rect2Y1 = Location2XY.Y * 11,
                        Rect2X2 = Location2X1Y1.X * 11,
                        Rect2Y2 = Location2X1Y1.Y * 11,

                        Rect3X1 = Location3XY.X * 11,       //bunu da bagladim su an
                        Rect3Y1 = Location3XY.Y * 11,
                        Rect3X2 = Location3X1Y1.X * 11,
                        Rect3Y2 = Location3X1Y1.Y * 11,

                        Rect4X1 = Location4XY.X * 11,       //bunu da bagladim su an
                        Rect4Y1 = Location4XY.Y * 11,
                        Rect4X2 = Location4X1Y1.X * 11,
                        Rect4Y2 = Location4X1Y1.Y * 11
                    });
                    Update(ii);

                    textBoxComment.Text = textEmp;

                    radioButtonPositive.Checked = false;
                    radioButtonPotential.Checked = false;
                    radioButtonNegative.Checked = false;


                    if (c == filesOriginal.Length)// - 1)
                        buttonNext.Enabled = false;
                    else
                    {
                        c++;// += 4;
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
                        Location1XY.X = item.Rect1X1 / 11; //////////added later
                        Location1XY.Y = item.Rect1Y1 / 11;
                        Location1X1Y1.X = item.Rect1X2 / 11;          // indi bagladim bunu da acacam
                        Location1X1Y1.Y = item.Rect1Y2 / 11;

                        Location2XY.X = item.Rect2X1 / 11; //////////added later
                        Location2XY.Y = item.Rect2Y1 / 11;
                        Location2X1Y1.X = item.Rect2X2 / 11;          // indi bagladim bunu da acacam
                        Location2X1Y1.Y = item.Rect2Y2 / 11;

                        Location3XY.X = item.Rect3X1 / 11; //////////added later
                        Location3XY.Y = item.Rect3Y1 / 11;
                        Location3X1Y1.X = item.Rect3X2 / 11;          // indi bagladim bunu da acacam
                        Location3X1Y1.Y = item.Rect3Y2 / 11;

                        Location4XY.X = item.Rect4X1 / 11; //////////added later
                        Location4XY.Y = item.Rect4Y1 / 11;
                        Location4X1Y1.X = item.Rect4X2 / 11;          // indi bagladim bunu da acacam
                        Location4X1Y1.Y = item.Rect4Y2 / 11;

                        //if (c == filesOriginal.Length - 1)
                        //    buttonNext.Enabled = false;
                        //else
                        //{
                        c++;// += 4;         ///////////////////////////////////////////yav baxaq gorek nolur
                        buttonPrevious.Enabled = true;
                        label1.Text = c + 1 + " out of " + filesOriginal.Length + " images \n";// + files[c];

                        downCheckFunction(downFlag);
                        // }
                    }
                    else
                    {
                        //end of file so we are clearing the data

                        textBoxComment.Text = textEmp;

                        radioButtonPositive.Checked = false;
                        radioButtonPotential.Checked = false;
                        radioButtonNegative.Checked = false;

                        //added later
                        c++;// += 4;
                        buttonPrevious.Enabled = true;
                        label1.Text = c + 1 + " out of " + filesOriginal.Length + " images \n";// + files[c];

                        downCheckFunction(downFlag);
                    }
                }
            }
            /*
            //else
            //{
            //    int id = 1;
            //    // ii++;//indi eledim olmamalidyi
            //    //  c++;
            //    if (dataList.Count == 0 || ii == (dataList.Count))
            //    {
            //        // id = dataList.Count * 4 + 1;

            //        MessageBox.Show(pathOri);

            //        string[] dirs = Directory.GetDirectories(pathOri);
            //        // MessageBox.Show(String.Join(Environment.NewLine, dirs));

            //        MessageBox.Show("C; " + c);
            //        filesOriginal = Directory.GetFiles(dirs[ii]);
            //        //  MessageBox.Show(filesOriginal.ToString());

            //        pictureBox1.Image = Image.FromFile(filesOriginal[0]);
            //        pictureBox2.Image = Image.FromFile(filesOriginal[1]);
            //        pictureBox3.Image = Image.FromFile(filesOriginal[2]);
            //        pictureBox4.Image = Image.FromFile(filesOriginal[3]);
            //        fileCount = Directory.GetFiles(dirs[ii]).Length;//filePathOriginal).Length;
            //        lbl_patient.Text = "Patient: " + dirs[ii];

            //        // Add any new data
            //        dataList.Add(new Data()
            //        {
            //            Image1Id = id,// w,//get last image id from json file then ++ and assign
            //            Image1Name = filesOriginal[0].TrimEnd('\\'),

            //            Image2Id = id + 1,// w,//get last image id from json file then ++ and assign
            //            Image2Name = filesOriginal[1].TrimEnd('\\'),

            //            Image3Id = id + 2,// w,//get last image id from json file then ++ and assign
            //            Image3Name = filesOriginal[2].TrimEnd('\\'),

            //            Image4Id = id + 3,// w,//get last image id from json file then ++ and assign
            //            Image4Name = filesOriginal[3].TrimEnd('\\'),

            //            Diagnosis = diagnosisInt,
            //            Comment = textBoxComment.Text,
            //            DoctorId = 1,
            //            Rect1X1 = Location1XY.X * 11,       //bunu da bagladim su an
            //            Rect1Y1 = Location1XY.Y * 11,
            //            Rect1X2 = Location1X1Y1.X * 11,
            //            Rect1Y2 = Location1X1Y1.Y * 11,

            //            Rect2X1 = Location2XY.X * 11,       //bunu da bagladim su an
            //            Rect2Y1 = Location2XY.Y * 11,
            //            Rect2X2 = Location2X1Y1.X * 11,
            //            Rect2Y2 = Location2X1Y1.Y * 11,

            //            Rect3X1 = Location3XY.X * 11,       //bunu da bagladim su an
            //            Rect3Y1 = Location3XY.Y * 11,
            //            Rect3X2 = Location3X1Y1.X * 11,
            //            Rect3Y2 = Location3X1Y1.Y * 11,

            //            Rect4X1 = Location4XY.X * 11,       //bunu da bagladim su an
            //            Rect4Y1 = Location4XY.Y * 11,
            //            Rect4X2 = Location4X1Y1.X * 11,
            //            Rect4Y2 = Location4X1Y1.Y * 11
            //        });
            //        Update(ii);

            //        textBoxComment.Text = textEmp;

            //        radioButtonPositive.Checked = false;
            //        radioButtonPotential.Checked = false;
            //        radioButtonNegative.Checked = false;


            //        if (c == filesOriginal.Length - 1)
            //        {
            //            buttonNext.Enabled = false;
            //        }
            //        else
            //        {
            //            c++;//= 4;
            //            buttonPrevious.Enabled = true;
            //            label1.Text = c + 1 + " out of " + filesOriginal.Length + " images \n";// + files[c];

            //            downCheckFunction(downFlag);
            //            ii++;
            //        }
            //    }
            //    else
            //    {
            //        Update(ii);
            //        ii++;
            //        if (ii < dataList.Count)
            //        {
            //            var item = dataList[ii];

            //            this.textBoxComment.Text = item.Comment;

            //            if (item.Diagnosis == 1)
            //            {
            //                this.radioButtonPositive.Checked = true;
            //                d = 1;
            //            }
            //            else if (item.Diagnosis == 2)
            //            {
            //                this.radioButtonPotential.Checked = true;
            //                d = 2;
            //            }
            //            else if (item.Diagnosis == 3)
            //            {
            //                this.radioButtonNegative.Checked = true;
            //                d = 3;
            //            }
            //            Location1XY.X = item.Rect1X1 / 11; //////////added later
            //            Location1XY.Y = item.Rect1Y1 / 11;
            //            Location1X1Y1.X = item.Rect1X2 / 11;          // indi bagladim bunu da acacam
            //            Location1X1Y1.Y = item.Rect1Y2 / 11;

            //            Location2XY.X = item.Rect2X1 / 11; //////////added later
            //            Location2XY.Y = item.Rect2Y1 / 11;
            //            Location2X1Y1.X = item.Rect2X2 / 11;          // indi bagladim bunu da acacam
            //            Location2X1Y1.Y = item.Rect2Y2 / 11;

            //            Location3XY.X = item.Rect3X1 / 11; //////////added later
            //            Location3XY.Y = item.Rect3Y1 / 11;
            //            Location3X1Y1.X = item.Rect3X2 / 11;          // indi bagladim bunu da acacam
            //            Location3X1Y1.Y = item.Rect3Y2 / 11;

            //            Location4XY.X = item.Rect4X1 / 11; //////////added later
            //            Location4XY.Y = item.Rect4Y1 / 11;
            //            Location4X1Y1.X = item.Rect4X2 / 11;          // indi bagladim bunu da acacam
            //            Location4X1Y1.Y = item.Rect4Y2 / 11;

            //            if (c == filesOriginal.Length - 1)
            //                buttonNext.Enabled = false;
            //            else
            //            {
            //                c += 4;         ///////////////////////////////////////////yav baxaq gorek nolur
            //                buttonPrevious.Enabled = true;
            //                label1.Text = c + 1 + " out of " + filesOriginal.Length + " images \n";// + files[c];

            //                downCheckFunction(downFlag);
            //            }
            //        }
            //        else
            //        {
            //            //  end of file so we are clearing the data

            //            textBoxComment.Text = textEmp;

            //            radioButtonPositive.Checked = false;
            //            radioButtonPotential.Checked = false;
            //            radioButtonNegative.Checked = false;

            //            // added later
            //            c++;//= 4;
            //            buttonPrevious.Enabled = true;
            //            label1.Text = c + 1 + " out of " + filesOriginal.Length + " images \n";// + files[c];

            //            downCheckFunction(downFlag);
            //        }
            //    }
            //}
            */
        }
        private void Update(int i)
        {
            //update
            //  MessageBox.Show("i " + i.ToString() + " ii " + ii.ToString());
            var cou = dataList.Count();


            var item = dataList[i];
            //Console.WriteLine(i.ToString());
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
                Location1XY.X = 0;
                Location1XY.Y = 0; // indi bagladim aciq olmalidi
                Location1X1Y1.X = 0;
                Location1X1Y1.Y = 0;

                Location2XY.X = 0;
                Location2XY.Y = 0; // indi bagladim aciq olmalidi
                Location2X1Y1.X = 0;
                Location2X1Y1.Y = 0;

                Location3XY.X = 0;
                Location3XY.Y = 0; // indi bagladim aciq olmalidi
                Location3X1Y1.X = 0;
                Location3X1Y1.Y = 0;

                Location4XY.X = 0;
                Location4XY.Y = 0; // indi bagladim aciq olmalidi
                Location4X1Y1.X = 0;
                Location4X1Y1.Y = 0;
            }

            //update
            //MessageBox.Show("i " + i.ToString() + " ii " + ii.ToString());
            //var cou = dataList.Count();
            ////MessageBox.Show(dataList[i].ToString());
            //var item = dataList[i - 1];
            ////Console.WriteLine(i.ToString());
            //item.Comment = this.textBoxComment.Text;

            //if (this.radioButtonPositive.Checked)
            //{
            //    item.Diagnosis = 1;
            //}
            //else if (this.radioButtonPotential.Checked)
            //{
            //    item.Diagnosis = 2;
            //}
            //else if (this.radioButtonNegative.Checked)
            //{
            //    item.Diagnosis = 3;
            //}
            ////item.RectX1 = LocationXY.X * 13;
            ////item.RectY1 = LocationXY.Y * 13;
            ////item.RectX2 = LocationX1Y1.X * 13;
            ////item.RectY2 = LocationX1Y1.Y * 13;
            //if (ii == dataList.Count - 1)
            //{
            //    Location1XY.X = 0;
            //    Location1XY.Y = 0; // indi bagladim aciq olmalidi
            //    Location1X1Y1.X = 0;
            //    Location1X1Y1.Y = 0;

            //    Location2XY.X = 0;
            //    Location2XY.Y = 0; // indi bagladim aciq olmalidi
            //    Location2X1Y1.X = 0;
            //    Location2X1Y1.Y = 0;

            //    Location3XY.X = 0;
            //    Location3XY.Y = 0; // indi bagladim aciq olmalidi
            //    Location3X1Y1.X = 0;
            //    Location3X1Y1.Y = 0;

            //    Location4XY.X = 0;
            //    Location4XY.Y = 0; // indi bagladim aciq olmalidi
            //    Location4X1Y1.X = 0;
            //    Location4X1Y1.Y = 0;
            //}
        }
        public void buttonUpFunction()
        {
            btnNavLR = true;
            downFlag = false;
            pictureBox1.Image = Image.FromFile(filesOriginal[0]);
            pictureBox2.Image = Image.FromFile(filesOriginal[1]);
            pictureBox3.Image = Image.FromFile(filesOriginal[2]);
            pictureBox4.Image = Image.FromFile(filesOriginal[3]);

            label1.Text = c + 1 + " out of " + filesOriginal.Length + " images \n";
        }
        public void buttonDownFunction()
        {
            downFlag = true;
            btnNavLR = true;
            pictureBox1.Image = Image.FromFile(filesColored[0]);
            pictureBox2.Image = Image.FromFile(filesColored[1]);
            pictureBox3.Image = Image.FromFile(filesColored[2]);
            pictureBox4.Image = Image.FromFile(filesColored[3]);

            label1.Text = c + 1 + " out of " + filesColored.Length + " images \n";
        }
        private void buttonPreviousFunction()
        {
            penClick = false;
            btnNavLR = false;
            CheckIfWeHave();
            CheckTemp();


            if (ch > 0)
                ch--;


            if (c == 0) //changed it here
                buttonPrevious.Enabled = false;
            else
            {
                if (ii >= dataList.Count())
                {
                    int id = dataList.Count * 4 + 1;
                    dataList.Add(new Data()
                    {
                        Image1Id = id,// w,//get last image id from json file then ++ and assign
                        Image1Name = Path.GetFileName(filesOriginal[0]),

                        Image2Id = id + 1,// w,//get last image id from json file then ++ and assign
                        Image2Name = Path.GetFileName(filesOriginal[1]),

                        Image3Id = id + 2,// w,//get last image id from json file then ++ and assign
                        Image3Name = Path.GetFileName(filesOriginal[2]),

                        Image4Id = id + 3,// w,//get last image id from json file then ++ and assign
                        Image4Name = Path.GetFileName(filesOriginal[3]),

                        Diagnosis = diagnosisInt,
                        Comment = textBoxComment.Text,
                        DoctorId = 1,
                        Rect1X1 = Location1XY.X * 11,       //bunu da bagladim su an
                        Rect1Y1 = Location1XY.Y * 11,
                        Rect1X2 = Location1X1Y1.X * 11,
                        Rect1Y2 = Location1X1Y1.Y * 11,

                        Rect2X1 = Location2XY.X * 11,       //bunu da bagladim su an
                        Rect2Y1 = Location2XY.Y * 11,
                        Rect2X2 = Location2X1Y1.X * 11,
                        Rect2Y2 = Location2X1Y1.Y * 11,

                        Rect3X1 = Location3XY.X * 11,       //bunu da bagladim su an
                        Rect3Y1 = Location3XY.Y * 11,
                        Rect3X2 = Location3X1Y1.X * 11,
                        Rect3Y2 = Location3X1Y1.Y * 11,

                        Rect4X1 = Location4XY.X * 11,       //bunu da bagladim su an
                        Rect4Y1 = Location4XY.Y * 11,
                        Rect4X2 = Location4X1Y1.X * 11,
                        Rect4Y2 = Location4X1Y1.Y * 11
                    });
                    Update(ii);
                }
                else
                {
                    Update(ii);
                }
                if (ii > 0)
                {
                    ii--;
                    c--;
                }

                //  MessageBox.Show(pathOri);
                string[] dirs = Directory.GetDirectories(pathOri);

                //     MessageBox.Show("C; " + c + " ii: " + ii);
                filesOriginal = Directory.GetFiles(dirs[ii]);
                //  MessageBox.Show(filesOriginal.ToString());

                pictureBox1.Image = Image.FromFile(filesOriginal[0]);
                pictureBox2.Image = Image.FromFile(filesOriginal[1]);
                pictureBox3.Image = Image.FromFile(filesOriginal[2]);
                pictureBox4.Image = Image.FromFile(filesOriginal[3]);
                fileCount = Directory.GetFiles(dirs[ii]).Length;//filePathOriginal).Length;
                lbl_patient.Text = "Patient: " + dirs[ii];


                var item = dataList[ii];// - 1];



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

                //item = dataList[ii];
                Location1XY.X = item.Rect1X1 / 11;
                Location1XY.Y = item.Rect1Y1 / 11;      // indi bagladim
                Location1X1Y1.X = item.Rect1X2 / 11;
                Location1X1Y1.Y = item.Rect1Y2 / 11;

                Location2XY.X = item.Rect2X1 / 11;
                Location2XY.Y = item.Rect2Y1 / 11;      // indi bagladim
                Location2X1Y1.X = item.Rect2X2 / 11;
                Location2X1Y1.Y = item.Rect2Y2 / 11;

                Location3XY.X = item.Rect3X1 / 11;
                Location3XY.Y = item.Rect3Y1 / 11;      // indi bagladim
                Location3X1Y1.X = item.Rect3X2 / 11;
                Location3X1Y1.Y = item.Rect3Y2 / 11;

                Location4XY.X = item.Rect4X1 / 11;
                Location4XY.Y = item.Rect4Y1 / 11;      // indi bagladim
                Location4X1Y1.X = item.Rect4X2 / 11;
                Location4X1Y1.Y = item.Rect4Y2 / 11;

                //  c--;//= 4;
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
            StaticData.DataList1.Image1Id = item1.Image1Id;
            StaticData.DataList1.DoctorId = item1.DoctorId;
            StaticData.DataList1.Diagnosis = item1.Diagnosis;
            StaticData.DataList1.Comment = item1.Comment;
            StaticData.DataList1.Rect1X1 = item1.Rect1X1;
            StaticData.DataList1.Rect1Y1 = item1.Rect1Y1;
            StaticData.DataList1.Rect1X2 = item1.Rect1X2;
            StaticData.DataList1.Rect1Y2 = item1.Rect1Y2;

            StaticData.DataList1.Image2Id = item1.Image2Id;
            StaticData.DataList1.Rect2X1 = item1.Rect2X1;
            StaticData.DataList1.Rect2Y1 = item1.Rect2Y1;
            StaticData.DataList1.Rect2X2 = item1.Rect2X2;
            StaticData.DataList1.Rect2Y2 = item1.Rect2Y2;

            StaticData.DataList1.Image3Id = item1.Image3Id;
            StaticData.DataList1.Rect3X1 = item1.Rect3X1;
            StaticData.DataList1.Rect3Y1 = item1.Rect3Y1;
            StaticData.DataList1.Rect3X2 = item1.Rect3X2;
            StaticData.DataList1.Rect3Y2 = item1.Rect3Y2;

            StaticData.DataList1.Image4Id = item1.Image4Id;
            StaticData.DataList1.Rect4X1 = item1.Rect4X1;
            StaticData.DataList1.Rect4Y1 = item1.Rect4Y1;
            StaticData.DataList1.Rect4X2 = item1.Rect4X2;
            StaticData.DataList1.Rect4Y2 = item1.Rect4Y2;
        }
        private void CopyStaticDataToDataList()
        {
            if (j < dataList.Count && StaticData.DataList1.Diagnosis != 0)
            {
                var item1 = dataList[j];
                item1.DoctorId = StaticData.DataList1.DoctorId;
                item1.Diagnosis = StaticData.DataList1.Diagnosis;
                item1.Comment = StaticData.DataList1.Comment;
                item1.Image1Id = StaticData.DataList1.Image1Id;
                item1.Rect1X1 = StaticData.DataList1.Rect1X1;
                item1.Rect1Y1 = StaticData.DataList1.Rect1Y1;
                item1.Rect1X2 = StaticData.DataList1.Rect1X2;
                item1.Rect1Y2 = StaticData.DataList1.Rect1Y2;

                item1.Image2Id = StaticData.DataList1.Image2Id;
                item1.Rect2X1 = StaticData.DataList1.Rect2X1;
                item1.Rect2Y1 = StaticData.DataList1.Rect2Y1;
                item1.Rect2X2 = StaticData.DataList1.Rect2X2;
                item1.Rect2Y2 = StaticData.DataList1.Rect2Y2;

                item1.Image3Id = StaticData.DataList1.Image3Id;
                item1.Rect3X1 = StaticData.DataList1.Rect3X1;
                item1.Rect3Y1 = StaticData.DataList1.Rect3Y1;
                item1.Rect3X2 = StaticData.DataList1.Rect3X2;
                item1.Rect3Y2 = StaticData.DataList1.Rect3Y2;

                item1.Image4Id = StaticData.DataList1.Image4Id;
                item1.Rect4X1 = StaticData.DataList1.Rect4X1;
                item1.Rect4Y1 = StaticData.DataList1.Rect4Y1;
                item1.Rect4X2 = StaticData.DataList1.Rect4X2;
                item1.Rect4Y2 = StaticData.DataList1.Rect4Y2;
            }
        }
    }
}