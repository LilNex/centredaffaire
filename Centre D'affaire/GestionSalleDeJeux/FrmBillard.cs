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

        int SecondsBillard1 , MinutesBillard1 , HoursBillard1 ;
        int SecondsBillard2 , MinutesBillard2 , HoursBillard2 ;
        int SecondsBillard3 , MinutesBillard3 , HoursBillard3 ;
        int SecondsBillard4 , MinutesBillard4 , HoursBillard4 ;
        int SecondsBillard5 , MinutesBillard5 , HoursBillard5 ;
        int SecondsBillard6 , MinutesBillard6 , HoursBillard6 ;
        int SecondsBillard7 , MinutesBillard7 , HoursBillard7 ;
        int SecondsBillard8 , MinutesBillard8 , HoursBillard8 ;

        clsJeux J1 = new clsJeux();
        clsJeux J2 = new clsJeux();
        clsJeux J3 = new clsJeux();
        clsJeux J4 = new clsJeux();
        clsJeux J5 = new clsJeux();
        clsJeux J6 = new clsJeux();
        clsJeux J7 = new clsJeux();
        clsJeux J8 = new clsJeux();

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
            SecondsBillard1 = 0; MinutesBillard1 = 0; HoursBillard1 = 0;
            SecondsBillard2 = 0; MinutesBillard2 = 0; HoursBillard2 = 0;
            SecondsBillard3 = 0; MinutesBillard3 = 0; HoursBillard3 = 0;
            SecondsBillard4 = 0; MinutesBillard4 = 0; HoursBillard4 = 0;
            SecondsBillard5 = 0; MinutesBillard5 = 0; HoursBillard5 = 0;
            SecondsBillard6 = 0; MinutesBillard6 = 0; HoursBillard6 = 0;
            SecondsBillard7 = 0; MinutesBillard7 = 0; HoursBillard7 = 0;
            SecondsBillard8 = 0; MinutesBillard8 = 0; HoursBillard8 = 0;



            txtSecondeBillard1.Text = "00";
            TxtMinuteBillard1.Text = "00";
            txtHoursBillard1.Text = "00";

            txtSecondeBillard2.Text = "00";
            TxtMinuteBillard2.Text = "00";
            txtHoursBillard2.Text = "00";

            txtSecondeBillard3.Text = "00";
            TxtMinuteBillard3.Text = "00";
            txtHoursBillard3.Text = "00";

            txtSecondeBillard4.Text = "00";
            TxtMinuteBillard4.Text = "00";
            txtHoursBillard4.Text = "00";

            txtSecondeBillard5.Text = "00";
            TxtMinuteBillard5.Text = "00";
            txtHoursBillard5.Text = "00";

            txtSecondeBillard6.Text = "00";
            TxtMinuteBillard6.Text = "00";
            txtHoursBillard6.Text = "00";

            txtSecondeBillard7.Text = "00";
            TxtMinuteBillard7.Text = "00";
            txtHoursBillard7.Text = "00";

            txtSecondeBillard8.Text = "00";
            TxtMinuteBillard8.Text = "00";
            txtHoursBillard8.Text = "00";
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
            timerBillard1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            
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

        private void btnClearBillard2_Click(object sender, EventArgs e)
        {
            btnPrixBillard2.Text = null;
        }

        private void txtHoursBillard1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timerBillard2_Tick(object sender, EventArgs e)
        {
            txtSecondeBillard2.Text = (SecondsBillard2++).ToString();
            if (SecondsBillard2 >= 60)
            {
                (MinutesBillard2++).ToString();
                SecondsBillard2 = 00;



                if (MinutesBillard2 == 60)
                {
                    (HoursBillard2++).ToString();
                    MinutesBillard2 = 00;



                    if (HoursBillard2 == 02)
                    {

                        timerBillard2.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        txtHoursBillard2.Text = "00";
                        txtSecondeBillard2.Text = "00";
                        TxtMinuteBillard2.Text = "00";

                    }
                }

            }
            txtSecondeBillard2.Text = string.Format("{0:00}", SecondsBillard2);
            TxtMinuteBillard2.Text = string.Format("{0:00}", MinutesBillard2);
            txtHoursBillard2.Text = string.Format("{0:00}", HoursBillard2);
        }

        private void txtHoursBillard2_Click(object sender, EventArgs e)
        {

        }

        private void TxtMinuteBillard2_Click(object sender, EventArgs e)
        {

        }

        private void txtSecondeBillard2_Click(object sender, EventArgs e)
        {

        }

        private void txtHoursBillard3_Click(object sender, EventArgs e)
        {

        }

        private void TxtMinuteBillard3_Click(object sender, EventArgs e)
        {

        }

        private void txtSecondeBillard3_Click(object sender, EventArgs e)
        {

        }

        private void txtHoursBillard4_Click(object sender, EventArgs e)
        {

        }

        private void TxtMinuteBillard4_Click(object sender, EventArgs e)
        {

        }

        private void txtSecondeBillard4_Click(object sender, EventArgs e)
        {

        }

        private void txtHoursBillard5_Click(object sender, EventArgs e)
        {

        }

        private void TxtMinuteBillard5_Click(object sender, EventArgs e)
        {

        }

        private void btnClearBillard3_Click(object sender, EventArgs e)
        {
            btnPrixBillard3.Text = null;

        }

        private void btnPrixBillard2_Click(object sender, EventArgs e)
        {

        }

        private void timerBillard3_Tick(object sender, EventArgs e)
        {
            txtSecondeBillard3.Text = (SecondsBillard3++).ToString();
            if (SecondsBillard3 >= 60)
            {
                (MinutesBillard3++).ToString();
                SecondsBillard3 = 00;



                if (MinutesBillard3 == 60)
                {
                    (HoursBillard3++).ToString();
                    MinutesBillard3 = 00;



                    if (HoursBillard3 == 02)
                    {

                        timerBillard3.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        txtHoursBillard3.Text = "00";
                        txtSecondeBillard3.Text = "00";
                        TxtMinuteBillard3.Text = "00";

                    }
                }

            }
            txtSecondeBillard3.Text = string.Format("{0:00}", SecondsBillard3);
            TxtMinuteBillard3.Text = string.Format("{0:00}", MinutesBillard3);
            txtHoursBillard3.Text = string.Format("{0:00}", HoursBillard3);
        }

        private void btnStartBillard4_Click(object sender, EventArgs e)
        {
            timerBillard4.Start();
        }

        private void btnClearBillard4_Click(object sender, EventArgs e)
        {
            btnPrixBillard4.Text = null;
        }

        private void timerBillard4_Tick(object sender, EventArgs e)
        {
            txtSecondeBillard4.Text = (SecondsBillard4++).ToString();
            if (SecondsBillard4 >= 60)
            {
                (MinutesBillard4++).ToString();
                SecondsBillard4 = 00;



                if (MinutesBillard4 == 60)
                {
                    (HoursBillard4++).ToString();
                    MinutesBillard4 = 00;



                    if (HoursBillard4 == 02)
                    {

                        timerBillard4.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        txtHoursBillard4.Text = "00";
                        txtSecondeBillard4.Text = "00";
                        TxtMinuteBillard4.Text = "00";

                    }
                }

            }
            txtSecondeBillard4.Text = string.Format("{0:00}", SecondsBillard4);
            TxtMinuteBillard4.Text = string.Format("{0:00}", MinutesBillard4);
            txtHoursBillard4.Text = string.Format("{0:00}", HoursBillard4);
        }

        private void btnStartBillard5_Click(object sender, EventArgs e)
        {
            timerBillard5.Start();
        }

        private void btnClearBillard5_Click(object sender, EventArgs e)
        {
            btnPrixBillard5.Text = null;
        }

        private void timerBillard5_Tick(object sender, EventArgs e)
        {
            txtSecondeBillard5.Text = (SecondsBillard5++).ToString();
            if (SecondsBillard5 >= 60)
            {
                (MinutesBillard5++).ToString();
                SecondsBillard5 = 00;



                if (MinutesBillard5 == 60)
                {
                    (HoursBillard5++).ToString();
                    MinutesBillard5 = 00;



                    if (HoursBillard1 == 02)
                    {

                        timerBillard5.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        txtHoursBillard5.Text = "00";
                        txtSecondeBillard5.Text = "00";
                        TxtMinuteBillard5.Text = "00";

                    }
                }

            }
            txtSecondeBillard5.Text = string.Format("{0:00}", SecondsBillard5);
            TxtMinuteBillard5.Text = string.Format("{0:00}", MinutesBillard5);
            txtHoursBillard5.Text = string.Format("{0:00}", HoursBillard5);
        }

        private void btnStartBillard6_Click(object sender, EventArgs e)
        {
            timerBillard6.Start();
        }

        private void btnRestBillard6_Click(object sender, EventArgs e)
        {
            timerBillard6.Stop();
            SecondsBillard6 = 0; MinutesBillard6 = 0; HoursBillard6= 0;
            btnPrixBillard6.Text = (int.Parse(txtHoursBillard6.Text) * 5 + int.Parse(TxtMinuteBillard6.Text) * 0.08).ToString();
            txtHoursBillard6.Text = "00";
            txtSecondeBillard6.Text = "00";
            TxtMinuteBillard6.Text = "00";
        }

        private void timerBillard6_Tick(object sender, EventArgs e)
        {
            txtSecondeBillard6.Text = (SecondsBillard6++).ToString();
            if (SecondsBillard6 >= 60)
            {
                (MinutesBillard6++).ToString();
                SecondsBillard6 = 00;



                if (MinutesBillard6 == 60)
                {
                    (HoursBillard6++).ToString();
                    MinutesBillard6 = 00;



                    if (HoursBillard6 == 02)
                    {

                        timerBillard6.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        txtHoursBillard6.Text = "00";
                        txtSecondeBillard6.Text = "00";
                        TxtMinuteBillard6.Text = "00";

                    }
                }

            }
            txtSecondeBillard6.Text = string.Format("{0:00}", SecondsBillard6);
            TxtMinuteBillard6.Text = string.Format("{0:00}", MinutesBillard6);
            txtHoursBillard6.Text = string.Format("{0:00}", HoursBillard6);
        }

        private void btnStartBillard7_Click(object sender, EventArgs e)
        {
            timerBillard7.Start();
        }

        private void btnRestBillard7_Click(object sender, EventArgs e)
        {
            timerBillard7.Stop();
            SecondsBillard7 = 0; MinutesBillard7 = 0; HoursBillard7 = 0;
            btnPrixBillard7.Text = (int.Parse(txtHoursBillard7.Text) * 5 + int.Parse(TxtMinuteBillard7.Text) * 0.08).ToString();
            txtHoursBillard7.Text = "00";
            txtSecondeBillard7.Text = "00";
            TxtMinuteBillard7.Text = "00";
        }

        private void btnClearBillard7_Click(object sender, EventArgs e)
        {
            btnPrixBillard7.Text = null;
        }

        private void btnPrixBillard7_Click(object sender, EventArgs e)
        {

        }

        private void timerBillard7_Tick(object sender, EventArgs e)
        {
            txtSecondeBillard7.Text = (SecondsBillard7++).ToString();
            if (SecondsBillard7 >= 60)
            {
                (MinutesBillard7++).ToString();
                SecondsBillard7= 00;



                if (MinutesBillard7 == 60)
                {
                    (HoursBillard7++).ToString();
                    MinutesBillard7 = 00;



                    if (HoursBillard7 == 02)
                    {

                        timerBillard7.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        txtHoursBillard7.Text = "00";
                        txtSecondeBillard7.Text = "00";
                        TxtMinuteBillard7.Text = "00";

                    }
                }

            }
            txtSecondeBillard7.Text = string.Format("{0:00}", SecondsBillard7);
            TxtMinuteBillard7.Text = string.Format("{0:00}", MinutesBillard7);
            txtHoursBillard7.Text = string.Format("{0:00}", HoursBillard7);
        }

        private void btnStartBillard8_Click(object sender, EventArgs e)
        {
            timerBillard8.Start();
        }

        private void btnRestBillard8_Click(object sender, EventArgs e)
        {
            timerBillard8.Stop();
            SecondsBillard8 = 0; MinutesBillard8 = 0; HoursBillard8 = 0;
            btnPrixBillard8.Text = (int.Parse(txtHoursBillard8.Text) * 5 + int.Parse(TxtMinuteBillard8.Text) * 0.08).ToString();
            txtHoursBillard8.Text = "00";
            txtSecondeBillard8.Text = "00";
            TxtMinuteBillard8.Text = "00";
        }

        private void btnClearBillard8_Click(object sender, EventArgs e)
        {
            btnPrixBillard8.Text = null;
        }

        private void timerBillard8_Tick(object sender, EventArgs e)
        {
            txtSecondeBillard8.Text = (SecondsBillard8++).ToString();
            if (SecondsBillard8 >= 60)
            {
                (MinutesBillard8++).ToString();
                SecondsBillard8 = 00;



                if (MinutesBillard8 == 60)
                {
                    (HoursBillard8++).ToString();
                    MinutesBillard8 = 00;



                    if (HoursBillard8 == 02)
                    {

                        timerBillard8.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        txtHoursBillard8.Text = "00";
                        txtSecondeBillard8.Text = "00";
                        TxtMinuteBillard8.Text = "00";

                    }
                }

            }
            txtSecondeBillard8.Text = string.Format("{0:00}", SecondsBillard8);
            TxtMinuteBillard8.Text = string.Format("{0:00}", MinutesBillard8);
            txtHoursBillard8.Text = string.Format("{0:00}", HoursBillard8);
        }

        private void timerBillard1_Tick(object sender, EventArgs e)
        {
            txtSecondeBillard1.Text = (SecondsBillard1++).ToString();
            if (SecondsBillard1 >= 60)
            {
                (MinutesBillard1++).ToString();
                SecondsBillard1 = 00;



                if (MinutesBillard1 == 60)
                {
                    (HoursBillard1++).ToString();
                    MinutesBillard1 = 00;



                    if (HoursBillard1 == 02)
                    {

                        timerBillard1.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        txtHoursBillard1.Text = "00";
                        txtSecondeBillard1.Text = "00";
                        TxtMinuteBillard1.Text = "00";

                    }
                }

            }
            txtSecondeBillard1.Text = string.Format("{0:00}", SecondsBillard1);
            TxtMinuteBillard1.Text = string.Format("{0:00}", MinutesBillard1);
            txtHoursBillard1.Text = string.Format("{0:00}", HoursBillard1);
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnPrixBillard1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditBillard_Click(object sender, EventArgs e)
        {
            frmAddGameAndEmployer FRMAG = new frmAddGameAndEmployer();
            FRMAG.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAbout FRMA22 = new FrmAbout();
            FRMA22.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmAddGame FRMAG = new FrmAddGame();
            FRMAG.Show();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            timerBillard1.Stop();
            SecondsBillard1 = 0; MinutesBillard1 = 0; HoursBillard1 = 0;
            btnPrixBillard1.Text= (int.Parse(txtHoursBillard1.Text) * 5 + int.Parse(TxtMinuteBillard1.Text) * 0.08).ToString();
            txtSecondeBillard1.Text = "00";
            TxtMinuteBillard1.Text = "00";
            txtHoursBillard1.Text = "00";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
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
            timerBillard3.Stop();
            SecondsBillard3 = 0; MinutesBillard3 = 0; HoursBillard3 = 0;
            btnPrixBillard3.Text = (int.Parse(txtHoursBillard3.Text) * 5 + int.Parse(TxtMinuteBillard3.Text) * 0.08).ToString();
            txtHoursBillard3.Text = "00";
            txtSecondeBillard3.Text = "00";
            TxtMinuteBillard3.Text = "00";
        }

        private void btnStartBillard3_Click(object sender, EventArgs e)
        {
            timerBillard3.Start();
        }

        private void btnRestBillard4_Click(object sender, EventArgs e)
        {
            timerBillard4.Stop();
            SecondsBillard4 = 0; MinutesBillard4 = 0; HoursBillard4 = 0;
            btnPrixBillard4.Text = (int.Parse(txtHoursBillard4.Text) * 5 + int.Parse(TxtMinuteBillard4.Text) * 0.08).ToString();
            txtHoursBillard4.Text = "00";
            txtSecondeBillard4.Text = "00";
            TxtMinuteBillard4.Text = "00";
        }

        private void btnRestBillard5_Click(object sender, EventArgs e)
        {
            timerBillard5.Stop();
            SecondsBillard5 = 0; MinutesBillard5 = 0; HoursBillard5 = 0;
            btnPrixBillard5.Text = (int.Parse(txtHoursBillard5.Text) * 5 + int.Parse(TxtMinuteBillard5.Text) * 0.08).ToString();
            txtHoursBillard5.Text = "00";
            txtSecondeBillard5.Text = "00";
            TxtMinuteBillard5.Text = "00";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnPrixBillard6.Text = null;
        }

        private void btnClearBillard1_Click(object sender, EventArgs e)
        {
            btnPrixBillard1.Text = null;
        }

        private void btnStartBillard2_Click(object sender, EventArgs e)
        {
            timerBillard2.Start();
        }

        private void timerBillard_Tick(object sender, EventArgs e)
        {
             
            //txtSecondeBillard1.Text = (SecondsBillard1++).ToString();
            //if (SecondsBillard1 >=60)
            //{
            //    (MinutesBillard1++).ToString();
            //    SecondsBillard1 = 00;
               


            //    if (MinutesBillard1 == 60)
            //    {
            //        (HoursBillard1++).ToString();
            //        MinutesBillard1 = 00;
                   


            //        if (HoursBillard1 == 02)
            //        {

            //            timerBillard.Stop();
            //            MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
            //            txtHoursBillard1.Text = "00";
            //            txtSecondeBillard1.Text = "00";
            //            TxtMinuteBillard1.Text = "00";

            //        }
            //    }

            //}
            //txtSecondeBillard1.Text = string.Format("{0:00}", SecondsBillard1);
            //TxtMinuteBillard1.Text = string.Format("{0:00}", MinutesBillard1);
            //txtHoursBillard1.Text = string.Format("{0:00}", MinutesBillard1);

        }

        private void button33_Click(object sender, EventArgs e)
        {
            
            timerBillard2.Stop();
            SecondsBillard2 = 0; MinutesBillard2 = 0; HoursBillard2 = 0;
            btnPrixBillard2.Text = (int.Parse(txtHoursBillard2.Text) * 5 + int.Parse(TxtMinuteBillard2.Text) * 0.08).ToString();
            txtSecondeBillard2.Text = "00";
            TxtMinuteBillard2.Text = "00";
            txtHoursBillard2.Text = "00";
        }   
    }
}
