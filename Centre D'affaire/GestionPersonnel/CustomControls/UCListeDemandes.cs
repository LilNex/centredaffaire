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
    public partial class UCListeDemandes : UserControl
    {
        public UCListeDemandes()
        {
            InitializeComponent();
        }

        private void UCListeDemandes_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Demission");
            comboBox1.Items.Add("Congé");
        }
        public void loadForm()
        {
            //Functions.setupDgv(this);
            dgvListeDemandes.DataSource = null;
            
            //dgvListeDemandes.Columns["Id"].Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Demission")
            {
                dgvListeDemandes.DataSource = null;
                dgvListeDemandes.DataSource = Demission.ListeDesDemission;
            }
            else
            {
                dgvListeDemandes.DataSource = null;
                dgvListeDemandes.DataSource = Congé.ListeDesCongé;
            }
        }
    }
}
