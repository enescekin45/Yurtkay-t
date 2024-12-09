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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtOgrMail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            //Bölümleri Listeleme Komutları
           
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolum", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                combBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            //Boş Odaları Listeleme Komutları
           
            SqlCommand komut2 = new SqlCommand("Select OdaNo From Odalar Where OdaKapasite!=OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                combOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand komutKaydet = new SqlCommand("insert into Ogrenciler (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogrum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrAdres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutKaydet.Parameters.AddWithValue("@P1", TxtOgrAd.Text);
                komutKaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p3", MskTC.Text);
                komutKaydet.Parameters.AddWithValue("@p4", MskOgrTelefon.Text);
                komutKaydet.Parameters.AddWithValue("@p5", MskDogrum.Text);
                komutKaydet.Parameters.AddWithValue("@p6", combBolum.Text);
                komutKaydet.Parameters.AddWithValue("@p7", TxtOgrMail.Text);
                komutKaydet.Parameters.AddWithValue("@p8", combOdaNo.Text);
                komutKaydet.Parameters.AddWithValue("@p9", TxtVeliAdSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p10", MskVeliTelefon.Text);
                komutKaydet.Parameters.AddWithValue("@p11", RchAdres.Text);
                komutKaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Eklendi ");

                SqlCommand komut = new SqlCommand("SELECT Ogrid FROM Ogrenciler", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString(); // Veriyi label'a yazdırıyoruz
                }
                bgl.baglanti().Close();


                //Ögrenci Borc Alanı Oluştuma Alanı 
                SqlCommand komutkaydet2 = new SqlCommand("insert into Borclar(Ogrid,OgrAd,OgrSoyad)values(@b1,@b2,@b3)",bgl.baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", TxtOgrAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", TxtOgrSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!! Lütfen yeniden deneyin");
            }

        }
    }
}
