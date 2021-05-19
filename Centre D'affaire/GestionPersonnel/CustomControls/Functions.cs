using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionPersonnel.CustomControls
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
    }
}
