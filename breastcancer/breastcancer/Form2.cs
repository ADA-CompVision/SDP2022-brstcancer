using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace breastcancer
{
    public partial class Form2 : Form
    {
        Point LocationXY, LocationX1Y1;
        Rectangle rect;
        bool IsMouseDown = false;
        List<Data> dataList = new List<Data>();

        int ii = 0;
        int jj = 0;
        int prev = 0;
        int c = 0;
        int diagnosisInt = 0;
        string[] filesNotResized;
        string[] filesBrightened;
        string[] filesDarked;
        string[] filesHighlyBrightened;
        string[] filesColor1, filesColor2, filesColor3, filesColor4, filesColor5, filesResizedTo511, filesResizedTo255, filesResizedTo1000, filesResizedTo1023;
        string filePath = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\path.json";
        string jsonData;

        //string fullPath = Path.GetFullPath(filePath).TrimEnd(Path.DirectorySeparatorChar);
        //string projectName = fullPath.Split(Path.DirectorySeparatorChar).Last();


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
            //panel3.BackColor = Color.FromArgb(45, 45, 45);
            panel4.BackColor = Color.FromArgb(45, 45, 45);

            label2.AutoSize = false;
            label2.Height = 1;
            label2.Width = 10000;
            label2.BorderStyle = BorderStyle.Fixed3D;


            radioButtonNegative.BackColor = Color.FromArgb(55, 55, 55);
            radioButtonNegative.ForeColor = Color.White;
            radioButtonPositive.BackColor = Color.FromArgb(55, 55, 55);
            radioButtonPositive.ForeColor = Color.White;
            radioButtonPotential.BackColor = Color.FromArgb(55, 55, 55);
            radioButtonPotential.ForeColor = Color.White;
            labelMark.BackColor = Color.Transparent;
            labelMark.ForeColor = Color.White;

            textBoxComment.Text = "Write a comment...";
            textBoxComment.ForeColor = Color.White;
            textBoxComment.BackColor = Color.FromArgb(55, 55, 55);

            labelDComment.ForeColor = Color.White;
            labelDComment.BackColor = Color.Transparent;

            labelNotes.ForeColor = Color.White;
            labelNotes.BackColor = Color.Transparent;

            label3.ForeColor = Color.WhiteSmoke;
            label4.ForeColor = Color.WhiteSmoke;
            label5.ForeColor = Color.WhiteSmoke;
            label12.ForeColor = Color.WhiteSmoke;
            label8.ForeColor = Color.WhiteSmoke;
            label7.ForeColor = Color.WhiteSmoke;
            label6.ForeColor = Color.WhiteSmoke;
            label11.ForeColor = Color.WhiteSmoke;


            IntPtr ptr = NativeMethods.CreateRoundRectRgn(2, 2, this.textBoxComment.Width, this.textBoxComment.Height, 5, 5); //play with these values till you are happy
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

            string filePathColor2 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color2";
            filesColor2 = Directory.GetFiles(filePathColor2);

            string filePathColor3 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color3";
            filesColor3 = Directory.GetFiles(filePathColor3);

            string filePathColor4 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color4";
            filesColor4 = Directory.GetFiles(filePathColor4);

            string filePathColor5 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Color5";
            filesColor5 = Directory.GetFiles(filePathColor5);

            //darked
            string filePathDarked = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\Darked";
            filesDarked = Directory.GetFiles(filePathDarked);

            //HighlyBrightened
            string filePathHighlyBrightened = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\HighlyBrightened";
            filesHighlyBrightened = Directory.GetFiles(filePathHighlyBrightened);

            //need notresized here
            string filePathNotResized = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\NotResized";
            filesNotResized = Directory.GetFiles(filePathNotResized);

            //Resizedto255        
            string filePathResizedTo255 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo255";
            filesResizedTo255 = Directory.GetFiles(filePathResizedTo255);

            string filePathResizedTo511 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo511";
            filesResizedTo511 = Directory.GetFiles(filePathResizedTo511);

            string filePathResizedTo1000 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo1000";
            filesResizedTo1000 = Directory.GetFiles(filePathResizedTo1000);

            string filePathResizedTo1023 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo1023";
            filesResizedTo1023 = Directory.GetFiles(filePathResizedTo1023);

            pictureBox3.Image = Image.FromFile(filesNotResized[c]);
            pictureBox4.Image = Image.FromFile(filesBrightened[c]);
            pictureBox5.Image = Image.FromFile(filesHighlyBrightened[c]);
            pictureBox1.Image = Image.FromFile(filesDarked[c]);
            pictureBox2.Image = Image.FromFile(filesResizedTo255[c]);
            pictureBox6.Image = Image.FromFile(filesResizedTo511[c]);
            pictureBox7.Image = Image.FromFile(filesResizedTo1000[c]);
            pictureBox8.Image = Image.FromFile(filesResizedTo1023[c]);


            label1.Text = c + 1 + " out of " + filesNotResized.Length + " images \n";
        }


        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            buttonPreviousFunction();
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonNextFunction();
        }
        private void radioButtonPositive_CheckedChanged_1(object sender, EventArgs e)
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
        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new Form4().Show();
        }
        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new Form4().Show();
        }
        private void pictureBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new Form4().Show();
        }
        private void pictureBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new Form4().Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(filesNotResized[c]);
            pictureBox3.Image = Image.FromFile(filesBrightened[c]);
            pictureBox4.Image = Image.FromFile(filesDarked[c]);
            pictureBox5.Image = Image.FromFile(filesHighlyBrightened[c]);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(filesNotResized[c]);
            pictureBox5.Image = Image.FromFile(filesBrightened[c]);
            pictureBox1.Image = Image.FromFile(filesDarked[c]);
            pictureBox4.Image = Image.FromFile(filesHighlyBrightened[c]);
        }
        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            new Form4().Show();
        }
        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            new Form4().Show();
        }
        private void pictureBox5_DoubleClick(object sender, EventArgs e)
        {
            new Form4().Show();
        }
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.buttonUp.Focus();

            }
            else if (e.KeyCode == Keys.Down)
            {
                this.buttonDown.Focus();
            }
            else if (e.KeyCode == Keys.Right)
            {
                buttonNextFunction();
                this.buttonNext.Focus();
            }
            else if (e.KeyCode == Keys.Left)
            {
                buttonPreviousFunction();
                this.buttonPrevious.Focus();
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
            IsMouseDown = true;
            LocationXY = e.Location;
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
            if (rect != null)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
                Rectangle rect1 = pictureBox3.ClientRectangle;

                Bitmap bmp = new Bitmap(rect1.Width, rect1.Height);
                // Bitmap bmp = new Bitmap(2800, 3518, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);


                pictureBox3.DrawToBitmap(bmp, rect1);
                // pictureBox3.DrawToBitmap(bmp, rect);
                String filePath = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Labeled\imgg.png";
                //bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                //using (Bitmap bitmap = (Bitmap)Image.FromFile(filePath))
                //{
                //    using (Bitmap newBitmap = new Bitmap(bitmap))
                //    {
                //        newBitmap.SetResolution(2800, 3518);

                //        newBitmap.Save(@"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Labeled\imggNNN.png", System.Drawing.Imaging.ImageFormat.Png);
                //    }
                //}
                //bmp = ResizeImage(pictureBox3.Image, 2800, 3518);
                // bmp.SetResolution(pictureBox3.Image.HorizontalResolution, pictureBox3.Image.VerticalResolution);

                bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                //pictureBox3.Image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            if (rect != null)// && IsMouseDown == true)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
                Rectangle rect1 = pictureBox4.ClientRectangle;

                Bitmap bmp = new Bitmap(rect1.Width, rect1.Height);
                // Bitmap bmp = new Bitmap(2800, 3518, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);


                pictureBox4.DrawToBitmap(bmp, rect1);
                // pictureBox3.DrawToBitmap(bmp, rect);
                String filePath = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Labeled\imgg4.png";

                bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            LocationXY = e.Location;
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
        //private void panel3_Paint(object sender, PaintEventArgs e)
        //{
        //    IntPtr ptr = NativeMethods.CreateRoundRectRgn(3, 3, this.panel3.Width, this.panel3.Height, 11, 11); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
        //    this.panel3.Region = System.Drawing.Region.FromHrgn(ptr);
        //    NativeMethods.DeleteObject(ptr);
        //}
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(3, 3, this.panel4.Width, this.panel4.Height, 11, 11); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.panel4.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        #region Make draggable

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        //private void (object sender, EventArgs e)
        //{
        //    // pictureBox3.BackColor = Color.White;
        //    this.pictureBox3.BorderStyle = BorderStyle.Fixed3D;

        //}

        //private void pictureBox3_MouseLeave(object sender, EventArgs e)
        //{
        //    this.pictureBox3.BackColor = Color.Black;
        //}

        private Rectangle GetRect()
        {
            rect = new Rectangle();
            rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
            rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);

            rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
            rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);

            return rect;
        }
        private void buttonNextFunction()
        {
            prev = 0;
            if (radioButtonNegative.Checked == false && radioButtonPositive.Checked == false && radioButtonPotential.Checked == false)
            {
                MessageBox.Show("You need to choose one option");
            }
            else
            {

                int id = 1;

                //if (dataList.Count > 0)
                //{
                //    id = dataList.Max(x => x.ImageId) + 1;
                //}

                if (ii == dataList.Count || dataList.Count == 0)
                {
                    id = dataList.Count + 1;


                    // Add any new data
                    dataList.Add(new Data()
                    {
                        ImageId = id,// w,//get last image id from json file then ++ and assign
                        ImageName = filesNotResized[c].TrimEnd('\\'),
                        Diagnosis = diagnosisInt,
                        Comment = textBoxComment.Text,
                        DoctorId = 1
                    });
                    JsonSave();


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

                        pictureBox1.Image = Image.FromFile(filesNotResized[c]);
                        pictureBox5.Image = Image.FromFile(filesBrightened[c]);
                        pictureBox3.Image = Image.FromFile(filesDarked[c]);
                        pictureBox4.Image = Image.FromFile(filesHighlyBrightened[c]);
                    }
                }
                else
                {
                    //update
                    int d = 0;
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

                    if (item.Comment != this.textBoxComment.Text || item.Diagnosis != d)
                    {
                        Update(ii);
                        JsonSave();
                    }
                }

                ii++;








                // Update json data string
                //jsonData = JsonConvert.SerializeObject(dataList, Formatting.Indented);
                //System.IO.File.WriteAllText(filePath, jsonData);


                //reseting function yaz bura
                //if (ii == dataList.Count)
                //{
                //    textBoxComment.Text = "";

                //    radioButtonPositive.Checked = false;
                //    radioButtonPotential.Checked = false;
                //    radioButtonNegative.Checked = false;

                //    if (c == filesNotResized.Length - 1)
                //        buttonNext.Enabled = false;
                //    else
                //    {
                //        c++;
                //        buttonPrevious.Enabled = true;
                //        label1.Text = c + 1 + " out of " + filesNotResized.Length + " images \n";// + files[c];

                //        pictureBox1.Image = Image.FromFile(filesNotResized[c]);
                //        pictureBox5.Image = Image.FromFile(filesBrightened[c]);
                //        pictureBox3.Image = Image.FromFile(filesDarked[c]);
                //        pictureBox4.Image = Image.FromFile(filesHighlyBrightened[c]);
                //    }
                //JsonSave();

                // }
                // ii++;

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
        }
        private void buttonPreviousFunction()
        {

            if (c == 0)
                buttonPrevious.Enabled = false;
            else
            {
                prev--;
                int d = 0;
                ii--;
                jj = ii + 1;
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

                if (prev == -1)
                {
                    item = dataList[ii];
                }
                if (prev < -1)
                {
                    item = dataList[jj];
                }

                if (item.Comment != this.textBoxComment.Text || item.Diagnosis != d)
                {
                    Update(jj);
                    JsonSave();
                }






                c--;
                buttonNext.Enabled = true;
                label1.Text = c + 1 + " out of " + filesNotResized.Length + " images \n";// + filesNotResized[c];

                pictureBox1.Image = Image.FromFile(filesNotResized[c]);
                pictureBox5.Image = Image.FromFile(filesBrightened[c]);
                pictureBox3.Image = Image.FromFile(filesDarked[c]);
                pictureBox4.Image = Image.FromFile(filesHighlyBrightened[c]);
            }
        }
        private void addJsonToList()
        {
            //var filePath = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\path.json";
            //// Read existing json data
            //var jsonData = System.IO.File.ReadAllText(filePath);
            //// De-serialize to object or create new list
            //var dataList = JsonConvert.DeserializeObject<List<Data>>(jsonData)
            //                      ?? new List<Data>();
            //int id = 1;
            //if (dataList.Count > 0)
            //{
            //    id = dataList.Max(x => x.ImageId) + 1;
            //}



            //// Add any new data
            //dataList.Add(new Data()
            //{
            //    ImageId = id,// w,//get last image id from json file then ++ and assign
            //    ImageName = filesNotResized[c],
            //    Diagnosis = diagnosisInt,
            //    Comment = textBoxComment.Text,
            //    DoctorId = 1
            //});

            //// Update json data string
            //jsonData = JsonConvert.SerializeObject(dataList, Formatting.Indented);
            //System.IO.File.WriteAllText(filePath, jsonData);
        }
        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}