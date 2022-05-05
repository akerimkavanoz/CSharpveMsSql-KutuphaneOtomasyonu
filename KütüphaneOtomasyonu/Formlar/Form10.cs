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
using System.Drawing.Drawing2D;

namespace KütüphaneOtomasyonu
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();
        SqlDataAdapter sda;

        private void Form10_Load(object sender, EventArgs e)
        {
            this.uyeTableAdapter.Fill(this.kutuphaneOtomasyonuDataSet4.Uye);
            this.Location = new Point(360, 175);
            comboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = metot.yenile(new SqlDataAdapter("select * from Uye", baglanti));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            this.Hide();
        }

        private void ceLearningTextbox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ID")
            {
                sda = new SqlDataAdapter("select UyeID, UyeAdi, UyeSAdi, UyeKAdi, UyeSifre, UyeDTarihi, UyeTel, UyeYas, UyelikTarihi from Uye where UyeID like '" + ceLearningTextbox1.Text + "%'", baglanti);
                metot.arama(sda, dataGridView1, ceLearningTextbox1);
            }

            else if (comboBox1.Text == "Ad")
            {
                sda = new SqlDataAdapter("select UyeID, UyeAdi, UyeSAdi, UyeKAdi, UyeSifre, UyeDTarihi, UyeTel, UyeYas, UyelikTarihi from Uye where UyeAdi like '" + ceLearningTextbox1.Text + "%'", baglanti);
                metot.arama(sda, dataGridView1, ceLearningTextbox1);
            }

            else if (comboBox1.Text == "Soyad")
            {
                sda = new SqlDataAdapter("select UyeID, UyeAdi, UyeSAdi, UyeKAdi, UyeSifre, UyeDTarihi, UyeTel, UyeYas, UyelikTarihi from Uye where UyeSAdi like '" + ceLearningTextbox1.Text + "%'", baglanti);
                metot.arama(sda, dataGridView1, ceLearningTextbox1);
            }

            else if (comboBox1.Text == "Kullanıcı Adı")
            {
                sda = new SqlDataAdapter("select UyeID, UyeAdi, UyeSAdi, UyeKAdi, UyeSifre, UyeDTarihi, UyeTel, UyeYas, UyelikTarihi from Uye where UyeKAdi like '" + ceLearningTextbox1.Text + "%'", baglanti);
                metot.arama(sda, dataGridView1, ceLearningTextbox1);
            }
        }
    }
}
