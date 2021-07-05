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

namespace Centre_D_affaire.GestionCafeRestaurant.AllUserControl
{
    [Serializable]
    public partial class UC_CreateNewUser : UserControl
    {
        public void ser()
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream fichierbin = new FileStream("User.txt", FileMode.OpenOrCreate);
            f.Serialize(fichierbin, ListUser);
            fichierbin.Close();
        }
        public UC_CreateNewUser()
        {
            InitializeComponent();
        }
        
        ClsUser STOLD = new ClsUser();

        public int recherche(string libelle)
        {
            for (int i = 0; i < ListUser.Count; i++)
            {
                if (ListUser[i].NomB == libelle)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool modifier(string numero, ClsUser ST)
        {
            if (recherche(numero) != -1)
            {
                ListUser[recherche(numero)] = ST;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool supprimer(string num)
        {

            if (recherche(num) != -1)
            {
                ListUser.RemoveAt(recherche(num));
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void charger()
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream fichierbin = new FileStream("User.txt", FileMode.OpenOrCreate);
            ListUser = (List<ClsUser>)f.Deserialize(fichierbin);
            fichierbin.Close();
        }
        [Serializable]
        public class ClsUser
        {
            public static List<ClsUser> ListUser = new List<ClsUser>();
            private string nomB;
            private int phoneB;
            private float mdpB;
            public ClsUser() { }
            public ClsUser(string n,int p,float m)
            {
                this.NomB = n;
                this.PhoneB = p;
                this.MdpB = m;
            }

            public string NomB { get => nomB; set => nomB = value; }
            public int PhoneB { get => phoneB; set => phoneB = value; }
            public float MdpB { get => mdpB; set => mdpB = value; }
        }
        public static List<ClsUser> ListUser = new List<ClsUser>();
        public int rechercheA(string libelle)
        {
            for (int i = 0; i < ListUser.Count; i++)
            {
                if (ListUser[i].NomB == libelle)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool AjouterA(ClsUser A)
        {
           
            if (rechercheA(A.NomB) == -1)
            {
                ListUser.Add(A);
                MessageBox.Show("Données d'utilisateur ajouter avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return true;
            }
            else { return false; }
        }
        public void RemplirGridStagiaires()
        {
            guna2DataGridView1.Rows.Clear();
            for (int i = 0; i < ListUser.Count; i++)
            {
                guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[i].Cells[0].Value = ListUser[i].NomB;
                guna2DataGridView1.Rows[i].Cells[1].Value = ListUser[i].PhoneB;
                guna2DataGridView1.Rows[i].Cells[2].Value = ListUser[i].MdpB;
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            ClsUser s = new ClsUser(UnameTb.Text, int.Parse(UphoneTb.Text), float.Parse(UpasswordTb.Text));
            AjouterA(s);
            RemplirGridStagiaires();
            UnameTb.Clear();
            UphoneTb.Clear();
            UpasswordTb.Clear();
            ser();
        }

        private void UC_CreateNewUser_Load(object sender, EventArgs e)
        {
            
            charger();
            RemplirGridStagiaires();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            float password = float.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            String name = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            int phone = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            UnameTb.Text = name;
            UpasswordTb.Text = password.ToString();
            UphoneTb.Text = phone.ToString();
            
        }
        public ClsUser rechercherST(string numero)
        {
            for (int i = 0; i < ListUser.Count; i++)
            {
                if (ListUser[i].NomB == numero)
                {
                    return ListUser[i];
                }
            }
            return null;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "")
            {
                MessageBox.Show("Sélectionner l'utilisateur à supprimer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Supprimer l'article?", "Important", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string nom = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                    supprimer(nom);
                    MessageBox.Show("données d'utilisateur sont supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RemplirGridStagiaires();
                    ser();
                   
                }
                
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
                string num = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
                STOLD = rechercherST(num);
                ClsUser s = new ClsUser(UnameTb.Text, int.Parse(UphoneTb.Text), float.Parse(UpasswordTb.Text));
                modifier(STOLD.NomB, s);
                RemplirGridStagiaires();
                UnameTb.Clear();
                UphoneTb.Clear();
                UpasswordTb.Clear();
                MessageBox.Show("Données d'utilisateur modifié avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RemplirGridStagiaires();
                ser();
                
            }
        }
    }
}
