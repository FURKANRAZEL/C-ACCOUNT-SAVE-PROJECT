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
    using MySql.Data.MySqlClient;
    using System.Runtime.InteropServices;
    using System.Data.OleDb;

    public partial class Form3 : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.MouseDown += new MouseEventHandler(panel1_MouseDown);

            CreateRoundRegion();
        }

        OleDbCommand komut;
        OleDbDataAdapter da;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:/test.accdb");
        private void CreateRoundRegion()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

                // panel1'i öne getir
                panel1.BringToFront();
            }
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

                // Sadece PictureBox'u öne getir, diğer bileşenlere dokunma
                pictureBox1.BringToFront();
            }
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
  (
      int nLeftRect,
      int nTopRect,
      int nRightRect,
      int nBottomRect,
      int nWidthEllipse,
      int nHeightEllipse
  );








        private void Form3_Load(object sender, EventArgs e)
        {
            test.CharacterCasing = CharacterCasing.Upper;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();

            OleDbCommand com = new OleDbCommand("SELECT * FROM TblTest where kad='" + test.Text + "' AND pass='" + textBox2.Text + "'");
            com.Connection = conn;
            OleDbDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                conn.Close();

                com = new OleDbCommand("SELECT * FROM TblTest where kad='" + test.Text + "' AND adminmi='evet'");
                com.Connection = conn;
                conn.Open();
                reader = com.ExecuteReader();
                if (reader.Read())
                {
                    Form2 form2 = new Form2();
                    Bilgi bilgi = new Bilgi();
                    form2.label3.Text = test.Text;
                    form2.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Yönetici Değilsiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }





            }
            else
            {
                MessageBox.Show("BASARISIZ");
            }

            conn.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

                panel1.BringToFront();

        }
    }
}
