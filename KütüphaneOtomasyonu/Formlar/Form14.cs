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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();
        SqlCommandBuilder sqlbuild;
        SqlDataAdapter adtr;
        DataSet daset = new DataSet();
        SqlDataAdapter sda;

        private void Form14_Load(object sender, EventArgs e)
        {
            this.kitapTableAdapter.Fill(this.kutuphaneOtomasyonuDataSet6.Kitap);
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
            adtr = new SqlDataAdapter("select * from Kitap", baglanti);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            sqlbuild = new SqlCommandBuilder(adtr);
            adtr.Update(daset, "Kitap");
            MessageBox.Show("İşlem başarılı");
            dataGridView1.DataSource = metot.yenile(new SqlDataAdapter("select * from Kitap", baglanti));
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            metot.editingControl(e, dataGridView1, false);
        }

        private void ceLearningTextbox1_TextChanged(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("select KitapISBN, KitapDili, KitapSSayisi, KitapBYili, KitapTur, KitapStok, KitapYazar, KitapYEvi, KitapKayitTarihi from Kitap where KitapISBN like '" + ceLearningTextbox1.Text + "%'", baglanti);
            metot.arama(sda, dataGridView1, ceLearningTextbox1);
        }

        private void ceLearningTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            metot.sadeceRakam(sender, e);
        }
    }
}
