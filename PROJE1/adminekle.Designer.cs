namespace PROJE1
{
    partial class adminekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminekle));
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 52);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(132, 18);
            label1.TabIndex = 2;
            label1.Text = "ADMIN PANEL";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(223, 6);
            button1.Name = "button1";
            button1.Size = new Size(51, 43);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(61, 368);
            button3.Name = "button3";
            button3.Size = new Size(160, 32);
            button3.TabIndex = 9;
            button3.Text = "EKLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.ForeColor = SystemColors.Menu;
            textBox1.Location = new Point(48, 229);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 28);
            textBox1.TabIndex = 8;
            textBox1.Text = "KULLANICI ADI";
            textBox1.MouseClick += textBox1_MouseClick;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaptionText;
            textBox2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox2.ForeColor = SystemColors.Menu;
            textBox2.Location = new Point(48, 277);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(186, 28);
            textBox2.TabIndex = 10;
            textBox2.Text = "SIFRE";
            textBox2.MouseClick += textBox2_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(76, 192);
            label2.Name = "label2";
            label2.Size = new Size(130, 18);
            label2.TabIndex = 2;
            label2.Text = "Hesap Kaydet";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaptionText;
            textBox3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox3.ForeColor = SystemColors.Menu;
            textBox3.Location = new Point(48, 323);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(186, 28);
            textBox3.TabIndex = 12;
            textBox3.Text = "NE HESABI?";
            textBox3.MouseClick += textBox3_MouseClick;
            // 
            // adminekle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(278, 450);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminekle";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminekle";
            Load += adminekle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox3;
    }
}