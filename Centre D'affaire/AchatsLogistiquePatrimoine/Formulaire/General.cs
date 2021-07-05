using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void FormCatalogue_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(70 , 0 , 0, 0);
            panel2.BackColor = Color.FromArgb(70, 0, 0, 0);
           


        }

        private void btnGPersonnel_Click(object sender, EventArgs e)
        {
            GestionPersonnel.frmGPersonnel frmGPersonnel = new GestionPersonnel.frmGPersonnel();
            frmGPersonnel.ShowDialog();
        }

        private void btnCafeRestaurant_Click(object sender, EventArgs e)
        {
            GestionCafeRestaurant.Form1 form1 = new GestionCafeRestaurant.Form1();
            form1.ShowDialog();
        }

        private void btnLocEspaces_Click(object sender, EventArgs e)
        {
            LocationEspacesSalleReunion.frmLESR frmLESR = new LocationEspacesSalleReunion.frmLESR();
            frmLESR.ShowDialog();
        }

        private void btnSalleDeJeux_Click(object sender, EventArgs e)
        {
            GestionSalleDeJeux.FrmMENU1 frmMENU = new GestionSalleDeJeux.FrmMENU1();
            frmMENU.ShowDialog();
        }

        private void btnCreche_Click(object sender, EventArgs e)
        {
            GestionCreche.frmGC frm = new GestionCreche.frmGC();
            frm.ShowDialog();
        }

        private void btnAchatService_Click(object sender, EventArgs e)
        {
            AchatsLogistiquePatrimoine.Catalogue catalogue = new Catalogue();
            catalogue.ShowDialog();
        }

        private void btnParking_Click(object sender, EventArgs e)
        {
            GestionParking.LoadingPage loadingPage = new GestionParking.LoadingPage();
            loadingPage.ShowDialog();
        }

        private void btnSalledeSport_Click(object sender, EventArgs e)
        {
            GestionSalleDeSport.btnSeconnecter frm = new GestionSalleDeSport.btnSeconnecter();
            frm.ShowDialog();
        }
    }
}
