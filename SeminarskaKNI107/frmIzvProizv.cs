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
    public partial class frmIzvProizv : Form
    {
        private ProdavnicaEntities7 prodavnica = new ProdavnicaEntities7();
        public frmIzvProizv(frmMain parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void frmIzvProizv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodavnicaDataSet.Proizvod' table. You can move, or remove it, as needed.
            cmbOpis.DisplayMember = "Kategorija";
            cmbOpis.ValueMember = "ProizvodID";


            proizvodBindingSource1.DataSource =
                          from proizvod in prodavnica.Proizvods
                          orderby proizvod.Kategorija



                          select new


                          {
                              ProizvodID = proizvod.ProizvodID,
                              Ime = proizvod.Ime,
                              Kolicina = proizvod.Kolicina,
                              Proizvoditel = proizvod.Proizvoditel,
                              Kategorija = proizvod.Kategorija,

                          };
        }
    

       
        private void cmbOpis_SelectedValueChanged(object sender, EventArgs e)
        {
            proizvodBindingSource.DataSource =
                        from proizvod in prodavnica.Proizvods
                        orderby proizvod.Kategorija



                        select new


                        {
                            ProizvodID = proizvod.ProizvodID,
                            Ime = proizvod.Ime,
                            Kolicina = proizvod.Kolicina,
                            Proizvoditel = proizvod.Proizvoditel,
                            Kategorija = proizvod.Kategorija,

                        };
            proizvodDataGridView.DataSource = proizvodBindingSource;
            this.proizvodBindingSource.Position = this.cmbOpis.SelectedIndex;
        }

        private void cmbOpis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
