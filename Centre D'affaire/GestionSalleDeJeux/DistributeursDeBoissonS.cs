using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    class DistributeursDeBoissonS
    {
        public int NumerDB;

        public DistributeursDeBoissonS() { }

        public DistributeursDeBoissonS (int NumerDB)
        {
            this.NumerDB = NumerDB;
        }

        public int numeroDB { get => NumerDB; set => numeroDB = value; }


    }
}
