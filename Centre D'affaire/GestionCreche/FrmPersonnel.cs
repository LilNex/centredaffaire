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
    public partial class FrmPersonnel : Form
    {
        public string ClsPersonnel { get; private set; }

        public FrmPersonnel()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)

        {
            if(txtnom.Text!=""&& txtprenom.Text!=""&& txttele.Text!=""&& txtAd.Text!=""&& txtAd.Text!=""&& txtNum.Text!="")
            dataGridView1.Rows.Add(txtnom.Text, txtprenom.Text, txttele.Text, txtAd.Text, txtAd.Text, txtNum.Text);
           

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        

        // private bool button4_Click(object sender, EventArgs e)
        // {


        // }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      


            
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPersonnel_Load(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string Nom = txtnom.Text;
            string Prenom = txtprenom.Text;
            string Telephone = txttele.Text;
            string Adresse = txtAd.Text;
            string Email = txtEmail.Text;
            string Numero = txtNum.Text;
            dataGridView1.CurrentRow.Cells[0].Value = Nom;
            dataGridView1.CurrentRow.Cells[1].Value = Prenom;
            dataGridView1.CurrentRow.Cells[2].Value = Telephone;
            dataGridView1.CurrentRow.Cells[3].Value = Adresse;
            dataGridView1.CurrentRow.Cells[4].Value = Email;
            dataGridView1.CurrentRow.Cells[5].Value = Numero;

        }

       

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("voullez vous vraiment supprimer ce personnel)", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    int index = this.dataGridView1.CurrentRow.Index;
                    this.dataGridView1.Rows.RemoveAt(index);
                    MessageBox.Show("La suppretion avec succées");

                }
                else
                {
                    MessageBox.Show("La suppretion ignorées");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("DatagridView est vide");
            }

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Selected = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if (txtNsearch.Text.Equals(dataGridView1.Rows[i].Cells[5].Value))
                    dataGridView1.Rows[i].Selected = true;
            bool R = true;
            if (R == false) MessageBox.Show("Error");
        }
    }
    
}

