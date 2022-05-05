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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F114M3V;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True");
        Metotlar metot = new Metotlar();
        Form4 fr4 = new Form4();

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Location = new Point(360, 175);
            ceLearningTextbox4.textbox.UseSystemPasswordChar = true;
            ceLearningTextbox4.textbox.MaxLength = 15;
            ceLearningMaskedTextbox2.maskedtextbox.Mask = "(999) 000-0000";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fr4.Show();
            this.Hide();
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            metot.sifreGoster(rjToggleButton1, ceLearningTextbox4);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            metot.uyeEkle(ceLearningTextbox1, ceLearningTextbox2, ceLearningTextbox3, ceLearningTextbox4, rjDatePicker1, ceLearningMaskedTextbox2, false);
        }
    }
}
