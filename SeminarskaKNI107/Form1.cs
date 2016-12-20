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
    public partial class frmMain : Form
    {
        Timer t = new Timer();
        public frmMain()
        {
           
        InitializeComponent();
             
    
        }

        private void mnuKalk_Click(object sender, EventArgs e)
        {
            frmKalkulator child = new frmKalkulator(this);
            child.Show();
        }

        private void mnuIzl_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            frmNajava obj1 = new frmNajava();
            obj1.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            this.Hide();
            frmNajava obj1 = new frmNajava();
            obj1.Show();
        }

        private void mnuProizv_Click(object sender, EventArgs e)
        {
            frmVnesProiz child = new frmVnesProiz(this);
            child.Show();
        }

        private void mnuCeni_Click(object sender, EventArgs e)
        {
            frmVnesCeni child = new frmVnesCeni(this);
            child.Show();
        }

        private void mnuProizvCeni_Click(object sender, EventArgs e)
        {
            frmVnesProizCeni child = new frmVnesProizCeni(this);
            child.Show();
        }

        private void mnuIzvProiz_Click(object sender, EventArgs e)
        {
            frmIzvProizv child = new frmIzvProizv(this);
            child.Show();
        }

        private void mnuIzvCeni_Click(object sender, EventArgs e)
        {
            frmIzvCeni child = new frmIzvCeni(this);
            child.Show();
        }

        private void mnuIzvProizCeni_Click(object sender, EventArgs e)
        {
            frmIzvProizvCen child = new frmIzvProizvCen(this);
            child.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
          
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Location = new Point(10, 10);
            dateTimePicker1.Width = 100;
            Controls.Add(dateTimePicker1);
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            String time = "";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            lblCas.Text = time;
        }

        private void ситеСпецификацииНаПроизводотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Specifikacii child = new Specifikacii(this);
            child.Show();
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void целосенПриказToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void magacinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Magacin child = new Magacin(this);
            child.Show();
        }
    }
}
        