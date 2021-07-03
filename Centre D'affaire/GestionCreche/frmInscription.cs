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
    public partial class frmInscription : Form
    {
        public frmInscription()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "HafsaFile(*.Hafsa)*|bureau files|*.bureau|all files(*.*)|*.*|";
                if (dialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {

                    picimage.ImageLocation = dialog.FileName;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error Accord", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtNom.Text, txtProfession.Text, txtTelephone.Text, txtDepartement.Text, txtNomEN.Text, txtAge.Text) ;
            


        }

        private void frmInscription_Load(object sender, EventArgs e)
        {
            frmInscription IN = new frmInscription();
            
            FrmAccul accul = new FrmAccul();
            accul.Hide();
            IN.BringToFront();
            this.Hide();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor= Color.FromArgb(50, 0, 0, 0);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
