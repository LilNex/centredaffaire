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
    public partial class FrmConnection : Form
    {
        
        clsEmployersSDJ EDSJ = new clsEmployersSDJ();
        public FrmConnection()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EDSJ.rechercherE(EDSJ.NumeroE) != -1)
            {
                if (ClsListeSDJ.ListE[EDSJ.rechercherE(EDSJ.NumeroE)].PasswordE1 == textPssword.Text)
                {
                    
                }
            }
            else
            {
                MessageBox.Show("votre mot de passe ou numero est incorect", "ERREUR");
            }

        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veuillez contacter la responsable pour retourner votre mot de passe , pour plus d'info 0606060606", "Realisation de mot de passe");
            
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            FrmNewMember FNM = new FrmNewMember();
            FNM.Show();
        }

        private void twtNumero_TextChanged(object sender, EventArgs e)
        {
            if ((twtNumero.Text).Any(char.IsLetter) )
            {
                errorProviderConnection.SetError(twtNumero, "Votre Telephone ne doit pas contien aucun letre.Et 10 nombre");
                btnConnect.Enabled = false;
            }
            else
            {
                errorProviderConnection.SetError(twtNumero, "");
                btnConnect.Enabled = true;
            }
        }

        private void FrmConnection_Load(object sender, EventArgs e)
        {

        }
    }
}
