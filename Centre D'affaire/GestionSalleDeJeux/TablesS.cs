using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    class TablesS
    {
        public int NumeroT;
        public string NomT;

        public TablesS() { }

        public TablesS(int NumeroT,string NomT)
        {
            this.NomT = NomT;
            this.NumeroT = NumeroT;
        }

        public int numeroT { get => NumeroT; set => NumeroT = value; }
        public string nomT { get => NomT; set => NomT = value; }

    }
}