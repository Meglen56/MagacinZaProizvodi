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
    public partial class frmIzvCeni : Form
    {
        private ProdavnicaEntities7 prodavnica = new ProdavnicaEntities7();
        public frmIzvCeni(frmMain parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void frmIzvCeni_Load(object sender, EventArgs e)
        {
            cenaBindingSource.DataSource = 
                from cena in prodavnica.Cenas
                orderby cena.ProizvodID
                select cena;
        }
    }
}
