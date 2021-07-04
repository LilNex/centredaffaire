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
        public object Fonctionnaire { get; private set; }

        public frmGroupe()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNom.Text==""|| txtNum.Text==""|| cbxGroupe.Text == "")
            {
                MessageBox.Show("attention !! une information est vide !!");
            }
            else
            {
                try
                {
                    this.dataGridView1.Rows.Add(int.Parse(txtNum.Text), txtNom.Text, cbxGroupe.Text);
                    this.txtNum.Clear();
                    this.txtNom.Clear();
                    this.cbxGroupe.Text=" ";
                }
                catch(FormatException)
                {
                    MessageBox.Show("Num Invalid ");

                }
            }
           

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Voulez Vous Vraiment Supprimer cette ligne ? ", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    int index = this.dataGridView1.CurrentRow.Index;
                    this.dataGridView1.Rows.RemoveAt(index);
                    MessageBox.Show("la suppression avec succées ");
                }
                else
                    MessageBox.Show("la suppression ign");

            }
            catch (Exception)
            {
                MessageBox.Show("DataGridView est vide ");
            }

        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            int cmp = 0;
            for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
            {
                if(this.dataGridView1.Rows[i].Cells[2].Value.ToString()== this.txtNomR.Text)
                {
                    MessageBox.Show("il existe!!");
                    cmp = 1;
                    
                }
            }
            if (cmp == 0)
                MessageBox.Show("n'existe pas");
        }
        int index;
        private void button1_Click(object sender, EventArgs e)
        {
            int trouve = 0;
            
            for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[2].Value.ToString() == txtSerch.Text)
                {
                    index = i;
                    trouve = 1;
                }
            }
            if (trouve == 0)
                MessageBox.Show("cette personne N'existe pas dans la liste ");
            else
                this.groupBox1.Visible = true;
        }

        private void btnAppliquer_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows[index].Cells[0].Value = txtNum.Text;
            this.dataGridView1.Rows[index].Cells[1].Value = txtNom.Text;
            this.dataGridView1.Rows[index].Cells[2].Value = cbxGroupe.Text;
            this.groupBox1.Visible = false;
            this.txtSerch.Text = string.Empty;
        }
    }
}
