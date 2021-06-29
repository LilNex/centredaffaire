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
    public partial class Catalogue : Form
    {
        public Catalogue()
        {
            InitializeComponent();
        }
            
        ClsListe cls = new ClsListe();



        private void Catalogue_Load(object sender, EventArgs e)

        {
            string a = Application.StartupPath;
            dgvCHoi.DataSource = null;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            ClsListe.chargerART();
            
            dgvCHoi.DataSource = ClsListe.List_article;
            dgvCHoi.Columns["nom"].Width = 150;
            dgvCHoi.Columns["typearticle"].Width = 80;
            dgvCHoi.Columns["description"].Visible = false;
            dgvCHoi.Columns["photo"].Visible = false;
            



            panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            pnlHaut.BackColor = Color.FromArgb(70, 0, 0, 0);

            cmbProduit.Text = "--Faites votre choix--";

                        
            

            cmbProduit.Items.Add("Bureau");
            cmbProduit.Items.Add("Meuble");
            cmbProduit.Items.Add("Materiel sportif");
            cmbProduit.Items.Add("Salle de jeux");
            cmbProduit.Items.Add("Cafe/restaurant");
            cmbProduit.Items.Add("Crèche");
            cmbProduit.Items.Add("Uniforme");
            cmbProduit.Items.Add("Service");
            cmbProduit.Items.Add("Autre");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<ClsArticle> la = new List<ClsArticle>();

            ClsListe a = new ClsListe();
            if (cmbProduit.SelectedItem == "Bureau")
            {

                dgvCHoi.DataSource = null;
                dgvCHoi.DataSource = ClsListe.getlisteART(ArticleType.Bureau ); 
                
                dgvCHoi.Columns["nom"].Width = 170;
                dgvCHoi.Columns["nom"].ReadOnly = true;


            }

            if (cmbProduit.SelectedItem == "MEUBLE")
            {




                dgvCHoi.DataSource = null;
                //dgvCHoi.DataSource = a.articleMeuble();
                dgvCHoi.Columns["nom"].Width = 170;
                dgvCHoi.Columns["nom"].ReadOnly = true;

                


            }

            cmbProduit.Text = "--Faites votre choix--";
            foreach( DataGridViewColumn d in dgvCHoi.Columns)
            {
                d.Visible = false;

            }
            dgvCHoi.Columns["nom"].Visible = true;
            dgvCHoi.Columns["nom"].Width = 220;
        }



        

        
        

        private void dgvCHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = ((ClsArticle)dgvCHoi.CurrentRow.DataBoundItem).Photo;
        }
        List<CHOIX> lc = new List<CHOIX>(); 


        private void btnChoisir_Click(object sender, EventArgs e)
        {
            CHOIX c = new CHOIX(((ClsArticle)dgvCHoi.CurrentRow.DataBoundItem), ((ClsArticle)dgvCHoi.CurrentRow.DataBoundItem).Nom, 0);
            //ClsListe.List_choix.Add(c);
            lc.Add(c);

            //dgvFinal.Rows.Add(((ClsArticle)dgvCHoi.CurrentRow.DataBoundItem));
            dgvFinal.Rows.Add(lc);

            //.Cells["Numéro"].Value = clsliste.ListeStagiaire[i].NumS1;

          //  dgvFinal.DataSource = lc;

           
            foreach (DataGridViewColumn d in dgvFinal.Columns)
            {
                d.Visible = false;

            }
            dgvFinal.Columns["nom"].Visible = true;
            dgvFinal.Columns["quantite"].Visible = true;
            
            //lc =(List<CHOIX>) dgvFinal.DataSource;
        }
    }
}