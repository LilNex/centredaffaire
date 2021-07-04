using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    
    public partial class FrmBabyFoot : Form
    {
        int SecondeBabyFoot1; int MinuteBabyFoot1; int HoursBabyFoot1;
        int SecondeBabyFoot2; int MinuteBabyFoot2; int HoursBabyFoot2;
        int SecondeBabyFoot3; int MinuteBabyFoot3; int HoursBabyFoot3;
        int SecondeBabyFoot4; int MinuteBabyFoot4; int HoursBabyFoot4;

        public FrmBabyFoot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConnection FC = new FrmConnection();
            FC.Show();
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

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void btnRestBabyFoot1_Click(object sender, EventArgs e)
        {
            timerBabyFoot1.Stop();
            SecondeBabyFoot1 = 0; MinuteBabyFoot1 = 0; HoursBabyFoot1 = 0;
            btnPrixBabyFoot1.Text = (int.Parse(btnHoursBabyFoot1.Text) * 5 + int.Parse(btnMinuteBabyFoot1.Text) * 0.08).ToString();
            btnHoursBabyFoot1.Text = "00";
            btnMinuteBabyFoot1.Text = "00";
            btnSecondeBabyFoot1.Text = "00";
        }

        private void btnStarBabyFoot1_Click(object sender, EventArgs e)
        {
            timerBabyFoot1.Start();
        }

        private void btnStarBabyFoot2_Click(object sender, EventArgs e)
        {
            timerBabyFoot2.Start();

        }

        private void btnStarBabyFoot3_Click(object sender, EventArgs e)
        {
            timerBabyFoot3.Start();

        }

        private void btnStarBabyFoot4_Click(object sender, EventArgs e)
        {
            timerBabyFoot4.Start();

        }

        private void btnRestBabyFoot3_Click(object sender, EventArgs e)
        {
            timerBabyFoot3.Stop();
            SecondeBabyFoot3 = 0; MinuteBabyFoot3 = 0; HoursBabyFoot3 = 0;
            btnPrixBabyFoot3.Text = (int.Parse(btnHoursBabyFoot3.Text) * 5 + int.Parse(btnMinuteBabyFoot3.Text) * 0.08).ToString();
            btnHoursBabyFoot3.Text = "00";
            btnMinuteBabyFoot3.Text = "00";
            btnSecondeBabyFoot3.Text = "00";
        }

        private void FrmBabyFoot_Load(object sender, EventArgs e)
        {
            SecondeBabyFoot1 = 0; MinuteBabyFoot1 = 0; HoursBabyFoot1 = 0;
            SecondeBabyFoot2 = 0; MinuteBabyFoot2 = 0; HoursBabyFoot2 = 0;
            SecondeBabyFoot3 = 0; MinuteBabyFoot3 = 0; HoursBabyFoot3 = 0;
            SecondeBabyFoot4 = 0; MinuteBabyFoot4 = 0; HoursBabyFoot4 = 0;

            clsBabyFoot BF1 = new clsBabyFoot("Baby Foot", 01);
            ClsListeSDJ.ListBabyFoot.Add(BF1);

            clsBabyFoot BF2 = new clsBabyFoot("Baby Foot", 02);
            ClsListeSDJ.ListBabyFoot.Add(BF2);

            clsBabyFoot BF3 = new clsBabyFoot("Baby Foot", 03);
            ClsListeSDJ.ListBabyFoot.Add(BF3);

            //clsBabyFoot BF1 = new clsBabyFoot("Baby Foot", 01);
            //ClsListeSDJ.ListBabyFoot.Add(BF1);

            btnHoursBabyFoot1.Text = "00";
            btnMinuteBabyFoot1.Text = "00";
            btnSecondeBabyFoot1.Text = "00";

            btnHoursBabyFoot2.Text = "00";
            btnMinuteBabyFoot2.Text = "00";
            btnSecondeBabyFoot2.Text = "00";

            btnHoursBabyFoot3.Text = "00";
            btnMinuteBabyFoot3.Text = "00";
            btnSecondeBabyFoot3.Text = "00";

            btnHoursBabyFoot4.Text = "00";
            btnMinuteBabyFoot4.Text = "00";
            btnSecondeBabyFoot4.Text = "00";

           

        }

        private void btnRestBabyFoot2_Click(object sender, EventArgs e)
        {
            timerBabyFoot2.Stop();
            SecondeBabyFoot2 = 0; MinuteBabyFoot2 = 0; HoursBabyFoot2 = 0;
            btnPrixBabyFoot2.Text = (int.Parse(btnHoursBabyFoot2.Text) * 5 + int.Parse(btnMinuteBabyFoot2.Text) * 0.08).ToString();
            btnHoursBabyFoot2.Text = "00";
            btnMinuteBabyFoot2.Text = "00";
            btnSecondeBabyFoot2.Text = "00";
        }

        private void btnRestBabyFoot4_Click(object sender, EventArgs e)
        {
            timerBabyFoot4.Stop();
            SecondeBabyFoot4 = 0; MinuteBabyFoot4 = 0; HoursBabyFoot4 = 0;
            btnPrixBabyFoot4.Text = (int.Parse(btnHoursBabyFoot4.Text) * 5 + int.Parse(btnMinuteBabyFoot4.Text) * 0.08).ToString();
            btnHoursBabyFoot4.Text = "00";
            btnMinuteBabyFoot4.Text = "00";
            btnSecondeBabyFoot4.Text = "00";
        }

        private void btnClearArcardS1_Click(object sender, EventArgs e)
        {
            btnPrixBabyFoot1.Text = null;
        }

        private void btnClearArcardS2_Click(object sender, EventArgs e)
        {
            btnPrixBabyFoot2.Text = null;

        }

        private void btnClearArcardS3_Click(object sender, EventArgs e)
        {
            btnPrixBabyFoot3.Text = null;

        }

        private void btnClearArcardS4_Click(object sender, EventArgs e)
        {
            btnPrixBabyFoot4.Text = null;

        }

        private void timerBabyFoot1_Tick(object sender, EventArgs e)
        {
            btnHoursBabyFoot1.Text = (SecondeBabyFoot1++).ToString();
            if (SecondeBabyFoot1 >= 60)
            {
                (MinuteBabyFoot1++).ToString();
                SecondeBabyFoot1 = 00;



                if (MinuteBabyFoot1 == 60)
                {
                    (MinuteBabyFoot1++).ToString();
                    MinuteBabyFoot1 = 00;



                    if (HoursBabyFoot1 == 02)
                    {

                        timerBabyFoot1.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        btnHoursBabyFoot1.Text = "00";
                        btnMinuteBabyFoot1.Text = "00";
                        btnSecondeBabyFoot1.Text = "00";

                    }
                }

            }
            btnSecondeBabyFoot1.Text = string.Format("{0:00}", SecondeBabyFoot1);
            btnMinuteBabyFoot1.Text = string.Format("{0:00}", MinuteBabyFoot1);
            btnHoursBabyFoot1.Text = string.Format("{0:00}", HoursBabyFoot1);
        }

        private void timerBabyFoot2_Tick(object sender, EventArgs e)
        {
            btnHoursBabyFoot2.Text = (SecondeBabyFoot2++).ToString();
            if (SecondeBabyFoot2 >= 60)
            {
                (MinuteBabyFoot2++).ToString();
                SecondeBabyFoot2 = 00;



                if (MinuteBabyFoot2 == 60)
                {
                    (MinuteBabyFoot2++).ToString();
                    MinuteBabyFoot2 = 00;



                    if (HoursBabyFoot2 == 02)
                    {

                        timerBabyFoot2.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        btnHoursBabyFoot2.Text = "00";
                        btnMinuteBabyFoot2.Text = "00";
                        btnSecondeBabyFoot2.Text = "00";

                    }
                }

            }
            btnSecondeBabyFoot2.Text = string.Format("{0:00}", SecondeBabyFoot2);
            btnMinuteBabyFoot2.Text = string.Format("{0:00}", MinuteBabyFoot2);
            btnHoursBabyFoot2.Text = string.Format("{0:00}", HoursBabyFoot2);
        }

        private void timerBabyFoot3_Tick(object sender, EventArgs e)
        {
            btnHoursBabyFoot3.Text = (SecondeBabyFoot3++).ToString();
            if (SecondeBabyFoot3 >= 60)
            {
                (MinuteBabyFoot3++).ToString();
                SecondeBabyFoot3 = 00;



                if (MinuteBabyFoot3 == 60)
                {
                    (MinuteBabyFoot3++).ToString();
                    MinuteBabyFoot3 = 00;



                    if (HoursBabyFoot3 == 02)
                    {

                        timerBabyFoot3.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        btnHoursBabyFoot3.Text = "00";
                        btnMinuteBabyFoot3.Text = "00";
                        btnSecondeBabyFoot3.Text = "00";

                    }
                }

            }
            btnSecondeBabyFoot3.Text = string.Format("{0:00}", SecondeBabyFoot3);
            btnMinuteBabyFoot3.Text = string.Format("{0:00}", MinuteBabyFoot3);
            btnHoursBabyFoot3.Text = string.Format("{0:00}", HoursBabyFoot3);
        }

        private void timerBabyFoot4_Tick(object sender, EventArgs e)
        {
            btnHoursBabyFoot4.Text = (SecondeBabyFoot4++).ToString();
            if (SecondeBabyFoot4 >= 60)
            {
                (MinuteBabyFoot4++).ToString();
                SecondeBabyFoot4 = 00;



                if (MinuteBabyFoot4 == 60)
                {
                    (MinuteBabyFoot4++).ToString();
                    MinuteBabyFoot4 = 00;



                    if (HoursBabyFoot4 == 02)
                    {

                        timerBabyFoot4.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        btnHoursBabyFoot4.Text = "00";
                        btnMinuteBabyFoot4.Text = "00";
                        btnSecondeBabyFoot4.Text = "00";

                    }
                }

            }
            btnSecondeBabyFoot4.Text = string.Format("{0:00}", SecondeBabyFoot4);
            btnMinuteBabyFoot4.Text = string.Format("{0:00}", MinuteBabyFoot4);
            btnHoursBabyFoot4.Text = string.Format("{0:00}", HoursBabyFoot4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAbout FRMA1 = new FrmAbout();
            FRMA1.Show();
        }

        private void btnEditBabyFoot_Click(object sender, EventArgs e)
        {
            frmAddGameAndEmployer FRMAA12 = new frmAddGameAndEmployer();
            FRMAA12.Show();
        }
    }
}
