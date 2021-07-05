using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public class ClsLivraison
    {
        private string num_livraison;
        private DateTime date_livraison;

        public string Num_livraison { get => num_livraison; set => num_livraison = value; }
        public DateTime Date_livraison { get => date_livraison; set => date_livraison = value; }

        public ClsLivraison() { }

        public ClsLivraison(string numlivraison , DateTime datelivraison)
        {
            this.Num_livraison = numlivraison;
            this.Date_livraison = datelivraison;
        }
    }
}
