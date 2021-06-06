using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    class Utilisateur : Personne
    {
        private string nomUtilisateur;
        private string motPasse;
        private string questionSecurite ;
        private string reponse; 

        public Utilisateur() { }
        public Utilisateur(string ID, string NOmComplet, DateTime DAteREJoin, int TElephone, string EMail, string ADresse, string SEx,string NOmUtilisateur , string MOtpass , string quetionSecurite , string reponse) : base(ID, NOmComplet, DAteREJoin, TElephone, EMail, ADresse, SEx)
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






    }
}
