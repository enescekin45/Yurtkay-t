using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace YurtkayıtSistemi
{
    public partial class Frmödemeler : Form
    {
        sqlbaglanti bgl = new sqlbaglanti();
        public Frmödemeler()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frmödemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtkayıtDataSet3.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter1.Fill(this.yurtkayıtDataSet3.Borclar);
            // TODO: Bu kod satırı 'yurtkayıtDataSet2.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.yurtkayıtDataSet2.Borclar);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frmödemeler_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TxtAd.Text = ad;
            TxtSoyad.Text = soyad;
            TxtKalan.Text = kalan;
            TxtOgrencid.Text = id;

        }

        private void BtnOdemeAl_Click(object sender, EventArgs e)
        {
            //ödenen tutarı kalan tutardan düşme
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(TxtOdeme.Text);
            kalan = Convert.ToInt16(TxtKalan.Text);
            yeniborc = kalan - odenen;
            TxtKalan.Text = yeniborc.ToString();

            //Yeni tutarı veri tabanına kaydetme
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where Ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtOgrencid.Text);
            komut.Parameters.AddWithValue("@P1", TxtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi");
            this.borclarTableAdapter1.Fill(this.yurtkayıtDataSet3.Borclar);

        }
    }
}
