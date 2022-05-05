
namespace KütüphaneOtomasyonu
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uyeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeSAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeKAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeDTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeYasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyelikTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneOtomasyonuDataSet4 = new KütüphaneOtomasyonu.KutuphaneOtomasyonuDataSet4();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uyeTableAdapter = new KütüphaneOtomasyonu.KutuphaneOtomasyonuDataSet4TableAdapters.UyeTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ceLearningTextbox1 = new KütüphaneOtomasyonu.CeLearningTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.ImageKey = "Untitled.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(50, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 38);
            this.button2.TabIndex = 13;
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
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(406, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 72);
            this.label1.TabIndex = 15;
            this.label1.Text = "Üye Arama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uyeIDDataGridViewTextBoxColumn,
            this.uyeAdiDataGridViewTextBoxColumn,
            this.uyeSAdiDataGridViewTextBoxColumn,
            this.uyeKAdiDataGridViewTextBoxColumn,
            this.uyeSifreDataGridViewTextBoxColumn,
            this.uyeDTarihiDataGridViewTextBoxColumn,
            this.uyeTelDataGridViewTextBoxColumn,
            this.uyeYasDataGridViewTextBoxColumn,
            this.uyelikTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uyeBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(50, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1106, 339);
            this.dataGridView1.TabIndex = 16;
            // 
            // uyeIDDataGridViewTextBoxColumn
            // 
            this.uyeIDDataGridViewTextBoxColumn.DataPropertyName = "UyeID";
            this.uyeIDDataGridViewTextBoxColumn.HeaderText = "   ID";
            this.uyeIDDataGridViewTextBoxColumn.Name = "uyeIDDataGridViewTextBoxColumn";
            this.uyeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uyeIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // uyeAdiDataGridViewTextBoxColumn
            // 
            this.uyeAdiDataGridViewTextBoxColumn.DataPropertyName = "UyeAdi";
            this.uyeAdiDataGridViewTextBoxColumn.HeaderText = " Adı";
            this.uyeAdiDataGridViewTextBoxColumn.Name = "uyeAdiDataGridViewTextBoxColumn";
            this.uyeAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.uyeAdiDataGridViewTextBoxColumn.Width = 130;
            // 
            // uyeSAdiDataGridViewTextBoxColumn
            // 
            this.uyeSAdiDataGridViewTextBoxColumn.DataPropertyName = "UyeSAdi";
            this.uyeSAdiDataGridViewTextBoxColumn.HeaderText = "  Soyadı";
            this.uyeSAdiDataGridViewTextBoxColumn.Name = "uyeSAdiDataGridViewTextBoxColumn";
            this.uyeSAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.uyeSAdiDataGridViewTextBoxColumn.Width = 130;
            // 
            // uyeKAdiDataGridViewTextBoxColumn
            // 
            this.uyeKAdiDataGridViewTextBoxColumn.DataPropertyName = "UyeKAdi";
            this.uyeKAdiDataGridViewTextBoxColumn.HeaderText = " Kullanıcı Adı";
            this.uyeKAdiDataGridViewTextBoxColumn.Name = "uyeKAdiDataGridViewTextBoxColumn";
            this.uyeKAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.uyeKAdiDataGridViewTextBoxColumn.Width = 130;
            // 
            // uyeSifreDataGridViewTextBoxColumn
            // 
            this.uyeSifreDataGridViewTextBoxColumn.DataPropertyName = "UyeSifre";
            this.uyeSifreDataGridViewTextBoxColumn.HeaderText = "  Şifre";
            this.uyeSifreDataGridViewTextBoxColumn.Name = "uyeSifreDataGridViewTextBoxColumn";
            this.uyeSifreDataGridViewTextBoxColumn.ReadOnly = true;
            this.uyeSifreDataGridViewTextBoxColumn.Width = 129;
            // 
            // uyeDTarihiDataGridViewTextBoxColumn
            // 
            this.uyeDTarihiDataGridViewTextBoxColumn.DataPropertyName = "UyeDTarihi";
            this.uyeDTarihiDataGridViewTextBoxColumn.HeaderText = "   Doğum Tarihi";
            this.uyeDTarihiDataGridViewTextBoxColumn.Name = "uyeDTarihiDataGridViewTextBoxColumn";
            this.uyeDTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.uyeDTarihiDataGridViewTextBoxColumn.Width = 140;
            // 
            // uyeTelDataGridViewTextBoxColumn
            // 
            this.uyeTelDataGridViewTextBoxColumn.DataPropertyName = "UyeTel";
            this.uyeTelDataGridViewTextBoxColumn.HeaderText = "   Telefon";
            this.uyeTelDataGridViewTextBoxColumn.Name = "uyeTelDataGridViewTextBoxColumn";
            this.uyeTelDataGridViewTextBoxColumn.ReadOnly = true;
            this.uyeTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyeYasDataGridViewTextBoxColumn
            // 
            this.uyeYasDataGridViewTextBoxColumn.DataPropertyName = "UyeYas";
            this.uyeYasDataGridViewTextBoxColumn.HeaderText = "   Yaş";
            this.uyeYasDataGridViewTextBoxColumn.Name = "uyeYasDataGridViewTextBoxColumn";
            this.uyeYasDataGridViewTextBoxColumn.ReadOnly = true;
            this.uyeYasDataGridViewTextBoxColumn.Width = 115;
            // 
            // uyelikTarihiDataGridViewTextBoxColumn
            // 
            this.uyelikTarihiDataGridViewTextBoxColumn.DataPropertyName = "UyelikTarihi";
            this.uyelikTarihiDataGridViewTextBoxColumn.HeaderText = " Üyelik Tarihi";
            this.uyelikTarihiDataGridViewTextBoxColumn.Name = "uyelikTarihiDataGridViewTextBoxColumn";
            this.uyelikTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.uyelikTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // uyeBindingSource
            // 
            this.uyeBindingSource.DataMember = "Uye";
            this.uyeBindingSource.DataSource = this.kutuphaneOtomasyonuDataSet4;
            // 
            // kutuphaneOtomasyonuDataSet4
            // 
            this.kutuphaneOtomasyonuDataSet4.DataSetName = "KutuphaneOtomasyonuDataSet4";
            this.kutuphaneOtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Ad",
            "Soyad",
            "Kullanıcı Adı"});
            this.comboBox1.Location = new System.Drawing.Point(222, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(321, 27);
            this.comboBox1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Arama Kategorisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(721, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ara";
            // 
            // uyeTableAdapter
            // 
            this.uyeTableAdapter.ClearBeforeFill = true;
            // 
            // ceLearningTextbox1
            // 
            this.ceLearningTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.ceLearningTextbox1.Br = System.Drawing.Color.White;
            this.ceLearningTextbox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceLearningTextbox1.ForeColor = System.Drawing.Color.Black;
            this.ceLearningTextbox1.Location = new System.Drawing.Point(780, 202);
            this.ceLearningTextbox1.Name = "ceLearningTextbox1";
            this.ceLearningTextbox1.Size = new System.Drawing.Size(376, 28);
            this.ceLearningTextbox1.TabIndex = 22;
            this.ceLearningTextbox1.TextChanged += new System.EventHandler(this.ceLearningTextbox1_TextChanged);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1198, 627);
            this.Controls.Add(this.ceLearningTextbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form10";
            this.Text = "Üye Arama";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneOtomasyonuDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private KutuphaneOtomasyonuDataSet4 kutuphaneOtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource uyeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeSAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeKAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeSifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeDTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyeYasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyelikTarihiDataGridViewTextBoxColumn;
        private KütüphaneOtomasyonu.KutuphaneOtomasyonuDataSet4TableAdapters.UyeTableAdapter uyeTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public CeLearningTextbox ceLearningTextbox1;
    }
}