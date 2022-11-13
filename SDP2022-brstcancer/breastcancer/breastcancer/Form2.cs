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
        String pathPC = "C:\\Users\\Narmina\\Desktop\\SDP2022-brstcancer-main\\PotentialCancer\\";
        String pathC = "C:\\Users\\Narmina\\Desktop\\SDP2022-brstcancer-main\\Cancer\\";
        String pathNC = "C:\\Users\\Narmina\\Desktop\\SDP2022-brstcancer-main\\NotCancer\\";



        private void Form2_Load(object sender, EventArgs e)
        {
            /*radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;*/


            //pictureBox1.Invoke((MethodInvoker)(() => pictureBox1.Location = new Point(30, -10)));
            //pictureBox2.Invoke((MethodInvoker)(() => pictureBox2.Location = new Point(, )));

            //label1.Invoke((MethodInvoker)(() => label1.Location = new Point(526, 650)));

            this.BackColor = Color.FromArgb(255, 254, 252);
            //this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

          /*  Size size = new Size(300, 400);
            pictureBox1.Size = size;
            pictureBox2.Size = size;
            pictureBox3.Size = size;
            pictureBox4.Size = size; */


            string filePath = "C:\\Users\\Narmina\\Desktop\\SDP2022-brstcancer-main\\Images";
            files = Directory.GetFiles(filePath);

            this.WindowState = FormWindowState.Maximized;
            pictureBox1.Image = Image.FromFile(files[c]);
            pictureBox3.Image = Image.FromFile(files[c]);
            pictureBox4.Image = Image.FromFile(files[c]);
            pictureBox5.Image = Image.FromFile(files[c]);
            label1.BackColor = Color.Transparent;
            /*label1.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;*/

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            if (c == files.Length - 1)
                button2.Enabled = false;
            else
            {
                c++;
                button1.Enabled = true;
                label1.Text = c + 1 + " out of " + files.Length + " images \n";// + files[c];

                pictureBox1.Image = Image.FromFile(files[c]);
                pictureBox3.Image = Image.FromFile(files[c]);
                pictureBox4.Image = Image.FromFile(files[c]);
                pictureBox5.Image = Image.FromFile(files[c]);
            }
        }

        /*private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(files[c]);
            label1.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            label1.Text = c + 1 + " out of " + files.Length + " images \n";// + files[c];

        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            if (c == 0)
                button1.Enabled = false;
            else
            {
                c--;
                button2.Enabled = true;
                label1.Text = c + 1 + " out of " + files.Length + " images \n" + files[c];

                pictureBox1.Image = Image.FromFile(files[c]);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string fullPath = Path.GetFullPath(files[c]).TrimEnd(Path.DirectorySeparatorChar);
            string projectName = Path.GetFileName(fullPath);
           // MessageBox.Show(projectName);
            String pathCan = pathC + projectName;
            //MessageBox.Show(pathCan);
            pictureBox1.Image.Save(pathCan);//, ImageFormat.Jpeg);

            if (File.Exists(pathPC + projectName))
            {
                File.Delete(pathPC + projectName);
            }
            if (File.Exists(pathNC + projectName))
            {
                File.Delete(pathNC + projectName);
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string fullPath = Path.GetFullPath(files[c]).TrimEnd(Path.DirectorySeparatorChar);
            string projectName = Path.GetFileName(fullPath);
            //MessageBox.Show(projectName);
            //pictureBox1.Image.Save("myfile.png", ImageFormat.Png);
            String pathCan = pathPC + projectName;
            //MessageBox.Show(pathCan);
            pictureBox1.Image.Save(pathCan);//, ImageFormat.Jpeg);
            if (File.Exists(pathC + projectName))
            {
                File.Delete(pathC + projectName);
            }
            if (File.Exists(pathNC + projectName))
            {
                File.Delete(pathNC + projectName);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string fullPath = Path.GetFullPath(files[c]).TrimEnd(Path.DirectorySeparatorChar);
            string projectName = Path.GetFileName(fullPath);
            //MessageBox.Show(projectName);
            //pictureBox1.Image.Save("myfile.png", ImageFormat.Png);
            String pathCan = pathNC + projectName;
            //MessageBox.Show(pathCan);
            pictureBox1.Image.Save(pathCan);//, ImageFormat.Jpeg);

            if (File.Exists(pathC + projectName))
            {
                File.Delete(pathC + projectName);
            }
            if (File.Exists(pathPC + projectName))
            {
                File.Delete(pathPC + projectName);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
