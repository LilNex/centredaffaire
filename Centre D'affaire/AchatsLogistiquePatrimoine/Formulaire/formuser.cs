using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public partial class formuser : Form
    {
        public formuser()
        {
            InitializeComponent();
        }
        Catalogue f = new Catalogue();

        private void formuser_Load(object sender, EventArgs e)
        {
            bunifuDropdown1.AddItem("departement");
            dataGridView1 .DataSource = ClsListe.List_choix;
            
           
        }

        private void ucDTLdemande1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
         }
    }
}
;