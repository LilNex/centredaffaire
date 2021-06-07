using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    class ClsService
    {
        private string numero_service;
        private string nom_service;

        public string Numero_service { get => numero_service; set => numero_service = value; }
        public string Nom_service { get => nom_service; set => nom_service = value; }

        public ClsService() { }

        public ClsService( string numeroservice , string nomservice)
        {
            this.numero_service = numeroservice;
            this.Nom_service = numero_service; 

        }





    }
}
