using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public enum ArticleType
    {
        Meuble, Bureau, SalleSport,SalleJeux, Autre,Service , Crèche , Uniforme , Caferestaurant,
    }


    [Serializable]
    public class ClsArticle
    {
        private string nom;       
        private ArticleType typeArticle;
        private string description;
        private Image photo;

        public string Nom { get => nom; set => nom = value; }
           
       
        public string Description { get => description; set => description = value; }
        public Image Photo { get => photo; set => photo = value; }
        public ArticleType TypeArticle { get => typeArticle; set => typeArticle = value; }

        public ClsArticle() { }

        public ClsArticle(string nom ,ArticleType articletype, string description ,  Image photo  )
        {
            this.Nom = nom;
            
            this.Description = description;
            this.Photo = photo;
            this.TypeArticle = articletype;
            
            
            
            
            


        }


       
    }
}
