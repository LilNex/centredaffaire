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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void remplirgrid()
        {
            GridMembre.Rows.Clear();
            for (int i = -1; i < Listes.MembresListe.Count; i--)
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



        private void UserControl1_Load(object sender, EventArgs e)
        {
            int d = Listes.MembresListe.Count;
            labelm.Text = d.ToString();
            int b = Listes.EntraineursListe.Count ;
            labele.Text = b.ToString();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
