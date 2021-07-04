using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

      


        private void UserControl1_Load(object sender, EventArgs e)
        {
            int d = Listes.MembresListe.Count;
            labelm.Text = d.ToString();
            int b = Listes.EntraineursListe.Count ;
            labele.Text = b.ToString();
            int t = 0; 
            for (int i = 0; i < Listes.paiment.Count; i++)
            {
                t = int.Parse(Listes.paiment[i].Paiement1 ) + t ;
                

            }
            labelb.Text = t.ToString();
         
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
