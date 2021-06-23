using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    public partial class UCProfil : UserControl
    {
        private ClsEmploye emp;
        public ClsEmploye loggedUser { get => emp;
            set {
                if(!(value is null))
                {
                    emp = value;
                    lblName.Text = emp.Nom + " " + emp.Prenom;
                }
                
            } }

        public UCProfil()
        {
            InitializeComponent();
        }
    }
}
