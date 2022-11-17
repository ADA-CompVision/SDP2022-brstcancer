using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace breastcancer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int c = 0;
        string[] files;
        String pathPos = "E:\\OneDrive - ADA University\\Homework\\Fall2022\\SDP\\PotentialCancer\\";
        String pathPot = "E:\\OneDrive - ADA University\\Homework\\Fall2022\\SDP\\Cancer\\";
        String pathN = "E:\\OneDrive - ADA University\\Homework\\Fall2022\\SDP\\NotCancer\\";

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            label1.BackColor = Color.Transparent;

            string filePath = @"E:\\OneDrive - ADA University\\Homework\\Fall2022\\SDP\\Images";
            files = Directory.GetFiles(filePath);

            pictureBox1.Image = Image.FromFile(files[c]);
            pictureBox5.Image = Image.FromFile(files[c]);
            pictureBox3.Image = Image.FromFile(files[c]);
            pictureBox4.Image = Image.FromFile(files[c]);

            label1.Text = c + 1 + " out of " + files.Length + " images \n";
        }
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
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
