namespace PROJE1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class AcilisEkran : Form
    {
        public AcilisEkran()
        {
            InitializeComponent();
        }

        bool islem = false;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!islem)
            {
                this.Opacity += 0.010;
            }
            if (this.Opacity == 1.0)
            {
                islem = true;
            }
            if (islem)
            {
                this.Opacity -= 0.010;
            }

            if (this.Opacity == 0)
            {
                Form3 giris = new Form3();
                giris.Show();
                timer1.Enabled = false;
                this.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
