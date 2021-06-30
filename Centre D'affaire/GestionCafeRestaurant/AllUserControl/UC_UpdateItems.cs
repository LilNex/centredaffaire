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

namespace Cafe_Management.AllUserControl
{
    [Serializable]
    public partial class UC_UpdateItems : UserControl
    {
        
        UC_Additems.ClsObjet STOLD = new UC_Additems.ClsObjet();

        public UC_UpdateItems()
        {
            InitializeComponent();
        }
        
        public int rechercheA(string libelle)
        {
            for (int i = 0; i < UC_Additems.ListArticle.Count; i++)
            {
                if (UC_Additems.ListArticle[i].NomA == libelle)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool modifier(string numero, UC_Additems.ClsObjet ST)
        {
            if (rechercheA(numero) != -1)
            {
                UC_Additems.ListArticle[rechercheA(numero)] = ST;
                return true;
            }
            else
            {
                return false;
            }
        }
        
       
        public void RemplirGridStagiaires()
        {
            guna2DataGridView1.Rows.Clear();
            for (int i = 0; i < UC_Additems.ListArticle.Count; i++)
            {
                guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[i].Cells[0].Value = UC_Additems.ListArticle[i].NomA;
                guna2DataGridView1.Rows[i].Cells[1].Value = UC_Additems.ListArticle[i].PrixA;
                guna2DataGridView1.Rows[i].Cells[2].Value = UC_Additems.ListArticle[i].CategorieA;
            }
        }
        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            
            RemplirGridStagiaires();
        }

       
        public List<UC_Additems.ClsObjet> re(string nom)
        {
            var RN = UC_Additems.ListArticle.Where(x => x.NomA.StartsWith(nom));
            return RN.ToList();
        }
        public void RemplirGrid()
        {
            guna2DataGridView1.Rows.Clear();
            for (int i = 0; i < Lr.Count; i++)
            {
                guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[i].Cells[0].Value = Lr[i].NomA;
                guna2DataGridView1.Rows[i].Cells[1].Value = Lr[i].PrixA;
                guna2DataGridView1.Rows[i].Cells[2].Value = Lr[i].CategorieA;
            }
        }
        public List<UC_Additems.ClsObjet> Lr = new List<UC_Additems.ClsObjet>();

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
           
            

            UC_Additems.ClsObjet s = new UC_Additems.ClsObjet();
            var RN = re(txtSearchItem.Text);
            Lr = RN.ToList();
            RemplirGrid();


        }

        
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            String category = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            int price = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            txtCategory.Text = category;
            txtName.Text = name;
            txtPrice.Text = price.ToString();
        }
        public UC_Additems.ClsObjet rechercherST(string numero)
        {
            for (int i = 0; i < UC_Additems.ListArticle.Count; i++)
            {
                if (UC_Additems.ListArticle[i].NomA == numero)
                {
                    return UC_Additems.ListArticle[i];
                }
            }
            return null;
        }
        public void ser()
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream fichierbin = new FileStream("Objet.txt", FileMode.OpenOrCreate);
            f.Serialize(fichierbin, UC_Additems.ListArticle);
            fichierbin.Close();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            string num = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            STOLD = rechercherST(num);
            UC_Additems.ClsObjet s = new UC_Additems.ClsObjet(txtName.Text, int.Parse(txtPrice.Text), txtCategory.Text);
            modifier(STOLD.NomA, s);
            RemplirGridStagiaires();
            txtName.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            ser();
        }
    }
}
