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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public int girisID;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");

        private void Form7_Load(object sender, EventArgs e)
        {
            this.Location = new Point(360, 175);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 fr16 = new Form16();
            fr16.girisID = girisID;
            fr16.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form15 fr15 = new Form15();
            fr15.girisID = girisID;
            fr15.uye = true;
            fr15.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form18 fr18 = new Form18();
            fr18.Show();
            this.Hide();
            fr18.girisID = girisID;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form19 fr19 = new Form19();
            fr19.girisID = girisID;
            fr19.Show();
            this.Hide();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select count(UyeID) from UyeAdres where UyeID = '" + girisID + "'", baglanti);
            int a = Convert.ToInt32(komut.ExecuteScalar());

            if (a == 0)
            {
                Form20 fr20 = new Form20();
                fr20.Show();
                fr20.girisID = girisID;
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kayıtlı adresiniz bulunmaktadır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select count(UyeID) from UyeAdres where UyeID = '" + girisID + "'", baglanti);
            int a = Convert.ToInt32(komut.ExecuteScalar());

            if (a == 0)
            {
                MessageBox.Show("Kayıtlı adresiniz bulunmamaktadır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                Form21 fr21 = new Form21();
                fr21.girisID = girisID;
                fr21.Show();
                this.Hide();
            }
            baglanti.Close();
        }
    }
}
