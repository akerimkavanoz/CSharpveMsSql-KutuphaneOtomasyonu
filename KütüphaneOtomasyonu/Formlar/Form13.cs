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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();
        SqlDataAdapter sda;

        private void Form13_Load(object sender, EventArgs e)
        {
            this.kitapTableAdapter.Fill(this.kutuphaneOtomasyonuDataSet5.Kitap);
            this.Location = new Point(360, 175);
            dataGridView1.DataSource = metot.yenile(new SqlDataAdapter("select * from Kitap", baglanti));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            this.Hide();
        }

        private void ceLearningTextbox1_TextChanged_1(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select KitapISBN, KitapDili, KitapSSayisi, KitapBYili, KitapTur, KitapStok, KitapYazar, KitapYEvi, KitapKayitTarihi from Kitap where KitapISBN like '" + ceLearningTextbox1.Text + "%'", baglanti);
            metot.arama(sda, dataGridView1, ceLearningTextbox1);
        }

        private void ceLearningTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            metot.sadeceRakam(sender, e);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Seçilen kitaplar çıkarılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (a == DialogResult.Yes)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from Kitap where KitapISBN='" + dataGridView1.SelectedRows[i].Cells["KitapISBN"].Value.ToString() + "'", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                }
                MessageBox.Show("Seçilen kitaplar çıkarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.DataSource = metot.yenile(new SqlDataAdapter("select * from Kitap", baglanti));
        }
    }
}
