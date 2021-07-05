using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    [Serializable]
    public class ClsListe
    {
        public static List<CHOIX> List_choix = new List<CHOIX>();

        public static List<ClsEmploye> List_employe = new List<ClsEmploye>();

        public static List<ClsFournisseur> List_fournisseur = new List<ClsFournisseur>();

        public static List<ClsArticle> List_article = new List<ClsArticle>();

        public static List<ClsCommande> List_commande = new List<ClsCommande>();

        public static List<ClsDemande> List_demande = new List<ClsDemande>();

        public static List<ClsFacture> List_facture = new List<ClsFacture>();

        public static List<ListeCategorie> List_categorie = new List<ListeCategorie>();

        public static List<ClsDepartement> List_departmnt = new List<ClsDepartement>();


        //public void remplirDepartemnt()
        //{
        //    List_demande.Add()
        //}


        public static void sauvegardeArt()
        {

            BinaryFormatter f = new BinaryFormatter();
            FileStream fichierbin = new FileStream(@"..\..\Resources\Article", FileMode.OpenOrCreate);
            f.Serialize(fichierbin, List_article);
            fichierbin.Close();
        }

        public static void chargerART()
        {
            BinaryFormatter f = new BinaryFormatter();
            //FileStream fichierbin = new FileStream("Article", FileMode.OpenOrCreate);
            MemoryStream fichierbin = new MemoryStream(Centre_D_affaire.Properties.Resources.Article1);


            List_article = (List<ClsArticle>)f.Deserialize(fichierbin);
            fichierbin.Close();

        }

        //charger article selon type
        public static List<ClsArticle> getlisteART(ArticleType l)
        {
            List<ClsArticle> la = new List<ClsArticle>();
            for (int i = 0; i < List_article.Count; i++)
            {
                if (List_article[i].TypeArticle == l)
                {
                    la.Add(List_article[i]);
                }
            }
            return la;
        }


        public static void sauvegardeDEMANDE()
        {
            BinaryFormatter f = new BinaryFormatter();
            FileStream fichierbin = new FileStream("demande", FileMode.OpenOrCreate);
            f.Serialize(fichierbin, List_demande);
            fichierbin.Close();
        }

        public static void chargerDEMANDE()
        {
            FileStream fichierbin = new FileStream("demande", FileMode.OpenOrCreate);

            try
            {
                BinaryFormatter f = new BinaryFormatter();
                List_demande = (List<ClsDemande>)f.Deserialize(fichierbin);

                fichierbin.Close();

            }
            catch (System.Runtime.Serialization.SerializationException e)
            {
                ClsListe.List_demande = new List<ClsDemande>();
            }
            finally { fichierbin.Close(); }

        }


        //public static void sauvegardeDMD()
        //{


        //        XmlSerializer xs = new XmlSerializer(ClsListe.List_demande.GetType());
        //        using (StreamWriter wr = new StreamWriter("demande.xml"))
        //        {
        //            xs.Serialize(wr, ClsListe.List_demande);
        //        }



        //}

        //public static void chargerDMD()
        //{
        //    try
        //    {
        //        XmlSerializer xs = new XmlSerializer(ClsListe.List_demande.GetType());
        //        using ( StreamReader rd = new StreamReader("demande.xml") )
        //        {
        //            xs.Deserialize(rd);

        //        }
        //    }
        //    catch(FileNotFoundException e)
        //    {
        //        ClsListe.List_demande = new List<ClsDemande>();
        //    }





        //}



    }
    
}

          





