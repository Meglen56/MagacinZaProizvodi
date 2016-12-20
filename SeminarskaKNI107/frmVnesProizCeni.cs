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
    public partial class frmVnesProizCeni : Form
    {
        private prodavnicaDataContextDataContext prod = new prodavnicaDataContextDataContext();
        private ProdavnicaEntities7 prodavnica = new ProdavnicaEntities7();
        public frmVnesProizCeni(frmMain parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void frmVnesProizCeni_Load(object sender, EventArgs e)
        {
            proizvodCenaBindingSource.DataSource =
               from proizvodcena in prodavnica.ProizvodCenas
               orderby proizvodcena.ProizvodID
               select proizvodcena;
        }

        private void proizvodCenaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            proizvodCenaBindingSource.EndEdit();
            prodavnica.SaveChanges();
           
            MessageBox.Show("СНИМЕНО", "", MessageBoxButtons.OK);
        }

        private void opisTextBox_TextChanged(object sender, EventArgs e)
        {

        }

       

        
    }
}
