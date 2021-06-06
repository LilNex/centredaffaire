using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    class Paiement  
    {
        private Membre membre;
        private string paiement;
        

        public Paiement() {}

        public Paiement(Membre mbr , string PAiement  )
            
        {
            this._Paiement = PAiement;
            this.membres = mbr; 
        }


        public string _Paiement { get=>paiement;  set=>paiement=value; }
        public Membre membres { get => membre; set => membre = value; }
        
        
    
    }
}
