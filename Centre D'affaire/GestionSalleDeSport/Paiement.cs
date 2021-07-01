using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public class Paiement
    {
        private Membre membe;
        private string paiement;


        public Paiement() { }

        public Paiement(Membre mbr, string PAiement)

        {
            this.Paiement1 = PAiement;
            this.membres1 = mbr;
        }


        public string Paiement1 { get => paiement; set => paiement = value; }
        public Membre membres1 { get => membe; set => membe = value; }


    }
    
}
