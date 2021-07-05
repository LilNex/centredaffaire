
namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class UCModifPoste
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
            this.txtDepNom = new System.Windows.Forms.TextBox();
            this.txtDepNum = new System.Windows.Forms.TextBox();
            this.lblText_Prenom = new System.Windows.Forms.Label();
            this.lblText_Nom = new System.Windows.Forms.Label();
            this.lblText_Numero = new System.Windows.Forms.Label();
            this.lblText_Ajout = new System.Windows.Forms.Label();
            this.dgvListeEmploye = new System.Windows.Forms.DataGridView();
            this.cmbEmpManager = new System.Windows.Forms.ComboBox();
            this.btnSuppEmp = new System.Windows.Forms.Button();
            this.btnMofidDep = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEmploye)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDepNom
            // 
            this.txtDepNom.BackColor = System.Drawing.Color.DarkGray;
            this.txtDepNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDepNom.Location = new System.Drawing.Point(314, 42);
            this.txtDepNom.Name = "txtDepNom";
            this.txtDepNom.Size = new System.Drawing.Size(137, 19);
            this.txtDepNom.TabIndex = 122;
            // 
            // txtDepNum
            // 
            this.txtDepNum.BackColor = System.Drawing.Color.DarkGray;
            this.txtDepNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepNum.Location = new System.Drawing.Point(81, 42);
            this.txtDepNum.Name = "txtDepNum";
            this.txtDepNum.Size = new System.Drawing.Size(137, 19);
            this.txtDepNum.TabIndex = 121;
            // 
            // lblText_Prenom
            // 
            this.lblText_Prenom.AutoSize = true;
            this.lblText_Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Prenom.Location = new System.Drawing.Point(12, 79);
            this.lblText_Prenom.Name = "lblText_Prenom";
            this.lblText_Prenom.Size = new System.Drawing.Size(68, 16);
            this.lblText_Prenom.TabIndex = 120;
            this.lblText_Prenom.Text = "Manager :";
            // 
            // lblText_Nom
            // 
            this.lblText_Nom.AutoSize = true;
            this.lblText_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Nom.Location = new System.Drawing.Point(245, 45);
            this.lblText_Nom.Name = "lblText_Nom";
            this.lblText_Nom.Size = new System.Drawing.Size(43, 16);
            this.lblText_Nom.TabIndex = 119;
            this.lblText_Nom.Text = "Nom :";
            // 
            // lblText_Numero
            // 
            this.lblText_Numero.AutoSize = true;
            this.lblText_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Numero.Location = new System.Drawing.Point(12, 45);
            this.lblText_Numero.Name = "lblText_Numero";
            this.lblText_Numero.Size = new System.Drawing.Size(62, 16);
            this.lblText_Numero.TabIndex = 118;
            this.lblText_Numero.Text = "Numéro :";
            // 
            // lblText_Ajout
            // 
            this.lblText_Ajout.AutoSize = true;
            this.lblText_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Ajout.Location = new System.Drawing.Point(12, 11);
            this.lblText_Ajout.Name = "lblText_Ajout";
            this.lblText_Ajout.Size = new System.Drawing.Size(199, 24);
            this.lblText_Ajout.TabIndex = 117;
            this.lblText_Ajout.Text = "Modification du Poste :";
            // 
            // dgvListeEmploye
            // 
            this.dgvListeEmploye.BackgroundColor = System.Drawing.Color.White;
            this.dgvListeEmploye.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeEmploye.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvListeEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeEmploye.Location = new System.Drawing.Point(16, 145);
            this.dgvListeEmploye.Name = "dgvListeEmploye";
            this.dgvListeEmploye.Size = new System.Drawing.Size(477, 341);
            this.dgvListeEmploye.TabIndex = 130;
            // 
            // cmbEmpManager
            // 
            this.cmbEmpManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpManager.FormattingEnabled = true;
            this.cmbEmpManager.Location = new System.Drawing.Point(81, 78);
            this.cmbEmpManager.Name = "cmbEmpManager";
            this.cmbEmpManager.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpManager.TabIndex = 134;
            // 
            // btnSuppEmp
            // 
            this.btnSuppEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuppEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnSuppEmp.FlatAppearance.BorderSize = 0;
            this.btnSuppEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppEmp.ForeColor = System.Drawing.Color.White;
            this.btnSuppEmp.Image = global::Centre_D_affaire.Properties.Resources.icons8_multiply_26px_4;
            this.btnSuppEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppEmp.Location = new System.Drawing.Point(499, 145);
            this.btnSuppEmp.Name = "btnSuppEmp";
            this.btnSuppEmp.Size = new System.Drawing.Size(113, 39);
            this.btnSuppEmp.TabIndex = 133;
            this.btnSuppEmp.Text = "Supprimer l\'employé";
            this.btnSuppEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuppEmp.UseVisualStyleBackColor = false;
            this.btnSuppEmp.Click += new System.EventHandler(this.btnSuppEmp_Click);
            // 
            // btnMofidDep
            // 
            this.btnMofidDep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMofidDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnMofidDep.FlatAppearance.BorderSize = 0;
            this.btnMofidDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMofidDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMofidDep.ForeColor = System.Drawing.Color.White;
            this.btnMofidDep.Image = global::Centre_D_affaire.Properties.Resources.icons8_pencil_drawing_32px;
            this.btnMofidDep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMofidDep.Location = new System.Drawing.Point(827, 434);
            this.btnMofidDep.Name = "btnMofidDep";
            this.btnMofidDep.Size = new System.Drawing.Size(113, 39);
            this.btnMofidDep.TabIndex = 132;
            this.btnMofidDep.Text = "Modifier";
            this.btnMofidDep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMofidDep.UseVisualStyleBackColor = false;
            this.btnMofidDep.Click += new System.EventHandler(this.btnMofidDep_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEffacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnEffacer.FlatAppearance.BorderSize = 0;
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer.ForeColor = System.Drawing.Color.White;
            this.btnEffacer.Image = global::Centre_D_affaire.Properties.Resources.icons8_multiply_26px_4;
            this.btnEffacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEffacer.Location = new System.Drawing.Point(827, 479);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(113, 39);
            this.btnEffacer.TabIndex = 131;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // UCModifPoste
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbEmpManager);
            this.Controls.Add(this.btnSuppEmp);
            this.Controls.Add(this.btnMofidDep);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.dgvListeEmploye);
            this.Controls.Add(this.txtDepNom);
            this.Controls.Add(this.txtDepNum);
            this.Controls.Add(this.lblText_Prenom);
            this.Controls.Add(this.lblText_Nom);
            this.Controls.Add(this.lblText_Numero);
            this.Controls.Add(this.lblText_Ajout);
            this.Name = "UCModifPoste";
            this.Size = new System.Drawing.Size(952, 529);
            this.Load += new System.EventHandler(this.UCModifDepartement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEmploye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDepNom;
        private System.Windows.Forms.TextBox txtDepNum;
        private System.Windows.Forms.Label lblText_Prenom;
        private System.Windows.Forms.Label lblText_Nom;
        private System.Windows.Forms.Label lblText_Numero;
        private System.Windows.Forms.Label lblText_Ajout;
        private System.Windows.Forms.DataGridView dgvListeEmploye;
        private System.Windows.Forms.Button btnMofidDep;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnSuppEmp;
        private System.Windows.Forms.ComboBox cmbEmpManager;
    }
}
