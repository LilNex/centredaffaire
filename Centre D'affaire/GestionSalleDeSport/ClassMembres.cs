using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionSalleDeSport {
    class ClassMembres
    {
        private string nom;
        private string prenom;
        private string numero;
        private DateTime dateNaissance;
        private int telphone;
        private string email;
        private string adresse;
        private int codePostal;
        private string sex;
        private string situationFamillial;



        // le constructour conseigne  
        public ClassMembres() { }

        // le constructeur par default 
        public ClassMembres(string NOm, string PRenom, string NUmero, DateTime DAteNaissance, int TElephone, string EMail, string ADresse, int COdPostal, string SEx, string SItuationFamillial)
        {
            this.Nom = NOm;
            this.Prenom = PRenom;
            this.Numero = NUmero;
            this.DateNaissance = DAteNaissance;
            this.Telephone = TElephone;
            this.Email = EMail;
            this.Adresse = ADresse;
            this.CodePostal = COdPostal;
            this.Sex = SEx;
            this.SituationFamillial = SItuationFamillial;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Numero { get => numero; set => numero = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public int Telephone { get => telphone; set => telphone = value; }
        public string Email { get => email; set => email = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int CodePostal { get => codePostal; set => codePostal = value; }
        public string Sex { get => sex; set => sex = value; }
        public string SituationFamillial { get => situationFamillial; set => situationFamillial = value; }

        public int Rechercher(string numero)
        {
            for (int i = 0; i < ClassListes.ListeMembres.Count; i++)
            {
                if (ClassListes.ListeMembres[i].Numero == numero)
                {
                    return i;
                }
            }
            return -1;
        }


        public bool Ajouter(ClassMembres Membre)
        {

            if (Rechercher(Membre.numero) == -1)
            {
                ClassListes.ListeMembres.Add(Membre);
                return true;
            }
            else
            {
                return false;
            }

        }



        public bool Supprimer(ClassMembres Membre)
        {

            if (Rechercher(Membre.numero) != -1)
            {
                ClassListes.ListeMembres.Remove(Membre);
                return true;
            }
            else
            {
                return false;
            }

        }
      //  x = "hello";
    }










}
