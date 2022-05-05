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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private string text;
        private int len = 0;

        public int girisID;
        public bool yonetici;
        public bool uye;

        private void Form11_Load(object sender, EventArgs e)
        {
            this.Location = new Point(650, 400);
            text = label1.Text;
            label1.Text = "";
            timer1.Start();
            timer2.Start();
        }
 
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 541)
            {
                timer1.Stop();
               
                if(yonetici == true)
                {
                    Form4 fr4 = new Form4();
                    fr4.Show();
                    this.Hide();
                }

                else if(uye == true)
                {
                    Form7 fr7 = new Form7();
                    fr7.girisID = girisID;
                    fr7.Show();
                    this.Hide();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                label1.Text = label1.Text + text.ElementAt(len);
                len++;
            }
            else
            {
                label1.Text = "";
                len = 0;
            }
        }
    }
}
