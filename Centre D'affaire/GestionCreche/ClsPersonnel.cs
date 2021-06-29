using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionCreche
{
    
    
        public class ClsPersonnel
        {


            private string Nom;
            private string Prenom;
            private string AdresseWeb;
            private string Email;
            private string Telephone;
            public ClsPersonnel() { }


            public ClsPersonnel(string Name, string Surname, String Adresse, string EmailE, string Phone)
            {
                this.Nom = Name;
                this.Prenom = Surname;
                this.AdresseWeb = Adresse;
                this.Email = EmailE;
                this.Telephone = Phone;

            }

            public string Nom1 { get => Nom; set => Nom = value; }
            public string Prenom1 { get => Prenom; set => Prenom = value; }
            public string Adresseweb1 { get => AdresseWeb; set => AdresseWeb = value; }
            public string Email1 { get => Email; set => Email = value; }
            public string Telephone1 { get => Telephone; set => Telephone = value; }

        }

    }

