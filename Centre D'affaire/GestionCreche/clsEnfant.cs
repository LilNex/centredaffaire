using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionCreche
{
    public class clsEnfant
    {
        private string nom;
        
        private DateTime dateNaiss;
        private DateTime dateDadmission;
        private int age;
 

        

        public clsEnfant() { }
        public clsEnfant(string NOM, DateTime dateN, DateTime dateD,  int AGE)
        {
            this.Nom = NOM;
           
            
            this.DateNaiss = dateN;
            this.DateDadmission = dateD;
            
            this.Age = AGE;

        }

        public string Nom { get => nom; set => nom = value; }
        
       
        public DateTime DateNaiss { get => dateNaiss; set => dateNaiss = value; }
        public DateTime DateDadmission { get => dateDadmission; set => dateDadmission = value; }
       
        public int Age { get => age; set => age = value; }


        //private int rechercher(string numero)
        //{
        //    for (int i = 0; i < clsListe.LE.Count; i++)
        //    {
        //        if (clsListe.LE[i].Num == num)
        //        {

        //            return i;
        //        }
        //    }

        //    return -1;
        //}
        //-------------------------------
        //public clsEnfant rechercherEF(string numero)
        //{
        //    for (int i = 0; i < clsListe.LE.Count; i++)
        //    {
        //        if (clsListe.LE[i].Num == num)
        //        {
        //            return clsListe.LE[i];
        //        }
        //    }

        //    return null;
        //}
        ////-----------------------------------
        //public bool Ajouter(clsEnfant EF)
        //{
        //    if (rechercher(EF.num) == -1)
        //    {
        //        clsListe.LE.Add(EF);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        ////-------------
        //public bool supprimer(clsEnfant EF)
        //{
        //    if (rechercher(EF.num) != -1)
        //    {
        //        clsListe.LE.Remove(EF);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        ////---------------
        //public bool supprimer(string num)
        //{
        //    if (rechercher(num) != -1)
        //    {
        //        clsListe.LE.RemoveAt(rechercher(num));
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //public bool modifier(string num, clsEnfant EF)
        //{
        //    if (rechercher(num) != -1)
        //    {
        //        clsListe.LE[rechercher(num)] = EF;
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
