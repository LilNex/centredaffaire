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
    public partial class FrmPS4 : Form
    {
        int SecondePs41; int MinutePs41; int HourPs41;
        int SecondePs42; int MinutePs42; int HourPs42;
        int SecondePs43; int MinutePs43; int HourPs43;
        int SecondePs44; int MinutePs44; int HourPs44;

        public FrmPS4()
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerPs41.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            timerPs41.Stop();
            SecondePs41 = 0; MinutePs41 = 0; HourPs41 = 0;
            btnPrixPs41.Text = (int.Parse(btnHourePs41.Text) * 5 + int.Parse(btnMinutePs41.Text) * 0.08).ToString();
            btnSecondePs41.Text = "00";
            btnMinutePs41.Text = "00";
            btnHourePs41.Text = "00";
        }

        private void btnStartPs42_Click(object sender, EventArgs e)
        {
            timerPs42.Start();
        }

        private void btnStartPs43_Click(object sender, EventArgs e)
        {
            timerPs43.Start();
        }

        private void btnStartPs44_Click(object sender, EventArgs e)
        {
            timerPs44.Start();
        }

        private void btnClearPs41_Click(object sender, EventArgs e)
        {
            btnPrixPs41.Text = null;
        }

        private void btnClearPs43_Click(object sender, EventArgs e)
        {
            btnPrixPs43.Text = null;

        }

        private void btnClearPs42_Click(object sender, EventArgs e)
        {
            btnPrixPs42.Text = null;

        }

        private void btnClearPs44_Click(object sender, EventArgs e)
        {
            btnPrixPs44.Text = null;

        }

        private void FrmPS4_Load(object sender, EventArgs e)
        {
            SecondePs41 = 0; MinutePs41 = 0; HourPs41 = 0;
            SecondePs42 = 0; MinutePs42 = 0; HourPs42 = 0;
            SecondePs43 = 0; MinutePs43 = 0; HourPs43 = 0;
            SecondePs44 = 0; MinutePs44 = 0; HourPs44 = 0;

            clsPs4 PS41 = new clsPs4("PS4", 1);
            ClsListeSDJ.ListPs4.Add(PS41);

            clsPs4 PS42 = new clsPs4("PS4", 2);
            ClsListeSDJ.ListPs4.Add(PS42);

            clsPs4 PS43 = new clsPs4("PS4", 3);
            ClsListeSDJ.ListPs4.Add(PS43);

            //clsPs4 PS41 = new clsPs4("PS4", 1);
            //ClsListeSDJ.ListPs4.Add(PS41);

            btnSecondePs41.Text = "00";
            btnMinutePs41.Text = "00";
            btnHourePs41.Text = "00";

            btnSecondePs42.Text = "00";
            btnMinutePs42.Text = "00";
            btnHourePs42.Text = "00";

            btnSecondePs43.Text = "00";
            btnMinutePs43.Text = "00";
            btnHourePs43.Text = "00";

            btnSecondePs44.Text = "00";
            btnMinutePs44.Text = "00";
            btnHourePs44.Text = "00";

        }

        private void btnRestPs42_Click(object sender, EventArgs e)
        {
            timerPs42.Stop();
            SecondePs42 = 0; MinutePs41 = 0; HourPs42 = 0;
            btnPrixPs42.Text = (int.Parse(btnHourePs42.Text) * 5 + int.Parse(btnMinutePs42.Text) * 0.08).ToString();
            btnSecondePs42.Text = "00";
            btnMinutePs42.Text = "00";
            btnHourePs42.Text = "00";
        }

        private void btnRestPs43_Click(object sender, EventArgs e)
        {
            timerPs43.Stop();
            SecondePs43 = 0; MinutePs43 = 0; HourPs43 = 0;
            btnPrixPs43.Text = (int.Parse(btnHourePs43.Text) * 5 + int.Parse(btnMinutePs43.Text) * 0.08).ToString();
            btnSecondePs43.Text = "00";
            btnMinutePs43.Text = "00";
            btnHourePs43.Text = "00";
        }

        private void btnRestPs44_Click(object sender, EventArgs e)
        {
            timerPs44.Stop();
            SecondePs44 = 0; MinutePs44 = 0; HourPs44 = 0;
            btnPrixPs44.Text = (int.Parse(btnHourePs44.Text) * 5 + int.Parse(btnMinutePs44.Text) * 0.08).ToString();
            btnSecondePs44.Text = "00";
            btnMinutePs44.Text = "00";
            btnHourePs44.Text = "00";
        }

        private void timerPs41_Tick(object sender, EventArgs e)
        {
            btnSecondePs41.Text = (SecondePs41++).ToString();
            if (SecondePs41 >= 60)
            {
                (MinutePs41++).ToString();
                SecondePs41 = 00;



                if (MinutePs41 == 60)
                {
                    (HourPs41++).ToString();
                    MinutePs41 = 00;



                    if (HourPs41 == 02)
                    {

                        timerPs41.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        btnSecondePs41.Text = "00";
                        btnMinutePs41.Text = "00";
                        btnHourePs41.Text = "00";

                    }
                }

            }
            btnSecondePs41.Text = string.Format("{0:00}", SecondePs41);
            btnMinutePs41.Text = string.Format("{0:00}", MinutePs41);
            btnHourePs41.Text = string.Format("{0:00}", HourPs41);
        }

        private void timerPs42_Tick(object sender, EventArgs e)
        {
            btnSecondePs42.Text = (SecondePs42++).ToString();
            if (SecondePs42 >= 60)
            {
                (MinutePs42++).ToString();
                SecondePs42 = 00;



                if (MinutePs42 == 60)
                {
                    (HourPs42++).ToString();
                    MinutePs42 = 00;



                    if (HourPs42 == 02)
                    {

                        timerPs42.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        btnSecondePs42.Text = "00";
                        btnMinutePs42.Text = "00";
                        btnHourePs42.Text = "00";

                    }
                }

            }
            btnSecondePs42.Text = string.Format("{0:00}", SecondePs42);
            btnMinutePs42.Text = string.Format("{0:00}", MinutePs42);
            btnHourePs42.Text = string.Format("{0:00}", HourPs42);
        }

        private void timerPs43_Tick(object sender, EventArgs e)
        {
            btnSecondePs43.Text = (SecondePs43++).ToString();
            if (SecondePs43 >= 60)
            {
                (MinutePs41++).ToString();
                SecondePs43 = 00;



                if (MinutePs43 == 60)
                {
                    (HourPs43++).ToString();
                    MinutePs43 = 00;



                    if (HourPs43 == 02)
                    {

                        timerPs43.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        btnSecondePs43.Text = "00";
                        btnMinutePs43.Text = "00";
                        btnHourePs43.Text = "00";

                    }
                }

            }
            btnSecondePs43.Text = string.Format("{0:00}", SecondePs43);
            btnMinutePs43.Text = string.Format("{0:00}", MinutePs43);
            btnHourePs43.Text = string.Format("{0:00}", HourPs43);
        }

        private void timerPs44_Tick(object sender, EventArgs e)
        {
            btnSecondePs44.Text = (SecondePs44++).ToString();
            if (SecondePs44 >= 60)
            {
                (MinutePs44++).ToString();
                SecondePs44 = 00;



                if (MinutePs44 == 60)
                {
                    (HourPs44++).ToString();
                    MinutePs44 = 00;



                    if (HourPs44 == 02)
                    {

                        timerPs44.Stop();
                        MessageBox.Show("vous avez depasser 2H de jeux", "Time out");
                        btnSecondePs44.Text = "00";
                        btnMinutePs44.Text = "00";
                        btnHourePs44.Text = "00";

                    }
                }

            }
            btnSecondePs44.Text = string.Format("{0:00}", SecondePs44);
            btnMinutePs44.Text = string.Format("{0:00}", MinutePs44);
            btnHourePs44.Text = string.Format("{0:00}", HourPs44);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAbout FRMA23 = new FrmAbout();
            FRMA23.Show();
        }

        private void btnEditPs4_Click(object sender, EventArgs e)
        {
            frmAddGameAndEmployer FRMAA34 = new frmAddGameAndEmployer();
            FRMAA34.Show();
        }
    }
}
