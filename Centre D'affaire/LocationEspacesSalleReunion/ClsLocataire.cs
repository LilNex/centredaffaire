using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.LocationEspacesSalleReunion
{
    [Serializable]
    public class ClsLocataire
    {
        private string numero;
        private string nom;
        private string prenom;
        private string adresse;
        private ClsType type = new ClsType();
        private string tel;

        public string Numero { get => numero; set => numero = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public ClsType Type { get => type; set => type = value; }
        public string Tel { get => tel; set => tel = value; }

        public override string ToString()
        {
            return this.Nom + " " + this.Prenom;
        }
    }
}
