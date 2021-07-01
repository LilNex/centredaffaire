using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionCreche
{
    public partial class frmGroupe : Form
    {
        public void RemplirGridEnfant()
        {
            dgvGroupe.Rows.Clear();

            for (int i = 0; i < clsListe.listeGroupe.Count; i++)
            {
                dgvGroupe.Rows.Add();

                dgvGroupe.Rows[i].Cells["Column1"].Value = clsListe.listeGroupe[i].NumG;
                dgvGroupe.Rows[i].Cells["Column2"].Value = clsListe.listeGroupe[i].NomG;


            }
        }

        public frmGroupe()
        {
            InitializeComponent();
        }
        

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            interfaces f = new interfaces();
            f.viderform(this);
        }

        private void btnNouveau_Click_1(object sender, EventArgs e)
        {
            
                interfaces f = new interfaces();
                f.viderform(this);
          
        }

        private void frmGroupe_Load(object sender, EventArgs e)
        {

        }

       

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            foreach( DataGridViewRow row in dgvGroupe.SelectedRows)
            {
                dgvGroupe.Rows.RemoveAt(row.Index);

            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        
        int index;

        

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int trouve=0;
            

            for (int i = 0; i < this.dgvGroupe.Rows.Count - 1; i++)
                

                
            {
                if (this.dgvGroupe.Rows[i].Cells[1].Value.ToString() == txtNumSERCHE.Text)
                {
                    index = i;
                    trouve = 1;
                 

                }

            }
            if (trouve == 0)

                MessageBox.Show(" ce groupe N'existe pas dans la liste ");
            else
                this.grbModification.Visible = true;


        }

        private void btnAppliquer_Click(object sender, EventArgs e)
        {

            this.dgvGroupe.Rows[index].Cells[0].Value = txtNewNom.Text;
            this.dgvGroupe.Rows[index].Cells[1].Value = txtNewNum.Text;
            this.grbModification.Visible = false;
            this.txtNumSERCHE.Text = string.Empty;

        }
    }
}
