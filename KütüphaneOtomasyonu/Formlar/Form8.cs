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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();
        SqlDataAdapter sda;

        private void Form8_Load(object sender, EventArgs e)
        {
            this.uyeTableAdapter.Fill(this.kutuphaneOtomasyonuDataSet1.Uye);
            this.Location = new Point(360, 175);
            dataGridView1.DataSource = metot.yenile(new SqlDataAdapter("select * from Uye", baglanti));
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
                var a = MessageBox.Show("Seçilen üyeler çıkarılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (a == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("delete from Uye where UyeID='" + dataGridView1.SelectedRows[i].Cells["UyeID"].Value.ToString() + "'", baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    MessageBox.Show("Seçilen üyeler çıkarıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dataGridView1.DataSource = metot.yenile(new SqlDataAdapter("select * from Uye", baglanti));
            }
            catch (Exception)
            {
                MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ceLearningTextbox1_TextChanged(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select UyeID, UyeAdi, UyeSAdi, UyeKAdi, UyeSifre, UyeDTarihi, UyeTel, UyeYas, UyelikTarihi from Uye where UyeKAdi like '" + ceLearningTextbox1.Text + "%'", baglanti);
            metot.arama(sda, dataGridView1, ceLearningTextbox1);
        }
    }
}
