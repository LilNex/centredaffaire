using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire
{
    public partial class FrmPersonnel : Form
    {
        public FrmPersonnel()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "HafsaFile(*.Hafsa)*|bureau files|*.bureau|all files(*.*)|*.*|";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    pictureBox1.ImageLocation = dialog.FileName;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error Accord", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtNomC.Text,txtEmail.Text,txtTele.Text,txtNiveau.Text);
            txtNomC.Clear();
            txtEmail.Clear();
            txtTele.Clear();
            txtNiveau.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("voullez vous vraiment supprimer ce personnel?", "confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    int index = this.dataGridView1.CurrentRow.Index;
                    this.dataGridView1.Rows.RemoveAt(index);
                    MessageBox.Show("la suppretion avec succés");
                }
                else
                {
                    MessageBox.Show("la suppretion est ignorée");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Datagrid est vide");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                row.Cells[0].Value = txtNomC;
                row.Cells[1].Value = txtEmail;
                row.Cells[2].Value = txtTele;
                row.Cells[3].Value = txtNiveau;

            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Selected = false;
            Boolean a = false;
            for(int i=0; i<dataGridView1.Rows.Count;i++)
            {
                if (txtNomC.Text.Equals(dataGridView1.Rows[i].Cells[0].Value))
                {
                    dataGridView1.Rows[i].Selected = true;
                    a = true;
                }
                if (a == false) MessageBox.Show("error");

            }
        }

        private void FrmPersonnel_Load(object sender, EventArgs e)
        {
            
        }
    }
}
