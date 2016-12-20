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
    public partial class frmVnesProiz : Form

    {
        private ProdavnicaEntities7 prodavnica = new ProdavnicaEntities7();

        public frmVnesProiz(frmMain parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void proizvodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            proizvodBindingSource.EndEdit();
            prodavnica.SaveChanges();
            imeTextBox.Text = "";
            kategorijaTextBox.Text = "";
            kolicinaTextBox.Text = "";
            proizvodIDTextBox.Text = "";
            proizvoditelTextBox.Text = "";
            MessageBox.Show("СНИМЕНО", "", MessageBoxButtons.OK);
        }

        private void frmVnesProiz_Load(object sender, EventArgs e)
        {
            proizvodBindingSource.DataSource =
                from proizvod in prodavnica.Proizvods
                orderby proizvod.ProizvodID
                select proizvod;
        }

     

      
    }
}
