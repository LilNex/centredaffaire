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

        List<CHOIX> lc = new List<CHOIX>();
        ClsDemande D = new ClsDemande();
        



        private void Catalogue_Load(object sender, EventArgs e)

        {
            panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            pnlHaut.BackColor = Color.FromArgb(70, 0, 0, 0);
            //charger fichier  choix dans liste choi 
            ClsListe.List_choix.Clear();
            ClsListe.chargerDEMANDE(); // pour ajouter une demande sur la liste precedente

            //charger les article
            ClsListe.List_article.Clear();
            ClsListe.chargerART();


            //string a = Application.StartupPath;
            dgvCHoi.DataSource = null;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
           
            
            dgvCHoi.DataSource = ClsListe.List_article;
            dgvCHoi.Columns["nom"].Width = 150;
            dgvCHoi.Columns["typearticle"].Width = 80;
            dgvCHoi.Columns["description"].Visible = false;
            dgvCHoi.Columns["photo"].Visible = false;
            

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

            //combo departement
            cmbDepartemen.Items.Add("Personnel");
            cmbDepartemen.Items.Add("Restaurant");
            cmbDepartemen.Items.Add("Salle de sport");
            cmbDepartemen.Items.Add("Salle de jeux");
            cmbDepartemen.Items.Add("Crèche");
            cmbDepartemen.Items.Add("Location ");
            cmbDepartemen.Items.Add("Parking");

            //liste departement
            ClsListe.List_departmnt.Add(new ClsDepartement("1", "Personnel"));

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
         


        private void btnChoisir_Click(object sender, EventArgs e)
        {
            
            bool exist = false;

            string n = ((ClsArticle)dgvCHoi.CurrentRow.DataBoundItem).Nom ;

            CHOIX c = new CHOIX(((ClsArticle)dgvCHoi.CurrentRow.DataBoundItem), n, 0);
            //ClsListe.List_choix.Add(c);
            for( int i = 0; i  < lc.Count; i++)
            {
                if(lc[i].Nom == n )
                {
                    exist = true;
                }

            }
            if(exist == false)
            {
                lc.Add(c);
            }
            

           
            dgvFinal.DataSource = null;
            dgvFinal.DataSource = lc;

           
            foreach (DataGridViewColumn d in dgvFinal.Columns)
            {
                d.Visible = false;

            }

            dgvFinal.Columns["nom"].Visible = true;
            dgvFinal.Columns["quantite"].Visible = true;

            dgvFinal.Columns["nom"].ReadOnly = true;
            dgvFinal.Columns["quantite"].ReadOnly = false;


            //lc =(List<CHOIX>) dgvFinal.DataSource;
        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {
            if( s==false)
            {
                MessageBox.Show("selectionnez un article");
            }
            else
            {
                string n = ((CHOIX)dgvFinal.CurrentRow.DataBoundItem).Nom;
                for (int i = 0; i < lc.Count; i++)
                {
                    if (lc[i].Nom == n)
                    {
                        lc.Remove(lc[i]);
                    }
                }

                dgvFinal.DataSource = null;
                dgvFinal.DataSource = lc;

                foreach (DataGridViewColumn d in dgvFinal.Columns)
                {
                    d.Visible = false;

                }

                dgvFinal.Columns["nom"].Visible = true;
                dgvFinal.Columns["quantite"].Visible = true;

                dgvFinal.Columns["nom"].ReadOnly = true;
                dgvFinal.Columns["quantite"].ReadOnly = false;

            }
            s = false;


        }
        bool s= false;

        private void dgvFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            s = true;
        }

        private void dgvFinal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = ((CHOIX)dgvFinal.CurrentRow.DataBoundItem).Article.Photo ;
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            lc.Clear();
            dgvFinal .DataSource = null;

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //creer objet demande 
            //ajouter a liste demande
            ///serialisation fichier demande
            ///
            //string id = ClsListe.List_choix.Count.ToString();

           // ClsListe.List_demande.Add(new ClsDemande(id, "", EtatDemande.attente, "", DateTime.Now, lc ,ClsListe.List_departmnt[0]));

            //sauvgarde demande

            

            
            //fonction serialiser vers ficher choiux depuis list choix generel


            
        }
    }
}