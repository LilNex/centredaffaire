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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
           TXTmotPass.Enabled = false;
            Deserialze();
            gridUtilisateur.Visible = false; 
        }

        private void TXTadresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNfermer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void grid()
        {
            gridUtilisateur.Rows.Clear(); 
            for (int i =0; i <Listes.utilisateurs.Count; i++)
            {
                gridUtilisateur.Rows.Add();
                gridUtilisateur.Rows[i].Cells["Login"].Value = Listes.utilisateurs[i].NomUtilisateur;
                gridUtilisateur.Rows[i].Cells["MotPass"].Value = Listes.utilisateurs[i].MotPass;

            }
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Utilisateur m = new Utilisateur(TXTNOmUtilisateur.Text , TXTmotPass.Text ,"" ,"");



            if (m.Ajouter(m)== true)
            {
                MessageBox.Show(TXTNOmUtilisateur.Text + " ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Serialize();
                grid();
                ClassInterface i = new ClassInterface();
                i.viderform(this);
                gridUtilisateur.Visible = true;

            }
            else
            {
                MessageBox.Show("Ajout non effectué, vérifiez que le ID  n'est pas en double", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
       


            }
            
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
            TXTmotPass.Text = CreatePassword(8);

        }
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void lblNomdutilisateur_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void TXTmotPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTNOmUtilisateur_TextChanged(object sender, EventArgs e)
        {

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void bunifuPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
       

        public void Serialize()
        {
            XmlSerializer xml = new XmlSerializer(Listes.utilisateurs.GetType());
            using (StreamWriter stream = System.IO.File.CreateText("util.xml"))
            {
                xml.Serialize(stream, Listes.utilisateurs);
                stream.Close();
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
                        grid();
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
    }
}
