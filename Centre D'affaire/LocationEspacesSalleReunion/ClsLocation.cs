using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Centre_D_affaire.LocationEspacesSalleReunion
{
    [Serializable]
    public enum LocationType
    {
        Heure,
        Jour
    }

    [Serializable]

    public class ClsLocation
    {
        private static List<ClsLocation> listeLocations = new List<ClsLocation>();

        private DateTime dateDebut;
        private DateTime dateFin;
        private DateTime heureDebut;
        private DateTime heureFin;
        private ClsEspaces espace;
        private ClsLocataire locataire;
        private LocationType type;

        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        public string HeureDebut { get => DateDebut.ToString("t");}
        public string HeureFin { get => DateFin.ToString("t");}

        public double DureeTotalHeure
        {
            get
            {
                return Math.Round(getDureeLocation().TotalHours,2);
            }
        }
        public double DureeTotalJour
        {
            get
            {
                return Math.Round(getDureeLocation().TotalDays,1);
            }
        }

        public ClsEspaces Espace { get => espace; set { 
                if(value == null)
                {
                    throw new NotImplementedException("Espace non choisi.");
                }
                else
                {
                    espace = value;
                }
            }
        }
        public ClsLocataire Locataire { get => locataire; set => locataire = value; }
        public static List<ClsLocation> ListeLocations { get => listeLocations; set => listeLocations = value; }
        public LocationType Type { get => type; set => type = value; }

        public ClsLocation() { }
        public ClsLocation(ClsEspaces espace,ClsLocataire locataire,DateTime DateDebut, DateTime DateFin, LocationType type) {
            
            if(DateDebut > DateFin)
            {
                throw new NotImplementedException("Date Invalide.");

            }
            else if(DateDebut < DateTime.Now)
            {
                throw new NotImplementedException("Date deja passé.");

            }
            else
            {
                this.DateDebut = DateDebut;
                this.DateFin = DateFin;
                this.Espace = espace;
                this.Locataire = locataire;
                this.Type = type;
            }
            
        }

        public static DateTime ChangeTime(DateTime dateTime, int hours, int minutes, int seconds = 0, int milliseconds = 0)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, hours, minutes, seconds, milliseconds, dateTime.Kind);
        }

        
        public bool verifierDisponibilité()
        {
            foreach(ClsLocation location in ListeLocations)
            {
                if (this.Espace.Numero == location.Espace.Numero)
                {
                    if (this.DateDebut > location.DateDebut && this.DateFin < location.DateFin)
                    {
                        return false;
                    }
                    else if (this.DateDebut < location.DateDebut && this.DateFin > location.DateFin)
                    {
                        return false;

                    }
                    else if (this.DateDebut < location.DateFin && this.DateDebut > location.DateDebut )
                    {
                        return false;

                    }
                }
            }
            return true;
        }

        public TimeSpan getDureeLocation()
        {
            return this.DateFin - this.DateDebut;
        }

        public double CalculMontantFinal()
        {
            if (this.type == LocationType.Heure)
            {
                return Math.Round(Espace.MontantloyeHeure * this.DureeTotalHeure, 2);
            }
            else if (this.type == LocationType.Jour)
            {
                return Math.Round(Espace.MontantloyeJour * this.DureeTotalJour, 2);

            }
            else return 0;
        }

        public static void SauvegarderLocations()
        {
            FileStream readLocationFile = new FileStream("Locations.bin", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(readLocationFile, ListeLocations);
            readLocationFile.Close();
        }
        public static List<ClsLocation> ChargerLocations()
        {
            FileStream writeLocationFile = new FileStream("Locations.bin", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                ListeLocations = (List<ClsLocation>)formatter.Deserialize(writeLocationFile);
            }
            catch (Exception e)
            {
                ListeLocations = new List<ClsLocation>();

            }
            finally
            {
                writeLocationFile.Close();
            }
            return ListeLocations;


        }

        public override string ToString()
        {
            return String.Format("{0} {1} / {2}",  Locataire.Nom, Locataire.Prenom, Espace.Nom);
        }
    }
    
}
