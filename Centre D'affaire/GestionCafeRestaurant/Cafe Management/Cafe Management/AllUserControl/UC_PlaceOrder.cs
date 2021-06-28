using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;

namespace Cafe_Management.AllUserControl
{

    //public class ClsObjet
    //{
    //    private string nomA;
    //    private float prixA;
    //    private string categorieA;

    //    public ClsObjet(string nom, float prix, string categorie)
    //    {
    //        this.NomA = nom;
    //        this.PrixA = prix;
    //        this.CategorieA = categorie;
    //    }

    //    public string NomA { get => nomA; set => nomA = value; }
    //    public float PrixA { get => prixA; set => prixA = value; }
    //    public string CategorieA { get => categorieA; set => categorieA = value; }
    //}
    //public class ClsList
    //{
    //    //public static List<ClsEmployes> ListEmployes = new List<ClsEmployes>();
    //    public static List<ClsObjet> ListArticle = new List<ClsObjet>();
    //    //public static List<ClsCategorie> ListeCategorie = new List<ClsCategorie>();

    //}
    public partial class UC_PlaceOrder : UserControl
    {


        //function fn = new function();
        //String query;
        public UC_PlaceOrder()
        {

            InitializeComponent();
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String category = comboCategory.Text;
            //query = "select name from item where category ='"+category+"'";
            //ShowItemList(query);
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //String category = comboCategory.Text;
            //query = "select name from item where category ='" + category + "' and name like '"+txtSearch.Text+"%'";
            //ShowItemList(query);
        }
        //private void ShowItemList(String query)
        //{
        //    listBox1.Items.Clear();
            //DataSet ds = fn.getData(query);
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            //}
        //}

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtquantityupdown.ResetText();
            txttotal.Clear();
            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtname.Text = text;
            //query = "select price from item where name = '" + text + "'";
            //DataSet ds = fn.getData(query);
            //try
            //{
            //    txtprice.Text = ds.Tables[0].Rows[0][0].ToString();
            //}
            //catch { }
        }

        private void txtquantityupdown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtquantityupdown.Value.ToString());
            Int64 price = Int64.Parse(txtprice.Text);
            txttotal.Text = (quan * price).ToString();
        }
        protected int n, total = 0;

        int amount;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells["Column4"].Value.ToString());
            }
            catch { }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            labeltotalamount.Text = total + " Dh";
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "       Notre cafe restaurant";
            printer.SubTitle = string.Format("Date:    {0}{1}{2}{3}{4}{5}",DateTime.Now.Day+"/", DateTime.Now.Month+"/",DateTime.Now.Year+"          ", DateTime.Now.Hour+":",DateTime.Now.Minute+":",DateTime.Now.Second);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Montant total à payer:   " + labeltotalamount.Text+"\n Merci pour votre visite";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);
            total = 0;
            guna2DataGridView1.Rows.Clear();
            labeltotalamount.Text = total + " Dh";
        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {
            ArrayList cls = new ArrayList();
            //Stream file = File.OpenRead(@"C:\Users\user\Desktop\sr\Objets.txt");
            BinaryFormatter deser = new BinaryFormatter();
            //cls = (ArrayList)(UC_Additems.ClsList)deser.Deserialize(file);
            //foreach (UC_Additems.ClsObjet clt in cls)
            //{
            //    if (comboCategory.Text == clt.CategorieA)
            //    {
            //        listBox1.Items.Add(clt.NomA);
            //    }
            //}
        }

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            if (txttotal.Text != "0" && txttotal.Text != "")
            {
                n = guna2DataGridView1.Rows.Add();
                guna2DataGridView1.Rows[n].Cells["Column1"].Value = txtname.Text;
                guna2DataGridView1.Rows[n].Cells["Column2"].Value = txtprice.Text;
                guna2DataGridView1.Rows[n].Cells["Column3"].Value = txtquantityupdown.Value;
                guna2DataGridView1.Rows[n].Cells["Column4"].Value = txttotal.Text;
                total += int.Parse(txttotal.Text);
                labeltotalamount.Text = total + " Dh";
            }
            else
            {
                MessageBox.Show("La quantité minimale doit être 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
