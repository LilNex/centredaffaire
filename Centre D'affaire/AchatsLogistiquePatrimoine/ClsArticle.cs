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
        
        private Image photo;

        public string Nom { get => nom; set => nom = value; }
           
       
       
        public Image Photo { get => photo; set => photo = value; }
        public ArticleType TypeArticle { get => typeArticle; set => typeArticle = value; }

        public ClsArticle() { }

        public ClsArticle(string nom ,ArticleType articletype, Image photo  )
        {
            this.Nom = nom;
            
            
            this.Photo = photo;
            this.TypeArticle = articletype;
            
            
            
            
            


        }


       
    }
}
