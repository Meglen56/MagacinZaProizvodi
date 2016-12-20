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
    public partial class frmKasier1 : Form
    {

        private ProdavnicaEntities10 prodavnica = new ProdavnicaEntities10();

        public frmKasier1()
        {
            InitializeComponent();
        }


        private void Kasier1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnFilter;

        }


        private void frmKasier1_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            frmNajaviProdavac obj1 = new frmNajaviProdavac();
            obj1.Show();

        }



        private void btnFilter_Click(object sender, EventArgs e)
        {

            viewProizvodiBindingSource.DataSource =
              prodavnica.viewProizvodis
              .Where(viewProizvodi => viewProizvodi.Kategorija.StartsWith(txtIme.Text))
              .OrderBy(viewProizvodi => viewProizvodi.Kategorija);


            if (String.IsNullOrEmpty(txtIme.Text) || txtIme.Text != "Лап топ" && txtIme.Text != "Апарати" && txtIme.Text != "Телевизори" && txtIme.Text != "Останато")
            {
                
                MessageBox.Show("Внесете една од категориите.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIme.Focus();

              
            }
           
            

            

                else
            {
                prodavnicaDataContextDataContext kategorija = new prodavnicaDataContextDataContext();
                IEnumerable<String> kategorijaZaIzbor = from k in prodavnica.viewProizvodis
                                                        where k.Kategorija == txtIme.Text
                                                        select k.Kategorija;
                if ((Enumerable.Count(kategorijaZaIzbor) > 0) == false)
                {
                    MessageBox.Show("Моментално нема производи во оваа категорија");
                }
              
                
                
            }
            
                
                
            }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}




        


        
      
