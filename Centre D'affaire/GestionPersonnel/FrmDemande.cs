using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionPersonnel
{
    public partial class FrmDemande : Form
    {
        public FrmDemande()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDemande_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongDateString();
             label2.Text = DateTime.Now.ToLongTimeString();




        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                FrmCongée f1 = new FrmCongée();
                f1.Show();
            }
            this.Hide();
        }

        private void Frm(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                FrmDemission f1 = new FrmDemission();
                f1.Show();
            }
            this.Hide();
        }

        private void FrmDemande_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
