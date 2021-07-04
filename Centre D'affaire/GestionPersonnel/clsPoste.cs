using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionPersonnel
{
    public class clsPoste
    {
        private string nom;
        private string num;
        public List<ClsEmploye> listeDesEmployé = new List<ClsEmploye>();

        public string Num
        {
            get => num; set
            {
                if (value.Substring(0, 3).All(char.IsLetter) && value.Substring(3, 3).All(char.IsNumber))
                {
                    num = value;
                }
                else
                {
                    throw new PosteNumInvalideException();
                }

            }
        }
        public string Nom { get => nom; set => nom = value; }

        public clsPoste(string nom, string num)
        {
            this.nom = nom;
            this.num = num;
        }
        public clsPoste() { }
        public  int rechercheEmployeNum(string num)
        {
            for (int i = 0; i < listeDesEmployé.Count(); i++)
            {
                if (listeDesEmployé[i].Num == num)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool ajouterEmploye(ClsEmploye p)
        {
            if (rechercheEmployeNum(p.Num) != -1)
            {
                return false;
            }
            else
            {

                listeDesEmployé.Add(p);
                return true;
            }
        }
        public override string ToString()
        {
            return this.Nom;
        }

    }
}
