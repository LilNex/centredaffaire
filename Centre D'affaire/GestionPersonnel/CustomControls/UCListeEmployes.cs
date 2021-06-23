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
    public partial class UCListeEmployes : UserControl
    {
        public UCListeEmployes()
        {
            InitializeComponent();
        }
        public void reloadForm()
        {
            dgvListeEmployes.DataSource = null;
            dgvListeEmployes.DataSource = Functions.getListemployes();
        }
        private void UCListeEmployes_Load(object sender, EventArgs e)
        {
            dgvListeEmployes.Font = new Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvListeEmployes.BackgroundColor = Color.White; 
            reloadForm();
        }

        private void txtRechercheNum_TextChanged(object sender, EventArgs e)
        {
            var querry = from x in Functions.getListemployes()
                         where x.Num.Contains(txtRechercheNum.Text.ToLower()) && x.Nom.ToLower().Contains(txtRechercheNom.Text.ToLower())
                         select x;
            dgvListeEmployes.DataSource = querry.ToList();
        }

        private void txtRechercheNom_TextChanged(object sender, EventArgs e)
        {
            var querry = from x in Functions.getListemployes()
                         where x.Num.Contains(txtRechercheNum.Text.ToLower()) && x.Nom.ToLower().Contains(txtRechercheNom.Text.ToLower())
                         select x;
            dgvListeEmployes.DataSource = querry.ToList();
        }
    }
}
