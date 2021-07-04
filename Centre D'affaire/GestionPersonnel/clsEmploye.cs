using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionPersonnel
{
    public enum EmployeType
    {
        Employe,
        Secretaire,
        Directeur,
    }

    public class ClsEmploye
    {

        public static List<ClsEmploye> ListeEmploye = new List<ClsEmploye>();
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
        private EmployeType type;

        //login
        private string userlogin;
        private string mdp;

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
                    throw new Exception("le Prenom ne doit pas contenur des chiffres et des caracteres spéciaux");
                }
            }
        }
        public string Prenom
        {
            get => prenom; set
            {
                bool okey = true;
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
        public string Userlogin { get => userlogin; set => userlogin = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public EmployeType Type { get => type; set => type = value; }

        public ClsEmploye(string num, string nom,string prenom,string cin, string tel, string email, char Sit, string comp, DateTime DateDajout,DateTime DateNaissance, char sex, string adresse, EmployeType empType)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Num = num;
            this.Cin = cin;
            this.Télephone = tel;
            this.Email = email;
            this.Situation_familiale = Sit;
            this.Competence = comp;
            this.Date_debut = DateDajout;
            this.Date_naissance = DateNaissance;
            this.Sex = sex;
            this.Adresse = adresse;

            this.Type = empType;


            this.Userlogin = Nom + "." + Prenom;
            this.Mdp = this.Cin;
        }

        public ClsEmploye() { }
        public int rechercher(string cin)
        {
            for (int i = 0; i < ListeEmploye.Count(); i++)
            {
                if (ListeEmploye[i].cin == cin)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool ajouter(ClsEmploye G)
        {
            if (rechercher(G.cin) == -1)
            {
              ListeEmploye.Add(G);
                return true;
            }
            return false;
        }
        public void supprimer(string cin)
        {
            if (rechercher(cin) != -1)
            {
               ListeEmploye.RemoveAt(rechercher(cin));

            }

        }
        public bool modifier(string cin , ClsEmploye G)
        {
            if (rechercher(cin) != -1)
            {
                ListeEmploye[rechercher(cin)] = G ;
                return true; 
            }
            return false;
        }
        public override string ToString()
        {
            return this.Nom + " " + this.Prenom;
        }
    }
}
