using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
   

namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    public partial class Catalogue : Form
    {

        
        public Catalogue()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
            // 381; 256
            //22; 143
            //982; 638
            

            


        }
        Formulaire.FormDTldemande a = new Formulaire.FormDTldemande();
      

        List<CHOIX> lc = new List<CHOIX>();
        

        ClsDemande D = new ClsDemande();

        //---AJOUTER LE TYPE  NUMERIC UP DOWN DANS LA LISTE DES TYPES DE COLONNE  DANS UNE DATAGRID-----------
        public class NumericUpDownColumn : DataGridViewColumn
        {
            public NumericUpDownColumn()
                : base(new NumericUpDownCell())
            {
            }

            public override DataGridViewCell CellTemplate
            {
                get { return base.CellTemplate; }
                set
                {
                    if (value != null && !value.GetType().IsAssignableFrom(typeof(NumericUpDownCell)))
                    {
                        throw new InvalidCastException("Must be a NumericUpDownCell");
                    }
                    base.CellTemplate = value;
                }
            }
        }

        public class NumericUpDownCell : DataGridViewTextBoxCell
        {
            private readonly decimal min;
            private readonly decimal max;

            public NumericUpDownCell()
                : base()
            {
                Style.Format = "F0";
            }
            public NumericUpDownCell(decimal min, decimal max)
                : base()
            {
                this.min = min;
                this.max = max;
                Style.Format = "F0";
            }

            public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
            {
                base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
                NumericUpDownEditingControl ctl = DataGridView.EditingControl as NumericUpDownEditingControl;
                ctl.Minimum = this.min;
                ctl.Maximum = this.max;
                ctl.Value = Convert.ToDecimal(this.Value);
            }

            public override Type EditType
            {
                get { return typeof(NumericUpDownEditingControl); }
            }

            public override Type ValueType
            {
                get { return typeof(Decimal); }
            }

            public override object DefaultNewRowValue
            {
                get { return null; }
            }
        }

        public class NumericUpDownEditingControl : NumericUpDown, IDataGridViewEditingControl
        {
            private DataGridView dataGridViewControl;
            private bool valueIsChanged = false;
            private int rowIndexNum;

            public NumericUpDownEditingControl()
                : base()
            {
                this.DecimalPlaces = 0;
            }

            public DataGridView EditingControlDataGridView
            {
                get { return dataGridViewControl; }
                set { dataGridViewControl = value; }
            }

            public object EditingControlFormattedValue
            {
                get { return this.Value.ToString("F0"); }
                set { this.Value = Decimal.Parse(value.ToString()); }
            }
            public int EditingControlRowIndex
            {
                get { return rowIndexNum; }
                set { rowIndexNum = value; }
            }
            public bool EditingControlValueChanged
            {
                get { return valueIsChanged; }
                set { valueIsChanged = value; }
            }

            public Cursor EditingPanelCursor
            {
                get { return base.Cursor; }
            }

            public bool RepositionEditingControlOnValueChange
            {
                get { return false; }
            }

            public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
            {
                this.Font = dataGridViewCellStyle.Font;
                this.ForeColor = dataGridViewCellStyle.ForeColor;
                this.BackColor = dataGridViewCellStyle.BackColor;
            }

            public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
            {
                return (keyData == Keys.Left || keyData == Keys.Right ||
                    keyData == Keys.Up || keyData == Keys.Down ||
                    keyData == Keys.Home || keyData == Keys.End ||
                    keyData == Keys.PageDown || keyData == Keys.PageUp);
            }

            public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
            {
                return this.Value.ToString();
            }

            public void PrepareEditingControlForEdit(bool selectAll)
            {
            }

            protected override void OnValueChanged(EventArgs e)
            {
                valueIsChanged = true;
                this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
                base.OnValueChanged(e);
            }
        }

        private void Catalogue_Load(object sender, EventArgs e)

        {
            

            if (ClsListe.List_choix.Count == 0)
            {
                pictureBox2.Show();
                timer1.Start();

                btnVider.Visible = false;
                btnsuivant.Visible = false;
                btnRetirer.Visible = false;
                lblFinal.Visible = false;
                lblChoi.Visible = false;
                btnChoisir.Visible = false;
                dgvCHoi.Visible = false;
                dgvFinal.Visible = false;
                pnlPersonnel.Visible = false;

            }
            else
            {
                dgvFinal.Visible = true;

            }
            //animation



           
           
           

            //panel1.BackColor = Color.FromArgb(30, 0, 0, 0);
            pnlHaut.BackColor = Color.FromArgb(70, 0, 0, 0);
            //charger fichier  choix dans liste choi 
            
            /*ClsListe.chargerDEMANDE();*/ // pour ajouter une demande sur la liste precedente

            //charger les article
            ClsListe.List_article.Clear();
            ClsListe.chargerART();


            //string a = Application.StartupPath;
            dgvCHoi.DataSource = null;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;


            dgvCHoi.DataSource = ClsListe.List_article;
            dgvCHoi.Columns["nom"].Width = 150;
            dgvCHoi.Columns["typearticle"].Width = 80;

            dgvCHoi.Columns["photo"].Visible = false;


            cmbProduit.Text = "--Faites votre choix--";
            cmbProduit.Items.Add("Bureau");
            cmbProduit.Items.Add("Meuble");
            cmbProduit.Items.Add("Materiel sportif");
            cmbProduit.Items.Add("Salle de jeux");
            cmbProduit.Items.Add("Cafe/restaurant");
            cmbProduit.Items.Add("Crèche");
            cmbProduit.Items.Add("Uniforme");
            cmbProduit.Items.Add("Service");
            cmbProduit.Items.Add("Autre");



           


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            //List<ClsArticle> la = new List<ClsArticle>();
            dgvCHoi.Visible = true;
            lblChoi.Visible = true;
            ClsListe a = new ClsListe();
            if (cmbProduit.SelectedItem.ToString() == "Bureau")
            {

                dgvCHoi.DataSource = null;
                dgvCHoi.DataSource = ClsListe.getlisteART(ArticleType.Bureau);

                dgvCHoi.Columns["nom"].Width = 170;
                dgvCHoi.Columns["nom"].ReadOnly = true;


            }

            if (cmbProduit.SelectedItem.ToString() == "Meuble")
            {

                dgvCHoi.DataSource = null;
                dgvCHoi.DataSource = ClsListe.getlisteART(ArticleType.Meuble);

                dgvCHoi.Columns["nom"].Width = 170;
                dgvCHoi.Columns["nom"].ReadOnly = true;

            }
            if (cmbProduit.SelectedItem.ToString() == "Materiel sportif")
            {

                dgvCHoi.DataSource = null;
                dgvCHoi.DataSource = ClsListe.getlisteART(ArticleType.SalleSport);

                dgvCHoi.Columns["nom"].Width = 170;
                dgvCHoi.Columns["nom"].ReadOnly = true;

            }
            if (cmbProduit.SelectedItem.ToString() == "Salle de jeux")
            {

                dgvCHoi.DataSource = null;
                dgvCHoi.DataSource = ClsListe.getlisteART(ArticleType.SalleJeux);

                dgvCHoi.Columns["nom"].Width = 170;
                dgvCHoi.Columns["nom"].ReadOnly = true;

            }
            if (cmbProduit.SelectedItem.ToString() == "Cafe/restaurant")
            {

                dgvCHoi.DataSource = null;
                dgvCHoi.DataSource = ClsListe.getlisteART(ArticleType.Caferestaurant);

                dgvCHoi.Columns["nom"].Width = 170;
                dgvCHoi.Columns["nom"].ReadOnly = true;

            }
            if (cmbProduit.SelectedItem.ToString() == "Crèche")
            {

                dgvCHoi.DataSource = null;
                dgvCHoi.DataSource = ClsListe.getlisteART(ArticleType.Crèche);

                dgvCHoi.Columns["nom"].Width = 170;
                dgvCHoi.Columns["nom"].ReadOnly = true;


            }
            if (cmbProduit.SelectedItem.ToString() == "Service")
            {

                dgvCHoi.DataSource = null;
                dgvCHoi.DataSource = ClsListe.getlisteART(ArticleType.Service);

                dgvCHoi.Columns["nom"].Width = 170;
                dgvCHoi.Columns["nom"].ReadOnly = true;


            }
            if (cmbProduit.SelectedItem.ToString() == "Autre")
            {

                dgvCHoi.DataSource = null;
                dgvCHoi.DataSource = ClsListe.getlisteART(ArticleType.Autre);

                dgvCHoi.Columns["nom"].Width = 170;
                dgvCHoi.Columns["nom"].ReadOnly = true;


            }
            if (cmbProduit.SelectedItem.ToString() == "Uniforme")
            {

                dgvCHoi.DataSource = null;
                dgvCHoi.DataSource = ClsListe.getlisteART(ArticleType.Uniforme);

                dgvCHoi.Columns["nom"].Width = 170;
                dgvCHoi.Columns["nom"].ReadOnly = true;


            }

            cmbProduit.Text = "--Faites votre choix--";
            foreach (DataGridViewColumn d in dgvCHoi.Columns)
            {
                d.Visible = false;

            }
            dgvCHoi.Columns["nom"].Visible = true;
            dgvCHoi.Columns["nom"].Width = 220;

            cmbProduit.Text = "--Faites votre choix--";
        }








        private void dgvCHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = ((ClsArticle)dgvCHoi.CurrentRow.DataBoundItem).Photo;
        }



        private void btnChoisir_Click(object sender, EventArgs e)
        {
            lblFinal.Visible = true;
            dgvFinal.Visible = true;
            btnRetirer.Visible = true;
            btnVider.Visible = true;
            btnsuivant.Visible = true;

            bool exist = false;

            string n = ((ClsArticle)dgvCHoi.CurrentRow.DataBoundItem).Nom;

            CHOIX c = new CHOIX(((ClsArticle)dgvCHoi.CurrentRow.DataBoundItem), n, 0);
          
            for (int i = 0; i < ClsListe.List_choix.Count; i++)
            {
                if (ClsListe.List_choix[i].Nom == n)
                {
                    exist = true;
                }

            }
            if (exist == false)
            {
                ClsListe.List_choix.Add(c);
            }



            dgvFinal.DataSource = null;
            dgvFinal.DataSource = ClsListe.List_choix;


            foreach (DataGridViewColumn d in dgvFinal.Columns)
            {
                d.Visible = false;

            }

            dgvFinal.Columns["nom"].Visible = true;
            dgvFinal.Columns["quantite"].Visible = true;

            dgvFinal.Columns["nom"].ReadOnly = true;
            dgvFinal.Columns["quantite"].ReadOnly = false;


            
        }

        private void btnRetirer_Click(object sender, EventArgs e)
        {

            if (s == false)
            {
                MessageBox.Show("selectionnez un article");
            }
            else
            {
                string n = ((CHOIX)dgvFinal.CurrentRow.DataBoundItem).Nom;
                for (int i = 0; i < ClsListe.List_choix.Count; i++)
                {
                    if (ClsListe.List_choix[i].Nom == n)
                    {
                        ClsListe.List_choix.Remove(ClsListe.List_choix[i]);
                    }
                }

                dgvFinal.DataSource = null;
                dgvFinal.DataSource = ClsListe.List_choix;

                foreach (DataGridViewColumn d in dgvFinal.Columns)
                {
                    d.Visible = false;

                }

                dgvFinal.Columns["nom"].Visible = true;
                dgvFinal.Columns["quantite"].Visible = true;

                dgvFinal.Columns["nom"].ReadOnly = true;
                dgvFinal.Columns["quantite"].ReadOnly = false;

            }
            s = false;


        }
        bool s = false;

        private void dgvFinal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            s = true;
        }

        private void dgvFinal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pictureBox1.Image = ((CHOIX)dgvFinal.CurrentRow.DataBoundItem).Article.Photo;
        }

        private void btnVider_Click(object sender, EventArgs e)
        {
            dgvFinal.Visible = false;
            ClsListe.List_choix.Clear();
            dgvFinal.DataSource = null;

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            

        }

        private void dgvFinal_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

        }
        
        private void btnsuivant_Click(object sender, EventArgs e)
        {
            
            this.Hide();

            
            
            a.Show();
            
            
            

            
            

        }

        private void cmbProduit_Click(object sender, EventArgs e)
        {

        }

        private void Catalogue_Click(object sender, EventArgs e)
        {

        }

        private void dgvCHoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCHoi_Click(object sender, EventArgs e)
        {
            btnChoisir.Visible = true;

        }

        private void lblChoi_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_LocationChanged(object sender, EventArgs e)
        {
           



            //pictureBox1.Location = new Point(x, y);
        }
        

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureBox2.Location.X;
            int y = pictureBox2.Location.Y;
            pictureBox2.Location = new Point(x + 4, y+2);

            
            if (x> 400 )
            {
                timer1.Stop();
            }
        }

        private void pnlHaut_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCONECT_Click(object sender, EventArgs e)
        {
            pnlPersonnel.Visible = true;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcha_Click(object sender, EventArgs e)
        {
            FormPres f = new FormPres();
            f.Show();

            this.Hide();

        }

        private void btnCom_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
