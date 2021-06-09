using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public partial class FormGestionnaire : Form
    {
        public FormGestionnaire()
        {
            InitializeComponent();

        }
        private Form activeForm;

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            activeForm.Close();
            
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PAnelDesktop.Controls.Add(childForm);
            this.PAnelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }




        private void BTNAchat_Click(object sender, EventArgs e)
        {


        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void BTNEntraineur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormGestionMembre(), sender);
        }

        private void BTNPrésence_Click(object sender, EventArgs e)
        {

        }

        private void btnPaiment_Click(object sender, EventArgs e)
        {

        }

        private void BTNPackage_Click(object sender, EventArgs e)
        {

        }

        private void BTNVente_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
