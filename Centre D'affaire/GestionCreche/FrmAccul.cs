using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Centre_D_affaire.GestionCreche
{
    public partial class FrmAccul : Form
    {
        private string Directeur;

        public FrmAccul()
        {
            InitializeComponent();
        }

        private void pnlAcceuil_Paint(object sender, PaintEventArgs e)
        {
            pnlAcceuil.BackColor = Color.FromArgb(50, 0, 0, 0);

        }



        private void btnCatalogue_Click(object sender, EventArgs e)
        {
            catalogue111 me = new catalogue111();
            //me.MdiParent = this;
            me.Dock = DockStyle.Fill;
            me.BringToFront();
            me.Show();


        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            frmInscription me = new frmInscription();

            // me.MdiParent = this;
            me.Dock = DockStyle.Fill;
            me.BringToFront();
            me.Show();
            

        }
        private void affichage(object sender, EventArgs e)
        {
            // foreach forms As Form in  
        }

        private void FrmAccul_Load(object sender, EventArgs e)
        {
            FrmAccul accul = new FrmAccul();
            cmbPF.Items.Add("Responsable");
            cmbPF.Items.Add("Personnel");
            cmbPF.Text = "    ";
            pnlPersonnel.Visible = false;

        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            pnlPersonnel.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbPF.Text == "Responsable" && txtName.Text == "Hafsa" && txtMDP.Text == "mnopqr00")

            {
                FrmPersonnel f = new FrmPersonnel();
                f.Show();
                this.Hide();
            }

            if(cmbPF.Text == "Personnel" && txtName.Text == "ihssane" && txtMDP.Text == "1234")
            {

            }


        }



    private void cmbPF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
