using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    class Stock :  Produit 
    {
        public Stock() { }
        public Stock(string idproduit, int prix, int quantite, string unite, int total)
            :base(idproduit,  prix, quantite, unite,total)
        {
        }
    }
}
