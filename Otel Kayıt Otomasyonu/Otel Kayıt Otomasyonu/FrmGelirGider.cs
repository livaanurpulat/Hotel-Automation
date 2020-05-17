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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=TasKonakOteli;Integrated Security=True");

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            //personel maaş hesaplama
            int personel;
            personel = Convert.ToInt16(TxtBoxPersonel.Text);
            LblPersonel.Text = (personel * 2000).ToString();

            int hesap;
            hesap = Convert.ToInt32(LblKasa.Text)-(Convert.ToInt32(LblPersonel.Text)+Convert.ToInt32(LblGida.Text)+Convert.ToInt32(Lblİcecek.Text)+Convert.ToInt32(LblElektrik.Text)+Convert.ToInt32(LblDogalgaz.Text)+Convert.ToInt32(LblSu.Text)+Convert.ToInt32(Lblinternet.Text));
            LblHesap.Text = hesap.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //kasadaki toplam parayı hesaplamak için MusteriKayit tablosu üzerinden toplatma işlemi:
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(ucret) as toplam from MusteriKayit", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasa.Text = oku["toplam"].ToString();

            }
            baglanti.Close();

            //Gıda Giderleri
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select sum(Gida) as toplam1 from MutfakHarcama", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                LblGida.Text = oku1["toplam1"].ToString();

            }
            baglanti.Close();

            //İçecek Giderleri
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(İcecek) as toplam2 from MutfakHarcama", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                Lblİcecek.Text = oku2["toplam2"].ToString();

            }
            baglanti.Close();

            //Elektrik Giderleri
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(Elektrik) as toplam3 from Faturalar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblElektrik.Text = oku3["toplam3"].ToString();

            }
            baglanti.Close();

            //Doğalgaz Giderleri
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Doğalgaz) as toplam4 from Faturalar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblDogalgaz.Text = oku4["toplam4"].ToString();

            }
            baglanti.Close();

            //Su Giderleri
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Su) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblSu.Text = oku5["toplam5"].ToString();

            }
            baglanti.Close();

            //İnternet Giderleri
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(İnternet) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                Lblinternet.Text = oku6["toplam6"].ToString();

            }
            baglanti.Close();

        }
    }
}
