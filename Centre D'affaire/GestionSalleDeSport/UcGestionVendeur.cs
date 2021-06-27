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

  

        private void btnSave_Click(object sender, EventArgs e)
        {
            string d = "01/01/1999";
            DateTime df = Convert.ToDateTime(d);
            Vendeur v = new Vendeur(TXTnumero.Text, TXTnomcomplet.Text, df, int.Parse(TXTtele.Text), TxtEmail.Text, TXTadresse.Text, "ftzyrm");
            if (v.Ajouter(v) == true)
            {
                MessageBox.Show(TXTnomcomplet.Text +" ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grid();
                ClassInterface i = new ClassInterface();
                i.viderform(this);
            }
            else
            {
                MessageBox.Show("Ajout non effectué, vérifiez que le ID  n'est pas en double", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTnumero.Focus();


            }
            
            


        }

   

        private void GridVendeur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow data = GridVendeur.Rows[i];
            TXTnumero.Text = data.Cells[0].Value.ToString();
            TXTnomcomplet.Text = data.Cells[1].Value.ToString();
            TxtEmail.Text = data.Cells[2].Value.ToString();
            TXTadresse.Text =data.Cells[3].Value.ToString();
            TXTtele.Text = data.Cells[4].Value.ToString();
            btnSave.Visible = false;
            btnMise.Visible = true;
            btnSupprimer.Visible = true; 
        }

        private void btnMise_Click(object sender, EventArgs e)
        {
            DialogResult D;
            D = MessageBox.Show("Voulez vous vraiment supprimer " + TXTnomcomplet.Text, "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (D == DialogResult.Yes)
            {
                string num = GridVendeur.CurrentRow.Cells[0].Value.ToString();
                Vendeur st = new Vendeur();
                st.supprimer(TXTnumero.Text);
                grid();
                btnSupprimer.Visible = false;
                btnMise.Visible = false;
                btnSave.Visible = true;

                ClassInterface i = new ClassInterface();
                i.viderform(this);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Voulez vous vraiment modifier "+ TXTnomcomplet.Text , "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (D == DialogResult.Yes)
            {
                var found = Listes.VendeursListe.FirstOrDefault(c => c.Id == TXTnumero.Text);
                found.Id = TXTnumero.Text;

                found.NomComplet = TXTnomcomplet.Text;
                found.Email = TxtEmail.Text;
                found.Adresse = TXTadresse.Text;
                found.Telephone = int.Parse(TXTtele.Text);
                grid();
                ClassInterface i = new ClassInterface();
                i.viderform(this);
            }

        }

        private void GridVendeur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}