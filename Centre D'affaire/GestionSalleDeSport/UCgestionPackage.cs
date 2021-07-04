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
    public partial class UCgestionPackage : UserControl
    {
        public UCgestionPackage()
        {
            InitializeComponent();
        }

        private void UCgestionPackage_Load(object sender, EventArgs e)
        {
            Deserialze();
         }
     

        public void Serialize()
        {
            XmlSerializer xml = new XmlSerializer(Listes.PackagesListe.GetType());
            using (StreamWriter stream = System.IO.File.CreateText("package.xml"))
            {
                xml.Serialize(stream, Listes.PackagesListe);
                stream.Close();
            }
        }

        public void Deserialze()
        {
            XmlSerializer xml = new XmlSerializer(Listes.PackagesListe.GetType());







            if (File.Exists("package.xml"))
            {
                try
                {
                    StreamReader stream = System.IO.File.OpenText("package.xml");

                    try
                    {

                        Listes.PackagesListe = (List<Package>)xml.Deserialize(stream);
                        remplirgrid();
                    }
                    catch (Exception)
                    {
                        throw new Exception("Problème de lecture !!!");
                    }
                    stream.Close();
                }
                catch (Exception)
                {
                    throw new Exception("Problème d'ouverture !!!");
                }
            }








        }

        private void TXTnomcomplet_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (char c in TXTprix.Text)
            {
                if (Char.IsDigit(c) == false)
                {
                    
                    MessageBox.Show("Tu doix ecrire une chaine du mombre "+ MessageBoxButtons.OK);
                }
                else
                {
                    Package pack = new Package(TXTnumero.Text, TXTnomcomplet.Text, TXTprix.Text, TXTdetails.Text);
                    pack.Ajouter(pack);
                    remplirgrid();
                    Serialize();
                }
            }
           
        }
        public void remplirgrid()
        {
            GridPackage.Rows.Clear();
            for (int i = 0; i < Listes.PackagesListe.Count; i++)
            {
                GridPackage.Rows.Add();
                GridPackage.Rows[i].Cells["ID"].Value = Listes.PackagesListe[i].Id;
                GridPackage.Rows[i].Cells["Details"].Value = Listes.PackagesListe[i].Detail;
                GridPackage.Rows[i].Cells["Prxi"].Value = Listes.PackagesListe[i].Prix;
                GridPackage.Rows[i].Cells["PackageNom"].Value = Listes.PackagesListe[i].Nom;

            }

        }
        
    }
} 
