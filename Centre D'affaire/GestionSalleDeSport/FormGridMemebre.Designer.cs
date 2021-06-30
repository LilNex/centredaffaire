
namespace Centre_D_affaire.GestionSalleDeSport
{
    partial class FormGridMemebre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGridMemebre));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.BTNredire = new Bunifu.Framework.UI.BunifuTileButton();
            this.BTNfermer = new Bunifu.Framework.UI.BunifuTileButton();
            this.GridMembre = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.IDMembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAteJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMembre)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Purple;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.BTNredire);
            this.bunifuPanel2.Controls.Add(this.BTNfermer);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1492, 41);
            this.bunifuPanel2.TabIndex = 156;
            this.bunifuPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuPanel2_MouseDown);
            // 
            // BTNredire
            // 
            this.BTNredire.BackColor = System.Drawing.Color.Transparent;
            this.BTNredire.color = System.Drawing.Color.Transparent;
            this.BTNredire.colorActive = System.Drawing.Color.Thistle;
            this.BTNredire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNredire.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BTNredire.ForeColor = System.Drawing.Color.White;
            this.BTNredire.Image = ((System.Drawing.Image)(resources.GetObject("BTNredire.Image")));
            this.BTNredire.ImagePosition = 5;
            this.BTNredire.ImageZoom = 80;
            this.BTNredire.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTNredire.LabelPosition = 0;
            this.BTNredire.LabelText = "";
            this.BTNredire.Location = new System.Drawing.Point(1379, 0);
            this.BTNredire.Margin = new System.Windows.Forms.Padding(6);
            this.BTNredire.Name = "BTNredire";
            this.BTNredire.Size = new System.Drawing.Size(49, 45);
            this.BTNredire.TabIndex = 13;
            // 
            // BTNfermer
            // 
            this.BTNfermer.BackColor = System.Drawing.Color.Transparent;
            this.BTNfermer.color = System.Drawing.Color.Transparent;
            this.BTNfermer.colorActive = System.Drawing.Color.Red;
            this.BTNfermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNfermer.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BTNfermer.ForeColor = System.Drawing.Color.White;
            this.BTNfermer.Image = ((System.Drawing.Image)(resources.GetObject("BTNfermer.Image")));
            this.BTNfermer.ImagePosition = 5;
            this.BTNfermer.ImageZoom = 80;
            this.BTNfermer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTNfermer.LabelPosition = 0;
            this.BTNfermer.LabelText = "";
            this.BTNfermer.Location = new System.Drawing.Point(1446, 0);
            this.BTNfermer.Margin = new System.Windows.Forms.Padding(6);
            this.BTNfermer.Name = "BTNfermer";
            this.BTNfermer.Size = new System.Drawing.Size(46, 46);
            this.BTNfermer.TabIndex = 12;
            // 
            // GridMembre
            // 
            this.GridMembre.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GridMembre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridMembre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridMembre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridMembre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridMembre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMembre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridMembre.ColumnHeadersHeight = 40;
            this.GridMembre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMembre,
            this.Sex,
            this.Nom,
            this.Poids,
            this.Telephone,
            this.Adresse,
            this.Email,
            this.DAteJoin,
            this.Duree,
            this.Frais,
            this.Total,
            this.Statut,
            this.Package});
            this.GridMembre.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(223)))));
            this.GridMembre.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridMembre.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GridMembre.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.GridMembre.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridMembre.CurrentTheme.BackColor = System.Drawing.Color.Purple;
            this.GridMembre.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.GridMembre.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Purple;
            this.GridMembre.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.GridMembre.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridMembre.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.GridMembre.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridMembre.CurrentTheme.Name = null;
            this.GridMembre.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            this.GridMembre.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridMembre.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GridMembre.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            this.GridMembre.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMembre.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridMembre.EnableHeadersVisualStyles = false;
            this.GridMembre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(216)))));
            this.GridMembre.HeaderBackColor = System.Drawing.Color.Purple;
            this.GridMembre.HeaderBgColor = System.Drawing.Color.Empty;
            this.GridMembre.HeaderForeColor = System.Drawing.Color.White;
            this.GridMembre.Location = new System.Drawing.Point(0, 47);
            this.GridMembre.Name = "GridMembre";
            this.GridMembre.RowHeadersVisible = false;
            this.GridMembre.RowHeadersWidth = 62;
            this.GridMembre.RowTemplate.Height = 40;
            this.GridMembre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMembre.Size = new System.Drawing.Size(1492, 288);
            this.GridMembre.TabIndex = 157;
            this.GridMembre.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Purple;
            this.GridMembre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMembre_CellContentClick);
            // 
            // IDMembre
            // 
            this.IDMembre.HeaderText = "IDMembre";
            this.IDMembre.MinimumWidth = 8;
            this.IDMembre.Name = "IDMembre";
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.MinimumWidth = 8;
            this.Sex.Name = "Sex";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            // 
            // Poids
            // 
            this.Poids.HeaderText = "Poids";
            this.Poids.MinimumWidth = 8;
            this.Poids.Name = "Poids";
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.MinimumWidth = 8;
            this.Telephone.Name = "Telephone";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.MinimumWidth = 8;
            this.Adresse.Name = "Adresse";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // DAteJoin
            // 
            this.DAteJoin.HeaderText = "DateJoin";
            this.DAteJoin.MinimumWidth = 8;
            this.DAteJoin.Name = "DAteJoin";
            // 
            // Duree
            // 
            this.Duree.HeaderText = "Duree";
            this.Duree.MinimumWidth = 8;
            this.Duree.Name = "Duree";
            // 
            // Frais
            // 
            this.Frais.HeaderText = "Frais";
            this.Frais.MinimumWidth = 8;
            this.Frais.Name = "Frais";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut";
            this.Statut.MinimumWidth = 8;
            this.Statut.Name = "Statut";
            // 
            // Package
            // 
            this.Package.HeaderText = "Package";
            this.Package.MinimumWidth = 8;
            this.Package.Name = "Package";
            // 
            // FormGridMemebre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 347);
            this.Controls.Add(this.GridMembre);
            this.Controls.Add(this.bunifuPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGridMemebre";
            this.Text = "FormGridMemebre";
            this.Load += new System.EventHandler(this.FormGridMemebre_Load);
            this.bunifuPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridMembre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuDataGridView GridMembre;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.Framework.UI.BunifuTileButton BTNredire;
        private Bunifu.Framework.UI.BunifuTileButton BTNfermer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poids;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAteJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package;
    }
}