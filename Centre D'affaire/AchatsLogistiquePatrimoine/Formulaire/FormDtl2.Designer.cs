
namespace Centre_D_affaire.AchatsLogistiquePatrimoine.Formulaire
{
    partial class FormDtl2
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCMd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCMd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTE DE VOTRE COMMANDE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvCMd
            // 
            this.dgvCMd.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvCMd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCMd.Location = new System.Drawing.Point(12, 52);
            this.dgvCMd.Name = "dgvCMd";
            this.dgvCMd.Size = new System.Drawing.Size(420, 364);
            this.dgvCMd.TabIndex = 3;
            this.dgvCMd.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvCMd_Paint);
            // 
            // FormDtl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 428);
            this.Controls.Add(this.dgvCMd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(800, 150);
            this.Name = "FormDtl2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormDtl2";
            this.Load += new System.EventHandler(this.FormDtl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCMd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCMd;
    }
}