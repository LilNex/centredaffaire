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
    public partial class ArchiveFacture : Form
    {

        public event Action loadForm;

        private ClsFacture _loc;
        public ClsFacture Loc { get => _loc; set { 
                _loc = value;
                txtNum.Text = _loc.Location.Locataire.Numero;
                txtNom.Text = _loc.Location.Locataire.Nom;
                txtPrenom.Text = _loc.Location.Locataire.Prenom;
                txtTel.Text = _loc.Location.Locataire.Tel;
                txtAdresse.Text = _loc.Location.Locataire.Adresse;
                lblEspace.Text = _loc.Location.Espace.ToString();
                lblAdresse.Text = _loc.Location.Espace.Adresse;
                lblVille.Text = _loc.Location.Espace.Ville;
                lblMontantJour.Text = _loc.Location.Espace.MontantloyeJour.ToString() + " DH";
                lblMontantHeure.Text = _loc.Location.Espace.MontantloyeHeure.ToString() + " DH";
                dtpDateDebut.Value = _loc.Location.DateDebut;
                dtpHeureDebut.Value = _loc.Location.DateDebut;
                dtpDateFin.Value = _loc.Location.DateFin;
                dtpHeureFin.Value = _loc.Location.DateFin;
                lblDate.Text = _loc.DateFacturation.ToString("f");

                //lblHeures.Text = Math.Round( _loc.getDureeLocation().TotalHours).ToString() + " Heures";
                lblHeures.Text = _loc.Location.DureeTotalHeure + " Heures";
                if(Math.Round(_loc.Location.getDureeLocation().TotalHours) >= 24)
                {
                    lblJour.Text = Math.Round(_loc.Location.getDureeLocation().TotalDays, 1).ToString() +" Jours";

                }
                switch (_loc.Location.Type)
                {
                    case LocationType.Heure:
                        lblTotal.Text = _loc.Location.CalculMontantFinal().ToString() + " DH";
                        rdbHeure.Checked = true;
                        break;
                    case LocationType.Jour:
                        lblTotal.Text = _loc.Location.CalculMontantFinal().ToString() + " DH";
                        rdbJour.Checked = true;

                        break;
                }
            }
        }


        public ArchiveFacture()
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




    }
}
