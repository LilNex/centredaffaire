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
    public partial class FrmInfoGame : Form
    {
        public FrmInfoGame()
        {
            InitializeComponent();
        }

        private void btnAddNewGame_Click(object sender, EventArgs e)
        {

            if (checkBoxBillardInfoGame.Checked)
            {
                int cpt = 0;
                for (int i = 0; i < ClsListeSDJ.ListBillard.Count(); i++)
                {
                    cpt += 1;
                }
                txtNumberNewGame.Text = cpt.ToString();
                clsBillard NGB = new clsBillard(txtNameNewGame.Text, int.Parse(txtNumberNewGame.Text));
                ClsListeSDJ.ListBillard.Add(NGB);
                MessageBox.Show("felkezk", "sdk");
            
            }
        }

        private void GetNewNumber_Click(object sender, EventArgs e)
        {
        }
    }
}
