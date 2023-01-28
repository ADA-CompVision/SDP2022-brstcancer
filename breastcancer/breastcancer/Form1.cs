namespace breastcancer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(34, 34, 34);

            //label pink
            string directory = Directory.GetCurrentDirectory();
            MessageBox.Show(directory);
            var parentName = Directory.GetParent(directory).FullName;
            parentName = Directory.GetParent(parentName).FullName;
            parentName = Directory.GetParent(parentName).FullName;
            parentName = Directory.GetParent(parentName).FullName;
            parentName = Directory.GetParent(parentName).FullName;        //E:\OneDrive - ADA University\Homework\SDP2022-brstcancer
            //pathJson = parentName + "\\path.json";
            //pathCol = parentName + "\\Augmentation\\Colorized";
            //pathOri = parentName + "\\Augmentation\\Original";
            //filePath = @"E:\OneDrive - ADA University\Homework\SDP2022-brstcancer\path.json";

            string pathLogoR = parentName + "\\Logo\\ribbon.png";
            pictureBox2.Image = Image.FromFile(pathLogoR);
            string pathLogoADA = parentName + "\\Logo\\adaf.png";
            pictureBox1.Image = Image.FromFile(pathLogoADA);
            string pathLogoT = parentName + "\\Logo\\tabibf.png";
            pictureBox3.Image = Image.FromFile(pathLogoT);





            label1.ForeColor = Color.WhiteSmoke;
            label2.ForeColor = Color.FromArgb(126, 126, 126);

            buttonAbout.ForeColor = Color.WhiteSmoke;
            buttonAbout.BackColor = Color.FromArgb(34, 34, 34);
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(2, 2, this.buttonAbout.Width, this.buttonAbout.Height, 5, 5);
            this.buttonAbout.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);

            buttonBrowse.BackColor = Color.WhiteSmoke;
            IntPtr ptr1 = NativeMethods.CreateRoundRectRgn(2, 2, this.buttonBrowse.Width, this.buttonBrowse.Height, 5, 5);
            this.buttonBrowse.Region = System.Drawing.Region.FromHrgn(ptr1);
            NativeMethods.DeleteObject(ptr1);
        }
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            //new Form2().Show();
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}