using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    public partial class FrmBabyFoot : Form
    {
        public FrmBabyFoot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConnection FC = new FrmConnection();
            FC.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMENU1 menu = new FrmMENU1();
            menu.Show();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            FrmSupport FS = new FrmSupport();
            FS.Show();
        }
    }
}
