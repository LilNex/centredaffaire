using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionPersonnel
{
    public partial class FrmCongée : Form
    {
        public FrmCongée()
        {
            InitializeComponent();
        }
        public void RemplirGridStagiaires()
        {
            dgvStagiaires.Rows.Clear();

            for (int i = 0; i < Congé.ListeDesCongé.Count; i++)
            {
                dgvStagiaires.Rows.Add();


                dgvStagiaires.Rows[i].Cells["db"].Value = Congé.ListeDesCongé[i].Dated;
                dgvStagiaires.Rows[i].Cells["db"].Value = Congé.ListeDesCongé[i].Datef;
                dgvStagiaires.Rows[i].Cells["durée"].Value = Congé.ListeDesCongé[i].Durée;
                dgvStagiaires.Rows[i].Cells["etat"].Value = Congé.ListeDesCongé[i].Etat;
                dgvStagiaires.Rows[i].Cells["catégorie"].Value = Congé.ListeDesCongé[i].Catégories;
                dgvStagiaires.Rows[i].Cells["nom"].Value = textBox1.Text;
                dgvStagiaires.Rows[i].Cells["cin"].Value = textBox2.Text;



            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmDemande f = new FrmDemande();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Congé.ListeEmploye.Count() > 0)
            {
                for (int i = 0; i < Congé.ListeEmploye.Count(); i++)
                {
                    if (Congé.ListeEmploye[i].Cin == textBox2.Text && Congé.ListeEmploye[i].Nom == textBox1.Text)
                    {
                        Congé c = new Congé(DateTime.Parse(dateTimePicker1.Text), DateTime.Parse(dateTimePicker2.Text), (int)numericUpDown1.Value, textBox3.Text, textBox4.Text);
                        Congé.ListeDesCongé.Add(c);
                        RemplirGridStagiaires();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("le nom ou le cin est pas valide", "Errur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("la liste des employés est valide", "Errur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FrmCongée_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
