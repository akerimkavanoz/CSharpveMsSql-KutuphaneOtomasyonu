using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace KütüphaneOtomasyonu
{
    class Metotlar
    {
        public SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");

        public void sadeceRakam(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void temizle(CeLearningTextbox ceLearningTextbox1, DataGridView dataGridView1)
        {
            if (string.IsNullOrEmpty(ceLearningTextbox1.Text))
            {
                dataGridView1.ClearSelection();
            }
        }

        public void arama(SqlDataAdapter sda, DataGridView dataGridView1, CeLearningTextbox ceLearningTextbox1)
        {
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            temizle(ceLearningTextbox1, dataGridView1);
        }

        public DataTable yenile(SqlDataAdapter adt)
        {
            baglanti.Open();
            SqlDataAdapter adtr = adt;
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        
        public void sifreGoster(RJToggleButton rjToggleButton1, CeLearningTextbox ceLearningTextbox2)
        {
            if (rjToggleButton1.CheckState == CheckState.Checked)
                ceLearningTextbox2.textbox.UseSystemPasswordChar = false;
            else
                ceLearningTextbox2.textbox.UseSystemPasswordChar = true;
        }

        public void uyeEkle(CeLearningTextbox ceLearningTextbox1, CeLearningTextbox ceLearningTextbox2, CeLearningTextbox ceLearningTextbox3, CeLearningTextbox ceLearningTextbox4, RJDatePicker rjDatePicker1, CeLearningMaskedTextbox ceLearningMaskedTextbox2, bool b)
        {
            Form3 fr3 = new Form3();
            Form5 fr5 = new Form5();
            Form4 fr4 = new Form4();
            Form6 fr6 = new Form6();
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
                    DateTime UyelikTarihi = DateTime.Today;

                    baglanti.Open();

                    string kayit = "insert into Uye(UyeAdi, UyeSAdi, UyeKAdi, UyeSifre, UyeDTarihi, UyeTel, UyeYas, UyelikTarihi) values(@UyeAdi, @UyeSAdi, @UyeKAdi, @UyeSifre, @UyeDTarihi, @UyeTel, @UyeYas, @UyelikTarihi)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);

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
                        if (ceLearningTextbox3.Text.Equals(array[i]))
                        {
                            a = true;
                            break;
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
                        
                        komut.Parameters.AddWithValue("@UyelikTarihi", UyelikTarihi);
                        komut.ExecuteNonQuery();

                        komut.Dispose();
                        baglanti.Close();

                        if (b == true)
                        {
                            MessageBox.Show("Üye Olundu", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fr3.Show();
                            fr5.Hide();
                            baglanti.Close();
                        }

                        else if (b == false)
                        {
                            MessageBox.Show("Üye Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fr4.Show();
                            fr6.Hide();
                            baglanti.Close();
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Bu kullanıcı adı sistemde kayıtlıdır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        baglanti.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editingControl(DataGridViewEditingControlShowingEventArgs e, DataGridView dataGridView2 , bool a)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (a == true)
            {
                if (dataGridView2.CurrentCell.ColumnIndex == 5 || dataGridView2.CurrentCell.ColumnIndex == 6)
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                    }
                }
            }

            else if (a == false)
            {
                if (dataGridView2.CurrentCell.ColumnIndex == 3 || dataGridView2.CurrentCell.ColumnIndex == 4 || dataGridView2.CurrentCell.ColumnIndex == 6)
                {
                    TextBox tb = e.Control as TextBox;
                    if (tb != null)
                    {
                        tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                    }
                }
            }
           
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
