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
        private ClsEmploye manager;

        public string Num { get => num; set {
                if (value.Substring(0, 3).All(char.IsLetter) && value.Substring(3, 3).All(char.IsNumber)) {
                    num = value;
                }
                else
                {
                    throw new DepartementNumInvalideException();
                }

                } }
        // CONDITION format : XXX000
        public string Nom { get => nom; set => nom = value; }
        public List<clsPoste> ListePoste { get => listePoste; set => listePoste = value; }
        public int Id { get => id; set => id = value; }
        public ClsEmploye Manager { get => manager; set => manager = value; }

        public ClsDepartement(string nom, string num)
        {
            Nom = nom;
            Num = num;
        }
        public ClsDepartement(){}
        public int recherchePosteNum(string num)
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
        public static int rechercheDepNum(string num)
        {
            for (int i = 0; i < ClsDepartement.ListeDepartement.Count(); i++)
            {
                if (ListeDepartement[i].Num == num)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool AjouterPoste(clsPoste poste)
        {
            if (recherchePosteNum(poste.Num) != -1)
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

        public bool ModifierDepartement(ClsDepartement Dep)
        {
            if (recherchePosteNum(Dep.Num) != -1)
            {
                ListeDepartement[recherchePosteNum(Dep.Num)] = Dep; 
                saveListeDeps();
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<ClsEmploye> getListemployes()
        {
            List<ClsEmploye> _listEmployes = new List<ClsEmploye>();
            for (int i = 0; i < this.ListePoste.Count; i++)
            {
                

                    foreach (ClsEmploye employe in this.ListePoste[i].listeDesEmployé)
                    {
                        _listEmployes.Add(employe);
                    
                }
            }
            return _listEmployes;
        }


        public static void loadListeDeps()
        {
            XmlSerializer XS = new XmlSerializer(ListeDepartement.GetType());
            try
            {
                FileStream r_fileDeps = new FileStream("Liste des departements.xml", FileMode.Open, FileAccess.ReadWrite);
                ClsDepartement.ListeDepartement = (List<ClsDepartement>)XS.Deserialize(r_fileDeps);
                r_fileDeps.Close();

            }
            catch (FileNotFoundException e)
            {
                ClsDepartement.ListeDepartement = new List<ClsDepartement>();
            }
        }

        public static void saveListeDeps()
        {
            XmlSerializer XS = new XmlSerializer(ListeDepartement.GetType());
            FileStream w_fileDeps = new FileStream("Liste des departements.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XS.Serialize(w_fileDeps, ListeDepartement);
            w_fileDeps.Close();
        }
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
