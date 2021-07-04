using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public class Entraineur : Personne
    {
       
        private int salaire ;
        private Image image;

        //Constructure
        public Entraineur() { }
        public Image IM { get => image; set => image = value; }
        public Entraineur(string ID, string NOmComplet, DateTime DAteREJoin, string TElephone, string EMail, string ADresse, string SEx ,int SAlarie , Image im )
            : base(ID, NOmComplet, DAteREJoin, TElephone, EMail, ADresse, SEx)
        {
           
            this.Salaire = SAlarie;
            this.IM = im;

        }

        public Entraineur(string ID, string NOmComplet, DateTime DAteREJoin, string TElephone, string EMail, string ADresse, string SEx) : base(ID, NOmComplet, DAteREJoin, TElephone, EMail, ADresse, SEx)
        {
        }

        public int Salaire { get => salaire; set => salaire = value; }


        public int Rechercher(string id)
        {
            for (int i = 0; i < Listes.EntraineursListe.Count; i++)
            {
                if (Listes.EntraineursListe[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }


        public bool Ajouter(Entraineur m)
        {
            if (Rechercher(m.Id) == -1)
            {
                Listes.EntraineursListe.Add(m);
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool supprimer(string numero)
        {
            if (Rechercher(numero) != -1)
            {
                Listes.EntraineursListe.RemoveAt(Rechercher(numero));
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
