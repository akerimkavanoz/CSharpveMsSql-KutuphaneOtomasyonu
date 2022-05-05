
namespace KütüphaneOtomasyonu
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.uyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneOtomasyonuDataSet1 = new KütüphaneOtomasyonu.KutuphaneOtomasyonuDataSet1();
            this.emanetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneOtomasyonuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneOtomasyonuDataSet = new KütüphaneOtomasyonu.KutuphaneOtomasyonuDataSet();
            this.emanetTableAdapter = new KütüphaneOtomasyonu.KutuphaneOtomasyonuDataSetTableAdapters.EmanetTableAdapter();
            this.uyeTableAdapter = new KütüphaneOtomasyonu.KutuphaneOtomasyonuDataSet1TableAdapters.UyeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UyeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeSAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeKAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeSifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeDTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeYas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.ceLearningTextbox1 = new KütüphaneOtomasyonu.CeLearningTextbox();
            this.rjButton1 = new KütüphaneOtomasyonu.RJButton();
            this.uyeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeSAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeKAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeDTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeYasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.ImageKey = "Untitled.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(41, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 38);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Untitled.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(438, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 72);
            this.label1.TabIndex = 14;
            this.label1.Text = "Üye Çıkar";
            // 
            // uyeBindingSource
            // 
            this.uyeBindingSource.DataMember = "Uye";
            this.uyeBindingSource.DataSource = this.kutuphaneOtomasyonuDataSet1;
            // 
            // kutuphaneOtomasyonuDataSet1
            // 
            this.kutuphaneOtomasyonuDataSet1.DataSetName = "KutuphaneOtomasyonuDataSet1";
            this.kutuphaneOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emanetBindingSource
            // 
            this.emanetBindingSource.DataMember = "Emanet";
            this.emanetBindingSource.DataSource = this.kutuphaneOtomasyonuDataSetBindingSource;
            // 
            // kutuphaneOtomasyonuDataSetBindingSource
            // 
            this.kutuphaneOtomasyonuDataSetBindingSource.DataSource = this.kutuphaneOtomasyonuDataSet;
            this.kutuphaneOtomasyonuDataSetBindingSource.Position = 0;
            // 
            // kutuphaneOtomasyonuDataSet
            // 
            this.kutuphaneOtomasyonuDataSet.DataSetName = "KutuphaneOtomasyonuDataSet";
            this.kutuphaneOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emanetTableAdapter
            // 
            this.emanetTableAdapter.ClearBeforeFill = true;
            // 
            // uyeTableAdapter
            // 
            this.uyeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UyeID,
            this.UyeAdi,
            this.UyeSAdi,
            this.UyeKAdi,
            this.UyeSifre,
            this.UyeDTarihi,
            this.UyeYas,
            this.UyeTel,
            this.uyeIDDataGridViewTextBoxColumn,
            this.uyeAdiDataGridViewTextBoxColumn,
            this.uyeSAdiDataGridViewTextBoxColumn,
            this.uyeKAdiDataGridViewTextBoxColumn,
            this.uyeSifreDataGridViewTextBoxColumn,
            this.uyeDTarihiDataGridViewTextBoxColumn,
            this.uyeTelDataGridViewTextBoxColumn,
            this.uyeYasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uyeBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(41, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.DividerHeight = 1;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 362);
            this.dataGridView1.TabIndex = 15;
            // 
            // UyeID
            // 
            this.UyeID.DataPropertyName = "UyeID";
            this.UyeID.HeaderText = "    ID";
            this.UyeID.Name = "UyeID";
            this.UyeID.ReadOnly = true;
            this.UyeID.Width = 90;
            // 
            // UyeAdi
            // 
            this.UyeAdi.DataPropertyName = "UyeAdi";
            this.UyeAdi.HeaderText = " Adı";
            this.UyeAdi.Name = "UyeAdi";
            this.UyeAdi.ReadOnly = true;
            this.UyeAdi.Width = 150;
            // 
            // UyeSAdi
            // 
            this.UyeSAdi.DataPropertyName = "UyeSAdi";
            this.UyeSAdi.HeaderText = "  Soyadı";
            this.UyeSAdi.Name = "UyeSAdi";
            this.UyeSAdi.ReadOnly = true;
            this.UyeSAdi.Width = 150;
            // 
            // UyeKAdi
            // 
            this.UyeKAdi.DataPropertyName = "UyeKAdi";
            this.UyeKAdi.HeaderText = " Kullanıcı Adı";
            this.UyeKAdi.Name = "UyeKAdi";
            this.UyeKAdi.ReadOnly = true;
            this.UyeKAdi.Width = 150;
            // 
            // UyeSifre
            // 
            this.UyeSifre.DataPropertyName = "UyeSifre";
            this.UyeSifre.HeaderText = " Şifre";
            this.UyeSifre.Name = "UyeSifre";
            this.UyeSifre.ReadOnly = true;
            this.UyeSifre.Width = 149;
            // 
            // UyeDTarihi
            // 
            this.UyeDTarihi.DataPropertyName = "UyeDTarihi";
            this.UyeDTarihi.HeaderText = "  Doğum Tarihi";
            this.UyeDTarihi.Name = "UyeDTarihi";
            this.UyeDTarihi.ReadOnly = true;
            this.UyeDTarihi.Width = 150;
            // 
            // UyeYas
            // 
            this.UyeYas.DataPropertyName = "UyeYas";
            this.UyeYas.HeaderText = "   Yaş";
            this.UyeYas.Name = "UyeYas";
            this.UyeYas.ReadOnly = true;
            this.UyeYas.Width = 115;
            // 
            // UyeTel
            // 
            this.UyeTel.DataPropertyName = "UyeTel";
            this.UyeTel.HeaderText = "  Telefon";
            this.UyeTel.Name = "UyeTel";
            this.UyeTel.ReadOnly = true;
            this.UyeTel.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(41, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kullanıcı Adına Göre Arama";
            // 
            // ceLearningTextbox1
            // 
            this.ceLearningTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.ceLearningTextbox1.Br = System.Drawing.Color.White;
            this.ceLearningTextbox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceLearningTextbox1.ForeColor = System.Drawing.Color.Black;
            this.ceLearningTextbox1.Location = new System.Drawing.Point(321, 140);
            this.ceLearningTextbox1.Name = "ceLearningTextbox1";
            this.ceLearningTextbox1.Size = new System.Drawing.Size(263, 28);
            this.ceLearningTextbox1.TabIndex = 19;
            this.ceLearningTextbox1.TextChanged += new System.EventHandler(this.ceLearningTextbox1_TextChanged);
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
            this.rjButton1.Location = new System.Drawing.Point(473, 564);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(277, 40);
            this.rjButton1.TabIndex = 17;
            this.rjButton1.Text = "Seçilen Üyeleri Çıkar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // uyeIDDataGridViewTextBoxColumn
            // 
            this.uyeIDDataGridViewTextBoxColumn.DataPropertyName = "UyeID";
            this.uyeIDDataGridViewTextBoxColumn.HeaderText = "UyeID";
            this.uyeIDDataGridViewTextBoxColumn.Name = "uyeIDDataGridViewTextBoxColumn";
            this.uyeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uyeAdiDataGridViewTextBoxColumn
            // 
            this.uyeAdiDataGridViewTextBoxColumn.DataPropertyName = "UyeAdi";
            this.uyeAdiDataGridViewTextBoxColumn.HeaderText = "UyeAdi";
            this.uyeAdiDataGridViewTextBoxColumn.Name = "uyeAdiDataGridViewTextBoxColumn";
            this.uyeAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uyeSAdiDataGridViewTextBoxColumn
            // 
            this.uyeSAdiDataGridViewTextBoxColumn.DataPropertyName = "UyeSAdi";
            this.uyeSAdiDataGridViewTextBoxColumn.HeaderText = "UyeSAdi";
            this.uyeSAdiDataGridViewTextBoxColumn.Name = "uyeSAdiDataGridViewTextBoxColumn";
            this.uyeSAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uyeKAdiDataGridViewTextBoxColumn
            // 
            this.uyeKAdiDataGridViewTextBoxColumn.DataPropertyName = "UyeKAdi";
            this.uyeKAdiDataGridViewTextBoxColumn.HeaderText = "UyeKAdi";
            this.uyeKAdiDataGridViewTextBoxColumn.Name = "uyeKAdiDataGridViewTextBoxColumn";
            this.uyeKAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uyeSifreDataGridViewTextBoxColumn
            // 
            this.uyeSifreDataGridViewTextBoxColumn.DataPropertyName = "UyeSifre";
            this.uyeSifreDataGridViewTextBoxColumn.HeaderText = "UyeSifre";
            this.uyeSifreDataGridViewTextBoxColumn.Name = "uyeSifreDataGridViewTextBoxColumn";
            this.uyeSifreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uyeDTarihiDataGridViewTextBoxColumn
            // 
            this.uyeDTarihiDataGridViewTextBoxColumn.DataPropertyName = "UyeDTarihi";
            this.uyeDTarihiDataGridViewTextBoxColumn.HeaderText = "UyeDTarihi";
            this.uyeDTarihiDataGridViewTextBoxColumn.Name = "uyeDTarihiDataGridViewTextBoxColumn";
            this.uyeDTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uyeTelDataGridViewTextBoxColumn
            // 
            this.uyeTelDataGridViewTextBoxColumn.DataPropertyName = "UyeTel";
            this.uyeTelDataGridViewTextBoxColumn.HeaderText = "UyeTel";
            this.uyeTelDataGridViewTextBoxColumn.Name = "uyeTelDataGridViewTextBoxColumn";
            this.uyeTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uyeYasDataGridViewTextBoxColumn
            // 
            this.uyeYasDataGridViewTextBoxColumn.DataPropertyName = "UyeYas";
            this.uyeYasDataGridViewTextBoxColumn.HeaderText = "UyeYas";
            this.uyeYasDataGridViewTextBoxColumn.Name = "uyeYasDataGridViewTextBoxColumn";
            this.uyeYasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form8
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1198, 627);
            this.Controls.Add(this.ceLearningTextbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form8";
            this.Text = "Üye Çıkar";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource kutuphaneOtomasyonuDataSetBindingSource;
        private KutuphaneOtomasyonuDataSet kutuphaneOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource emanetBindingSource;
        private KutuphaneOtomasyonuDataSetTableAdapters.EmanetTableAdapter emanetTableAdapter;
        private KutuphaneOtomasyonuDataSet1 kutuphaneOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource uyeBindingSource;
        private KutuphaneOtomasyonuDataSet1TableAdapters.UyeTableAdapter uyeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RJButton rjButton1;
        private System.Windows.Forms.Label label2;
        private CeLearningTextbox ceLearningTextbox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeSAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeKAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeSifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeDTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeYas;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeSAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeKAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeDTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeYasDataGridViewTextBoxColumn;
    }
}