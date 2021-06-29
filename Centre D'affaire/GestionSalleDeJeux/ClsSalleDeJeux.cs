using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    class ClsSalleDeJeux
    {
        public int NumeroS;
        public string NomS;
        
        public ClsSalleDeJeux() { }

        public ClsSalleDeJeux(int NumeroS, string NomS)
        {
            this.NumeroS = NumeroS;
            this.NomS = NomS;
        }

        public int numeroS { get => NumeroS; set => NumeroS = value; }
        public string nomS { get => NomS; set => NomS = value; }


        //--------LA METHODE DE RECHERCHE---------------
        public int RechercheSDJ(int NumeroS)
        {
            for(int i=0;i<ClsListeSDJ.ListSalle.Count;i++)
            {
                if (ClsListeSDJ.ListSalle[i].numeroS == NumeroS)
                {
                    return i;
                }
            }
            return -1;
        }



        //--------LA METHODE D'AJOUTE---------------
        public bool AjouterSalleDJ()
        {
            if (RechercheSDJ(NumeroS) == -1)
            {
                ClsSalleDeJeux SDJ = new ClsSalleDeJeux();
                //button = SDJ.NumeroT;
                //button = SDJ.nomT;
                ClsListeSDJ.ListSalle.Add(SDJ);
                return true;
            }
            else
            {
                //SDJ est deja exsite
                return false;
            }
        }
    }
}
