using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centre_D_affaire.GestionCreche
{
     public class clsFacture
    {
        private int NumF;
        private DateTime DateF;
        private DateTime Datedecheance;
        private double MontantT;
        private string ModeR;

        public clsFacture() { }
        public clsFacture(int numf,DateTime datef,DateTime dateecheance,double montant,string modeR)
        {
            this.NumF1 = numf;
            this.DateF1 = datef;
            this.Datedecheance1 = dateecheance;
            this.MontantT1 = montant;
            this.ModeR1 = modeR;
        }

        public int NumF1 { get => NumF; set => NumF = value; }
        public DateTime DateF1 { get => DateF; set => DateF = value; }
        public DateTime Datedecheance1 { get => Datedecheance; set => Datedecheance = value; }
        public double MontantT1 { get => MontantT; set => MontantT = value; }
        public string ModeR1 { get => ModeR; set => ModeR = value; }
    }
}
