using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    class Achat
    {
        private string achatID;
        private DateTime dateAchat;
        private Vendeur vendeuur;


        public string Numero { get => achatID; set => achatID = value; }
        public  DateTime date { get => dateAchat; set => dateAchat = value; }
        public Vendeur vebndeur { get => vendeuur; set => vendeuur = value; }



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


        public bool Ajouter(Achat m)
        {
            if (Rechercher(m.Numero) == -1)
            {
                Listes.achatliste.Add(m);
                return true;
            }
            else
            {
                return false;
            }
        }



    } 



    
}
