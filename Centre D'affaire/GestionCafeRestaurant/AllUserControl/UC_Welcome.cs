using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionCafeRestaurant.AllUserControl
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(num == 0)
            {
                labelBanner.Location = new Point(94, 367);
                labelBanner.ForeColor = Color.Blue;
                num++;
            }
            else if(num == 1)
            {
                labelBanner.Location = new Point(166, 367);
                labelBanner.ForeColor = Color.DodgerBlue;
                num++;
            }
            else if(num == 2)
            {
                labelBanner.Location = new Point(230, 367);
                labelBanner.ForeColor = Color.DarkSlateBlue;
                num ++;
            }
            else if (num == 3)
            {
                labelBanner.Location = new Point(30, 367);
                labelBanner.ForeColor = Color.DarkBlue;
                num ++;
            }
            else if (num == 4)
            {
                labelBanner.Location = new Point(60, 367);
                labelBanner.ForeColor = Color.MidnightBlue;
                num = 0;
            }
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void labelBanner_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
