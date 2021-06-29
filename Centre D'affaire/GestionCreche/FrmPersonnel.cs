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
        public FrmPersonnel()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnom.Text == " " || txtprenom.Text == "" || txtEmail.Text == "" || txtAd.Text == "" || txtNum.Text == "" || txttele.Text == "")
            {
                MessageBox.Show("Attention!!une information est vide!!");
            }
            else
            {
                try
                {
                    dataGridView1.Rows.Add(txtnom.Text, txtprenom.Text, txtEmail.Text, txtAd.Text, txtNum.Text, int.Parse(txttele.Text));
                    {

                        {
                            txtprenom.Clear();
                            txtEmail.Clear();
                            txtAd.Clear();
                            txtNum.Clear();
                            txttele.Clear();

                        }
                    }
                }

                catch (FormatException)
                {
                    MessageBox.Show("l'age invalide");

                }


            }


        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
           // int trouve = 0;
           // int index;
           //// for (int i = 0 < this.dataGridView1.Rows.Count - 1; i++)
           //  //   if (this.dataGridView1.Rows[i].Cells[5].Value.ToString== txtNsearch.Text)
           //     {
           //       // index = i;
           //        // trouve = 1;
           //     }
           //// if (trouve == 0)

           //     MessageBox.Show(" Cette personne n'existe pas dans la liste");

           // else
           //     this.Modification.Visible = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

