using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    class ClsDemande
    {
        private string ID_demande;
        private string Type_demande;
        private string Etat_demande;
        private DateTime Date_demande;

        public string ID_demande1 { get => ID_demande; set => ID_demande = value; }
        public string Type_demande1 { get => Type_demande; set => Type_demande = value; }
        public string Etat_demande1 { get => Etat_demande; set => Etat_demande = value; }
        public DateTime Date_demande1 { get => Date_demande; set => Date_demande = value; }

        public ClsDemande() { }

        public ClsDemande(string iddemande , string typedemande, string etatdemande,DateTime datedemande) 
        {
            this.ID_demande = iddemande;
            this.Type_demande = typedemande;
            this.Etat_demande = etatdemande;
            this.Date_demande = datedemande;
        }
        public int Recherche_Dmd(string iddmd)
        {
            for (int i = 0; i < ClsListe.List_demande.Count(); i++)
            {
                if (ClsListe.List_demande[i].ID_demande == iddmd)
                {
                    return i;
                }
            }
            return -1;
        }
        public ClsDemande Recherche_Dmd_O(string iddmd)
        {
            for (int i = 0; i < ClsListe.List_demande.Count(); i++)
            {
                if (ClsListe.List_demande[i].ID_demande == iddmd)
                {
                    return ClsListe.List_demande[i];
                }
            }
            return null;
        }
        public bool Ajouter_Dmd(ClsDemande dmd)
        {
            if (Recherche_Dmd(dmd.ID_demande) == -1)
            {
                ClsListe.List_demande.Add(dmd);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Supprimer_Dmd(ClsDemande dmd)
        {
            if (Recherche_Dmd(dmd.ID_demande) != -1)
            {
                ClsListe.List_demande.Remove(dmd);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Modifier_Acha(string id, ClsDemande dmd)
        {
            if (Recherche_Dmd(id) != -1)
            {
                ClsListe.List_demande[Recherche_Dmd(id)] = dmd;
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
