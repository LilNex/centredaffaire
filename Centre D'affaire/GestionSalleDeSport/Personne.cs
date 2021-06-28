using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
      public class Personne
    {
        private string id;
        private string nomComplet;  
        private DateTime dateJoin;
        private string telphone;
        private string email;
        private string adresse;
        private string sex;



        // le constructour conseigne  
        public Personne() { }

        // le constructeur par default 
        public Personne(string ID, string NOmComplet,DateTime DAteREJoin, string TElephone, string EMail, string ADresse, string SEx) 
        {
            this.Id = ID;
            this.NomComplet = NOmComplet;

            this.DateJoin = DAteREJoin;
            this.Telephone = TElephone;
            this.Email = EMail;
            this.Adresse = ADresse;
            this.Sex = SEx;

        }

        public string Id { get => id; set => id = value; }
        public string NomComplet { get => nomComplet; set => nomComplet = value; }
        public DateTime DateJoin { get => dateJoin; set => dateJoin = value; }
        public string Telephone { get => telphone; set => telphone = value; }
        public string Email { get => email; set => email = value; }
        public string Adresse{ get => adresse; set => adresse = value; } 
        public string Sex { get => sex; set => sex = value; }

       


        



        
       }
}
