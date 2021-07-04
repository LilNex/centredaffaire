using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionPersonnel
{
    public class DepartementEventArgs : EventArgs
    {
        public ClsDepartement departement { get; set; }
    }

    public class PosteModifEventArgs : EventArgs
    {
        public ClsDepartement departement { get; set; }
        public clsPoste poste { get; set; }
    }
}
