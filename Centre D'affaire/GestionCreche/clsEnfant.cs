using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionCreche
{
    class clsEnfant
    {
        private string nom;
        private string prenom;
        private char Sex;
        private DateTime dateNaiss;
        private DateTime dateDadmission;
        private string num;
        private int age;
        private ClsParant parant;

        

        public clsEnfant() { }
        public clsEnfant(string NOM, string PRENOM, char SEX, DateTime dateN, DateTime dateD, string NUM, int AGE)
        {
            this.Nom = NOM;
            this.Prenom = PRENOM;
            this.Sex1 = SEX;
            this.DateNaiss = dateN;
            this.DateDadmission = dateD;
            this.Num = NUM;
            this.Age = AGE;

        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public char Sex1 { get => Sex; set => Sex = value; }
        public DateTime DateNaiss { get => dateNaiss; set => dateNaiss = value; }
        public DateTime DateDadmission { get => dateDadmission; set => dateDadmission = value; }
        public string Num { get => num; set => num = value; }
        public int Age { get => age; set => age = value; }


        private int rechercher(string numero)
        {
            for (int i = 0; i < clsListe.ListeEnfant.Count; i++)
            {
                if (clsListe.ListeEnfant[i].Num == num)
                {

                    return i;
                }
            }

            return -1;
        }
        //-------------------------------
        public clsEnfant rechercherEF(string numero)
        {
            for (int i = 0; i < clsListe.ListeEnfant.Count; i++)
            {
                if (clsListe.ListeEnfant[i].Num == num)
                {
                    return clsListe.ListeEnfant[i];
                }
            }

            return null;
        }
        //-----------------------------------
        public bool Ajouter(clsEnfant EF)
        {
            if (rechercher(EF.num) == -1)
            {
                clsListe.ListeEnfant.Add(EF);
                return true;
            }
            else
            {
                return false;
            }
        }
        //-------------
        public bool supprimer(clsEnfant EF)
        {
            if (rechercher(EF.num) != -1)
            {
                clsListe.ListeEnfant.Remove(EF);
                return true;
            }
            else
            {
                return false;
            }
        }
        //---------------
        public bool supprimer(string num)
        {
            if (rechercher(num) != -1)
            {
                clsListe.ListeEnfant.RemoveAt(rechercher(num));
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool modifier(string num, clsEnfant EF)
        {
            if (rechercher(num) != -1)
            {
                clsListe.ListeEnfant[rechercher(num)] = EF;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
