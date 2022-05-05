using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyonu
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Location = new Point(360, 175);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form6 fr6 = new Form6();
            fr6.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 fr8 = new Form8();
            fr8.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 fr9 = new Form9();
            fr9.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form10 fr10 = new Form10();
            fr10.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form12 fr12 = new Form12();
            fr12.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form13 fr13 = new Form13();
            fr13.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 fr14 = new Form14();
            fr14.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form15 fr15 = new Form15();
            fr15.yonetici = true;
            fr15.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
