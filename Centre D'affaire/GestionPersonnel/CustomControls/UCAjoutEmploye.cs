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

        private void UCAjoutEmploye_Load(object sender, EventArgs e)
        {
            cmbDeparts.DataSource = null;
            cmbDeparts.Items.Add("Choisissez un departement");
            cmbDeparts.Text = "Choisissez un departement";

            cmbPoste.DataSource = null;
            cmbPoste.Items.Add("Choisissez un poste");
            cmbPoste.Text = "Choisissez un poste";
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
    }
}
