using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public class ClsDetail_Demande
    {
        private int quantite_demande;
        private DateTime date_prevuLivre;
        private string etat_demande;

       
        public DateTime Date_prevuLivre { get => date_prevuLivre; set => date_prevuLivre = value; }
        public string Etat_demande { get => etat_demande; set => etat_demande = value; }
        public int Quantite_demande { get => quantite_demande; set => quantite_demande = value; }

        public ClsDetail_Demande() { }

        public ClsDetail_Demande(int quantitedemande , DateTime dateprevu , string etatdemande)
        {
            this.Quantite_demande = quantitedemande;
            this.Date_prevuLivre = dateprevu;
            this.Etat_demande = etatdemande;

        }



    }
}
