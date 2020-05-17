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
using System.Data.Sql;
using System.Data.SqlClient;

namespace Otel_Kayıt_Otomasyonu
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        //veri tabanı bağlantı kodu:
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=TasKonakOteli;Integrated Security=True");

        //erişim belirleyici:
        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            //MusteriKayit tablosuyla bağlantı kodu:
            SqlCommand komut = new SqlCommand("select * from MusteriKayit", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            //oku komutu çalıştığı müddetçe listview'e verileri ekle.
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());

                listView1.Items.Add(ekle);
                   
            }
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        //listview'e çift tıklandığında müşteri bilgilerinin textboxlara gelmesi:
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CmBoxCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTcNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Kayıt silme işlemi yapıldığında odalar için oluşturulan tablolardan temizleme: 
            if(TxtOdaNo.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "201")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda201", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "202")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda202", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "203")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda203", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "301")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda301", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "302")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda302", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }

            if (TxtOdaNo.Text == "303")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda303", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            CmBoxCinsiyet.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Clear();
            TxtTcNo.Clear();
            TxtOdaNo.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
            TxtUcret.Clear();

        }

        //Müşteri bilgileri güncellenmek için.
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriKayit set Ad='" + TxtAdi.Text + "',Soyad='" + TxtSoyadi.Text + "',Cinsiyet='" + CmBoxCinsiyet.Text + "',Telefon='" + MskTxtTelefon.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtTcNo.Text + "',OdaNo='" + TxtOdaNo.Text + "',GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "',Ucret='" + TxtUcret.Text + "' where MusteriId=" + id +"", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();

        }

        //Kayıtlı müşterilerde arama yapma.
        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            //Kayıtlı müşteriler içinde Ad'a göre arama kodu:
            SqlCommand komut = new SqlCommand("select * from MusteriKayit where Ad like '%" +textBox1.Text+"%'" , baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            //oku komutu çalıştığı müddetçe listview'e verileri ekle.
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
    }
}


