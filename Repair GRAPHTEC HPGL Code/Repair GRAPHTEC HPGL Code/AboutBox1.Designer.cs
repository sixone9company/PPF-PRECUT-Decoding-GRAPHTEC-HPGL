namespace Repair_GRAPHTEC_HPGL_Code
{
    partial class AboutBox1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.SplitButton;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 311);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(119, 19);
            label1.Name = "label1";
            label1.Size = new Size(260, 16);
            label1.TabIndex = 1;
            label1.Text = "About Enigma | Binary to HPGL Patterns";
            // 
            // button1
            // 
            button1.Location = new Point(454, 301);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 56);
            label2.Name = "label2";
            label2.Size = new Size(175, 15);
            label2.TabIndex = 3;
            label2.Text = "Version 1.0.1 GRAPHTEC - HPGL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 88);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 4;
            label3.Text = "619 Company";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 114);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 5;
            label4.Text = "Telegram:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(174, 114);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(163, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://t.me/sixone9compary";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(119, 154);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(410, 126);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // AboutBox1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 337);
            Controls.Add(richTextBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox1";
            Padding = new Padding(10);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About Progarm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private RichTextBox richTextBox1;
    }
}
