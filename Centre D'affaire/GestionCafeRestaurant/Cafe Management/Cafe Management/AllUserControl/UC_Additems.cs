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
    public partial class UC_Additems : UserControl
    {
        [Serializable]
        public class ClsList
        {
            //public static List<ClsEmployes> ListEmployes = new List<ClsEmployes>();
            public static List<ClsObjet> ListArticle = new List<ClsObjet>();

            public static explicit operator ArrayList(ClsList v)
            {
                throw new NotImplementedException();
            }
            //public static List<ClsCategorie> ListeCategorie = new List<ClsCategorie>();

        }
        [Serializable]
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
        private int rechercheA(string libelle)
        {
            for (int i = 0; i < ClsList.ListArticle.Count; i++)
            {
                if (ClsList.ListArticle[i].NomA == libelle)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool AjouterA(ClsObjet A)
        {
            if (rechercheA(A.NomA) == -1)
            {
                ClsList.ListArticle.Add(A);
                return true;
            }
            else { return false; }
        }


        //function fn = new function();
        //String query;
        public UC_Additems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ClsObjet s = new ClsObjet(txtItemName.Text, float.Parse(txtPrice.Text), txtCategorie.Text);
            //query = "insert into item (name,category,price) values ('" + txtItemName.Text + "','" + txtCategorie.Text + "'," + txtPrice.Text + ")";
            //fn.setdata(query);
            AjouterA(s);
            MessageBox.Show("Objet ajouter avec succes","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ClearAll();
        }

        public void ClearAll()
        {
            txtCategorie.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void UC_Additems_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}