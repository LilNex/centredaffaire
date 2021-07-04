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
    public partial class UCListePoste : UserControl
    {
        public event EventHandler<PosteModifEventArgs> ModifierPosteEvent;

        public UCListePoste()
        {
            InitializeComponent();
            
        }

        private void dgvListePostes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvListeEmployes.DataSource = ((clsPoste)dgvListePostes.CurrentRow.DataBoundItem).listeDesEmployé;
        }

        private void UCListePoste_Load(object sender, EventArgs e)
        {
            reloadForm();
        }
        public void reloadForm()
        {
            dgvListePostes.DataSource = Functions.getListPostes();

        }

        private void txtEmployeNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var querry = from x in ((clsPoste)dgvListePostes.CurrentRow.DataBoundItem).listeDesEmployé
                             where x.Num.Contains(txtEmployeNum.Text) && x.Nom.ToLower().Contains(txtEmployeNom.Text.ToLower())
                             select x;
                dgvListeEmployes.DataSource = querry.ToList();
            }
            catch (Exception ex)
            {
                dgvListeEmployes.DataSource = null;
            }
        }

        private void txtEmployeNom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var querry = from x in ((clsPoste)dgvListePostes.CurrentRow.DataBoundItem).listeDesEmployé
                             where x.Num.Contains(txtEmployeNum.Text) && x.Nom.ToLower().Contains(txtEmployeNom.Text.ToLower())
                             select x;
                dgvListeEmployes.DataSource = querry.ToList();
            }
            catch (Exception ex)
            {
                dgvListeEmployes.DataSource = null;
            }
        }

        private void txtPosteNum_TextChanged(object sender, EventArgs e)
        {
            var querry = from x in Functions.getListPostes()
                         where x.Num.Contains(txtPosteNum.Text.ToLower()) && x.Nom.ToLower().Contains(txtPosteNom.Text.ToLower())
                         select x;
            dgvListePostes.DataSource = querry.ToList();
        }

        private void txtPosteNom_TextChanged(object sender, EventArgs e)
        {
            var querry = from x in Functions.getListPostes()
                         where x.Num.Contains(txtPosteNum.Text.ToLower()) && x.Nom.ToLower().Contains(txtPosteNom.Text.ToLower())
                         select x;
            dgvListePostes.DataSource = querry.ToList();
        }

        private void btnModifPoste_Click(object sender, EventArgs e)
        {
            PosteModifEventArgs args = new PosteModifEventArgs();
            args.poste = dgvListePostes.CurrentRow.DataBoundItem as clsPoste;
            ModifierPosteEvent(this, args);
        }
    }
}
