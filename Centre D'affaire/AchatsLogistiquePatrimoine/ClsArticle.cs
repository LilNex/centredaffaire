using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    class ClsArticle
    {
        private string numero_categorie;
        private string libele;
        private string description;
        private string photochemin;

        public string Numero_categorie { get => numero_categorie; set => numero_categorie = value; }
        public string Libele { get => libele; set => libele = value; }
        public string Description { get => description; set => description = value; }
        public string Photochemin { get => photochemin; set => photochemin = value; }

        public ClsArticle() { }

        public ClsArticle( string numerocategorie , string libele , string description , string photochemin  )
        {
            this.numero_categorie = numerocategorie;
            this.Libele = libele;
            this.Description = description;
            this.Photochemin = photochemin;


        }
    }
}
