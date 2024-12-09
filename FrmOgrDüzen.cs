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
    public partial class FrmOgrDüzen : Form
    {
        public FrmOgrDüzen()
        {
            InitializeComponent();
        }

        public string id, ad, soyad, TC, telefon, dogrum, bölüm, mail, odano, veliad, velitel, adres;



        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmOgrDüzen_Load(object sender, EventArgs e)
        {
            Txtogrid.Text = id;
            maskedTextBox1.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskTC.Text = TC;
            MskOgrTelefon.Text = telefon;
            MskDogrum.Text = dogrum;
            combBolum.Text = bölüm;
            TxtOgrMail.Text = mail;
            combOdaNo.Text = odano;
            TxtVeliAdSoyad.Text = veliad;
            MskVeliTelefon.Text = velitel;
            RchAdres.Text = adres;
        }
        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenciler set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogrum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrAdres=@p12 where Ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Txtogrid.Text);
                komut.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
                komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", MskTC.Text);
                komut.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
                komut.Parameters.AddWithValue("@p6", MskDogrum.Text);
                komut.Parameters.AddWithValue("@p7", combBolum.Text);
                komut.Parameters.AddWithValue("@p8", TxtOgrMail.Text);
                komut.Parameters.AddWithValue("@p9", combOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", TxtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", MskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", RchAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("kayıt Güncellendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!,Yeniden Deneyin");
            }
        }

    }
}
