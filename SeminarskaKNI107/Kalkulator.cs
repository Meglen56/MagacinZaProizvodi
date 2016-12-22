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
    public partial class frmKalkulator : Form
    {
        char oper = '+';
        double vrednost = 0;
        bool isNumber;
        double vneseno;

        public frmKalkulator(frmMain parent)
        {
            MagacinEventLog.WriteInformationLog("Vlez vo Kalkulator");
            InitializeComponent();
            MdiParent = parent;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
            // txtDisplay.Text = txtDisplay.Text + “1”;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
            // txtDisplay.Text = txtDisplay.Text + “1”;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
            // txtDisplay.Text = txtDisplay.Text + “1”;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
            // txtDisplay.Text = txtDisplay.Text + “1”;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
            // txtDisplay.Text = txtDisplay.Text + “1”;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
            // txtDisplay.Text = txtDisplay.Text + “1”;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
            // txtDisplay.Text = txtDisplay.Text + “1”;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
            // txtDisplay.Text = txtDisplay.Text + “1”;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
            // txtDisplay.Text = txtDisplay.Text + “1”;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
            // txtDisplay.Text = txtDisplay.Text + “1”;
        }

        private void btnToc_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnToc.Text;
            // txtDisplay.Text = txtDisplay.Text + “1”;
        }

        private void btnZbir_Click(object sender, EventArgs e)
        {
            {
                isNumber = double.TryParse(txtDisplay.Text, out vneseno);
                if (isNumber == false)
                {
                    MessageBox.Show("Мора да внесете број", "ГРЕШКА",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDisplay.Focus();
                }
                else
                {
                    switch (oper)
                    {
                        case '+':
                            vrednost = vrednost + double.Parse(txtDisplay.Text); //vrednost+=vneseno;
                            break;
                        case '-':
                            vrednost = vrednost - double.Parse(txtDisplay.Text); // vrednost-=vneseno; 
                            break;
                        case '*':
                            vrednost = vrednost * double.Parse(txtDisplay.Text); // vrednost*=vneseno;
                            break;
                        case '/':
                            vrednost = vrednost / double.Parse(txtDisplay.Text); // vrednost/=vneseno;
                            break;
                    }
                    oper = '+';       //овој дел се менува соодветно „-‟, „*‟, „/‟
                    txtDisplay.Text = "";
                    // txtDosega.Text = txtDosega.Text + vneseno.ToString() + oper.ToString();
                }
            }
        }

        private void btnRaz_Click(object sender, EventArgs e)
        {
            {
                isNumber = double.TryParse(txtDisplay.Text, out vneseno);
                if (isNumber == false)
                {
                    MessageBox.Show("Мора да внесете број", "ГРЕШКА",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDisplay.Focus();
                }
                else
                {
                    switch (oper)
                    {
                        case '+':
                            vrednost = vrednost + double.Parse(txtDisplay.Text); //vrednost+=vneseno;
                            break;
                        case '-':
                            vrednost = vrednost - double.Parse(txtDisplay.Text); // vrednost-=vneseno; 
                            break;
                        case '*':
                            vrednost = vrednost * double.Parse(txtDisplay.Text); // vrednost*=vneseno;
                            break;
                        case '/':
                            vrednost = vrednost / double.Parse(txtDisplay.Text); // vrednost/=vneseno;
                            break;
                    }
                    oper = '-';       //овој дел се менува соодветно „-‟, „*‟, „/‟
                    txtDisplay.Text = "";
                    // txtDosega.Text = txtDosega.Text + vneseno.ToString() + oper.ToString();
                }
            }
        }

        private void btnProiz_Click(object sender, EventArgs e)
        {
            {
                isNumber = double.TryParse(txtDisplay.Text, out vneseno);
                if (isNumber == false)
                {
                    MessageBox.Show("Мора да внесете број", "ГРЕШКА",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDisplay.Focus();
                }
                else
                {
                    switch (oper)
                    {
                        case '+':
                            vrednost = vrednost + double.Parse(txtDisplay.Text); //vrednost+=vneseno;
                            break;
                        case '-':
                            vrednost = vrednost - double.Parse(txtDisplay.Text); // vrednost-=vneseno; 
                            break;
                        case '*':
                            vrednost = vrednost * double.Parse(txtDisplay.Text); // vrednost*=vneseno;
                            break;
                        case '/':
                            vrednost = vrednost / double.Parse(txtDisplay.Text); // vrednost/=vneseno;
                            break;
                    }
                    oper = '*';       //овој дел се менува соодветно „-‟, „*‟, „/‟
                    txtDisplay.Text = "";
                    // txtDosega.Text = txtDosega.Text + vneseno.ToString() + oper.ToString();
                }
            }
        }

        private void btnKol_Click(object sender, EventArgs e)
        {
            {
                isNumber = double.TryParse(txtDisplay.Text, out vneseno);
                if (isNumber == false)
                {
                    MessageBox.Show("Мора да внесете број", "ГРЕШКА",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDisplay.Focus();
                }
                else
                {
                    switch (oper)
                    {
                        case '+':
                            vrednost = vrednost + double.Parse(txtDisplay.Text); //vrednost+=vneseno;
                            break;
                        case '-':
                            vrednost = vrednost - double.Parse(txtDisplay.Text); // vrednost-=vneseno; 
                            break;
                        case '*':
                            vrednost = vrednost * double.Parse(txtDisplay.Text); // vrednost*=vneseno;
                            break;
                        case '/':
                            vrednost = vrednost / double.Parse(txtDisplay.Text); // vrednost/=vneseno;
                            break;
                    }
                    oper = '/';       //овој дел се менува соодветно „-‟, „*‟, „/‟
                    txtDisplay.Text = "";
                    // txtDosega.Text = txtDosega.Text + vneseno.ToString() + oper.ToString();
                }
            }
        }

        private void btnEd_Click(object sender, EventArgs e)
        {

            {
                isNumber = double.TryParse(txtDisplay.Text, out vneseno);

                if (isNumber == false)
                {
                    MessageBox.Show("Мора да внесете број", "ГРЕШКА", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    txtDisplay.Focus();
                }
                else
                {
                    switch (oper)
                    {
                        case '+':
                            vrednost = vrednost + double.Parse(txtDisplay.Text); // vrednost+=vneseno;
                            break;
                        case '-':
                            vrednost = vrednost - double.Parse(txtDisplay.Text); // vrednost-=vneseno;
                            break;
                        case '*':
                            vrednost = vrednost * double.Parse(txtDisplay.Text); // vrednost*=vneseno;
                            break;
                        case '/':
                            vrednost = vrednost / double.Parse(txtDisplay.Text); // vrednost/=vneseno;
                            break;
                    }
                    txtDisplay.Text = vrednost.ToString();
                    //txtDosega.Text = txtDosega.Text + vneseno.ToString() + “=” + vrednost.ToString();
                    vrednost = 0;
                    oper = '+';
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            {
                oper = '+';
                vrednost = 0;
                txtDisplay.Text = "";
                //txtDosega.Text = "";
            }
        }

        private void frmKalkulator_Load(object sender, EventArgs e)
        {

        }
    }
}
       

   