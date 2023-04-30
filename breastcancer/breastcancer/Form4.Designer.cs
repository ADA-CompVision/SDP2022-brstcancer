using System.Windows.Forms;

namespace breastcancer
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelNotes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMark = new System.Windows.Forms.Label();
            this.radioButtonPositive = new System.Windows.Forms.RadioButton();
            this.radioButtonNegative = new System.Windows.Forms.RadioButton();
            this.radioButtonPotential = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelDComment = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMa = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonQuestionM = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.lbl_patient = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrevious.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrevious.Location = new System.Drawing.Point(3, 6);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(111, 37);
            this.buttonPrevious.TabIndex = 297;
            this.buttonPrevious.Text = "Back";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNext.Location = new System.Drawing.Point(120, 6);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(112, 37);
            this.buttonNext.TabIndex = 298;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelNotes
            // 
            this.labelNotes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNotes.Location = new System.Drawing.Point(3, 222);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(65, 22);
            this.labelNotes.TabIndex = 301;
            this.labelNotes.Text = "Notes";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(1042, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 702);
            this.panel1.TabIndex = 914;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonPrevious, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonNext, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 615);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(235, 49);
            this.tableLayoutPanel2.TabIndex = 918;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNotes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxComment, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelDComment, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.27184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.72816F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 459);
            this.tableLayoutPanel1.TabIndex = 917;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.labelMark);
            this.panel2.Controls.Add(this.radioButtonPositive);
            this.panel2.Controls.Add(this.radioButtonNegative);
            this.panel2.Controls.Add(this.radioButtonPotential);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(3, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 153);
            this.panel2.TabIndex = 915;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMark.Location = new System.Drawing.Point(10, 15);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(90, 19);
            this.labelMark.TabIndex = 915;
            this.labelMark.Text = "Mark it as:";
            // 
            // radioButtonPositive
            // 
            this.radioButtonPositive.AutoSize = true;
            this.radioButtonPositive.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonPositive.Location = new System.Drawing.Point(10, 52);
            this.radioButtonPositive.Name = "radioButtonPositive";
            this.radioButtonPositive.Size = new System.Drawing.Size(84, 23);
            this.radioButtonPositive.TabIndex = 300;
            this.radioButtonPositive.TabStop = true;
            this.radioButtonPositive.Text = "Positive";
            this.radioButtonPositive.UseVisualStyleBackColor = true;
            this.radioButtonPositive.CheckedChanged += new System.EventHandler(this.radioButtonPositive_CheckedChanged);
            // 
            // radioButtonNegative
            // 
            this.radioButtonNegative.AutoSize = true;
            this.radioButtonNegative.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonNegative.Location = new System.Drawing.Point(10, 106);
            this.radioButtonNegative.Name = "radioButtonNegative";
            this.radioButtonNegative.Size = new System.Drawing.Size(91, 23);
            this.radioButtonNegative.TabIndex = 900;
            this.radioButtonNegative.TabStop = true;
            this.radioButtonNegative.Text = "Negative";
            this.radioButtonNegative.UseVisualStyleBackColor = true;
            // 
            // radioButtonPotential
            // 
            this.radioButtonPotential.AutoSize = true;
            this.radioButtonPotential.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonPotential.Location = new System.Drawing.Point(10, 79);
            this.radioButtonPotential.Name = "radioButtonPotential";
            this.radioButtonPotential.Size = new System.Drawing.Size(94, 23);
            this.radioButtonPotential.TabIndex = 800;
            this.radioButtonPotential.TabStop = true;
            this.radioButtonPotential.Text = "Potential";
            this.radioButtonPotential.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 385);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 111);
            this.textBox1.TabIndex = 905;
            this.textBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(64, 583);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 801;
            this.label14.Text = "label14";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 677);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 298;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 677);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 299;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxComment.Location = new System.Drawing.Point(3, 261);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(229, 195);
            this.textBoxComment.TabIndex = 905;
            this.textBoxComment.TabStop = false;
            this.textBoxComment.Enter += new System.EventHandler(this.textBoxComment_Enter);
            this.textBoxComment.Leave += new System.EventHandler(this.textBoxComment_Leave);
            // 
            // labelDComment
            // 
            this.labelDComment.AutoSize = true;
            this.labelDComment.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDComment.Location = new System.Drawing.Point(3, 0);
            this.labelDComment.Name = "labelDComment";
            this.labelDComment.Size = new System.Drawing.Size(221, 24);
            this.labelDComment.TabIndex = 916;
            this.labelDComment.Text = "Doctor\'s comments";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.74105F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.25895F));
            this.tableLayoutPanel6.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1304, 708);
            this.tableLayoutPanel6.TabIndex = 932;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.tableLayoutPanel7);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tableLayoutPanel5);
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Controls.Add(this.lbl_patient);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1033, 702);
            this.panel4.TabIndex = 920;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.buttonPencil, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.buttonClean, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(899, 46);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(131, 71);
            this.tableLayoutPanel7.TabIndex = 933;
            // 
            // buttonPencil
            // 
            this.buttonPencil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPencil.BackgroundImage = global::breastcancer.Properties.Resources.pencil;
            this.buttonPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPencil.Location = new System.Drawing.Point(7, 10);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(50, 50);
            this.buttonPencil.TabIndex = 921;
            this.buttonPencil.UseVisualStyleBackColor = true;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClean.BackgroundImage = global::breastcancer.Properties.Resources.eraser;
            this.buttonClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClean.Location = new System.Drawing.Point(73, 11);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(50, 48);
            this.buttonClean.TabIndex = 928;
            this.buttonClean.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(9, 609);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 918;
            this.label2.Text = "label2";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.labelMa, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(23, 40);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(177, 37);
            this.tableLayoutPanel5.TabIndex = 932;
            // 
            // labelMa
            // 
            this.labelMa.AutoSize = true;
            this.labelMa.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMa.Location = new System.Drawing.Point(3, 0);
            this.labelMa.Name = "labelMa";
            this.labelMa.Size = new System.Drawing.Size(161, 24);
            this.labelMa.TabIndex = 922;
            this.labelMa.Text = "Mammograms";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(326, 41);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.20113F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(445, 560);
            this.tableLayoutPanel4.TabIndex = 931;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 554);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.44695F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.68848F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.86456F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel3.Controls.Add(this.buttonQuestionM, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonDown, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonUp, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonTest, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 621);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1024, 71);
            this.tableLayoutPanel3.TabIndex = 930;
            // 
            // buttonQuestionM
            // 
            this.buttonQuestionM.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonQuestionM.BackgroundImage = global::breastcancer.Properties.Resources.ques;
            this.buttonQuestionM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonQuestionM.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQuestionM.Location = new System.Drawing.Point(3, 10);
            this.buttonQuestionM.Name = "buttonQuestionM";
            this.buttonQuestionM.Size = new System.Drawing.Size(50, 50);
            this.buttonQuestionM.TabIndex = 921;
            this.buttonQuestionM.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDown.BackgroundImage = global::breastcancer.Properties.Resources.down11;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(971, 10);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(50, 50);
            this.buttonDown.TabIndex = 801;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonUp.BackgroundImage = global::breastcancer.Properties.Resources.up11;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(906, 10);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(50, 50);
            this.buttonUp.TabIndex = 302;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(396, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 801;
            this.label1.Text = "label1";
            // 
            // buttonTest
            // 
            this.buttonTest.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonTest.BackgroundImage = global::breastcancer.Properties.Resources.predict1;
            this.buttonTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTest.Location = new System.Drawing.Point(764, 7);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(129, 57);
            this.buttonTest.TabIndex = 929;
            this.buttonTest.Text = "Predict";
            this.buttonTest.UseVisualStyleBackColor = true;
            // 
            // lbl_patient
            // 
            this.lbl_patient.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_patient.AutoSize = true;
            this.lbl_patient.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_patient.Location = new System.Drawing.Point(773, 583);
            this.lbl_patient.Name = "lbl_patient";
            this.lbl_patient.Size = new System.Drawing.Size(73, 19);
            this.lbl_patient.TabIndex = 927;
            this.lbl_patient.Text = "Patient: ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1305, 713);
            this.Controls.Add(this.tableLayoutPanel6);
            this.MinimumSize = new System.Drawing.Size(1278, 678);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mammograms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonPrevious;
        private Button buttonNext;
        private Label labelNotes;
        private Label labelDComment;
        private Panel panel2;
        private Label labelMark;
        private RadioButton radioButtonPositive;
        private RadioButton radioButtonNegative;
        private RadioButton radioButtonPotential;
        private TextBox textBox1;
        private Label label14;
        private Button button1;
        private Button button2;
        private TextBox textBoxComment;
        private TableLayoutPanel tableLayoutPanel6;
        protected Panel panel1;
        private Panel panel4;
        private Button buttonDown;
        private Button buttonUp;
        private Label label1;
        private Button buttonQuestionM;
        private Button buttonClean;
        private Label lbl_patient;
        private Button buttonPencil;
        private Label labelMa;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonTest;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel7;
    }
}
//    private void InitializeComponent()
//    {
//        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
//        this.buttonPencil = new System.Windows.Forms.Button();
//        this.buttonQuestionM = new System.Windows.Forms.Button();
//        this.buttonDown = new System.Windows.Forms.Button();
//        this.label2 = new System.Windows.Forms.Label();
//        this.buttonUp = new System.Windows.Forms.Button();
//        this.label1 = new System.Windows.Forms.Label();
//        this.label3 = new System.Windows.Forms.Label();
//        this.pictureBox1 = new System.Windows.Forms.PictureBox();
//        this.panel4 = new System.Windows.Forms.Panel();
//        this.buttonClean = new System.Windows.Forms.Button();
//        this.labelMark = new System.Windows.Forms.Label();
//        this.radioButtonPositive = new System.Windows.Forms.RadioButton();
//        this.radioButtonNegative = new System.Windows.Forms.RadioButton();
//        this.radioButtonPotential = new System.Windows.Forms.RadioButton();
//        this.textBox1 = new System.Windows.Forms.TextBox();
//        this.label14 = new System.Windows.Forms.Label();
//        this.button1 = new System.Windows.Forms.Button();
//        this.button2 = new System.Windows.Forms.Button();
//        this.panel2 = new System.Windows.Forms.Panel();
//        this.panel1 = new System.Windows.Forms.Panel();
//        this.labelNotes = new System.Windows.Forms.Label();
//        this.labelDComment = new System.Windows.Forms.Label();
//        this.textBoxComment = new System.Windows.Forms.TextBox();
//        this.buttonNext = new System.Windows.Forms.Button();
//        this.buttonPrevious = new System.Windows.Forms.Button();
//        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
//        this.panel4.SuspendLayout();
//        this.panel2.SuspendLayout();
//        this.panel1.SuspendLayout();
//        this.SuspendLayout();
//        // 
//        // buttonPencil
//        // 
//        this.buttonPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPencil.BackgroundImage")));
//        this.buttonPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//        this.buttonPencil.Location = new System.Drawing.Point(953, 78);
//        this.buttonPencil.Name = "buttonPencil";
//        this.buttonPencil.Size = new System.Drawing.Size(50, 50);
//        this.buttonPencil.TabIndex = 921;
//        this.buttonPencil.UseVisualStyleBackColor = true;
//        this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
//        // 
//        // buttonQuestionM
//        // 
//        this.buttonQuestionM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonQuestionM.BackgroundImage")));
//        this.buttonQuestionM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//        this.buttonQuestionM.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//        this.buttonQuestionM.Location = new System.Drawing.Point(24, 633);
//        this.buttonQuestionM.Name = "buttonQuestionM";
//        this.buttonQuestionM.Size = new System.Drawing.Size(44, 44);
//        this.buttonQuestionM.TabIndex = 921;
//        this.buttonQuestionM.UseVisualStyleBackColor = true;
//        // 
//        // buttonDown
//        // 
//        this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
//        this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//        this.buttonDown.Location = new System.Drawing.Point(1028, 615);
//        this.buttonDown.Name = "buttonDown";
//        this.buttonDown.Size = new System.Drawing.Size(50, 50);
//        this.buttonDown.TabIndex = 801;
//        this.buttonDown.UseVisualStyleBackColor = true;
//        this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
//        // 
//        // label2
//        // 
//        this.label2.AutoSize = true;
//        this.label2.Location = new System.Drawing.Point(3, 597);
//        this.label2.Name = "label2";
//        this.label2.Size = new System.Drawing.Size(38, 15);
//        this.label2.TabIndex = 918;
//        this.label2.Text = "label2";
//        // 
//        // buttonUp
//        // 
//        this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
//        this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//        this.buttonUp.Location = new System.Drawing.Point(972, 615);
//        this.buttonUp.Name = "buttonUp";
//        this.buttonUp.Size = new System.Drawing.Size(50, 50);
//        this.buttonUp.TabIndex = 302;
//        this.buttonUp.UseVisualStyleBackColor = true;
//        this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
//        // 
//        // label1
//        // 
//        this.label1.AutoSize = true;
//        this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//        this.label1.Location = new System.Drawing.Point(942, 565);
//        this.label1.Name = "label1";
//        this.label1.Size = new System.Drawing.Size(61, 20);
//        this.label1.TabIndex = 927;
//        this.label1.Text = "Patient: ";
//        // 
//        // label3
//        // 
//        this.label3.AutoSize = true;
//        this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//        this.label3.Location = new System.Drawing.Point(548, 662);
//        this.label3.Name = "label3";
//        this.label3.Size = new System.Drawing.Size(38, 15);
//        this.label3.TabIndex = 908;
//        this.label3.Text = "label3";
//        // 
//        // pictureBox1
//        // 
//        this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
//        this.pictureBox1.Location = new System.Drawing.Point(342, 13);
//        this.pictureBox1.Name = "pictureBox1";
//        this.pictureBox1.Size = new System.Drawing.Size(467, 586);
//        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//        this.pictureBox1.TabIndex = 2;
//        this.pictureBox1.TabStop = false;
//        this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
//        this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
//        // 
//        // panel4
//        // 
//        this.panel4.Controls.Add(this.buttonClean);
//        this.panel4.Controls.Add(this.buttonPencil);
//        this.panel4.Controls.Add(this.buttonQuestionM);
//        this.panel4.Controls.Add(this.buttonDown);
//        this.panel4.Controls.Add(this.label2);
//        this.panel4.Controls.Add(this.buttonUp);
//        this.panel4.Controls.Add(this.label1);
//        this.panel4.Controls.Add(this.label3);
//        this.panel4.Controls.Add(this.pictureBox1);
//        this.panel4.Location = new System.Drawing.Point(5, 9);
//        this.panel4.Name = "panel4";
//        this.panel4.Size = new System.Drawing.Size(1087, 691);
//        this.panel4.TabIndex = 922;
//        this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
//        // 
//        // buttonClean
//        // 
//        this.buttonClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClean.BackgroundImage")));
//        this.buttonClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//        this.buttonClean.Location = new System.Drawing.Point(1018, 78);
//        this.buttonClean.Name = "buttonClean";
//        this.buttonClean.Size = new System.Drawing.Size(50, 50);
//        this.buttonClean.TabIndex = 928;
//        this.buttonClean.UseVisualStyleBackColor = true;
//        // 
//        // labelMark
//        // 
//        this.labelMark.AutoSize = true;
//        this.labelMark.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//        this.labelMark.Location = new System.Drawing.Point(41, 18);
//        this.labelMark.Name = "labelMark";
//        this.labelMark.Size = new System.Drawing.Size(76, 20);
//        this.labelMark.TabIndex = 915;
//        this.labelMark.Text = "Mark it as:";
//        // 
//        // radioButtonPositive
//        // 
//        this.radioButtonPositive.AutoSize = true;
//        this.radioButtonPositive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//        this.radioButtonPositive.Location = new System.Drawing.Point(41, 63);
//        this.radioButtonPositive.Name = "radioButtonPositive";
//        this.radioButtonPositive.Size = new System.Drawing.Size(70, 21);
//        this.radioButtonPositive.TabIndex = 300;
//        this.radioButtonPositive.TabStop = true;
//        this.radioButtonPositive.Text = "Positive";
//        this.radioButtonPositive.UseVisualStyleBackColor = true;
//        this.radioButtonPositive.CheckedChanged += new System.EventHandler(this.radioButtonPositive_CheckedChanged);
//        // 
//        // radioButtonNegative
//        // 
//        this.radioButtonNegative.AutoSize = true;
//        this.radioButtonNegative.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//        this.radioButtonNegative.Location = new System.Drawing.Point(41, 117);
//        this.radioButtonNegative.Name = "radioButtonNegative";
//        this.radioButtonNegative.Size = new System.Drawing.Size(78, 21);
//        this.radioButtonNegative.TabIndex = 900;
//        this.radioButtonNegative.TabStop = true;
//        this.radioButtonNegative.Text = "Negative";
//        this.radioButtonNegative.UseVisualStyleBackColor = true;
//        // 
//        // radioButtonPotential
//        // 
//        this.radioButtonPotential.AutoSize = true;
//        this.radioButtonPotential.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//        this.radioButtonPotential.Location = new System.Drawing.Point(41, 90);
//        this.radioButtonPotential.Name = "radioButtonPotential";
//        this.radioButtonPotential.Size = new System.Drawing.Size(76, 21);
//        this.radioButtonPotential.TabIndex = 800;
//        this.radioButtonPotential.TabStop = true;
//        this.radioButtonPotential.Text = "Potential";
//        this.radioButtonPotential.UseVisualStyleBackColor = true;
//        // 
//        // textBox1
//        // 
//        this.textBox1.Location = new System.Drawing.Point(19, 385);
//        this.textBox1.Multiline = true;
//        this.textBox1.Name = "textBox1";
//        this.textBox1.Size = new System.Drawing.Size(227, 111);
//        this.textBox1.TabIndex = 905;
//        this.textBox1.TabStop = false;
//        // 
//        // label14
//        // 
//        this.label14.AutoSize = true;
//        this.label14.Location = new System.Drawing.Point(64, 583);
//        this.label14.Name = "label14";
//        this.label14.Size = new System.Drawing.Size(44, 15);
//        this.label14.TabIndex = 801;
//        this.label14.Text = "label14";
//        // 
//        // button1
//        // 
//        this.button1.Location = new System.Drawing.Point(19, 677);
//        this.button1.Name = "button1";
//        this.button1.Size = new System.Drawing.Size(75, 23);
//        this.button1.TabIndex = 298;
//        this.button1.Text = "Next";
//        this.button1.UseVisualStyleBackColor = true;
//        // 
//        // button2
//        // 
//        this.button2.Location = new System.Drawing.Point(156, 677);
//        this.button2.Name = "button2";
//        this.button2.Size = new System.Drawing.Size(75, 23);
//        this.button2.TabIndex = 299;
//        this.button2.Text = "Back";
//        this.button2.UseVisualStyleBackColor = true;
//        // 
//        // panel2
//        // 
//        this.panel2.Controls.Add(this.labelMark);
//        this.panel2.Controls.Add(this.radioButtonPositive);
//        this.panel2.Controls.Add(this.radioButtonNegative);
//        this.panel2.Controls.Add(this.radioButtonPotential);
//        this.panel2.Controls.Add(this.textBox1);
//        this.panel2.Controls.Add(this.label14);
//        this.panel2.Controls.Add(this.button1);
//        this.panel2.Controls.Add(this.button2);
//        this.panel2.Enabled = false;
//        this.panel2.Location = new System.Drawing.Point(19, 109);
//        this.panel2.Name = "panel2";
//        this.panel2.Size = new System.Drawing.Size(227, 153);
//        this.panel2.TabIndex = 915;
//        this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
//        // 
//        // panel1
//        // 
//        this.panel1.Controls.Add(this.labelNotes);
//        this.panel1.Controls.Add(this.panel2);
//        this.panel1.Controls.Add(this.labelDComment);
//        this.panel1.Controls.Add(this.textBoxComment);
//        this.panel1.Controls.Add(this.buttonNext);
//        this.panel1.Controls.Add(this.buttonPrevious);
//        this.panel1.Location = new System.Drawing.Point(1098, 9);
//        this.panel1.Name = "panel1";
//        this.panel1.Size = new System.Drawing.Size(258, 691);
//        this.panel1.TabIndex = 914;
//        this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
//        // 
//        // labelNotes
//        // 
//        this.labelNotes.AutoSize = true;
//        this.labelNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//        this.labelNotes.Location = new System.Drawing.Point(19, 306);
//        this.labelNotes.Name = "labelNotes";
//        this.labelNotes.Size = new System.Drawing.Size(51, 20);
//        this.labelNotes.TabIndex = 301;
//        this.labelNotes.Text = "Notes";
//        // 
//        // labelDComment
//        // 
//        this.labelDComment.AutoSize = true;
//        this.labelDComment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
//        this.labelDComment.Location = new System.Drawing.Point(20, 49);
//        this.labelDComment.Name = "labelDComment";
//        this.labelDComment.Size = new System.Drawing.Size(184, 25);
//        this.labelDComment.TabIndex = 916;
//        this.labelDComment.Text = "Doctor\'s comments";
//        // 
//        // textBoxComment
//        // 
//        this.textBoxComment.Enabled = false;
//        this.textBoxComment.Location = new System.Drawing.Point(19, 368);
//        this.textBoxComment.Multiline = true;
//        this.textBoxComment.Name = "textBoxComment";
//        this.textBoxComment.Size = new System.Drawing.Size(227, 153);
//        this.textBoxComment.TabIndex = 905;
//        this.textBoxComment.TabStop = false;
//        this.textBoxComment.Enter += new System.EventHandler(this.textBoxComment_Enter);
//        this.textBoxComment.Leave += new System.EventHandler(this.textBoxComment_Leave);
//        // 
//        // buttonNext
//        // 
//        this.buttonNext.Location = new System.Drawing.Point(136, 622);
//        this.buttonNext.Name = "buttonNext";
//        this.buttonNext.Size = new System.Drawing.Size(110, 37);
//        this.buttonNext.TabIndex = 298;
//        this.buttonNext.Text = "Next";
//        this.buttonNext.UseVisualStyleBackColor = true;
//        this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
//        // 
//        // buttonPrevious
//        // 
//        this.buttonPrevious.Location = new System.Drawing.Point(17, 622);
//        this.buttonPrevious.Name = "buttonPrevious";
//        this.buttonPrevious.Size = new System.Drawing.Size(110, 37);
//        this.buttonPrevious.TabIndex = 297;
//        this.buttonPrevious.Text = "Back";
//        this.buttonPrevious.UseVisualStyleBackColor = true;
//        this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
//        // 
//        // Form4
//        // 
//        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
//        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//        this.ClientSize = new System.Drawing.Size(1370, 724);
//        this.Controls.Add(this.panel1);
//        this.Controls.Add(this.panel4);
//        this.MaximizeBox = false;
//        this.MinimizeBox = false;
//        this.Name = "Form4";
//        this.Text = "Form4";
//        this.Load += new System.EventHandler(this.Form4_Load);
//        ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
//        this.panel4.ResumeLayout(false);
//        this.panel4.PerformLayout();
//        this.panel2.ResumeLayout(false);
//        this.panel2.PerformLayout();
//        this.panel1.ResumeLayout(false);
//        this.panel1.PerformLayout();
//        this.ResumeLayout(false);

//    }

//    #endregion

//    private Button buttonPencil;
//    private Button buttonQuestionM;
//    private Button buttonDown;
//    private Label label2;
//    private Button buttonUp;
//    private Label label1;
//    private Label label3;
//    private PictureBox pictureBox1;
//    private Panel panel4;
//    private Label labelMark;
//    private RadioButton radioButtonPositive;
//    private RadioButton radioButtonNegative;
//    private RadioButton radioButtonPotential;
//    private TextBox textBox1;
//    private Label label14;
//    private Button button1;
//    private Button button2;
//    private Panel panel2;
//    private Panel panel1;
//    private Label labelNotes;
//    private Label labelDComment;
//    private TextBox textBoxComment;
//    private Button buttonNext;
//    private Button buttonPrevious;
//    private Button buttonClean;
//}
//}