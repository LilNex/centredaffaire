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
using System.Xml.Serialization;

namespace Centre_D_affaire.GestionCafeRestaurant.AllUserControl
{
    [Serializable]

    

    public partial class UC_Additems : UserControl
    {
        [Serializable]
        public class ClsObjet
        {
            public static List<ClsObjet> ListArticle = new List<ClsObjet>();
            private string nomA;
            private float prixA;
            private string categorieA;
            public ClsObjet() { }

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
       
        public static List<ClsObjet> ListArticle = new List<ClsObjet>();

        public void ser()
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream fichierbin = new FileStream("Objet.txt", FileMode.OpenOrCreate);
            f.Serialize(fichierbin, ListArticle);
            fichierbin.Close();
        }
        public void charger()
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream fichierbin = new FileStream("Objet.txt", FileMode.OpenOrCreate);
            ListArticle = (List<ClsObjet>)f.Deserialize(fichierbin);
            fichierbin.Close();
        }
        public int rechercheA(string libelle)
        {
            for (int i = 0; i < ListArticle.Count; i++)
            {
                if (ListArticle[i].NomA == libelle)
                {
                    return i;
                }
            }
            return -1;
        }


        public UC_Additems()
        {
            InitializeComponent();
        }
         public bool AjouterA(ClsObjet A)
        {
            if (rechercheA(A.NomA) == -1)
            {

                ListArticle.Add(A);
                MessageBox.Show("Objet ajouter avec succes", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ser();
                return true;
                
            }
            else { return false; }
        }
        
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ClsObjet s = new ClsObjet(txtItemName.Text, float.Parse(txtPrice.Text), txtCategorie.Text);
            AjouterA(s);
            txtItemName.Clear();
            txtCategorie.Text = "";
            txtPrice.Clear();
        }

       

        private void UC_Additems_Leave(object sender, EventArgs e)
        {
            
        }

        private void UC_Additems_Load(object sender, EventArgs e)
        {
            
            charger();
        }
    }
}