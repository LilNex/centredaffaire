using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    class Type
    {
        private string nom_Type;

        public Type(){}

        public Type(string nom )
        {
            this.nom_Type = nom;
        }

        public string Nom_Type { get => nom_Type; set => nom_Type = value; }

    }
    
}   
