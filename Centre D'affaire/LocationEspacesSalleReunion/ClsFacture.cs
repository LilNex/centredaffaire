using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Centre_D_affaire.LocationEspacesSalleReunion
{
    [Serializable]
    public class ClsFacture
    {
        private static List<ClsFacture> listeFactures = new List<ClsFacture>();
        public static List<ClsFacture> ListeFactures { get => listeFactures; set => listeFactures = value; }




        private int numero;
        private DateTime dateFacturation;
        private double montantFacturation;

        private ClsLocation location;

        public int Numero { get => numero; set => numero = value; }
        public DateTime DateFacturation { get => dateFacturation; set => dateFacturation = value; }
        public double MontantFacturation { get => montantFacturation; set => montantFacturation = value; }
        public ClsLocation Location { get => location; set => location = value; }
    
        public ClsFacture() { }
        public ClsFacture(ClsLocation location)
        {
            this.Numero = getMaxID();
            this.DateFacturation = DateTime.Now;
            this.MontantFacturation = location.CalculMontantFinal();
            this.Location = location;
              
        }

        public static bool FacturerLocation(ClsLocation l)
        {
            ClsFacture facture = new ClsFacture(l);
            ListeFactures.Add(facture);
            ClsLocation.ListeLocations.Remove(l);
            SauvegarderArchive();
            ClsLocation.SauvegarderLocations();
            return true;
        }

        public static void SauvegarderArchive()
        {
            FileStream writeFacturationFile = new FileStream("Factures.bin", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeFacturationFile, ListeFactures);
            writeFacturationFile.Close();
        }
        public static List<ClsFacture> ChargerArchive()
        {
            FileStream readLocationFile = new FileStream("Factures.bin", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                ListeFactures = (List<ClsFacture>)formatter.Deserialize(readLocationFile);
            }
            catch (Exception e)
            {
                ListeFactures = new List<ClsFacture>();
            }
            finally
            {
                readLocationFile.Close();
            }
            return ListeFactures;


        }

        public static int getMaxID()
        {
            int id = 0;
            foreach(ClsFacture f in ListeFactures)
            {
                if (f.Numero > id)
                {
                    id = f.Numero;
                }
            }
            return id + 1;
        }
    }
}
