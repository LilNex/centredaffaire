using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    class Vendeur : Personne
    {
        private string fourniture ;

        //Constructure
        public Vendeur() { }

        public Vendeur(string ID, string NOmComplet, DateTime DAteREJoin, int TElephone, string EMail, string ADresse, string SEx, string FOurniture)
            : base(ID, NOmComplet,  DAteREJoin, TElephone, EMail, ADresse, SEx)
        {

            this.Fourniture = FOurniture;

        }


        public string Fourniture { get => fourniture; set => fourniture = value; }

    }
}
