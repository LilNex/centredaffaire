using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafe_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Hamza" && txtPassword.Text == "Hamza"|| txtUsername.Text == "Siham" && txtPassword.Text == "Siham"|| txtUsername.Text == "Mehdi" && txtPassword.Text == "Mehdi")
            {
                PageMenu ds = new PageMenu("Admin");
                ds.Show();
                this.Hide();
            }
            else
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Entrer un nom d'utilisateur ou un mot de passe","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UsersTbl where Uname = '" + txtUsername.Text + "' and Upassword ='" + txtPassword.Text + "'",con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        PageMenu ds = new PageMenu("Servant");
                        ds.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Identifiant ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }

        }
    }
}
