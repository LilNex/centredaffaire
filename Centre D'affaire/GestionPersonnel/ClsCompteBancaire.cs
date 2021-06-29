using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionPersonnel
{
    class ClsCompteBancaire
    {
        private string NomSl;
        private int NumSl;
        private int RIB;
        public string nomSl {get => nomSl; set => nomSl = value;}
        public int numSl { get => numSl; set => numSl = value; }
        public int Rib { get => Rib; set => Rib = value; }
        
        public ClsCompteBancaire()
        {
            this.NomSl = nomSl;
            this.NumSl = numSl;
            this.RIB = Rib;
        }
    }
    
        




}
