using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public class ClsEmploye
    {
        private string ID_emp;
        private string MDP_emp;
        private string Nom;
        private string Prenom;
        private int Telephone;
        private string E_mail;
        private String  TypeProfil;
        


        public string Nom1 { get => Nom; set => Nom = value; }
        public string Prenom1 { get => Prenom; set => Prenom = value; }
      
     
        public int Telephone1 { get => Telephone; set => Telephone = value; }
        public string ID_emp1{ get => ID_emp; set => ID_emp = value; }
        public string E_mail1 { get => E_mail; set => E_mail = value; }
        public string TypeProfil1 { get => TypeProfil; set => TypeProfil = value; }
        public string MDP_emp1 { get => MDP_emp; set => MDP_emp = value; }



        //----------constructeur par default---------------
        public ClsEmploye() { }
        //--------------constructeur renseigné-----------------
        public ClsEmploye(string id_emp, string nom,string prenom,int telephone,string email,string profil,string mdp)            

        {
            this.ID_emp = id_emp;
            this.MDP_emp1 = mdp;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Telephone = telephone;
            this.E_mail = email;
            this.TypeProfil1 = profil;
        }
        public int Recherche_Emp(string idemp)
        {
            for (int i = 0; i < ClsListe.List_employe.Count(); i++)
            {
                if (ClsListe.List_employe[i].ID_emp == idemp)
                {
                    return i;
                }
                
            }
            return -1;
        }
        public ClsEmploye Recherche_Emp_OB(string idemp)
        {
            for (int i = 0; i < ClsListe.List_employe.Count(); i++)
            {
                if (ClsListe.List_employe[i].ID_emp == idemp)
                {
                    return ClsListe.List_employe[i];
                }

            }
            return null;
        }
        public bool Ajouter_Emp(ClsEmploye A)
        {
            if (Recherche_Emp(A.ID_emp) == -1)
            {
                ClsListe.List_employe.Add(A);
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool Supprimer_Emp(ClsEmploye s)
        {
            if (Recherche_Emp(s.ID_emp) != -1)
            {
                ClsListe.List_employe.Remove(s);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Modifier_Emp(string id, ClsEmploye e)
        {
            if (Recherche_Emp(id) != -1)
            {
                ClsListe.List_employe[ Recherche_Emp(id) ] = e;
                return true;
            }
            else
            {
                return false;
            }

        }





    }
   
}
