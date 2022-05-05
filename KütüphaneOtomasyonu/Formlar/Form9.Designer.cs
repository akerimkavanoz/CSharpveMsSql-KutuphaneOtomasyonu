
namespace KütüphaneOtomasyonu
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.uyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneOtomasyonuDataSet2 = new KütüphaneOtomasyonu.KutuphaneOtomasyonuDataSet2();
            this.uyeTableAdapter = new KütüphaneOtomasyonu.KutuphaneOtomasyonuDataSet2TableAdapters.UyeTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.uyeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeSAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeKAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeSifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeDTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeYasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyelikTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneOtomasyonuDataSet3 = new KütüphaneOtomasyonu.KutuphaneOtomasyonuDataSet3();
            this.uyeTableAdapter1 = new KütüphaneOtomasyonu.KutuphaneOtomasyonuDataSet3TableAdapters.UyeTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.ceLearningTextbox1 = new KütüphaneOtomasyonu.CeLearningTextbox();
            this.rjButton1 = new KütüphaneOtomasyonu.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(428, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 72);
            this.label1.TabIndex = 16;
            this.label1.Text = "Üye Düzenle";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.ImageKey = "Untitled.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(50, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 38);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Untitled.png");
            // 
            // uyeBindingSource
            // 
            this.uyeBindingSource.DataMember = "Uye";
            this.uyeBindingSource.DataSource = this.kutuphaneOtomasyonuDataSet2;
            // 
            // kutuphaneOtomasyonuDataSet2
            // 
            this.kutuphaneOtomasyonuDataSet2.DataSetName = "KutuphaneOtomasyonuDataSet2";
            this.kutuphaneOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyeTableAdapter
            // 
            this.uyeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uyeIDDataGridViewTextBoxColumn,
            this.UyeAdi,
            this.UyeSAdi,
            this.UyeKAdi,
            this.UyeSifre,
            this.UyeDTarihi,
            this.UyeTel,
            this.uyeYasDataGridViewTextBoxColumn,
            this.UyelikTarihi});
            this.dataGridView2.DataSource = this.uyeBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(50, 186);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Size = new System.Drawing.Size(1106, 369);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            // 
            // uyeIDDataGridViewTextBoxColumn
            // 
            this.uyeIDDataGridViewTextBoxColumn.DataPropertyName = "UyeID";
            this.uyeIDDataGridViewTextBoxColumn.HeaderText = "    ID";
            this.uyeIDDataGridViewTextBoxColumn.Name = "uyeIDDataGridViewTextBoxColumn";
            this.uyeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uyeIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // UyeAdi
            // 
            this.UyeAdi.DataPropertyName = "UyeAdi";
            this.UyeAdi.HeaderText = " Adı";
            this.UyeAdi.Name = "UyeAdi";
            this.UyeAdi.Width = 130;
            // 
            // UyeSAdi
            // 
            this.UyeSAdi.DataPropertyName = "UyeSAdi";
            this.UyeSAdi.HeaderText = "  Soyadı";
            this.UyeSAdi.Name = "UyeSAdi";
            this.UyeSAdi.Width = 130;
            // 
            // UyeKAdi
            // 
            this.UyeKAdi.DataPropertyName = "UyeKAdi";
            this.UyeKAdi.HeaderText = " Kullanıcı Adı";
            this.UyeKAdi.Name = "UyeKAdi";
            this.UyeKAdi.ReadOnly = true;
            this.UyeKAdi.Width = 130;
            // 
            // UyeSifre
            // 
            this.UyeSifre.DataPropertyName = "UyeSifre";
            this.UyeSifre.HeaderText = "  Şifre";
            this.UyeSifre.Name = "UyeSifre";
            this.UyeSifre.Width = 129;
            // 
            // UyeDTarihi
            // 
            this.UyeDTarihi.DataPropertyName = "UyeDTarihi";
            this.UyeDTarihi.HeaderText = "  Doğum Tarihi";
            this.UyeDTarihi.Name = "UyeDTarihi";
            this.UyeDTarihi.Width = 135;
            // 
            // UyeTel
            // 
            this.UyeTel.DataPropertyName = "UyeTel";
            this.UyeTel.HeaderText = "   Telefon";
            this.UyeTel.Name = "UyeTel";
            this.UyeTel.Width = 130;
            // 
            // uyeYasDataGridViewTextBoxColumn
            // 
            this.uyeYasDataGridViewTextBoxColumn.DataPropertyName = "UyeYas";
            this.uyeYasDataGridViewTextBoxColumn.HeaderText = "   Yaş";
            this.uyeYasDataGridViewTextBoxColumn.Name = "uyeYasDataGridViewTextBoxColumn";
            this.uyeYasDataGridViewTextBoxColumn.ReadOnly = true;
            this.uyeYasDataGridViewTextBoxColumn.Width = 115;
            // 
            // UyelikTarihi
            // 
            this.UyelikTarihi.DataPropertyName = "UyelikTarihi";
            this.UyelikTarihi.HeaderText = " Üyelik Tarihi";
            this.UyelikTarihi.Name = "UyelikTarihi";
            this.UyelikTarihi.ReadOnly = true;
            this.UyelikTarihi.Width = 125;
            // 
            // uyeBindingSource1
            // 
            this.uyeBindingSource1.DataMember = "Uye";
            this.uyeBindingSource1.DataSource = this.kutuphaneOtomasyonuDataSet3;
            // 
            // kutuphaneOtomasyonuDataSet3
            // 
            this.kutuphaneOtomasyonuDataSet3.DataSetName = "KutuphaneOtomasyonuDataSet3";
            this.kutuphaneOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyeTableAdapter1
            // 
            this.uyeTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(46, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Kullanıcı Adına Göre Arama";
            // 
            // ceLearningTextbox1
            // 
            this.ceLearningTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.ceLearningTextbox1.Br = System.Drawing.Color.White;
            this.ceLearningTextbox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceLearningTextbox1.ForeColor = System.Drawing.Color.Black;
            this.ceLearningTextbox1.Location = new System.Drawing.Point(326, 139);
            this.ceLearningTextbox1.Name = "ceLearningTextbox1";
            this.ceLearningTextbox1.Size = new System.Drawing.Size(263, 28);
            this.ceLearningTextbox1.TabIndex = 24;
            this.ceLearningTextbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ceLearningTextbox1_KeyPress);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(498, 575);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(233, 40);
            this.rjButton1.TabIndex = 22;
            this.rjButton1.Text = "Düzenle ve Kaydet";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1198, 627);
            this.Controls.Add(this.ceLearningTextbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form9";
            this.Text = "Üye Düzenle";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private KutuphaneOtomasyonuDataSet2 kutuphaneOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource uyeBindingSource;
        private KutuphaneOtomasyonuDataSet2TableAdapters.UyeTableAdapter uyeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private KutuphaneOtomasyonuDataSet3 kutuphaneOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource uyeBindingSource1;
        private KutuphaneOtomasyonuDataSet3TableAdapters.UyeTableAdapter uyeTableAdapter1;
        private RJButton rjButton1;
        private CeLearningTextbox ceLearningTextbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeSAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeKAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeSifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeDTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeYasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyelikTarihi;
    }
}