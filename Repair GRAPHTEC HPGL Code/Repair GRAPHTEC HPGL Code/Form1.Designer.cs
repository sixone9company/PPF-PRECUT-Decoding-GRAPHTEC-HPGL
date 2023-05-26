namespace Repair_GRAPHTEC_HPGL_Code
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(595, 206);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 232);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(595, 206);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 114);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Input:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 321);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Output:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(681, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(167, 229);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options";
            // 
            // button3
            // 
            button3.Location = new Point(6, 114);
            button3.Name = "button3";
            button3.Size = new Size(155, 23);
            button3.TabIndex = 7;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 76);
            button2.Name = "button2";
            button2.Size = new Size(155, 23);
            button2.TabIndex = 6;
            button2.Text = "Convert PLT File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 36);
            button1.Name = "button1";
            button1.Size = new Size(155, 23);
            button1.TabIndex = 5;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(681, 415);
            button4.Name = "button4";
            button4.Size = new Size(167, 23);
            button4.TabIndex = 5;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(720, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 87);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(719, 130);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(89, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Abuot Progarm";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(688, 111);
            label3.Name = "label3";
            label3.Size = new Size(154, 15);
            label3.TabIndex = 8;
            label3.Text = "Version: GRAPHTEC - HPGL ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 450);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enigma By SIXONE9 | Binary to HPGL Patterns";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private Label label3;
    }
}