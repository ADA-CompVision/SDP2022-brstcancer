﻿using System;
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
        public Form2()
        {
            InitializeComponent();
        }
        int c = 0;
        int diagnosisInt = 0;
        string[] filesNotResized;
        string[] filesBrightened;
        string[] filesDarked;
        string[] filesHighlyBrightened;


        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = BackColor = Color.White;
            label1.BackColor = Color.Transparent;

            string filePathNotResized = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Photos\NotResized";
            filesNotResized = Directory.GetFiles(filePathNotResized);

            string filePathBrightened = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Photos\Brightened";
            filesBrightened = Directory.GetFiles(filePathBrightened);

            string filePathDarked = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Photos\Darked";
            filesDarked = Directory.GetFiles(filePathDarked);

            string filePathHighlyBrightened = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Photos\HighlyBrightened";
            filesHighlyBrightened = Directory.GetFiles(filePathHighlyBrightened);

            pictureBox1.Image = Image.FromFile(filesNotResized[c]);
            pictureBox5.Image = Image.FromFile(filesBrightened[c]);
            pictureBox3.Image = Image.FromFile(filesDarked[c]);
            pictureBox4.Image = Image.FromFile(filesHighlyBrightened[c]);

            label1.Text = c + 1 + " out of " + filesNotResized.Length + " images \n";
        }


        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (radioButtonNegative.Checked == false && radioButtonPositive.Checked == false && radioButtonPotential.Checked == false)
            {
                MessageBox.Show("You need to choose one option");
            }
            else
            {

                var filePath = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\path.json";
                // Read existing json data
                var jsonData = System.IO.File.ReadAllText(filePath);
                // De-serialize to object or create new list
                var dataList = JsonConvert.DeserializeObject<List<Data>>(jsonData)
                                      ?? new List<Data>();
                int id = 1;
                if (dataList.Count > 0)
                {
                    id = dataList.Max(x => x.ImageId) + 1;
                }

                // Add any new data
                dataList.Add(new Data()
                {
                    ImageId = id,// w,//get last image id from json file then ++ and assign
                                 //ImageName
                    Diagnosis = diagnosisInt,
                    Comment = textBoxComment.Text,
                    DoctorId = 1
                });

                // Update json data string
                jsonData = JsonConvert.SerializeObject(dataList, Formatting.Indented);
                System.IO.File.WriteAllText(filePath, jsonData);




                textBoxComment.Text = "";
                radioButtonPositive.Checked = false;
                radioButtonPotential.Checked = false;
                radioButtonNegative.Checked = false;

                if (c == 0)
                    buttonPrevious.Enabled = false;
                else
                {
                    c--;
                    buttonNext.Enabled = true;
                    label1.Text = c + 1 + " out of " + filesNotResized.Length + " images \n";// + filesNotResized[c];

                    pictureBox1.Image = Image.FromFile(filesNotResized[c]);
                    pictureBox5.Image = Image.FromFile(filesBrightened[c]);
                    pictureBox3.Image = Image.FromFile(filesDarked[c]);
                    pictureBox4.Image = Image.FromFile(filesHighlyBrightened[c]);
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (radioButtonNegative.Checked == false && radioButtonPositive.Checked == false && radioButtonPotential.Checked == false)
            {
                MessageBox.Show("You need to choose one option");
            }
            else
            {
                var filePath = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\path.json";
                // Read existing json data
                var jsonData = System.IO.File.ReadAllText(filePath);
                // De-serialize to object or create new list
                var dataList = JsonConvert.DeserializeObject<List<Data>>(jsonData)
                                      ?? new List<Data>();
                int id = 1;
                if (dataList.Count > 0)
                {
                    id = dataList.Max(x => x.ImageId) + 1;
                }

                // Add any new data
                dataList.Add(new Data()
                {
                    ImageId = id,// w,//get last image id from json file then ++ and assign
                    ImageName = filesNotResized[c],
                    Diagnosis = diagnosisInt,
                    Comment = textBoxComment.Text,
                    DoctorId = 1
                });

                // Update json data string
                jsonData = JsonConvert.SerializeObject(dataList, Formatting.Indented);
                System.IO.File.WriteAllText(filePath, jsonData);



                //reseting
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
    }
}
