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
    public partial class frmguncellesil : Form
    {
        dbislemleri db = new dbislemleri(); 
        public frmguncellesil()
        {
            InitializeComponent();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.kullanicitablogetir().Tables[0];
        }

        private void frmguncellesil_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.kullanicitablogetir().Tables[0];
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtkullanici2.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtsifre2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtyas.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtkilo.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtboy.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            date.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cmbcns.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmbsktlk.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            masktel.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
             cmbsure.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
             txtadres.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtTc.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
        }

        private void cmbsure_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iban1_TextChanged(object sender, EventArgs e)
        {
            if (iban1.Text != "")
            {
                string ibanim = Convert.ToString(iban1.Text);
                dataGridView1.DataSource = db.kullaniciarauye(ibanim);
            }
            else
            {
                dataGridView1.DataSource = db.kullanicitablogetir().Tables[0];
            }
        }

        private void geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
