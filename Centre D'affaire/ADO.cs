using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Centre_D_affaire
{
    public class ADO
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataSet ds = new DataSet();



        public void connecter()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = " data source=DESKTOP-OUMVAH4 ; initial catalog=security=true ";
                con.Open();
            }
        }
        public void Deconnecter()
        {
            if (con.State == ConnectionState.Open)
            {
                
                con.Close();
            }

        }
        public void RemplirGrid(string table ,DataGridView DG)
        {
            connecter();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FORM " + table;

            da.SelectCommand = cmd;
            da.Fill(ds, "DT" + table);
            DG.DataSource = ds.Tables["DTenfant"];
            Deconnecter();

        }
    }
}
