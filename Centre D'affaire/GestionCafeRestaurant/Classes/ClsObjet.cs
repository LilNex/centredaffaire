using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Management.Classes
{
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
}
