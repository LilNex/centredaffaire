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
using System.Collections;

namespace Cafe_Management.AllUserControl
{
    [Serializable]
    public partial class UC_RemoveItem : UserControl
    {
        ArrayList cls = new ArrayList();
        
        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        private void UC_RemoveItem_Load(object sender, EventArgs e)
        {
          
            RemplirGridStagiaires();
        }
        public List<UC_Additems.ClsObjet> re(string nom)
        {
            var RN = UC_Additems.ListArticle.Where(x => x.NomA.StartsWith(nom));
            return RN.ToList();
        }
        public void loadData()
        {
            
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
        private void txtSarch_TextChanged(object sender, EventArgs e)
        {



            UC_Additems.ClsObjet s= new UC_Additems.ClsObjet();
            var RN = re(txtSarch.Text);
            Lr = RN.ToList();
            RemplirGrid();

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
        public void ser()
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream fichierbin = new FileStream("Objet.txt", FileMode.OpenOrCreate);
            f.Serialize(fichierbin, UC_Additems.ListArticle);
            fichierbin.Close();
        }
        public bool supprimer(string num)
        {

            if (rechercheA(num) != -1)
            {
                UC_Additems.ListArticle.RemoveAt(rechercheA(num));
                return true;
            }
            else
            {
                return false;
            }
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Supprimer l'article?", "Important", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                string nom = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                supprimer(nom);
                RemplirGridStagiaires();
                
                ser();
            }
        }

        private void UC_RemoveItem_Enter(object sender, EventArgs e)
        {
            
        }
        public class ClsObjet
        {
            private string nomA;
            private float prixA;
            private string categorieA;

            public ClsObjet(string nom, float prix, string categorie)
            {
                this.NomA = nom;
                this.PrixA = prix;
                this.CategorieA = categorie;
            }

            public string NomA { get => nomA; set => nomA = value; }
            public float PrixA { get => prixA; set => prixA = value; }
            public string CategorieA { get => categorieA; set => categorieA = value; }
        }
        public class ClsList
        {
            public static List<ClsObjet> ListArticle = new List<ClsObjet>();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
