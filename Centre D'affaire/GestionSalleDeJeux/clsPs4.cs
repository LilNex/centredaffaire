using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    public class clsPs4
    {
        private string namePs4;
        private int numberPs4;

        public clsPs4(string namePs4,int numberPs4)
        {
            this.namePs4 = namePs4;
            this.numberPs4 = numberPs4;
        }


        public string NamePs4 { get => namePs4; set => namePs4 = value; }
        public int NumberPs4 { get => numberPs4; set => numberPs4 = value; }
    }
}
