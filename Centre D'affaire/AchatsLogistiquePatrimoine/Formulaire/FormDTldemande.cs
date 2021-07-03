using System;
using System.Linq;
using System.Windows.Forms;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine.Formulaire
{
    public partial class FormDTldemande : Form
    {
        public FormDTldemande()
        {
            InitializeComponent();
        }

        public int IDdmd;

        private void FormDTldemande_Load(object sender, EventArgs e)
        {

            IDdmd = ClsListe.List_demande.IndexOf(ClsListe.List_demande.Max());

            cmbDepartement.Items.Add("Restaurant");
            cmbDepartement.Items.Add("Location ");
            btnSignature.Visible = false;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepartement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSignature_Click(object sender, EventArgs e)
        {

        }

        private void btnSigner_Click(object sender, EventArgs e)
        {
            btnSignature.Visible = true;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            
            Formulaire.FormDtl2 f = new FormDtl2();
            f.Hide();

            this.Hide();

            Catalogue c = new Catalogue();
            c.Show();



        }

        ClsDepartement depar;

        private void btnValider_Click(object sender, EventArgs e)
        {
            
            string urgence ="";
            if (rdbNomal.Checked)
            {
                urgence = "normal";
            }
            if (rdbUrgent.Checked)
            {
                urgence = "urgent";
            }
            if(cmbDepartement.SelectedItem.ToString() == "Restaurant")
            {
                for(int i= 0; i < ClsListe.List_departmnt.Count; i++)
                {
                    if (ClsListe.List_departmnt[i].Nom_service == "Restaurant")
                    {
                        depar = ClsListe.List_departmnt[i] ;
                    }
                }

            }
            ClsListe.List_demande.Add(new ClsDemande(IDdmd, txtLibele.Text, EtatDemande.attente, urgence, dtp.Value, ClsListe.List_choix,depar));

            ClsListe.List_choix.Clear();
            

        }
    }
}
