using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KütüphaneOtomasyonu
{
    public class CeLearningMaskedTextbox : Control
    {
        private int radius = 15;
        public MaskedTextBox maskedtextbox = new MaskedTextBox();
        private GraphicsPath shape;
        private GraphicsPath innerRect;
        private Color br;

        public CeLearningMaskedTextbox()
        {
            base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            base.SetStyle(ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            this.maskedtextbox.Parent = this;
            base.Controls.Add(this.maskedtextbox);
            this.maskedtextbox.BorderStyle = BorderStyle.None;
            maskedtextbox.Font = this.Font;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.Black;
            this.br = Color.White;
            maskedtextbox.BackColor = this.br;
            this.Text = null;
            this.Font = new Font("Century Gothic", 12f);
            base.Size = new Size(135, 33);
            this.DoubleBuffered = true;
            maskedtextbox.KeyDown += new KeyEventHandler(maskedtextbox_KeyDown);
            maskedtextbox.TextChanged += new EventHandler(maskedtextbox_TextChanged);
            maskedtextbox.MouseDoubleClick += new MouseEventHandler(maskedtextbox_MouseDoubleClick);

        }

        private void maskedtextbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                maskedtextbox.SelectAll();
            }
        }

        private void maskedtextbox_TextChanged(object sender, EventArgs e)
        {
            this.Text = maskedtextbox.Text;
        }

        private void maskedtextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.A))
            {
                maskedtextbox.SelectionStart = 0;
                maskedtextbox.SelectionLength = this.Text.Length;
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            maskedtextbox.Font = this.Font;
            base.Invalidate();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            maskedtextbox.ForeColor = this.ForeColor;
            base.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.shape = new MyRectangle((float)base.Width, (float)base.Height, (float)this.radius, 0f, 0f).Path;
            this.innerRect = new MyRectangle(base.Width - 0.5f, base.Height - 0.5f, (float)this.radius, 0.5f, 0.5f).Path;
            if (maskedtextbox.Height >= (base.Height - 4))
            {
                base.Height = maskedtextbox.Height + 4;
            }
            maskedtextbox.Location = new Point(this.radius - 5, (base.Height / 2) - (maskedtextbox.Font.Height / 2));
            maskedtextbox.Width = base.Width - ((int)(this.radius * 1.5));
            e.Graphics.SmoothingMode = ((SmoothingMode)SmoothingMode.HighQuality);
            Bitmap bitmap = new Bitmap(base.Width, base.Height);
            Graphics graphics = Graphics.FromImage((Image)bitmap);
            e.Graphics.DrawPath(Pens.Gray, this.shape);
            using (SolidBrush brush = new SolidBrush(this.br))
            {
                e.Graphics.FillPath((Brush)brush, this.innerRect);
            }
            Trans.MakeTransparent(this, e.Graphics);
            base.OnPaint(e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            maskedtextbox.Text = this.Text;
        }

        public void SelectedAll()
        {
            maskedtextbox.SelectAll();
        }

        public Color Br
        {
            get =>
                this.br;
            set
            {
                this.br = value;
                if (this.br != Color.Transparent)
                {
                    maskedtextbox.BackColor = this.br;
                }
                base.Invalidate();
            }
        }

        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = Color.Transparent;
        }
    }
}

