using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    class Package
    {
        private string id;
        private string nom;
        private string prix;
        private string detail;

        public Package() { }
        public Package(string ID, string NOm, string PRix, string DEtail)
        {
            this.Id = ID;
            this.Nom = NOm;
            this.Prix = PRix;
            this.Detail = DEtail;
        }
        public string Id { get => id; set => id = value; }
        public string Nom {get =>nom  ; set =>nom = value ; }
        public string Prix  { get => prix; set => prix = value; }
        public string Detail { get => detail; set => detail = value; }


    }
}
