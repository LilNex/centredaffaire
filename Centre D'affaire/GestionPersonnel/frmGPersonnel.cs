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
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ClsEmploye logged = Functions.login(txtLogin.Text, txtMdp.Text);
            if (logged != null)
            {
                if(logged.Type == EmployeType.Directeur)
                {
                    frmPrincipal_Directeur frm = new frmPrincipal_Directeur();
                    frm.UserLogged = logged;
                    frm.Show();
                }
                else /*(logged.Type == EmployeType.Employe)*/
                {
                    frmPrincipal_Employe frm = new frmPrincipal_Employe();
                    frm.UserLogged = logged;
                    frm.Show();
                }

            }
            else
            {
                lblNotif.Text = "Identifiant ou mot de passe invalide.";
            }
        }


        private void btnDirect_Click(object sender, EventArgs e)
        {
            frmPrincipal_Directeur frm = new frmPrincipal_Directeur();
            this.Hide();
            frm.Show();
        }
    }
}
