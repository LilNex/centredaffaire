
namespace Centre_D_affaire.GestionCreche
{
    partial class frmInscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscription));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblProfession = new System.Windows.Forms.Label();
            this.lblDepartement = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picimage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNomEN = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblDN = new System.Windows.Forms.Label();
            this.lblDA = new System.Windows.Forms.Label();
            this.DDM = new System.Windows.Forms.DateTimePicker();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.DN = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nomparent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.btnValider);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.DN);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.DDM);
            this.panel1.Controls.Add(this.lblDA);
            this.panel1.Controls.Add(this.lblDN);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.txtNomEN);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.picimage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDepartement);
            this.panel1.Controls.Add(this.txtTelephone);
            this.panel1.Controls.Add(this.txtProfession);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.lblTelephone);
            this.panel1.Controls.Add(this.lblDepartement);
            this.panel1.Controls.Add(this.lblProfession);
            this.panel1.Controls.Add(this.lblNom);
            this.panel1.Location = new System.Drawing.Point(38, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 387);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblNom
            // 
           //
            // 
            // lblProfession
            // 
            this.lblProfession.AutoSize = true;
            this.lblProfession.BackColor = System.Drawing.Color.Transparent;
            this.lblProfession.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfession.Location = new System.Drawing.Point(3, 62);
            this.lblProfession.Name = "lblProfession";
            this.lblProfession.Size = new System.Drawing.Size(80, 20);
            this.lblProfession.TabIndex = 1;
            this.lblProfession.Text = "Profession";
            // 
            // lblDepartement
            // 
            this.lblDepartement.AutoSize = true;
            this.lblDepartement.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartement.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartement.Location = new System.Drawing.Point(12, 149);
            this.lblDepartement.Name = "lblDepartement";
            this.lblDepartement.Size = new System.Drawing.Size(99, 20);
            this.lblDepartement.TabIndex = 2;
            this.lblDepartement.Text = "Departement";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelephone.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(12, 108);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(78, 20);
            this.lblTelephone.TabIndex = 3;
            this.lblTelephone.Text = "telephone";
            this.lblTelephone.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(16, 39);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(178, 20);
            this.txtNom.TabIndex = 4;
            // 
            // txtProfession
            // 
            this.txtProfession.Location = new System.Drawing.Point(16, 82);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(178, 20);
            this.txtProfession.TabIndex = 5;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(16, 125);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(178, 20);
            this.txtTelephone.TabIndex = 6;
            // 
            // txtDepartement
            // 
            this.txtDepartement.Location = new System.Drawing.Point(16, 172);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(178, 20);
            this.txtDepartement.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom D\'enfant";
            // 
            // picimage
            // 
            this.picimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picimage.ImageLocation = "";
            this.picimage.Location = new System.Drawing.Point(513, 20);
            this.picimage.Name = "picimage";
            this.picimage.Size = new System.Drawing.Size(100, 90);
            this.picimage.TabIndex = 9;
            this.picimage.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(528, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNomEN
            // 
            this.txtNomEN.Location = new System.Drawing.Point(284, 43);
            this.txtNomEN.Name = "txtNomEN";
            this.txtNomEN.Size = new System.Drawing.Size(186, 20);
            this.txtNomEN.TabIndex = 11;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(242, 62);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 20);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Age";
            // 
            // lblDN
            // 
            this.lblDN.AutoSize = true;
            this.lblDN.BackColor = System.Drawing.Color.Transparent;
            this.lblDN.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDN.Location = new System.Drawing.Point(242, 108);
            this.lblDN.Name = "lblDN";
            this.lblDN.Size = new System.Drawing.Size(113, 20);
            this.lblDN.TabIndex = 13;
            this.lblDN.Text = "Date Naissance";
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.BackColor = System.Drawing.Color.Transparent;
            this.lblDA.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDA.Location = new System.Drawing.Point(242, 149);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(128, 20);
            this.lblDA.TabIndex = 14;
            this.lblDA.Text = "Date D\'admission";
            // 
            // DDM
            // 
            this.DDM.Location = new System.Drawing.Point(273, 172);
            this.DDM.Name = "DDM";
            this.DDM.Size = new System.Drawing.Size(197, 20);
            this.DDM.TabIndex = 15;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(284, 85);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(186, 20);
            this.txtAge.TabIndex = 16;
            // 
            // DN
            // 
            this.DN.Location = new System.Drawing.Point(284, 131);
            this.DN.Name = "DN";
            this.DN.Size = new System.Drawing.Size(197, 20);
            this.DN.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomparent,
            this.Profession,
            this.Telephone,
            this.Depar,
            this.NomE,
            this.AGE,
            this.DateN,
            this.DateAD});
            this.dataGridView1.Location = new System.Drawing.Point(169, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 115);
            this.dataGridView1.TabIndex = 18;
            // 
            // Nomparent
            // 
            this.Nomparent.HeaderText = "Nom parent";
            this.Nomparent.Name = "Nomparent";
            this.Nomparent.Width = 50;
            // 
            // Profession
            // 
            this.Profession.HeaderText = "Profession";
            this.Profession.Name = "Profession";
            this.Profession.Width = 50;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Profession";
            this.Telephone.Name = "Telephone";
            this.Telephone.Width = 50;
            // 
            // Depar
            // 
            this.Depar.HeaderText = "Departement";
            this.Depar.Name = "Depar";
            this.Depar.Width = 50;
            // 
            // NomE
            // 
            this.NomE.HeaderText = "Nom d\'enfant";
            this.NomE.Name = "NomE";
            this.NomE.Width = 50;
            // 
            // AGE
            // 
            this.AGE.HeaderText = "AGE";
            this.AGE.Name = "AGE";
            this.AGE.Width = 50;
            // 
            // DateN
            // 
            this.DateN.HeaderText = "Date Naissance";
            this.DateN.Name = "DateN";
            this.DateN.Width = 50;
            // 
            // DateAD
            // 
            this.DateAD.HeaderText = "Date Admission";
            this.DateAD.Name = "DateAD";
            this.DateAD.Width = 50;
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Transparent;
            this.btnValider.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.Color.Blue;
            this.btnValider.Location = new System.Drawing.Point(42, 269);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 32);
            this.btnValider.TabIndex = 19;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.Font = new System.Drawing.Font("Script MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Blue;
            this.btnAjouter.Location = new System.Drawing.Point(42, 231);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 32);
            this.btnAjouter.TabIndex = 20;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFermer.BackgroundImage")));
            this.btnFermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFermer.Location = new System.Drawing.Point(653, 0);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(48, 37);
            this.btnFermer.TabIndex = 21;
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 488);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInscription";
            this.Text = "frmInscription";
            this.Load += new System.EventHandler(this.frmInscription_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProfession;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblDepartement;
        private System.Windows.Forms.TextBox txtDepartement;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomEN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picimage;
        private System.Windows.Forms.DateTimePicker DN;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.DateTimePicker DDM;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.Label lblDN;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomparent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAD;
        private System.Windows.Forms.Button btnFermer;
    }
}