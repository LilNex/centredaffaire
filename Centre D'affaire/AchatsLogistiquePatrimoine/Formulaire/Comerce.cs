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
    public partial class Comerce : Form
    {
        public Comerce()
        {
            InitializeComponent();
        }

        private void Comerce_Load(object sender, EventArgs e)
        {
           
                
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        public void users()
        {
            Comerce n = new Comerce();

            foreach(Control c in  this.Controls) 
            { 
                if( c is UserControl)
                {
                    c.Hide();
                }
            }
        }
    }
}
