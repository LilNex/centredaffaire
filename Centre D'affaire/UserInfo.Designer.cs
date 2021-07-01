
namespace Centre_D_affaire
{
    partial class UserInfo
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlhaut = new System.Windows.Forms.Panel();
            this.lblinfo = new System.Windows.Forms.Label();
            this.bunifunom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifudescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifutelephone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifucombobox = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgence = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantite = new Centre_D_affaire.AchatsLogistiquePatrimoine.Catalogue.NumericUpDownColumn();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlhaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlhaut
            // 
            this.pnlhaut.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlhaut.Controls.Add(this.lblinfo);
            this.pnlhaut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlhaut.Location = new System.Drawing.Point(0, 0);
            this.pnlhaut.Name = "pnlhaut";
            this.pnlhaut.Size = new System.Drawing.Size(1347, 88);
            this.pnlhaut.TabIndex = 0;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(111, 24);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(328, 40);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "DETAIL DEMANDE";
            // 
            // bunifunom
            // 
            this.bunifunom.BorderColorFocused = System.Drawing.Color.White;
            this.bunifunom.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.bunifunom.BorderColorMouseHover = System.Drawing.Color.White;
            this.bunifunom.BorderThickness = 3;
            this.bunifunom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifunom.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifunom.ForeColor = System.Drawing.Color.LightSlateGray;
            this.bunifunom.isPassword = false;
            this.bunifunom.Location = new System.Drawing.Point(86, 122);
            this.bunifunom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifunom.Name = "bunifunom";
            this.bunifunom.Size = new System.Drawing.Size(382, 48);
            this.bunifunom.TabIndex = 1;
            this.bunifunom.Text = "NOM  DEMANDEUR";
            this.bunifunom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifunom.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(492, 538);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifudescription
            // 
            this.bunifudescription.BorderColorFocused = System.Drawing.Color.Gray;
            this.bunifudescription.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.bunifudescription.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifudescription.BorderThickness = 3;
            this.bunifudescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifudescription.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifudescription.ForeColor = System.Drawing.Color.LightSlateGray;
            this.bunifudescription.isPassword = false;
            this.bunifudescription.Location = new System.Drawing.Point(86, 191);
            this.bunifudescription.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifudescription.Name = "bunifudescription";
            this.bunifudescription.Size = new System.Drawing.Size(382, 48);
            this.bunifudescription.TabIndex = 6;
            this.bunifudescription.Text = "DESCRIPTION";
            this.bunifudescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifutelephone
            // 
            this.bunifutelephone.BorderColorFocused = System.Drawing.Color.Gray;
            this.bunifutelephone.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.bunifutelephone.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifutelephone.BorderThickness = 3;
            this.bunifutelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifutelephone.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifutelephone.ForeColor = System.Drawing.Color.LightSlateGray;
            this.bunifutelephone.isPassword = false;
            this.bunifutelephone.Location = new System.Drawing.Point(86, 261);
            this.bunifutelephone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifutelephone.Name = "bunifutelephone";
            this.bunifutelephone.Size = new System.Drawing.Size(382, 48);
            this.bunifutelephone.TabIndex = 7;
            this.bunifutelephone.Text = "TELEPHONE";
            this.bunifutelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifucombobox
            // 
            this.bunifucombobox.BackColor = System.Drawing.Color.Transparent;
            this.bunifucombobox.BorderRadius = 3;
            this.bunifucombobox.DisabledColor = System.Drawing.Color.Gray;
            this.bunifucombobox.ForeColor = System.Drawing.Color.White;
            this.bunifucombobox.Items = new string[0];
            this.bunifucombobox.Location = new System.Drawing.Point(86, 396);
            this.bunifucombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifucombobox.Name = "bunifucombobox";
            this.bunifucombobox.NomalColor = System.Drawing.Color.SteelBlue;
            this.bunifucombobox.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifucombobox.selectedIndex = -1;
            this.bunifucombobox.Size = new System.Drawing.Size(382, 43);
            this.bunifucombobox.TabIndex = 8;
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderThickness = 3;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(86, 328);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(382, 48);
            this.bunifuMetroTextbox2.TabIndex = 9;
            this.bunifuMetroTextbox2.Text = "E-MAIL";
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.article,
            this.description,
            this.telephone,
            this.email,
            this.urgence,
            this.quantite});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SteelBlue;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(569, 94);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 24;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(756, 402);
            this.bunifuCustomDataGrid1.TabIndex = 10;
            // 
            // nom
            // 
            this.nom.HeaderText = "NOM-DEMANDEUR";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.Width = 125;
            // 
            // article
            // 
            this.article.HeaderText = "NOM-ARTICLE";
            this.article.MinimumWidth = 6;
            this.article.Name = "article";
            this.article.Width = 125;
            // 
            // description
            // 
            this.description.HeaderText = "DESCRIPTION";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.Width = 125;
            // 
            // telephone
            // 
            this.telephone.HeaderText = "TELEPHONE";
            this.telephone.MinimumWidth = 6;
            this.telephone.Name = "telephone";
            this.telephone.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "E-MAIL";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // urgence
            // 
            this.urgence.HeaderText = "URGENCE";
            this.urgence.MinimumWidth = 6;
            this.urgence.Name = "urgence";
            this.urgence.Width = 125;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "QUANTITE";
            this.quantite.MinimumWidth = 6;
            this.quantite.Name = "quantite";
            this.quantite.Width = 125;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(569, 538);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(71, 70);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 11;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.bunifuMetroTextbox2);
            this.Controls.Add(this.bunifucombobox);
            this.Controls.Add(this.bunifutelephone);
            this.Controls.Add(this.bunifudescription);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifunom);
            this.Controls.Add(this.pnlhaut);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(1347, 611);
            this.pnlhaut.ResumeLayout(false);
            this.pnlhaut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlhaut;
        private System.Windows.Forms.Label lblinfo;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifunom;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifudescription;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifutelephone;
        private Bunifu.Framework.UI.BunifuDropdown bunifucombobox;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewComboBoxColumn urgence;
        private AchatsLogistiquePatrimoine.Catalogue.NumericUpDownColumn quantite;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}
