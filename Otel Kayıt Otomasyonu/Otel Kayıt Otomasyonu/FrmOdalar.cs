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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=TasKonakOteli;Integrated Security=True");

        //Odalar formunda dolu odalardaki müşteri bilgilerini gösterir ve dolu odalar belirlenen renkte gözükür:
        private void FrmOdalar_Load(object sender, EventArgs e)
        {

            //Oda 101
           baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                BtnOda101.Text = oku1["Ad"].ToString() + " " + oku1["Soyad"].ToString() ;
            }
            baglanti.Close();
            if(BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.RoyalBlue;
            }

            //Oda 102
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BtnOda102.Text = oku2["Ad"].ToString() + " " + oku2["Soyad"].ToString();
            }
            baglanti.Close();
            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.RoyalBlue;
            }

            //Oda 103
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                BtnOda103.Text = oku3["Ad"].ToString() + " " + oku3["Soyad"].ToString();
            }
            baglanti.Close();
            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.RoyalBlue;
            }

            //Oda 201
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda201", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                BtnOda201.Text = oku4["Ad"].ToString() + " " + oku4["Soyad"].ToString();
            }
            baglanti.Close();
            if (BtnOda201.Text != "201")
            {
                BtnOda201.BackColor = Color.RoyalBlue;
            }

            //Oda 202
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda202", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                BtnOda202.Text = oku5["Ad"].ToString() + " " + oku5["Soyad"].ToString();
            }
            baglanti.Close();
            if (BtnOda202.Text != "202")
            {
                BtnOda202.BackColor = Color.RoyalBlue;
            }

            //Oda 203
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda203", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                BtnOda203.Text = oku6["Ad"].ToString() + " " + oku6["Soyad"].ToString();
            }
            baglanti.Close();
            if (BtnOda203.Text != "203")
            {
                BtnOda203.BackColor = Color.RoyalBlue;
            }

            //Oda 301
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda301", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                BtnOda301.Text = oku7["Ad"].ToString() + " " + oku7["Soyad"].ToString();
            }
            baglanti.Close();
            if (BtnOda301.Text != "301")
            {
                BtnOda301.BackColor = Color.RoyalBlue;
            }

            //Oda 302
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda302", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                BtnOda302.Text = oku8["Ad"].ToString() + " " + oku8["Soyad"].ToString();
            }
            baglanti.Close();
            if (BtnOda302.Text != "302")
            {
                BtnOda302.BackColor = Color.RoyalBlue;
            }

            //Oda 303
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda303", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                BtnOda303.Text = oku9["Ad"].ToString() + " " + oku9["Soyad"].ToString();
            }
            baglanti.Close();
            if (BtnOda303.Text != "303")
            {
                BtnOda303.BackColor = Color.RoyalBlue;
            }
        }
    }
}
