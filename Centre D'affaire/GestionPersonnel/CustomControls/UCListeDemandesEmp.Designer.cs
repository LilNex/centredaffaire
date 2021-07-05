namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class UCListeDemandesEmp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblText_Departements = new System.Windows.Forms.Label();
            this.dgvListeDemandes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDemandes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText_Departements
            // 
            this.lblText_Departements.AutoSize = true;
            this.lblText_Departements.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Departements.Location = new System.Drawing.Point(3, 0);
            this.lblText_Departements.Name = "lblText_Departements";
            this.lblText_Departements.Size = new System.Drawing.Size(216, 24);
            this.lblText_Departements.TabIndex = 29;
            this.lblText_Departements.Text = "Liste de vos Demandes :";
            // 
            // dgvListeDemandes
            // 
            this.dgvListeDemandes.AllowUserToAddRows = false;
            this.dgvListeDemandes.AllowUserToDeleteRows = false;
            this.dgvListeDemandes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListeDemandes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeDemandes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListeDemandes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListeDemandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeDemandes.EnableHeadersVisualStyles = false;
            this.dgvListeDemandes.Location = new System.Drawing.Point(7, 65);
            this.dgvListeDemandes.Name = "dgvListeDemandes";
            this.dgvListeDemandes.ReadOnly = true;
            this.dgvListeDemandes.RowHeadersVisible = false;
            this.dgvListeDemandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListeDemandes.Size = new System.Drawing.Size(402, 426);
            this.dgvListeDemandes.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Type de demandes :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 37;
            // 
            // UCListeDemandesEmp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListeDemandes);
            this.Controls.Add(this.lblText_Departements);
            this.Name = "UCListeDemandesEmp";
            this.Size = new System.Drawing.Size(952, 529);
            this.Load += new System.EventHandler(this.UCListeDemandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDemandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblText_Departements;
        private System.Windows.Forms.DataGridView dgvListeDemandes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
