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

        private void OpenChildForm(UserControl  childForm, object btnSender)
        {
            if (activeForm != null)
            activeForm.Close();
            
            
            
            
            childForm.Dock = DockStyle.Fill;
            this.PAnelDesktop.Controls.Add(childForm);
            this.PAnelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }




     

        private void BTNEntraineur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UCgestionVente(), sender);
            bunifuPanel2.BackgroundColor = Color.FromArgb(155, 155, 155);
        }

        
    }
}
