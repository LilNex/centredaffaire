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
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            FormSignIn f = new FormSignIn();
            f.Show();
        }

        private void BTNfermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
    }
}
