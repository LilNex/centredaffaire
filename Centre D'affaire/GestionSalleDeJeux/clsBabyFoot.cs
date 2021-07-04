using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    public class clsBabyFoot
    {
        private string nameBabyFoot;
        private int numberBabyFoot;

        public string NameBabyFoot { get => nameBabyFoot; set => nameBabyFoot = value; }
        public int NumberBabyFoot { get => numberBabyFoot; set => numberBabyFoot = value; }

        public clsBabyFoot(string nameBabyFoot,int numberBabyFoot)
        {
            NameBabyFoot = nameBabyFoot;
            NumberBabyFoot = numberBabyFoot;
        }

    }
}
