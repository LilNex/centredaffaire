using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    class DistributeursDeBoissonS
    {
        public int NumerDB;

        public DistributeursDeBoissonS() { }

        public DistributeursDeBoissonS (int NumerDB)
        {
            this.NumerDB = NumerDB;
        }

        public int numeroDB { get => NumerDB; set => numeroDB = value; }


        //---------LA METHODE DE RECHERCHE---------------


        public int rechercher(string numerDB)
        {
            for (int i = 0; i < ClsListeSDJ.ListDDB.Count; i++)
            {
                if (ClsListeSDJ.ListDDB[i].numeroDB == numeroDB)
                {
                    return i;
                }
            }
            return -1;
        }

        //----------LA METHODE DE MODIFICATION------------------



        public bool modifier(string NumerDB, DistributeursDeBoissonS AB)
        {

            if (rechercher(NumerDB) != -1)
            {
                ClsListeSDJ.ListDDB[rechercher(NumerDB)] = AB;
                return true;
            }
            else
            {
                return false;
            }
        }


        //--------LA METHODE DE SUPPRESION---------------


        public bool supprimer(DistributeursDeBoissonS AB)
        {
            ClsListeSDJ.ListDDB.Remove(AB);
            return true;

        }
        public bool supprimer(string numerDB)
        {
            for (int i = 0; i < ClsListeSDJ.ListDDB.Count; i++)
            {
                if (ClsListeSDJ.ListDDB[i].NumerDB == NumerDB)
                {
                    ClsListeSDJ.ListDDB.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

    }
}
