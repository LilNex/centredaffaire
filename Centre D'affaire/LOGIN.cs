using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Centre_D_affaire
{ 
     
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxlogin.Checked==true)
            {
                txtmdp.UseSystemPasswordChar = true;
            }
            else
            {
                txtmdp.UseSystemPasswordChar = false;
            }
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            txtmdp.PasswordChar = '*';
            txtmdp.CharacterCasing = CharacterCasing.Lower;
        }
        public void aaa()
        {
            
        }
        private void cmbprofil_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //for (int i = 0; i<; i++)
            //{

            //if (ClsListe.List_demande[i].ID_demande1 == int.Parse(cmbidcommande.SelectedItem.ToString()))
            //{
            //    lc.Clear();
            //    lc = ClsListe.List_demande[i].listchoix;


            //}

            //}
            //dgvDmdV.DataSource = null;
            //dgvDmdV.DataSource = lc;
        }
    }
}
