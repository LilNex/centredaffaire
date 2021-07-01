using System;
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
    public partial class UCGestionPaiment : UserControl
    {
        public UCGestionPaiment()
        {
            InitializeComponent();
        }

        public void grid()
        {
            GridPaiment.Rows.Clear();
            for (int i = 0; i < Listes.paiment.Count; i++)
            {
                GridPaiment.Rows.Add();
                GridPaiment.Rows[i].Cells["ID"].Value = Listes.paiment[i].membres1.Id;
                GridPaiment.Rows[i].Cells["Frais"].Value = Listes.paiment[i].membres1.Frais;
                GridPaiment.Rows[i].Cells["Total"].Value = Listes.paiment[i].membres1.Total;
                GridPaiment.Rows[i].Cells["Date"].Value = Listes.paiment[i].membres1.DateJoin;
                GridPaiment.Rows[i].Cells["Duree"].Value = Listes.paiment[i].membres1.Duree;
                GridPaiment.Rows[i].Cells["Nom"].Value = Listes.paiment[i].membres1.NomComplet;
                GridPaiment.Rows[i].Cells["Paiment1"].Value = Listes.paiment[i].Paiement1;
              

            }


        }

        private void UCpaiment_Load(object sender, EventArgs e)
        {
            TXTnumero.Enabled = false;
            TXTtotal.Enabled = false;
            TXTDUREE.Enabled = false;
            TxtFrais.Enabled = false;
            grid(); 
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Package p = new Package(); 
            Membre f = new Membre(TXTnumero.Text, Cbnom.Text, DPdate.Value, "" , "", "", "", p,1 , int.Parse(TxtFrais.Text), int.Parse(TXTDUREE.Text), int.Parse(TXTtotal.Text), "" , Properties.Resources.image);
            Paiement m = new Paiement(f,txtpaiment.Text);
            Listes.paiment.Add(m);
            grid();
        }

        private void Cbnom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbnom_Click(object sender, EventArgs e)
        {
            Cbnom.DataSource = Listes.MembresListe;
            Cbnom.ValueMember = "NomComplet";
            Cbnom.DisplayMember = "NomComplet";
        }

        private void Cbnom_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Listes.MembresListe.Count; i++)
            {
                if (Listes.MembresListe[i].NomComplet == Cbnom.Text)
                {
                    TXTnumero.Text = Listes.MembresListe[i].Id;
                    TXTDUREE.Text = Listes.MembresListe[i].Duree.ToString();
                    TxtFrais.Text = Listes.MembresListe[i].Frais.ToString();
                    TXTtotal.Text = Listes.MembresListe[i].Total.ToString();

                }
            }
        }
    }
}
