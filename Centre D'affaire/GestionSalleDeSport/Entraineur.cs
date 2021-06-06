using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeSport
{
    class Entraineur : Personne
    {
       
        private int salaire ;

        //Constructure
        public Entraineur() { }

        public Entraineur(string ID, string NOmComplet, DateTime DAteREJoin, int TElephone, string EMail, string ADresse, string SEx ,int SAlarie )
            : base(ID, NOmComplet, DAteREJoin, TElephone, EMail, ADresse, SEx)
        {
           
            this.Salaire = SAlarie; 
   
        }

       
        public int Salaire { get => salaire; set => salaire = value; }







    }
}
