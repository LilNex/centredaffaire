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
            clsBillard B1 = new clsBillard("Billard", 01);
            ClsListeSDJ.ListBillard.Add(B1);

            clsBillard B2 = new clsBillard("8 Bool", 02);
            ClsListeSDJ.ListBillard.Add(B2);

            clsBillard B3 = new clsBillard("Billard", 03);
            ClsListeSDJ.ListBillard.Add(B3);

            clsBillard B4 = new clsBillard("8 Bool", 04);
            ClsListeSDJ.ListBillard.Add(B4);

            clsBillard B5 = new clsBillard("Billard", 05);
            ClsListeSDJ.ListBillard.Add(B5);

            clsBillard B6 = new clsBillard("Billard", 06);
            ClsListeSDJ.ListBillard.Add(B6);
            



            clsBabyFoot BB1 = new clsBabyFoot("BabyFoot",1);
            ClsListeSDJ.ListBabyFoot.Add(BB1);

            clsBabyFoot BB2 = new clsBabyFoot("BabyFoot", 2);
            ClsListeSDJ.ListBabyFoot.Add(BB2);

            clsBabyFoot BB3 = new clsBabyFoot("BabyFoot", 3);
            ClsListeSDJ.ListBabyFoot.Add(BB3);



            clsPs4 Ps41 = new clsPs4("Ps4", 1);
            ClsListeSDJ.ListPs4.Add(Ps41);

            clsPs4 Ps42 = new clsPs4("Ps4", 2);
            ClsListeSDJ.ListPs4.Add(Ps42);

            clsPs4 Ps43 = new clsPs4("Ps4", 3);
            ClsListeSDJ.ListPs4.Add(Ps43);



            clsArcArdStreet AS1 = new clsArcArdStreet("ArcArdStreet", 01);
            ClsListeSDJ.listArcardS.Add(AS1);

            clsArcArdStreet AS2 = new clsArcArdStreet("King OF Fighter", 02);
            ClsListeSDJ.listArcardS.Add(AS2);

            clsArcArdStreet AS3 = new clsArcArdStreet("ArcArdStreet", 03);
            ClsListeSDJ.listArcardS.Add(AS3);

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

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click_2(object sender, EventArgs e)
        {
            FrmAbout FAB = new FrmAbout();
            FAB.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmAddGameAndEmployer frmagae = new frmAddGameAndEmployer();
            frmagae.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMENU1 FRMM12 = new FrmMENU1();
            FRMM12.Show();
        }
    }
}
