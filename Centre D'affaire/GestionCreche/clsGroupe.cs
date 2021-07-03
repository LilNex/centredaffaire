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
        private static List<clsEnfant> LE = new List<clsEnfant>();



        public int NumG { get => numG; set => numG = value; }
        public string NomG { get => nomG; set => nomG = value; }
        public static List<clsEnfant> LE1 { get => LE; set => LE = value; }

        public clsGroupe() { }
        public clsGroupe(int numG, string nomG,List<clsEnfant> LE)
        {
            this.numG = numG;
            this.nomG = nomG;
            LE1 = LE;
            
            
        }

        
        

        //public bool AjouterDansListeG(clsGroupe G)
        //{

        //    clsListe.listeGroupe.Add(G);
        //    return true;
        //}
        //public bool AjouterEnfantDansGroupe(clsEnfant EF)
        //{

        //    clsGroupe.LE.Add(EF);
        //    return true;
        //}
        //public bool SUPPRIMERDansGroupe(clsEnfant EF)
        //{

        //    clsGroupe.LE.Remove(EF);
        //    return true;
        //}
        //public bool supprimer(clsGroupe G)
        //{
        //    if (rechercherG(G.numG) != -1)
        //    {
        //        clsListe.listeGroupe.Remove(G);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //private int rechercherG(int numG)
        //{
        //    throw new NotImplementedException();
        //}

        //public clsGroupe rechercherG(string numG)
        //{
        //    for (int i = 0; i < clsListe.listeGroupe.Count; i++)
        //    {
        //        if (clsListe.listeGroupe[i].numG == NumG)
        //        {
        //            return clsListe.listeGroupe[i];
        //        }
        //    }

        //    return null;
        //}

        //internal bool SupprimerDansListeG(object numG)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
