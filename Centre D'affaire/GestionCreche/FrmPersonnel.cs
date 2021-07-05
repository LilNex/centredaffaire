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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtNom.Text, txtE.Text, txtT.Text, txtA.Text, txtN.Text);

            txtNom.Clear();
            txtE.Clear();
            txtT.Clear();
            txtA.Clear();
            txtN.Clear();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean a= false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
               
                    dataGridView1.Rows[i].Selected = false;
                    a = true;
               
              
            }
            for (int i=0;i<dataGridView1.Rows.Count; i++)
            {
                if (txtNom.Text.Equals(dataGridView1.Rows[i].Cells[0].Value))
                {
                    dataGridView1.Rows[i].Selected = true;
                    a = true;
                }
                if (a == false) MessageBox.Show("error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int trouve=0;
            int index=0;
            for(int i = 0;i< this.dataGridView1.Rows.Count-1; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[1].Value.ToString() == txtMod.Text)
                {
                    index= i;
                    trouve = 1;
                }
                if (trouve == 0)
                {
                    MessageBox.Show("Ce personne n'existe pas");
                }
                else
                    this.groupBox2.Visible = true;
                this.dataGridView1.Rows[index].Cells[0].Value = txtNom.Text;
                this.dataGridView1.Rows[index].Cells[1].Value = txtE.Text;
                this.dataGridView1.Rows[index].Cells[2].Value = txtT.Text;
                this.dataGridView1.Rows[index].Cells[3].Value = txtA.Text;
                this.dataGridView1.Rows[index].Cells[4].Value = txtN.Text;
                this.txtMod.Text = string.Empty;


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Voullez vous vraiment supprimer ce personnel?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    int index = this.dataGridView1.CurrentRow.Index;
                    this.dataGridView1.Rows.RemoveAt(index);
                    MessageBox.Show("la supprretion avec Succées");
                }
                else
                    MessageBox.Show("la supprretion est ignorée");
            }
            catch(Exception)
            {
                MessageBox.Show("Datagrid este");
            }
        }
    }
}
