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
        int cpt = 1001;
        public FrmNewMember()
        {
            InitializeComponent();
        }

        private void btnAjouterE_Click(object sender, EventArgs e)
        {
            clsEmployersSDJ NE = new clsEmployersSDJ();
            txtnomAdd.Text = null;
            txtPrenomAdd.Text = null;
            txtTelephoneAdd.Text = null;

            NE.NomE = txtnomAdd.Text;
            NE.PrenomE = txtPrenomAdd.Text;
            NE.NumeroE = int.Parse(btnNumberView.Text);
            NE.TelephoneE = int.Parse(txtTelephoneAdd.Text);
            NE.DateNaissanceE = dateTimeAdd.Value;

            ClsListeSDJ.ListE.Add(NE);

            DgvAddE.DataSource = ClsListeSDJ.ListE;
            cpt += 0001;

        }

        private void FrmNewMember_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ClsListeSDJ.ListE.Count; i++)
            {
                cpt += 1;

            }
            btnNumberView.Text = cpt.ToString();
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
            if ((txtTelephoneAdd.Text).Any(char.IsLetter))
            {
                EreurPNomAdd.SetError(txtTelephoneAdd, "Votre nom ne doit pas contien des chifre");
                btnAjouterE.Enabled = false;
            }
            else
            {
                EreurPNomAdd.SetError(txtTelephoneAdd, "");
                btnAjouterE.Enabled = true;
            }
        }

        private void btnNumberView_Click(object sender, EventArgs e)
        {



        }

        private void btnGetNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
