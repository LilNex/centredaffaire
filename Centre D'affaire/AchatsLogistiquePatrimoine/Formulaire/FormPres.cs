using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public partial class FormPres : Form
    {
        public FormPres()
        {
            InitializeComponent();
        }
        List<ClsDemande> ld = new List<ClsDemande>();
        List<CHOIX> lc = new List<CHOIX>();
        List<ClsDepartement> ldep = new List<ClsDepartement>();
        
        private void FormPres_Load(object sender, EventArgs e)
        {
            ClsListe.List_demande.Clear();
            ClsListe.chargerDEMANDE();


            panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            
            pnlDemande.BackColor = Color.FromArgb(30, 0, 0, 0);
            pnlDTLdmd.BackColor = Color.FromArgb(30, 0, 0, 0);


            pnlDTLdmd.Visible = false;
            pnlDemande.Visible = false;

            picboxDTLchoix.BackgroundImageLayout = ImageLayout.Stretch;

            // les combobo remplir
            for (int i = 0; i < ClsListe.List_demande.Count; i++)
            {
                if(ClsListe.List_demande[i].Etat_demande1 == EtatDemande.attente)
                {
                    cmbID.Items.Add( ClsListe.List_demande[i].ID_demande1.ToString() );                    
                }               
            }

            //for (int i = 0; i < ClsListe.List_article.Count; i++)
            //{
            //    cmbARticle.Items.Add(ClsListe.List_article[i].TypeArticle);
            //}
           
                
          
            
            //combo departement
            for (int i = 0; i < ClsListe.List_departmnt.Count; i++)
            {
                cmbDeprt.Items.Add(ClsListe.List_departmnt[i] );
            }

            //combo urgence
            cmbUtgnce.Items.Add("urgent");
            cmbUtgnce.Items.Add("normal");








            cmbDeprt.Text = "    faites votre choix      ";
            // visibilite

            


        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDemande_Click(object sender, EventArgs e)
        {
            

            pnlDemande.Visible = true;
            dgvDmdNV.DataSource = ClsListe.List_demande;
            //foreach (DataGridViewColumn d in dataGridView1.Columns)
            //{
            //    d.Visible = false;

            //}






        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            for (int i = 0; i < ClsListe.List_demande.Count; i++)
            {
               
               if (ClsListe.List_demande[i].ID_demande1 == int.Parse(cmbID.SelectedItem.ToString()))
               {
                     lc.Clear();
                     lc.AddRange(ClsListe.List_demande[i].listchoix);


               }
 
            }
            dgvDmdNV.DataSource = null;
            dgvDmdNV.DataSource = lc;

            foreach (DataGridViewColumn d in dgvDmdNV.Columns)
            {
                d.Visible = false;

            }
            dgvDmdNV.Columns["nom"].Visible = true;
            dgvDmdNV.Columns["quantite"].Visible = true;
            


            cmbID.Text = "    faites votre choix      ";

        }

        private void dgvDmdNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDmdNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            


            
            
            if( dgvDmdNV.CurrentRow.DataBoundItem is CHOIX)
            {
                pnlDTLdmd.Visible = true;
                pnlDTLdmd.BringToFront();


                picboxDTLchoix.Image = ((CHOIX)dgvDmdNV.CurrentRow.DataBoundItem).Article.Photo;
                lblNonAfich.Text = ((CHOIX)dgvDmdNV.CurrentRow.DataBoundItem).Nom;
                for (int i = 0; i < ClsListe.List_demande.Count; i++)
                {
                    for (int j = 0; j < ClsListe.List_demande[i].listchoix.Count; j++)
                    {
                        if (ClsListe.List_demande[i].listchoix[j] == (CHOIX)dgvDmdNV.CurrentRow.DataBoundItem)
                        {
                            lbldepartm.Text = ClsListe.List_demande[i].Departement.Nom_service ;
                            lblQuantite.Text = ClsListe.List_demande[i].listchoix[j].Quantite.ToString();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Selectionnez le choix et non pas la demande ");
            }

            
           





        }

        private void pnlValidDmd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbARticle_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void cmbDeprt_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < ClsListe.List_demande.Count ; i++)
            {

                if (ClsListe.List_demande[i].Departement == (ClsDepartement) cmbDeprt.SelectedItem )
                {
                    lc.Clear();
                    //for(int j=0;ClsListe.List_demande[i].)
                    lc.AddRange(ClsListe.List_demande[i].listchoix);


                }

            }

            dgvDmdNV.DataSource = null;
            dgvDmdNV.DataSource = lc;
            cmbDeprt.Text = "    faites votre choix      ";
        }

        private void cmbUtgnce_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < ClsListe.List_demande.Count; i++)
            {

                if (ClsListe.List_demande[i].Urgence == cmbUtgnce.SelectedItem.ToString())
                {
                    lc.Clear();
                    //for(int j=0;ClsListe.List_demande[i].)
                    lc.AddRange(ClsListe.List_demande[i].listchoix); 

                }

            }

            dgvDmdNV.DataSource = null;
            dgvDmdNV.DataSource = lc;

            cmbUtgnce.Text = "    faites votre choix      ";
        }

        private void pnlDemande_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlDTLdmd.Hide();
        }
    }
}
