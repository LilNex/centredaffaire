using System;
using System.Collections.Generic;
using System.Drawing;

using System.Windows.Forms;

namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    public partial class UCAjoutEmploye : UserControl
    {
        //public List<clsDepartememnt> ListeDepartements { get; set; }      to update
        public UCAjoutEmploye()
        {
            InitializeComponent();
        }

        public void reloadForm()
        {
            //cmbDeparts.DataSource = null;
            //cmbDeparts.DataSource = ClsDepartement.ListeDepartement;
            cmbDeparts.Items.Clear();
            cmbDeparts.Items.Add("Choisissez un departement");
            cmbDeparts.Text = "Choisissez un departement";

            foreach(ClsDepartement dep in ClsDepartement.ListeDepartement)
            {
                cmbDeparts.Items.Add(dep);
            }

            //cmbPoste.DataSource = null;
            cmbPoste.Items.Clear();
            cmbPoste.Items.Add("Choisissez un poste");
            cmbPoste.Text = "Choisissez un poste";

        }
        private void UCAjoutEmploye_Load(object sender, EventArgs e)
        {
            reloadForm();
        }

        private void rdbH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbF_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        

        private void txtAdresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDeparts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDeparts.SelectedItem is ClsDepartement)
            {
                cmbPoste.Items.Clear();
                cmbPoste.Items.Add("Choisissez un poste");
                cmbPoste.Text = "Choisissez un poste";
                foreach (clsPoste Poste in ((ClsDepartement)cmbDeparts.SelectedItem).ListePoste)
                {
                    cmbPoste.Items.Add(Poste);
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            char sexe = 'H';
            if (rdbH.Checked)
            {
                sexe = 'H';
            }
            if (rdbF.Checked)
            {
                sexe = 'F';
                

            }
            EmployeType empType = EmployeType.Employe;
            if (rdbTEmp.Checked)
            {
                empType = EmployeType.Employe;
            }
            if (rdbTSecretaire.Checked)
            {
                empType = EmployeType.Secretaire;
            }
            if (rdbTDirecteur.Checked)
            {
                empType = EmployeType.Directeur;
            }

            ClsEmploye employe = new ClsEmploye(txtNum.Text, txtNom.Text, txtPrenom.Text, txtCIN.Text, txtNumTel.Text, txtEmail.Text, 'M', textBox5.Text, DateTime.Now , datePicker.Value,sexe,txtAdresse.Text,empType);
            //ClsEmploye employe = new ClsEmploye();
            if(cmbDeparts.SelectedItem is ClsDepartement)
            {
                if (cmbPoste.SelectedItem is clsPoste)
                {
                    //((clsPoste)cmbPoste.SelectedItem).ajouterEmploye(employe);
                    for (int i = 0; i < ClsDepartement.ListeDepartement.Count; i++)
                    {
                        if (ClsDepartement.ListeDepartement[i].Num == ((ClsDepartement)cmbDeparts.SelectedItem).Num)
                        {
                            for (int y = 0; y < ClsDepartement.ListeDepartement[i].ListePoste.Count; y++)
                            {
                                if (ClsDepartement.ListeDepartement[i].ListePoste[y].Num == ((clsPoste)cmbPoste.SelectedItem).Num)
                                {
                                    ClsDepartement.ListeDepartement[i].ListePoste[y].ajouterEmploye(employe);
                                    ClsDepartement.saveListeDeps();
                                }
                            }
                        }
                    }
                }
            }
            
        }

        private void txtRechercheNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "PNG Image (*.png)|*.png|JPEG Image (*.jpg)|*.jpg|All files (*.*)|*.*";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Functions.clearForm(this);
        }
    }
}
