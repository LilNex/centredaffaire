using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    public partial class UCModifPoste : UserControl
    {
        public UCModifPoste()
        {
            InitializeComponent();
        }
        

        private clsPoste _poste;
        public clsPoste Poste { get => _poste; set {
                _poste = value;
                if(_poste is clsPoste)
                {
                    reloadForm();
                }

            } }

        public void reloadForm()
        {
            txtDepNom.Text = _poste.Nom;
            txtDepNum.Text = _poste.Num;
            dgvListeEmploye.DataSource = null;
            dgvListeEmploye.DataSource = _poste.listeDesEmployé;
            cmbEmpManager.DataSource = null;
            cmbEmpManager.DataSource = _poste.listeDesEmployé;

            cmbEmpManager.SelectedItem = _poste.Manager;
            //txtNumDep.Text = _dep.Tel;
        }

        private void btnMofidDep_Click(object sender, EventArgs e)
        {
            _poste.Nom = txtDepNom.Text;
            _poste.Num = txtDepNum.Text;
            _poste.Manager = cmbEmpManager.SelectedItem as ClsEmploye;
            clsPoste.ModifierPoste(_poste);

        }

        private void btnSuppEmp_Click(object sender, EventArgs e)
        {
            ClsEmploye emp = dgvListeEmploye.CurrentRow.DataBoundItem as ClsEmploye;
            _poste.listeDesEmployé.Remove(emp);
            //_poste.ModifierDepartement(_poste);
            reloadForm();
        }

        private void UCModifDepartement_Load(object sender, EventArgs e)
        {

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Functions.clearForm(this);
        }
    }
}
