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
    public partial class UCgestionMemebre : UserControl
    {
        public UCgestionMemebre()
        {
            InitializeComponent();
        }

        private void UCgestionMemebre_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Package pack = new Package(cbPackage.Text);

            Membre mbr = new Membre(TXTnumero.Text ,TXTnomcomplet.Text ,DPdate.Value , int.Parse(TXTtele.Text),TxtEmail.Text , TXTadresse.Text , Cbgenre.Text , pack, int.Parse(TXTXpoids.Text) , int.Parse(TxtFrais.Text) , int.Parse( TXTDUREE.Text ), int.Parse( TXTtotal.Text) ,cbStatus.Text   );
            mbr.Ajouter(mbr);
        }

        private void BTnshow_Click(object sender, EventArgs e)
        {
            FormGridMemebre f = new FormGridMemebre();
            f.Show(); 
        }

        private void cbPackage_Click(object sender, EventArgs e)
        {

            
            cbPackage.DataSource = Listes.PackagesListe;
            cbPackage.ValueMember = "Nom";
            cbPackage.DisplayMember = "Nom";
        }
    }
}
