using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    class TablesS
    {
        public int NumeroT;
        public string NomT;

        public TablesS() { }

        public TablesS(int NumeroT,string NomT)
        {
            this.NomT = NomT;
            this.NumeroT = NumeroT;
        }

        public int numeroT { get => NumeroT; set => NumeroT = value; }
        public string nomT { get => NomT; set => NomT = value; }



        //----------- LA METHODE DE RECHERCHE------------
        public int rechercher(string numeroT)
        {
            for (int i = 0; i < ClsListeSDJ.ListTableS.Count; i++)
            {
                if (ClsListeSDJ.ListTableS[i].NumeroT == NumeroT)
                {
                    return i;
                }
            }
            return -1;
        }



        //-------- LA METHODE DE MODIFICATION------------------
        public bool modifier(string numeroT, TablesS TA)
        {

            if (rechercher(numeroT) != -1)
            {
                ClsListeSDJ.ListTableS[rechercher(numeroT)] = TA;
                return true;
            }
            else
            {
                return false;
            }
        }


        //----------LA METHODE DE SUPRESSION------------------



        public bool supprimer(TablesS TA)
        {
            ClsListeSDJ.ListTableS.Remove(TA);
            return true;

        }


        public bool supprimer(string NumeroT)
        {
            for (int i = 0; i < ClsListeSDJ.ListTableS.Count; i++)
            {
                if (ClsListeSDJ.ListTableS[i].NumeroT == numeroT)
                {
                    ClsListeSDJ.ListTableS.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}