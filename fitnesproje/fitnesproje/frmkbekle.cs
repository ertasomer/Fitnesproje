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
    public partial class frmkbekle : Form
    {
        public frmkbekle()
        {
            InitializeComponent();
        }

        private void frmkbekle_Load(object sender, EventArgs e)
        {
            timer1.Start();

           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        int zaman = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval=10;
            progressBar1.Value = zaman;
            zaman++;
            if (zaman>300)
            {
                timer1.Stop();
                frmadmin frm = new frmadmin();
                       frm.Show();
                     Close();
                
            }
        }
    }
}
