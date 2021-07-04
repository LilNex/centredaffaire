using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionCreche
{
    class clsResponsable
    {
        private string nom;
        private string prenom;
        private string tel;
        private string email;
        private string adresseWeb;
        private string num;

        public clsResponsable() { }
        public clsResponsable(string NOM, string PRENOM, string TEL, string EMAIL, string ADRESSEWEB, string NUM)
        {
            this.Nom = NOM;
            this.Prenom = PRENOM;
            this.Tel = TEL;
            this.Email = EMAIL;
            this.AdresseWeb = ADRESSEWEB;
            this.Num = NUM;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string AdresseWeb { get => adresseWeb; set => adresseWeb = value; }
        public string Num { get => num; set => num = value; }


        public int Rechercher(string num)
        {
            for (int i = 0; i < clsListe.ListeOrganismes.Count; i++)
            {
                if (clsListe.ListeOrganismes[i].Num == num)
                {
                    return i;
                }
            }
            return -1;
        }


        public bool Ajouter(clsResponsable Organisme)
        {

            if (Rechercher(Organisme.num) == -1)
            {
                clsListe.ListeOrganismes.Add(Organisme);
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool supprimer(clsResponsable Organisme)
        {
            if (Rechercher(Organisme.num) != -1)
            {
                clsListe.ListeOrganismes.Remove(Organisme);
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
