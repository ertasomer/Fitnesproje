using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fitnesproje
{
    public partial class frmkayitadmin : Form
    {
        dbislemleri db = new dbislemleri();
        public frmkayitadmin()
        {
            InitializeComponent();
        }



        private void kayit_Click(object sender, EventArgs e)
        {
            int kilo = Convert.ToInt32(txtkilo.Text);
            int boy = Convert.ToInt32(txtboy.Text);
            int yas = Convert.ToInt32(txtyas.Text);
            string tc = txtTc.Text;
            string ad = txtad.Text;
            string soyad = txtsoyad.Text;
            string adres = txtadres.Text;
            string kullaniciad = txtkullanici2.Text;
            string sifre = txtsifre2.Text;
            string tarih = date.Value.ToShortDateString();
            string cinsiyet = cmbcns.Text;
            string sakatlik = cmbsktlk.Text;
            string tel = masktel.Text;
            string email = txtEmail.Text;
            int sure = Convert.ToInt32(cmbsure.Text);
            int sonuc;
            sonuc = db.uyeekle(tc, ad, soyad, adres, kullaniciad, sifre, yas, kilo, boy, tarih, cinsiyet, sakatlik, tel, email, sure);
            if (sonuc > 0)
            {
                MessageBox.Show("kayıt başarılı");
            }
            else MessageBox.Show("kayıt gerçekleşemedi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kilo = Convert.ToInt32(txtkilo.Text);
            int boy = Convert.ToInt32(txtboy.Text);
            int yas = Convert.ToInt32(txtyas.Text);
            string tc = txtTc.Text;
            string ad = txtad.Text;
            string soyad = txtsoyad.Text;
            string adres = txtadres.Text;
            string kullaniciad = txtkullanici2.Text;
            string sifre = txtsifre2.Text;
            string tarih = date.Value.ToShortDateString();
            string isBaslama=dateTimePicker1.Value.ToShortDateString();
            string cinsiyet = cmbcns.Text;
            string sakatlik = cmbsktlk.Text;
            string tel = masktel.Text;
            string email = txtEmail.Text;
            string brans = "antronür";
            string yteki = "yetki yok";
            int sure = Convert.ToInt32(cmbsure.Text);
            int sonuc;
            sonuc = db.calisanelekle(tc,ad,soyad,adres,yteki,yas,isBaslama,tarih,brans);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
