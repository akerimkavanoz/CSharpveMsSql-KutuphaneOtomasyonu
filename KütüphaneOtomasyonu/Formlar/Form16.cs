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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        public int girisID;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();

        private void Form16_Load(object sender, EventArgs e)
        {
            this.Location = new Point(360, 175);
            ceLearningTextbox4.textbox.UseSystemPasswordChar = true;
            ceLearningTextbox4.textbox.MaxLength = 15;
            ceLearningMaskedTextbox2.maskedtextbox.Mask = "(999) 000-0000";

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Uye where UyeID like '" + girisID + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ceLearningTextbox1.Text = read["UyeAdi"].ToString();
                ceLearningTextbox2.Text = read["UyeSAdi"].ToString();
                ceLearningTextbox3.Text = read["UyeKAdi"].ToString();
                ceLearningTextbox4.Text = read["UyeSifre"].ToString();
                rjDatePicker1.Text = read["UyeDTarihi"].ToString();
                ceLearningMaskedTextbox2.Text = read["UyeTel"].ToString();
            }   
            baglanti.Close();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.Show();
            this.Hide();
            fr7.girisID = girisID;
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            metot.sifreGoster(rjToggleButton1, ceLearningTextbox4);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(ceLearningTextbox1.Text) || string.IsNullOrEmpty(ceLearningTextbox2.Text) || string.IsNullOrEmpty(ceLearningTextbox3.Text) || string.IsNullOrEmpty(ceLearningTextbox4.Text) || string.IsNullOrEmpty(rjDatePicker1.Text) || string.IsNullOrEmpty(ceLearningMaskedTextbox2.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    string uye_adi = ceLearningTextbox1.Text;
                    string uye_soyadi = ceLearningTextbox2.Text;
                    string uye_kadi = ceLearningTextbox3.Text;
                    string uye_sifre = ceLearningTextbox4.Text;
                    DateTime uye_dtarihi = Convert.ToDateTime(rjDatePicker1.Text);
                    string uye_tel = ceLearningMaskedTextbox2.Text;

                    int UyeYas = 0;
                    TimeSpan fark;
                    fark = DateTime.Now.Date.Subtract(uye_dtarihi);
                    UyeYas = Convert.ToInt32(fark.TotalDays) / 365;

                    baglanti.Open();

                    string kayit = "Update Uye set UyeAdi = @UyeAdi, UyeSAdi = @UyeSAdi, UyeKAdi = @UyeKAdi, UyeSifre = @UyeSifre, UyeDTarihi = @UyeDTarihi, UyeTel = @UyeTel, UyeYas = @UyeYas where UyeID like'" + girisID + "'";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);

                    SqlCommand komut2 = new SqlCommand("select UyeKAdi from Uye where UyeID like '" + girisID + "'", baglanti);
                    var b = komut2.ExecuteScalar();

                    SqlCommand karsilastirma = new SqlCommand("select UyeKAdi from Uye", baglanti);
                    SqlDataReader veriOku = karsilastirma.ExecuteReader();

                    ArrayList array = new ArrayList();

                    int i = 0;

                    while (veriOku.Read())
                    {
                        array.Add(veriOku["UyeKAdi"].ToString());
                    }
                    karsilastirma.Dispose();
                    veriOku.Close();

                    bool a = false;

                    for (i = 0; i < array.Count; i++)
                    {
                        if (!ceLearningTextbox3.Text.Equals(b))
                        {
                            if (ceLearningTextbox3.Text.Equals(array[i]))
                            {
                                a = true;
                                break;
                            }
                        }
                    }

                    if (a == false)
                    {
                        komut.Parameters.AddWithValue("@UyeAdi", uye_adi);
                        komut.Parameters.AddWithValue("@UyeSAdi", uye_soyadi);
                        komut.Parameters.AddWithValue("@UyeKAdi", uye_kadi);
                        komut.Parameters.AddWithValue("@UyeSifre", uye_sifre);
                        komut.Parameters.AddWithValue("@UyeDTarihi", uye_dtarihi);
                        komut.Parameters.AddWithValue("@UyeTel", uye_tel);
                        komut.Parameters.AddWithValue("@UyeYas", UyeYas);
                        komut.ExecuteNonQuery();

                        komut.Dispose();
                        baglanti.Close();

                        MessageBox.Show("Üyelik bilgileri düzenlendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Bu kullanıcı adı sistemde kayıtlıdır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
    }
}
