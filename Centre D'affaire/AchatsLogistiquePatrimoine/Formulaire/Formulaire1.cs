using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public partial class Formulaire1 : Form
    {
        public Formulaire1()
        {
            InitializeComponent();
        }
        
        ClsEmploye e = new ClsEmploye();

        
        private void Formulaire1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //string a;
            //do
            //{
            //    if (e.recherche(txt_Id.Text) != -1)
            //    {
            //        a = e.recherche(txt_Id.Text);
            //        if (txt_Mdp.Text == ClsListe.List_employe[a].MDP_emp1 && cmb_profil != "DIRECTEUR") ;
            //        {
            //            // conexion + nv formulaire + notification +.....
            //            //
            //        }
            //            else // verification mo de pass


            //    }
            //    else // compte inexistant


            //} while (); // recherch(id) == -1 )

        }
        private void txt_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
