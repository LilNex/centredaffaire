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
    public partial class UCgestionEntraineur : UserControl
    {
        public UCgestionEntraineur()
        {
            InitializeComponent();
        }
        public void grid()
        {
            GridENTRAINEUR.Rows.Clear();
            for (int i = 0; i < Listes.EntraineursListe.Count; i++)
            {
                GridENTRAINEUR.Rows.Add();
                GridENTRAINEUR.Rows[i].Cells["ID"].Value = Listes.EntraineursListe[i].Id;
                GridENTRAINEUR.Rows[i].Cells["Nom"].Value = Listes.EntraineursListe[i].NomComplet;
                GridENTRAINEUR.Rows[i].Cells["Adresse"].Value = Listes.EntraineursListe[i].Adresse;
                GridENTRAINEUR.Rows[i].Cells["Email"].Value = Listes.EntraineursListe[i].Email;
                GridENTRAINEUR.Rows[i].Cells["Telephone"].Value = Listes.EntraineursListe[i].Telephone;
                GridENTRAINEUR.Rows[i].Cells["Salair"].Value = Listes.EntraineursListe[i].Salaire;
                GridENTRAINEUR.Rows[i].Cells["Telephone"].Value = Listes.EntraineursListe[i].Telephone;
                GridENTRAINEUR.Rows[i].Cells["DAteJoin"].Value = Listes.EntraineursListe[i].DateJoin;
                GridENTRAINEUR.Rows[i].Cells["Sex"].Value = Listes.EntraineursListe[i].Sex;


            }


        }

        private void UCgestionEntraineur_Load(object sender, EventArgs e)
        {
            btnSupprimer.Visible = false;
            btnMise.Visible = false;
            TXtSalaire.Visible = true; 
            grid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string d = "01/01/1999";
            DateTime df = Convert.ToDateTime(d);


            Entraineur v = new Entraineur(TXTnumero.Text, TXTnomcomplet.Text, DPdate.Value, TXTtele.Text, TxtEmail.Text, TXTadresse.Text, TXTgenre.Text, int.Parse(TXtSalaire.Text), bunifuPictureBox1.Image);
            if (v.Ajouter(v) == true)
            {
                MessageBox.Show(TXTnomcomplet.Text + " ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grid();
                ClassInterface i = new ClassInterface();
                i.viderform(this);
            }
            else
            {
                MessageBox.Show("Ajout non effectué, vérifiez que le ID  n'est pas en double", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTnumero.Focus();


            }
        }

        private void GridENTRAINEUR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow data = GridENTRAINEUR.Rows[i];
            TXTnumero.Text = data.Cells[0].Value.ToString();
            TXTnomcomplet.Text = data.Cells[2].Value.ToString();
            TxtEmail.Text = data.Cells[5].Value.ToString();
            TXTadresse.Text = data.Cells[4].Value.ToString();
            TXTtele.Text = data.Cells[3].Value.ToString();
            TXTgenre.Text = data.Cells[1].Value.ToString();
            DPdate.Value = Convert.ToDateTime(data.Cells[6].Value);
            TXtSalaire.Text = data.Cells[7].Value.ToString();

            btnSave.Visible = false;
            btnMise.Visible = true;
            btnSupprimer.Visible = true;
            for ( int f = 0; f < Listes.EntraineursListe.Count; f++)
            {
                if(Listes.EntraineursListe[f].Id == TXTnumero.Text)
                {
                    bunifuPictureBox1.Image = Listes.EntraineursListe[f].IM; 
                }
                
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("Voulez vous vraiment modifier " + TXTnomcomplet.Text, "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (D == DialogResult.Yes)
            {
                var found = Listes.EntraineursListe.FirstOrDefault(c => c.Id == TXTnumero.Text);
                found.Id = TXTnumero.Text;

                found.NomComplet = TXTnomcomplet.Text;
                found.Email = TxtEmail.Text;
                found.Adresse = TXTadresse.Text;
                found.Telephone = TXTtele.Text;
                found.Sex = TXTgenre.Text;
                found.DateJoin = DPdate.Value;
                TXtSalaire.Text = TXtSalaire.Text;
                grid();
                ClassInterface i = new ClassInterface();
                i.viderform(this);
            }


        }

        private void btnMise_Click(object sender, EventArgs e)
        {
            DialogResult D;
            D = MessageBox.Show("Voulez vous vraiment supprimer " + TXTnomcomplet.Text, "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (D == DialogResult.Yes)
            {
                string num = GridENTRAINEUR.CurrentRow.Cells[0].Value.ToString();
                Entraineur st = new Entraineur();
                st.supprimer(TXTnumero.Text);
                grid();
                btnSupprimer.Visible = false;
                btnMise.Visible = false;
                btnSave.Visible = true;

                ClassInterface i = new ClassInterface();
                i.viderform(this);
            }
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

        private void TXtSalaire_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
