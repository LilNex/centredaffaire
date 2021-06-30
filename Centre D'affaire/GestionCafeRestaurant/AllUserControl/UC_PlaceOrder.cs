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

    
    [Serializable]
    public partial class UC_PlaceOrder : UserControl
    {


        

        public UC_PlaceOrder()
        {

            InitializeComponent();
        }
        string ca;
        int p;
        int quan;
        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            listBox1.Items.Clear();
            foreach (UC_Additems.ClsObjet clt in UC_Additems.ListArticle)
            {
                if (comboCategory.Text == clt.CategorieA)
                {
                    listBox1.Items.Add(clt.NomA);
                    ca = clt.CategorieA;
                    p = int.Parse(clt.PrixA.ToString());
                }
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            
            for (int i = 0; i < UC_Additems.ListArticle.Count; i++)
            {
                if (UC_Additems.ListArticle[i].NomA.StartsWith(txtSearch.Text)&&UC_Additems.ListArticle[i].CategorieA==comboCategory.Text)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(UC_Additems.ListArticle[i].NomA);
                }
                if (txtSearch.Text == "")
                {
                    listBox1.Items.Clear();
                    foreach (UC_Additems.ClsObjet clt in UC_Additems.ListArticle)
                    {
                        if (comboCategory.Text == clt.CategorieA)
                        {
                            listBox1.Items.Add(clt.NomA);
                            ca = clt.CategorieA;
                            p = int.Parse(clt.PrixA.ToString());
                        }
                    }
                }
            }
        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            txtquantityupdown.ResetText();
            txttotal.Clear();
            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtname.Text = text;
            txtprice.Text = p.ToString();

           

        }

        private void txtquantityupdown_ValueChanged(object sender, EventArgs e)
        {
            
            quan = int.Parse(txtquantityupdown.Value.ToString());
            txttotal.Text = (quan * p).ToString();
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
                txtquantityupdown.Value = 0;
                txtname.Clear();
                txtprice.Clear();
            }
            else
            {
                MessageBox.Show("La quantité minimale doit être 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
