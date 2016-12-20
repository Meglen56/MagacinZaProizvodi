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
    public partial class frmKasier2 : Form
    {
        private ProdavnicaEntities10 prodavnica1 = new ProdavnicaEntities10();
        public frmKasier2()
        {
            InitializeComponent();
        }

        private void frmKasier2_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnFilter2; 
        }

        private void frmKasier2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmNajaviProdavac obj1 = new frmNajaviProdavac();
            obj1.Show();
        }

        private void txtIme2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter2_Click(object sender, EventArgs e)
        {
            viewProizvodiBindingSource.DataSource =
              prodavnica1.viewProizvodis
              .Where(viewProizvodi => viewProizvodi.Kategorija.StartsWith(txtIme2.Text))
              .OrderBy(viewProizvodi => viewProizvodi.Kategorija);


            if (String.IsNullOrEmpty(txtIme2.Text) || txtIme2.Text != "Лап топ" && txtIme2.Text != "Апарати" && txtIme2.Text != "Телевизори" && txtIme2.Text != "Останато")
            {

                MessageBox.Show("Внесете една од категориите.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIme2.Focus();


            }
            else
            {
                prodavnicaDataContextDataContext kategorija = new prodavnicaDataContextDataContext();
                IEnumerable<String> kategorijaZaIzbor = from k in prodavnica1.viewProizvodis


                                                        where k.Kategorija == txtIme2.Text
                                                        select k.Kategorija;
                if ((Enumerable.Count(kategorijaZaIzbor) > 0) == false)
                {
                    MessageBox.Show("Моментално нема производи во оваа категорија");
                }
            }
                
                
            }
    }
}
        