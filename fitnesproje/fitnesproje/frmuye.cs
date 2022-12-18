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
    public partial class frmuye : Form
    {
        public frmuye()
        {
            InitializeComponent();
        }

        private void frmuye_Load(object sender, EventArgs e)
        {
            dbislemleri db = new dbislemleri();

            lbldoldur.Text = db.sonuc;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin frm = new frmlogin();
            frm.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
