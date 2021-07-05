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
            //-------------------------------------------------------------------------------------------------------------------------------
            //------------------CASABLANCA------------------------------------------------------------------------------------------------
            ClsListe.List_fournisseur.Add(new ClsFournisseur("GENEREUX BUREAU","+212598745632","genereuxbureau@gmail.com", "CASABLANCA/MAARIF", "KAMAL AYOUBI", "CASABLANCA"));
            ClsListe.List_fournisseur.Add(new ClsFournisseur("MEUBLE","+212522335049","meuble@gmail.com", "CASABLANCA/CASAANFA", "BLARBI AHMED", "CASABLANCA"));
            ClsListe.List_fournisseur.Add(new ClsFournisseur("DIAMANT UNIFORME","+212522335049","diamantunifrome@gmail.com", "CASABLANCA/AINSEBAA", "MERYEM LHLOU", "CASABLANCA"));
            //-----------------------------------RABAT------------------------------------------------
            ClsListe.List_fournisseur.Add(new ClsFournisseur("BUREAU FESTIVAL","+212523668899", "bureaufestival@gmail.com", "RABAT/HAY RIAD", "SAMIRA KADMIRI", "RABAT"));
            ClsListe.List_fournisseur.Add(new ClsFournisseur("GARDE MEUBLE","+212525664480", "gardemeuble@gmail.com", "RABAT/TAKADOUM", "BLAMINE TAHA", "RABAT"));
            ClsListe.List_fournisseur.Add(new ClsFournisseur("HONNETE UNIFORME","+212525905044","honneteuniforme@gmail.com", "RABAT/AGDAL", "SOFIA HARATI", "RABAT"));
            //----------------------------------TANGER-------------------------------------------------------------------------------------------------
            ClsListe.List_fournisseur.Add(new ClsFournisseur("RANGEER BUREAU","+212525607722", "rangerbureau@gmail.com", "TANGER/MEDINA", "SAMIR LYAKOUBI", "TANGER"));
            ClsListe.List_fournisseur.Add(new ClsFournisseur("GARDE MEUBLE","+212525867788", "gardemeuble@gmail.com", "TANGER/OLD CITY", "HAFID LYAMANI", "TANGER"));
            ClsListe.List_fournisseur.Add(new ClsFournisseur("HONNETE UNIFORME","+212525905044", "honneteuniforme@gmail.com", "TANGER/PORT", "SOFIA LYOUSSI", "TANGER"));
            //------------------------------------------------------------------------------------------------------------------------------------------
            //------------------------------------LISTE EMPLOYEE-------------------------------------------
            ClsListe.List_employe.Add(new ClsEmploye("1", "MESSAOUDI", "AMINE",0660620686, "aminemessaoudi@gmail.com", "RESPONSABLE COMMERCIAL","0000"));
            ClsListe.List_employe.Add(new ClsEmploye("2", "BOULIF", "SAFAA",0618475015, "boulifsafaa@gmail.com", "DIRECTRICE","0000"));
            ClsListe.List_employe.Add(new ClsEmploye("3", "ALLAM","WALAA",0617929719, "walaaallam@gmail.com","RESPONSABLE ACHAT","0000"));

            Application.Run(new Catalogue());

            
            
        }
    }
}
