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

        public DataGridView dgvListDeps { get => dgvListeDeps; set => dgvListeDeps = value; }
        public event EventHandler<DepartementEventArgs> ModifierDepEvent;
        public UCListeDepartement()
        {
            InitializeComponent();

        }
        
        public void loadForm()
        {
            //Functions.setupDgv(this);
            dgvListeDeps.DataSource = ClsDepartement.ListeDepartement;
            dgvListeDeps.Columns["Id"].Visible = false;
            
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

        private void txtRechercheNum_TextChanged(object sender, EventArgs e)
        {
            var querry = from x in ClsDepartement.ListeDepartement
                         where x.Num.Contains(txtRechercheNum.Text) && x.Nom.ToLower().Contains(txtRechercheNom.Text.ToLower())
                         select x;
            dgvListeDeps.DataSource = querry.ToList();
        }

        private void txtRechercheNom_TextChanged(object sender, EventArgs e)
        {
            var querry = from x in ClsDepartement.ListeDepartement
                         where x.Num.Contains(txtRechercheNum.Text) && x.Nom.ToLower().Contains(txtRechercheNom.Text.ToLower())
                         select x;
            dgvListeDeps.DataSource = querry.ToList();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var querry = from x in ((ClsDepartement)dgvListeDeps.CurrentRow.DataBoundItem).ListePoste
                             where x.Num.Contains(txtPRNum.Text) && x.Nom.ToLower().Contains(txtPRNom.Text.ToLower())
                             select x;
                dgvListePoste.DataSource = querry.ToList();
            }
            catch (Exception ex)
            {
                dgvListePoste.DataSource = null;
            }
        }

        private void txtPRNom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var querry = from x in ((ClsDepartement)dgvListeDeps.CurrentRow.DataBoundItem).ListePoste
                             where x.Num.Contains(txtPRNum.Text) && x.Nom.ToLower().Contains(txtPRNom.Text.ToLower())
                             select x;
                dgvListePoste.DataSource = querry.ToList();
            }
            catch(Exception ex)
            {
                dgvListePoste.DataSource = null;
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            DepartementEventArgs args = new DepartementEventArgs();
            if(dgvListDeps.CurrentRow!= null)
                if(dgvListDeps.CurrentRow.DataBoundItem != null)
                args.departement = dgvListDeps.CurrentRow.DataBoundItem as ClsDepartement ;
            ModifierDepEvent(this, args);

        }
        protected virtual void Modifier_Event(DepartementEventArgs e)
        {
            EventHandler<DepartementEventArgs> handler = ModifierDepEvent;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }
    }
}
