﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionSalleDeSport
{
    public partial class UCgetionAchats : UserControl
    {
        public UCgetionAchats()
        {
            InitializeComponent();
        }

        private void TXTtele_TextChanged(object sender, EventArgs e)
        {

        }

        private void DPdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GB2_Enter(object sender, EventArgs e)
        {

        }

        private void btntrouver_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Listes.VendeursListe.Count; i++)
            {
                if (Listes.VendeursListe[i].Id == TXTnomcomplet.Text)
                {
                    TXTtele.Text = Listes.VendeursListe[i].Telephone.ToString() ;
                    bunifuTextBox3.Text = Listes.VendeursListe[i].NomComplet;
                }
            }
        }
    }
}