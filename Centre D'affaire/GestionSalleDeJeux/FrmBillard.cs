using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    public partial class FrmBillard : Form
    {

        int MSeconds; int Seconds; int Minutes;

     
        clsJeux J1 = new clsJeux();
        clsJeux J2 = new clsJeux();
        clsJeux J3 = new clsJeux();
        clsJeux J4 = new clsJeux();
        public FrmBillard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void GSDJ_Load(object sender, EventArgs e)
        {
            int Seconde, Minute, Hours;

            J1.NomJ="Billard";
            ClsListeSDJ.ListJeux.Add(J1);

            J2.NomJ = "Baby Foot";
           
            ClsListeSDJ.ListJeux.Add(J2);

            J3.NomJ = "8 Bool";
            ClsListeSDJ.ListJeux.Add(J3);

            J4.NomJ = ""; ;
            ClsListeSDJ.ListJeux.Add(J4);

            LblNameJ1.Text = J1.NomJ;
            btnHoure.Text = "00";
            btnSeconde.Text = "00";
            btnMinute.Text = "00";

        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBillHot_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            
            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void GbJ1_Enter(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }
        private void PointDepartTime()
        {
            btnHoure.Text = "00";
            btnSeconde.Text = "00";
            btnMinute.Text = "00";
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMENU1 menu = new FrmMENU1();
            menu.Show();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            FrmSupport FS = new FrmSupport();
            FS.Show();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            FrmConnection FC = new FrmConnection();
            FC.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MSeconds = 0; Seconds = 0; Minutes = 0;
            PointDepartTime();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnSeconde.Text = (MSeconds++).ToString();
            if (MSeconds >= 10)
            {
                MSeconds = 0;

                btnSeconde.Text = (MSeconds++).ToString();

                if (Seconds >= 60)
                {
                    Seconds = 0;
                    btnMinute.Text = (Minutes++).ToString();

                    if (Minutes >= 5)
                    {
                        PointDepartTime();
                        timer1.Stop();
                        
                    }
                }

            }
        }
        private void btnOccupation_Click(object sender, EventArgs e)
        {

        }

        private void btnPrixBillard_Click(object sender, EventArgs e)
        {
        }

        private void btnHoure_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }
    }
}
