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
    public partial class FrmAddGame : Form
    {
        public FrmAddGame()
        {
            InitializeComponent();
        }

        private void btnArcardeStreet_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddGame_Load(object sender, EventArgs e)
        {
            DgvBillard.DataSource = ClsListeSDJ.ListBillard;
            DgvBabyFoot.DataSource = ClsListeSDJ.ListBabyFoot;
            DgvPs4.DataSource = ClsListeSDJ.ListPs4;
            DgvArcardStreet.DataSource = ClsListeSDJ.listArcardS;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmInfoGame FRMNG = new FrmInfoGame();
            FRMNG.Show();
        }

        private void DgvBillard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvBabyFoot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvBillardPs4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNewGameRefresh_Click(object sender, EventArgs e)
        {
            DgvBillard.DataSource = null;
            DgvBillard.DataSource = ClsListeSDJ.ListBillard;

            DgvArcardStreet.DataSource = null;
            DgvArcardStreet.DataSource = ClsListeSDJ.listArcardS;

            DgvBabyFoot.DataSource = null;
            DgvBabyFoot.DataSource = ClsListeSDJ.ListBabyFoot;

            DgvPs4.DataSource = null;
            DgvPs4.DataSource = ClsListeSDJ.ListPs4;
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {

        }
    }
}
