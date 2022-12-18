using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace fitnesproje
{
    class dbislemleri
    {
        SqlConnection baglan;
        SqlCommand komut;
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand com = new SqlCommand();
        DataSet ds = new DataSet();
        public string sonuc;
        public dbislemleri()
        {
            string baglanti = "server=4ZR4L1N1Z\\SQLEXPRESS; database= fitnesapp;user=omer;password=adolfömer;";
            baglan = new SqlConnection(baglanti);
            baglan.Open();
        }

        public string kgiriskontrol(string kadi, string sifre)
        {
            string sql = "select ad+' '+soyad as adsoyad from kayit where kullaniciad='" +
                kadi + "' and sifre='" + sifre + "'";
            komut = new SqlCommand(sql, baglan);
           sonuc = (string)komut.ExecuteScalar();
            return sonuc;
        }
        public DataSet kullanicitablogetir()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("select * from kayit ", baglan);
            sda.Fill(ds);
            return ds;
        }

        public int calisanelekle(string tc, string ad, string soyad, string adres, string yteki, int yas, string isBaslama, string dogumtarih, string brans)
        {
            string sqli = "insert into calisanlar(ad,soyad,Tc,isBaslama,adres,yetki,yas,dogumtarih,brans) values('" + ad + "','" + soyad
                + "','" + tc + "','" + isBaslama + "','" + adres + "','" + yteki + "','" + yas + "','" + dogumtarih + "','" + brans + "')";
            komut = new SqlCommand(sqli, baglan);
            int sonuc = (int)komut.ExecuteNonQuery();
            return sonuc;
        }
        public int uyeekle(string tc, string ad, string soyad, string adres, string kullaniciad, string sifree, int yas, int kilo, int boy,string tarih, string cinsiyet, string saglik_durumu,string tel_no,string email,int kayit_süre)
        {
            string sqli = "insert into kayit (kullaniciad,sifre,ad,soyad,yas,kilo,boy,cinsiyet,saglik_durumu,tel_no,email,Tc,adres,tarih,kayit_sure) values ('" + kullaniciad + "','" + sifree + "','" + ad+ "','" + soyad + "','" + yas + "','" + kilo + "','" +
                boy + "','" + cinsiyet + "','" + saglik_durumu + "','" + tel_no + "','" + email + "','" + tc + "','" + adres + "','" + tarih + "'," + kayit_süre + ")"; ;
            komut = new SqlCommand(sqli, baglan);
            int sonuc = (int)komut.ExecuteNonQuery();
            return sonuc;
        }
        public DataTable kullaniciarauye(string getir)
        {
            DataTable dt = new DataTable();
            string sql = "select * from kayit where 0=0 ";
            if (getir != "")
            {
                sql += "and lower(Tc) like'%" + getir.ToLower() + "%'";
            }
            SqlDataAdapter sda = new SqlDataAdapter(sql, baglan);
            sda.Fill(dt);
            return dt;
        }
        
    }
}
