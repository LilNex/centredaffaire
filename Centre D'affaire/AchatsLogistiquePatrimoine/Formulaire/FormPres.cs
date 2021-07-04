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

        private void FormPres_Load(object sender, EventArgs e)
        {
            ClsListe.List_demande.Clear();
            ClsListe.chargerDEMANDE();

            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(50, 0, 0, 0);
            pnlDemande.BackColor = Color.FromArgb(50, 0, 0, 0);

            pnlDemande.Visible = false;

            // les combobo remplir
            for(int i = 0; i < ClsListe.List_demande.Count; i++)
            {
                if(ClsListe.List_demande[i].Etat_demande1 == EtatDemande.attente)
                {
                    cmbID.Items.Add( ClsListe.List_demande[i].ID_demande1.ToString() );                    
                }               
            }

            for (int i = 0; i < ClsListe.List_article.Count; i++)
            {
                cmbARticle.Items.Add(ClsListe.List_article[i].TypeArticle);
            }


            for (int i = 0; i < ClsListe.List_departmnt.Count; i++)
            {
                cmbDeprt.Items.Add(ClsListe.List_departmnt[i].Nom_service );
            }














        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDemande_Click(object sender, EventArgs e)
        {
            ClsListe.List_demande.Clear();
            ClsListe.chargerDEMANDE();

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
    }
}
