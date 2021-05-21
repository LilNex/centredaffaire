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
    }
}
