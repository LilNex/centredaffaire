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
    public partial class FormGridMemebre : Form
    {
        public FormGridMemebre()
        {
            InitializeComponent();
        }

        public void remplirgrid()
        {
            GridMembre.Rows.Clear(); 
            for (int i = 0; i < Listes.MembresListe.Count; i++ )
            {
                GridMembre.Rows.Add();
                GridMembre.Rows[i].Cells["IDMembre"].Value = Listes.MembresListe[i].Id;
                GridMembre.Rows[i].Cells["Poids"].Value = Listes.MembresListe[i].Poids;
                GridMembre.Rows[i].Cells["Telephone"].Value = Listes.MembresListe[i].Telephone;
                GridMembre.Rows[i].Cells["Nom"].Value = Listes.MembresListe[i].NomComplet;
                GridMembre.Rows[i].Cells["Adresse"].Value = Listes.MembresListe[i].Adresse;
                GridMembre.Rows[i].Cells["Email"].Value = Listes.MembresListe[i].Email;
                GridMembre.Rows[i].Cells["Frais"].Value = Listes.MembresListe[i].Frais;
                GridMembre.Rows[i].Cells["Total"].Value = Listes.MembresListe[i].Total;
                GridMembre.Rows[i].Cells["Duree"].Value = Listes.MembresListe[i].Duree;
                GridMembre.Rows[i].Cells["Statut"].Value = Listes.MembresListe[i].Statut;
                GridMembre.Rows[i].Cells["Sex"].Value = Listes.MembresListe[i].Sex;
                GridMembre.Rows[i].Cells["DateJoin"].Value = Listes.MembresListe[i].DateJoin;
                GridMembre.Rows[i].Cells["Package"].Value = Listes.MembresListe[i].Package.Nom;



            }

        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();



        private void FormGridMemebre_Load(object sender, EventArgs e)
        {
            remplirgrid();
        }

        private void GridMembre_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
