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
            this.BackColor = BackColor = Color.White;


            string filePath = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\Photos\NotResized";
            files = Directory.GetFiles(filePath);

            pictureBox1.Image = Image.FromFile(files[c]);
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //new Form2().Show();
            this.Close();

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
          
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                if (e.Delta <= 0)
                {
                    //set minimum size to zoom
                    if (pictureBox1.Width < 50)
                        // lbl_Zoom.Text = pictureBox1.Image.Size; 
                        return;
                }
                else
                {
                    //set maximum size to zoom
                    if (pictureBox1.Width > 1000)
                        return;
                }
                pictureBox1.Width += Convert.ToInt32(pictureBox1.Width * e.Delta / 1000);
                pictureBox1.Height += Convert.ToInt32(pictureBox1.Height * e.Delta / 1000);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {

           // pictureBox3.Image = Image.FromFile(filesNotResized[c]);
           
        }
    }
}
