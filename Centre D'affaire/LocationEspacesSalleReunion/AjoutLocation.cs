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
	public partial class AjoutLocation : Form
	{
        public event Action loadForm;

		private bool verifDispo()
        {
			DateTime DateDebut = dtpDateDebut.Value;
			DateDebut = ClsLocation.ChangeTime(DateDebut, dtpHeureDebut.Value.Hour, dtpHeureDebut.Value.Minute);
			DateTime DateFin = dtpDateFin.Value;
			DateFin = ClsLocation.ChangeTime(DateFin, dtpHeureFin.Value.Hour, dtpHeureFin.Value.Minute);
		
			ClsEspaces espaceLoue = cmbEspace.SelectedItem as ClsEspaces;
			ClsLocation location = new ClsLocation();
            try
            {
				location.Espace = espaceLoue;
				location.DateDebut = DateDebut;
				location.DateFin = DateFin;

				if (rdbHeure.Checked)
				{
					location.Type = LocationType.Heure;
					lblTotal.Text = location.CalculMontantFinal().ToString() + " DH";
				}
				else if (rdbJour.Checked)
				{
					location.Type = LocationType.Jour;
					lblTotal.Text = location.CalculMontantFinal().ToString() + " DH";
				}
				if (location.verifierDisponibilité())
				{
					lblDispo.Text = "Oui";
					lblDispo.ForeColor = Color.Green;
					return true;
				}
				else
				{
					lblDispo.Text = "Non";
					lblDispo.ForeColor = Color.Red;
					return false;
				}

				
			}
			catch(NotImplementedException e)
            {
				return false;

			}

		}

		public AjoutLocation()
		{
			InitializeComponent();
	    }

		private void AjoutLocation_Load(object sender, EventArgs e)
		{
			ClsEspaces.ChargerEspaces();
			ClsLocation.ChargerLocations();
		}

		private void btnAjouter_Click(object sender, EventArgs e)
		{
			DateTime DateDebut = dtpDateDebut.Value;
			DateDebut = ClsLocation.ChangeTime(DateDebut, dtpHeureDebut.Value.Hour, dtpHeureDebut.Value.Minute);
			DateTime DateFin = dtpDateFin.Value;
			DateFin = ClsLocation.ChangeTime(DateFin, dtpHeureFin.Value.Hour, dtpHeureFin.Value.Minute);

			ClsLocataire locataire = new ClsLocataire();
			locataire.Numero = txtNum.Text;
			locataire.Nom = txtNom.Text;
			locataire.Prenom = txtPrenom.Text;
			locataire.Adresse = txtAdresse.Text;
			locataire.Tel = txtTel.Text;
			

			ClsEspaces espaceLoue = cmbEspace.SelectedItem as ClsEspaces;

			try
			{
				LocationType type;
                if (rdbHeure.Checked)
                {
					type = LocationType.Heure;
                }
				else if (rdbJour.Checked)
                {
					type = LocationType.Jour;
                }
                else
                {
					throw new NotImplementedException("Choisissez un type de location.");
                }
				ClsLocation location = new ClsLocation(espaceLoue, locataire, DateDebut, DateFin, type);
				if (location.verifierDisponibilité())
				{
					ClsLocation.ListeLocations.Add(location);
					ClsLocation.SauvegarderLocations();
					MessageBox.Show("Réservation ajouté avec succès !");
                    loadForm();
					this.Close();
				}
				else
				{
					MessageBox.Show("Une reservation est déja prise dans le crénaux choisi.");

				}

			}
			catch (NotImplementedException ex)
			{
				MessageBox.Show(ex.Message);
			}




		}

		private void cmbEspace_DropDown(object sender, EventArgs e)
		{
			cmbEspace.Items.Clear();
			foreach (ClsEspaces item in ClsEspaces.ListeEspaces)
			{
				cmbEspace.Items.Add(item);
			}
		}

		private void cmbEspace_SelectedIndexChanged(object sender, EventArgs e)
		{
			ClsEspaces espace = cmbEspace.SelectedItem as ClsEspaces;
			lblAdresse.Text = espace.Adresse;
			lblVille.Text = espace.Ville;
			lblMontantJour.Text = espace.MontantloyeJour.ToString() + " DH";
			lblMontantHeure.Text = espace.MontantloyeHeure.ToString() + " DH";
			if (espace.Type == EspaceType.Bureau)
			{
				lblTypeEspace.Text = "Bureau";
			}
			else if (espace.Type == EspaceType.SalleReunion)
			{
				lblTypeEspace.Text = "Salle de réunion";
			}
			verifDispo();
		}

		private void lblVille_Click(object sender, EventArgs e)
		{

		}

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
			verifDispo();
		}

        private void rdbJour_CheckedChanged(object sender, EventArgs e)
        {
			verifDispo();

		}

        private void rdbHeure_CheckedChanged(object sender, EventArgs e)
        {
			verifDispo();

		}
    }
}
