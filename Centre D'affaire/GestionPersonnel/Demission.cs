using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionPersonnel
{
    class Demission
    {
        public static List<Demission> ListeDesDemission = new List<Demission>();
        private DateTime date;
        private int num;
        private ClsEmploye Employe;
        private string raison;
        private string etat;
        public DateTime Date { get => date; set => date = value; }

        public string Etat { get => etat; set => etat = value; }
        public string Raison { get => raison; set => raison = value; }
        public ClsEmploye Employe1 { get => Employe; set => Employe = value; }
        public int Num { get => num; set => num = value; }

        public Demission() { }
        public Demission(DateTime d,   string Raison, string Etat)
        {
           
            this.Num = num;
            this.date = d;       
            this.raison = Raison;
            this.etat = Etat;
        }
        public int rechercher(int num)
        {
            for (int i = 0; i < ListeDesDemission.Count(); i++)
            {
                if (ListeDesDemission[i].num == num)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool ajouter(Demission G)
        {
            if (rechercher(G.num) == -1)
            {
                ListeDesDemission.Add(G);
                return true;
            }
            return false;
        }
        public void supprimer(int num )
        {
            if (rechercher(num) != -1)
            {
                ListeDesDemission.RemoveAt(rechercher(num));

            }

        }

    }
}
