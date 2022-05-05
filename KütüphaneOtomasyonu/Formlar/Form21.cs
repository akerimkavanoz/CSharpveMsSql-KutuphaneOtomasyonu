using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KütüphaneOtomasyonu
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        public int girisID;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();
        Form7 fr7 = new Form7();

        private void Form21_Load(object sender, EventArgs e)
        {
            this.Location = new Point(360, 175);
           
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from UyeAdres where UyeID like '" + girisID + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ceLearningTextbox4.Text = read["AdresSokak"].ToString();
                ceLearningTextbox1.Text = read["AdresIl"].ToString();
                ceLearningTextbox2.Text = read["AdresIlce"].ToString();
                ceLearningTextbox3.Text = read["AdresMahalle"].ToString();    
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fr7.girisID = girisID;
            fr7.Show();
            this.Hide();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ceLearningTextbox1.Text) || string.IsNullOrEmpty(ceLearningTextbox2.Text) || string.IsNullOrEmpty(ceLearningTextbox3.Text) || string.IsNullOrEmpty(ceLearningTextbox4.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string il = ceLearningTextbox1.Text;
                    string ilce = ceLearningTextbox2.Text;
                    string mahalle = ceLearningTextbox3.Text;
                    string sokak = ceLearningTextbox4.Text;

                    string sorgu = "update UyeAdres set AdresSokak = @AdresSokak, AdresIl = @AdresIl, AdresIlce = @AdresIlce, AdresMahalle = @AdresMahalle where UyeID = '" + girisID + "'";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    baglanti.Open();
                    komut.Parameters.AddWithValue("@AdresSokak", sokak);
                    komut.Parameters.AddWithValue("@AdresIl", il);
                    komut.Parameters.AddWithValue("@AdresIlce", ilce);
                    komut.Parameters.AddWithValue("@AdresMahalle", mahalle);
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();

                    MessageBox.Show("Adres Düzenlendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fr7.girisID = girisID;
                    fr7.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
