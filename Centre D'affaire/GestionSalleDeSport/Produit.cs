using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public class Produit
    {
        private string idProduit;
        private int prix;
        private int quantite;
        public string nom;
        private int total;
        DateTime date;
        private Vendeur vend;

        public  Produit() { }
        public Produit(string idproduit , int prix , string nom, int quantite  , int total , Vendeur vend  , DateTime date) 
        {
            this.ID = idproduit;
            this.Nom = nom; 
            this.Prix = prix;
            this.Quantite = quantite;
            this.Total = total;
            this.Date = date;
            this.Vendeuur = vend;
        }
        public string ID { get => idProduit; set => idProduit = value; }
        public string Nom { get => nom; set => nom = value; }
        public DateTime Date { get => date; set => date = value;  }
        public int Prix { get => prix; set => prix = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public int Total { get => total; set => total = value; }
        public Vendeur Vendeuur { get => vend; set => vend = value ; }

        public int Rechercher(string id)
        {
            for (int i = 0; i < Listes.produit.Count; i++)
            {
                if (Listes.produit[i].ID == id)
                {
                    return i;
                }
            }
            return -1;
        }


        public bool Ajouter(Produit m)
        {
            if (Rechercher(m.ID) == -1)
            {
                Listes.produit.Add(m);
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
