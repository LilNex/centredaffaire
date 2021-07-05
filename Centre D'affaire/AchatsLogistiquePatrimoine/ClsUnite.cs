using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public class ClsUnite
    {
        private string numero_unite;
        private string libele;

        public string Numero_unite { get => numero_unite; set => numero_unite = value; }
        public string Libele { get => libele; set => libele = value; }

        public ClsUnite() { }

        public ClsUnite(string numeroUnite , string libele)
        {
            this.numero_unite = numeroUnite;
            this.Libele = libele ; 

        }
        


    }
}
