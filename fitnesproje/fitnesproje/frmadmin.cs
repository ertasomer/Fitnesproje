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
    public partial class frmadmin : Form
    {
        dbislemleri db = new dbislemleri();
        public frmadmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin frm = new frmlogin();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmadmin_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.kullanicitablogetir().Tables[0];
        }

        private void çalışanGünceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmguncellesil frm = new frmguncellesil();
            frm.ShowDialog();
        }

        private void yeniÇalışanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkayitadmin frm = new frmkayitadmin();
            frm.ShowDialog();
        }

        private void hesapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmguncellesil frm = new frmguncellesil();
            frm.ShowDialog();
        }
    }
}
