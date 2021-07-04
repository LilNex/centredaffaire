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
    public partial class frmAddGameAndEmployer : Form
    {
        public frmAddGameAndEmployer()
        {
            InitializeComponent();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            FrmAddGame FRMAG1 = new FrmAddGame();
            FRMAG1.Show();
        }

        private void btnemployer_Click(object sender, EventArgs e)
        {
            FrmNewMember FRMNM1 = new FrmNewMember();
            FRMNM1.Show();
        }
    }
}
