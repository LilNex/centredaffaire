using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    
    public partial class UCNotif : UserControl
    {
        
        public UCNotif()
        {
            InitializeComponent();
        }
        public void showError(string message)
        {
                lblMessage.Text = message;
            this.BringToFront();

        }
        private void UCNotif_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            
        }
    }
}
