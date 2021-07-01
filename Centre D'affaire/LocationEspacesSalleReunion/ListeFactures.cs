using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.LocationEspacesSalleReunion
{
    public partial class ListeFactures : Form
    {
        public event Action loadForm;

        public ListeFactures()
        {
            InitializeComponent();
        }

        private void ListeFactures_Load(object sender, EventArgs e)
        {
            ClsFacture.ChargerArchive();
            dgvFactures.DataSource = ClsFacture.ListeFactures;
            
        }

        private void dgvFactures_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ArchiveFacture frmFacture = new ArchiveFacture();
            frmFacture.loadForm += loadForm;
            frmFacture.Loc = dgvFactures.CurrentRow.DataBoundItem as ClsFacture;

            frmFacture.ShowDialog();
        }
    }
}
