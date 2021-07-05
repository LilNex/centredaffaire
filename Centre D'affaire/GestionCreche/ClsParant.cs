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
        
        private string Profession;
        private int telephone;
        private string departement;
        private readonly List<frmInscription> EF = new List<frmInscription>();
        public ClsParant() { }
        public List<frmInscription> en{ get => EF; }
        
       

        public ClsParant(string Nom, string Prof , int tele , string depar)
        {
            this.NomParant = Nom;
            
            this.Profession = Prof;
            this.telephone = tele;
            this.departement = depar;
       


        }

        public string Nom { get => NomParant; set => NomParant = value; }
        
        public string Pro { get => Profession; set => Profession = value; }
        public int tele { get => telephone; set => telephone = value; }
        public string depar { get => departement; set => departement = value; }
    }
}
