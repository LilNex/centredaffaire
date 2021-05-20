using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public class ClsFacturation
    {
        private string Numero_facture;
        private DateTime Date_facturation;
        private string Etat;
        private int Prix_facture;

        public string Numero_facture1 { get => Numero_facture; set => Numero_facture = value; }
        public DateTime Date_facturation1 { get => Date_facturation; set => Date_facturation = value; }
        public string Etat1 { get => Etat; set => Etat = value; }
        public int Prix_facture1 { get => Prix_facture; set => Prix_facture = value; }
        //------constructeur par default--------------------
        public ClsFacturation() { }
        //-------------constructeur renseigné-------------
        public ClsFacturation(string num_facture,DateTime date_facturation,string etat,int prix_facture)
        {
            this.Numero_facture = num_facture;
            this.Date_facturation = date_facturation;
            this.Etat = etat;
            this.Prix_facture = prix_facture;
        }
    
    }
}
