using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionSalleDeJeux
{
    class ClsOccupationJ
    {
        private DateTime dateDeOccupation;
        private DateTime dateDeDebut;
        private DateTime dateDeFin;

        public DateTime DateDeOccupation { get => dateDeOccupation; set => dateDeOccupation = value; }
        public DateTime DateDeDebut { get => dateDeDebut; set => dateDeDebut = value; }
        public DateTime DateDeFin { get => dateDeFin; set => dateDeFin = value; }

        public ClsOccupationJ() { }

        public ClsOccupationJ(DateTime DateDeOccupation,DateTime DateDeDebut,DateTime DateDeFin)
        {
            this.DateDeOccupation = DateDeOccupation;
            this.DateDeDebut = DateDeDebut;
            this.DateDeFin = DateDeFin;
        }

    }
}
