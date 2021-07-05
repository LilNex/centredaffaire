namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class UCListeDepartement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtRechercheNom = new System.Windows.Forms.TextBox();
            this.txtRechercheNum = new System.Windows.Forms.TextBox();
            this.lblText_ParNom = new System.Windows.Forms.Label();
            this.lblText_ParNumero = new System.Windows.Forms.Label();
            this.lblText_Departements = new System.Windows.Forms.Label();
            this.dgvListePoste = new System.Windows.Forms.DataGridView();
            this.lblText_Postes = new System.Windows.Forms.Label();
            this.txtPRNom = new System.Windows.Forms.TextBox();
            this.txtPRNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListeDeps = new System.Windows.Forms.DataGridView();
            this.btnModifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePoste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDeps)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRechercheNom
            // 
            this.txtRechercheNom.BackColor = System.Drawing.Color.DarkGray;
            this.txtRechercheNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercheNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRechercheNom.Location = new System.Drawing.Point(144, 52);
            this.txtRechercheNom.Name = "txtRechercheNom";
            this.txtRechercheNom.Size = new System.Drawing.Size(124, 19);
            this.txtRechercheNom.TabIndex = 28;
            this.txtRechercheNom.TextChanged += new System.EventHandler(this.txtRechercheNom_TextChanged);
            // 
            // txtRechercheNum
            // 
            this.txtRechercheNum.BackColor = System.Drawing.Color.DarkGray;
            this.txtRechercheNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercheNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRechercheNum.Location = new System.Drawing.Point(7, 52);
            this.txtRechercheNum.Name = "txtRechercheNum";
            this.txtRechercheNum.Size = new System.Drawing.Size(124, 19);
            this.txtRechercheNum.TabIndex = 27;
            this.txtRechercheNum.TextChanged += new System.EventHandler(this.txtRechercheNum_TextChanged);
            // 
            // lblText_ParNom
            // 
            this.lblText_ParNom.AutoSize = true;
            this.lblText_ParNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_ParNom.Location = new System.Drawing.Point(141, 33);
            this.lblText_ParNom.Name = "lblText_ParNom";
            this.lblText_ParNom.Size = new System.Drawing.Size(64, 16);
            this.lblText_ParNom.TabIndex = 25;
            this.lblText_ParNom.Text = "Par nom :";
            // 
            // lblText_ParNumero
            // 
            this.lblText_ParNumero.AutoSize = true;
            this.lblText_ParNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_ParNumero.Location = new System.Drawing.Point(4, 33);
            this.lblText_ParNumero.Name = "lblText_ParNumero";
            this.lblText_ParNumero.Size = new System.Drawing.Size(83, 16);
            this.lblText_ParNumero.TabIndex = 24;
            this.lblText_ParNumero.Text = "Par numéro :";
            // 
            // lblText_Departements
            // 
            this.lblText_Departements.AutoSize = true;
            this.lblText_Departements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Departements.Location = new System.Drawing.Point(3, 0);
            this.lblText_Departements.Name = "lblText_Departements";
            this.lblText_Departements.Size = new System.Drawing.Size(137, 24);
            this.lblText_Departements.TabIndex = 23;
            this.lblText_Departements.Text = "Departements :";
            // 
            // dgvListePoste
            // 
            this.dgvListePoste.AllowUserToAddRows = false;
            this.dgvListePoste.AllowUserToDeleteRows = false;
            this.dgvListePoste.BackgroundColor = System.Drawing.Color.White;
            this.dgvListePoste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListePoste.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListePoste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListePoste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListePoste.EnableHeadersVisualStyles = false;
            this.dgvListePoste.Location = new System.Drawing.Point(549, 77);
            this.dgvListePoste.Name = "dgvListePoste";
            this.dgvListePoste.ReadOnly = true;
            this.dgvListePoste.RowHeadersVisible = false;
            this.dgvListePoste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListePoste.Size = new System.Drawing.Size(402, 414);
            this.dgvListePoste.TabIndex = 31;
            // 
            // lblText_Postes
            // 
            this.lblText_Postes.AutoSize = true;
            this.lblText_Postes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Postes.Location = new System.Drawing.Point(546, 0);
            this.lblText_Postes.Name = "lblText_Postes";
            this.lblText_Postes.Size = new System.Drawing.Size(76, 24);
            this.lblText_Postes.TabIndex = 32;
            this.lblText_Postes.Text = "Postes :";
            // 
            // txtPRNom
            // 
            this.txtPRNom.BackColor = System.Drawing.Color.DarkGray;
            this.txtPRNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPRNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPRNom.Location = new System.Drawing.Point(686, 52);
            this.txtPRNom.Name = "txtPRNom";
            this.txtPRNom.Size = new System.Drawing.Size(124, 19);
            this.txtPRNom.TabIndex = 36;
            this.txtPRNom.TextChanged += new System.EventHandler(this.txtPRNom_TextChanged);
            // 
            // txtPRNum
            // 
            this.txtPRNum.BackColor = System.Drawing.Color.DarkGray;
            this.txtPRNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPRNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPRNum.Location = new System.Drawing.Point(549, 52);
            this.txtPRNum.Name = "txtPRNum";
            this.txtPRNum.Size = new System.Drawing.Size(124, 19);
            this.txtPRNum.TabIndex = 35;
            this.txtPRNum.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(683, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Par nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Par numéro :";
            // 
            // dgvListeDeps
            // 
            this.dgvListeDeps.AllowUserToAddRows = false;
            this.dgvListeDeps.AllowUserToDeleteRows = false;
            this.dgvListeDeps.BackgroundColor = System.Drawing.Color.White;
            this.dgvListeDeps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeDeps.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            //this.dgvListeDeps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListeDeps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeDeps.EnableHeadersVisualStyles = false;
            this.dgvListeDeps.Location = new System.Drawing.Point(7, 77);
            this.dgvListeDeps.Name = "dgvListeDeps";
            this.dgvListeDeps.ReadOnly = true;
            this.dgvListeDeps.RowHeadersVisible = false;
            this.dgvListeDeps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListeDeps.Size = new System.Drawing.Size(402, 414);
            this.dgvListeDeps.TabIndex = 31;
            this.dgvListeDeps.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeDeps_CellContentClick);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Image = global::Centre_D_affaire.Properties.Resources.icons8_pencil_drawing_32px;
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(412, 364);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(0);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(134, 42);
            this.btnModifier.TabIndex = 37;
            this.btnModifier.Text = "Modifier le département";
            this.btnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // UCListeDepartement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvListeDeps);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.txtPRNom);
            this.Controls.Add(this.txtPRNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblText_Postes);
            this.Controls.Add(this.dgvListePoste);
            this.Controls.Add(this.txtRechercheNom);
            this.Controls.Add(this.txtRechercheNum);
            this.Controls.Add(this.lblText_ParNom);
            this.Controls.Add(this.lblText_ParNumero);
            this.Controls.Add(this.lblText_Departements);
            this.Name = "UCListeDepartement";
            this.Size = new System.Drawing.Size(952, 529);
            this.Load += new System.EventHandler(this.UCListeDepartement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePoste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDeps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRechercheNom;
        private System.Windows.Forms.TextBox txtRechercheNum;
        private System.Windows.Forms.Label lblText_ParNom;
        private System.Windows.Forms.Label lblText_ParNumero;
        private System.Windows.Forms.Label lblText_Departements;
        private System.Windows.Forms.DataGridView dgvListePoste;
        private System.Windows.Forms.Label lblText_Postes;
        private System.Windows.Forms.TextBox txtPRNom;
        private System.Windows.Forms.TextBox txtPRNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgvListeDeps;
    }
}
