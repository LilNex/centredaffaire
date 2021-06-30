using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionCreche
{
    class clsGroupe
    {
        private int numG;
        private string nomG;
        private static List<clsEnfant> ListeEnfant = new List<clsEnfant>();

        public int NumG { get => numG; set => numG = value; }
        public string NomG { get => nomG; set => nomG = value; }
        public clsGroupe() { }
        public clsGroupe(int numG, string nomG)
        {
            this.numG = numG;
            this.nomG = nomG;
        }


        

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

            clsGroupe.ListeEnfant.Remove(EF);
            return true;
        }

    }
}
