using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public partial class UCgetionAchats : UserControl
    {
        public UCgetionAchats()
        {
            InitializeComponent();
        }

        private void TXTtele_TextChanged(object sender, EventArgs e)
        {

        }

        private void DPdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GB2_Enter(object sender, EventArgs e)
        {

        }

        private void btntrouver_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Listes.VendeursListe.Count; i++)
            {
                if (Listes.VendeursListe[i].Id == TXTnomcomplet.Text)
                {
                    TXTtele.Text = Listes.VendeursListe[i].Telephone.ToString() ;
                    bunifuTextBox3.Text = Listes.VendeursListe[i].NomComplet;
                }
                else
                {
                    MessageBox.Show("n'est pas existe :");
                }
            }
        }

        private void UCgetionAchats_Load(object sender, EventArgs e)
        {
            txtTotal.Enabled = false;
        }

        private void TXTnomcomplet_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Listes.VendeursListe.Count; i++)
            {
                string t = "";
                foreach  (char str in TXTnumero.Text)
                {
                    t = t + str;
                    if (Listes.VendeursListe[i].Id == t)
                    {
                        TXTtele.Text = Listes.VendeursListe[i].Telephone;
                        bunifuTextBox3.Text = Listes.VendeursListe[i].NomComplet;

                    }
                    else 
                    {
                        TXTtele.Text = "";
                        bunifuTextBox3.Text = "";
                    }
                }
            }
        }

        public void grid()
        {
            
                GriAchat.Rows.Clear();
                for (int i = 0; i < Listes.VendeursListe.Count; i++)
                {
                    GriAchat.Rows.Add();
                    GriAchat.Rows[i].Cells["NomProduit"].Value = Listes.achatliste[i].nom;
                    GriAchat.Rows[i].Cells["Prix"].Value = Listes.achatliste[i].Prix;
                    GriAchat.Rows[i].Cells["TOTAL"].Value = Listes.achatliste[i].Total;
                  
                }


            
        }
        public void Serialize()
        {
            XmlSerializer xml = new XmlSerializer(Listes.VendeursListe.GetType());
            using (StreamWriter stream = System.IO.File.CreateText("achat.xml"))
            {
                xml.Serialize(stream, Listes.achatliste);
            }
        }

        public void Deserialze()
        {
            XmlSerializer xml = new XmlSerializer(Listes.VendeursListe.GetType());
            using (StreamReader stream = System.IO.File.OpenText("vendeurs.xml"))
            {
                Listes.VendeursListe = (List<Vendeur>)xml.Deserialize(stream);
                grid();
                
            }
        }
        private void btnAcheter_Click(object sender, EventArgs e)
        {
            Vendeur f = new Vendeur(TXTnomcomplet.Text, bunifuTextBox3.Text, DPdate.Value, TXTtele.Text, "", "", "");
            Produit v = new Produit(TXTnumero.Text, int.Parse(TXTprix.Text), TXTProduitNom.Text, int.Parse(TXTquantite.Text), int.Parse(txtTotal.Text), f, DPdate.Value);
            if (v.Ajouter(v) == true)
            {
                MessageBox.Show(TXTProduitNom.Text + " ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grid();
                
            }
            else
            {
                MessageBox.Show("Ajout non effectué, vérifiez que le ID  n'est pas en double", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTnumero.Focus();


            }
        }
    }
}
