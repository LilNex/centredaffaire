using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionCreche
{
    class clsGroupe
    {
        private int num;
        private int numSalle;
        private static List<clsEnfant> ListeEnfant = new List<clsEnfant>();

        public clsGroupe() { }
        public clsGroupe(int NUM, int NUMSALLE)
        {
            this.Num = NUM;
            this.NumSalle = NUMSALLE;

        }

        public int Num { get => num; set => num = value; }
        public int NumSalle { get => numSalle; set => numSalle = value; }


        public bool AjouterDansListeG(clsGroupe G)
        {

            clsListe.listeGroupe.Add(G);
            return true;
        }
        public bool AjouterEnfantDansGroupe(clsEnfant EF)
        {

            clsGroupe.ListeEnfant.Add(EF);
            return true;
        }
        public bool SUPPRIMERDansGroupe(clsEnfant EF)
        {

            clsGroupe.ListeEnfant.Add(EF);
            return true;
        }

    }
}
