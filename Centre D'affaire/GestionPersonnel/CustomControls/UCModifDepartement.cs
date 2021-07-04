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
            //txtNumDep.Text = _dep.Tel;
        }

        private void btnMofidDep_Click(object sender, EventArgs e)
        {
            _dep.Nom = txtDepNom.Text;
            _dep.Num = txtDepNum.Text;

            _dep.ModifierDepartement(_dep);

        }
    }
}
