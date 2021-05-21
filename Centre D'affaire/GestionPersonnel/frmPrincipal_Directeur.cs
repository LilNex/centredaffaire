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
        public CultureInfo cultureInfo = new CultureInfo("fr-FR");
        public frmPrincipal_Directeur()
        {   
            InitializeComponent();
            setupForm();
            ClsDepartement.loadListeDeps();
            //clsRFID rFID = new clsRFID();
            //rFID.connectArduino();
        }
        public void setupForm()
        {
            timer.Start();
            pnlActive.Height = btnDashboard.Height;
            pnlActive.Top = btnDashboard.Top;
            ucDashboard.BringToFront();
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
            ucDashboard.BringToFront();
        }

        private void btnEmployes_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnEmployes.Top;
            ucEmployes.BringToFront();


        }

        private void btnGstPaie_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnGstPaie.Top;
        }

        private void btnDemandes_Click(object sender, EventArgs e)
        {
            pnlActive.Top = btnDemandes.Top;
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

        private void ucDepartements_Load(object sender, EventArgs e)
        {

        }
    }
}
