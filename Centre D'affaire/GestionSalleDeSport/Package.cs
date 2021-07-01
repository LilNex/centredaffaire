using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public class Package
    {
        private string id;
        private string nom;
        private string prix;
        private string detail;

        public Package() { }
        public Package(string ID, string NOm, string PRix, string DEtail)
        {
            this.Id = ID;
            this.Nom = NOm;
            this.Prix = PRix;
            this.Detail = DEtail;
        }

        public Package(string NOm)
        {
            
            this.Nom = NOm;
            
        }
        public string Id { get => id; set => id = value; }
        public string Nom {get =>nom  ; set =>nom = value ; }
        public string Prix  { get => prix; set => prix = value; }
        public string Detail { get => detail; set => detail = value; }


        public int Rechercher(string id)
        {
            for (int i = 0; i < Listes.PackagesListe.Count; i++)
            {
                if (Listes.PackagesListe[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }


        public bool Ajouter(Package pack)
        {
            if (Rechercher(pack.Id) == -1)
            {
                Listes.PackagesListe.Add(pack);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool supprimer(Package ST)
        {
            if (Rechercher(ST.Id) != -1)
            {
                Listes.PackagesListe.Remove(ST);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
