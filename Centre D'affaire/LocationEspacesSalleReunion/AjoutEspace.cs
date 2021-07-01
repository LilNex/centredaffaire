using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.LocationEspacesSalleReunion
{
    public partial class AjoutEspace : Form
    {
        public event Action loadForm;

        public AjoutEspace()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ClsEspaces espace = new ClsEspaces();
            espace.Nom = txtNom.Text;
            espace.Numero = txtNum.Text;
            espace.Adresse = txtAdresse.Text;
            espace.Etage = int.Parse(numericUpDown1.Value.ToString());
            espace.MontantloyeJour = float.Parse(txtMontantJour.Text);
            espace.MontantloyeHeure = float.Parse(txtMontantHeure.Text);
            espace.Ville = txtVille.Text;
            if (rdbBureau.Checked)
            {
                espace.Type = EspaceType.Bureau;
            }
            if (rdbReunion.Checked)
            {
                espace.Type = EspaceType.SalleReunion;
            }

            ClsEspaces.ListeEspaces.Add(espace);
            ClsEspaces.SauvegarderEspaces();

            loadForm();
            this.Close();
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {
            if (!txtMontantJour.Text.All(char.IsNumber))
            {
                txtMontantJour.Text.Remove(txtMontantJour.Text.Length - 1);
            }
        }

        private void AjoutEspace_Load(object sender, EventArgs e)
        {
            ClsEspaces.ChargerEspaces();

        }
    }
}
