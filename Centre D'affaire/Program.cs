using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Centre_D_affaire.GestionSalleDeSport;
//using Centre_D_affaire.GestionSalleDeJeux;

namespace Centre_D_affaire
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            //pour afficher haut qualite du graphique du formulaire
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Centre_D_affaire.GestionSalleDeSport.btnSeconnecter());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
   