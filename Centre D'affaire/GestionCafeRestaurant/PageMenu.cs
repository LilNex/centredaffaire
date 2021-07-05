using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionCafeRestaurant
{
    public partial class PageMenu : Form
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        public PageMenu(String user)
        {
            InitializeComponent();
            if(user == "Admin")
            {
                btnAdd.Show();
                btnAddItems.Show();
                btnRemove.Show();
                btnUpdate.Show();
            }
            else
            {
                btnAdd.Hide();
                btnAddItems.Hide();
                btnRemove.Hide();
                btnUpdate.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_Additems1.Visible = true;
            uC_Additems1.BringToFront();
        }

        private void PageMenu_Load(object sender, EventArgs e)
        {
            uC_Additems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItem1.Visible = false;
            uC_CreateNewUser1.Visible = false;
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            uC_CreateNewUser1.Visible = true;
            uC_CreateNewUser1.BringToFront();
        }

        private void uC_CreateNewUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
