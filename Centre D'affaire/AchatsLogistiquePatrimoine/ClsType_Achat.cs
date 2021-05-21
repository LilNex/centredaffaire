using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    class ClsType_Achat
    {
        private string nom_Type;

        public ClsType_Achat(){}

        public ClsType_Achat(string nom )
        {
            this.nom_Type = nom;
        }

        public string Nom_Type { get => nom_Type; set => nom_Type = value; }

    }
    
}   
