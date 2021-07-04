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
    public partial class Comerce : Form
    {
        public Comerce()
        {
            InitializeComponent();
        }

        private void Comerce_Load(object sender, EventArgs e)
        {
            pnlcommande.Visible = false;
            ///-----REMPLICAGE DES COMBOS
            for(int i=0;i< ClsListe.List_commande.Count;i++)
            {
                if(ClsListe.List_commande[i].Etatcommande==etatcommande.encours)
                {
                    cmbcommande.Items.Add(ClsListe.List_commande[i].ID_cmd);
                }
            }
           
            for(int i=0;i<ClsListe.List_article.Count;i++)
            {
                cmbarticle.Items.Add(ClsListe.List_article[i].TypeArticle);

            }
                
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlcommande.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        public void users()
        {
            Comerce n = new Comerce();

            foreach(Control c in  this.Controls) 
            { 
                if( c is UserControl)
                {
                    c.Hide();
                }
            }
        }

        private void lbltitre_Click(object sender, EventArgs e)
        {

        }

        private void pnldemande_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
