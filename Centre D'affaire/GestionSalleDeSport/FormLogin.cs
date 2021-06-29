using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public partial class btnSeconnecter : Form
    {
        public btnSeconnecter()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< Listes.utilisateurs.Count; i++)
            {
                if (Listes.utilisateurs[i].NomUtilisateur == txtLogin.Text && Listes.utilisateurs[i].MotPass == TXTmotpasse.Text) {

                    FormGestionnaire f = new FormGestionnaire();
                    f.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Votre Nom d'utilisateur ou votre Mot de passe n'est pas correct , veulliez resseyer : " + MessageBoxButtons.OK);
                }

            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            FormSignIn f = new FormSignIn();
            f.Show();
        }

        private void BTNfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
