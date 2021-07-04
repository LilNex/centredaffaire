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
    public partial class frmGroupes : Form
    {
        public frmGroupes()
        {
            InitializeComponent();
        }

        private void txtNomRechercher_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text == "Ajouter")
            {
                string[] t = new string[] { txtNom.Text, txtNUm.Text, cmbGroupe.Text };
                ListViewItem LS = new ListViewItem(t);
                lsvGroupe.Items.Add(LS);

            }
            else
            {
                lsvGroupe.Items[indice].SubItems[0].Text = txtNUm.Text;
                lsvGroupe.Items[indice].SubItems[1].Text = txtNom.Text;
                lsvGroupe.Items[indice].SubItems[2].Text = cmbGroupe.Text;
                btnAjouter.Text = "Ajouter";
            }

        }

       


        private void frmGroupes_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Fonctionnaire.txt");
            string ligne = string.Empty;
            while ((ligne = sr.ReadLine()) != null)
            {
                string[] t = ligne.Split('/');
                ListViewItem it = new ListViewItem(t);
                lsvGroupe.Items.Add(it);

            }
            sr.Close();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        { bool trouve = false;
            foreach (ListViewItem li in lsvGroupe.Items)
            {
                if (li.SubItems[0].Text == txtNomRechercher.Text)
                    trouve = true;
            }
            if (trouve)
                MessageBox.Show(" ce nom existe déjà ");
            else
                MessageBox.Show(" le nom n'existe pas ");


        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvGroupe.SelectedItems.Count > 0)
            {
                int indice = lsvGroupe.SelectedIndices[0];
                DialogResult r = MessageBox.Show("voulez vous vraiment supprimer la ligne ", "Fonctionnaire", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    lsvGroupe.Items.RemoveAt(indice);
                }

            }


        }
        int indice;

        private void ModifiertoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lsvGroupe.SelectedItems.Count > 0)
            {
                indice = lsvGroupe.SelectedIndices[0];
                txtNUm.Text = lsvGroupe.Items[indice].SubItems[1].Text;
                txtNom.Text = lsvGroupe.Items[indice].SubItems[2].Text;
                cmbGroupe.Text = lsvGroupe.Items[indice].SubItems[3].Text;
                btnAjouter.Text = "Modifier";
            }
            
        }

        private void btnEnregitrer_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Fonctionnaire.txt", false);
            foreach (ListViewItem li in lsvGroupe.Items)
            {
                sw.WriteLine(li.SubItems[0].Text + "/" + li.SubItems[1].Text + "/" + li.SubItems[2].Text);
            }
            sw.Close();
        }
    }
}
 