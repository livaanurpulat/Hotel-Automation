using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Kayıt_Otomasyonu
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            //Admin Giriş butonuna tıklandığında giriş ekranına yönlendirir:
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnYeniMusteri_Click(object sender, EventArgs e)
        {
            //Yeni Müşteri butonuna tıklandığında müşteri ekleme formuna yönlendirir:
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGlrGdr_Click(object sender, EventArgs e)
        {
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            FrmAylikHarcama fr = new FrmAylikHarcama();
            fr.Show();
        }
    }
}
