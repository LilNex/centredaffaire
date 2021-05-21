using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    class ClsListe
    {
        public static List<ClsEmploye> List_employe = new List<ClsEmploye>();
        public static List<ClsFournisseur> List_fournisseur = new List<ClsFournisseur>();
        public static List<ClsAchats> List_achat = new List<ClsAchats>();
        public static List<ClsCommande> List_commande = new List<ClsCommande>();
        public static List<ClsDemande> List_demande = new List<ClsDemande>();
        public static List<ClsFacture> List_facture = new List<ClsFacture>();
    }
}
