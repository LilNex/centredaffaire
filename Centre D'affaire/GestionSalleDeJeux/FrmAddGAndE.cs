using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    public partial class FrmAddGAndE : Form
    {
        public FrmAddGAndE()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmNewMember FRMNM = new FrmNewMember();
            FRMNM.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNewMember FRMNM1 = new FrmNewMember();
            FRMNM1.Show();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            FrmAddGame FRMAG1 = new FrmAddGame();
            FRMAG1.Show();
        }

        private void btnImageBillard_Click(object sender, EventArgs e)
        {
            FrmAddGame FRMAG2 = new FrmAddGame();
            FRMAG2.Show();
        }

        private void FrmAddAll_Load(object sender, EventArgs e)
        {

        }
    }
}
