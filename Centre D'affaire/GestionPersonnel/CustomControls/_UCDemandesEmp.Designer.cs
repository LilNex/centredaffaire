namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class UCDemandesEmp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ucListeDemandesEmp1 = new Centre_D_affaire.GestionPersonnel.CustomControls.UCListeDemandesEmp();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Centre_D_affaire.Properties.Resources.icons8_user_groups_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(225, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Demander un congé";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnDemission_click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Centre_D_affaire.Properties.Resources.icons8_user_groups_32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(450, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Demander une demission";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnConge_Click);
            // 
            // ucListeDemandesEmp1
            // 
            this.ucListeDemandesEmp1.BackColor = System.Drawing.Color.White;
            this.ucListeDemandesEmp1.Location = new System.Drawing.Point(0, 40);
            this.ucListeDemandesEmp1.Name = "ucListeDemandesEmp1";
            this.ucListeDemandesEmp1.Size = new System.Drawing.Size(952, 529);
            this.ucListeDemandesEmp1.TabIndex = 10;
            // 
            // UCDemandesEmp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ucListeDemandesEmp1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListeDemandes);
            this.Name = "UCDemandesEmp";
            this.Size = new System.Drawing.Size(952, 569);
            this.Load += new System.EventHandler(this.UCDepartements_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnListeDemandes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UCListeDemandesEmp ucListeDemandesEmp1;
    }
}
