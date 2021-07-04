using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace Centre_D_affaire.GestionPersonnel
{
    public enum EtatConge
    {
        Refusé,
        EnAttente,
        Validé
    }

    public enum TypeConge
    {
        CongéMaladie,
        CongéMaternité,
        CongéPayé,
        CongéDExamen,
        Congé,
    }
    public class Congé
    {
        public static List<Congé> ListeDesCongé = new List<Congé>();
        private DateTime dated;
        private DateTime datef;
        private int num;
        //private int nombrecongés;

        private int durée;
        private ClsEmploye employe;
        private TypeConge catégories;
        private EtatConge etat;

        public DateTime DateDebut { get => dated; set => dated = value; }
        public int Durée { get => durée; set => durée = value; }
        public ClsEmploye Employe { get => employe; set => employe = value; }
        public TypeConge Catégories { get => catégories; set => catégories = value; }
        public EtatConge Etat { get => etat; set => etat = value; }
        public DateTime DateFin { get => datef; set => datef = value; }
        public int Num { get => num; set => num = value; }

        public Congé() { }
        public Congé(DateTime d, int duré, TypeConge ca)    
        {
            this.num = getMaxId();
            this.dated = d;
            this.datef = d.AddDays(duré);
            this.durée = duré;
            this.catégories = ca;
            this.etat= EtatConge.EnAttente;
        }
        public int rechercher(int num)
        {
            for (int i = 0; i < ListeDesCongé.Count(); i++)
            {
                if (ListeDesCongé[i].num == num)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool ajouter (Congé G)
        {
            if(rechercher(G.num) == -1)
            {
                ListeDesCongé.Add(G);
                return true;
            }
            return false;                
        }
        public void supprimer(int num)
        {
            if (rechercher(num) != -1)
            {
                ListeDesCongé.RemoveAt(rechercher(num));
                
            }
            
        }
        public int getMaxId()
        {
            int x = 0;
            foreach(Congé c in ListeDesCongé)
            {
                if(c.Num > x)
                {
                    x = c.Num;
                }
            }
            return x + 1;
        }
        public static void loadListeConges()
        {
            XmlSerializer XS = new XmlSerializer(ListeDesCongé.GetType());
            try
            {
                FileStream r_fileConge = new FileStream("Liste des Congés.xml", FileMode.Open, FileAccess.ReadWrite);
                ListeDesCongé = (List<Congé>)XS.Deserialize(r_fileConge);
                r_fileConge.Close();

            }
            catch (FileNotFoundException e)
            {
                ListeDesCongé = new List<Congé>();
            }
        }

        public static void saveListeConge()
        {
            XmlSerializer XS = new XmlSerializer(ListeDesCongé.GetType());
            FileStream w_fileDemission = new FileStream("Liste des Congés.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XS.Serialize(w_fileDemission, ListeDesCongé);
            w_fileDemission.Close();
        }
    }
}
