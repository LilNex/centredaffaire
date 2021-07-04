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
            ClsListe.List_demande.Clear();
            ClsListe.chargerDEMANDE();


            btnsignature.Visible = false; 
            //string donne="";
            string a = "                                 ";
            string c = "                              ";
            string b = "                       ";

            flowLayoutPanel1.AutoScroll = true;

            for(int i =0; i<ClsListe.List_choix.Count; i++)
            {
                Label l = new Label();
                if (ClsListe.List_choix[i].Nom.Length <= 7)
                {
                    l.Text = " - "+ ClsListe.List_choix[i].Nom + a + ClsListe.List_choix[i].Quantite;
                }
                if (ClsListe.List_choix[i].Nom.Length >7 && ClsListe.List_choix[i].Nom.Length <= 9)
                {
                    l.Text = " - "+ClsListe.List_choix[i].Nom + c + ClsListe.List_choix[i].Quantite;
                }
                if(ClsListe.List_choix[i].Nom.Length > 9)
                {
                    l.Text = " - " + ClsListe.List_choix[i].Nom + b + ClsListe.List_choix[i].Quantite;
                }
               
                l.Width = lbltete.Width;
                flowLayoutPanel1.Controls.Add(l);


            }
            


            

            for(int i=0;i<ClsListe.List_departmnt.Count; i++)
            {
                cmbDepartement.Items.Add(ClsListe.List_departmnt[i].Nom_service);
            }
            



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
            btnsignature.Visible = true;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            
           
           

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

            if(ClsListe.List_demande.Count== 0)
            {
                IDdmd = 1 ;
            }
            else
            {
                IDdmd = ClsListe.List_demande.Count;
                    
            }

            ClsListe.List_demande.Add(new ClsDemande(IDdmd, txtLibele.Text, EtatDemande.attente, urgence, dtp.Value, ClsListe.List_choix,depar));

            ClsListe.List_choix.Clear();

            ClsListe.sauvegardeDEMANDE();

            //Catalogue f = new Catalogue();
            //f.Show();

            FormPres d = new FormPres();
            d.Show();
            

            this.Close();


        }
    }
}
