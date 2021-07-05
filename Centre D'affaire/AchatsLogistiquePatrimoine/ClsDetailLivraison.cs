using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public class ClsDetailLivraison
    {
        private string numero_detail;
        private int quantite_livre;

        public string Numero_detail { get => numero_detail; set => numero_detail = value; }
        public int Quantite_livre { get => quantite_livre; set => quantite_livre = value; }

        public ClsDetailLivraison() { }

        public ClsDetailLivraison(string numerodetail , int quantitelivre)
        {
            this.Numero_detail = numerodetail;
            this.Quantite_livre = quantitelivre;

        }
    }
}
