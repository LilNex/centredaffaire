using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire
{
    public static class Class1
    {
        public static void Showcontrol(System.Windows.Forms.Control control,System.Windows.Forms.Control panel1)
        {
            panel1.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panel1.Controls.Add(control);
        }

    }
}
