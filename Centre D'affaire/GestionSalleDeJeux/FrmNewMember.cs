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
    public partial class FrmNewMember : Form
    {
        
        public FrmNewMember()
        {
            InitializeComponent();
        }

        private void btnAjouterE_Click(object sender, EventArgs e)
        {
            clsEmployersSDJ NE = new clsEmployersSDJ();


            NE.NomE = txtnomAdd.Text;
            NE.PrenomE = txtPrenomAdd.Text;
            NE.NumeroE = int.Parse(txtNuméroEView.Text);
 NE.DateNaissanceE = dateTimeAdd.Value;
            NE.PasswordE1 = txtPasswordAdd.Text;

            ClsListeSDJ.ListE.Add(NE);

            DgvAddE.DataSource = null;
            DgvAddE.DataSource = ClsListeSDJ.ListE;

            txtnomAdd.Text = null;
            txtPrenomAdd.Text = null;
            txtPrenomAdd.Text = null;
            txtPasswordAdd.Text = null;
            MessageBox.Show("your modification is successfully", "Add");

        }

        private void FrmNewMember_Load(object sender, EventArgs e)
        {

        }

        private void txtnomAdd_TextChanged(object sender, EventArgs e)
        {
            if ((txtnomAdd.Text).Any(char.IsDigit) )
            {
                EreurPNomAdd.SetError(txtnomAdd, "Votre nom ne doit pas contien des chifre");
                btnAjouterE.Enabled = false;
            }
            else
            {
                EreurPNomAdd.SetError(txtnomAdd, "");
                btnAjouterE.Enabled = true;
            }
        }

        private void txtPrenomAdd_TextChanged(object sender, EventArgs e)
        {
            if ((txtPrenomAdd.Text).Any(char.IsDigit))
            {
                EreurPNomAdd.SetError(txtPrenomAdd, "Votre nom ne doit pas contien des chifre");
                btnAjouterE.Enabled = false;
            }
            else
            {
                EreurPNomAdd.SetError(txtPrenomAdd, "");
                btnAjouterE.Enabled = true;
            }
        }

        private void txtTelephoneAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNumberView_Click(object sender, EventArgs e)
        {



        }

        private void btnGetNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblPasswordADD_Click(object sender, EventArgs e)
        {

        }

        private void txtPasswordAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerationNuméro_Click(object sender, EventArgs e)
        {
            txtNuméroEView.Text = GenerateurNumero(3);
        }

        public static string GenerateurNumero(int length)
        {
            Random GN = new Random();
            var x = GN.Next(0, 1000000);
            string s = x.ToString("000000");
            return s;
        }

        private void txtNuméroCView_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
