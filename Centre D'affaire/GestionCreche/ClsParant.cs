using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionCreche
{
    class ClsParant
    {
        private string NomParant;
        private string prenomParant;
        private string Profession;
        private int telephone;
        private string departement;
        private readonly List<frmEnfant> EF = new List<frmEnfant>();
        public ClsParant() { }
        public List<frmEnfant> en{ get => EF; }
        
       

        public ClsParant(string Nom, string PRENOM, string Pro , int tele , string depar)
        {
            this.NomParant = Nom;
            this.prenomParant = PRENOM;
            this.Profession = Pro;
            this.telephone = tele;
            this.departement = depar;
       


        }

        public string Nom { get => NomParant; set => NomParant = value; }
        public string Prenom { get => prenomParant; set => prenomParant= value; }
        public string Pro { get => Profession; set => Profession = value; }
        public int tele { get => telephone; set => telephone = value; }
        public string depar { get => departement; set => departement = value; }
    }
}
