using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace Centre_D_affaire.GestionPersonnel
{
    public enum EtatDemission
    {
        Refusé,
        EnAttente,
        Validé
    }
    public class Demission
    {
        public static List<Demission> ListeDesDemission = new List<Demission>();
        private DateTime date;
        private int num;
        private ClsEmploye employe;
        private string raison;
        private EtatDemission etat;
        public DateTime Date { get => date; set => date = value; }

        public EtatDemission Etat { get => etat; set => etat = value; }
        public string Raison { get => raison; set => raison = value; }
        public ClsEmploye Employe { get => employe; set => employe = value; }
        public int Num { get => num; set => num = value; }

        public Demission() { }
        public Demission(DateTime d, string Raison/*ClsEmploye emp*/)
        {
           
            this.Num = num;
            this.date = d;       
            this.raison = Raison;
            //this.Employe = emp;
            this.etat = EtatDemission.EnAttente;
        }
        public int rechercher(int num)
        {
            for (int i = 0; i < ListeDesDemission.Count(); i++)
            {
                if (ListeDesDemission[i].num == num)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool ajouter(Demission G)
        {
            if (rechercher(G.num) == -1)
            {
                ListeDesDemission.Add(G);
                return true;
            }
            return false;
        }
        public void supprimer(int num )
        {
            if (rechercher(num) != -1)
            {
                ListeDesDemission.RemoveAt(rechercher(num));

            }

        }
        public int getMaxId()
        {
            int x = 0;
            foreach (Demission c in ListeDesDemission)
            {
                if (c.Num > x)
                {
                    x = c.Num;
                }
            }
            return x + 1;
        }
        public static void loadListeDemission()
        {
            XmlSerializer XS = new XmlSerializer(ListeDesDemission.GetType());
            try
            {
                FileStream r_fileDemission = new FileStream("Liste des Demissions.xml", FileMode.Open, FileAccess.ReadWrite);
                ListeDesDemission = (List<Demission>)XS.Deserialize(r_fileDemission);
                r_fileDemission.Close();

            }
            catch (FileNotFoundException e)
            {
                ListeDesDemission = new List<Demission>();
            }
        }

        public static void saveListeDemission()
        {
            XmlSerializer XS = new XmlSerializer(ListeDesDemission.GetType());
            FileStream w_fileDemission = new FileStream("Liste des Demissions.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XS.Serialize(w_fileDemission, ListeDesDemission);
            w_fileDemission.Close();
        }
    }
}
