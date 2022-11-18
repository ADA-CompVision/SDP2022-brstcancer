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
        public Form2()
        {
            InitializeComponent();
        }
        int c = 0;
        int diagnosisInt = 0;
        string[] files;
       // String pathPos = "E:\\OneDrive - ADA University\\Homework\\Fall2022\\SDP\\PotentialCancer\\";
        //String pathPot = "E:\\OneDrive - ADA University\\Homework\\Fall2022\\SDP\\Cancer\\";
        //String pathN = "E:\\OneDrive - ADA University\\Homework\\Fall2022\\SDP\\NotCancer\\";


        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            label1.BackColor = Color.Transparent;

            string filePath = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Images";
            files = Directory.GetFiles(filePath);

            pictureBox1.Image = Image.FromFile(files[c]);
            pictureBox5.Image = Image.FromFile(files[c]);
            pictureBox3.Image = Image.FromFile(files[c]);
            pictureBox4.Image = Image.FromFile(files[c]);

            label1.Text = c + 1 + " out of " + files.Length + " images \n";
            //MessageBox.Show(getImageId().ToString());
        }


        private void buttonPrevious_Click(object sender, EventArgs e)
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





            radioButtonPositive.Checked = false;
            radioButtonPotential.Checked = false;
            radioButtonNegative.Checked = false;

            if (c == 0)
                buttonPrevious.Enabled = false;
            else
            {
                c--;
                buttonNext.Enabled = true;
                label1.Text = c + 1 + " out of " + files.Length + " images \n" + files[c];

                pictureBox1.Image = Image.FromFile(files[c]);
                pictureBox5.Image = Image.FromFile(files[c]);
                pictureBox3.Image = Image.FromFile(files[c]);
                pictureBox4.Image = Image.FromFile(files[c]);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
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
                ImageName = files[c],
                Diagnosis = diagnosisInt,
                Comment = textBoxComment.Text,
                DoctorId = 1
            });

            // Update json data string
            jsonData = JsonConvert.SerializeObject(dataList, Formatting.Indented);
            System.IO.File.WriteAllText(filePath, jsonData);







            //reseting
            radioButtonPositive.Checked = false;
            radioButtonPotential.Checked = false;
            radioButtonNegative.Checked = false;

            if (c == files.Length - 1)
                buttonNext.Enabled = false;
            else
            {
                c++;
                buttonPrevious.Enabled = true;
                label1.Text = c + 1 + " out of " + files.Length + " images \n";// + files[c];

                pictureBox1.Image = Image.FromFile(files[c]);
                pictureBox5.Image = Image.FromFile(files[c]);
                pictureBox3.Image = Image.FromFile(files[c]);
                pictureBox4.Image = Image.FromFile(files[c]);
            }
        }

        private void radioButtonPositive_CheckedChanged_1(object sender, EventArgs e)
        {
            string fullPath = Path.GetFullPath(files[c]).TrimEnd(Path.DirectorySeparatorChar);
            string projectName = Path.GetFileName(fullPath);
            String pathCan = pathPos + projectName;
            pictureBox1.Image.Save(pathCan);

            if (File.Exists(pathPot + projectName))
            {
                File.Delete(pathPot + projectName);
            }
            if (File.Exists(pathN + projectName))
            {
                File.Delete(pathN + projectName);
            }
            diagnosisInt = 1;

        }

        private void radioButtonPotential_CheckedChanged(object sender, EventArgs e)
        {
            string fullPath = Path.GetFullPath(files[c]).TrimEnd(Path.DirectorySeparatorChar);
            string projectName = Path.GetFileName(fullPath);
            String pathCan = pathPot + projectName;
            pictureBox1.Image.Save(pathCan);
            if (File.Exists(pathPos + projectName))
            {
                File.Delete(pathPos + projectName);
            }
            if (File.Exists(pathN + projectName))
            {
                File.Delete(pathN + projectName);
            }
            diagnosisInt = 2;
        }

        private void radioButtonNegative_CheckedChanged(object sender, EventArgs e)
        {
            string fullPath = Path.GetFullPath(files[c]).TrimEnd(Path.DirectorySeparatorChar);
            string projectName = Path.GetFileName(fullPath);
            String pathCan = pathN + projectName;
            pictureBox1.Image.Save(pathCan);

            if (File.Exists(pathPos + projectName))
            {
                File.Delete(pathPos + projectName);
            }
            if (File.Exists(pathPot + projectName))
            {
                File.Delete(pathPot + projectName);
            }
            diagnosisInt = 3;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new Form4().Show();
        }
    }
}
