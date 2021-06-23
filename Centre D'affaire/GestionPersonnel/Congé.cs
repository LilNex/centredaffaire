using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionPersonnel
{
    class Congé
    {
        public List<Congé> ListeDesCongé = new List<Congé>();
        private DateTime date;
        private int durée;
        private static List<ClsEmploye> listeEmploye = new List<ClsEmploye>();
        private string catégories;
        private string etat;

        public DateTime Date { get => date; set => date = value; }
        public int Durée { get => durée; set => durée = value; }
        public static List<ClsEmploye> ListeEmploye { get => listeEmploye; set => listeEmploye = value; }
        public string Catégories { get => catégories; set => catégories = value; }
        public string Etat { get => etat; set => etat = value; }
        public Congé() { }
        public Congé(DateTime d, int duré,List<ClsEmploye>ls,string ca,string etats)    
        {
            this.date = d;
            this.durée = duré;
            listeEmploye = ls;
            this.catégories = ca;
            this.etat= etats;

        }
        public int rechercher(DateTime date)
        {
            for (int i = 0; i < ListeDesCongé.Count(); i++)
            {
                if (ListeDesCongé[i].date == date)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool ajouter (Congé G)
        {
            if(rechercher(G.date) == -1)
            {
                ListeDesCongé.Add(G);
                return true;
            }
            return false;                
        }
        public void supprimer(DateTime date)
        {
            if (rechercher(date) != -1)
            {
                ListeDesCongé.RemoveAt(rechercher(date));
                
            }
            
        }

    }
}
