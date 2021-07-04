using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    public class clsArcArdStreet
    {
        private string NameArcardStreet;
        private int NumberNameArcardStreet;

        public clsArcArdStreet(string nameArcardStreet, int numberNameArcardStreet)
        {
            NameArcardStreet1 = nameArcardStreet;
            NumberNameArcardStreet1 = numberNameArcardStreet;
        }



        public string NameArcardStreet1 { get => NameArcardStreet; set => NameArcardStreet = value; }
        public int NumberNameArcardStreet1 { get => NumberNameArcardStreet; set => NumberNameArcardStreet = value; }
    }
}
