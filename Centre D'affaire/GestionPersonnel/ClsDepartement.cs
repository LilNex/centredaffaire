using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionPersonnel
{
    class ClsDepartement
    {

        public static List<ClsDepartement> ListeDepartement = new List<ClsDepartement>();

        private string num;
        private string nom;
        private List<clsPoste> listePoste = new List<clsPoste>();
        private int id;

        public string Num { get => num; set => num = value; }
        // CONDITION format : XXX000
        public string Nom { get => nom; set => nom = value; }
        internal List<clsPoste> ListePoste { get => listePoste; set => listePoste = value; }
        public int Id { get => id; set => id = value; }

        public ClsDepartement(string nom, string num)
        {
            Nom = nom;
            Num = num;
        }
        public int rechercheNum(string num)
        {
            for (int i = 0; i < ListePoste.Count(); i++)
            {
                if (ListePoste[i].Num == num)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool AjouterPoste(clsPoste poste)
        {
            if (rechercheNum(poste.Num) != -1)
            {
                return false;
            }
            else
            {

                ListePoste.Add(poste);
                return true;
            }
        }
        

    }
}
