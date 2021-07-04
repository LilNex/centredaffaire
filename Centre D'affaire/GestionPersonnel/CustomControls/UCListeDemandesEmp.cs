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
    public partial class UCListeDemandesEmp : UserControl
    {
        private ClsEmploye emp;

        public ClsEmploye EmployeLogged
        {
            get => emp; set
            {
                emp = value;
            }
        }
        public UCListeDemandesEmp()
        {
            InitializeComponent();
        }

        private void UCListeDemandes_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Demission");
            comboBox1.Items.Add("Congé");
        }
        public void loadForm()
        {
            //Functions.setupDgv(this);
            dgvListeDemandes.DataSource = null;
            //dgvListeDemandes.Columns["Id"].Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Demission")
            {
                dgvListeDemandes.DataSource = null;
                dgvListeDemandes.DataSource = (from x in Demission.ListeDesDemission
                                              where x.Employe.Num == EmployeLogged.Num
                                              select x).ToList();
            }
            else
            {
                dgvListeDemandes.DataSource = null;
                dgvListeDemandes.DataSource = (from x in Congé.ListeDesCongé
                                               where x.Employe.Num == EmployeLogged.Num
                                               select x).ToList();
            }
        }
    }
}
