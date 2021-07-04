using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionCreche
{
    public partial class frmFacture : Form
    {
        private int indice;

        public frmFacture()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }

        private void frmFacture_Load(object sender, EventArgs e)
        {

            
         }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            if (btnAjouter.Text == "Ajouter")
            {
                string[] t = new string[] { txtnum.Text, txtnom.Text, cbxMois.Text, dtpDateF.Text, txtAdresse.Text, dtpDateEcheance.Text,cbxMode.Text, lblM.Text };
                ListViewItem LS = new ListViewItem(t);
                lsvFacture.Items.Add(LS);

            }
            else
            {
                lsvFacture.Items[indice].SubItems[0].Text = txtnum.Text;
                lsvFacture.Items[indice].SubItems[1].Text = txtnom.Text;
                lsvFacture.Items[indice].SubItems[2].Text = cbxMois.Text;
                lsvFacture.Items[indice].SubItems[3].Text = dtpDateF.Text;
                lsvFacture.Items[indice].SubItems[4].Text = txtAdresse.Text;
                lsvFacture.Items[indice].SubItems[5].Text = dtpDateEcheance.Text;
                lsvFacture.Items[indice].SubItems[6].Text = cbxMode.Text;
                lsvFacture.Items[indice].SubItems[7].Text = lblM.Text;

                btnAjouter.Text = "Ajouter";



            }
        }
    }
    
   

           
        
}
 

