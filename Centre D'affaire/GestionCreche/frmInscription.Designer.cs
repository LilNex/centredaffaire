
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblDA = new System.Windows.Forms.Label();
            this.lblDN = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtNomEN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picimage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartement = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblDepartement = new System.Windows.Forms.Label();
            this.lblProfession = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.txtDad = new System.Windows.Forms.TextBox();
            this.txtDN = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NomParent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Profession = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Departement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomEnfant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateNaissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateAdmission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.txtDN);
            this.panel1.Controls.Add(this.txtDad);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.btnValider);
            this.panel1.Controls.Add(this.txtAge);
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
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(284, 85);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(186, 20);
            this.txtAge.TabIndex = 16;
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
            // txtNomEN
            // 
            this.txtNomEN.Location = new System.Drawing.Point(284, 43);
            this.txtNomEN.Name = "txtNomEN";
            this.txtNomEN.Size = new System.Drawing.Size(186, 20);
            this.txtNomEN.TabIndex = 11;
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
            // txtDepartement
            // 
            this.txtDepartement.Location = new System.Drawing.Point(16, 172);
            this.txtDepartement.Name = "txtDepartement";
            this.txtDepartement.Size = new System.Drawing.Size(178, 20);
            this.txtDepartement.TabIndex = 7;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(16, 125);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(178, 20);
            this.txtTelephone.TabIndex = 6;
            // 
            // txtProfession
            // 
            this.txtProfession.Location = new System.Drawing.Point(16, 82);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(178, 20);
            this.txtProfession.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(16, 39);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(178, 20);
            this.txtNom.TabIndex = 4;
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
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(3, 13);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(114, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom du parent";
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
            // txtDad
            // 
            this.txtDad.Location = new System.Drawing.Point(284, 172);
            this.txtDad.Name = "txtDad";
            this.txtDad.Size = new System.Drawing.Size(186, 20);
            this.txtDad.TabIndex = 21;
            // 
            // txtDN
            // 
            this.txtDN.Location = new System.Drawing.Point(284, 131);
            this.txtDN.Name = "txtDN";
            this.txtDN.Size = new System.Drawing.Size(186, 20);
            this.txtDN.TabIndex = 22;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NomParent,
            this.Profession,
            this.telephone,
            this.Departement,
            this.NomEnfant,
            this.Age,
            this.DateNaissance,
            this.DateAdmission});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(157, 219);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(456, 151);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NomParent
            // 
            this.NomParent.Text = "NomParent";
            // 
            // Profession
            // 
            this.Profession.Text = "Profession";
            // 
            // telephone
            // 
            this.telephone.Text = "telephone";
            // 
            // Departement
            // 
            this.Departement.Text = "Departement";
            // 
            // NomEnfant
            // 
            this.NomEnfant.Text = "NomEnfant";
            // 
            // Age
            // 
            this.Age.Text = "Age";
            // 
            // DateNaissance
            // 
            this.DateNaissance.Text = "DateNaissance";
            this.DateNaissance.Width = 40;
            // 
            // DateAdmission
            // 
            this.DateAdmission.Text = "DateAdmission";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(153, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 42);
            this.label1.TabIndex = 22;
            this.label1.Text = "FiChe D\'inscription";
            // 
            // frmInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInscription";
            this.Load += new System.EventHandler(this.frmInscription_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.Label lblDN;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox txtDN;
        private System.Windows.Forms.TextBox txtDad;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NomParent;
        private System.Windows.Forms.ColumnHeader Profession;
        private System.Windows.Forms.ColumnHeader telephone;
        private System.Windows.Forms.ColumnHeader Departement;
        private System.Windows.Forms.ColumnHeader NomEnfant;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader DateNaissance;
        private System.Windows.Forms.ColumnHeader DateAdmission;
        private System.Windows.Forms.Label label1;
    }
}