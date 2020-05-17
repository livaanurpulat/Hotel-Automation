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
    public partial class FrmAylikHarcama : Form
    {
        public FrmAylikHarcama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=TasKonakOteli;Integrated Security=True");
        //MutfakHarcamaları içi erişim belirleyici
        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from MutfakHarcama", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["İcecek"].ToString());
                listView1.Items.Add(ekle);
                  

            }
            baglanti.Close();
        }

        //Faturalar için erişim belirleyici
        private void veriler2()
        {
            listView2.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select*from Faturalar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Doğalgaz"].ToString());
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["İnternet"].ToString());
                listView2.Items.Add(ekle);


            }
            baglanti.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MutfakHarcama(Gida,İcecek) values('" + TxtGida.Text + "','" + TxtIcecek.Text + "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();

            TxtGida.Clear();
            TxtIcecek.Clear();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void BtnKaydet2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Faturalar(Elektrik,Doğalgaz,Su,İnternet) values('" + TxtElektrik.Text + "','" + TxtDogalgaz.Text + "','" + TxtSu.Text + "','" + TxtInternet.Text + "')", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            veriler2();

            TxtGida.Clear();
            TxtIcecek.Clear();
        }
    }
}
