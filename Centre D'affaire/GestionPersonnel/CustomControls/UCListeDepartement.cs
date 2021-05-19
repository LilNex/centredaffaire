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
        }
        private void UCListeDepartement_Load(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
