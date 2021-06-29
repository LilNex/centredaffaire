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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
           TXTmotPass.Enabled = false;
            gridUtilisateur.Visible = false; 
        }

        private void TXTadresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNfermer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void grid()
        {
            gridUtilisateur.Rows.Clear(); 
            for (int i =0; i <Listes.utilisateurs.Count; i++)
            {
                gridUtilisateur.Rows.Add();
                gridUtilisateur.Rows[i].Cells["Login"].Value = Listes.utilisateurs[i].NomUtilisateur;
                gridUtilisateur.Rows[i].Cells["MotPass"].Value = Listes.utilisateurs[i].MotPass;

            }
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Utilisateur m = new Utilisateur(TXTNOmUtilisateur.Text , TXTmotPass.Text ,"" ,"");



            if (m.Ajouter(m)== true)
            {
                MessageBox.Show(TXTNOmUtilisateur.Text + " ajouté avec succès", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grid();
                ClassInterface i = new ClassInterface();
                i.viderform(this);
                gridUtilisateur.Visible = true;

            }
            else
            {
                MessageBox.Show("Ajout non effectué, vérifiez que le ID  n'est pas en double", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
       


            }
            
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
           
            TXTmotPass.Text = CreatePassword(8);

        }
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        private void lblNomdutilisateur_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void TXTmotPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTNOmUtilisateur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
