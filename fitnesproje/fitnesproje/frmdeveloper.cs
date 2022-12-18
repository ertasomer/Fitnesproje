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
    public partial class frmdeveloper : Form
    {
        public frmdeveloper()
        {
            InitializeComponent();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            frmlogin frm = new frmlogin();
            frm.Show();
            this.Hide();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
