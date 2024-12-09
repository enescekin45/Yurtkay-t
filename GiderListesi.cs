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
    public partial class GiderListesi : Form
    {
        public GiderListesi()
        {
            InitializeComponent();
        }

        private void GiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayıtDataSet5.Gider' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.giderTableAdapter.Fill(this.yurtkayıtDataSet5.Gider);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            FrmGiderGüncelle frg = new FrmGiderGüncelle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frg.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frg.Elektrik= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frg.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frg.Dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frg.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frg.Gıda = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frg.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frg.Diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frg.Show();
        }
    }
}
