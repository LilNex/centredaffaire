using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    public partial class UCAjoutEmploye : UserControl
    {
        //public List<clsDepartememnt> ListeDepartements { get; set; }      to update
        public UCAjoutEmploye()
        {
            InitializeComponent();
        }

        public void reloadForm()
        {
            //cmbDeparts.DataSource = null;
            //cmbDeparts.DataSource = ClsDepartement.ListeDepartement;
            cmbDeparts.Items.Clear();
            cmbDeparts.Items.Add("Choisissez un departement");
            cmbDeparts.Text = "Choisissez un departement";

            foreach(ClsDepartement dep in ClsDepartement.ListeDepartement)
            {
                cmbDeparts.Items.Add(dep);
            }

            //cmbPoste.DataSource = null;
            cmbPoste.Items.Clear();
            cmbPoste.Items.Add("Choisissez un poste");
            cmbPoste.Text = "Choisissez un poste";

        }
        private void UCAjoutEmploye_Load(object sender, EventArgs e)
        {
            reloadForm();
        }

        private void rdbH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbF_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        

        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDeparts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeparts.SelectedItem is ClsDepartement)
            {
                cmbPoste.Items.Clear();
                cmbPoste.Items.Add("Choisissez un poste");
                cmbPoste.Text = "Choisissez un poste";
                foreach (clsPoste Poste in ((ClsDepartement)cmbDeparts.SelectedItem).ListePoste)
                {
                    cmbPoste.Items.Add(Poste);
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ClsEmploye employe = new ClsEmploye(txtNum.Text,txtNom.Text, txtPrenom.Text,txtCIN.Text);
            if(cmbDeparts.SelectedItem is ClsDepartement)
            {
                if (cmbPoste.SelectedItem is clsPoste)
                {
                    //((clsPoste)cmbPoste.SelectedItem).ajouterEmploye(employe);
                    for (int i = 0; i < ClsDepartement.ListeDepartement.Count; i++)
                    {
                        if (ClsDepartement.ListeDepartement[i].Num == ((ClsDepartement)cmbDeparts.SelectedItem).Num)
                        {
                            for (int y = 0; y < ClsDepartement.ListeDepartement[i].ListePoste.Count; y++)
                            {
                                if (ClsDepartement.ListeDepartement[i].ListePoste[y].Num == ((clsPoste)cmbPoste.SelectedItem).Num)
                                {
                                    ClsDepartement.ListeDepartement[i].ListePoste[y].ajouterEmploye(employe);
                                    ClsDepartement.saveListeDeps();
                                }
                            }
                        }
                    }
                }
            }
            
        }

        private void txtRechercheNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
