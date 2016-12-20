using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SeminarskaKNI107
{
    public partial class frmNajaviProdavac : Form
    {
        public frmNajaviProdavac()
        {
            InitializeComponent();
        }

        private void frmNajaviProdavac_Load(object sender, EventArgs e)
        {

        }

        private void frmNajaviProdavac_FormClosing(object sender, FormClosingEventArgs e)
        {
          

            this.Hide();
            frmNajava obj1 = new frmNajava();
            obj1.Show();
        }

        private void btnKas1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKasier1 obj1 = new frmKasier1();
            obj1.Show();
            btnKas1.Hide();
        }

        private void btnKas2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKasier2 obj2 = new frmKasier2();
            obj2.Show();
            btnKas1.Hide();
        }
    }
}
