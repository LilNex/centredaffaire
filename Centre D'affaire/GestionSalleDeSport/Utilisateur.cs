using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public class Utilisateur
    {
        private string nomUtilisateur;
        private string motPasse;
        private string questionSecurite ;
        private string reponse; 

        public Utilisateur() { }
        public Utilisateur(string NOmUtilisateur , string MOtpass , string quetionSecurite , string reponse)
        {
            this.NomUtilisateur = NOmUtilisateur;
            this.MotPass = MOtpass;
            this.Quetion = quetionSecurite;
            this.Reponse = reponse; 
            
        }

        public string NomUtilisateur { get => nomUtilisateur; set => nomUtilisateur = value; }
        public string MotPass { get => motPasse; set => motPasse = value; }

        public string Quetion { get => questionSecurite; set => questionSecurite = value; }
        public string Reponse { get => reponse; set => reponse = value; }

        public int Rechercher(string id)
        {
            for (int i = 0; i < Listes.utilisateurs.Count; i++)
            {
                if (Listes.utilisateurs[i].nomUtilisateur == id)
                {
                    return i;
                }
            }
            return -1;
        }


        public bool Ajouter(Utilisateur m)
        {
            if (Rechercher(m.nomUtilisateur) == -1)
            {
                Listes.utilisateurs.Add(m);
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
