using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centre_D_affaire.AchatsLogistiquePatrimoine;

namespace Centre_D_affaire
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]  
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ClsListe.List_departmnt.Add(new ClsDepartement("1", "Restaurant", "hamza", "0666666666", "hamzafilahi@gmail.com"));
            ClsListe.List_departmnt.Add(new ClsDepartement("2", "Salle de sport", "mehdi saadi", "O66666666666", "mehdosaadi@gmail.com"));
            ClsListe.List_departmnt.Add(new ClsDepartement("3", "Salle de jeux ", "jelouane alae", "0666666666", "jelouanealae@gmail.com"));
            ClsListe.List_departmnt.Add(new ClsDepartement("4", "Crèche", "sfifa ihsane", "0666666666", "sfifa ihsane"));
            ClsListe.List_departmnt.Add(new ClsDepartement("5", "Parking", "fisly oussama", "0666666666", "fislyoussama@gmail.com"));
            ClsListe.List_departmnt.Add(new ClsDepartement("6", "Gestion personnel", "chaiq ismail", "0666666666", "chaiqismail@gmail.com"));
            ClsListe.List_departmnt.Add(new ClsDepartement("7", "Location salle et espace", "el fadil imad", "066666666", "elfadilimad@gmail.com"));
            ClsListe.List_departmnt.Add(new ClsDepartement("8", "Service achats", "walaa allam", "06666666", "walaaallam@gmail.com"));


            Application.Run(new saisie());

            
            
        }
    }
}
