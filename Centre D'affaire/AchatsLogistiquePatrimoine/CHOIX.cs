using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    [Serializable]
    public class CHOIX
    {
        private ClsArticle article;
        private string nom;
        private int quantite;

        public CHOIX() { }

        public CHOIX(ClsArticle article , string nom,int quantite)
        {
            this.Article = article;
            this.Nom = nom;
            this.Quantite = quantite;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public ClsArticle Article { get => article; set => article = value; }
    }
}
