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

namespace Centre_D_affaire.GestionCreche
{
    public partial class frmFacture : Form
    {
        private int indice;

        public frmFacture()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxPaiementde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPaiementde.SelectedItem == "Mois")
            {
                _ = lblMontant.Text == "LE MONTANT TOTAL EST 1300 DH";
            }
            if (cbxPaiementde.SelectedItem == "  Assurance  400 DH")
            {
                _ = lblMontant.Text == "LE MONTANT TOTAL EST 400 DH";
            }
            if (cbxPaiementde.SelectedItem == "Fais d'inscription 500 DH") 
 
            {
                _ = lblMontant.Text == " LE MONTANT TOTAL EST 500 DH";
            }
            if (cbxPaiementde.SelectedItem == "Transport 200 DH")
            {
                _ = lblMontant.Text == " LE MONTANT TOTAL EST 200 DH";
            }
            if (cbxPaiementde.SelectedItem == "Repas 200DH")
            {
                _ = lblMontant.Text == "LE MONTANT TOTAL EST 200 DH";
            }
            if (cbxPaiementde.SelectedItem == "Mois et Assurance 1700 DH")
            {
                _ = lblMontant.Text == "LE MONTANT TOTAL EST 1700 DH";
            }
            if (cbxPaiementde.SelectedItem == "Mois et Fais d'inscription 1800 DH")
            {
                _ = lblMontant.Text == "LE MONTANT TOTAL EST 1800 DH";
            }
            if (cbxPaiementde.SelectedItem == "Mois et Fais d'inscription et Assurance 2200 DH")
            {
                _ = lblMontant.Text == "LE MONTANT TOTAL EST 2200 DH";
            }
            if (cbxPaiementde.SelectedItem == "Mois et Repas 1500 DH")
            {
                _ = lblMontant.Text == "LE MONTANT TOTAL EST 1500 DH";

            }
            if (cbxPaiementde.SelectedItem == "Mois et Transport 1500 DH")
            {
                _ = lblMontant.Text == "LE MONTANT TOTAL EST 1500 DH";
            }
            if (cbxPaiementde.SelectedItem == "Mois et Repas et Transport 1700 DH")
            {
                _ = lblMontant.Text == "LE MONTANT TOTAL EST 1700 DH";
            }
            if (cbxPaiementde.SelectedItem == "Mois et Fais d'inscription et Assurance et Transport et Repas 2600 DH")
            {
                _ = lblMontant.Text == "LE MONTANT TOTAL EST 2600 DH";
            }
            if (cbxPaiementde.SelectedItem == "Mois et Fais d'inscription et Assurance et Transport 2400 DH")
            {
                _ = lblMontant.Text == "2400 DH";
            }
            if (cbxPaiementde.SelectedItem == "Mois et Fais d'inscription et Assurance  et Repas 2400 DH")
            {
                _ = lblMontant.Text == "LE MONTANT TOTAL EST 2400 DH";
            }
        }

                private void btnAjouter_Click(object sender, EventArgs e)
              {
            if (btnAjouter.Text == "Ajouter")
            {
                string[] t = new string[] { txtnum.Text, txtnom.Text, cbxMois.Text, dtpDateF.Text, txtAdresse.Text, dtpDateEcheance.Text, cbxPaiementde.Text, lblMontant.Text };
                ListViewItem LS = new ListViewItem(t);
                lsvFacture.Items.Add(LS);

            }
            else
            {
                lsvFacture.Items[indice].SubItems[0].Text = txtnum.Text;
                lsvFacture.Items[indice].SubItems[1].Text = txtnom.Text;
                lsvFacture.Items[indice].SubItems[2].Text = cbxMois.Text;
                lsvFacture.Items[indice].SubItems[3].Text = dtpDateF.Text;
                lsvFacture.Items[indice].SubItems[4].Text = txtAdresse.Text;
                lsvFacture.Items[indice].SubItems[5].Text = dtpDateEcheance.Text;
                lsvFacture.Items[indice].SubItems[6].Text = cbxPaiementde.Text;
                lsvFacture.Items[indice].SubItems[7].Text = lblMontant.Text;


                btnAjouter.Text = "Ajouter";
            }
        }

        private void frmFacture_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Fonctionnaire.txt");
            string ligne = string.Empty;
            while ((ligne = sr.ReadLine()) != null)
            {
                string[] t = ligne.Split('/');
                ListViewItem it = new ListViewItem(t);
                lsvFacture.Items.Add(it);

            }
            sr.Close();
        }
        int index;

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvFacture.SelectedItems.Count > 0)
            {
                indice = lsvFacture.SelectedIndices[0];
                txtnum.Text = lsvFacture.Items[indice].SubItems[1].Text;
                txtnom.Text = lsvFacture.Items[indice].SubItems[2].Text;
                cbxMois.Text = lsvFacture.Items[indice].SubItems[3].Text;
                dtpDateF.Text = lsvFacture.Items[indice].SubItems[4].Text;
                txtAdresse.Text = lsvFacture.Items[indice].SubItems[5].Text;
                dtpDateEcheance.Text = lsvFacture.Items[indice].SubItems[6].Text;
                cbxPaiementde.Text = lsvFacture.Items[indice].SubItems[7].Text;
                lblMontant.Text = lsvFacture.Items[indice].SubItems[8].Text;
                btnAjouter.Text = "Modifier";
            }



        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (lsvFacture.SelectedItems.Count > 0)
            {
                int indice = lsvFacture.SelectedIndices[0];
                DialogResult r = MessageBox.Show("voulez vous vraiment supprimer la ligne ", "Fonctionnaire", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    lsvFacture.Items.RemoveAt(indice);
                }

            }

        }

        private void btnEnregitrer_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Fonctionnaire.txt", false);
            foreach (ListViewItem li in lsvFacture.Items)
            {
                sw.WriteLine(li.SubItems[0].Text + "/" + li.SubItems[1].Text + "/" + li.SubItems[2].Text + "/" + li.SubItems[3].Text + "/" + li.SubItems[4].Text + "/" + li.SubItems[5].Text + "/" + li.SubItems[6].Text + "/" + li.SubItems[7].Text);
            }
            sw.Close();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            bool trouve = false;
            foreach (ListViewItem li in lsvFacture.Items)
            {
                if (li.SubItems[0].Text == txtNumRecherche.Text)
                    trouve = true;
            }
            if (trouve)
                MessageBox.Show(" ce Facture existe déjà ");
            else
                MessageBox.Show(" la Facture n'existe pas ");

        }

    }
}