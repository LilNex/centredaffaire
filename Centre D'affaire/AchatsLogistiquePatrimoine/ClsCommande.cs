using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    class ClsCommande
    {
        private string iD_cmd;
        private DateTime date_cmd;

        public string ID_cmd { get => iD_cmd; set => iD_cmd = value; }
        public DateTime Date_cmd { get => date_cmd; set => date_cmd = value; }

        public ClsCommande() { }

        public ClsCommande(string idCmd,DateTime dateCmd) 
        {
            this.ID_cmd = idCmd;
            this.Date_cmd = dateCmd;


        }
    }
}
