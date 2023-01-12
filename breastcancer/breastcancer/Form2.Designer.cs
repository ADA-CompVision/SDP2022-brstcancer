﻿namespace breastcancer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMark = new System.Windows.Forms.Label();
            this.radioButtonPositive = new System.Windows.Forms.RadioButton();
            this.radioButtonNegative = new System.Windows.Forms.RadioButton();
            this.radioButtonPotential = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelDComment = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelRightM = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelLeftM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonQuestionM = new System.Windows.Forms.Button();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(7, 633);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(120, 37);
            this.buttonPrevious.TabIndex = 297;
            this.buttonPrevious.Text = "Back";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(130, 633);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(120, 37);
            this.buttonNext.TabIndex = 298;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(19, 368);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(227, 153);
            this.textBoxComment.TabIndex = 905;
            this.textBoxComment.TabStop = false;
            this.textBoxComment.Enter += new System.EventHandler(this.textBoxComment_Enter);
            this.textBoxComment.Leave += new System.EventHandler(this.textBoxComment_Leave);
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNotes.Location = new System.Drawing.Point(19, 306);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(51, 20);
            this.labelNotes.TabIndex = 301;
            this.labelNotes.Text = "Notes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNotes);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelDComment);
            this.panel1.Controls.Add(this.textBoxComment);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrevious);
            this.panel1.Location = new System.Drawing.Point(1098, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 691);
            this.panel1.TabIndex = 914;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelMark);
            this.panel2.Controls.Add(this.radioButtonPositive);
            this.panel2.Controls.Add(this.radioButtonNegative);
            this.panel2.Controls.Add(this.radioButtonPotential);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(19, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 153);
            this.panel2.TabIndex = 915;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMark.Location = new System.Drawing.Point(41, 18);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(76, 20);
            this.labelMark.TabIndex = 915;
            this.labelMark.Text = "Mark it as:";
            // 
            // radioButtonPositive
            // 
            this.radioButtonPositive.AutoSize = true;
            this.radioButtonPositive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonPositive.Location = new System.Drawing.Point(41, 63);
            this.radioButtonPositive.Name = "radioButtonPositive";
            this.radioButtonPositive.Size = new System.Drawing.Size(70, 21);
            this.radioButtonPositive.TabIndex = 300;
            this.radioButtonPositive.TabStop = true;
            this.radioButtonPositive.Text = "Positive";
            this.radioButtonPositive.UseVisualStyleBackColor = true;
            this.radioButtonPositive.CheckedChanged += new System.EventHandler(this.radioButtonPositive_CheckedChanged);
            // 
            // radioButtonNegative
            // 
            this.radioButtonNegative.AutoSize = true;
            this.radioButtonNegative.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonNegative.Location = new System.Drawing.Point(41, 117);
            this.radioButtonNegative.Name = "radioButtonNegative";
            this.radioButtonNegative.Size = new System.Drawing.Size(78, 21);
            this.radioButtonNegative.TabIndex = 900;
            this.radioButtonNegative.TabStop = true;
            this.radioButtonNegative.Text = "Negative";
            this.radioButtonNegative.UseVisualStyleBackColor = true;
            this.radioButtonNegative.CheckedChanged += new System.EventHandler(this.radioButtonNegative_CheckedChanged);
            // 
            // radioButtonPotential
            // 
            this.radioButtonPotential.AutoSize = true;
            this.radioButtonPotential.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonPotential.Location = new System.Drawing.Point(41, 90);
            this.radioButtonPotential.Name = "radioButtonPotential";
            this.radioButtonPotential.Size = new System.Drawing.Size(76, 21);
            this.radioButtonPotential.TabIndex = 800;
            this.radioButtonPotential.TabStop = true;
            this.radioButtonPotential.Text = "Potential";
            this.radioButtonPotential.UseVisualStyleBackColor = true;
            this.radioButtonPotential.CheckedChanged += new System.EventHandler(this.radioButtonPotential_CheckedChanged);
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
            // labelDComment
            // 
            this.labelDComment.AutoSize = true;
            this.labelDComment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDComment.Location = new System.Drawing.Point(19, 63);
            this.labelDComment.Name = "labelDComment";
            this.labelDComment.Size = new System.Drawing.Size(184, 25);
            this.labelDComment.TabIndex = 916;
            this.labelDComment.Text = "Doctor\'s comments";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(288, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(255, 320);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 907;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            this.pictureBox2.DoubleClick += new System.EventHandler(this.pictureBox2_DoubleClick);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(832, 127);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(255, 320);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 904;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox4_Paint);
            this.pictureBox4.DoubleClick += new System.EventHandler(this.pictureBox4_DoubleClick);
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseMove);
            this.pictureBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseUp);
            // 
            // labelRightM
            // 
            this.labelRightM.AutoSize = true;
            this.labelRightM.Location = new System.Drawing.Point(561, 461);
            this.labelRightM.Name = "labelRightM";
            this.labelRightM.Size = new System.Drawing.Size(106, 15);
            this.labelRightM.TabIndex = 910;
            this.labelRightM.Text = "Right Projection M";
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Location = new System.Drawing.Point(288, 461);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(84, 15);
            this.labelLeft.TabIndex = 909;
            this.labelLeft.Text = "Left Projection";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(561, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(255, 320);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 902;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            this.pictureBox3.DoubleClick += new System.EventHandler(this.pictureBox3_DoubleClick);
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRight.Location = new System.Drawing.Point(18, 461);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(92, 15);
            this.labelRight.TabIndex = 908;
            this.labelRight.Text = "Right Projection";
            // 
            // labelLeftM
            // 
            this.labelLeftM.AutoSize = true;
            this.labelLeftM.Location = new System.Drawing.Point(832, 461);
            this.labelLeftM.Name = "labelLeftM";
            this.labelLeftM.Size = new System.Drawing.Size(98, 15);
            this.labelLeftM.TabIndex = 916;
            this.labelLeftM.Text = "Left Projection M";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 661);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 801;
            this.label1.Text = "label1";
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(958, 631);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(44, 44);
            this.buttonUp.TabIndex = 302;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 615);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 918;
            this.label2.Text = "label2";
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(1008, 632);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(44, 44);
            this.buttonDown.TabIndex = 801;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonQuestionM
            // 
            this.buttonQuestionM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonQuestionM.BackgroundImage")));
            this.buttonQuestionM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonQuestionM.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonQuestionM.Location = new System.Drawing.Point(11, 633);
            this.buttonQuestionM.Name = "buttonQuestionM";
            this.buttonQuestionM.Size = new System.Drawing.Size(44, 44);
            this.buttonQuestionM.TabIndex = 921;
            this.buttonQuestionM.UseVisualStyleBackColor = true;
            // 
            // buttonPencil
            // 
            this.buttonPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPencil.BackgroundImage")));
            this.buttonPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPencil.Location = new System.Drawing.Point(908, 631);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(44, 44);
            this.buttonPencil.TabIndex = 921;
            this.buttonPencil.UseVisualStyleBackColor = true;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(18, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.buttonPencil);
            this.panel4.Controls.Add(this.buttonQuestionM);
            this.panel4.Controls.Add(this.buttonDown);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.buttonUp);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.labelLeftM);
            this.panel4.Controls.Add(this.labelRight);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.labelLeft);
            this.panel4.Controls.Add(this.labelRightM);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(2, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1090, 690);
            this.panel4.TabIndex = 920;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1360, 711);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mammograms";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonPrevious;
        private Button buttonNext;
        private TextBox textBoxComment;
        private Label labelNotes;
        private Panel panel1;
        private Panel panel2;
        private Label labelMark;
        private RadioButton radioButtonPositive;
        private RadioButton radioButtonNegative;
        private RadioButton radioButtonPotential;
        private TextBox textBox1;
        private Label label14;
        private Button button1;
        private Button button2;
        private Label labelDComment;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label labelRightM;
        private Label labelLeft;
        private PictureBox pictureBox3;
        private Label labelRight;
        private Label labelLeftM;
        private Label label1;
        private Button buttonUp;
        private Label label2;
        private Button buttonDown;
        private Button buttonQuestionM;
        private Button buttonPencil;
        private PictureBox pictureBox1;
        private Panel panel4;
    }
}