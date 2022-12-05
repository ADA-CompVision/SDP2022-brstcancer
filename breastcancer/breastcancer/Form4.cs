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


        //PictureBox pictureBox;
        //Pen m_penRed = new Pen(Color.Red, 2f);
        //Rectangle m_rectangle = new Rectangle(10, 100, 30, 30);

        //public Form1()
        //{
        //    // Add a picturebox for testing
        //    pictureBox = new PictureBox();
        //    pictureBox.Image = Bitmap.FromFile(@"E:\OneDrive - ADA University\Homework\Fall2022\SDP\Images\image0.png"); // Use a valid image path
        //    pictureBox.Dock = DockStyle.Fill;
        //    Controls.Add(pictureBox);
        //    // Add a Paint event handler
        //    pictureBox.Paint += m_picturebox_Paint;

        //    pictureBox.Image.Save(@"E:\OneDrive - ADA University\Homework\Fall2022\SDP\Images\imgAAA.png");
        //}

        //void m_picturebox_Paint(object sender, PaintEventArgs e)
        //{

        //    e.Graphics.DrawRectangle(m_penRed, m_rectangle);
        //}
        // This example creates a PictureBox control on the form and draws to it.
        // This example assumes that the Form_Load event handler method is
        // connected to the Load event of the form.

        // private PictureBox pictureBox1 = new PictureBox();
        // Cache font instead of recreating font objects each time we paint.
        private Font fnt = new Font("Arial", 10);
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // Dock the PictureBox to the form and set its background to white.
        //    pictureBox1.Image = Image.FromFile(@"E:\OneDrive - ADA University\Homework\Fall2022\SDP\Images\image0.png"); // Use a valid image path

        //    // pictureBox1.Dock = DockStyle.Fill;
        //    // pictureBox1.BackColor = Color.White;
        //    // Connect the Paint event of the PictureBox to the event handler method.
        //    //    pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

        //    // Add the PictureBox control to the Form.
        //    //    this.Controls.Add(pictureBox1);
        //}

        //private void pictureBox1_Paint(object sender, PaintEventArgs e)
        //{
        //    // Create a local version of the graphics object for the PictureBox.
        //    //Graphics g = e.Graphics;

        //    //// Draw a string on the PictureBox.
        //    //g.DrawString("This is a diagonal line drawn on the control",
        //    //    fnt, System.Drawing.Brushes.Blue, new Point(30, 30));
        //    //// Draw a line in the PictureBox.
        //    //g.DrawLine(System.Drawing.Pens.Red, pictureBox1.Left, pictureBox1.Top,
        //    //    pictureBox1.Right, pictureBox1.Bottom);
        //}

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

        //private void pictureBox1_Paint(object sender, PaintEventArgs e)
        //{
        //    Create a local version of the graphics object for the PictureBox.

        //   Graphics g = e.Graphics;

        //    Draw a string on the PictureBox.
        //    g.DrawString("This is a diagonal line drawn on the control",
        //        fnt, Brushes.Blue, new Point(30, 30));
        //    Draw a line in the PictureBox.
        //    g.DrawLine(Pens.Red, pictureBox1.Left, pictureBox1.Top,
        //        pictureBox1.Right, pictureBox1.Bottom);
        //}
    }
}
