using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    class PointeuseS
    {
        public int NumeroP;
        public String NomP;

        public PointeuseS() { }

        public PointeuseS(int NumeroP,string NomP)
        {
            this.NumeroP = NumeroP;
            this.NomP = NomP; 
        }

        public int numeroP { get => NumeroP; set => NumeroP = value; }
        public string nomP { get => NomP; set => NomP = value; }

    }
}
