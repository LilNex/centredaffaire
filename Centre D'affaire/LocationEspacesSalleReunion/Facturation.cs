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
    public partial class Facturation : Form
    {

        public event Action loadForm;

        private ClsLocation _loc;
        public ClsLocation Loc { get => _loc; set { 
                _loc = value;
                txtNum.Text = _loc.Locataire.Numero;
                txtNom.Text = _loc.Locataire.Nom;
                txtPrenom.Text = _loc.Locataire.Prenom;
                txtTel.Text = _loc.Locataire.Tel;
                txtAdresse.Text = _loc.Locataire.Adresse;
                lblEspace.Text = _loc.Espace.ToString();
                lblAdresse.Text = _loc.Espace.Adresse;
                lblVille.Text = _loc.Espace.Ville;
                lblMontantJour.Text = _loc.Espace.MontantloyeJour.ToString() + " DH";
                lblMontantHeure.Text = _loc.Espace.MontantloyeHeure.ToString() + " DH";
                dtpDateDebut.Value = _loc.DateDebut;
                dtpHeureDebut.Value = _loc.DateDebut;
                dtpDateFin.Value = _loc.DateFin;
                dtpHeureFin.Value = _loc.DateFin;

                //lblHeures.Text = Math.Round( _loc.getDureeLocation().TotalHours).ToString() + " Heures";
                lblHeures.Text = _loc.DureeTotalHeure + " Heures";
                if(Math.Round(_loc.getDureeLocation().TotalHours) >= 24)
                {
                    lblJour.Text = Math.Round(_loc.getDureeLocation().TotalDays, 1).ToString() +" Jours";

                }
                switch (_loc.Type)
                {
                    case LocationType.Heure:
                        lblTotal.Text = _loc.CalculMontantFinal().ToString() + " DH";
                        rdbHeure.Checked = true;
                        break;
                    case LocationType.Jour:
                        lblTotal.Text = _loc.CalculMontantFinal().ToString() + " DH";
                        rdbJour.Checked = true;

                        break;
                }
            }
        }


        public Facturation()
        {
            InitializeComponent();
        }


        private void Facturation_Load(object sender, EventArgs e)
        {
            foreach(Control ctl in this.Controls)
            {
                if(ctl is TextBox)
                {
                    ctl.Enabled = false;
                }
                if(ctl is RadioButton)
                {
                    ctl.Enabled = false;
                }if(ctl is DateTimePicker)
                {
                    ctl.Enabled = false;
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if(DateTime.Now > _loc.DateDebut)
            {
                if ( MessageBox.Show("Cette réservation est deja en cours. Etes vous sur de la supprimer ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ClsLocation.ListeLocations.Remove(_loc))
                    {
                        MessageBox.Show("Reservation Supprimé !");
                        ClsLocation.SauvegarderLocations();
                        loadForm();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'annulation.");
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Etes-vous sur de supprimer la réservation ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ClsLocation.ListeLocations.Remove(_loc))
                    {
                        MessageBox.Show("Reservation Supprimé !");
                        ClsLocation.SauvegarderLocations();
                        loadForm();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'annulation.");
                    }
                }
            }
            
        }

        private void btnFacturer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmer la facturation", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ClsFacture.FacturerLocation(_loc);
                loadForm();
                this.Close();
            }
        }
    }
}
