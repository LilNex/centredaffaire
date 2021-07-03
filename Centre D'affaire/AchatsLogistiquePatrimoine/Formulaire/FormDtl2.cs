using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine.Formulaire
{
    public partial class FormDtl2 : Form
    {
        public FormDtl2()
        {
            InitializeComponent();

        }

        private void FormDtl2_Load(object sender, EventArgs e)
        {
            dgvCMd.DataSource = ClsListe.List_choix;

            foreach (DataGridViewColumn d in dgvCMd.Columns)
            {
                d.Visible = false;

            }

            dgvCMd.Columns["nom"].Visible = true;
            dgvCMd.Columns["quantite"].Visible = true;

            dgvCMd.Columns["nom"].ReadOnly = true;
            dgvCMd.Columns["quantite"].ReadOnly = false;

            dgvCMd.Columns["nom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCMd.Columns["quantite"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void dgvCMd_Paint(object sender, PaintEventArgs e)
        {

            //e.Graphics.DrawImage(Centre_D_affaire.Properties.Resources.feuille_page, new Point(0, 0));
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
