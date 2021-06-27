using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            remplirgrid();
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
