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
    public partial class Billard : Form
    {
        Jeux J1 = new Jeux();
        Jeux J2 = new Jeux();
        Jeux J3 = new Jeux();
        Jeux J4 = new Jeux();
        public Billard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void GSDJ_Load(object sender, EventArgs e)
        {
            J1.NomJ="Billard";
            J1.NumeroJ = 1;
            ClsListeSDJ.ListJeux.Add(J1);

            J2.NomJ = "Baby Foot";
            J1.NumeroJ = 2;
            ClsListeSDJ.ListJeux.Add(J2);

            J3.NomJ = "8 Bool";
            J3.NumeroJ = 3;
            ClsListeSDJ.ListJeux.Add(J3);

            J4.NomJ = ""; ;
            J4.NumeroJ = 4;
            ClsListeSDJ.ListJeux.Add(J4);

            LblNameJ1.Text = J1.NomJ;
            LblNumeroJ1.Text = J1.NumeroJ.ToString();
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBillHot_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnOccupation.ForeColor = Color.Red;       
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnOccupation.ForeColor = Color.Green;
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void GbJ1_Enter(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MENU1 menu = new MENU1();
            menu.Show();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            FrmSupport FS = new FrmSupport();
            FS.Show();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            FrmConnection FC = new FrmConnection();
            FC.Show();
        }
    }
}
