namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class UCDepartements
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAjouterPoste = new System.Windows.Forms.Button();
            this.btnAjouterDeps = new System.Windows.Forms.Button();
            this.btnListeDeps = new System.Windows.Forms.Button();
            this.btnListePostes = new System.Windows.Forms.Button();
            this.ucListeDepartement = new Centre_D_affaire.GestionPersonnel.CustomControls.UCListeDepartement();
            this.ucListePoste = new Centre_D_affaire.GestionPersonnel.CustomControls.UCListePoste();
            this.ucAjoutDepartement = new Centre_D_affaire.GestionPersonnel.CustomControls.UCAjoutDepartement();
            this.ucModifDepartement = new Centre_D_affaire.GestionPersonnel.CustomControls.UCModifDepartement();
            this.ucModifPoste = new Centre_D_affaire.GestionPersonnel.CustomControls.UCModifPoste();
            this.SuspendLayout();
            // 
            // btnAjouterPoste
            // 
            this.btnAjouterPoste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnAjouterPoste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPoste.ForeColor = System.Drawing.Color.White;
            this.btnAjouterPoste.Image = global::Centre_D_affaire.Properties.Resources.icons8_add_user_male_32px;
            this.btnAjouterPoste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterPoste.Location = new System.Drawing.Point(675, 0);
            this.btnAjouterPoste.Margin = new System.Windows.Forms.Padding(0);
            this.btnAjouterPoste.Name = "btnAjouterPoste";
            this.btnAjouterPoste.Size = new System.Drawing.Size(225, 42);
            this.btnAjouterPoste.TabIndex = 9;
            this.btnAjouterPoste.Text = "Ajouter un poste";
            this.btnAjouterPoste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterPoste.UseVisualStyleBackColor = false;
            this.btnAjouterPoste.Click += new System.EventHandler(this.btnAjouterPoste_Click);
            // 
            // btnAjouterDeps
            // 
            this.btnAjouterDeps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnAjouterDeps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterDeps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterDeps.ForeColor = System.Drawing.Color.White;
            this.btnAjouterDeps.Image = global::Centre_D_affaire.Properties.Resources.icons8_add_user_male_32px;
            this.btnAjouterDeps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterDeps.Location = new System.Drawing.Point(450, 0);
            this.btnAjouterDeps.Margin = new System.Windows.Forms.Padding(0);
            this.btnAjouterDeps.Name = "btnAjouterDeps";
            this.btnAjouterDeps.Size = new System.Drawing.Size(225, 42);
            this.btnAjouterDeps.TabIndex = 7;
            this.btnAjouterDeps.Text = "Ajouter un départements";
            this.btnAjouterDeps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterDeps.UseVisualStyleBackColor = false;
            this.btnAjouterDeps.Click += new System.EventHandler(this.btnAjouterDeps_Click);
            // 
            // btnListeDeps
            // 
            this.btnListeDeps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnListeDeps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeDeps.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeDeps.ForeColor = System.Drawing.Color.White;
            this.btnListeDeps.Image = global::Centre_D_affaire.Properties.Resources.icons8_user_groups_32px;
            this.btnListeDeps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListeDeps.Location = new System.Drawing.Point(0, 0);
            this.btnListeDeps.Margin = new System.Windows.Forms.Padding(0);
            this.btnListeDeps.Name = "btnListeDeps";
            this.btnListeDeps.Size = new System.Drawing.Size(225, 42);
            this.btnListeDeps.TabIndex = 6;
            this.btnListeDeps.Text = "Liste des départements";
            this.btnListeDeps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListeDeps.UseVisualStyleBackColor = false;
            this.btnListeDeps.Click += new System.EventHandler(this.btnListeDeps_Click);
            // 
            // btnListePostes
            // 
            this.btnListePostes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnListePostes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListePostes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListePostes.ForeColor = System.Drawing.Color.White;
            this.btnListePostes.Image = global::Centre_D_affaire.Properties.Resources.icons8_user_groups_32px;
            this.btnListePostes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListePostes.Location = new System.Drawing.Point(225, 0);
            this.btnListePostes.Margin = new System.Windows.Forms.Padding(0);
            this.btnListePostes.Name = "btnListePostes";
            this.btnListePostes.Size = new System.Drawing.Size(225, 42);
            this.btnListePostes.TabIndex = 8;
            this.btnListePostes.Text = "Liste des postes";
            this.btnListePostes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListePostes.UseVisualStyleBackColor = false;
            this.btnListePostes.Click += new System.EventHandler(this.btnListePostes_Click);
            // 
            // ucListeDepartement
            // 
            this.ucListeDepartement.BackColor = System.Drawing.Color.White;
            this.ucListeDepartement.Location = new System.Drawing.Point(0, 42);
            this.ucListeDepartement.Name = "ucListeDepartement";
            this.ucListeDepartement.Size = new System.Drawing.Size(952, 529);
            this.ucListeDepartement.TabIndex = 10;
            this.ucListeDepartement.Load += new System.EventHandler(this.ucListeDepartement_Load);
            // 
            // ucListePoste
            // 
            this.ucListePoste.Location = new System.Drawing.Point(0, 42);
            this.ucListePoste.Name = "ucListePoste";
            this.ucListePoste.Size = new System.Drawing.Size(952, 529);
            this.ucListePoste.TabIndex = 11;
            // 
            // ucAjoutDepartement
            // 
            this.ucAjoutDepartement.Location = new System.Drawing.Point(0, 42);
            this.ucAjoutDepartement.Name = "ucAjoutDepartement";
            this.ucAjoutDepartement.Size = new System.Drawing.Size(952, 529);
            this.ucAjoutDepartement.TabIndex = 12;
            this.ucAjoutDepartement.Load += new System.EventHandler(this.ucAjoutDepartement_Load);
            // 
            // ucModifDepartement
            // 
            this.ucModifDepartement.BackColor = System.Drawing.Color.White;
            this.ucModifDepartement.Departement = null;
            this.ucModifDepartement.Location = new System.Drawing.Point(0, 40);
            this.ucModifDepartement.Name = "ucModifDepartement";
            this.ucModifDepartement.Size = new System.Drawing.Size(952, 529);
            this.ucModifDepartement.TabIndex = 13;
            // 
            // ucModifPoste
            // 
            this.ucModifPoste.BackColor = System.Drawing.Color.White;
            this.ucModifPoste.Poste = null;
            this.ucModifPoste.Location = new System.Drawing.Point(0, 40);
            this.ucModifPoste.Name = "ucModifPoste";
            this.ucModifPoste.Size = new System.Drawing.Size(952, 529);
            this.ucModifPoste.TabIndex = 14;
            // 
            // UCDepartements
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnAjouterPoste);
            this.Controls.Add(this.btnAjouterDeps);
            this.Controls.Add(this.btnListeDeps);
            this.Controls.Add(this.btnListePostes);
            this.Controls.Add(this.ucAjoutDepartement);
            this.Controls.Add(this.ucModifDepartement);
            this.Controls.Add(this.ucListeDepartement);
            this.Controls.Add(this.ucListePoste);
            this.Controls.Add(this.ucModifPoste);
            this.Name = "UCDepartements";
            this.Size = new System.Drawing.Size(952, 569);
            this.Load += new System.EventHandler(this.UCDepartements_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterDeps;
        private System.Windows.Forms.Button btnListeDeps;
        private System.Windows.Forms.Button btnListePostes;
        private System.Windows.Forms.Button btnAjouterPoste;
        private UCListeDepartement ucListeDepartement;
        private UCListePoste ucListePoste;
        private UCAjoutDepartement ucAjoutDepartement;
        private UCModifDepartement ucModifDepartement;
        private UCModifPoste ucModifPoste;
    }
}
