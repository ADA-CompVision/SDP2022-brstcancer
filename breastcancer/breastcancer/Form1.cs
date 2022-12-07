namespace breastcancer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(34, 34, 34);
            label2.ForeColor = Color.FromArgb(126, 126, 126);

            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(34, 34, 34);
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(2, 2, this.button1.Width, this.button1.Height, 2, 2); 
            this.button1.Region = System.Drawing.Region.FromHrgn(ptr);
            NativeMethods.DeleteObject(ptr);

            button2.BackColor = Color.FromArgb(34, 34, 34);
            button2.ForeColor = Color.White;
            IntPtr ptr1 = NativeMethods.CreateRoundRectRgn(2, 2, this.button2.Width, this.button2.Height, 2, 2); 
            this.button2.Region = System.Drawing.Region.FromHrgn(ptr1);
            NativeMethods.DeleteObject(ptr1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();

        }
    }
}