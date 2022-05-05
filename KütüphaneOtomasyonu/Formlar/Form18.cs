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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        public int girisID;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();
        SqlDataAdapter sda;

        private void Form18_Load(object sender, EventArgs e)
        {
            this.kitapTableAdapter.Fill(this.kutuphaneOtomasyonuDataSet9.Kitap);
            this.Location = new Point(360, 175);
            comboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = metot.yenile(new SqlDataAdapter("select * from Kitap", baglanti));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.Show();
            this.Hide();
            fr7.girisID = girisID;
        }
        
        private void ceLearningTextbox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ISBN")
            {
                sda = new SqlDataAdapter("select KitapISBN, KitapAdi, KitapDili, KitapSSayisi, KitapBYili, KitapTur, KitapStok, KitapYazar, KitapYEvi, KitapKayitTarihi  from Kitap where KitapISBN like '" + ceLearningTextbox1.Text + "%'", baglanti);
                metot.arama(sda, dataGridView1, ceLearningTextbox1);
            }

            else if (comboBox1.Text == "Ad")
            {
                sda = new SqlDataAdapter("select KitapISBN, KitapAdi, KitapDili, KitapSSayisi, KitapBYili, KitapTur, KitapStok, KitapYazar, KitapYEvi, KitapKayitTarihi  from Kitap where KitapAdi like '" + ceLearningTextbox1.Text + "%'", baglanti);
                metot.arama(sda, dataGridView1, ceLearningTextbox1);
            }

            else if (comboBox1.Text == "Dil")
            {
                sda = new SqlDataAdapter("select KitapISBN, KitapAdi, KitapDili, KitapSSayisi, KitapBYili, KitapTur, KitapStok, KitapYazar, KitapYEvi, KitapKayitTarihi  from Kitap where KitapDili like '" + ceLearningTextbox1.Text + "%'", baglanti);
                metot.arama(sda, dataGridView1, ceLearningTextbox1);
            }

            else if (comboBox1.Text == "Sayfa Sayısı")
            {
                sda = new SqlDataAdapter("select KitapISBN, KitapAdi, KitapDili, KitapSSayisi, KitapBYili, KitapTur, KitapStok, KitapYazar, KitapYEvi, KitapKayitTarihi  from Kitap where KitapSSayisi like '" + ceLearningTextbox1.Text + "%'", baglanti);
                metot.arama(sda, dataGridView1, ceLearningTextbox1);
            }

            else if (comboBox1.Text == "Basım Yılı")
            {
                sda = new SqlDataAdapter("select KitapISBN, KitapAdi, KitapDili, KitapSSayisi, KitapBYili, KitapTur, KitapStok, KitapYazar, KitapYEvi, KitapKayitTarihi  from Kitap where KitapBYili like '" + ceLearningTextbox1.Text + "%'", baglanti);
                metot.arama(sda, dataGridView1, ceLearningTextbox1);
            }

            else if (comboBox1.Text == "Tür")
            {
                sda = new SqlDataAdapter("select KitapISBN, KitapAdi, KitapDili, KitapSSayisi, KitapBYili, KitapTur, KitapStok, KitapYazar, KitapYEvi, KitapKayitTarihi  from Kitap where KitapTur like '" + ceLearningTextbox1.Text + "%'", baglanti);
                metot.arama(sda, dataGridView1, ceLearningTextbox1);
            }

            else if (comboBox1.Text == "Yazar")
            {
                sda = new SqlDataAdapter("select KitapISBN, KitapAdi, KitapDili, KitapSSayisi, KitapBYili, KitapTur, KitapStok, KitapYazar, KitapYEvi, KitapKayitTarihi  from Kitap where KitapYazar like '" + ceLearningTextbox1.Text + "%'", baglanti);
                metot.arama(sda, dataGridView1, ceLearningTextbox1);
            }

            else if (comboBox1.Text == "Yayınevi")
            {
                sda = new SqlDataAdapter("select KitapISBN, KitapAdi, KitapDili, KitapSSayisi, KitapBYili, KitapTur, KitapStok, KitapYazar, KitapYEvi, KitapKayitTarihi  from Kitap where KitapYEvi like '" + ceLearningTextbox1.Text + "%'", baglanti);
                metot.arama(sda, dataGridView1, ceLearningTextbox1);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime EmanetTarihi = DateTime.Today;

                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    baglanti.Open();
                    var KitapISBN = dataGridView1.SelectedRows[i].Cells["KitapISBN"].Value.ToString();
                    var KitapStok = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells["KitapStok"].Value);
                    SqlCommand komut = new SqlCommand("insert into Emanet(UyeID, KitapISBN, EmanetTarihi) values(@UyeID, @KitapISBN , @EmanetTarihi)", baglanti);
                    SqlCommand komut2 = new SqlCommand("select count(KitapISBN) from Emanet where UyeID like '" + girisID + "' and KitapISBN like '" + KitapISBN + "'", baglanti);
                    int a = Convert.ToInt32(komut2.ExecuteScalar());
                   
                    if (KitapStok > 0)
                    {
                        if (a == 0)
                        {
                            komut.Parameters.AddWithValue("@UyeID", girisID);
                            komut.Parameters.AddWithValue("@KitapISBN", KitapISBN);
                            komut.Parameters.AddWithValue("@EmanetTarihi", EmanetTarihi);
                            komut.ExecuteNonQuery();
                            MessageBox.Show("Kitap Alındı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            MessageBox.Show("Bu kitabı zaten aldınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Bu kitap stoklarda kalmamıştır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                baglanti.Close();
                dataGridView1.DataSource = metot.yenile(new SqlDataAdapter("select * from Kitap", baglanti));

        }
            catch (Exception)
            {
                MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}
