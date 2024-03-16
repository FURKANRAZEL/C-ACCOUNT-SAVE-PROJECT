namespace PROJE1
{
    partial class Bilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bilgi));
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(121, 18);
            label2.TabIndex = 3;
            label2.Text = "AYRINTILAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 116);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(57, 75);
            label1.Name = "label1";
            label1.Size = new Size(142, 18);
            label1.TabIndex = 4;
            label1.Text = "HESAP BILGISI";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(522, -4);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(46, 44);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(230, 300);
            label8.Name = "label8";
            label8.Size = new Size(53, 19);
            label8.TabIndex = 14;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(324, 75);
            label7.Name = "label7";
            label7.Size = new Size(151, 18);
            label7.TabIndex = 7;
            label7.Text = "SISTEM BILGISI";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Location = new Point(324, 116);
            label6.Name = "label6";
            label6.Size = new Size(202, 19);
            label6.TabIndex = 8;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(313, 150);
            label5.Name = "label5";
            label5.Size = new Size(202, 19);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Bilgi
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(567, 328);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Bilgi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bilgi";
            Load += Bilgi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button2;
        public Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}