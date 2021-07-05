using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public class ClsProfil
    {
        private string ID_profil;
        private string Nom_profil;// DIRECTEUR / RESPONSABLE ACHAT / COMMERCIAL / SECRETAIRE 

        public string ID_profil1 { get => ID_profil; set => ID_profil = value; }
        public string Nom_profil1 { get => Nom_profil; set => Nom_profil = value; }
        //-------constructeur par default---------------------
        public ClsProfil() { }
        //----------constructeur renseigné
        public ClsProfil(string id_profil,string nom_profil)
        {
            this.ID_profil = id_profil;
            this.Nom_profil = nom_profil;
        }
    
    }
}
