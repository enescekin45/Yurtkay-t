namespace YurtkayıtSistemi
{
    partial class FrmAnaFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaFrom));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öğrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciDüzenleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ödemeAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gidelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderİstatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirİstatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giderİstatistikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelinDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erişimKolaylığıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radyo3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yurtkayıtDataSet1 = new YurtkayıtSistemi.YurtkayıtDataSet1();
            this.ogrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrencilerTableAdapter = new YurtkayıtSistemi.YurtkayıtDataSet1TableAdapters.OgrencilerTableAdapter();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrOdaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrencilerToolStripMenuItem,
            this.bölümlerToolStripMenuItem,
            this.ödemelerToolStripMenuItem,
            this.gidelerToolStripMenuItem,
            this.istatistiklerToolStripMenuItem,
            this.yöneticiToolStripMenuItem,
            this.erişimKolaylığıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrencilerToolStripMenuItem
            // 
            this.öğrencilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciEkleToolStripMenuItem,
            this.öğrenciDüzenleToolStripMenuItem,
            this.öğrenciDüzenleToolStripMenuItem1});
            this.öğrencilerToolStripMenuItem.Name = "öğrencilerToolStripMenuItem";
            this.öğrencilerToolStripMenuItem.Size = new System.Drawing.Size(92, 23);
            this.öğrencilerToolStripMenuItem.Text = "Öğrenciler";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            this.öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            this.öğrenciEkleToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            // 
            // öğrenciDüzenleToolStripMenuItem
            // 
            this.öğrenciDüzenleToolStripMenuItem.Name = "öğrenciDüzenleToolStripMenuItem";
            this.öğrenciDüzenleToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.öğrenciDüzenleToolStripMenuItem.Text = "Öğrenci Listesi";
            // 
            // öğrenciDüzenleToolStripMenuItem1
            // 
            this.öğrenciDüzenleToolStripMenuItem1.Name = "öğrenciDüzenleToolStripMenuItem1";
            this.öğrenciDüzenleToolStripMenuItem1.Size = new System.Drawing.Size(191, 24);
            this.öğrenciDüzenleToolStripMenuItem1.Text = "Öğrenci Düzenle";
            // 
            // bölümlerToolStripMenuItem
            // 
            this.bölümlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bölümEkleToolStripMenuItem,
            this.bölümDüzenleToolStripMenuItem});
            this.bölümlerToolStripMenuItem.Name = "bölümlerToolStripMenuItem";
            this.bölümlerToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.bölümlerToolStripMenuItem.Text = "Bölümler";
            // 
            // bölümEkleToolStripMenuItem
            // 
            this.bölümEkleToolStripMenuItem.Name = "bölümEkleToolStripMenuItem";
            this.bölümEkleToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.bölümEkleToolStripMenuItem.Text = "Bölüm Ekle";
            // 
            // bölümDüzenleToolStripMenuItem
            // 
            this.bölümDüzenleToolStripMenuItem.Name = "bölümDüzenleToolStripMenuItem";
            this.bölümDüzenleToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.bölümDüzenleToolStripMenuItem.Text = "Bölüm Düzenle";
            // 
            // ödemelerToolStripMenuItem
            // 
            this.ödemelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ödemeAlToolStripMenuItem});
            this.ödemelerToolStripMenuItem.Name = "ödemelerToolStripMenuItem";
            this.ödemelerToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.ödemelerToolStripMenuItem.Text = "Ödemeler";
            // 
            // ödemeAlToolStripMenuItem
            // 
            this.ödemeAlToolStripMenuItem.Name = "ödemeAlToolStripMenuItem";
            this.ödemeAlToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.ödemeAlToolStripMenuItem.Text = "Ödeme Al";
            // 
            // gidelerToolStripMenuItem
            // 
            this.gidelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giderEkleToolStripMenuItem,
            this.giderİstatistiklerToolStripMenuItem});
            this.gidelerToolStripMenuItem.Name = "gidelerToolStripMenuItem";
            this.gidelerToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.gidelerToolStripMenuItem.Text = "Giderler";
            // 
            // giderEkleToolStripMenuItem
            // 
            this.giderEkleToolStripMenuItem.Name = "giderEkleToolStripMenuItem";
            this.giderEkleToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.giderEkleToolStripMenuItem.Text = "Gider Ekle";
            // 
            // giderİstatistiklerToolStripMenuItem
            // 
            this.giderİstatistiklerToolStripMenuItem.Name = "giderİstatistiklerToolStripMenuItem";
            this.giderİstatistiklerToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.giderİstatistiklerToolStripMenuItem.Text = "Gider Listesi";
            // 
            // istatistiklerToolStripMenuItem
            // 
            this.istatistiklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirİstatistiklerToolStripMenuItem,
            this.giderİstatistikleriToolStripMenuItem});
            this.istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            this.istatistiklerToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.istatistiklerToolStripMenuItem.Text = "istatistikler";
            // 
            // gelirİstatistiklerToolStripMenuItem
            // 
            this.gelirİstatistiklerToolStripMenuItem.Name = "gelirİstatistiklerToolStripMenuItem";
            this.gelirİstatistiklerToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.gelirİstatistiklerToolStripMenuItem.Text = "Gelir istatistikleri";
            // 
            // giderİstatistikleriToolStripMenuItem
            // 
            this.giderİstatistikleriToolStripMenuItem.Name = "giderİstatistikleriToolStripMenuItem";
            this.giderİstatistikleriToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.giderİstatistikleriToolStripMenuItem.Text = "Gider istatistikleri";
            // 
            // yöneticiToolStripMenuItem
            // 
            this.yöneticiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreİşlemleriToolStripMenuItem,
            this.personelinDüzenlemeToolStripMenuItem});
            this.yöneticiToolStripMenuItem.Name = "yöneticiToolStripMenuItem";
            this.yöneticiToolStripMenuItem.Size = new System.Drawing.Size(76, 23);
            this.yöneticiToolStripMenuItem.Text = "Yönetici";
            // 
            // şifreİşlemleriToolStripMenuItem
            // 
            this.şifreİşlemleriToolStripMenuItem.Name = "şifreİşlemleriToolStripMenuItem";
            this.şifreİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.şifreİşlemleriToolStripMenuItem.Text = "Şifre İşlemleri";
            // 
            // personelinDüzenlemeToolStripMenuItem
            // 
            this.personelinDüzenlemeToolStripMenuItem.Name = "personelinDüzenlemeToolStripMenuItem";
            this.personelinDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.personelinDüzenlemeToolStripMenuItem.Text = "Personel  Düzenleme";
            // 
            // erişimKolaylığıToolStripMenuItem
            // 
            this.erişimKolaylığıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.paintToolStripMenuItem,
            this.radyolarToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.çıkışToolStripMenuItem1});
            this.erişimKolaylığıToolStripMenuItem.Name = "erişimKolaylığıToolStripMenuItem";
            this.erişimKolaylığıToolStripMenuItem.Size = new System.Drawing.Size(124, 23);
            this.erişimKolaylığıToolStripMenuItem.Text = "Erişim Kolaylığı";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.paintToolStripMenuItem.Text = "Paint";
            // 
            // radyolarToolStripMenuItem
            // 
            this.radyolarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.radyo1ToolStripMenuItem,
            this.radyo2ToolStripMenuItem,
            this.radyo3ToolStripMenuItem});
            this.radyolarToolStripMenuItem.Name = "radyolarToolStripMenuItem";
            this.radyolarToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.radyolarToolStripMenuItem.Text = "Radyolar";
            // 
            // radyo1ToolStripMenuItem
            // 
            this.radyo1ToolStripMenuItem.Name = "radyo1ToolStripMenuItem";
            this.radyo1ToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.radyo1ToolStripMenuItem.Text = "Radyo 1";
            // 
            // radyo2ToolStripMenuItem
            // 
            this.radyo2ToolStripMenuItem.Name = "radyo2ToolStripMenuItem";
            this.radyo2ToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.radyo2ToolStripMenuItem.Text = "Radyo 2";
            // 
            // radyo3ToolStripMenuItem
            // 
            this.radyo3ToolStripMenuItem.Name = "radyo3ToolStripMenuItem";
            this.radyo3ToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.radyo3ToolStripMenuItem.Text = "Radyo 3";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.çıkışToolStripMenuItem.Text = "Hakkımızda";
            // 
            // çıkışToolStripMenuItem1
            // 
            this.çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            this.çıkışToolStripMenuItem1.Size = new System.Drawing.Size(187, 24);
            this.çıkışToolStripMenuItem1.Text = "Çıkış";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrOdaNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrencilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 355);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // yurtkayıtDataSet1
            // 
            this.yurtkayıtDataSet1.DataSetName = "YurtkayıtDataSet1";
            this.yurtkayıtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencilerBindingSource
            // 
            this.ogrencilerBindingSource.DataMember = "Ogrenciler";
            this.ogrencilerBindingSource.DataSource = this.yurtkayıtDataSet1;
            // 
            // ogrencilerTableAdapter
            // 
            this.ogrencilerTableAdapter.ClearBeforeFill = true;
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "Ogrid";
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrOdaNoDataGridViewTextBoxColumn
            // 
            this.ogrOdaNoDataGridViewTextBoxColumn.DataPropertyName = "OgrOdaNo";
            this.ogrOdaNoDataGridViewTextBoxColumn.HeaderText = "OgrOdaNo";
            this.ogrOdaNoDataGridViewTextBoxColumn.Name = "ogrOdaNoDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(496, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(544, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAnaFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAnaFrom";
            this.Text = "FrmAnaFrom";
            this.Load += new System.EventHandler(this.FrmAnaFrom_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciDüzenleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bölümlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ödemeAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gidelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderİstatistiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirİstatistiklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giderİstatistikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelinDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erişimKolaylığıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radyo3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtkayıtDataSet1 yurtkayıtDataSet1;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource;
        private YurtkayıtDataSet1TableAdapters.OgrencilerTableAdapter ogrencilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrOdaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}