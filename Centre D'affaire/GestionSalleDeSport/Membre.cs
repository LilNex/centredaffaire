using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public class Membre : Personne
    {
        Package pack;
        private string statut; 
        private int poids;
        private int frais;
        private int duree;
        private int total;
        private Image image; 
        

        public Membre() { }

        public Membre
        (
            string ID, string NOmComplet, DateTime DAteREJoin, string TElephone,
            string EMail, string ADresse, string SEx ,Package PAckage , 
            int POids , int FRais, int DUree , int TOTal  , string status , Image im
        )
            
        : base(ID, NOmComplet,  DAteREJoin, TElephone, EMail, ADresse, SEx )


        {
            this.Package = PAckage;
            this.Statut = status ; 
            this.Poids = POids;
            this.Duree = DUree;
            this.Total = TOTal;
            this.Frais = FRais;
            this.IM = im;
        }



        public Package Package { get => pack; set => pack = value; }
        public int Poids { get => poids; set => poids = value; }
        public Image IM { get => image; set => image = value; }

        public string Statut { get => statut; set => statut = value; }

        public int Frais { get => frais; set => frais = value; }
        public int Duree { get => duree; set => duree = value; }
        public int Total { get => total; set => total = value; }





        public int Rechercher(string id)
        {
            for(int i =0; i< Listes.MembresListe.Count; i++)
            {
                if(Listes.MembresListe[i].Id == id)
                {
                    return i;
                }
            }
            return -1; 
        }

        public int Rerchercher(string id )
        {
            for (int i = 0; i < Listes.fg.Count; i++)
            {
                if (Listes.fg[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }


        public bool Ajouter(Membre m)
        {
            if(Rechercher(m.Id)== -1)
            {
                Listes.MembresListe.Add(m);
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Ajozuter(Membre m)
        {
          
                Listes.fg.Add(m);
              
            
        }
        public bool supprimer(string numero)
        {
            if (Rechercher(numero) != -1)
            {
                Listes.MembresListe.RemoveAt(Rechercher(numero));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

