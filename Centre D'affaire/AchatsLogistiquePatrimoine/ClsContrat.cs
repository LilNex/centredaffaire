using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    class ClsContrat
    {
        private DateTime Date_debut;
        private DateTime Date_fin;
       

        public DateTime Date_debut1 { get => Date_debut; set => Date_debut = value; }
        public DateTime Date_fin1 { get => Date_fin; set => Date_fin = value; }
      
        //----------constructeur par default--------------------
        public ClsContrat() { }
        //----------constructeur renseigné--------------------
        public ClsContrat(DateTime date_debut,DateTime date_fin)
        {
            this.Date_debut = date_debut;
            this.Date_fin = date_fin;
        }
    
    }
}
