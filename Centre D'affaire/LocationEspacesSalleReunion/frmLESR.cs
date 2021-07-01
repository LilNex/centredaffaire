using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centre_D_affaire.LocationEspacesSalleReunion
{
    public partial class frmLESR : Form
    {
        public frmLESR()
        {
            InitializeComponent();
        }

        private void btnAjoutEspace_Click(object sender, EventArgs e)
        {
            AjoutEspace frmAjoutEspace = new AjoutEspace();
            frmAjoutEspace.loadForm += reloadForm;
            frmAjoutEspace.ShowDialog();
        }

        private void btnAjoutLocation_Click(object sender, EventArgs e)
        {
            AjoutLocation frmAjoutLocation = new AjoutLocation();
            frmAjoutLocation.loadForm += reloadForm;
            frmAjoutLocation.ShowDialog();
        }

        private void frmLESR_Load(object sender, EventArgs e)
        {
            reloadForm();
            lblDate.Text = DateTime.Now.ToString("f").ToUpper();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void dgvReservations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Facturation frmFacture = new Facturation();
            frmFacture.loadForm += reloadForm;
            frmFacture.Loc = dgvReservations.CurrentRow.DataBoundItem as ClsLocation;

            frmFacture.ShowDialog();
        }

        private void dgvReservations_DataSourceChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            foreach(DataGridViewRow row in dgv.Rows)
            {
                ClsLocation obj = row.DataBoundItem as ClsLocation;
                if(DateTime.Now > obj.DateDebut && DateTime.Now < obj.DateFin)
                {
                    foreach(DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Green;
                        cell.Style.ForeColor = Color.White;
                    }
                }
                else if (DateTime.Now > obj.DateFin )
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = Color.Red;
                        cell.Style.ForeColor = Color.White;
                    }
                }
            }
        }

        public void reloadForm()
        {
            ClsLocation.ChargerLocations();
            ClsEspaces.ChargerEspaces();
            ClsFacture.ChargerArchive();

            dgvEspaces.DataSource = null;
            dgvReservations.DataSource = null;
            dgvEspaces.DataSource = ClsEspaces.ListeEspaces;
            dgvReservations.DataSource = ClsLocation.ListeLocations;

            lblEspaceCount.Text = ClsEspaces.ListeEspaces.Count.ToString();
        }

        private void btnFactures_Click(object sender, EventArgs e)
        {
            ListeFactures frmFactures = new ListeFactures();
            frmFactures.loadForm += reloadForm;
            frmFactures.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("f");
            

        }
    }
}
