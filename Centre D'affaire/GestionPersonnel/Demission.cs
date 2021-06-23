using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionPersonnel
{
    class Demission
    {
        public List<Demission> ListeDesDemission = new List<Demission>();
        private DateTime date;
        private static List<ClsEmploye> listeEmploye = new List<ClsEmploye>();
        private string raison;
        private string etat;

        public DateTime Date { get => date; set => date = value; }
        public static List<ClsEmploye> ListeEmploye { get => listeEmploye; set => listeEmploye = value; }
        public string Etat { get => etat; set => etat = value; }
        public string Raison { get => raison; set => raison = value; }

        public Demission() { }
        public Demission(DateTime d,  List<ClsEmploye> ls, string Raison, string Etat)
        {
            this.date = d;
            listeEmploye = ls;
            this.raison = Raison;
            this.etat = Etat;

        }
        public int rechercher(DateTime date)
        {
            for (int i = 0; i < ListeDesDemission.Count(); i++)
            {
                if (ListeDesDemission[i].date == date)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool ajouter(Demission G)
        {
            if (rechercher(G.date) == -1)
            {
                ListeDesDemission.Add(G);
                return true;
            }
            return false;
        }
        public void supprimer(DateTime date)
        {
            if (rechercher(date) != -1)
            {
                ListeDesDemission.RemoveAt(rechercher(date));

            }

        }

    }
}
