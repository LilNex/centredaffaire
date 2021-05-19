using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    
    public partial class UCEmployes : UserControl
    {
        
        public UCEmployes()
        {
            InitializeComponent();
        }
        private void UCEmployes_Load(object sender, EventArgs e)
        {
            ucListeEmployes.BringToFront();
        }

        private void btnListeEmployes_Click(object sender, EventArgs e)
        {
            ucListeEmployes.BringToFront();
        }

        private void btnAjouterEmploye_Click(object sender, EventArgs e)
        {
            ucAjoutEmploye.BringToFront();
        }

        
    }
}
