using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Centre_D_affaire.GestionPersonnel
{
    public class ClsDepartement
    {
        

        private static List<ClsDepartement> listeDepartement = new List<ClsDepartement>();
        public static List<ClsDepartement> ListeDepartement { get => listeDepartement; set => listeDepartement = value; }



        private string num;
        private string nom;
        private List<clsPoste> listePoste = new List<clsPoste>();
        private int id;

        public string Num { get => num; set => num = value; }
        // CONDITION format : XXX000
        public string Nom { get => nom; set => nom = value; }
        public List<clsPoste> ListePoste { get => listePoste; set => listePoste = value; }
        public int Id { get => id; set => id = value; }

        public ClsDepartement(string nom, string num)
        {
            Nom = nom;
            Num = num;
        }
        public ClsDepartement(){}
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
                saveListeDeps();
                return true;
            }
        }

        public static void loadListeDeps()
        {
            XmlSerializer XS = new XmlSerializer(ListeDepartement.GetType());
            try
            {
                StreamReader r_fileDeps = new StreamReader("Liste des departements.xml");
                ClsDepartement.ListeDepartement = (List<ClsDepartement>)XS.Deserialize(r_fileDeps);

            }
            catch (FileNotFoundException e)
            {
                ClsDepartement.ListeDepartement = new List<ClsDepartement>();
            }
        }

        public static void saveListeDeps()
        {
            XmlSerializer XS = new XmlSerializer(ListeDepartement.GetType());
            StreamWriter w_fileDeps = new StreamWriter("Liste des departements.xml");
            XS.Serialize(w_fileDeps, ListeDepartement);
        }
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
