using System;
using System.IO;

namespace Centre_D_affaire.GestionCreche
{
    internal class BinaryFormatter
    {
        public static implicit operator BinaryFormatter(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter v)
        {
            throw new NotImplementedException();
        }

        internal void Serialize(FileStream fichierBin, frmInscription frmEnfant)
        {
            throw new NotImplementedException();
        }
    }
}