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
            TXTtotal.Enabled = false;
            TxtFrais.Enabled = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Package pack = new Package(cbPackage.Text);

            Membre mbr = new Membre(TXTnumero.Text ,TXTnomcomplet.Text ,DPdate.Value ,TXTtele.Text,TxtEmail.Text , TXTadresse.Text , Cbgenre.Text , pack , int.Parse(TXTXpoids.Text) , int.Parse(TxtFrais.Text) , int.Parse( TXTDUREE.Text ), int.Parse( TXTtotal.Text) ,cbStatus.Text , pictureBox1.Image );
            if (mbr.Ajouter(mbr) == true)
            {
                MessageBox.Show(TXTnomcomplet.Text + " ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                //ClassInterface i = new ClassInterface();
                //i.viderform(this);
            }
            else
            {
                MessageBox.Show("Ajout non effectué, vérifiez que le ID  n'est pas en double", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTnumero.Focus();


            }
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

        private void cbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtFrais_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Cbgenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXTDUREE_TextChanged(object sender, EventArgs e)
        {
            int s = int.Parse(TxtFrais.Text) * int.Parse(TXTDUREE.Text);
            TXTtotal.Text = s.ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                bunifuPictureBox1.Image = new Bitmap(open.FileName);
            }
        }
    }
}
