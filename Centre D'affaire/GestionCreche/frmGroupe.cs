using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionCreche
{
    public partial class frmGroupe : Form
    {
        public object Fonctionnaire { get; private set; }

        public frmGroupe()
        {
            InitializeComponent();
        }

        private void frmGroupe_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string[] tInfos = new string[] { cbxGroupe.Text, txtNom.Text, txtNum.Text };
            ListViewItem List = new ListViewItem(tInfos);

            lsvGroupe.Items.Add(List);
           
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
           if (lsvGroupe.SelectedIndices.Count > 0)
               lsvGroupe.Items.RemoveAt(lsvGroupe.SelectedIndices[0]);

           else
                MessageBox.Show("selectionnez un ligne");
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvGroupe.SelectedIndices.Count > 0)
            {
                DialogResult result = MessageBox.Show("voulez vous vraiment supprimer la ligne", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    lsvGroupe.Items.RemoveAt(lsvGroupe.SelectedIndices[0]);
                }
            }

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvGroupe.SelectedIndices.Count > 0)
            {
                int indice = lsvGroupe.SelectedIndices[0];
                cbxGroupe.Text = lsvGroupe.Items[indice].SubItems[0].Text;
                txtNom.Text = lsvGroupe.Items[indice].SubItems[1].Text;
                txtNum.Text = lsvGroupe.Items[indice].SubItems[2].Text;
            }


        }
    }
}
