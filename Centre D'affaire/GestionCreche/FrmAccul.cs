using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            //me.Dock = DockStyle.Fill;
            // me.BringToFront();
            me.Show();
            this.Hide();


        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            frmInscription me = new frmInscription();

            // me.MdiParent = this;
            //  me.Dock = DockStyle.Fill;
            //me.BringToFront();
            me.Show();
            this.Hide();

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


            clsListe.ListeResponsable.Add(new clsResponsable("Naghar", "Hafsa", "06777777", "AAA", "BBBB", "Responsable", "1111"));
            clsListe.ListeResponsable.Add(new clsResponsable("Sfifa", "Ihssane", "06777778", "AAA", "BBBB", "Personnel", "1111"));
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            pnlPersonnel.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool D = false;
            string a = txtName.Text;
            string b = txtMDP.Text;
            string c = cmbPF.SelectedItem.ToString();
            for (int i = 0; i < clsListe.ListeResponsable.Count; i++)
            {
                if (clsListe.ListeResponsable[i].Nom == a && clsListe.ListeResponsable[i].Mdp1 == b && clsListe.ListeResponsable[i].type1 == c)
                {
                    D = true;
                }
            }

        
            if (D == false)
            {
                MessageBox.Show("information incorrect");
                txtName.Text = "";
                txtMDP.Text = "";

            }

            if (D == true && c == "Responsable")
            {
                FrmPersonnel f = new FrmPersonnel();
                f.Show();
                this.Hide();
            }
            if (D == true && c == "Personnel")
            {


                FrmPersonnel f = new FrmPersonnel();
                f.Show();
                this.Hide();


            }
        }


    


            private void cmbPF_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void txtName_TextChanged(object sender, EventArgs e)
            {

            }
    }
}
