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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Location = new Point(360, 175);
            ceLearningTextbox2.textbox.UseSystemPasswordChar = true;
            AcceptButton = rjButton1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form5 fr = new Form5();
            fr.Show();
            this.Hide();
        }
        
        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = ceLearningTextbox1.Text;
                string sifre = ceLearningTextbox2.Text;
                SqlCommand com = new SqlCommand();
                baglanti.Open();
                com.Connection = baglanti;
                com.CommandText = "select * from Uye where UyeKAdi='" + ceLearningTextbox1.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and UyeSifre='" + ceLearningTextbox2.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
                SqlDataReader dr = com.ExecuteReader();

                if (string.IsNullOrEmpty(ceLearningTextbox1.Text) || string.IsNullOrEmpty(ceLearningTextbox2.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (dr.Read())
                    {
                        int girisID = Convert.ToInt32(dr[0]);
                        MessageBox.Show("Giriş Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form11 fr11 = new Form11();
                        fr11.uye = true;
                        fr11.girisID = girisID;
                        fr11.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre", "Hatalı giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                baglanti.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            metot.sifreGoster(rjToggleButton1, ceLearningTextbox2);
        }
    }
}
