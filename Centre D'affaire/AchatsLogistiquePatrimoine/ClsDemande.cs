using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public enum EtatDemande { 
        validé,
        attente
    }
    [Serializable]
    public class ClsDemande
    {
        private int ID_demande;
        private string Libele;
        private EtatDemande Etat_demande; // validé 
        private string urgence;
        private DateTime Date_demande;
        private List<CHOIX> Listchoix = new List<CHOIX>();
        private ClsDepartement departement = new ClsDepartement();
        

        public int ID_demande1 { get => ID_demande; set => ID_demande = value; }
        
        public EtatDemande Etat_demande1 { get => Etat_demande; set => Etat_demande = value; }
        public DateTime Date_demande1 { get => Date_demande; set => Date_demande = value; }
        public string Libele1 { get => Libele; set => Libele = value; }
        public string Urgence { get => urgence; set => urgence = value; }
        public List<CHOIX> listchoix { get => Listchoix; set => Listchoix = value; }
        public ClsDepartement Departement { get => departement; set => departement = value; }

        public ClsDemande() { }

        public ClsDemande(int iddemande , string libele, EtatDemande etatdemande, string urgence ,DateTime datedemande, List<CHOIX> listchoix, ClsDepartement departement) 
        {
            this.ID_demande = iddemande;
            this.Libele = libele;
            this.Etat_demande = etatdemande ;
            this.Urgence = urgence;
            this.Date_demande = datedemande;
            this.listchoix = listchoix;
            this.Departement = departement;
        }
        public int Recherche_Dmd(int iddmd)
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
        public ClsDemande Recherche_Dmd_O(int iddmd)
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
        public bool Modifier_Acha(int id, ClsDemande dmd)
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
        
        
       
        public static void affiche(List<ClsEmploye> L, ComboBox c)
        {
            c.Items.Add(L[0].Nom1);

            
        }



    }
}
