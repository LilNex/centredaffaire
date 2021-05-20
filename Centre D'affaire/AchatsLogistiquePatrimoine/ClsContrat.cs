using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    class ClsContrat
    {
        private string ID_contrat;
        private DateTime Date_debut;
        private DateTime Date_fin;
       

        public DateTime Date_debut1 { get => Date_debut; set => Date_debut = value; }
        public DateTime Date_fin1 { get => Date_fin; set => Date_fin = value; }
        public string ID_contrat1 { get => this.ID_contrat; set => this.ID_contrat = value; }

        //----------constructeur par default--------------------
        public ClsContrat() { }
        //----------constructeur renseigné--------------------
        public ClsContrat(string idcontrat , DateTime date_debut,DateTime date_fin)
        {
            this.ID_contrat = idcontrat;
            this.Date_debut = date_debut;
            this.Date_fin = date_fin;
        }
    
    }
}
