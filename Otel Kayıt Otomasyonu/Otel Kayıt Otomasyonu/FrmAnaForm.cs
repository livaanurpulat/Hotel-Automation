/****************************************************************************
**                         SAKARYA ÜNİVERSİTESİ
**               BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                 BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                    NESNEYE DAYALI PROGRAMLAMA DERSİ
**                        2019-2020 BAHAR DÖNEMİ
**
**                      PROJE NUMARASI.........: 01
**                      ÖĞRENCİ ADI............: LİVA NUR PULAT
**                      ÖĞRENCİ NUMARASI.......: B191200371
**                      DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
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
            //Admin Giriş butonuna tıklandığında giriş ekranına yönlendirir.
            FrmAdminGiris fr = new FrmAdminGiris();
            fr.Show();
            this.Hide();
        }

        private void BtnYeniMusteri_Click(object sender, EventArgs e)
        {
            //Yeni Müşteri butonuna tıklandığında müşteri ekleme formuna yönlendirir.
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Müşteriler butonuna tıklandığında müşterileri gösteren forma yönlendirir.
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            //Odalar formuna yönlendirir.
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            //çıkış butonu uygulamayı sonlandırır.
            Application.Exit();
        }

        private void BtnGlrGdr_Click(object sender, EventArgs e)
        {
            //Gelir Gider formuna yönlendirir.
            FrmGelirGider fr = new FrmGelirGider();
            fr.Show();
        }

        private void BtnStok_Click(object sender, EventArgs e)
        {
            //Aylık Harcamalar formuna yönlendirir.
            FrmAylikHarcama fr = new FrmAylikHarcama();
            fr.Show();
        }
    }
}
