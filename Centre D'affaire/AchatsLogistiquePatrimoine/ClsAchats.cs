using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    class ClsAchats
    {
        private string iD_Achat;
        private int quantité;
        private int prix;

        public string ID_Achat { get => iD_Achat; set => iD_Achat = value; }
        public int Quantité { get => quantité; set => quantité = value; }
        public int Prix { get => prix; set => prix = value; }

        public ClsAchats() { }

        public ClsAchats(string idachats,int quantité , int prix)
        {
            this.ID_Achat = idachats;
            this.Quantité = quantité;
            this.Prix = quantité;

        }
    }
}
