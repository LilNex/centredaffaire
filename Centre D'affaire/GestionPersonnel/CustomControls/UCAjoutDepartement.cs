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
    public partial class UCAjoutDepartement : UserControl
    {
        private List<clsPoste> tempListePoste = new List<clsPoste>();

        public UCAjoutDepartement()
        {
            InitializeComponent();
        }

        private void UCAjoutDepartement_Load(object sender, EventArgs e)
        {
            tempListePoste.Clear();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ClsDepartement newDep = new ClsDepartement(txtDepNom.Text,txtDepNum.Text);
            if (tempListePoste.Count != 0)
            {
                newDep.ListePoste = tempListePoste;
            }
            ClsDepartement.ListeDepartement.Add(newDep);
        }

        private void btnAjouterPoste_Click(object sender, EventArgs e)
        {
            clsPoste tempPoste = new clsPoste(txtTempPosteNom.Text, txtTempPosteNum.Text);
            tempListePoste.Add(tempPoste);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tempListePoste;
            tempPoste = null;
            
        }
    }
}
