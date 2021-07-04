using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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
            Utilisateur u = new Utilisateur("mehdi", "123", "", "");
            u.Ajouter(u);
            Deserialze();
        }
        bool x;

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < Listes.utilisateurs.Count; i++)
            {
                if (Listes.utilisateurs[i].NomUtilisateur == txtLogin.Text && Listes.utilisateurs[i].MotPass == TXTmotpasse.Text)
                {

                    x = true;


                }
               

            }
            if ( x == true)
            {
                FormGestionnaire f = new FormGestionnaire();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("votre mote passe ou username est incorrect ! " + MessageBoxButtons.OK);
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

        public void Deserialze()
        {
            XmlSerializer xml = new XmlSerializer(Listes.utilisateurs.GetType());







            if (File.Exists("util.xml"))
            {
                try
                {
                    StreamReader stream = System.IO.File.OpenText("util.xml");

                    try
                    {

                        Listes.utilisateurs = (List<Utilisateur>)xml.Deserialize(stream);
                        
                    }
                    catch (Exception)
                    {
                        throw new Exception("Problème de lecture !!!");
                    }
                    stream.Close();
                }
                catch (Exception)
                {
                    throw new Exception("Problème d'ouverture !!!");
                }
            }








        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FormSignIn frmSignIn = new FormSignIn();
            frmSignIn.Show();
        }
    }
}
