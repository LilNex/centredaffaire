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
                

                clsBillard NGB = new clsBillard(txtNameNewGame.Text, int.Parse(NUDNumberAddGame.Value.ToString()));
                ClsListeSDJ.ListBillard.Add(NGB);
                MessageBox.Show("your modification is successfully", "ADD");
            
            }
            if (checkBoxArcardStreetInfoGame.Checked)
            {


                clsArcArdStreet NAS = new clsArcArdStreet(txtNameNewGame.Text, int.Parse(NUDNumberAddGame.Value.ToString()));
                ClsListeSDJ.listArcardS.Add(NAS);
                MessageBox.Show("your modification is successfully", "ADD");

            }
            if (checkBoxBabyFootInfoGame.Checked)
            {


                clsBabyFoot NBF = new clsBabyFoot(txtNameNewGame.Text, int.Parse(NUDNumberAddGame.Value.ToString()));
                ClsListeSDJ.ListBabyFoot.Add(NBF);
                MessageBox.Show("your modification is successfully", "ADD");

            }
            if (checkBoxPs4InfoGame.Checked)
            {


                clsPs4 NPS41 = new clsPs4(txtNameNewGame.Text, int.Parse(NUDNumberAddGame.Value.ToString()));
                ClsListeSDJ.ListPs4.Add(NPS41);
                MessageBox.Show("your modification is successfully", "ADD");

            }

        }

        private void GetNewNumber_Click(object sender, EventArgs e)
        {
        }

        private void txtNumberNewGame_TextChanged(object sender, EventArgs e)
        {

        }

        private void NUDNumberAddGame_ValueChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < ClsListeSDJ.ListBillard.Count(); i++)
            //{
            //    if (NUDNumberAddGame.Value == ClsListeSDJ.ListBillard[i].NumberOFBillard)
            //    {
            //        EPAddGame.SetError(NUDNumberAddGame, "This number is already Exist,Try another ");
            //        btnAddNewGame.Enabled = false;
            //    }
            //}
            //EPAddGame.SetError(NUDNumberAddGame, "");
            //btnAddNewGame.Enabled = true;
        }
    }
}
