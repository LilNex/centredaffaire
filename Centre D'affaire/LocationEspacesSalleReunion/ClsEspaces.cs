using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.LocationEspacesSalleReunion
{
    public enum EspaceType
    {
        Bureau, SalleReunion
    }

    [Serializable]
    public class ClsEspaces
    {
        private static List<ClsEspaces> listeEspaces = new List<ClsEspaces>();

        public ClsEspaces()
        {

        }
        private string nom;
        private string numero;
        private string adresse;
        private string ville;
        private int etage;
        private float montantloyeJour;
        private float montantloyeHeure;
        private EspaceType type;

        public string Nom { get => nom; set => nom = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Ville { get => ville; set => ville = value; }
        public int Etage { get => etage; set => etage = value; }
        public float MontantloyeJour { get => montantloyeJour; set => montantloyeJour = value; }
        public float MontantloyeHeure { get => montantloyeHeure; set => montantloyeHeure = value; }
        public EspaceType Type { get => type; set => type = value; }
        public static List<ClsEspaces> ListeEspaces { get => listeEspaces; set => listeEspaces = value; }

        public ClsEspaces(string nom, string numero, string adresse, string ville, int etage, float montantloye, EspaceType type)
        {
            this.Nom = nom;
            this.Numero = numero;
            this.Adresse = adresse;
            this.Ville = ville;
            this.Etage = etage;
            this.MontantloyeJour = montantloye;
            this.Type = type;

        }
        public static void SauvegarderEspaces()
        {
            FileStream readEspaceFile = new FileStream("Espaces.bin", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(readEspaceFile, ListeEspaces);
            readEspaceFile.Close();
        }

        public static List<ClsEspaces> ChargerEspaces()
        {
            FileStream writeEspaceFile = new FileStream("Espaces.bin", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                ListeEspaces = (List<ClsEspaces>)formatter.Deserialize(writeEspaceFile);
            }
            catch (Exception e)
            {
                ListeEspaces = new List<ClsEspaces>();

            }
            finally
            {
                writeEspaceFile.Close();
            }
            return ListeEspaces;


        }

        public override string ToString()
        {
            return this.Numero + " / " + this.Nom;
        }
    }

}
