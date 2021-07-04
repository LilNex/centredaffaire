
namespace Centre_D_affaire.LocationEspacesSalleReunion
{
    partial class frmLESR
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
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEspaces = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEspaceCount = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFactures = new System.Windows.Forms.Button();
            this.btnAjoutEspace = new System.Windows.Forms.Button();
            this.btnAjoutLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspaces)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservations
            // 
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(15, 129);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.RowHeadersVisible = false;
            this.dgvReservations.Size = new System.Drawing.Size(285, 207);
            this.dgvReservations.TabIndex = 4;
            this.dgvReservations.DataSourceChanged += new System.EventHandler(this.dgvReservations_DataSourceChanged);
            this.dgvReservations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Reservations :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Espaces :";
            // 
            // dgvEspaces
            // 
            this.dgvEspaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspaces.Location = new System.Drawing.Point(319, 129);
            this.dgvEspaces.Name = "dgvEspaces";
            this.dgvEspaces.RowHeadersVisible = false;
            this.dgvEspaces.Size = new System.Drawing.Size(281, 207);
            this.dgvEspaces.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnFactures);
            this.panel1.Controls.Add(this.btnAjoutEspace);
            this.panel1.Controls.Add(this.btnAjoutLocation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(606, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 351);
            this.panel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Espaces Disponible : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(11, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 20);
            this.lblDate.TabIndex = 33;
            this.lblDate.Text = "Date ";
            // 
            // lblEspaceCount
            // 
            this.lblEspaceCount.AutoSize = true;
            this.lblEspaceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspaceCount.Location = new System.Drawing.Point(199, 42);
            this.lblEspaceCount.Name = "lblEspaceCount";
            this.lblEspaceCount.Size = new System.Drawing.Size(0, 20);
            this.lblEspaceCount.TabIndex = 34;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Centre_D_affaire.Properties.Resources.icons8_pin_80px;
            this.pictureBox2.Location = new System.Drawing.Point(15, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Centre_D_affaire.Properties.Resources.icons8_office_60px;
            this.pictureBox1.Location = new System.Drawing.Point(319, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // btnFactures
            // 
            this.btnFactures.Image = global::Centre_D_affaire.Properties.Resources.icons8_bill_24px;
            this.btnFactures.Location = new System.Drawing.Point(8, 106);
            this.btnFactures.Name = "btnFactures";
            this.btnFactures.Size = new System.Drawing.Size(137, 45);
            this.btnFactures.TabIndex = 4;
            this.btnFactures.Text = "Afficher l\'archive des factures";
            this.btnFactures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFactures.UseVisualStyleBackColor = true;
            this.btnFactures.Click += new System.EventHandler(this.btnFactures_Click);
            // 
            // btnAjoutEspace
            // 
            this.btnAjoutEspace.Image = global::Centre_D_affaire.Properties.Resources.icons8_organization_24px;
            this.btnAjoutEspace.Location = new System.Drawing.Point(8, 4);
            this.btnAjoutEspace.Name = "btnAjoutEspace";
            this.btnAjoutEspace.Size = new System.Drawing.Size(137, 45);
            this.btnAjoutEspace.TabIndex = 2;
            this.btnAjoutEspace.Text = "Ajouter un Espace";
            this.btnAjoutEspace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjoutEspace.UseVisualStyleBackColor = true;
            this.btnAjoutEspace.Click += new System.EventHandler(this.btnAjoutEspace_Click);
            // 
            // btnAjoutLocation
            // 
            this.btnAjoutLocation.Image = global::Centre_D_affaire.Properties.Resources.icons8_calendar_plus_24px;
            this.btnAjoutLocation.Location = new System.Drawing.Point(8, 55);
            this.btnAjoutLocation.Name = "btnAjoutLocation";
            this.btnAjoutLocation.Size = new System.Drawing.Size(137, 45);
            this.btnAjoutLocation.TabIndex = 3;
            this.btnAjoutLocation.Text = "Ajouter une réservation";
            this.btnAjoutLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjoutLocation.UseVisualStyleBackColor = true;
            this.btnAjoutLocation.Click += new System.EventHandler(this.btnAjoutLocation_Click);
            // 
            // frmLESR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(758, 351);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEspaceCount);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEspaces);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvReservations);
            this.Name = "frmLESR";
            this.Text = "Location des espaces";
            this.Load += new System.EventHandler(this.frmLESR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspaces)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutLocation;
        private System.Windows.Forms.Button btnAjoutEspace;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEspaces;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFactures;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEspaceCount;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}