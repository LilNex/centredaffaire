using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Centre_D_affaire.GestionParking
{
    public partial class Dashboard : Form
    {
        List<info> list1 = new List<info>();
        List<info> list2 = new List<info>();
        List<info> list3 = new List<info>();
        List<info> list4 = new List<info>();


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

        public void vidhome()
        {
            bunifuDataGridView1.Rows.Clear();
        }

        public void majspot()
        {
            bunifuDataGridView3.Rows.Clear();
            foreach (info i in list2)
            {
                bunifuDataGridView3.Rows.Add(i.SpotNumber.ToString(), i.SpotName);
            }
        }

        public void vidcar()
        {
            CarNamee.Text = "";
            bunifuTextBox13.Text = "";
            bunifuTextBox15.Text = "";
        }
        public void majcar()
        {
            bunifuDataGridView2.Rows.Clear();
            foreach (info i in list1)
            {
                bunifuDataGridView2.Rows.Add(i.Carname.ToString(), i.Cartype,i.Time.ToString()+" Hours");

            }
        }

        public void vidspot()
        {
            bunifuTextBox18.Text = "";
            bunifuTextBox17.Text = "";
        }

        public void majpay()
        {
            bunifuDataGridView4.Rows.Clear();
            foreach (info i in list3)
            {
                bunifuDataGridView4.Rows.Add(i.Methode,i.HolderName,i.ExperitionDate1,i.CardNumber.ToString(),i.CvvCode,ToString());

            }
        }

        public void vidpay()
        {
            HolderNamee.Text = "";
            ExpirationDate.Text = "";
            CvvCode.Text = "";
            CreditCardNumber.Text = "";
        }

        public void majHome()
        {
            try
            {
                string time = DateTime.Now.ToString("h:mm tt");
                string day = DateTime.Now.ToString("MM/dd");

                bunifuDataGridView1.Rows.Clear();
                for (int a = 0; a < list1.Count; a++)
                {
                    for (int l = 0; l < list1.Count; l++)
                    {
                        for (int i = 0; i < list1.Count; i++)
                        {
                            int cost = list1[i].Time * 5;
                            string pay = "$";
                            //info f5 = new info(day.ToString(), time.ToString(), int.Parse(list1[l].Time.ToString()), int.Parse(list2[l].SpotNumber.ToString()), list1[i].Carname, cost + pay, list3[a].Methode);
                            //list4.Add(f5);
                            bunifuDataGridView1.Rows.Add(list1[i].Carname, day.ToString(), time.ToString(), list1[l].Time.ToString()+ " Hours", list2[l].SpotNumber.ToString(), cost + pay, list3[a].Methode);
                            l++;
                            a++;
                        }
                    }
                }
            }
            catch
            {

            }

        }


        private void frmGParking_Load(object sender, EventArgs e)
        {
            LoginForm info = new LoginForm();
            label1.Text = GetUserFromMyClass();
            label2.Text = GetUserFromMyClass();
            label3.Text = GetUserFromMyClass();

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
            DialogResult d = MessageBox.Show("Are you sure you want to Exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
            DialogResult d = MessageBox.Show("Are you sure you want to Logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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
            if(list3.Count == 0 && list1.Count > 0)
            {
                paymentTab.Show();
                AccountTab.Hide();
                HomeTab.Hide();
                carTab.Hide();
                spotTab.Hide();
                MessageBox.Show("Payment Method should be added first!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }
            else
            {
                if (list3.Count != list1.Count || list3.Count != list2.Count)
                {
                    MessageBox.Show("Payment Method is messing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                }
            }
            if (list2.Count != list1.Count)
            {
                MessageBox.Show("Car or spot is messing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (list2.Count > list1.Count)
                {
                    carTab.Show();
                    paymentTab.Hide();
                    AccountTab.Hide();
                    HomeTab.Hide();
                    spotTab.Hide();
                }
                if (list2.Count < list1.Count)
                {
                    spotTab.Show();
                    paymentTab.Hide();
                    AccountTab.Hide();
                    HomeTab.Hide();
                    carTab.Hide();
                }
            }
            if (list3.Count == list1.Count && list3.Count == list2.Count)
            {
                majHome();
                HomeTab.Show();
            }

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            HomeTab.Hide();
            spotTab.Hide();
            paymentTab.Hide();
            carTab.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            spotTab.Show();
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
                    throw new Exception("Input Empty");
                }
                else
                {
                    info f = new info(methode, HolderNamee.Text, ExpirationDate.Text, double.Parse(CreditCardNumber.Text), int.Parse(CvvCode.Text));
                    list3.Add(f);
                    maj();
                    vidpay();

                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            try
            {
                int i = bunifuDataGridView4.SelectedRows[0].Index;
                list3.RemoveAt(i);
                maj();
            }
            catch(Exception)
            {
                MessageBox.Show("Select a Row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            if (bunifuTextBox18.Text == "" || bunifuTextBox17.Text == "" )
            {
                MessageBox.Show("Somthing is messing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    info f1 = new info(int.Parse(bunifuTextBox18.Text), bunifuTextBox17.Text.ToString());
                    list2.Add(f1);
                    majspot();
                    vidspot();
                }
                catch (Exception b)
                {
                    MessageBox.Show(b.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            try
            {
                int i = bunifuDataGridView3.SelectedRows[0].Index;
                list2.RemoveAt(i);
                majspot();
            }
            catch (Exception)
            {
                MessageBox.Show("Select a Row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (CarNamee.Text == "" || bunifuTextBox13.Text == "" || bunifuTextBox15.Text == "")
            {
                MessageBox.Show("Something is messing ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    info f2 = new info(CarNamee.Text, bunifuTextBox13.Text,int.Parse(bunifuTextBox15.Text));
                    list1.Add(f2);
                    majcar();
                    vidcar();
                }
                catch (Exception b)
                {
                    MessageBox.Show(b.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Select a Row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(c.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            try
            {
                int i = bunifuDataGridView3.SelectedRows[0].Index;
                list2[i].SpotName = bunifuTextBox17.Text;
                list2[i].SpotNumber = int.Parse(bunifuTextBox18.Text);


                majspot();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            // code ba9i makamalch :) 

            //LoginForm login = new LoginForm();
            //foreach (info i in login.list )
            //{
            //    if(info.User == i.Username)
            //    {
            //        int index = login.list.FindIndex(a => info.User == a.Username);
            //        login.list[index].Username = Usernametxt.Text;
            //        login.list[index].Password = passwordtxt.Text;
            //        login.list[index].Email = Emailtxt.Text;
            //        login.list[index].Telephone = int.Parse(Telephonetxt.Text);
            //        MessageBox.Show("Good", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    }
            //}
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"C:\data.xml");
                XmlNodeList aNodes = doc.SelectNodes("/info/Username2[3]");
                foreach (XmlNode aNode in aNodes)
                {
                    XmlAttribute idAttribute = aNode.Attributes["Username2[3]"];
                    if (idAttribute != null)
                    {
                        string currentValue = idAttribute.Value;
                        if (string.IsNullOrEmpty(currentValue))
                        {
                            idAttribute.Value = "test";
                        }
                    }

                }
                doc.Save(@"C:\data.xml");
                MessageBox.Show("value changed succsusfly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            try
            {
                int i = bunifuDataGridView4.SelectedRows[0].Index;
                list3[i].HolderName = HolderNamee.Text;
                list3[i].CardNumber = double.Parse(CreditCardNumber.Text);
                list3[i].ExperitionDate1 = ExpirationDate.Text;
                list3[i].CvvCode = int.Parse(CvvCode.Text);
                if (Radio1Visa.Checked == true)
                {
                    list3[i].Methode = "Visa";
                }
                if (Radio2Mastercard.Checked == true)
                {
                    list3[i].Methode = "Master Card";
                }
                if (Radio3Paypal.Checked == true)
                {
                    list3[i].Methode = "Paypal";
                }

                majpay();
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton211_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton212_Click(object sender, EventArgs e)
        {
            bool v = true;
            try
            {
                if (bunifuTextBox1.Text == "")
                {
                    MessageBox.Show("Search box empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dgv f = new dgv();
                    //this.Hide();
                    f.Show();
                    f.bunifuDataGridView1.Rows.Clear();
                    for (int a = 0; a < list1.Count; a++)
                    {
                        for (int l = 0; l < list1.Count; l++)
                        {
                            string time = DateTime.Now.ToString("h:mm:tt");
                            string day = DateTime.Now.ToString("MM/dd");
                            for (int i = 0; i < list1.Count; i++)
                            {
                                if (list1[i].Carname == bunifuTextBox1.Text)
                                {
                                    bunifuTextBox1.Text = "";
                                    int cost = list1[i].Time * 5;
                                    string pay = "$";
                                    f.bunifuDataGridView1.Rows.Add(day.ToString(), time.ToString(), list1[l].Time.ToString() + " Hours", list2[l].SpotNumber.ToString(), list1[i].Carname, cost + pay, list3[a].Methode);
                                    //bunifuDataGridView1.Rows.RemoveAt(-1);
                                    v = false;
                                    l++;
                                    a++;
                                }
                            }

                        }
                    }
                    if (v == true)
                    {
                        MessageBox.Show("Name does not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
            catch (Exception exc)
            {
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AccountTab.Show();
            HomeTab.Hide();
            carTab.Hide();
            spotTab.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            AccountTab.Show();
            HomeTab.Hide();
            carTab.Hide();
            spotTab.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AccountTab.Show();
            HomeTab.Hide();
            carTab.Hide();
            spotTab.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AccountTab.Show();
            HomeTab.Hide();
            carTab.Hide();
            spotTab.Hide();
        }

        private void bunifuThinButton211_Click_1(object sender, EventArgs e)
        {
            bool v = true;

            try
            {
                if (bunifuTextBox2.Text == "")
                {
                    MessageBox.Show("Search box empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dgvCar f = new dgvCar();
                    //this.Hide();
                    f.Show();
                    f.bunifuDataGridView2.Rows.Clear();                    
                    for (int i = 0; i < list1.Count; i++)
                    {
                        if (list1[i].Carname == bunifuTextBox2.Text)
                        {
                            bunifuTextBox2.Text = "";
                            f.bunifuDataGridView2.Rows.Add(list1[i].Carname, list1[i].Cartype,list1[i].Time.ToString()+" Hours");
                            v = false;
                        }
                    }
                    if (v == true)
                    {
                        MessageBox.Show("Name does not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
            catch (Exception exc)
            {

            }
        }

        private void bunifuThinButton213_Click(object sender, EventArgs e)
        {
            bool v = true;

            try
            {
                if (bunifuTextBox3.Text == "")
                {
                    MessageBox.Show("Search box empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dgvSpot f = new dgvSpot();
                    //this.Hide();
                    f.Show();
                    f.bunifuDataGridView3.Rows.Clear();
                    for (int i = 0; i < list2.Count; i++)
                    {
                        if (list2[i].SpotName == bunifuTextBox3.Text)
                        {
                            bunifuTextBox3.Text = "";
                            f.bunifuDataGridView3.Rows.Add(list2[i].SpotNumber.ToString(), list2[i].SpotName);
                            v = false;
                        }
                    }
                    if (v == true)
                    {
                        MessageBox.Show("Name does not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
            catch (Exception exc)
            {

            }
        }
    }
}
