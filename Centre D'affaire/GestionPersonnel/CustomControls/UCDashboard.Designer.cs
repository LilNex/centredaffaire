
namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class UCDashboard
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
            this.lblDateNow = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDemandsCongé = new System.Windows.Forms.Label();
            this.lblText_DemandeDemission = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDemissionAttente = new System.Windows.Forms.Label();
            this.pnlInfoEmployé = new System.Windows.Forms.Panel();
            this.lblEmployesAbsent = new System.Windows.Forms.Label();
            this.lblText_EmployesAbsent = new System.Windows.Forms.Label();
            this.lblEmployesPresent = new System.Windows.Forms.Label();
            this.lbl_TextEmploye = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlInfoEmployé.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateNow
            // 
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNow.Location = new System.Drawing.Point(19, 17);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(284, 56);
            this.lblDateNow.TabIndex = 6;
            this.lblDateNow.Text = "$DateTime.Now$";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.lblDemandsCongé);
            this.panel1.Controls.Add(this.lblText_DemandeDemission);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblDemissionAttente);
            this.panel1.Location = new System.Drawing.Point(194, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 5;
            // 
            // lblDemandsCongé
            // 
            this.lblDemandsCongé.AutoSize = true;
            this.lblDemandsCongé.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemandsCongé.ForeColor = System.Drawing.Color.White;
            this.lblDemandsCongé.Location = new System.Drawing.Point(7, 84);
            this.lblDemandsCongé.Name = "lblDemandsCongé";
            this.lblDemandsCongé.Size = new System.Drawing.Size(25, 30);
            this.lblDemandsCongé.TabIndex = 7;
            this.lblDemandsCongé.Text = "0";
            // 
            // lblText_DemandeDemission
            // 
            this.lblText_DemandeDemission.AutoSize = true;
            this.lblText_DemandeDemission.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_DemandeDemission.ForeColor = System.Drawing.Color.White;
            this.lblText_DemandeDemission.Location = new System.Drawing.Point(4, 16);
            this.lblText_DemandeDemission.Name = "lblText_DemandeDemission";
            this.lblText_DemandeDemission.Size = new System.Drawing.Size(144, 17);
            this.lblText_DemandeDemission.TabIndex = 4;
            this.lblText_DemandeDemission.Text = "Démission en attente :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Congé en attente :";
            // 
            // lblDemissionAttente
            // 
            this.lblDemissionAttente.AutoSize = true;
            this.lblDemissionAttente.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemissionAttente.ForeColor = System.Drawing.Color.White;
            this.lblDemissionAttente.Location = new System.Drawing.Point(7, 35);
            this.lblDemissionAttente.Name = "lblDemissionAttente";
            this.lblDemissionAttente.Size = new System.Drawing.Size(25, 30);
            this.lblDemissionAttente.TabIndex = 5;
            this.lblDemissionAttente.Text = "0";
            // 
            // pnlInfoEmployé
            // 
            this.pnlInfoEmployé.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInfoEmployé.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
            this.pnlInfoEmployé.Controls.Add(this.lblEmployesAbsent);
            this.pnlInfoEmployé.Controls.Add(this.lblText_EmployesAbsent);
            this.pnlInfoEmployé.Controls.Add(this.lblEmployesPresent);
            this.pnlInfoEmployé.Controls.Add(this.lbl_TextEmploye);
            this.pnlInfoEmployé.Location = new System.Drawing.Point(45, 362);
            this.pnlInfoEmployé.Margin = new System.Windows.Forms.Padding(0);
            this.pnlInfoEmployé.Name = "pnlInfoEmployé";
            this.pnlInfoEmployé.Size = new System.Drawing.Size(150, 150);
            this.pnlInfoEmployé.TabIndex = 4;
            // 
            // lblEmployesAbsent
            // 
            this.lblEmployesAbsent.AutoSize = true;
            this.lblEmployesAbsent.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployesAbsent.ForeColor = System.Drawing.Color.White;
            this.lblEmployesAbsent.Location = new System.Drawing.Point(6, 84);
            this.lblEmployesAbsent.Name = "lblEmployesAbsent";
            this.lblEmployesAbsent.Size = new System.Drawing.Size(25, 30);
            this.lblEmployesAbsent.TabIndex = 3;
            this.lblEmployesAbsent.Text = "0";
            // 
            // lblText_EmployesAbsent
            // 
            this.lblText_EmployesAbsent.AutoSize = true;
            this.lblText_EmployesAbsent.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_EmployesAbsent.ForeColor = System.Drawing.Color.White;
            this.lblText_EmployesAbsent.Location = new System.Drawing.Point(3, 65);
            this.lblText_EmployesAbsent.Name = "lblText_EmployesAbsent";
            this.lblText_EmployesAbsent.Size = new System.Drawing.Size(118, 17);
            this.lblText_EmployesAbsent.TabIndex = 2;
            this.lblText_EmployesAbsent.Text = "Employés absent :";
            // 
            // lblEmployesPresent
            // 
            this.lblEmployesPresent.AutoSize = true;
            this.lblEmployesPresent.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployesPresent.ForeColor = System.Drawing.Color.White;
            this.lblEmployesPresent.Location = new System.Drawing.Point(6, 35);
            this.lblEmployesPresent.Name = "lblEmployesPresent";
            this.lblEmployesPresent.Size = new System.Drawing.Size(25, 30);
            this.lblEmployesPresent.TabIndex = 1;
            this.lblEmployesPresent.Text = "0";
            // 
            // lbl_TextEmploye
            // 
            this.lbl_TextEmploye.AutoSize = true;
            this.lbl_TextEmploye.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TextEmploye.ForeColor = System.Drawing.Color.White;
            this.lbl_TextEmploye.Location = new System.Drawing.Point(3, 16);
            this.lbl_TextEmploye.Name = "lbl_TextEmploye";
            this.lbl_TextEmploye.Size = new System.Drawing.Size(123, 17);
            this.lbl_TextEmploye.TabIndex = 0;
            this.lbl_TextEmploye.Text = "Employés présent :";
            // 
            // UCDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblDateNow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlInfoEmployé);
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(946, 563);
            this.Load += new System.EventHandler(this.UCDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlInfoEmployé.ResumeLayout(false);
            this.pnlInfoEmployé.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblDateNow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDemandsCongé;
        private System.Windows.Forms.Label lblText_DemandeDemission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDemissionAttente;
        private System.Windows.Forms.Panel pnlInfoEmployé;
        private System.Windows.Forms.Label lblEmployesAbsent;
        private System.Windows.Forms.Label lblText_EmployesAbsent;
        private System.Windows.Forms.Label lblEmployesPresent;
        private System.Windows.Forms.Label lbl_TextEmploye;
    }
}
