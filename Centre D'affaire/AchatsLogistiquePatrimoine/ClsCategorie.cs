using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    class ClsCategorie
    {
        private string num_categorie;
        private string nom_categorie;

        

        public string Num_categorie { get => num_categorie; set => num_categorie = value; }
        public string Nom_categorie { get => nom_categorie; set => nom_categorie = value; }

        public ClsCategorie() { }

        public ClsCategorie(string numCategorie , string nomCategorie)
        {
            this.num_categorie = numCategorie;
            this.nom_categorie = nomCategorie; 
        }





    }
}
