using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Drawing;
using Centre_D_affaire.GestionPersonnel;

namespace Centre_D_affaire.GestionPersonnel
{
    class Functions
    {
        private static PrivateFontCollection pfc = new PrivateFontCollection();
        
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
            ClsDepartement.saveListeDeps();
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
            ClsDepartement.loadListeDeps();
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
            //pfc.AddFontFile(Path.Combine(Application.StartupPath, "..\\..\\GestionPersonnel\\Resources\\Fonts\\Poppins\\Poppins-Regular.ttf"));
            pfc.AddFontFile(Path.Combine(Application.StartupPath, "..\\..\\GestionPersonnel\\Resources\\Fonts\\Poppins\\Poppins-Regular.ttf"));
            //pfc.AddFontFile("Poppins-Regular.ttf");

            foreach (Control c in control.Controls)
            {
                if (c is Bunifu.Framework.UI.BunifuFlatButton)
                {
                    ((Bunifu.Framework.UI.BunifuFlatButton)c).TextFont = new Font(pfc.Families[0], ((Bunifu.Framework.UI.BunifuFlatButton)c).TextFont.Size, ((Bunifu.Framework.UI.BunifuFlatButton)c).Font.Style);
                    
                }
                else if(c is DataGridView)
                {
                    ((DataGridView)c).ColumnHeadersDefaultCellStyle.Font = new Font(pfc.Families[0], /*((DataGridView)c).ColumnHeadersDefaultCellStyle.Font.Size*/12, ((DataGridView)c).Font.Style) ;
                }
                else if(c is ComboBox)
                {
                    ((ComboBox)c).Font = new System.Drawing.Font(pfc.Families[0], 10, c.Font.Style);
                }

                else if (!(c is TextBox || c is Bunifu.Framework.UI.BunifuDatepicker))
                {
                    c.Font = new System.Drawing.Font(pfc.Families[0], c.Font.Size, c.Font.Style);
                    //if(c.Font.Size < 10)
                    //{
                    //    c.BringToFront();
                    //}
                } 
                
                
                if (c.Controls.Count > 0)
                {
                    setFont(c);
                }
            }
        }
        public static void setCellStyle(Control control)
        {
            pfc.AddFontFile(Path.Combine(Application.StartupPath, "..\\..\\GestionPersonnel\\Resources\\Fonts\\Poppins\\Poppins-Regular.ttf"));
            foreach (Control ctl in control.Controls)
            {
                if (ctl is DataGridView)
                {
                    ((DataGridView)ctl).BorderStyle = BorderStyle.None;
                    ((DataGridView)ctl).CellBorderStyle = DataGridViewCellBorderStyle.None;
                    ((DataGridView)ctl).DefaultCellStyle.Font = new System.Drawing.Font(pfc.Families[0], 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    for (int i = 0; i < ((DataGridView)ctl).Rows.Count; i++)
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
                if(ctl.Controls.Count > 0)
                {
                    setCellStyle(ctl);
                }
            }

            
        }
        
        public static void setupDgv (Control control)
        {
            foreach (Control ctl in control.Controls)
            {
                if (ctl is DataGridView)
                {
                    ((DataGridView)ctl).DataSourceChanged += Functions.Functions_DataSourceChanged;
                }
                if (ctl.Controls.Count > 0)
                {
                    setupDgv(ctl);
                }
            }
        }

        public static void Functions_DataSourceChanged(object sender, EventArgs e)
        {
            pfc.AddFontFile(Path.Combine(Application.StartupPath, "..\\..\\GestionPersonnel\\Resources\\Fonts\\Poppins\\Poppins-Regular.ttf"));
            if (sender is DataGridView)
            {
                ((DataGridView)sender).BorderStyle = BorderStyle.None;
                ((DataGridView)sender).CellBorderStyle = DataGridViewCellBorderStyle.None;
                ((DataGridView)sender).DefaultCellStyle.Font = new System.Drawing.Font(pfc.Families[0], 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                for (int i = 0; i < ((DataGridView)sender).Rows.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        ((DataGridView)sender).Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(159, 201, 243);
                    }
                    else
                    {
                        ((DataGridView)sender).Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(207, 228, 249);
                    }
                }

            }
        }
        public static ClsEmploye login(string user, string mdp)
        {
            foreach(ClsEmploye emp in getListemployes())
            {
                if (emp.Userlogin == user && emp.Mdp == mdp)
                {
                    return emp;
                }
            }
            return null;

        }
        public static Stream ToStream(string str)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(str);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
    
}
