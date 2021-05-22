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
    public partial class UCListeDepartement : UserControl
    {
        public event Action reloadForm;

        public DataGridView dgvListeEmploye { get=> dgvListeDeps; set=> dgvListeDeps = value; }
        public UCListeDepartement()
        {
            InitializeComponent();

        }
        
        public void loadForm()
        {
            dgvListeDeps.DataSource = ClsDepartement.ListeDepartement;
            dgvListeDeps.DefaultCellStyle.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
        }
        private void UCListeDepartement_Load(object sender, EventArgs e)
        {
            loadForm();

        }

        private void dgvListeDeps_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListePoste.DataSource = ((ClsDepartement)dgvListeDeps.CurrentRow.DataBoundItem).ListePoste;
        }

        private void dgvListeDeps_CellStyleChanged(object sender, DataGridViewCellEventArgs e)
        {
            //dgvListeDeps.DefaultCellStyle.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }
    }
}
