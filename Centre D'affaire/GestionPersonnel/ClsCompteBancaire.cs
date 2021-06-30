using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionPersonnel
{
    class ClsCompteBancaire
    {
        private string nomSl;
        private int NumSl;
        private int RIB;
        private int Total;
        private DateTime dp;
        
        public string NomSl {get => nomSl; set => nomSl = value;}
        public int numSl { get => NumSl; set => NumSl = value; }
        public int Rib { get => RIB; set => RIB = value; }
        public int total { get => Total; set => Total = value; }
        public DateTime DP { get => dp; set => dp = value; }




        public ClsCompteBancaire(string nom, int num, int RIb, int tot , DateTime d)
        {
            this.NomSl = nom;
            this.numSl = num;
            this.Rib = RIb;
            this.total = tot;
            this.DP = d; 
        }

        public void Ajout(ClsCompteBancaire bnc)
        {
            list.bnq.Add(bnc);
        }
    }
    
        
    



}
