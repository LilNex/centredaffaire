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
    public partial class UC_RemoveItem : UserControl
    {
        ArrayList cls = new ArrayList();
        //function fn = new function();
        //String query;
        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        private void UC_RemoveItem_Load(object sender, EventArgs e)
        {
            //loadData();
        }
        public void loadData()
        {
            //query = "select * from item";
            //DataSet ds = fn.getData(query);
            //guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSarch_TextChanged(object sender, EventArgs e)
        {
            
            foreach (ClsObjet ctl in cls)
            {
                guna2DataGridView1.DataSource = ctl;
            }
            //query = "select * from item where name like '" + txtSarch.Text + "%'";
            //DataSet ds = fn.getData(query);
            //guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Supprimer l'article?", "Important", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //query = "delete from item where iid = "+id+"";
                //fn.setdata(query);
                //loadData();
            }
        }

        private void UC_RemoveItem_Enter(object sender, EventArgs e)
        {
            //loadData();
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
    }
}
