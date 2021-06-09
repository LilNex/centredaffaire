using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    class Vendeur : Personne
    {
        

        //Constructure
        public Vendeur() { }

        public Vendeur(string ID, string NOmComplet, DateTime DAteREJoin, int TElephone, string EMail, string ADresse, string SEx)
            : base(ID, NOmComplet,  DAteREJoin, TElephone, EMail, ADresse, SEx)
        {

        }



    }
}
