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
    public partial class Specifikacii : Form
    {
        private ProdavnicaEntities11 prod = new ProdavnicaEntities11();
        public Specifikacii(frmMain parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void Specifikacii_Load(object sender, EventArgs e)
        {

            this.AcceptButton = btnFilter;

           
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            viewSpecifikaciiBindingSource.DataSource =
             prod.ViewSpecifikaciis
             .Where(viewProizvodi => viewProizvodi.Kategorija.StartsWith(txtFilter.Text))
             .OrderBy(ViewSpecifikacii => ViewSpecifikacii.Cena);



            if (String.IsNullOrEmpty(txtFilter.Text) || txtFilter.Text != "Лап топ" && txtFilter.Text != "Апарати" && txtFilter.Text != "Телевизори" && txtFilter.Text != "Останато")
            {

                MessageBox.Show("Внесете една од категориите.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFilter.Focus();

            }
                else
            {
                prodavnicaDataContextDataContext kategorija = new prodavnicaDataContextDataContext();
                IEnumerable<String> kategorijaZaIzbor = from k in prod.ViewSpecifikaciis
                                                        where k.Kategorija == txtFilter.Text
                                                        select k.Kategorija;
                if ((Enumerable.Count(kategorijaZaIzbor) > 0) == false)
                {
                    MessageBox.Show("Моментално нема производи во оваа категорија");
                }
              
                
                
            }
            
                
                
            }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }


            }
           
        }
    

