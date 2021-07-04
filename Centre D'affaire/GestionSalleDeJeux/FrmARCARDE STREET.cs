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
    public partial class FrmArcardeStreet : Form
    {
        int SecondsArcardS1; int MinuteArcardS1; int HoursArcardS1;
        int SecondsArcardS2; int MinuteArcardS2; int HoursArcardS2;
        int SecondsArcardS3; int MinuteArcardS3; int HoursArcardS3;
        int SecondsArcardS4; int MinuteArcardS4; int HoursArcardS4;



        public FrmArcardeStreet()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConnection FC = new FrmConnection();
            FC.Show();
        }

        private void FrmArcardeStreet_Load(object sender, EventArgs e)
        {
            
            //bool t = false;
            //foreach (FrmAbout frm in this.mdichildren()
            //{
            //    if (frm.name == "form2")
            //        t = true;
            //}
            //if (t == false)
            //{
            //    form2 f = new form2();
            //    f.name = "form2";
            //    f.mdiparent = this;
            //    f.show();

            //}


            SecondsArcardS1 = 0; MinuteArcardS1 = 0; HoursArcardS1 = 0;
            SecondsArcardS2 = 0; MinuteArcardS2 = 0; HoursArcardS2 = 0;
            SecondsArcardS3 = 0; MinuteArcardS3 = 0; HoursArcardS3 = 0;
            SecondsArcardS4 = 0; MinuteArcardS4 = 0; HoursArcardS4 = 0;




            //clsArcArdStreet AS4 = new clsArcArdStreet();
            //ClsListeSDJ.listArcardS.Add(AS4);

            btnHoursArcardS1.Text = "00";
            btnMinuteArcardS1.Text = "00";
            btnSecondeArcardS1.Text = "00";

            btnsSecondeArcardS2.Text = "00";
            btnMinuteArcardS2.Text = "00";
            btnsHoursArcardS2.Text = "00";

            btnSecondeArcardS3.Text = "00";
            btnMinuteArcardS3.Text = "00";
            btnsHoursArcardS3.Text = "00";

            btnSecondeArcardS4.Text = "00";
            btnMinuteArcardS4.Text = "00";
            btnHoursArcardS4.Text = "00";
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void btnClearBillard1_Click(object sender, EventArgs e)
        {
            btnPrixArcardS1.Text = null;
        }

        private void btnStartArcardS1_Click(object sender, EventArgs e)
        {
            timerStartArcardS1.Start();
        }

        private void btnRestArcardS1_Click(object sender, EventArgs e)
        {
            timerStartArcardS1.Stop();
            SecondsArcardS1 = 0; MinuteArcardS1 = 0; HoursArcardS1 = 0;
            btnPrixArcardS1.Text = (int.Parse(btnHoursArcardS1.Text) * 5 + int.Parse(btnMinuteArcardS1.Text) * 0.08).ToString();
            btnHoursArcardS1.Text = "00";
            btnMinuteArcardS1.Text = "00";
            btnSecondeArcardS1.Text = "00";

        }

        private void timerStartArcardS1_Tick(object sender, EventArgs e)
        {
            btnHoursArcardS1.Text = (SecondsArcardS1++).ToString();
            if (SecondsArcardS1 >= 60)
            {
                (MinuteArcardS1++).ToString();
                SecondsArcardS1 = 00;



                if (MinuteArcardS1 == 60)
                {
                    (HoursArcardS1++).ToString();
                    MinuteArcardS1 = 00;



                    if (HoursArcardS1 == 02)
                    {

                        timerStartArcardS1.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        btnHoursArcardS1.Text = "00";
                        btnMinuteArcardS1.Text = "00";
                        btnSecondeArcardS1.Text = "00";

                    }
                }

            }
            btnSecondeArcardS1.Text = string.Format("{0:00}", SecondsArcardS1);
            btnMinuteArcardS1.Text = string.Format("{0:00}", MinuteArcardS1);
            btnHoursArcardS1.Text = string.Format("{0:00}", HoursArcardS1);
        }

        private void btnStartArcardS2_Click(object sender, EventArgs e)
        {
            timerStartArcardS2.Start();
        }

        private void btnRestArcardS2_Click(object sender, EventArgs e)
        {
            timerStartArcardS2.Stop();
            SecondsArcardS2 = 0; MinuteArcardS2 = 0; HoursArcardS2 = 0;
            btnPrixArcardS2.Text = (int.Parse(btnsHoursArcardS2.Text) * 5 + int.Parse(btnMinuteArcardS2.Text) * 0.08).ToString();
            btnsSecondeArcardS2.Text = "00";
            btnMinuteArcardS2.Text = "00";
            btnsHoursArcardS2.Text = "00";


        }

        private void btnClearArcardS2_Click(object sender, EventArgs e)
        {
            btnPrixArcardS2.Text = null;
        }

        private void timerStartArcardS2_Tick(object sender, EventArgs e)
        {
            btnsSecondeArcardS2.Text = (SecondsArcardS2++).ToString();
            if (SecondsArcardS2 >= 60)
            {
                (MinuteArcardS2++).ToString();
                SecondsArcardS2 = 00;



                if (MinuteArcardS2 == 60)
                {
                    (HoursArcardS2++).ToString();
                    MinuteArcardS2 = 00;



                    if (HoursArcardS2 == 02)
                    {

                        timerStartArcardS2.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        btnsSecondeArcardS2.Text = "00";
                        btnMinuteArcardS2.Text = "00";
                        btnsHoursArcardS2.Text = "00";

                    }
                }
            }
            btnsHoursArcardS2.Text = string.Format("{0:00}", HoursArcardS2);
            btnMinuteArcardS2.Text = string.Format("{0:00}", MinuteArcardS2);
            btnsSecondeArcardS2.Text = string.Format("{0:00}", SecondsArcardS2);
        }

        private void timerStartArcardS3_Tick(object sender, EventArgs e)
        {
            btnSecondeArcardS3.Text = (SecondsArcardS3++).ToString();
            if (SecondsArcardS3 >= 60)
            {
                (MinuteArcardS3++).ToString();
                SecondsArcardS3 = 00;



                if (MinuteArcardS3 == 60)
                {
                    (HoursArcardS3++).ToString();
                    MinuteArcardS3 = 00;



                    if (HoursArcardS3 == 02)
                    {

                        timerStartArcardS3.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        btnSecondeArcardS3.Text = "00";
                        btnMinuteArcardS3.Text = "00";
                        btnsHoursArcardS3.Text = "00";

                    }
                }
            }
            btnsHoursArcardS3.Text = string.Format("{0:00}", HoursArcardS3);
            btnMinuteArcardS3.Text = string.Format("{0:00}", MinuteArcardS3);
            btnSecondeArcardS3.Text = string.Format("{0:00}", SecondsArcardS3);
        }

        private void btnStartArcardS3_Click(object sender, EventArgs e)
        {
            timerStartArcardS3.Start();
        }

        private void btnRestArcardS3_Click(object sender, EventArgs e)
        {
            timerStartArcardS3.Stop();
            SecondsArcardS3 = 0; MinuteArcardS3 = 0; HoursArcardS3 = 0;
            btnPrixArcardS3.Text = (int.Parse(btnsHoursArcardS3.Text) * 5 + int.Parse(btnMinuteArcardS2.Text) * 0.08).ToString();
            btnSecondeArcardS3.Text = "00";
            btnMinuteArcardS3.Text = "00";
            btnsHoursArcardS3.Text = "00";
        }

        private void btnRestArcardS4_Click(object sender, EventArgs e)
        {
            timerStartArcardS4.Stop();
            SecondsArcardS4 = 0; MinuteArcardS4 = 0; HoursArcardS4 = 0;
            btnPrixArcardS4.Text = (int.Parse(btnHoursArcardS4.Text) * 5 + int.Parse(btnMinuteArcardS4.Text) * 0.08).ToString();
            btnHoursArcardS4.Text = "00";
            btnMinuteArcardS4.Text = "00";
            btnSecondeArcardS4.Text = "00";
        }

        private void timerStartArcardS4_Tick(object sender, EventArgs e)
        {
            btnHoursArcardS4.Text = (SecondsArcardS4++).ToString();
            if (SecondsArcardS4 >= 60)
            {
                (MinuteArcardS4++).ToString();
                SecondsArcardS4 = 00;



                if (MinuteArcardS4 == 60)
                {
                    (HoursArcardS4++).ToString();
                    MinuteArcardS4 = 00;



                    if (HoursArcardS4 == 02)
                    {

                        timerStartArcardS4.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        btnHoursArcardS4.Text = "00";
                        btnMinuteArcardS4.Text = "00";
                        btnSecondeArcardS4.Text = "00";

                    }
                }
            }
            btnHoursArcardS4.Text = string.Format("{0:00}", HoursArcardS4);
            btnMinuteArcardS4.Text = string.Format("{0:00}", MinuteArcardS4);
            btnSecondeArcardS4.Text = string.Format("{0:00}", SecondsArcardS4);
        }

        private void btnStartArcardS4_Click(object sender, EventArgs e)
        {
            timerStartArcardS4.Start();
        }

        private void btnClearArcardS3_Click(object sender, EventArgs e)
        {
            btnPrixArcardS4.Text = null;
        }

        private void btnClearArcardS4_Click(object sender, EventArgs e)
        {
            btnPrixArcardS3.Text = null;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            FrmMENU1 FRMM = new FrmMENU1();
            FRMM.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            FrmAbout FRMA = new FrmAbout();
            FRMA.Show();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            frmAddGameAndEmployer FRMAGAE = new frmAddGameAndEmployer();
            FRMAGAE.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAbout frmA = new FrmAbout();
            frmA.Show();
        }
    }
    
}
