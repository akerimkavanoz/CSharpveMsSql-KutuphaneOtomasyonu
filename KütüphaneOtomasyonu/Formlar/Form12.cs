using System;
using System.Collections;
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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();
        Form4 fr4 = new Form4();

        private void Form12_Load(object sender, EventArgs e)
        {
            this.Location = new Point(360, 175);
            this.AcceptButton = rjButton1;
            ceLearningTextbox4.textbox.MaxLength = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            this.Hide();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ceLearningTextbox1.Text) || string.IsNullOrEmpty(ceLearningTextbox2.Text) || string.IsNullOrEmpty(ceLearningTextbox3.Text) || string.IsNullOrEmpty(ceLearningTextbox4.Text) || string.IsNullOrEmpty(ceLearningTextbox5.Text) || string.IsNullOrEmpty(ceLearningTextbox6.Text) || string.IsNullOrEmpty(ceLearningTextbox7.Text) || string.IsNullOrEmpty(ceLearningTextbox8.Text) || string.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string kitap_adi = ceLearningTextbox1.Text;
                    string kitap_yazari = ceLearningTextbox2.Text;
                    string kitap_ssayisi = ceLearningTextbox3.Text;
                    string kitap_byili = ceLearningTextbox4.Text;
                    string kitap_yevi = ceLearningTextbox5.Text;
                    string kitap_dili = ceLearningTextbox6.Text;
                    string kitap_stok = ceLearningTextbox7.Text;
                    string kitap_isbn = ceLearningTextbox8.Text;
                    string kitap_turu = comboBox1.Text;
                    DateTime KitapKTarihi = DateTime.Today;
                    
                    baglanti.Open();

                    string kayit = "insert into Kitap(KitapISBN, KitapAdi, KitapDili, KitapSSayisi, KitapBYili, KitapTur, KitapStok, KitapYazar, KitapYEvi, KitapKayitTarihi) values(@KitapISBN, @KitapAdi, @KitapDili, @KitapSSayisi, @KitapBYili, @KitapTur, @KitapStok, @KitapYazar, @KitapYEvi, @KitapKayitTarihi)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);

                    SqlCommand karsilastirma = new SqlCommand("select KitapISBN from Kitap", baglanti);
                    SqlDataReader veriOku = karsilastirma.ExecuteReader();

                    ArrayList array = new ArrayList();
                    bool a = false;

                    int i = 0;

                    while (veriOku.Read())
                    {
                        array.Add(veriOku["KitapISBN"].ToString());
                    }
                    karsilastirma.Dispose();
                    veriOku.Close();

                    for (i = 0; i < array.Count; i++)
                    {
                        if (ceLearningTextbox8.Text.Equals(array[i]))
                        {
                            a = true;
                            break;
                        }
                    }

                    if (a == false)
                    {
                        komut.Parameters.AddWithValue("@KitapISBN", kitap_isbn);
                        komut.Parameters.AddWithValue("@KitapAdi", kitap_adi);
                        komut.Parameters.AddWithValue("@KitapDili", kitap_dili);
                        komut.Parameters.AddWithValue("@KitapSSayisi", kitap_ssayisi);
                        komut.Parameters.AddWithValue("@KitapBYili", kitap_byili);
                        komut.Parameters.AddWithValue("@KitapTur", kitap_turu);
                        komut.Parameters.AddWithValue("@KitapStok", kitap_stok);
                        komut.Parameters.AddWithValue("@KitapYazar", kitap_yazari);
                        komut.Parameters.AddWithValue("@KitapYEvi", kitap_yevi);
                        komut.Parameters.AddWithValue("@KitapKayitTarihi", KitapKTarihi);
                        komut.ExecuteNonQuery();

                        komut.Dispose();
                        baglanti.Close();

                        MessageBox.Show("Kitap Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fr4.Show();
                        this.Hide();
                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bu kitap sistemde kayıtlıdır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ceLearningTextbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            metot.sadeceRakam(sender, e);
        }

        private void ceLearningTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            metot.sadeceRakam(sender, e);
        }

        private void ceLearningTextbox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            metot.sadeceRakam(sender, e);
        }

        private void ceLearningTextbox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            metot.sadeceRakam(sender, e);
        }
    }
}
