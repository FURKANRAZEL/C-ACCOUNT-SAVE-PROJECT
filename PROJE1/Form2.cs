using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Resultset;
using MySqlX.XDevAPI.Relational;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using System.Management;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace PROJE1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            yenile();
        }

        OleDbCommand komut;
        OleDbDataAdapter da;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:/test.accdb");

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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        public void yenile()
        {


            conn.Open();

            OleDbCommand com = new OleDbCommand("SELECT id, KAD, pass,adminmi,nehesabi FROM TblTest");
            com.Connection = conn;
            OleDbDataAdapter adapter = new OleDbDataAdapter(com);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = 139;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = 15;
            }
            conn.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            yenile();
            labelyenile();
            dataGridView1.ColumnHeadersVisible = false;
            Form3 form3 = new Form3();

            this.textBox1.Text = form3.test.Text;

        }
        public void labelyenile()
        {
            int cevap = dataGridView1.Rows.Count - 1;
            label2.Text = "ADMIN SAYISI " + cevap;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            conn.Open();

            OleDbCommand com = new OleDbCommand("SELECT * FROM TblTest WHERE kad = '" + textBox1.Text + "'");
            com.Connection = conn;
            OleDbDataAdapter adapter = new OleDbDataAdapter(com);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            conn.Open();
            int a = Convert.ToInt32(this.textBox4.Text);
            if (a == 0)
            {
                MessageBox.Show("HATA", "SILMEK ICIN SECIN", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            else
            {
                if (a == 1)
                {
                    MessageBox.Show("SİSTEM HESABI SİLİNEMEZ", "SİSTEM HESABI SILINEMEZ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    OleDbCommand com = new OleDbCommand("DELETE FROM TblTest WHERE id = @Id");
                    com.Parameters.AddWithValue("@Id", textBox4.Text);
                    com.Connection = conn;
                    com.ExecuteNonQuery();

                    conn.Close();
                    yenile();
                    labelyenile();
                    MessageBox.Show("Kayıt silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }




        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminekle adminekle = new adminekle();
            adminekle.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            yenile();
            labelyenile();
        }

        private void button6_Click(object sender, EventArgs e)
        {


            conn.Open();
            OleDbCommand com = new OleDbCommand("SET @autoid :=0;UPDATE test SET ID = @autoid := (@autoid + 1);ALTER TABLE test AUTO_INCREMENT = 1;");
            com.Parameters.AddWithValue("@autoid", "@autoid");
            com.Connection = conn;
            com.ExecuteNonQuery();

            conn.Close();
            yenile();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(this.textBox4.Text);
            if (a != 0)
            {
                Guncelle guncelle = new Guncelle();
                guncelle.textBox1.Text = textBox2.Text;
                guncelle.textBox2.Text = textBox3.Text;
                guncelle.textBox3.Text = textBox4.Text;
                this.Visible = false;
                guncelle.ShowDialog();
            }
            else
            {
                MessageBox.Show("GUNCELLEMEK ICIN SECIN", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                Random rastgele = new Random();
                string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz";
                string kad = "";
                string pass = "";
                for (int a = 0; a < 6; a++)
                {
                    kad += harfler[rastgele.Next(harfler.Length)];
                }
                for (int a = 0; a < 6; a++)
                {
                    pass += harfler[rastgele.Next(harfler.Length)];
                }


                conn.Open();
                string sorgu = "Insert into TblTest (kad,pass) values ('" + kad + "','" + pass + "')";
                OleDbCommand cmd = new OleDbCommand(sorgu);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();

                conn.Close();
                yenile();
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bilgi bilgi = new Bilgi();
            bilgi.label3.Text = this.label3.Text;
            bilgi.Show();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
