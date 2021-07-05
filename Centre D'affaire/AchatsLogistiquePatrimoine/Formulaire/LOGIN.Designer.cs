
namespace Centre_D_affaire
{
    partial class LOGIN
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
            this.lblusername = new System.Windows.Forms.Label();
            this.lblmdp = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtmdp = new System.Windows.Forms.TextBox();
            this.pnllogin = new System.Windows.Forms.Panel();
            this.lblprofil = new System.Windows.Forms.Label();
            this.cmbprofil = new System.Windows.Forms.ComboBox();
            this.lbllogin = new System.Windows.Forms.Label();
            this.lbltitre = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.chboxlogin = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnllogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblusername.Location = new System.Drawing.Point(4, 99);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(56, 23);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Nom";
            // 
            // lblmdp
            // 
            this.lblmdp.AutoSize = true;
            this.lblmdp.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmdp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmdp.Location = new System.Drawing.Point(3, 159);
            this.lblmdp.Name = "lblmdp";
            this.lblmdp.Size = new System.Drawing.Size(108, 23);
            this.lblmdp.TabIndex = 1;
            this.lblmdp.Text = "Password";
            // 
            // txtnom
            // 
            this.txtnom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnom.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(146, 99);
            this.txtnom.Multiline = true;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(158, 23);
            this.txtnom.TabIndex = 2;
            this.txtnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmdp
            // 
            this.txtmdp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmdp.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmdp.Location = new System.Drawing.Point(146, 159);
            this.txtmdp.Multiline = true;
            this.txtmdp.Name = "txtmdp";
            this.txtmdp.Size = new System.Drawing.Size(158, 23);
            this.txtmdp.TabIndex = 3;
            this.txtmdp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnllogin
            // 
            this.pnllogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnllogin.Controls.Add(this.lblprofil);
            this.pnllogin.Controls.Add(this.cmbprofil);
            this.pnllogin.Controls.Add(this.lbllogin);
            this.pnllogin.Controls.Add(this.txtmdp);
            this.pnllogin.Controls.Add(this.lblmdp);
            this.pnllogin.Controls.Add(this.txtnom);
            this.pnllogin.Controls.Add(this.lblusername);
            this.pnllogin.Location = new System.Drawing.Point(69, 82);
            this.pnllogin.Name = "pnllogin";
            this.pnllogin.Size = new System.Drawing.Size(331, 335);
            this.pnllogin.TabIndex = 4;
            // 
            // lblprofil
            // 
            this.lblprofil.AutoSize = true;
            this.lblprofil.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprofil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblprofil.Location = new System.Drawing.Point(3, 232);
            this.lblprofil.Name = "lblprofil";
            this.lblprofil.Size = new System.Drawing.Size(71, 25);
            this.lblprofil.TabIndex = 6;
            this.lblprofil.Text = "Profil";
            // 
            // cmbprofil
            // 
            this.cmbprofil.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbprofil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbprofil.FormattingEnabled = true;
            this.cmbprofil.Items.AddRange(new object[] {
            "Directeur",
            "Responsable Achat",
            "Responsable Commercial"});
            this.cmbprofil.Location = new System.Drawing.Point(146, 232);
            this.cmbprofil.Name = "cmbprofil";
            this.cmbprofil.Size = new System.Drawing.Size(158, 24);
            this.cmbprofil.TabIndex = 5;
            this.cmbprofil.SelectedIndexChanged += new System.EventHandler(this.cmbprofil_SelectedIndexChanged);
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbllogin.Location = new System.Drawing.Point(112, 21);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(104, 34);
            this.lbllogin.TabIndex = 4;
            this.lbllogin.Text = "LOGIN";
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltitre.Location = new System.Drawing.Point(123, 19);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(229, 34);
            this.lbltitre.TabIndex = 5;
            this.lbltitre.Text = "SERVICE ACHAT";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnlogin.Location = new System.Drawing.Point(129, 447);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(228, 52);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "VALIDER";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // chboxlogin
            // 
            this.chboxlogin.AutoSize = true;
            this.chboxlogin.BackColor = System.Drawing.Color.Transparent;
            this.chboxlogin.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxlogin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.chboxlogin.Location = new System.Drawing.Point(215, 526);
            this.chboxlogin.Name = "chboxlogin";
            this.chboxlogin.Size = new System.Drawing.Size(238, 24);
            this.chboxlogin.TabIndex = 7;
            this.chboxlogin.Text = "Afficher le mot de passe";
            this.chboxlogin.UseVisualStyleBackColor = false;
            this.chboxlogin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(72, 526);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Profil";
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(480, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chboxlogin);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.pnllogin);
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.pnllogin.ResumeLayout(false);
            this.pnllogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblmdp;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtmdp;
        private System.Windows.Forms.Panel pnllogin;
        private System.Windows.Forms.Label lblprofil;
        private System.Windows.Forms.ComboBox cmbprofil;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label lbltitre;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.CheckBox chboxlogin;
        private System.Windows.Forms.Label label1;
    }
}