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
        // autre attributs en relation avec type achat  

        public string ID_cmd { get => iD_cmd; set => iD_cmd = value; }
        public DateTime Date_cmd { get => date_cmd; set => date_cmd = value; }

        public ClsCommande() { }

        public ClsCommande(string idCmd,DateTime dateCmd) 
        {
            this.ID_cmd = idCmd;
            this.Date_cmd = dateCmd;


        }
        public int Recherche_Cmd(string idcmd)
        {
            for (int i = 0; i < ClsListe.List_commande.Count(); i++)
            {
                if (ClsListe.List_commande[i].iD_cmd == idcmd)
                {
                    return i;
                }
            }
            return -1;
        }
        public ClsCommande Recherche_Cmd_O(string idcmd)
        {
            for (int i = 0; i < ClsListe.List_commande.Count(); i++)
            {
                if (ClsListe.List_commande[i].iD_cmd == idcmd)
                {
                    return ClsListe.List_commande[i];
                }
            }
            return null;
        }
        public bool Ajouter_Cmd(ClsCommande cmd)
        {
            if (Recherche_Cmd(cmd.iD_cmd) == -1)
            {
                ClsListe.List_commande.Add(cmd);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Supprimer_Cmd(ClsCommande cmd)
        {
            if (Recherche_Cmd(cmd.iD_cmd) != -1)
            {
                ClsListe.List_commande.Remove(cmd);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Modifier_Cmd(string id, ClsCommande cmd)
        {
            if (Recherche_Cmd(id) != -1)
            {
                ClsListe.List_commande[Recherche_Cmd(id)] = cmd;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
