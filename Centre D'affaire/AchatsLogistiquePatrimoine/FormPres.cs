using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public partial class FormPres : Form
    {
        public FormPres()
        {
            InitializeComponent();
        }

        private void FormPres_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(50, 0, 0, 0);
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDemande_Click(object sender, EventArgs e)
        {
            //Thread t = new Thread(affiche);
            //t.Start();
            FormPcom f = new FormPcom();
            f.Show();

        }
    }
}
