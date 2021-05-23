using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public class ClsFacture
    {
        private string Numero_facture;
        private DateTime Date_facturation;
        private string Etat; // declenche serialisation 
        private int Prix_facture;

        public string Numero_facture1 { get => Numero_facture; set => Numero_facture = value; }
        public DateTime Date_facturation1 { get => Date_facturation; set => Date_facturation = value; }
        public string Etat1 { get => Etat; set => Etat = value; }
        public int Prix_facture1 { get => Prix_facture; set => Prix_facture = value; }
        //------constructeur par default--------------------
        public ClsFacture() { }
        //-------------constructeur renseigné-------------
        public ClsFacture(string num_facture,DateTime date_facturation,string etat,int prix_facture)
        {
            this.Numero_facture = num_facture;
            this.Date_facturation = date_facturation;
            this.Etat = etat;
            this.Prix_facture = prix_facture;
        }
        public int Recherche_Fac(string numfac)
        {
            for (int i = 0; i < ClsListe.List_facture.Count(); i++)
            {
                if (ClsListe.List_facture[i].Numero_facture == numfac)
                {
                    return i;
                }
            }
            return -1;
        }
        public ClsFacture Recherche_Fac_O(string numfac)
        {
            for (int i = 0; i < ClsListe.List_facture.Count(); i++)
            {
                if (ClsListe.List_facture[i].Numero_facture == numfac)
                {
                    return ClsListe.List_facture[i];
                }
            }
            return null;
        }
        public bool Ajouter_Fac(ClsFacture numfac)
        {
            if (Recherche_Fac(numfac.Numero_facture) == -1)
            {
                ClsListe.List_facture.Add(numfac);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Supprimer_Fac(ClsFacture numfac)
        {
            if (Recherche_Fac(numfac.Numero_facture) != -1)
            {
                ClsListe.List_facture.Remove(numfac);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Modifier_Fac(string id, ClsFacture numfac)
        {
            if (Recherche_Fac(id) != -1)
            {
                ClsListe.List_facture[Recherche_Fac(id)] = numfac;
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
