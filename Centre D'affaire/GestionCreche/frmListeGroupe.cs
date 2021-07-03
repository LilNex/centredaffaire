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
    public partial class frmListeGroupe : Form
    {
        private object cn;
        private bool trouve;

        public frmListeGroupe()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void btnenregitrer_Click(object sender, EventArgs e)
        {
            StreamWriter saveListe = new StreamWriter("mesListesGroupes.txt", true);
            foreach (ListViewItem maListe in lsvListeGroupe.Items)
            {
                saveListe.WriteLine(maListe.SubItems[0].Text + "/" + maListe.SubItems[1].Text + "/" + maListe.SubItems[2].Text + "/" + maListe.SubItems[3].Text);

            }
            saveListe.Close();
        }

        private void frmListeGroupe_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("meslistesGroupes.txt");
            string ligne = string.Empty;
            while((ligne = sr.ReadLine())!= null)
            {
                string[] t = ligne.Split();
                ListViewItem it = new ListViewItem(t);
                lsvListeGroupe.Items.Add(it);
            }
            sr.Close();
        }

        private void dgvListeGroupe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string[] t = new string[] { txtnum.Text, txtnom.Text, txtprenom.Text, cbGroupe.Text };
            ListViewItem ls = new ListViewItem(t);
            lsvListeGroupe.Items.Add(ls);

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if(lsvListeGroupe.SelectedIndices.Count>0)
            lsvListeGroupe.Items.RemoveAt(lsvListeGroupe.SelectedIndices[0]);
        }

        private void btnrechercher_Click(object sender, EventArgs e)
        {
            bool trouve = false;
            foreach(ListViewItem li in lsvListeGroupe.Items)
            {
                if(li.SubItems[0].Text==txtnom.Text)
                
                    trouve = true;
                
                
            }
            if (trouve)
            {
                MessageBox.Show("le num existe déjà ");
            }
            else
                MessageBox.Show("le num n'existe pas ");
        }
    }
}
