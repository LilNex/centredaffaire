
namespace Centre_D_affaire.LocationEspacesSalleReunion
{
    partial class ListeFactures
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgvFactures = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactures)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Factures : ";
            // 
            // dgvFactures
            // 
            this.dgvFactures.AllowUserToAddRows = false;
            this.dgvFactures.AllowUserToDeleteRows = false;
            this.dgvFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactures.Location = new System.Drawing.Point(16, 36);
            this.dgvFactures.Name = "dgvFactures";
            this.dgvFactures.ReadOnly = true;
            this.dgvFactures.RowHeadersVisible = false;
            this.dgvFactures.Size = new System.Drawing.Size(541, 389);
            this.dgvFactures.TabIndex = 29;
            this.dgvFactures.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactures_CellDoubleClick);
            // 
            // ListeFactures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 437);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvFactures);
            this.Name = "ListeFactures";
            this.Text = "Liste des Factures";
            this.Load += new System.EventHandler(this.ListeFactures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvFactures;
    }
}