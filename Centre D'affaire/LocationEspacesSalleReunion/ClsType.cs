using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.LocationEspacesSalleReunion
{
    [Serializable]
    public class ClsType
    {
        private string numero;
        private string libellé;

        public string Numero { get => numero; set => numero = value; }
        public string Libellé { get => libellé; set => libellé = value; }

        public ClsType() { }
    }
}
