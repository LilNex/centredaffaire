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
    public partial class frmGPersonnel : Form
    {
        public frmGPersonnel()
        {
            InitializeComponent();
        }

        private void frmGPersonnel_Load(object sender, EventArgs e)
        {
            // test
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ClsEmploye logged = Functions.login(txtLogin.Text, txtMdp.Text);
            if (logged != null)
            {
                frmPrincipal_Directeur frm = new frmPrincipal_Directeur();
                frm.UserLogged = logged;
                frm.Show();
            }
            else
            {
                lblNotif.Text = "Identifiant ou mot de passe invalide.";
            }
        }
    }
}
