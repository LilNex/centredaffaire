using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public partial class saisie : Form
    {
        public saisie()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = @"C:\Users\DELL\Desktop\Image";
            //o.Filter = "aaaa (*.jpeg)|*.jpeg | aaaa (*.png)|*.png | All files (*.*)|*.*";
            if( o.ShowDialog() == DialogResult.OK)
            {
                picb.Image = Image.FromFile(o.FileName);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            ArticleType type = ArticleType.Autre ;
            switch (comboBox1.SelectedItem)
            {
                case "Bureau":
                    type = ArticleType.Bureau;
                    break;
                case "Meuble":
                    type = ArticleType.Meuble;
                    break;
                case "Materiel sportif":
                    type = ArticleType.SalleSport;
                    break;
                case "Salle de jeux":
                    type = ArticleType.SalleJeux;
                    break;
                case "Cafe/restaurant":
                    type = ArticleType.Caferestaurant;
                    break;
                case "Crèche":
                    type = ArticleType.Crèche;
                    break;
                case "Uniforme":
                    type = ArticleType.Uniforme;
                    break;
                case "Service":
                    type = ArticleType.Service;
                    break;
                case "Autre":
                    type = ArticleType.Autre;
                    break;



            }
            ClsListe.chargerART(); 

            ClsArticle a = new ClsArticle(nom.Text,type,picb.Image);
            ClsListe.List_article.Add(a);


            ClsListe.sauvegardeArt();










        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void saisie_Load(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add("Bureau");
            comboBox1.Items.Add("Meuble");
            comboBox1.Items.Add("Materiel sportif");
            comboBox1.Items.Add("Salle de jeux");
            comboBox1.Items.Add("Cafe/restaurant");
            comboBox1.Items.Add("Crèche");
            comboBox1.Items.Add("Uniforme");
            comboBox1.Items.Add("Service");
            comboBox1.Items.Add("Autre");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Catalogue C = new Catalogue();
            C.Show();
        }
    }
}
