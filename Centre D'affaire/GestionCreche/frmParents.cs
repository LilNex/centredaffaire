using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionCreche
{
    public partial class frmParents : Form
    {
        public frmParents()
        {
            InitializeComponent();
        }

        private void BtnPre_Click(object sender, EventArgs e)
        {
            frmParents frm2 = new frmParents();
            frm2.Show();
            this.Hide();
        }

        private void frmParents_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
