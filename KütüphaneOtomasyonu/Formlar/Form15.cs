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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();
        SqlDataAdapter sda;
        public int girisID;
        public bool yonetici;
        public bool uye;

        private void Form15_Load(object sender, EventArgs e)
        {
            this.kitapTableAdapter.Fill(this.kutuphaneOtomasyonuDataSet7.Kitap);
            this.Location = new Point(360, 175);
            dataGridView1.DataSource = metot.yenile(new SqlDataAdapter("select * from Kitap", baglanti));
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( yonetici == true )
            {
                Form4 fr4 = new Form4();
                fr4.Show();
                this.Hide();
            }

            else if ( uye == true )
            {
                Form7 fr7 = new Form7();
                fr7.girisID = girisID;
                fr7.Show();
                this.Hide();
            }
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

            else if (comboBox1.Text == "Yayınevi")
            {
                sda = new SqlDataAdapter("select KitapISBN, KitapAdi, KitapDili, KitapSSayisi, KitapBYili, KitapTur, KitapStok, KitapYazar, KitapYEvi, KitapKayitTarihi  from Kitap where KitapYEvi like '" + ceLearningTextbox1.Text + "%'", baglanti);
                metot.arama(sda, dataGridView1, ceLearningTextbox1);
            }
        }
    }
}
