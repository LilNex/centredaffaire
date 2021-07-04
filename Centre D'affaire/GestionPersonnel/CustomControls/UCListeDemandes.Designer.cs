namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class UCListeDemandes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtRechercheNom = new System.Windows.Forms.TextBox();
            this.txtRechercheNum = new System.Windows.Forms.TextBox();
            this.lblText_ParNom = new System.Windows.Forms.Label();
            this.lblText_ParNumero = new System.Windows.Forms.Label();
            this.lblText_Departements = new System.Windows.Forms.Label();
            this.dgvListeDemandes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDemandes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRechercheNom
            // 
            this.txtRechercheNom.BackColor = System.Drawing.Color.DarkGray;
            this.txtRechercheNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercheNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRechercheNom.Location = new System.Drawing.Point(286, 52);
            this.txtRechercheNom.Name = "txtRechercheNom";
            this.txtRechercheNom.Size = new System.Drawing.Size(124, 19);
            this.txtRechercheNom.TabIndex = 33;
            // 
            // txtRechercheNum
            // 
            this.txtRechercheNum.BackColor = System.Drawing.Color.DarkGray;
            this.txtRechercheNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercheNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRechercheNum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtRechercheNum.Location = new System.Drawing.Point(149, 52);
            this.txtRechercheNum.Name = "txtRechercheNum";
            this.txtRechercheNum.Size = new System.Drawing.Size(124, 19);
            this.txtRechercheNum.TabIndex = 32;
            // 
            // lblText_ParNom
            // 
            this.lblText_ParNom.AutoSize = true;
            this.lblText_ParNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_ParNom.Location = new System.Drawing.Point(283, 33);
            this.lblText_ParNom.Name = "lblText_ParNom";
            this.lblText_ParNom.Size = new System.Drawing.Size(64, 16);
            this.lblText_ParNom.TabIndex = 31;
            this.lblText_ParNom.Text = "Par nom :";
            // 
            // lblText_ParNumero
            // 
            this.lblText_ParNumero.AutoSize = true;
            this.lblText_ParNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_ParNumero.Location = new System.Drawing.Point(146, 33);
            this.lblText_ParNumero.Name = "lblText_ParNumero";
            this.lblText_ParNumero.Size = new System.Drawing.Size(83, 16);
            this.lblText_ParNumero.TabIndex = 30;
            this.lblText_ParNumero.Text = "Par numéro :";
            // 
            // lblText_Departements
            // 
            this.lblText_Departements.AutoSize = true;
            this.lblText_Departements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Departements.Location = new System.Drawing.Point(3, 0);
            this.lblText_Departements.Name = "lblText_Departements";
            this.lblText_Departements.Size = new System.Drawing.Size(191, 24);
            this.lblText_Departements.TabIndex = 29;
            this.lblText_Departements.Text = "Liste des Demandes :";
            // 
            // dgvListeDemandes
            // 
            this.dgvListeDemandes.AllowUserToAddRows = false;
            this.dgvListeDemandes.AllowUserToDeleteRows = false;
            this.dgvListeDemandes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListeDemandes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeDemandes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListeDemandes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListeDemandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeDemandes.EnableHeadersVisualStyles = false;
            this.dgvListeDemandes.Location = new System.Drawing.Point(7, 77);
            this.dgvListeDemandes.Name = "dgvListeDemandes";
            this.dgvListeDemandes.ReadOnly = true;
            this.dgvListeDemandes.RowHeadersVisible = false;
            this.dgvListeDemandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListeDemandes.Size = new System.Drawing.Size(402, 414);
            this.dgvListeDemandes.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Type de demandes :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UCListeDemandes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListeDemandes);
            this.Controls.Add(this.txtRechercheNom);
            this.Controls.Add(this.txtRechercheNum);
            this.Controls.Add(this.lblText_ParNom);
            this.Controls.Add(this.lblText_ParNumero);
            this.Controls.Add(this.lblText_Departements);
            this.Name = "UCListeDemandes";
            this.Size = new System.Drawing.Size(952, 529);
            this.Load += new System.EventHandler(this.UCListeDemandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDemandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRechercheNom;
        private System.Windows.Forms.TextBox txtRechercheNum;
        private System.Windows.Forms.Label lblText_ParNom;
        private System.Windows.Forms.Label lblText_ParNumero;
        private System.Windows.Forms.Label lblText_Departements;
        private System.Windows.Forms.DataGridView dgvListeDemandes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
