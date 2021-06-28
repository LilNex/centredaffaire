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
    public partial class FrmMENU1 : Form
    {
        public FrmMENU1()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            if (FlpMenu.Width == btnDashboard.Width)
            {
                FlpMenu.Width = 67;
                PnlBillard.Left = 120;
                PnlPS4.Left = 120;
                PnlBabyFoot.Left = 600;
                PnlAcracdeStreet.Left = 600;

            }
            else
            {
                FlpMenu.Width = btnDashboard.Width;
                PnlBillard.Location = new Point(259, 137);
                PnlPS4.Location = new Point(256, 342);
                PnlBabyFoot.Location = new Point(662, 137);
                PnlAcracdeStreet.Location = new Point(659, 342);

            }
        }

        private void FlpMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MENU1_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSupport FS = new FrmSupport();
            FS.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmConnection FC = new FrmConnection();
            FC.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBillard FBL = new FrmBillard();
            FBL.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBillard FBL = new FrmBillard();
            FBL.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmPS4 FPS4 = new FrmPS4();
            FPS4.Show();
        }

        private void btnImageBabayFoot_Click(object sender, EventArgs e)
        {
            FrmBabyFoot FBF = new FrmBabyFoot();
            FBF.Show();
        }

        private void btnBabayFoot_Click(object sender, EventArgs e)
        {
            FrmBabyFoot FBF = new FrmBabyFoot();
            FBF.Show();
        }

        private void btnImagePS4_Click(object sender, EventArgs e)
        {
            FrmPS4 FPS4 = new FrmPS4();
            FPS4.Show();
        }

        private void btnImageArcardeStreet_Click(object sender, EventArgs e)
        {
            FrmArcardeStreet FAS = new FrmArcardeStreet();
            FAS.Show();
        }

        private void btnArcardeStreet_Click(object sender, EventArgs e)
        {
            FrmArcardeStreet FAS = new FrmArcardeStreet();
            FAS.Show();
        }
    }
}
