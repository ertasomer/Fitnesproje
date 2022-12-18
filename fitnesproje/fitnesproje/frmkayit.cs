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
    public partial class frmkayit : Form
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
       
        public frmkayit()
        {
            InitializeComponent();
        }

        private void kayit_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand();
            con = new SqlConnection("server=4ZR4L1N1Z\\SQLEXPRESS; database= FitnesApp;user=omer;password=adolfömer;");
            con.Open();
            cmd.Connection = con;
            int kilo = Convert.ToInt32(txtkilo.Text);
            int boy = Convert.ToInt32(txtboy.Text);
            int yas = Convert.ToInt32(txtyas.Text);


            cmd.CommandText = "insert into kayit (kullaniciad,sifre,ad,soyad,yas,kilo,boy,cinsiyet,saglik_durumu,tel_no,email,Tc,adres) values ('" + txtkullanici2.Text + "','" + txtsifre2.Text + "','" + txtad.Text + "','" + txtsoyad.Text + "','" + yas + "','" + kilo + "','" +
                boy + "','" + cmbcns.SelectedItem + "','" + cmbsktlk.SelectedItem + "','" + masktel.Text + "','" + txtEmail.Text + "','" + txtTc.Text + "','" + txtadres.Text + "')";
            cmd.ExecuteNonQuery();
            griddoldur();
            txtkullanici2.Clear();
            txtsifre2.Clear();
            txtad.Clear();
            txtsoyad.Clear();
            txtkilo.Clear();
            txtboy.Clear();
            txtyas.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
