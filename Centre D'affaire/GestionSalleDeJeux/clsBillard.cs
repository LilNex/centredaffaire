using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    public class clsBillard
    {
        private string NameBillard;
        private int numeroBillard;

        public clsBillard(string nameBillard, int numeroBillard)
        {
            NameBillard = nameBillard;
            this.numeroBillard = numeroBillard;
        }


        public string NameOfBillard { get => NameBillard; set => NameBillard = value; }
        public int NumberOFBillard { get => numeroBillard; set => numeroBillard = value; }



    }
}
