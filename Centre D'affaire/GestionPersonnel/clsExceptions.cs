using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionPersonnel
{
    public class DepartementException : ApplicationException
    {
        public DepartementException(string Message) : base("Erreur département : " + Message) { }
    }

    public class DepartementNumInvalideException : DepartementException
    {
        public DepartementNumInvalideException() : base("Le numéro du département est invalide") { }
    }
    public class DepartementNomInvalideException : DepartementException
    {
        public DepartementNomInvalideException() : base("Le nom du département est invalide") { }
    }
    public class DepartementNumExistantException : DepartementException
    {
        public DepartementNumExistantException() : base("Le numéro du département existant") { }
    }
    public class DepartementNomExistantException : DepartementException
    {
        public DepartementNomExistantException() : base("Le nom du département existant") { }
    }
    public class PosteException : ApplicationException
    {
        public PosteException(string Message) : base("Erreur Poste : ") { }
    }

    public class PosteNumInvalideException : PosteException
    {
        public PosteNumInvalideException() : base("Le numéro du Poste est invalide") { }
    }
    public class PosteNomInvalideException : PosteException
    {
        public PosteNomInvalideException() : base("Le nom du Poste est invalide") { }
    }
    public class PosteNumExistantException : PosteException
    {
        public PosteNumExistantException() : base("Le numéro du Poste existant") { }
    }
    public class PosteNomExistantException : PosteException
    {
        public PosteNomExistantException() : base("Le nom du Poste existant") { }
    }
}
