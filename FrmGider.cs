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
    public partial class FrmGider : Form
    {
        
        public FrmGider()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmGider_Load(object sender, EventArgs e)
        {
            

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Gider (Elektrik,su,Dogalgaz,internet,Gıda,personel,Diger) Values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtElektirik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", Txtdogal.Text);
                komut.Parameters.AddWithValue("@p4", Txtinternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGıda.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("kayıtlar Eklendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! oluştu yeniden deneyin");
            }
        }
    }
}
