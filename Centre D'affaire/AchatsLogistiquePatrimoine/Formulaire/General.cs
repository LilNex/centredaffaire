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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void FormCatalogue_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(70 , 0 , 0, 0);
            panel2.BackColor = Color.FromArgb(70, 0, 0, 0);
           


        }
    }
}
