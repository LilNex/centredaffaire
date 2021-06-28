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
    public partial class FrmConnection : Form
    {
        public FrmConnection()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Veuillez contacter la responsable pour retourner votre mot de passe , pour plus d'info 0606060606", "Realisation de mot de passe");
            
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            FrmNewMember FNM = new FrmNewMember();
            FNM.Show();
        }
    }
}
