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
        List<ClsDemande> ld = new List<ClsDemande>();
        List<ClsCommande> l = new List<ClsCommande>();
        List<CHOIX> lc = new List<CHOIX>();
        private void Comerce_Load(object sender, EventArgs e)
        {
            pnlfournisseur.Visible = false;
            pnlcommande.Visible = false;
            ///-----REMPLICAGE DES COMBOS
            for(int i=0;i< ClsListe.List_demande.Count;i++)
            {
                if(ClsListe.List_demande[i].Etat_demande1==EtatDemande.validé)
                {
                    cmbidcommande.Items.Add(ClsListe.List_demande[i].ID_demande1);
                }
            }
           
            for(int i=0;i<ClsListe.List_article.Count;i++)
            {
                //cmbarticle.Items.Add(ClsListe.List_article[i].TypeArticle);

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

            for (int i = 0; i < ClsListe.List_demande.Count; i++)
            {

                if (ClsListe.List_demande[i].ID_demande1 == int.Parse(cmbidcommande.SelectedItem.ToString()))
                {
                    lc.Clear();
                    lc = ClsListe.List_demande[i].listchoix;


                }

            }
            dgvDmdV.DataSource = null;
            dgvDmdV.DataSource = lc;

        }
        
                    
        private void cmbarticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ArticleType Type;
            //Enum.TryParse<ArticleType>(cmbarticle.SelectedIndex.ToString(), out Type);
            //var id = from x in ClsListe.List_choix
            //         where x.Article== (ch)cmbarticle.SelectedIndex
            //         from y in x.listchoix
            //         where y.Article.TypeArticle == Type
            //         select y;
        }

        private void cmbdepartement_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ClsListe.List_demande.Count; i++)
            {

                if (ClsListe.List_demande[i].Departement == (ClsDepartement)cmbdepartement.SelectedItem)
                {
                    lc.Clear();
                    //for(int j=0;ClsListe.List_demande[i].)
                    lc.AddRange(ClsListe.List_demande[i].listchoix);


                }

            }

            dgvDmdV.DataSource = null;
            dgvDmdV.DataSource = lc;
        }

       

        private void cmbUrgnce_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ClsListe.List_demande.Count; i++)
            {

                if (ClsListe.List_demande[i].Urgence == cmbUrgnce.SelectedItem.ToString())
                {
                    lc.Clear();
                    //for(int j=0;ClsListe.List_demande[i].)
                    lc.AddRange(ClsListe.List_demande[i].listchoix);

                }

            }

            dgvDmdV.DataSource = null;
            dgvDmdV.DataSource = lc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlfournisseur.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Catalogue f = new Catalogue();
            f.Show();

            this.Hide();
        }
    }
}
