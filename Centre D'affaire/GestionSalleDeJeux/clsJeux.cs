using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    class clsJeux
    {
        public int NumeroJ;
        public string NomJ;

        public clsJeux() { }

        public clsJeux(int NumeroJ, string NomJ)
        {
            this.NomJ = NomJ;
            this.NumeroJ = NumeroJ;
        }

        public int numeroJ { get => NumeroJ; set => NumeroJ = value; }
        public string nomJ { get => NomJ; set => NomJ = value; }

        

        //----------- LA METHODE DE RECHERCHE------------
        //public int rechercherJeux(int numeroT)
        //{
        //    for (int i = 0; i < ClsListeSDJ.ListJeux.Count; i++)
        //    {
        //        if (ClsListeSDJ.ListJeux[i].NomJ == NomJ)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}



        //-------- LA METHODE DE MODIFICATION------------------
        //public bool modifierJeux(int numeroT, clsJeux TA)
        //{

        //    //if (rechercherJeux(numeroT) != -1)
        //    //{
        //    //    ClsListeSDJ.ListJeux[rechercherJeux(numeroT)] = TA;
        //    //    return true;
        //    //}
        //    //else
        //    //{
        //    //    return false;
        //    //}
        //}


        //----------LA METHODE DE SUPRESSION------------------
        //public bool supprimerJeux(int NumeroT)
        //{
        //    for (int i = 0; i < ClsListeSDJ.ListJeux.Count; i++)
        //    {
        //        if (ClsListeSDJ.ListJeux[i].NomJ == NomJ)
        //        {
        //            ClsListeSDJ.ListJeux.RemoveAt(i);
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //----------LA METHODE D'AJOUTE------------------
        //    public bool AjouterJeux()
        //    {
        //        if (rechercherJeux(NumeroJ) ==-1)
        //        {
        //            clsJeux TS = new clsJeux();
        //            //button = TS.NumeroT;
        //            //button = TS.nomT;
        //            ClsListeSDJ.ListJeux.Add(TS);
        //            return true;
        //        }
        //        else
        //        {
        //            //la table est deja exsite
        //            return false;
        //        }
        //    }

    }
}