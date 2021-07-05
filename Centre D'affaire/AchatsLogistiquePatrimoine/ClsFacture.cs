using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public enum etatfacture
    {
        payé, nonpayé,
    }
    [Serializable]
    public class ClsFacture
    {
        private string Id_facture;
        private DateTime Date_facturation;
        private etatfacture etatfacture;      // declenche serialisation 
        private float Prix_facture;
        private ClsCommande objCmd;
        private ClsFournisseur objfourniss ;

        public string Numero_facture1 { get => Id_facture; set => Id_facture = value; }
        public DateTime Date_facturation1 { get => Date_facturation; set => Date_facturation = value; }
        public etatfacture Etatfacture { get => etatfacture; set => etatfacture = value; }
        public float Prix_facture1 { get => Prix_facture; set => Prix_facture = value; }
        public ClsCommande ObjCmd { get => objCmd; set => objCmd = value; }
        public ClsFournisseur Objfourniss { get => objfourniss; set => objfourniss = value; }

        //------constructeur par default--------------------
        public ClsFacture() { }
        //-------------constructeur renseigné-------------
        public ClsFacture(string id_facture, DateTime date_facturation,etatfacture etatfacture, float prix_facture,ClsCommande objcomande , ClsFournisseur objfourniss )
        {
            this.Id_facture = id_facture;
            this.Date_facturation = date_facturation;
            this.Etatfacture = etatfacture ;
            this.Prix_facture = prix_facture;
            this.ObjCmd = objcomande;
            this.Objfourniss = objfourniss; 
        }
        //public int Recherche_Fac(string numfac)
        //{
        //    for (int i = 0; i < ClsListe.List_facture.Count(); i++)
        //    {
        //        if (ClsListe.List_facture[i].Numero_facture == numfac)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        //public ClsFacture Recherche_Fac_O(string numfac)
        //{
        //    for (int i = 0; i < ClsListe.List_facture.Count(); i++)
        //    {
        //        if (ClsListe.List_facture[i].Numero_facture == numfac)
        //        {
        //            return ClsListe.List_facture[i];
        //        }
        //    }
        //    return null;
        //}
        //public bool Ajouter_Fac(ClsFacture numfac)
        //{
        //    if (Recherche_Fac(numfac.Numero_facture) == -1)
        //    {
        //        ClsListe.List_facture.Add(numfac);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool Supprimer_Fac(ClsFacture numfac)
        //{
        //    if (Recherche_Fac(numfac.Numero_facture) != -1)
        //    {
        //        ClsListe.List_facture.Remove(numfac);
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool Modifier_Fac(string id, ClsFacture numfac)
        //{
        //    if (Recherche_Fac(id) != -1)
        //    {
        //        ClsListe.List_facture[Recherche_Fac(id)] = numfac;
                
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

    }
}
