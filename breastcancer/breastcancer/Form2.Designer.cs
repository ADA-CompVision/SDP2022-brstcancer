namespace breastcancer
{
    partial class Form2
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
            buttonPrevious = new Button();
            buttonNext = new Button();
            labelNotes = new Label();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            labelMark = new Label();
            radioButtonPositive = new RadioButton();
            radioButtonNegative = new RadioButton();
            radioButtonPotential = new RadioButton();
            textBox1 = new TextBox();
            label14 = new Label();
            button1 = new Button();
            button2 = new Button();
            labelDComment = new Label();
            textBoxComment = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel4 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            buttonPencil = new Button();
            buttonClean = new Button();
            label2 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            labelMa = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            lbl_rp_prediction = new Label();
            labelRight = new Label();
            lbl_lpm_prediction = new Label();
            pictureBox3 = new PictureBox();
            lbl_lp_prediction = new Label();
            pictureBox4 = new PictureBox();
            labelLeft = new Label();
            lbl_rpm_prediction = new Label();
            pictureBox1 = new PictureBox();
            labelLeftM = new Label();
            labelRightM = new Label();
            pictureBox2 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonQuestionM = new Button();
            buttonDown = new Button();
            buttonUp = new Button();
            label1 = new Label();
            buttonTest = new Button();
            lbl_patient = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonPrevious
            // 
            buttonPrevious.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonPrevious.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPrevious.Location = new Point(3, 6);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(111, 37);
            buttonPrevious.TabIndex = 297;
            buttonPrevious.Text = "Back";
            buttonPrevious.UseVisualStyleBackColor = true;
            buttonPrevious.EnabledChanged += buttonPrevious_EnabledChanged;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // buttonNext
            // 
            buttonNext.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonNext.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNext.Location = new Point(120, 6);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(112, 37);
            buttonNext.TabIndex = 298;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // labelNotes
            // 
            labelNotes.Anchor = AnchorStyles.Left;
            labelNotes.AutoSize = true;
            labelNotes.Font = new Font("Bookman Old Style", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNotes.Location = new Point(3, 222);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(65, 22);
            labelNotes.TabIndex = 301;
            labelNotes.Text = "Notes";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(1042, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 702);
            panel1.TabIndex = 914;
            panel1.Paint += panel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonPrevious, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonNext, 1, 0);
            tableLayoutPanel2.Location = new Point(16, 615);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(235, 49);
            tableLayoutPanel2.TabIndex = 918;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(labelDComment, 0, 0);
            tableLayoutPanel1.Controls.Add(labelNotes, 0, 2);
            tableLayoutPanel1.Controls.Add(textBoxComment, 0, 3);
            tableLayoutPanel1.Location = new Point(16, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.27184F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75.72816F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            tableLayoutPanel1.Size = new Size(235, 459);
            tableLayoutPanel1.TabIndex = 917;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(labelMark);
            panel2.Controls.Add(radioButtonPositive);
            panel2.Controls.Add(radioButtonNegative);
            panel2.Controls.Add(radioButtonPotential);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(229, 153);
            panel2.TabIndex = 915;
            panel2.Paint += panel2_Paint;
            // 
            // labelMark
            // 
            labelMark.AutoSize = true;
            labelMark.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelMark.Location = new Point(10, 15);
            labelMark.Name = "labelMark";
            labelMark.Size = new Size(90, 19);
            labelMark.TabIndex = 915;
            labelMark.Text = "Mark it as:";
            // 
            // radioButtonPositive
            // 
            radioButtonPositive.AutoSize = true;
            radioButtonPositive.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonPositive.Location = new Point(10, 52);
            radioButtonPositive.Name = "radioButtonPositive";
            radioButtonPositive.Size = new Size(84, 23);
            radioButtonPositive.TabIndex = 300;
            radioButtonPositive.TabStop = true;
            radioButtonPositive.Text = "Positive";
            radioButtonPositive.UseVisualStyleBackColor = true;
            radioButtonPositive.CheckedChanged += radioButtonPositive_CheckedChanged;
            // 
            // radioButtonNegative
            // 
            radioButtonNegative.AutoSize = true;
            radioButtonNegative.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonNegative.Location = new Point(10, 106);
            radioButtonNegative.Name = "radioButtonNegative";
            radioButtonNegative.Size = new Size(91, 23);
            radioButtonNegative.TabIndex = 900;
            radioButtonNegative.TabStop = true;
            radioButtonNegative.Text = "Negative";
            radioButtonNegative.UseVisualStyleBackColor = true;
            radioButtonNegative.CheckedChanged += radioButtonNegative_CheckedChanged;
            // 
            // radioButtonPotential
            // 
            radioButtonPotential.AutoSize = true;
            radioButtonPotential.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonPotential.Location = new Point(10, 79);
            radioButtonPotential.Name = "radioButtonPotential";
            radioButtonPotential.Size = new Size(94, 23);
            radioButtonPotential.TabIndex = 800;
            radioButtonPotential.TabStop = true;
            radioButtonPotential.Text = "Potential";
            radioButtonPotential.UseVisualStyleBackColor = true;
            radioButtonPotential.CheckedChanged += radioButtonPotential_CheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 385);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 111);
            textBox1.TabIndex = 905;
            textBox1.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(64, 583);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 801;
            label14.Text = "label14";
            // 
            // button1
            // 
            button1.Location = new Point(19, 677);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 298;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(156, 677);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 299;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // labelDComment
            // 
            labelDComment.AutoSize = true;
            labelDComment.Font = new Font("Bookman Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDComment.Location = new Point(3, 0);
            labelDComment.Name = "labelDComment";
            labelDComment.Size = new Size(221, 24);
            labelDComment.TabIndex = 916;
            labelDComment.Text = "Doctor's comments";
            // 
            // textBoxComment
            // 
            textBoxComment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxComment.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxComment.Location = new Point(3, 261);
            textBoxComment.Multiline = true;
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(229, 195);
            textBoxComment.TabIndex = 905;
            textBoxComment.TabStop = false;
            textBoxComment.Enter += textBoxComment_Enter;
            textBoxComment.Leave += textBoxComment_Leave;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.AutoSize = true;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.74105F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.25895F));
            tableLayoutPanel6.Controls.Add(panel4, 0, 0);
            tableLayoutPanel6.Controls.Add(panel1, 1, 0);
            tableLayoutPanel6.Location = new Point(0, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1304, 708);
            tableLayoutPanel6.TabIndex = 932;
            tableLayoutPanel6.Paint += tableLayoutPanel6_Paint;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.BackColor = SystemColors.ButtonFace;
            panel4.Controls.Add(tableLayoutPanel7);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(tableLayoutPanel5);
            panel4.Controls.Add(tableLayoutPanel4);
            panel4.Controls.Add(tableLayoutPanel3);
            panel4.Controls.Add(lbl_patient);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1033, 702);
            panel4.TabIndex = 920;
            panel4.Paint += panel4_Paint;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(buttonPencil, 0, 0);
            tableLayoutPanel7.Controls.Add(buttonClean, 1, 0);
            tableLayoutPanel7.Location = new Point(899, 46);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(131, 71);
            tableLayoutPanel7.TabIndex = 933;
            // 
            // buttonPencil
            // 
            buttonPencil.Anchor = AnchorStyles.None;
            buttonPencil.BackgroundImage = Properties.Resources.pencil;
            buttonPencil.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPencil.Location = new Point(7, 11);
            buttonPencil.Name = "buttonPencil";
            buttonPencil.Size = new Size(50, 48);
            buttonPencil.TabIndex = 921;
            buttonPencil.UseVisualStyleBackColor = true;
            buttonPencil.Click += buttonPencil_Click;
            buttonPencil.Paint += buttonPencil_Paint;
            // 
            // buttonClean
            // 
            buttonClean.Anchor = AnchorStyles.None;
            buttonClean.BackgroundImage = Properties.Resources.eraser;
            buttonClean.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClean.Location = new Point(73, 11);
            buttonClean.Name = "buttonClean";
            buttonClean.Size = new Size(50, 48);
            buttonClean.TabIndex = 928;
            buttonClean.UseVisualStyleBackColor = true;
            buttonClean.Click += buttonClean_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 609);
            label2.Name = "label2";
            label2.Size = new Size(54, 19);
            label2.TabIndex = 918;
            label2.Text = "label2";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tableLayoutPanel5.Controls.Add(labelMa, 0, 0);
            tableLayoutPanel5.Location = new Point(23, 40);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(317, 36);
            tableLayoutPanel5.TabIndex = 932;
            // 
            // labelMa
            // 
            labelMa.AutoSize = true;
            labelMa.Font = new Font("Bookman Old Style", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMa.Location = new Point(3, 0);
            labelMa.Name = "labelMa";
            labelMa.Size = new Size(161, 24);
            labelMa.TabIndex = 922;
            labelMa.Text = "Mammograms";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(lbl_rp_prediction, 0, 2);
            tableLayoutPanel4.Controls.Add(labelRight, 0, 1);
            tableLayoutPanel4.Controls.Add(lbl_lpm_prediction, 3, 2);
            tableLayoutPanel4.Controls.Add(pictureBox3, 2, 0);
            tableLayoutPanel4.Controls.Add(lbl_lp_prediction, 1, 2);
            tableLayoutPanel4.Controls.Add(pictureBox4, 3, 0);
            tableLayoutPanel4.Controls.Add(labelLeft, 1, 1);
            tableLayoutPanel4.Controls.Add(lbl_rpm_prediction, 2, 2);
            tableLayoutPanel4.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel4.Controls.Add(labelLeftM, 3, 1);
            tableLayoutPanel4.Controls.Add(labelRightM, 2, 1);
            tableLayoutPanel4.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel4.Location = new Point(17, 120);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 93.20113F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 6.798867F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 44.49F));
            tableLayoutPanel4.Size = new Size(1032, 395);
            tableLayoutPanel4.TabIndex = 931;
            // 
            // lbl_rp_prediction
            // 
            lbl_rp_prediction.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_rp_prediction.AutoSize = true;
            lbl_rp_prediction.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_rp_prediction.Location = new Point(3, 363);
            lbl_rp_prediction.Name = "lbl_rp_prediction";
            lbl_rp_prediction.Size = new Size(252, 19);
            lbl_rp_prediction.TabIndex = 923;
            lbl_rp_prediction.Text = "Prediction:";
            // 
            // labelRight
            // 
            labelRight.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelRight.AutoSize = true;
            labelRight.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelRight.Location = new Point(3, 329);
            labelRight.Name = "labelRight";
            labelRight.Size = new Size(252, 19);
            labelRight.TabIndex = 908;
            labelRight.Text = "Right Projection";
            // 
            // lbl_lpm_prediction
            // 
            lbl_lpm_prediction.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_lpm_prediction.AutoSize = true;
            lbl_lpm_prediction.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_lpm_prediction.Location = new Point(777, 363);
            lbl_lpm_prediction.Name = "lbl_lpm_prediction";
            lbl_lpm_prediction.Size = new Size(252, 19);
            lbl_lpm_prediction.TabIndex = 926;
            lbl_lpm_prediction.Text = "Prediction: ";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.BackColor = SystemColors.ActiveCaptionText;
            pictureBox3.Location = new Point(521, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(247, 320);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 902;
            pictureBox3.TabStop = false;
            pictureBox3.Paint += pictureBox3_Paint;
            pictureBox3.DoubleClick += pictureBox3_DoubleClick;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            pictureBox3.MouseMove += pictureBox3_MouseMove;
            pictureBox3.MouseUp += pictureBox3_MouseUp;
            // 
            // lbl_lp_prediction
            // 
            lbl_lp_prediction.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_lp_prediction.AutoSize = true;
            lbl_lp_prediction.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_lp_prediction.Location = new Point(261, 363);
            lbl_lp_prediction.Name = "lbl_lp_prediction";
            lbl_lp_prediction.Size = new Size(252, 19);
            lbl_lp_prediction.TabIndex = 924;
            lbl_lp_prediction.Text = "Prediction:";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top;
            pictureBox4.BackColor = SystemColors.ActiveCaptionText;
            pictureBox4.Location = new Point(779, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(248, 320);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 904;
            pictureBox4.TabStop = false;
            pictureBox4.Paint += pictureBox4_Paint;
            pictureBox4.DoubleClick += pictureBox4_DoubleClick;
            pictureBox4.MouseDown += pictureBox4_MouseDown;
            pictureBox4.MouseMove += pictureBox4_MouseMove;
            pictureBox4.MouseUp += pictureBox4_MouseUp;
            // 
            // labelLeft
            // 
            labelLeft.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelLeft.AutoSize = true;
            labelLeft.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelLeft.Location = new Point(261, 329);
            labelLeft.Name = "labelLeft";
            labelLeft.Size = new Size(252, 19);
            labelLeft.TabIndex = 909;
            labelLeft.Text = "Left Projection";
            // 
            // lbl_rpm_prediction
            // 
            lbl_rpm_prediction.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbl_rpm_prediction.AutoSize = true;
            lbl_rpm_prediction.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_rpm_prediction.Location = new Point(519, 363);
            lbl_rpm_prediction.Name = "lbl_rpm_prediction";
            lbl_rpm_prediction.Size = new Size(252, 19);
            lbl_rpm_prediction.TabIndex = 925;
            lbl_rpm_prediction.Text = "Prediction: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(263, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // labelLeftM
            // 
            labelLeftM.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelLeftM.AutoSize = true;
            labelLeftM.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelLeftM.Location = new Point(777, 329);
            labelLeftM.Name = "labelLeftM";
            labelLeftM.Size = new Size(252, 19);
            labelLeftM.TabIndex = 916;
            labelLeftM.Text = "Left Projection M";
            // 
            // labelRightM
            // 
            labelRightM.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelRightM.AutoSize = true;
            labelRightM.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelRightM.Location = new Point(519, 329);
            labelRightM.Name = "labelRightM";
            labelRightM.Size = new Size(252, 19);
            labelRightM.TabIndex = 910;
            labelRightM.Text = "Right Projection M";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.Location = new Point(5, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 320);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 907;
            pictureBox2.TabStop = false;
            pictureBox2.Paint += pictureBox2_Paint;
            pictureBox2.DoubleClick += pictureBox2_DoubleClick;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            pictureBox2.MouseMove += pictureBox2_MouseMove;
            pictureBox2.MouseUp += pictureBox2_MouseUp;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Left;
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.44695F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.68848F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.86456F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            tableLayoutPanel3.Controls.Add(buttonQuestionM, 0, 0);
            tableLayoutPanel3.Controls.Add(buttonDown, 4, 0);
            tableLayoutPanel3.Controls.Add(buttonUp, 3, 0);
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Controls.Add(buttonTest, 2, 0);
            tableLayoutPanel3.Location = new Point(9, 621);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1024, 71);
            tableLayoutPanel3.TabIndex = 930;
            // 
            // buttonQuestionM
            // 
            buttonQuestionM.Anchor = AnchorStyles.Left;
            buttonQuestionM.BackgroundImage = Properties.Resources.ques;
            buttonQuestionM.BackgroundImageLayout = ImageLayout.Zoom;
            buttonQuestionM.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonQuestionM.Location = new Point(3, 10);
            buttonQuestionM.Name = "buttonQuestionM";
            buttonQuestionM.Size = new Size(50, 50);
            buttonQuestionM.TabIndex = 921;
            buttonQuestionM.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            buttonDown.Anchor = AnchorStyles.Right;
            buttonDown.BackgroundImage = Properties.Resources.down11;
            buttonDown.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDown.Location = new Point(971, 10);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(50, 50);
            buttonDown.TabIndex = 801;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += buttonDown_Click;
            // 
            // buttonUp
            // 
            buttonUp.Anchor = AnchorStyles.Right;
            buttonUp.BackgroundImage = Properties.Resources.up11;
            buttonUp.BackgroundImageLayout = ImageLayout.Zoom;
            buttonUp.Location = new Point(906, 10);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(50, 50);
            buttonUp.TabIndex = 302;
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUp_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(396, 26);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 801;
            label1.Text = "label1";
            // 
            // buttonTest
            // 
            buttonTest.Anchor = AnchorStyles.Right;
            buttonTest.BackgroundImage = Properties.Resources.predict1;
            buttonTest.BackgroundImageLayout = ImageLayout.Zoom;
            buttonTest.Location = new Point(764, 7);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(129, 57);
            buttonTest.TabIndex = 929;
            buttonTest.Text = "Predict";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // lbl_patient
            // 
            lbl_patient.Anchor = AnchorStyles.Right;
            lbl_patient.AutoSize = true;
            lbl_patient.Font = new Font("Bookman Old Style", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_patient.Location = new Point(773, 583);
            lbl_patient.Name = "lbl_patient";
            lbl_patient.Size = new Size(73, 19);
            lbl_patient.TabIndex = 927;
            lbl_patient.Text = "Patient: ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1305, 713);
            Controls.Add(tableLayoutPanel6);
            MinimumSize = new Size(1278, 678);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mammograms";
            WindowState = FormWindowState.Maximized;
            Activated += Form2_Activated;
            FormClosing += Form2_FormClosing;
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            KeyUp += Form2_KeyUp;
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lbl_lpm_prediction;
        private PictureBox pictureBox2;
        private Label label1;
        private Label lbl_rpm_prediction;
        private Button buttonQuestionM;
        private Button buttonClean;
        private Label lbl_lp_prediction;
        private Label lbl_patient;
        private Label lbl_rp_prediction;
        private Label labelRight;
        private Label labelLeftM;
        private Label labelRightM;
        private Label labelLeft;
        private Button buttonPencil;
        private PictureBox pictureBox3;
        private Label labelMa;
        private Label label2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonTest;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel7;
    }
}