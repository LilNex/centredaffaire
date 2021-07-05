using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Centre_D_affaire.GestionCafeRestaurant.Classes
{
    [Serializable]
    public class ClsList
    {
        public static List<ClsList> ListUsers = new List<ClsList>();
        
        private string nomC;
            private int phoneC;
            private string mdpC;
            
            public ClsList(string n, int p, string m)
            {
                this.NomC = n;
                this.PhoneC = p;
                this.MdpC = m;
            }

            public string NomC { get => nomC; set => nomC = value; }
            public int PhoneC { get => phoneC; set => phoneC = value; }
            public string MdpC { get => mdpC; set => mdpC = value; }
        public void charger()
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream fichierbin = new FileStream("User.txt", FileMode.OpenOrCreate);
            ListUsers = (List<ClsList>)f.Deserialize(fichierbin);
            fichierbin.Close();
        }
    }
        
       
    }

