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

        
                private void btnAjouter_Click(object sender, EventArgs e)
              {
            if (btnAjouter.Text == "Ajouter")
            {
                string[] t = new string[] { txtnum.Text, txtnom.Text, cbxMois.Text, dtpDateF.Text, txtAdresse.Text, dtpDateEcheance.Text, lblM.Text };
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
                lsvFacture.Items[indice].SubItems[6].Text =lblM.Text;

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
                lblM.Text = lsvFacture.Items[indice].SubItems[7].Text;

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

        private void button1_Click(object sender, EventArgs e)
        {
            int p1;
            int p2;
            int p3;
            int p4;
            int p5;
            Double Facture;
            if (chbxMois.Checked)
            {
                p1 = 1300;
            }
            else
            {
                p1 = 0;
            }

            if (chbxAssurances.Checked)
            {
                p2 = 3000;
            }
            else
            {
                p2 = 0;
            }

            if (chbxinscription.Checked)
            {
                p3 = 250;
            }
            else
            {
                p3 = 0;
            }
            if (chbxTransporte.Checked)
            {
                p4 = 200;
            }
            else
            {
                p4 = 0;
            }

            if (chbxRepas.Checked)
            {
                p5 = 200;
            }
            else
            {
                p5 = 0;
            }

            Facture = p1 + p2 + p3 + p4 + p5 ;
             lblM.Text = Facture.ToString();
            ;
        }
    }
}