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
    public partial class UCModifDepartement : UserControl
    {
        public UCModifDepartement()
        {
            InitializeComponent();
        }

        private ClsDepartement _dep;
        public ClsDepartement Departement { get => _dep; set {
                _dep = value;
                if(_dep is ClsDepartement)
                {
                    reloadForm();
                }

            } }

        public void reloadForm()
        {
            txtDepNom.Text = _dep.Nom;
            txtDepNum.Text = _dep.Num;
            dgvListePoste.DataSource = null;
            dgvListePoste.DataSource = _dep.ListePoste;
            cmbEmpManager.DataSource = null;
            cmbEmpManager.DataSource = _dep.getListemployes();

            cmbEmpManager.SelectedItem = _dep.Manager;
            //txtNumDep.Text = _dep.Tel;
        }

        private void btnMofidDep_Click(object sender, EventArgs e)
        {
            _dep.Nom = txtDepNom.Text;
            _dep.Num = txtDepNum.Text;
            _dep.Manager = cmbEmpManager.SelectedItem as ClsEmploye;
            _dep.ModifierDepartement(_dep);
            ClsDepartement.saveListeDeps();

            reloadForm();
            this.SendToBack();

        }

        private void btnSuppPoste_Click(object sender, EventArgs e)
        {
            clsPoste poste = dgvListePoste.CurrentRow.DataBoundItem as clsPoste;
            _dep.ListePoste.RemoveAt(_dep.recherchePosteNum(poste.Num));
            _dep.ModifierDepartement(_dep);
            reloadForm();
            ClsDepartement.saveListeDeps();
            this.SendToBack();

        }

        private void UCModifDepartement_Load(object sender, EventArgs e)
        {

        }
    }
}
