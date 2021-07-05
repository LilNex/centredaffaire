using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    public partial class UCAjoutPoste : UserControl
    {
        private List<clsPoste> tempListePoste = new List<clsPoste>();
        NotifyIcon N = new NotifyIcon();


        public UCAjoutPoste()
        {
            InitializeComponent();
            N.Icon = SystemIcons.Information;
            N.Visible = true;
        }

        private void UCAjoutDepartement_Load(object sender, EventArgs e)
        {
            tempListePoste.Clear();
            cmbDeparts.Items.Clear();
            cmbDeparts.Items.Add("Choisissez un departement");
            cmbDeparts.Text = "Choisissez un departement";

            foreach (ClsDepartement dep in ClsDepartement.ListeDepartement)
            {
                cmbDeparts.Items.Add(dep);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            
        }

        private void btnAjouterPoste_Click(object sender, EventArgs e)
        {
            clsPoste tempPoste = new clsPoste(txtTempPosteNom.Text, txtTempPosteNum.Text);
            if (Functions.addPoste(ClsDepartement.ListeDepartement[ClsDepartement.rechercheDepNum(((ClsDepartement)cmbDeparts.SelectedItem).Num)].ListePoste, tempPoste))
            {
                N.ShowBalloonTip(1100, "Poste ajouté", "Le poste a été ajouté à la liste avec succès", ToolTipIcon.Info);
                 
            }
            else
            {
                N.ShowBalloonTip(1100, "Ajout échoué", "Le numéro du poste est déja dans la liste", ToolTipIcon.Error);

            }

            dataGridView1.DataSource = null;
            if (tempListePoste.Count != 0)
            {
                dataGridView1.Columns["Num"].Visible = false;
                dataGridView1.Columns["Nom"].Visible = false;
                dataGridView1.DataSource = tempListePoste;

            }
            else
            {
                dataGridView1.Columns["Num"].Visible = true;
                dataGridView1.Columns["Nom"].Visible = true;
            }
            tempPoste = null;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions.clearForm(this);
        }
    }
}
