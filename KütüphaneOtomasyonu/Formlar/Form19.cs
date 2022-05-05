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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        public int girisID;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();
        SqlDataAdapter adtr;

        private void Form19_Load(object sender, EventArgs e)
        {
            this.kitapTableAdapter.Fill(this.kutuphaneOtomasyonuDataSet11.Kitap);
            this.Location = new Point(360, 175);
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.Show();
            this.Hide();
            fr7.girisID = girisID;
        }

        void listele()
        {
            baglanti.Open();
            adtr = new SqlDataAdapter("select * from Kitap where KitapISBN in (Select KitapISBN from Emanet where UyeID like '" + girisID + "')", baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        void degerlendirme(int b)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("select count(KitapISBN) from KitapDegerlendirme where KitapISBN = '" + dataGridView1.SelectedRows[i].Cells["KitapISBN"].Value.ToString() + "'", baglanti);
                int a = Convert.ToInt32(komut2.ExecuteScalar());

                if (a == 0)
                {
                    SqlCommand komut = new SqlCommand("insert into KitapDegerlendirme(UyeID, KitapISBN, Degerlendirme) values ('" + girisID + "', '" + dataGridView1.SelectedRows[i].Cells["KitapISBN"].Value.ToString() + "', '" + b + "')", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Değerlendirmeniz alınmıştır", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Bu kitap için değerlendirme yaptınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                baglanti.Close();
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            degerlendirme(1);
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            degerlendirme(2);
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            degerlendirme(3);
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            degerlendirme(4);
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            degerlendirme(5);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime IadeTarihi = DateTime.Today;
                var a = MessageBox.Show("Seçilen kitaplar iade edilsin mi", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (a == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("delete from Emanet where KitapISBN='" + dataGridView1.SelectedRows[i].Cells["KitapISBN"].Value.ToString() + "'", baglanti);
                        komut.ExecuteNonQuery();

                        var KitapISBN = dataGridView1.SelectedRows[i].Cells["KitapISBN"].Value.ToString();
                        SqlCommand komut2 = new SqlCommand("insert into Iade(UyeID, KitapISBN, IadeTarihi) values(@UyeID, @KitapISBN , @IadeTarihi)", baglanti);
                        SqlCommand komut3 = new SqlCommand("select count(KitapISBN) from Iade where UyeID like '" + girisID + "' and KitapISBN like '" + KitapISBN + "'", baglanti);
                        SqlCommand komut4 = new SqlCommand("update Iade set IadeTarihi = @IadeTarihi where UyeID like '" + girisID + "' and KitapISBN like '" + KitapISBN + "'", baglanti);
                        int b = Convert.ToInt32(komut3.ExecuteScalar());

                        if ( b == 0 )
                        {
                            komut2.Parameters.AddWithValue("@UyeID", girisID);
                            komut2.Parameters.AddWithValue("@KitapISBN", KitapISBN);
                            komut2.Parameters.AddWithValue("@IadeTarihi", IadeTarihi);
                            komut2.ExecuteNonQuery();
                            baglanti.Close();
                        }

                        else if ( b == 1 )
                        {
                            komut4.Parameters.AddWithValue("@IadeTarihi", IadeTarihi);
                            komut4.ExecuteNonQuery();
                            baglanti.Close();
                        }  
                    }
                    MessageBox.Show("Seçilen kitaplar iade edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridView1.DataSource = metot.yenile(new SqlDataAdapter("select * from Kitap where KitapISBN in (Select KitapISBN from Emanet where UyeID like '" + girisID + "')", baglanti));
            }
            catch (Exception)
            {
                MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
