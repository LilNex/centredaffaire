using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    class Produit
    {
        private string idProduit;
        private int prix;
        private int quantite;
        private string unite;
        private int total;
        private Vendeur vend;

        public  Produit() { }
        public Produit(string idproduit , int prix , int quantite , string unite , int total ) 
        {
            this.ID = idproduit;
            this.Prix = prix;
            this.Quantite = quantite;
            this.Unite = unite;
            this.Total = total;
        }
        public string ID { get => idProduit; set => idProduit = value; }
        public int Prix { get => prix; set => prix = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public string Unite { get => unite; set => unite = value; }
        public int Total { get => total; set => total = value; }





    }
}
