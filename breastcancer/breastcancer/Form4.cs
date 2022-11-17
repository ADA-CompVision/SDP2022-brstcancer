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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int c = 0;
        string[] files;
                
        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.WindowState = FormWindowState.Maximized;

            string filePath = @"E:\\OneDrive - ADA University\\Homework\\Fall2022\\SDP\\Images";
            files = Directory.GetFiles(filePath);

            pictureBox1.Image = Image.FromFile(files[c]);           
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //new Form2().Show();
            this.Close();

        }
    }
}
