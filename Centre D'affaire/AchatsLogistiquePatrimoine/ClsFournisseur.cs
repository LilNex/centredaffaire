using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    class ClsFournisseur
    {
        private string nom_Societe;
        private string telephone_Four;
        private string email_Four;
        private string siteweb_Four;

        public string Nom_Societe { get => nom_Societe; set => nom_Societe = value; }
        public string Telephone_Four { get => telephone_Four; set => telephone_Four = value; }
        public string Email_Four { get => email_Four; set => email_Four = value; }
        public string Siteweb_Four { get => siteweb_Four; set => siteweb_Four = value; }

        public ClsFournisseur() { }

        public ClsFournisseur(string nomsociete,string telephonefour,string emailfour,string sitewebfour)
        {
            this.Nom_Societe = nomsociete;
            this.Telephone_Four = telephonefour;
            this.Email_Four = emailfour;
            this.Siteweb_Four = sitewebfour;

        }

    }
}
