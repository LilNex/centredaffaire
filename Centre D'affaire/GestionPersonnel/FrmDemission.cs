using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Centre_D_affaire.GestionPersonnel
{
    public partial class FrmDemission : Form
    {
        public FrmDemission()
        {
            InitializeComponent();
        }
        public void RemplirGridDemission()
        {
            dgvDemission.Rows.Clear();

            for (int i = 0; i <Demission.ListeDesDemission.Count; i++)
            {
                dgvDemission.Rows.Add();


                dgvDemission.Rows[i].Cells["date"].Value = Demission.ListeDesDemission[i].Date;
                dgvDemission.Rows[i].Cells["raison"].Value = Demission.ListeDesDemission[i].Raison;
                dgvDemission.Rows[i].Cells["etat"].Value = Demission.ListeDesDemission[i].Etat;
                dgvDemission.Rows[i].Cells["nm"].Value = textBox1.Text;
                dgvDemission.Rows[i].Cells["cin"].Value = textBox2.Text;



            }
        }
        private void FrmDemission_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            XmlSerializer XS = new XmlSerializer(Demission.ListeDesDemission.GetType());
            StreamWriter w_fileDeps = new StreamWriter("Liste des Demission.xml");
            XS.Serialize(w_fileDeps, Demission.ListeDesDemission);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmDemande f = new FrmDemande();
            f.Show();
            this.Hide();
        }

      
            private void button1_Click(object sender, EventArgs e)
            {
                if (ClsEmploye.ListeEmploye.Count() > 0)
                {
                    for (int i = 0; i < ClsEmploye.ListeEmploye.Count(); i++)
                    {
                        if (ClsEmploye.ListeEmploye[i].Cin == textBox2.Text && ClsEmploye.ListeEmploye[i].Nom == textBox1.Text)
                        {
                            Demission d = new Demission( dateTimePicker1.Value,textBox3.Text);
                            Demission.ListeDesDemission.Add(d);
                            Demission.saveListeDemission();
                            RemplirGridDemission();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("le nom ou le cin est pas valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("la liste des employés est valide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
