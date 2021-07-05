using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionPersonnel
{
    public partial class frmPrincipal_Directeur : Form
    {
        private ClsEmploye userLogged;
        public ClsEmploye UserLogged
        {
            get => userLogged;
            set
            {
                userLogged = value;
                ucProfil1.loggedUser = value;
            }

        }

        public CultureInfo cultureInfo = new CultureInfo("fr-FR");
        public CustomControls.frmAlert alert = new CustomControls.frmAlert();
        

        public frmPrincipal_Directeur()
        {   
            InitializeComponent();
            setupForm();
            ClsDepartement.loadListeDeps();
            Demission.loadListeDemission();
            Congé.loadListeConges();
            Functions.setFont(this);
            //clsRFID rFID = new clsRFID();
            //rFID.connectArduino();
        }
        public void setupForm()
        {
            timer.Start();
            pnlActive.Height = btnDashboard.Height;
            pnlActive.Top = btnDashboard.Top;
            ucDashboard.BringToFront();
            //pnlError.BringToFront();
            //alert.showError("test", CustomControls.frmAlert.errorType.Error);
            
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

            Application.Exit();

        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnDashboard.Top;
            ucDashboard.BringToFront();
        }

        private void btnEmployes_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnEmployes.Top;
            ucEmployes.BringToFront();
            ucEmployes.UCListeEmployes.reloadForm();

        }

        private void btnGstPaie_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnGstPaie.Top;
        }

        private void btnDemandes_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnDemandes.Top;
            ucDemandes.BringToFront();
        }

        private void btnDeparts_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnDeparts.Top;
            ucDepartements.loadForm();
            ucDepartements.BringToFront();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ucDashboard.DateNow = DateTime.Now.ToString("F", cultureInfo).ToUpper();
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnParametre.Top;

        }

        private void workerError_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pnlDrag_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
