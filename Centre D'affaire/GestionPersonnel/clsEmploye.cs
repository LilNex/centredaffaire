using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionPersonnel
{
    public class ClsEmploye
    {
        private string nom;
        private string prenom;
        private string num;
        private string télephone;
        private string email;
        private string cin;
        private char situation_familiale;
        private string competence;
        private DateTime date_debut;
        private DateTime date_naissance;
        private char sex;
        private string adresse;
        private int salaire;
        private string rfid;
        public string Nom
        {
            get => nom;
            set
            {
                if (value.All(char.IsLetter))
                {
                    nom = value;
                }
                else
                {
                    throw new Exception("le Prenom ne doit pas contenur des chiffres et des caracteres spécieux");
                }
            }
        }
        public string Prenom
        {
            get => prenom; set
            {
                bool okey = false;
                foreach (char c in value)
                {
                    if (char.IsLetter(c) == false)
                    {
                        okey = false;
                    }
                }
                if (okey == false)
                {
                    throw new Exception("le Prenom ne doit pas contenur des chiffres et des caracteres spécieux");
                }
                else
                {
                    prenom = value;
                }
            }
        }

        public string Num { get => num; set => num = value; }
        public string Cin { get => cin; set => cin = value; }
        public string Télephone { get => télephone; set => télephone = value; }
        public string Email { get => email; set => email = value; }
        public char Situation_familiale { get => situation_familiale; set => situation_familiale = value; }
        public string Competence { get => competence; set => competence = value; }
        public DateTime Date_debut { get => date_debut; set => date_debut = value; }
        public DateTime Date_naissance { get => date_naissance; set => date_naissance = value; }
        public char Sex { get => sex; set => sex = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Salaire { get => salaire; set => salaire = value; }
        public string Rfid { get => rfid; set => rfid = value; }

        public ClsEmploye(string num, string nom)
        {
            this.Nom = nom;
            this.Num = num;
        }
        public ClsEmploye() { }
    }
}
