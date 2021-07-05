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
    public partial class UCDashboard : UserControl
    {
        public string DateNow { get => lblDateNow.Text; set 
            {
                lblDateNow.Text = value;
            } 
        }
        public UCDashboard()
        {
            InitializeComponent();
        }

        private void UCDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
