using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtkayıtSistemi
{
    public partial class FrmOgrListesi : Form
    {
        public FrmOgrListesi()
        {
            InitializeComponent();
        }

        private void FrmOgrListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayıtDataSet4.Ogrenciler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogrencilerTableAdapter.Fill(this.yurtkayıtDataSet4.Ogrenciler);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDüzen fr = new FrmOgrDüzen();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.dogrum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.bölüm = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.odano = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            fr.veliad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            fr.velitel = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            fr.adres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            fr.Show();
        }
    }
}
