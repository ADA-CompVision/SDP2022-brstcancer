using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Point downPoint, upPoint;


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
        string[] filesColor1, filesColor2, filesColor3, filesColor4, filesColor5, filesResizedTo511;
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

            // Read existing json data
            jsonData = System.IO.File.ReadAllText(filePath);
            // De-serialize to object or create new list
            dataList = JsonConvert.DeserializeObject<List<Data>>(jsonData)
                                  ?? new List<Data>();

            this.KeyPreview = true;

            this.WindowState = FormWindowState.Maximized;
            this.BackColor = BackColor = Color.White;
            label1.BackColor = Color.Transparent;

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

            string filePathHighlyBrightened = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\HighlyBrightened";
            filesHighlyBrightened = Directory.GetFiles(filePathHighlyBrightened);

            string filePathNotResized = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\NotResized";
            filesNotResized = Directory.GetFiles(filePathNotResized);

            string filePathResizedTo255 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo255";
            filesBrightened = Directory.GetFiles(filePathResizedTo255);

            string filePathResizedTo511 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo511";
            filesResizedTo511 = Directory.GetFiles(filePathResizedTo511);

            string filePathResizedTo1000 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo1000";
            filesHighlyBrightened = Directory.GetFiles(filePathResizedTo1000);

            string filePathResizedTo1023 = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Augmentation\ResizedTo1023";
            filesHighlyBrightened = Directory.GetFiles(filePathResizedTo1023);

            pictureBox3.Image = Image.FromFile(filesNotResized[c]);
            pictureBox4.Image = Image.FromFile(filesBrightened[c]);
            //  pictureBox5.Image = Image.FromFile(filesDarked[c]);
            pictureBox1.Image = Image.FromFile(filesHighlyBrightened[c]);
            //  pictureBox2.Image = Image.FromFile(filesDarked[c]);
            pictureBox6.Image = Image.FromFile(filesHighlyBrightened[c]);

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






        public void drawEllipse(PictureBox pb, int x, int y, int w, int h, float Bwidth)
        {
            //refresh the picture box
            pb.Refresh();
            //create a graphics object
            Graphics g = pb.CreateGraphics();
            //create a pen object
            Pen p = new Pen(Color.Red, Bwidth);
            //draw Ellipse
            g.DrawEllipse(p, x, y, w, h);
            //dispose pen and graphics object
            //p.Dispose();
            //g.Dispose();
        }
        int x, y, x0, x1, y0,y1;
        public void DrawRectangleFloat(PaintEventArgs e)
        {

            // Create pen.
            Pen pen = new Pen(Color.Red, 3);

            // Create location and size of rectangle.
            //float x = 0.0F;
            //float y = 0.0F;
            float width = 200.0F;
            float height = 200.0F;

            // Draw rectangle to screen.
            //e.Graphics.DrawRectangle(blackPen, x, y, width, height);

            // int x, y;
            //Pen pen = new Pen(Color.Red);
            //Rectangle rect = new Rectangle();
            pictureBox3.CreateGraphics().DrawRectangle(pen, x, y, 25, 52);
        }



        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            //x = e.X;
            //y = e.Y;
            //Pen pen = new Pen(Color.Red, 3);
            //pictureBox3.CreateGraphics().DrawRectangle(pen, x, y, 50, 52);
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            upPoint = e.Location;
            //CreateShape();
            //pictureBox3.CreateGraphics().DrawRectangle(pen, 20, 30, 25, 52);
            Pen pen = new Pen(Color.Red, 3);

            Rectangle rect = new Rectangle(downPoint.X, downPoint.Y, upPoint.X - downPoint.X, upPoint.Y - downPoint.Y);
            pictureBox3.CreateGraphics().DrawRectangle(pen, rect);
            //Rect rectangle = new Rect() { rect = rect };
            this.Invalidate();
            //MessageBox.Show("UP " + upPoint.ToString());

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = e.Location;
            //MessageBox.Show("Down "+ downPoint.ToString());
        }

        private void buttonPen_Click(object sender, EventArgs e)
        {
            //  int x, y;
            Pen pen = new Pen(Color.Red);
            Rectangle rect = new Rectangle();
            pictureBox3.CreateGraphics().DrawRectangle(pen, 20, 30, 25, 52);
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