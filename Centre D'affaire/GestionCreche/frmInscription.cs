using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;

namespace Centre_D_affaire.GestionCreche
{
    public partial class frmInscription : Form
    {
        public frmInscription()
        {
            InitializeComponent();
        }
        ADO d = new ADO();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "HafsaFile(*.Hafsa)*|bureau files|*.bureau|all files(*.*)|*.*|";
                if (dialog.ShowDialog()== System.Windows.Forms.DialogResult.OK)
                {

                    picimage.ImageLocation = dialog.FileName;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error Accord", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
            
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if ((txtNom.Text == "" || txtProfession.Text == "" || txtTelephone.Text == "" || txtDepartement.Text == "" || txtNomEN.Text == "" || txtAge.Text == ""|| txtDad.Text==""|| txtDN.Text==""))
            {
                MessageBox.Show("ATTENTION !! Une information est vide");
            }
            else
            {
                try
                {

                   string[] t =new string[] { txtNom.Text, txtProfession.Text, txtTelephone.Text, txtDepartement.Text, txtNomEN.Text, txtAge.Text };
                    this.txtNom.Text = "";
                    this.txtNom.Clear();
                    this.txtProfession.Clear();
                    this.txtDepartement.Clear();
                    this.txtNomEN.Clear();
                    this.txtTelephone.Clear();
                    this.txtAge.Clear();
                    this.txtDN.Clear();
                    this.txtDad.Clear();
                    ListViewItem IS = new ListViewItem(t);
                    listView1.Items.Add(IS);
                }
                catch (FormatException)
                {
                    MessageBox.Show("invalide!!");
                }
               



            }
        }

        private void frmInscription_Load(object sender, EventArgs e)
        {
            frmInscription IN = new frmInscription();
            
            FrmAccul accul = new FrmAccul();
            accul.Hide();
            IN.BringToFront();
            this.Hide();


            //StreamReader sr = new StreamReader("inscription.txt");
            //string ligne = string.Empty;
            //while ((ligne =sr.ReadLine()) != null)
            //{
            //    string[] t = ligne.Split();
            //    ListViewItem it = new ListViewItem(t);
            //    listView1.Items.Add(it);


            //}
            //sr.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor= Color.FromArgb(50, 0, 0, 0);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAccul accul = new FrmAccul();
            accul.Show();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            
        }
        public void sauvegarder(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter("inscription.txt", false);
            foreach (ListViewItem li in listView1.Items)
            {
                sr.WriteLine(li.SubItems[0].Text + li.SubItems[1].Text + li.SubItems[2].Text + li.SubItems[3].Text + li.SubItems[4].Text + li.SubItems[5].Text + li.SubItems[6].Text + li.SubItems[7].Text);
            }
            sr.Close();
            

        }
    }
}
