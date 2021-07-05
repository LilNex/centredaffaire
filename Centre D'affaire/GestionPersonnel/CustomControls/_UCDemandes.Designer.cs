namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class UCDemandes
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
            this.btnListeDemandes = new System.Windows.Forms.Button();
            this.ucListeDemandes1 = new Centre_D_affaire.GestionPersonnel.CustomControls.UCListeDemandes();
            this.SuspendLayout();
            // 
            // btnListeDemandes
            // 
            this.btnListeDemandes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnListeDemandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeDemandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeDemandes.ForeColor = System.Drawing.Color.White;
            this.btnListeDemandes.Image = global::Centre_D_affaire.Properties.Resources.icons8_user_groups_32px;
            this.btnListeDemandes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListeDemandes.Location = new System.Drawing.Point(0, 0);
            this.btnListeDemandes.Margin = new System.Windows.Forms.Padding(0);
            this.btnListeDemandes.Name = "btnListeDemandes";
            this.btnListeDemandes.Size = new System.Drawing.Size(225, 42);
            this.btnListeDemandes.TabIndex = 6;
            this.btnListeDemandes.Text = "Liste des demandes";
            this.btnListeDemandes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListeDemandes.UseVisualStyleBackColor = false;
            this.btnListeDemandes.Click += new System.EventHandler(this.btnListeDemandes_Click);
            // 
            // ucListeDemandes1
            // 
            this.ucListeDemandes1.BackColor = System.Drawing.Color.White;
            this.ucListeDemandes1.Location = new System.Drawing.Point(0, 40);
            this.ucListeDemandes1.Name = "ucListeDemandes1";
            this.ucListeDemandes1.Size = new System.Drawing.Size(952, 529);
            this.ucListeDemandes1.TabIndex = 7;
            // 
            // UCDemandes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ucListeDemandes1);
            this.Controls.Add(this.btnListeDemandes);
            this.Name = "UCDemandes";
            this.Size = new System.Drawing.Size(952, 569);
            this.Load += new System.EventHandler(this.UCDepartements_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListeDemandes;
        private UCListeDemandes ucListeDemandes1;
    }
}
