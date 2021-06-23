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
    public partial class UcGestionVendeur : UserControl
    {
        public UcGestionVendeur()
        {
            InitializeComponent();
        }

        public void grid()
        {
            GridVendeur.Rows.Clear();
            for (int i = 0; i < Listes.VendeursListe.Count; i++)
            {
                GridVendeur.Rows.Add();
                GridVendeur.Rows[i].Cells["ID"].Value = Listes.VendeursListe[i].Id;
                GridVendeur.Rows[i].Cells["Nom"].Value = Listes.VendeursListe[i].NomComplet;
                GridVendeur.Rows[i].Cells["Adresse"].Value = Listes.VendeursListe[i].Adresse;
                GridVendeur.Rows[i].Cells["Email"].Value = Listes.VendeursListe[i].Email;
                GridVendeur.Rows[i].Cells["Telephone"].Value = Listes.VendeursListe[i].Telephone;

            }


        }

        private void UcGestionVendeur_Load(object sender, EventArgs e)
        {
            btnSupprimer.Visible = false;
            btnMise.Visible = false; 
            grid();
        }

        private void TXTnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTnomcomplet_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnumero_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string d = "01/01/1999";
            DateTime df = Convert.ToDateTime(d);


            Vendeur v = new Vendeur(TXTnumero.Text, TXTnomcomplet.Text, df, int.Parse(TXTtele.Text), TxtEmail.Text, TXTadresse.Text, "ftzyrm");
            v.Ajouter(v);
            grid();

        }

        private void GridVendeur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            



        }

        private void GridVendeur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow data = GridVendeur.Rows[i];
            TXTnumero.Text = data.Cells[0].Value.ToString();
            TXTnumero.Text = data.Cells[0].Value.ToString();
        }
    }
}