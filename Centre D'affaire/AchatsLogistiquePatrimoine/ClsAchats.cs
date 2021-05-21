using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    class ClsAchats
    {
        private string iD_Achat;
        private int quantité;
        private int prix;

        public string ID_Achat { get => iD_Achat; set => iD_Achat = value; }
        public int Quantité { get => quantité; set => quantité = value; }
        public int Prix { get => prix; set => prix = value; }

        public ClsAchats() { }

        public ClsAchats(string idachats,int quantité , int prix)
        {
            this.ID_Achat = idachats;
            this.Quantité = quantité;
            this.Prix = quantité;

        }
        public int Recherche_Ach(string idacha)
        {
            for (int i = 0; i <ClsListe.List_achat.Count(); i++)
            {
                if(ClsListe.List_achat[i].iD_Achat==idacha)
                {
                    return i;
                }
            }
            return -1;
        }
        public ClsAchats Recherche_Ach_O(string idacha)
        {
            for (int i = 0; i < ClsListe.List_achat.Count(); i++)
            {
                if (ClsListe.List_achat[i].iD_Achat == idacha)
                {
                    return ClsListe.List_achat[i];
                }
            }
            return null;
        }
        public bool Ajouter_Ach(ClsAchats A)
        {
            if(Recherche_Ach(A.iD_Achat)==-1)
            {
                ClsListe.List_achat.Add(A);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Supprimer_Acha(ClsAchats a)
        {
            if(Recherche_Ach(a.iD_Achat)!=-1)
            {
                ClsListe.List_achat.Remove(a);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Modifier_Acha(string id,ClsAchats ac)
        {
            if(Recherche_Ach(id)!=-1)
            {
                ClsListe.List_achat[Recherche_Ach(id)] = ac;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
