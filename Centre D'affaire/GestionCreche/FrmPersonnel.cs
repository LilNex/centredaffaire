using System;
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
    public partial class FrmPersonnel : Form
    {
        public FrmPersonnel()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add(txtnom.Text, txtprenom.Text, txtEmail.Text, txtAd.Text, txtNum.Text, txttele.Text);
            txtnom.Clear();
            txtprenom.Clear();
            txtEmail.Clear();
            txtAd.Clear();
            txtNum.Clear();
            txttele.Clear();


        }
        int a;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = e.RowIndex;
            DataGridView row = dataGridView1.Rows[a];
            txtnom.Text = row.Cells[0].value.Tostring();
        }
    }
}
