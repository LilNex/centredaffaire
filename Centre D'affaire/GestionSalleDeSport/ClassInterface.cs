using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionSalleDeSport
{
    class ClassInterface
    {
        public void viderform(Control f)
        {
            foreach (Control ctl in f.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = "";
                }

                if (ctl.Controls.Count > 0)
                {
                    viderform(ctl);
                }

            }
        }
    }
}
