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

namespace Cafe_Management.AllUserControl
{
    public partial class UC_CreateNewUser : UserControl
    {
        public UC_CreateNewUser()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Cafedb.mdf;Integrated Security=True;Connect Timeout=30");
        /*void populate()
        {
            con.Open();
            string query = "select * from UsersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }*/
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //con.Open();
            //string query = "insert into UsersTbl values('"+UnameTb.Text+"','"+UphoneTb.Text+"','"+UpasswordTb.Text+"')";
            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Utilisateur créé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //con.Close();
            //populate();
        }

        private void UC_CreateNewUser_Load(object sender, EventArgs e)
        {
            //populate();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            UphoneTb.Text = guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            UpasswordTb.Text = guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "")
            {
                MessageBox.Show("Sélectionner l'utilisateur à supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //con.Open();
                //string query = "delete from UsersTbl where Uname ='" + UnameTb.Text + "'";
                //SqlCommand cmd = new SqlCommand(query, con);
                //cmd.ExecuteNonQuery();
                MessageBox.Show("Utilisateur supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //con.Close();
                //populate();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(UpasswordTb.Text == ""|| UphoneTb.Text=="" || UnameTb.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //con.Open();
                //string query = "update UsersTbl set Uname = '" + UnameTb.Text + "',Uphone = '" + UphoneTb.Text + "' ,Upassword = '" + UpasswordTb.Text + "' where Uphone ='"+UphoneTb.Text+"'";
                //SqlCommand cmd = new SqlCommand(query, con);
                //cmd.ExecuteNonQuery();
                MessageBox.Show("Utilisateur modifié avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //con.Close();
                //populate();
            }
        }
    }
}
