using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionCreche
{
    class clsParents
    {
        private string nomPere;
        private string prenomPere;
        private string nomMere;
        private string prenomMere;
        private int NmbrEnfantAcharge;
        private int codePostal;
        private string ville;
        private string Tel;
        private string AdresseParents;

        public clsParents() { }
        public clsParents(string NOMPERE, string PRENOMPERE, string NOMMERE, string PRENOMMERE, int NMBRENFANTACHARGE, string ADRESSEPARENTS, int CODEPOSTAL, string VILLE, string TEL)
        {
            this.NomPere = NOMPERE;
            this.PrenomPere = PRENOMPERE;
            this.NomMere = NOMMERE;
            this.PrenomMere = PRENOMMERE;
            this.NmbrEnfantAcharge1 = NMBRENFANTACHARGE;
            this.AdresseParents1 = ADRESSEPARENTS;

        }

        public string NomPere { get => nomPere; set => nomPere = value; }
        public string PrenomPere { get => prenomPere; set => prenomPere = value; }
        public string NomMere { get => nomMere; set => nomMere = value; }
        public string PrenomMere { get => prenomMere; set => prenomMere = value; }
        public int NmbrEnfantAcharge1 { get => NmbrEnfantAcharge; set => NmbrEnfantAcharge = value; }
        public int CodePostal { get => codePostal; set => codePostal = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Tel1 { get => Tel; set => Tel = value; }
        public string AdresseParents1 { get => AdresseParents; set => AdresseParents = value; }
    }
}

