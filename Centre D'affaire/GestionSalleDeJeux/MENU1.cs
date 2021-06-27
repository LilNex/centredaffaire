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
    public partial class MENU1 : Form
    {
        public MENU1()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //if (FlpMenu.Width == btnDashboard.Width)
            //{
            //    FlpMenu.Width = 67;
            //}
            //else
            //{
            //    FlpMenu.Width = btnDashboard.Width;
            //}
        }

        private void FlpMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MENU1_Load(object sender, EventArgs e)
        {
            //FlpMenu.Width = 67;
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
    }
}
