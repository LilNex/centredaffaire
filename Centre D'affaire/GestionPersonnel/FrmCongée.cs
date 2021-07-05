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
    public partial class FrmCongée : Form
    {
        public FrmCongée()
        {
            InitializeComponent();
        }
        public void RemplirGridCongée()
        {
            dgvCongé.Rows.Clear();

            for (int i = 0; i < Congé.ListeDesCongé.Count; i++)
            {
                dgvCongé.Rows.Add();


                dgvCongé.Rows[i].Cells["db"].Value = Congé.ListeDesCongé[i].DateDebut;
                dgvCongé.Rows[i].Cells["db"].Value = Congé.ListeDesCongé[i].DateFin;
                dgvCongé.Rows[i].Cells["durée"].Value = Congé.ListeDesCongé[i].Durée;
                dgvCongé.Rows[i].Cells["etat"].Value = Congé.ListeDesCongé[i].Etat;
                dgvCongé.Rows[i].Cells["catégorie"].Value = Congé.ListeDesCongé[i].Catégories;
                dgvCongé.Rows[i].Cells["nom"].Value = textBox1.Text;
                dgvCongé.Rows[i].Cells["cin"].Value = textBox2.Text;



            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmDemande f = new FrmDemande();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            XmlSerializer XS = new XmlSerializer(Congé.ListeDesCongé.GetType());
            StreamWriter w_fileDeps = new StreamWriter("Liste des Congés.xml");
            XS.Serialize(w_fileDeps, Congé.ListeDesCongé);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ClsEmploye. ListeEmploye.Count() > 0)
            {
                for (int i = 0; i < ClsEmploye.ListeEmploye.Count(); i++)
                {
                    if (ClsEmploye.ListeEmploye[i].Cin == textBox2.Text && ClsEmploye.ListeEmploye[i].Nom == textBox1.Text)
                    {
                        TypeConge status;
                        Enum.TryParse<TypeConge>(comboBox1.SelectedValue.ToString(), out status);
                        Congé c = new Congé(DateTime.Parse(dateTimePicker1.Text),  (int)numericUpDown1.Value, status);
                        Congé.ListeDesCongé.Add(c);
                        Congé.saveListeConge();
                        RemplirGridCongée();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("le nom ou le cin est pas valide", "Errur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            

        }

        private void FrmCongée_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetNames(typeof(TypeConge));
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
