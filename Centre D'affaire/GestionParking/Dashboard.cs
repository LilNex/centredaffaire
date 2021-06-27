using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionParking
{
    public partial class Dashboard : Form
    {
        List<info> list1 = new List<info>();
        List<info> list2 = new List<info>();
        List<info> list3 = new List<info>();




        public Dashboard()
        {
            InitializeComponent();
        }

        public void maj()
        {
            bunifuDataGridView4.Rows.Clear();
            foreach (info i in list3)
            {
                bunifuDataGridView4.Rows.Add(i.Methode, i.HolderName, i.ExperitionDate1, i.CardNumber.ToString(), i.CvvCode.ToString());

            }
        }

        public void majspot()
        {
            bunifuDataGridView3.Rows.Clear();
            foreach (info i in list2)
            {
                bunifuDataGridView3.Rows.Add(i.SpotNumber.ToString(), i.SpotName);
            }
        }

        public void majcar()
        {
            bunifuDataGridView2.Rows.Clear();
            foreach (info i in list1)
            {
                bunifuDataGridView2.Rows.Add(i.Carname.ToString(), i.Cartype,i.Time.ToString());

            }
        }

        public void majHome()
        {
            //try
            //{
            //    foreach(info l in list2)
            //    {
            //        bunifuDataGridView1.Rows.Clear();
            //        foreach (info i in list1)
            //        {
            //            bunifuDataGridView1.Rows.Add(i.SpotNumber.ToString());
            //            break;
            //        }
            //        foreach (info i in list2)
            //        {
            //            int cost = i.Time * 5;
            //            string pay = "$";
            //            bunifuDataGridView1.Rows.Add(i.Time.ToString(), i.Carname, cost.ToString());
            //            break;
            //        }
            //    }
            //}
            //catch
            //{

            //}

        }


        private void frmGParking_Load(object sender, EventArgs e)
        {
            LoginForm info = new LoginForm();
            label1.Text = GetUserFromMyClass();
        }
        public string GetUserFromMyClass()
        {
            return info.User;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to Exit?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (d == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void bunifuButton6_Click_1(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to Logout?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (d == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                this.Hide();
                login.Show();
            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //info f3 = new info(int.Parse(bunifuTextBox15.Text), int.Parse(bunifuTextBox18.Text),CarNamee.Text);

            //majHome();
            HomeTab.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            HomeTab.Hide();
            carTab.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            HomeTab.Hide();
            carTab.Hide();
            spotTab.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            HomeTab.Hide();
            carTab.Hide();
            spotTab.Hide();
            AccountTab.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            AccountTab.Show();
            HomeTab.Hide();
            carTab.Hide();
            spotTab.Hide();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            AccountTab.Show();
            HomeTab.Hide();
            carTab.Hide();
            spotTab.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            paymentTab.Show();
            AccountTab.Hide();
            HomeTab.Hide();
            carTab.Hide();
            spotTab.Hide();
        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {
                    }

        private void paymentTab_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void settingsTab_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatavizAdvanced1_Load(object sender, EventArgs e)
        {

        }

        private void carTab_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            string methode = "";
            try
            {
                if (Radio1Visa.Checked)
                {
                    methode = "Visa";
                }
                if (Radio2Mastercard.Checked)
                {
                    methode = "Master Card";
                }
                if (Radio3Paypal.Checked)
                {
                    methode = "Paypal";
                }
                if (HolderNamee.Text == "" || ExpirationDate.Text == "" || CreditCardNumber.Text == "" || CvvCode.Text == "")
                {
                    throw new Exception("Input blank");
                }
                else
                {
                    info f = new info(methode, HolderNamee.Text, ExpirationDate.Text, int.Parse(CreditCardNumber.Text), int.Parse(CvvCode.Text));
                    list3.Add(f);
                    maj();

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            try
            {
                int i = bunifuDataGridView4.SelectedRows[0].Index;
                list1.RemoveAt(i);
                maj();
            }
            catch(Exception)
            {
                MessageBox.Show("Select a Row", "attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            if (SpotNamee.Text == "" || SpotNumberr.Text == "" )
            {
                throw new Exception("Input blank");
            }
            else
            {
                try
                {
                    info f1 = new info(int.Parse(bunifuTextBox18.Text), bunifuTextBox17.Text.ToString());
                    list2.Add(f1);
                    majspot();
                }
                catch (Exception b)
                {
                    MessageBox.Show(b.Message, "attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            try
            {
                int i = bunifuDataGridView3.SelectedRows[0].Index;
                list1.RemoveAt(i);
                majspot();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a Row", "attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (CarNamee.Text == "" || CarTypee.Text == "" || bunifuTextBox15.Text == "")
            {
                throw new Exception("Input blank");
            }
            else
            {
                try
                {
                    info f2 = new info(CarNamee.Text, bunifuTextBox13.Text,int.Parse(bunifuTextBox15.Text));
                    list1.Add(f2);
                    majcar();
                }
                catch (Exception b)
                {
                    MessageBox.Show(b.Message, "attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            try
            {
                int i = bunifuDataGridView2.SelectedRows[0].Index;
                list1.RemoveAt(i);
                majcar();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a Row", "attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                int i = bunifuDataGridView2.SelectedRows[0].Index;
                list1[i].Carname = CarNamee.Text;
                list1[i].Cartype = bunifuTextBox13.Text;
                list1[i].Time = int.Parse(bunifuTextBox15.Text);


                majcar();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            try
            {
                int i = bunifuDataGridView3.SelectedRows[0].Index;
                list1[i].SpotName = bunifuTextBox17.Text;
                list1[i].SpotNumber = int.Parse(bunifuTextBox18.Text);


                majspot();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            // code ba9i makamalch :) 

            LoginForm login = new LoginForm();
            foreach (info i in login.list )
            {
                if(info.User == i.Username)
                {
                    int index = login.list.FindIndex(a => info.User == a.Username);
                    login.list[index].Username = Usernametxt.Text;
                    login.list[index].Password = passwordtxt.Text;
                    login.list[index].Email = Emailtxt.Text;
                    login.list[index].Telephone = int.Parse(Telephonetxt.Text);
                    MessageBox.Show("Good", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
    }
}
