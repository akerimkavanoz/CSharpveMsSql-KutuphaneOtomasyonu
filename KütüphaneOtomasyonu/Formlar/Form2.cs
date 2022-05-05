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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();
        
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(360, 175);
            ceLearningTextbox2.textbox.UseSystemPasswordChar = true;
            ceLearningTextbox2.textbox.MaxLength = 15;
            this.AcceptButton = rjButton1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from Yonetici where YoneticiKAdi=@adi COLLATE SQL_Latin1_General_CP1_CS_AS and YoneticiSifre=@sifresi COLLATE SQL_Latin1_General_CP1_CS_AS";
                SqlParameter prm1 = new SqlParameter("adi", ceLearningTextbox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", ceLearningTextbox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (string.IsNullOrEmpty(ceLearningTextbox1.Text) || string.IsNullOrEmpty(ceLearningTextbox2.Text))
                {
                    MessageBox.Show("Lütfen bilgilerinizi giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Giriş Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form11 fr11 = new Form11();
                        fr11.yonetici = true;
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

        private void ceLearningTextbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            metot.sadeceRakam(sender, e);
        }
    }
}
