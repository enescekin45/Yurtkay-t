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
    public partial class FrmAnaFrom : Form
    {
        public FrmAnaFrom()
        {
            InitializeComponent();
        }

        private void FrmAnaFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtkayıtDataSet1.Ogrenciler' table. You can move, or remove it, as needed.
            this.ogrencilerTableAdapter.Fill(this.yurtkayıtDataSet1.Ogrenciler);
            timer1.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongDateString();
        }
    }
}
