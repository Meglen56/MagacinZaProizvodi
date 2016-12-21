using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SeminarskaKNI107
{
    public partial class frmNajava : Form
    {

        public frmNajava()
        {
            InitializeComponent();
        }

        private void btnNajavi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtLozinka.Text) || String.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                MessageBox.Show("Внесете лозинка или корисничко име.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLozinka.Focus();
            }
            else if (String.IsNullOrEmpty(txtIme.Text) || String.IsNullOrWhiteSpace(txtIme.Text))
            {
                MessageBox.Show("Внесете лозинка или корисничко име .", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIme.Focus();
            }
            else
            {
                MagacinEventLog.WriteInformationLog("Najaven Korisnik");
                String korisnik = NajaviKorisnik(txtIme.Text, txtLozinka.Text);

                if (korisnik == null)
                {
                    MessageBox.Show("Нема такво Корисничко Име или Лозинка");
                }
                else if (korisnik == "adm")
                {
                    this.Hide();
                    frmMain obj1 = new frmMain();
                    obj1.Show();
                    label1.Hide();
                    label2.Hide();
                    txtIme.Hide();
                    txtLozinka.Hide();
                    btnNajavi.Hide();

                }
                else if (korisnik == "pro")
                {
                    this.Hide();
                    frmNajaviProdavac obj2 = new frmNajaviProdavac();
                    obj2.Show();
                    label1.Hide();
                    label2.Hide();
                    txtIme.Hide();
                    txtLozinka.Hide();
                    btnNajavi.Hide();

                }
            }
        }

        private void frmNajava_Load(object sender, EventArgs e)
        {

            this.AcceptButton = btnNajavi;
        }

        private void frmNajava_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Сакате да ја исклучите апликацијата", "Крај", MessageBoxButtons.YesNo)
           == DialogResult.No)
                e.Cancel = true;
        }

        private void frmNajava_Load_1(object sender, EventArgs e)
        {

        }

        public String NajaviKorisnik(String korisnickoIme, String password)
        {
            String izlez = null;
            prodavnicaDataContextDataContext user = new prodavnicaDataContextDataContext();
            IEnumerable<String> korisnikZaVlez = from u in user.Korisniks
                                                 where u.Ime == korisnickoIme && u.Lozinka == password
                                                 select u.TipKorisnik;

            if ((Enumerable.Count(korisnikZaVlez) > 0) == false)
            {
                izlez = null;
            }
            else if (korisnikZaVlez.First().ToString() == "adm")
            {
                izlez = "adm";
            }

            else if (korisnikZaVlez.First().ToString() == "pro")
            {
                izlez = "pro";
            }
            return izlez;

        }



    }
}
