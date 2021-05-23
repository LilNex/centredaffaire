using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    class SalleDeJeux
    {
        public int NumeroS;
        public string NomS;
        
        public SalleDeJeux() { }

        public SalleDeJeux(int NumeroS, string NomS)
        {
            this.NumeroS = NumeroS;
            this.NomS = NomS;
        }

        public int numeroS { get => NumeroS; set => NumeroS = value; }
        public string nomS { get => NomS; set => NomS = value; }

    }
}
