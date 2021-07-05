using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centre_D_affaire.GestionCreche;

namespace Centre_D_affaire
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]  
        static void Main()
        {
            //pour afficher haut qualite du graphique du formulaire
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_departmnt.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsDepartement("1", "Restaurant", "hamza", "0666666666", "hamzafilahi@gmail.com"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_departmnt.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsDepartement("2", "Salle de sport", "mehdi saadi", "O66666666666", "mehdosaadi@gmail.com"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_departmnt.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsDepartement("3", "Salle de jeux ", "jelouane alae", "0666666666", "jelouanealae@gmail.com"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_departmnt.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsDepartement("4", "Crèche", "sfifa ihsane", "0666666666", "sfifa ihsane"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_departmnt.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsDepartement("5", "Parking", "fisly oussama", "0666666666", "fislyoussama@gmail.com"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_departmnt.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsDepartement("6", "Gestion personnel", "chaiq ismail", "0666666666", "chaiqismail@gmail.com"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_departmnt.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsDepartement("7", "Location salle et espace", "el fadil imad", "066666666", "elfadilimad@gmail.com"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_departmnt.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsDepartement("8", "Service achats", "walaa allam", "06666666", "walaaallam@gmail.com"));
            //-------------------------------------------------------------------------------------------------------------------------------
            //------------------CASABLANCA------------------------------------------------------------------------------------------------
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_fournisseur.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsFournisseur("GENEREUX BUREAU","+212598745632","genereuxbureau@gmail.com", "CASABLANCA/MAARIF", "KAMAL AYOUBI", "CASABLANCA"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_fournisseur.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsFournisseur("MEUBLE","+212522335049","meuble@gmail.com", "CASABLANCA/CASAANFA", "BLARBI AHMED", "CASABLANCA"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_fournisseur.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsFournisseur("DIAMANT UNIFORME","+212522335049","diamantunifrome@gmail.com", "CASABLANCA/AINSEBAA", "MERYEM LHLOU", "CASABLANCA"));
            //-----------------------------------RABAT------------------------------------------------
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_fournisseur.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsFournisseur("BUREAU FESTIVAL","+212523668899", "bureaufestival@gmail.com", "RABAT/HAY RIAD", "SAMIRA KADMIRI", "RABAT"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_fournisseur.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsFournisseur("GARDE MEUBLE","+212525664480", "gardemeuble@gmail.com", "RABAT/TAKADOUM", "BLAMINE TAHA", "RABAT"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_fournisseur.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsFournisseur("HONNETE UNIFORME","+212525905044","honneteuniforme@gmail.com", "RABAT/AGDAL", "SOFIA HARATI", "RABAT"));
            //----------------------------------TANGER-------------------------------------------------------------------------------------------------
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_fournisseur.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsFournisseur("RANGEER BUREAU","+212525607722", "rangerbureau@gmail.com", "TANGER/MEDINA", "SAMIR LYAKOUBI", "TANGER"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_fournisseur.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsFournisseur("GARDE MEUBLE","+212525867788", "gardemeuble@gmail.com", "TANGER/OLD CITY", "HAFID LYAMANI", "TANGER"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_fournisseur.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsFournisseur("HONNETE UNIFORME","+212525905044", "honneteuniforme@gmail.com", "TANGER/PORT", "SOFIA LYOUSSI", "TANGER"));
            //------------------------------------------------------------------------------------------------------------------------------------------
            //------------------------------------LISTE EMPLOYEE-------------------------------------------
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_employe.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsEmploye("1", "MESSAOUDI", "AMINE",0660620686, "aminemessaoudi@gmail.com", "RESPONSABLE COMMERCIAL","0000"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_employe.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsEmploye("2", "BOULIF", "SAFAA",0618475015, "boulifsafaa@gmail.com", "DIRECTRICE","0000"));
            Centre_D_affaire.AchatsLogistiquePatrimoine.ClsListe.List_employe.Add(new Centre_D_affaire.AchatsLogistiquePatrimoine.ClsEmploye("3", "ALLAM","WALAA",0617929719, "walaaallam@gmail.com","RESPONSABLE ACHAT","0000"));



            
            //Centre_D_affaire.AchatsLogistiquePatrimoine
            Application.Run(new Centre_D_affaire.AchatsLogistiquePatrimoine.General());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
