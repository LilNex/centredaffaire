﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.GestionCreche
{
    public partial class frmGroupe : Form
    {
        public void RemplirGridEnfant()
        {
            dgvGroupe.Rows.Clear();

            for (int i = 0; i < clsListe.listeGroupe.Count; i++)
            {
                dgvGroupe.Rows.Add();

                dgvGroupe.Rows[i].Cells["Column1"].Value = clsListe.listeGroupe[i].NumG;
                dgvGroupe.Rows[i].Cells["Column2"].Value = clsListe.listeGroupe[i].NomG;


            }
        }

        public frmGroupe()
        {
            InitializeComponent();
        }
        

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            interfaces f = new interfaces();
            f.viderform(this);
        }

        private void btnNouveau_Click_1(object sender, EventArgs e)
        {
            
                interfaces f = new interfaces();
                f.viderform(this);
          
        }

        private void frmGroupe_Load(object sender, EventArgs e)
        {

        }

       

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            foreach( DataGridViewRow row in dgvGroupe.SelectedRows)
            {
                dgvGroupe.Rows.RemoveAt(row.Index);

            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
