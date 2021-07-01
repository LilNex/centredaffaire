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
            for (int i = Listes.MembresListe.Count ; i < 0; i--)
            {
                GridMembre.Rows.Add();
                GridMembre.Rows[i].Cells["IDMembre"].Value = Listes.MembresListe[i].Id;
               
                GridMembre.Rows[i].Cells["Telephone"].Value = Listes.MembresListe[i].Telephone;
                GridMembre.Rows[i].Cells["Nom"].Value = Listes.MembresListe[i].NomComplet;
                GridMembre.Rows[i].Cells["Adresse"].Value = Listes.MembresListe[i].Adresse;
                GridMembre.Rows[i].Cells["Email"].Value = Listes.MembresListe[i].Email;
        


            }

        }



        private void UserControl1_Load(object sender, EventArgs e)
        {
            int d = Listes.MembresListe.Count;
            labelm.Text = d.ToString();
            int b = Listes.EntraineursListe.Count ;
            labele.Text = b.ToString();
            int t = 0; 
            for (int i = 0; i < Listes.paiment.Count; i++)
            {
                t = int.Parse(Listes.paiment[i].Paiement1 ) + t ;
                

            }
            labelb.Text = t.ToString();
            remplirgrid();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
