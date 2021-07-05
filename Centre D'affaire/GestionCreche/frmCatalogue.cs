using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionCreche
{
    public partial class catalogue111 : Form
    {
        public catalogue111()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void catalogue1_Load(object sender, EventArgs e)
        {

        }

        private void btnRepas_Click(object sender, EventArgs e)
        {
            pcr.Hide();
            rp21.Hide();
            rp31.Hide();
            rp11.Show();
            btnNext2.Hide();
            btnPrecedent2.Hide();
            btnNext1.Show();
            btnPrecedent1.Show();
            jeux1.Hide();
            
            rp11.BringToFront();

        }

     

        private void frmCatalogue_Load(object sender, EventArgs e)
        {
            catalogue111 ca = new catalogue111();
            pcr.BringToFront();
            rp11.Hide();
            rp21.Hide();
            rp31.Hide();
            btnNext2.Hide();
            btnNext1.Hide();
            btnPrecedent1.Hide();
            btnPrecedent2.Hide();
        }

        private void rp31_Load(object sender, EventArgs e)
        {

        }

        private void rp11_Load(object sender, EventArgs e)
        {

        }

        private void rp21_Load(object sender, EventArgs e)
        {

        }

        private void rp31_Load_1(object sender, EventArgs e)
        {

        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
           
                
                    rp11.Hide();
                    rp31.Hide();
                    rp21.Show();
            btnNext1.Hide();
            btnPrecedent2.Hide();
            btnNext2.Show();
                    rp21.BringToFront();
                


            //rp11.Hide();
            //rp21.Hide();
            //rp31.Show();
            //rp31.BringToFront();





        }

        private void btnPrecedent1_Click(object sender, EventArgs e)
        {
            rp21.Hide();
            rp31.Hide();
            rp11.Show();
            btnNext1.Show();
            

            rp11.BringToFront();
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            rp11.Hide();
            rp21.Hide();
            rp31.Show();
            btnPrecedent2.Show();
            btnNext2.Hide();
            btnNext1.Hide();
            rp31.BringToFront();
        }

        private void btnPrecedent2_Click(object sender, EventArgs e)
        {
            rp11.Hide();
            rp31.Hide();
            rp21.Show();
            btnNext1.Hide();
            btnPrecedent2.Hide();
            btnNext2.Show();
            rp21.BringToFront();
        }

        private void rp21_Load_1(object sender, EventArgs e)
        {
            //btnPrecedent2.Show();
            //btnNext2.Show();
            //btnNext1.Hide();
            //rp21.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }


        private void btnSport_Click(object sender, EventArgs e)
        {
            sport1.BringToFront();
            pcr.Hide();
            btnNext2.Hide();
            btnNext1.Hide();
            btnPrecedent1.Hide();
            btnPrecedent2.Hide();
            sport1.Show();

        }

        private void btnJoue_Click(object sender, EventArgs e)
        {
           
            pcr.Hide();
            rp11.Hide();
            rp21.Hide();
            rp31.Hide();
            btnNext2.Hide();
            btnNext1.Hide();
            btnPrecedent1.Hide();
            btnPrecedent2.Hide();
            jeux1.Show();
            jeux1.BringToFront();

        }

        private void btnActivité_Click(object sender, EventArgs e)
        {
            pcr.Hide();
            rp11.Hide();
            rp21.Hide();
            rp31.Hide();
            btnNext2.Hide();
            btnNext1.Hide();
            btnPrecedent1.Hide();
            btnPrecedent2.Hide();
            activité1.Show();
            activité1.BringToFront();
        }









        //private void btnNext2_Click(object sender, EventArgs e)
        //{
        //    rapas2_User repas = new rapas2_User();
        //    repas.Show();
        //}

        //private void btnPrecedent_Click(object sender, EventArgs e)
        //{
        //    Catalogue_User cu = new Catalogue_User();
        //    cu.Show();
        //}
    }
}
