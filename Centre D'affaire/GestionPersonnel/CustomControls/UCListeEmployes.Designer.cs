
namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class UCListeEmployes
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
            this.lblText_Recherche = new System.Windows.Forms.Label();
            this.dgvListeEmployes = new System.Windows.Forms.DataGridView();
            this.lblText_ParPrenom = new System.Windows.Forms.Label();
            this.txtRecherchePrenom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEmployes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRechercheNom
            // 
            this.txtRechercheNom.BackColor = System.Drawing.Color.DarkGray;
            this.txtRechercheNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercheNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRechercheNom.Location = new System.Drawing.Point(145, 45);
            this.txtRechercheNom.Name = "txtRechercheNom";
            this.txtRechercheNom.Size = new System.Drawing.Size(124, 19);
            this.txtRechercheNom.TabIndex = 14;
            this.txtRechercheNom.TextChanged += new System.EventHandler(this.txtRechercheNom_TextChanged);
            // 
            // txtRechercheNum
            // 
            this.txtRechercheNum.BackColor = System.Drawing.Color.DarkGray;
            this.txtRechercheNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercheNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRechercheNum.Location = new System.Drawing.Point(8, 45);
            this.txtRechercheNum.Name = "txtRechercheNum";
            this.txtRechercheNum.Size = new System.Drawing.Size(124, 19);
            this.txtRechercheNum.TabIndex = 13;
            this.txtRechercheNum.TextChanged += new System.EventHandler(this.txtRechercheNum_TextChanged);
            // 
            // lblText_ParNom
            // 
            this.lblText_ParNom.AutoSize = true;
            this.lblText_ParNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_ParNom.Location = new System.Drawing.Point(142, 25);
            this.lblText_ParNom.Name = "lblText_ParNom";
            this.lblText_ParNom.Size = new System.Drawing.Size(64, 16);
            this.lblText_ParNom.TabIndex = 11;
            this.lblText_ParNom.Text = "Par nom :";
            // 
            // lblText_ParNumero
            // 
            this.lblText_ParNumero.AutoSize = true;
            this.lblText_ParNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_ParNumero.Location = new System.Drawing.Point(5, 25);
            this.lblText_ParNumero.Name = "lblText_ParNumero";
            this.lblText_ParNumero.Size = new System.Drawing.Size(83, 16);
            this.lblText_ParNumero.TabIndex = 10;
            this.lblText_ParNumero.Text = "Par numéro :";
            // 
            // lblText_Recherche
            // 
            this.lblText_Recherche.AutoSize = true;
            this.lblText_Recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Recherche.Location = new System.Drawing.Point(3, 0);
            this.lblText_Recherche.Name = "lblText_Recherche";
            this.lblText_Recherche.Size = new System.Drawing.Size(108, 24);
            this.lblText_Recherche.TabIndex = 9;
            this.lblText_Recherche.Text = "Recheche :";
            // 
            // dgvListeEmployes
            // 
            this.dgvListeEmployes.AllowUserToAddRows = false;
            this.dgvListeEmployes.AllowUserToDeleteRows = false;
            this.dgvListeEmployes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListeEmployes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeEmployes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListeEmployes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListeEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeEmployes.EnableHeadersVisualStyles = false;
            this.dgvListeEmployes.Location = new System.Drawing.Point(8, 112);
            this.dgvListeEmployes.Name = "dgvListeEmployes";
            this.dgvListeEmployes.ReadOnly = true;
            this.dgvListeEmployes.RowHeadersVisible = false;
            this.dgvListeEmployes.Size = new System.Drawing.Size(493, 414);
            this.dgvListeEmployes.TabIndex = 16;
            // 
            // lblText_ParPrenom
            // 
            this.lblText_ParPrenom.AutoSize = true;
            this.lblText_ParPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_ParPrenom.Location = new System.Drawing.Point(275, 25);
            this.lblText_ParPrenom.Name = "lblText_ParPrenom";
            this.lblText_ParPrenom.Size = new System.Drawing.Size(84, 16);
            this.lblText_ParPrenom.TabIndex = 12;
            this.lblText_ParPrenom.Text = "Par prénom :";
            // 
            // txtRecherchePrenom
            // 
            this.txtRecherchePrenom.BackColor = System.Drawing.Color.DarkGray;
            this.txtRecherchePrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecherchePrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRecherchePrenom.Location = new System.Drawing.Point(278, 45);
            this.txtRecherchePrenom.Name = "txtRecherchePrenom";
            this.txtRecherchePrenom.Size = new System.Drawing.Size(124, 19);
            this.txtRecherchePrenom.TabIndex = 15;
            // 
            // UCListeEmployes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.dgvListeEmployes);
            this.Controls.Add(this.txtRecherchePrenom);
            this.Controls.Add(this.txtRechercheNom);
            this.Controls.Add(this.txtRechercheNum);
            this.Controls.Add(this.lblText_ParPrenom);
            this.Controls.Add(this.lblText_ParNom);
            this.Controls.Add(this.lblText_ParNumero);
            this.Controls.Add(this.lblText_Recherche);
            this.Name = "UCListeEmployes";
            this.Size = new System.Drawing.Size(952, 529);
            this.Load += new System.EventHandler(this.UCListeEmployes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEmployes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRechercheNom;
        private System.Windows.Forms.TextBox txtRechercheNum;
        private System.Windows.Forms.Label lblText_ParNom;
        private System.Windows.Forms.Label lblText_ParNumero;
        private System.Windows.Forms.Label lblText_Recherche;
        private System.Windows.Forms.DataGridView dgvListeEmployes;
        private System.Windows.Forms.Label lblText_ParPrenom;
        private System.Windows.Forms.TextBox txtRecherchePrenom;
    }
}
