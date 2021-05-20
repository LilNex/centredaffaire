using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public  class ClsEmploye
    {
        private string ID_emp;
        private string Nom;
        private string Prenom;
        private int Telephone;
        private string E_mail;
        private string Profil;
        private ClsProfil Type_profil;


        public string Nom1 { get => Nom; set => Nom = value; }
        public string Prenom1 { get => Prenom; set => Prenom = value; }
      
     
        public int Telephone1 { get => Telephone; set => Telephone = value; }
        public string ID_emp1{ get => ID_emp; set => ID_emp = value; }
        public string E_mail1 { get => E_mail; set => E_mail = value; }
        public string Profil1 { get => Profil; set => Profil = value; }
        internal ClsProfil Type_profil1 { get => Type_profil; set => Type_profil = value; }
        //----------constructeur par default---------------
        public ClsEmploye() { }
        //--------------constructeur renseigné-----------------
        public ClsEmploye(string id_emp,string nom,string prenom,int telephone,string email,string profil,ClsProfil type_employe)
        {
            this.ID_emp = id_emp;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Telephone = telephone;
            this.E_mail = email;
            this.Profil = profil;
            this.Type_profil = type_employe;
        }


    }
   
}
