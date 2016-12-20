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
    public partial class frmIzvProizvCen : Form
    {
        private prodavnicaDataContextDataContext opis = new prodavnicaDataContextDataContext();
        private ProdavnicaDataSet prod = new ProdavnicaDataSet();
        private ProdavnicaEntities7 prodavnica = new ProdavnicaEntities7();
        public frmIzvProizvCen(frmMain parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void frmIzvProizvCen_Load(object sender, EventArgs e)
        {
         

            cmbOpis.DisplayMember = "Ime";
            cmbOpis.ValueMember = "ProizvodID";

            
            
            proizvodCenaBindingSource.DataSource =
            from proizvodCena in prodavnica.ProizvodCenas
             orderby proizvodCena.Ime
            
            
             
            select new


            {
                ProizvodID = proizvodCena.ProizvodID,
                Ime = proizvodCena.Ime,
                Opis = proizvodCena.Opis,
            };
        }
          

        private void proizvodCenaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





       

        private void frmIzvProizvCen_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodavnicaDataSet.Proizvod' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'prodavnicaDataSet.ProizvodCena' table. You can move, or remove it, as needed.
            this.proizvodCenaTableAdapter.Fill(this.prodavnicaDataSet.ProizvodCena);

        }

        private void proizvodCenaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbOpis_SelectedValueChanged(object sender, EventArgs e)
        {
            
           
            proizvodCenaBindingSource1.DataSource =
            from proizvodCena in prodavnica.ProizvodCenas
           
            orderby proizvodCena.Ime

            select new
{
             ProizvodID = proizvodCena.ProizvodID,
            Ime = proizvodCena.Ime,
            Opis = proizvodCena.Opis};
            proizvodCenaDataGridView.DataSource = proizvodCenaBindingSource1;

            this.proizvodCenaBindingSource1.Position = this.cmbOpis.SelectedIndex;
            
        }

       
    }
}


