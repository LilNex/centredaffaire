using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Data.SqlClient;

namespace Centre_D_affaire.GestionCafeRestaurant
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Hamza" && txtPassword.Text == "Hamza" || txtUsername.Text == "Siham" && txtPassword.Text == "Siham" || txtUsername.Text == "Mehdi" && txtPassword.Text == "Mehdi")
            {
                PageMenu ds = new PageMenu("Admin");
                ds.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Entrer un nom d'utilisateur ou un mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnGuest_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PageMenu ds = new PageMenu("Servant");
            ds.Show();
            this.Hide();
        }
    }
}
    
