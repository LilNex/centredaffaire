using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionPersonnel
{
    public partial class FrmPaiement : Form
    {
        public FrmPaiement()
        {
            InitializeComponent();
        }
        public void grid()
        {
            dgvPaiement.Rows.Clear();
            for (int i = 0; i < list.bnq.Count; i++)
            {
                dgvPaiement.Rows.Add();
                dgvPaiement.Rows[i].Cells["nomsl"].Value = list.bnq[i].NomSl;
                dgvPaiement.Rows[i].Cells["num"].Value = list.bnq[i].numSl;
                dgvPaiement.Rows[i].Cells["rib"].Value = list.bnq[i].Rib;
                dgvPaiement.Rows[i].Cells["salairetotal"].Value = list.bnq[i].total;
                dgvPaiement.Rows[i].Cells["datepaie"].Value = list.bnq[i].DP;
                dgvPaiement.Rows[i].Cells["HeursTravail"].Value = txtHrt.Text ;


            }


        }

        

        private void txtHrt_TextChanged(object sender, EventArgs e)
        {
            int total = int.Parse(txtHrt.Text) * 10;
            txtSt.Text = total.ToString();
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            ClsCompteBancaire cmp = new ClsCompteBancaire(txtNom.Text, int.Parse(txtNum.Text), int.Parse(txtRIB.Text), int.Parse(txtSt.Text) , dateTimePickerDp.Value);
            cmp.Ajout(cmp);
            grid();
        }

        private void FrmPaiement_Load(object sender, EventArgs e)
        {
            txtSt.Enabled = false; 
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    
}
