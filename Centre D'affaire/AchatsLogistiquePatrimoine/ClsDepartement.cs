﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
   

    public class ClsDepartement
    {
        private string email;
        private string nom_demandeur;
        private string telephone;
        private string numero_departement;
        private string nom_departement;

        public string Numero_service { get => numero_departement; set => numero_departement = value; }
        public string Nom_service { get => nom_departement; set => nom_departement = value; }
        public string Email { get => email; set => email = value; }
        public string Nom_demandeur { get => nom_demandeur; set => nom_demandeur = value; }
        public string Telephone { get => telephone; set => telephone = value; }

        public ClsDepartement() { }

        public ClsDepartement( string numerodepartement , string nomdepartement)
        {
            this.numero_departement =numerodepartement ;
            this.nom_departement = nomdepartement ;

        }





    }
}
