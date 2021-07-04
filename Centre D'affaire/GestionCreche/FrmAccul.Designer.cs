
namespace Centre_D_affaire.GestionCreche
{
    partial class FrmAccul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccul));
            this.pnlAcceuil = new System.Windows.Forms.Panel();
            this.btnCatalogue = new System.Windows.Forms.Button();
            this.btnInscription = new System.Windows.Forms.Button();
            this.btnPersonnel = new System.Windows.Forms.Button();
            this.pnlPersonnel = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPF = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlAcceuil.SuspendLayout();
            this.pnlPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcceuil
            // 
            this.pnlAcceuil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlAcceuil.Controls.Add(this.btnCatalogue);
            this.pnlAcceuil.Controls.Add(this.btnInscription);
            this.pnlAcceuil.Location = new System.Drawing.Point(1, 232);
            this.pnlAcceuil.Margin = new System.Windows.Forms.Padding(5);
            this.pnlAcceuil.Name = "pnlAcceuil";
            this.pnlAcceuil.Size = new System.Drawing.Size(669, 107);
            this.pnlAcceuil.TabIndex = 0;
            this.pnlAcceuil.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAcceuil_Paint);
            // 
            // btnCatalogue
            // 
            this.btnCatalogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogue.Location = new System.Drawing.Point(343, 0);
            this.btnCatalogue.Margin = new System.Windows.Forms.Padding(5);
            this.btnCatalogue.Name = "btnCatalogue";
            this.btnCatalogue.Size = new System.Drawing.Size(211, 107);
            this.btnCatalogue.TabIndex = 2;
            this.btnCatalogue.Text = "Catalogue";
            this.btnCatalogue.UseVisualStyleBackColor = true;
            this.btnCatalogue.Click += new System.EventHandler(this.btnCatalogue_Click);
            // 
            // btnInscription
            // 
            this.btnInscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscription.Location = new System.Drawing.Point(91, 0);
            this.btnInscription.Margin = new System.Windows.Forms.Padding(5);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(211, 107);
            this.btnInscription.TabIndex = 1;
            this.btnInscription.Text = "INSCRIRE MON ENFANT";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonnel.Location = new System.Drawing.Point(501, 0);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(169, 28);
            this.btnPersonnel.TabIndex = 3;
            this.btnPersonnel.Text = "Espace Personnel";
            this.btnPersonnel.UseVisualStyleBackColor = false;
            this.btnPersonnel.Click += new System.EventHandler(this.btnPersonnel_Click);
            // 
            // pnlPersonnel
            // 
            this.pnlPersonnel.Controls.Add(this.btnLogin);
            this.pnlPersonnel.Controls.Add(this.label3);
            this.pnlPersonnel.Controls.Add(this.cmbPF);
            this.pnlPersonnel.Controls.Add(this.label2);
            this.pnlPersonnel.Controls.Add(this.label1);
            this.pnlPersonnel.Controls.Add(this.txtMDP);
            this.pnlPersonnel.Controls.Add(this.txtName);
            this.pnlPersonnel.Location = new System.Drawing.Point(333, 25);
            this.pnlPersonnel.Name = "pnlPersonnel";
            this.pnlPersonnel.Size = new System.Drawing.Size(337, 152);
            this.pnlPersonnel.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(216, 115);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(80, 28);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "profil";
            // 
            // cmbPF
            // 
            this.cmbPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPF.FormattingEnabled = true;
            this.cmbPF.Location = new System.Drawing.Point(168, 75);
            this.cmbPF.Name = "cmbPF";
            this.cmbPF.Size = new System.Drawing.Size(128, 28);
            this.cmbPF.TabIndex = 8;
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // txtMDP
            // 
            this.txtMDP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMDP.Location = new System.Drawing.Point(168, 41);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.Size = new System.Drawing.Size(128, 19);
            this.txtMDP.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(168, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 19);
            this.txtName.TabIndex = 5;
            // 
            // FrmAccul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 478);
            this.Controls.Add(this.pnlPersonnel);
            this.Controls.Add(this.btnPersonnel);
            this.Controls.Add(this.pnlAcceuil);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAccul";
            this.Text = "FrmAccul";
            this.Load += new System.EventHandler(this.FrmAccul_Load);
            this.pnlAcceuil.ResumeLayout(false);
            this.pnlPersonnel.ResumeLayout(false);
            this.pnlPersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAcceuil;
        private System.Windows.Forms.Button btnCatalogue;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Button btnPersonnel;
        private System.Windows.Forms.Panel pnlPersonnel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPF;
        private System.Windows.Forms.Button btnLogin;
    }
}