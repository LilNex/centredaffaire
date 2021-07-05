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
    public partial class frmPrincipal_Employe : Form
    {
        private ClsEmploye userLogged;
        public ClsEmploye UserLogged
        {
            get => userLogged;
            set
            {
                userLogged = value;
                ucProfil1.loggedUser = value;
                ucDemandesEmp1.EmployeLogged = value;
            }

        }

        public CultureInfo cultureInfo = new CultureInfo("fr-FR");
        public CustomControls.frmAlert alert = new CustomControls.frmAlert();
        

        public frmPrincipal_Employe()
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
            
            //pnlError.BringToFront();
            //alert.showError("test", CustomControls.frmAlert.errorType.Error);
            
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();

        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnDashboard.Top;
            //ucDashboard.BringToFront();
        }

        

        private void btnDemandes_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnDemandes.Top;
            
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
