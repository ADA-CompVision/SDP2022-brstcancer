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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonPositive = new System.Windows.Forms.RadioButton();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonPotential = new System.Windows.Forms.RadioButton();
            this.radioButtonNegative = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(113, 386);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // radioButtonPositive
            // 
            this.radioButtonPositive.AutoSize = true;
            this.radioButtonPositive.Location = new System.Drawing.Point(1069, 176);
            this.radioButtonPositive.Name = "radioButtonPositive";
            this.radioButtonPositive.Size = new System.Drawing.Size(66, 19);
            this.radioButtonPositive.TabIndex = 300;
            this.radioButtonPositive.TabStop = true;
            this.radioButtonPositive.Text = "Positive";
            this.radioButtonPositive.UseVisualStyleBackColor = true;
            this.radioButtonPositive.CheckedChanged += new System.EventHandler(this.radioButtonPositive_CheckedChanged_1);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(1074, 549);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 299;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(1175, 549);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 298;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1149, 630);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 801;
            this.label1.Text = "label1";
            // 
            // radioButtonPotential
            // 
            this.radioButtonPotential.AutoSize = true;
            this.radioButtonPotential.Location = new System.Drawing.Point(1069, 225);
            this.radioButtonPotential.Name = "radioButtonPotential";
            this.radioButtonPotential.Size = new System.Drawing.Size(72, 19);
            this.radioButtonPotential.TabIndex = 800;
            this.radioButtonPotential.TabStop = true;
            this.radioButtonPotential.Text = "Potential";
            this.radioButtonPotential.UseVisualStyleBackColor = true;
            this.radioButtonPotential.CheckedChanged += new System.EventHandler(this.radioButtonPotential_CheckedChanged);
            // 
            // radioButtonNegative
            // 
            this.radioButtonNegative.AutoSize = true;
            this.radioButtonNegative.Location = new System.Drawing.Point(1069, 267);
            this.radioButtonNegative.Name = "radioButtonNegative";
            this.radioButtonNegative.Size = new System.Drawing.Size(72, 19);
            this.radioButtonNegative.TabIndex = 900;
            this.radioButtonNegative.TabStop = true;
            this.radioButtonNegative.Text = "Negative";
            this.radioButtonNegative.UseVisualStyleBackColor = true;
            this.radioButtonNegative.CheckedChanged += new System.EventHandler(this.radioButtonNegative_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(113, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(280, 352);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 902;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            this.pictureBox3.DoubleClick += new System.EventHandler(this.pictureBox3_DoubleClick);
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(412, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(280, 351);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 904;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.DoubleClick += new System.EventHandler(this.pictureBox4_DoubleClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(708, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(280, 351);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 903;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.DoubleClick += new System.EventHandler(this.pictureBox5_DoubleClick);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(1044, 398);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(227, 111);
            this.textBoxComment.TabIndex = 905;
            this.textBoxComment.TabStop = false;
            this.textBoxComment.TextChanged += new System.EventHandler(this.textBoxComment_TextChanged);
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(12, 344);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(50, 47);
            this.buttonDown.TabIndex = 801;
            this.buttonDown.Text = "Down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(12, 161);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(50, 48);
            this.buttonUp.TabIndex = 302;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1065, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 301;
            this.label2.Text = "Add comment";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(412, 386);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 351);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 907;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(708, 386);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(280, 351);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 906;
            this.pictureBox6.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.radioButtonNegative);
            this.Controls.Add(this.radioButtonPotential);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.radioButtonPositive);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private RadioButton radioButtonPositive;
        private Button buttonPrevious;
        private Button buttonNext;
        private Label label1;
        private RadioButton radioButtonPotential;
        private RadioButton radioButtonNegative;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private TextBox textBoxComment;
        private Button buttonDown;
        private Button buttonUp;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
    }
}