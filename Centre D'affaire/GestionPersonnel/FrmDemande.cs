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
            label1.Text = DateTime.Now.Day.ToString();
            if(checkBox1.Checked == true)
            {
                FrmCongée f = new FrmCongée();
                f.Show();
            }
            if (checkBox2.Checked == true)
            {
                FrmDemission f1 = new FrmDemission();
                f1.Show();
            }
        }
    }
}
