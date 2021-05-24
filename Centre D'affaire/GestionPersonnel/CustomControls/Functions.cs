using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;

namespace Centre_D_affaire.GestionPersonnel
{
    static class Functions
    {
        
        public static void clearForm(Control form) 
        { 
            foreach(Control x in form.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }
                if (x is RadioButton)
                {
                    ((RadioButton)x).Checked = false;
                }
                if (x is DataGridView)
                {
                    ((DataGridView)x).DataSource = null;
                }
                if (x is PictureBox)
                {
                    ((PictureBox)x).Image = null;
                }
                if (x.Controls.Count > 0)
                {
                    clearForm(x);
                }

            }
        }

        public static bool addPoste(List<clsPoste> ListePostes, clsPoste Poste)
        {
            for (int i = 0; i < ListePostes.Count; i++)
            {
                if (Poste.Num == ListePostes[i].Num)
                {
                    return false;
                }
            }
            ListePostes.Add(Poste);
            return true;
        }
        public static bool AjouterDepartement(ClsDepartement departement)
        {
            for (int i = 0; i < ClsDepartement.ListeDepartement.Count; i++)
            {
                if (departement.Num == ClsDepartement.ListeDepartement[i].Num)
                {
                    throw new DepartementNumExistantException();
                }
                else if (departement.Nom == ClsDepartement.ListeDepartement[i].Nom)
                {
                    throw new DepartementNomExistantException();
                }
            }
            ClsDepartement.ListeDepartement.Add(departement);
            ClsDepartement.saveListeDeps();
            return true;
        }

        public static List<clsPoste> getListPostes()
        {
            List<clsPoste> _listPoste = new List<clsPoste>();
            for (int i = 0; i < ClsDepartement.ListeDepartement.Count; i++)
            {
                //for (int y = 0; y < ClsDepartement.ListeDepartement[i].ListePoste.Count; y++)
                //{
                foreach (clsPoste poste in ClsDepartement.ListeDepartement[i].ListePoste)
                {
                    _listPoste.Add(poste);
                }
                //}
            }
            return _listPoste;
        }
        public static List<ClsEmploye> getListemployes()
        {
            List<ClsEmploye> _listEmployes = new List<ClsEmploye>();
            for (int i = 0; i < ClsDepartement.ListeDepartement.Count; i++)
            {
                for (int y = 0; y < ClsDepartement.ListeDepartement[i].ListePoste.Count; y++)
                {
                    foreach (ClsEmploye employe in ClsDepartement.ListeDepartement[i].ListePoste[y].listeDesEmployé)
                    {
                        _listEmployes.Add(employe);
                    }
                }
            }
            return _listEmployes;
        }

        public static void setFont(Control control)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile("\\GestionPersonnel\\Resources\\Fonts\\Poppins-Medium.ttf");

            //foreach (Control c in control.Controls)
            //{
            //    c.Font = new System.Drawing.Font(pfc.Families[0], 10, System.Drawing.FontStyle.Regular);
            //}
        }
    }
    
}
