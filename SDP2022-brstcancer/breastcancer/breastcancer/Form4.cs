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
            string filePath = "C:\\Users\\Narmina\\Desktop\\SDP2022-brstcancer-main\\Images";
            files = Directory.GetFiles(filePath);
            pictureBox1.Image = Image.FromFile(files[c]);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
