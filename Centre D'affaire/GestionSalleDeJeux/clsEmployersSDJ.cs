﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    public class clsEmployersSDJ
    {
        private string nomE;
        private string prenomE;
        private int numeroE;
        private int telephoneE;
        private DateTime dateNaissanceE;

        public string NomE { get => nomE; set => nomE = value; }
        public string PrenomE { get => prenomE; set => prenomE = value; }
        public int TelephoneE { get => telephoneE; set => telephoneE = value; }
        public DateTime DateNaissanceE { get => dateNaissanceE; set => dateNaissanceE = value; }
        public int NumeroE { get => numeroE; set => numeroE = value; }

        public clsEmployersSDJ() { }
        public clsEmployersSDJ(string NomE,string PrenomE,int numeroE,int TelephoneE,DateTime DateNaissanceE)
        {
            this.NomE = NomE;
            this.PrenomE = PrenomE;
            this.TelephoneE = TelephoneE;
            this.numeroE = numeroE;
            this.DateNaissanceE = DateNaissanceE;
        }

        //public bool AjouterE()
        //{
        //    if (rechercherE(NumeroE) == -1)
        //    {
        //        clsEmployersSDJ ESDJ = new clsEmployersSDJ();
        //        ESDJ.NomE = txt
        //        return true;
        //    }
        //    else
        //    {
        //        la table est deja exsite
        //        return false;
        //    }
        //}

        public int rechercherE(int numeroE)
        {
            for (int i = 0; i < ClsListeSDJ.ListE.Count; i++)
            {
                if (ClsListeSDJ.ListE[i].numeroE == numeroE)
                {
                    return i;
                }
            }
            return -1;
        }
        

        
    }
}
