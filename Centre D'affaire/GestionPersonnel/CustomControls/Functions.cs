using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Drawing;

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
        public static void setCellStyle(Control control)
        {
            foreach(object ctl in control.Controls)
            {
                if (ctl is DataGridView)
                {
                    DataGridView dgv = (DataGridView)ctl;
                    ((DataGridView)ctl).DefaultCellStyle.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            ((DataGridView)ctl).Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(159, 201, 243);
                        }
                        else
                        {
                            ((DataGridView)ctl).Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(207, 228, 249);
                        }
                    }
                    
                }
            }

            
        }
        
    }
    
}
