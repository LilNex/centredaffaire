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




    }
}
