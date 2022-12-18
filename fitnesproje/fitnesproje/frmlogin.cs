using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace fitnesproje
{
    public partial class frmlogin : Form
    {
       public SqlCommand cmd;
       public SqlDataAdapter da;
       public SqlConnection con;
       public DataSet ds;
       
       
        
        void griddoldur()
        {
            con = new SqlConnection("server=4ZR4L1N1Z\\SQLEXPRESS; database= FitnesApp;user=omer;password=adolfömer;");
            da = new SqlDataAdapter("Select *From kayit", con);
         ds = new DataSet();
          con.Open();
          
         
            con.Close();
        }
        public frmlogin()
        {
            InitializeComponent();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            if (txtkullanici1.Text == "admin" && txtsifre1.Text == "root")
            {
                MessageBox.Show("ADMİN GİRİŞİ BAŞARILI");
                txtkullanici1.Clear();
                txtsifre1.Clear();
               // frmadmin frm = new frmadmin();
                frmkbekle frm = new frmkbekle();
                frm.Show();
                this.Hide();

            }
           
            else if (txtkullanici1.Text=="ömer"&&txtsifre1.Text=="ertas")
            {
                MessageBox.Show("HEY DEVELOPER HOŞ GELDİN");
                txtkullanici1.Clear();
                txtsifre1.Clear();
                frmdeveloper frm2 = new frmdeveloper();
                frm2.Show();
                this.Hide();
                
            }
            else if (txtkullanici1.Text != "admin" && txtsifre1.Text != "root")
            {
                MessageBox.Show("ADMİN GİRİŞİ HATALI LÜTFEN ÜYE GİRİŞİ YAPIN");
                txtkullanici1.Clear();
                txtsifre1.Clear();
            }
        }

        private void kayit_Click(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmkayit frm = new frmkayit();
            frm.Show();
            
        }

        public void uye_Click(object sender, EventArgs e)
        { string sonuc;
            dbislemleri vt = new dbislemleri();
            sonuc = vt.kgiriskontrol(txtkullanici1.Text,txtsifre1.Text);
            if (sonuc != null)
            {
                MessageBox.Show("hoşgeldiniz sayın " + sonuc);
                frmuye frn = new frmuye();
                frn.ShowDialog();
                Close();
            }
            else MessageBox.Show("hatalı kullanıcı adı veya şifre. kalan hakkınız ");
        }

        
    }
}
