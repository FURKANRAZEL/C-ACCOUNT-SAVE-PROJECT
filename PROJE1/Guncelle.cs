namespace PROJE1
{
    using MySql.Data.MySqlClient;
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
    using System.Data.OleDb;

    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }
        OleDbCommand komut;
        OleDbDataAdapter da;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=C:/test.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Visible = true;
            this.Visible = false;
        }

        private void Guncelle_Load(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //this.textBox1.Text = form2.textBox2.Text;
            //this.textBox2.Text = form2.textBox3.Text;
            //MessageBox.Show(this.textBox1.Text + "  " + this.textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
                conn.Open();
                
                if (textBox3.Text.ToString() == "1")
                {
                    MessageBox.Show("SİSTEM HESABI DEĞİŞTİRİLEMEZ", "SİSTEM HESABI SILINEMEZ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    int a, b;
                OleDbCommand sa = new OleDbCommand("UPDATE TblTest SET KAD = @newKad, pass = @newPass WHERE id = @filterId", conn);

                sa.Parameters.AddWithValue("@newKad", textBox1.Text);
                sa.Parameters.AddWithValue("@newPass", textBox2.Text);
                sa.Parameters.AddWithValue("@filterId", Convert.ToUInt16(textBox3.Text));
                sa.ExecuteNonQuery();
                MessageBox.Show("Değiştirildi");
                   
                }
            conn.Close();


        }
    }
}
