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
    public partial class frmVnesCeni : Form
    {
        private prodavnicaDataContextDataContext prod = new prodavnicaDataContextDataContext();
        private ProdavnicaEntities7 prodavnica = new ProdavnicaEntities7();
        public frmVnesCeni(frmMain parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void frmVnesCeni_Load(object sender, EventArgs e)
        {
                cenaBindingSource2.DataSource = 
                from cena in prodavnica.Cenas
                orderby cena.ProizvodID
                select cena;
        }

        private void cenaBindingSource2BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate();
            cenaBindingSource2.EndEdit();
            prodavnica.SaveChanges();
            
            MessageBox.Show("СНИМЕНО","", MessageBoxButtons.OK);

        }

  

     
    }
}
