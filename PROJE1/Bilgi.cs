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
    using System.Management;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using System.Collections;
    using System.Net;
    using System.Text.RegularExpressions;
    using System.IO;
    using System.Net.NetworkInformation;
    using System.Reflection;
    using Microsoft.Win32;

    public partial class Bilgi : Form
    {
        public Bilgi()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            GetGraphicsCardModel();
        }

        private void GetGraphicsCardModel()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject obj in collection)
                {
                    string graphicsCardModel = obj["Caption"].ToString();
                    label5.Text = graphicsCardModel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }



        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.label3.Text = this.label3.Text;
                this.Close();
            form2.Visible = Enabled;
        }
        private string GetPublicIpAddress()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    // WebClient'ı kullanarak bir hizmetten genel IP adresini al
                    string publicIp = client.DownloadString("https://api64.ipify.org"); // ipify ücretsiz bir hizmettir
                    return publicIp;
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Web Hatası: " + ex.Message);
                return "Bilinmeyen Genel IP Adresi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return "Bilinmeyen Genel IP Adresi";
            }
        }
            private void Bilgi_Load(object sender, EventArgs e)
        {
            try
            {
                string publicIp = GetPublicIpAddress();
                label8.Text = $"{publicIp}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }


            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

            ManagementObjectCollection collection = searcher.Get();

            try
            {


                foreach (ManagementObject obj in collection)
                {
                    label6.Text = $"{obj["Name"]}";
                    break; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }


        }
        string Modem()
        {
            var webClient = new WebClient();
            string dnsString = webClient.DownloadString("http://checkip.dyndns.org");
            dnsString = (new Regex(@"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b")).Match(dnsString).Value;
            webClient.Dispose();
            return dnsString;
        }

    }
}
