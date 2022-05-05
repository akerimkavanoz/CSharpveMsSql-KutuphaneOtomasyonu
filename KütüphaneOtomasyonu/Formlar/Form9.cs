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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();
        SqlCommandBuilder sqlbuild;
        SqlDataAdapter adtr;
        SqlDataAdapter sda;
        DataSet daset = new DataSet();

        private void Form9_Load(object sender, EventArgs e)
        {
            this.uyeTableAdapter1.Fill(this.kutuphaneOtomasyonuDataSet3.Uye);
            this.Location = new Point(360, 175);
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            this.Hide();
        }

        void listele()
        {
            baglanti.Open();
            adtr = new SqlDataAdapter("select * from Uye", baglanti);
            adtr.Fill(daset, "Uye");
            dataGridView2.DataSource = daset.Tables["Uye"];
            baglanti.Close();
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            metot.editingControl(e, dataGridView2, true);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            sqlbuild = new SqlCommandBuilder(adtr);
            adtr.Update(daset, "Uye");
            MessageBox.Show("Seçilen üyeler düzenlendi ve kaydedildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
            dataGridView2.DataSource = metot.yenile(new SqlDataAdapter("select * from Uye", baglanti));
        }

        private void ceLearningTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            sda = new SqlDataAdapter("select UyeID, UyeAdi, UyeSAdi, UyeKAdi, UyeSifre, UyeDTarihi, UyeTel, UyeYas, UyelikTarihi from Uye where UyeKAdi like '" + ceLearningTextbox1.Text + "%'", baglanti);
            metot.arama(sda, dataGridView2, ceLearningTextbox1);
        }
    }
}
