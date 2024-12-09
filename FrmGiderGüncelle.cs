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
    public partial class FrmGiderGüncelle : Form
    {
        public FrmGiderGüncelle()
        {
            InitializeComponent();
        }

        public string Elektrik, su, Dogalgaz, internet, Gıda, personel, Diger,id;
        private void FrmGiderGüncelle_Load(object sender, EventArgs e)
        {
            Txtgiderid.Text = id;
            TxtElektirik.Text = Elektrik;
            TxtSu.Text = su;
            Txtdogal.Text = Dogalgaz;
            Txtinternet.Text = internet;
            TxtGıda.Text = Gıda;
            TxtPersonel.Text = personel;
            TxtDiger.Text = Diger;
        }
    }
}
