namespace YurtkayıtSistemi
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.pcbBolumEkle = new System.Windows.Forms.PictureBox();
            this.pcbBolumSil = new System.Windows.Forms.PictureBox();
            this.pcbBolumDüzenle = new System.Windows.Forms.PictureBox();
            this.TxtBolumid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBolumAd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtkayıtDataSet = new YurtkayıtSistemi.YurtkayıtDataSet();
            this.bolumTableAdapter = new YurtkayıtSistemi.YurtkayıtDataSetTableAdapters.BolumTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumDüzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbBolumEkle
            // 
            this.pcbBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumEkle.Image")));
            this.pcbBolumEkle.Location = new System.Drawing.Point(314, 12);
            this.pcbBolumEkle.Name = "pcbBolumEkle";
            this.pcbBolumEkle.Size = new System.Drawing.Size(70, 37);
            this.pcbBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBolumEkle.TabIndex = 0;
            this.pcbBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumEkle, "Bölüm Ekle");
            this.pcbBolumEkle.Click += new System.EventHandler(this.pcbBolumEkle_Click);
            // 
            // pcbBolumSil
            // 
            this.pcbBolumSil.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumSil.Image")));
            this.pcbBolumSil.Location = new System.Drawing.Point(390, 12);
            this.pcbBolumSil.Name = "pcbBolumSil";
            this.pcbBolumSil.Size = new System.Drawing.Size(70, 37);
            this.pcbBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBolumSil.TabIndex = 0;
            this.pcbBolumSil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumSil, "Bölüm Sil");
            this.pcbBolumSil.Click += new System.EventHandler(this.pcbBolumSil_Click);
            // 
            // pcbBolumDüzenle
            // 
            this.pcbBolumDüzenle.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumDüzenle.Image")));
            this.pcbBolumDüzenle.Location = new System.Drawing.Point(346, 55);
            this.pcbBolumDüzenle.Name = "pcbBolumDüzenle";
            this.pcbBolumDüzenle.Size = new System.Drawing.Size(70, 37);
            this.pcbBolumDüzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBolumDüzenle.TabIndex = 0;
            this.pcbBolumDüzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumDüzenle, "Bölüm Güncelle");
            this.pcbBolumDüzenle.Click += new System.EventHandler(this.pcbBolumDüzenle_Click);
            // 
            // TxtBolumid
            // 
            this.TxtBolumid.Enabled = false;
            this.TxtBolumid.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBolumid.Location = new System.Drawing.Point(97, 10);
            this.TxtBolumid.Name = "TxtBolumid";
            this.TxtBolumid.Size = new System.Drawing.Size(190, 27);
            this.TxtBolumid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bölüm id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bölüm Ad:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtBolumAd
            // 
            this.TxtBolumAd.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBolumAd.Location = new System.Drawing.Point(101, 53);
            this.TxtBolumAd.Name = "TxtBolumAd";
            this.TxtBolumAd.Size = new System.Drawing.Size(190, 27);
            this.TxtBolumAd.TabIndex = 3;
            this.TxtBolumAd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-11, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 225);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumBindingSource
            // 
            this.bolumBindingSource.DataMember = "Bolum";
            this.bolumBindingSource.DataSource = this.yurtkayıtDataSet;
            // 
            // yurtkayıtDataSet
            // 
            this.yurtkayıtDataSet.DataSetName = "YurtkayıtDataSet";
            this.yurtkayıtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumTableAdapter
            // 
            this.bolumTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 363);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBolumAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBolumid);
            this.Controls.Add(this.pcbBolumDüzenle);
            this.Controls.Add(this.pcbBolumSil);
            this.Controls.Add(this.pcbBolumEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bolumler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumDüzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtkayıtDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbBolumEkle;
        private System.Windows.Forms.PictureBox pcbBolumSil;
        private System.Windows.Forms.PictureBox pcbBolumDüzenle;
        private System.Windows.Forms.TextBox TxtBolumid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBolumAd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtkayıtDataSet yurtkayıtDataSet;
        private System.Windows.Forms.BindingSource bolumBindingSource;
        private YurtkayıtDataSetTableAdapters.BolumTableAdapter bolumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}