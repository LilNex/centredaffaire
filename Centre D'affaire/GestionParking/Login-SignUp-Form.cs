using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace Centre_D_affaire.GestionParking
{

    public partial class LoginForm : Form
    {
        public List<info> list = new List<info>();
        public bool x = false;
        public bool y = false;
        public bool z = false;
        //XmlSerializer xml;


        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,     // x-coordinate of upper-left corner
        //    int nTopRect,      // y-coordinate of upper-left corner
        //    int nRightRect,    // x-coordinate of lower-right corner
        //    int nBottomRect,   // y-coordinate of lower-right corner
        //    int nWidthEllipse, // height of ellipse
        //    int nHeightEllipse // width of ellipse
        //);
        public LoginForm()
        {
            InitializeComponent();
            //xml = new XmlSerializer(typeof(List<info>));

            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {
            panelSIGNUP.Hide();
            this.Height = this.Height - 17;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
        public void Empty()
        {
            UserName.Text = "";
            Password.Text = "";
            username2.Text = "";
            password2.Text = "";
            email.Text = "";
            telephone.Text = "";
        }
        public void maj()
        {

        }
        public void remplir()
        {

        }
        private void LoginBTN_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "" || Password.Text == "" )

            {
                if (UserName.Text == "")
                {
                    MessageBox.Show("User Name Empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    z = true;
                }
                else
                {
                    MessageBox.Show("Password Empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    z = true;
                }
            }
            if (UserName.Text != "" || Password.Text != "")
            {
                info login = new info(UserName.Text, Password.Text);

                if (File.Exists("C:\\data.xml"))
                {
                    FileStream file = new FileStream("C:\\data.xml", FileMode.Open, FileAccess.Read);
                    XmlSerializer xml = new XmlSerializer(typeof(List<info>));

                    list = (List<info>)xml.Deserialize(file);

                    foreach (info i in list)
                    {
                        //if (Password.Text != i.Password2)
                        //{
                        //    MessageBox.Show("Password incorrect", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        //else
                        //{
                        //    if (UserName.Text != i.Username2)
                        //    {
                        //        MessageBox.Show("UserName incorrect", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    }
                        if (Password.Text == i.Password2 && UserName.Text == i.Username2)
                        {
                            MessageBox.Show("Correct, Click Ok to Continue ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            x = true;

                            this.Hide();
                            Dashboard form = new Dashboard();
                            form.Show();
                            file.Close();

                        }
                    }
                
                    if (x == false && z == false)
                    //if (UserName.Text == "" || Password.Text == "" )
                    {
                        foreach (info i in list)
                        {
                            if (Password.Text != i.Password2 && UserName.Text == i.Username2)
                            {
                                MessageBox.Show("Password incorrect", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                y = true;
                                break;
                            }
                            else
                            {
                                if (UserName.Text != i.Username2 && Password.Text == i.Password2)
                                {
                                    MessageBox.Show("UserName incorrect", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    y = true;
                                    break;
                                }
                            }
                        }
                        if (y == false && UserName.Text != "" && Password.Text != "")
                            {
                            foreach (info i in list)
                            {
                                if (UserName.Text != i.Username2 && Password.Text != i.Password2)
                                {
                                    MessageBox.Show("UserName and Password incorrect", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                }
                            }

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Create an Account to Login", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Empty();
                
            }


        }

        private void ShowPasswordToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (ShowPasswordToggleSwitch1.Checked == true)
            {
                Password.UseSystemPasswordChar = false;
                Password.PasswordChar = '*';
            }
            if (ShowPasswordToggleSwitch1.Checked == false)
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewAccountBTN_Click(object sender, EventArgs e)
        {
            PanelSIGNIN.Hide();
            panelSIGNUP.Show();
            this.Height = this.Height + 17;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            panelSIGNUP.Hide();
            PanelSIGNIN.Show();
            this.Height = this.Height - 17;
        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (bunifuToggleSwitch2.Checked == true)
            {
                password2.UseSystemPasswordChar = false;
                password2.PasswordChar = '*';
            }
            if (bunifuToggleSwitch2.Checked == false)
            {
                password2.UseSystemPasswordChar = true;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (username2.Text == "" || password2.Text == "" || email.Text == ""  || telephone.Text == "" )

            {
                if (username2.Text == "")
                {
                    MessageBox.Show("User Name Empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (password2.Text == "")
                    {
                        MessageBox.Show("Password Empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (email.Text == "")
                        {
                            MessageBox.Show("Email Empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Telephone Empty", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                }

            }
            else
            {
                try
                {
                    info signup = new info(username2.Text, password2.Text, email.Text, int.Parse(telephone.Text));

                    signup.Username2 = username2.Text;
                    signup.Password2 = password2.Text;
                    signup.Email = email.Text;
                    signup.Telephone = int.Parse(telephone.Text);

                    if (File.Exists("C:\\data.xml"))
                    {
                        FileStream file0 = new FileStream("C:\\data.xml", FileMode.Open, FileAccess.Read);
                        XmlSerializer xml0 = new XmlSerializer(typeof(List<info>));

                        list = (List<info>)xml0.Deserialize(file0);
                        file0.Close();
                    }

                    list.Add(signup);

                    XmlSerializer xml = new XmlSerializer(typeof(List<info>));

                    FileStream file = new FileStream("C:\\data.xml", FileMode.Create, FileAccess.Write);

                    xml.Serialize(file, list);
                    file.Close();

                    panelSIGNUP.Hide();
                    PanelSIGNIN.Show();
                    Empty();
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }
    }
}
