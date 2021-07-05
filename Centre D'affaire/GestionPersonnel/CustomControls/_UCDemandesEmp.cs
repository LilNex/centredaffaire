using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    public partial class UCDemandesEmp : UserControl
    {
        private List<ClsDepartement> listDeparts = new List<ClsDepartement>();
        private ClsEmploye emp;

        public ClsEmploye EmployeLogged { get => emp; set {
                emp = value;
                ucListeDemandesEmp1.EmployeLogged = value;
            } }

        public UCDemandesEmp()
        {
            InitializeComponent();
        }

        public void loadForm()
        {
            //Functions.clearForm(ucListeDepartement);
            Functions.setupDgv(this);

            Functions.setCellStyle(this);
        }
        private void UCDepartements_Load(object sender, EventArgs e)
        {
            loadForm();

        }

        private void btnListeDemandes_Click(object sender, EventArgs e)
        {
            ucListeDemandesEmp1.BringToFront();

        }

        

        

        private void btnDemission_click(object sender, EventArgs e)
        {
            FrmDemission dem = new FrmDemission();
            dem.ShowDialog();
        }

        private void btnConge_Click(object sender, EventArgs e)
        {
            FrmCongée conge = new FrmCongée();
            conge.ShowDialog();
        }
    }
}
