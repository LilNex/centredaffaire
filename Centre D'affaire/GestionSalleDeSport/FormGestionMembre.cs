using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public partial class FormGestionMembre : Form
    {
        public FormGestionMembre()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            
        }

        private void lblprenom_Click(object sender, EventArgs e)
        {

        }

        private void TXTprenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnom_Click(object sender, EventArgs e)
        {

        }

        private void TXTnom_TextChanged(object sender, EventArgs e)
        {
           
          

        }

        private void FormGestionMembre_Load(object sender, EventArgs e)
        {

        }

        private void TXTemail_TextChanged(object sender, EventArgs e)
        {
                    }

        private void BTNNeouveau_Click(object sender, EventArgs e)
        {
            TXTnomcomplet.Text = "ousaama";
        }

        private void DPdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
               // textBox1.Text = open.FileName;
            }
        }
    }
}
