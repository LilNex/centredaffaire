
namespace Centre_D_affaire.AchatsLogistiquePatrimoine.Formulaire
{
    partial class FormDTldemande
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartement = new System.Windows.Forms.ComboBox();
            this.txtLibele = new System.Windows.Forms.TextBox();
            this.txtresponsable = new System.Windows.Forms.TextBox();
            this.lblSignature = new System.Windows.Forms.Label();
            this.btnSignature = new System.Windows.Forms.Button();
            this.btnSigner = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.rdbNomal = new System.Windows.Forms.RadioButton();
            this.rdbUrgent = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Détail de votre demande";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Responsable département :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Libelé :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Urgence :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Département :";
            // 
            // cmbDepartement
            // 
            this.cmbDepartement.BackColor = System.Drawing.Color.PeachPuff;
            this.cmbDepartement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartement.FormattingEnabled = true;
            this.cmbDepartement.Location = new System.Drawing.Point(290, 123);
            this.cmbDepartement.Name = "cmbDepartement";
            this.cmbDepartement.Size = new System.Drawing.Size(173, 21);
            this.cmbDepartement.TabIndex = 7;
            this.cmbDepartement.SelectedIndexChanged += new System.EventHandler(this.cmbDepartement_SelectedIndexChanged);
            // 
            // txtLibele
            // 
            this.txtLibele.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLibele.Location = new System.Drawing.Point(142, 317);
            this.txtLibele.Multiline = true;
            this.txtLibele.Name = "txtLibele";
            this.txtLibele.Size = new System.Drawing.Size(321, 86);
            this.txtLibele.TabIndex = 10;
            // 
            // txtresponsable
            // 
            this.txtresponsable.Location = new System.Drawing.Point(290, 174);
            this.txtresponsable.Name = "txtresponsable";
            this.txtresponsable.Size = new System.Drawing.Size(173, 20);
            this.txtresponsable.TabIndex = 11;
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.BackColor = System.Drawing.Color.Transparent;
            this.lblSignature.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.Location = new System.Drawing.Point(39, 524);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(91, 20);
            this.lblSignature.TabIndex = 12;
            this.lblSignature.Text = "Signature :";
            this.lblSignature.Click += new System.EventHandler(this.lblSignature_Click);
            // 
            // btnSignature
            // 
            this.btnSignature.BackColor = System.Drawing.Color.White;
            this.btnSignature.BackgroundImage = global::Centre_D_affaire.Properties.Resources.signature;
            this.btnSignature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignature.FlatAppearance.BorderSize = 0;
            this.btnSignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignature.Location = new System.Drawing.Point(37, 574);
            this.btnSignature.Name = "btnSignature";
            this.btnSignature.Size = new System.Drawing.Size(98, 70);
            this.btnSignature.TabIndex = 13;
            this.btnSignature.UseVisualStyleBackColor = false;
            // 
            // btnSigner
            // 
            this.btnSigner.BackColor = System.Drawing.Color.Transparent;
            this.btnSigner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSigner.Location = new System.Drawing.Point(142, 524);
            this.btnSigner.Name = "btnSigner";
            this.btnSigner.Size = new System.Drawing.Size(53, 26);
            this.btnSigner.TabIndex = 14;
            this.btnSigner.Text = "Signer ";
            this.btnSigner.UseVisualStyleBackColor = false;
            this.btnSigner.Click += new System.EventHandler(this.btnSigner_Click);
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(142, 444);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(109, 20);
            this.dtp.TabIndex = 15;
            this.dtp.Value = new System.DateTime(2021, 7, 3, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Réalisé le :";
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Transparent;
            this.btnRetour.BackgroundImage = global::Centre_D_affaire.Properties.Resources.WhatsApp_Image_2021_07_03_at_10_31_21;
            this.btnRetour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRetour.Location = new System.Drawing.Point(416, 642);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(47, 41);
            this.btnRetour.TabIndex = 17;
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.Transparent;
            this.btnValider.BackgroundImage = global::Centre_D_affaire.Properties.Resources.WhatsApp_Image_2021_07_03_at_10_31_30;
            this.btnValider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnValider.Location = new System.Drawing.Point(469, 642);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(47, 41);
            this.btnValider.TabIndex = 18;
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // rdbNomal
            // 
            this.rdbNomal.AutoSize = true;
            this.rdbNomal.BackColor = System.Drawing.Color.Transparent;
            this.rdbNomal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNomal.Location = new System.Drawing.Point(158, 239);
            this.rdbNomal.Name = "rdbNomal";
            this.rdbNomal.Size = new System.Drawing.Size(82, 21);
            this.rdbNomal.TabIndex = 19;
            this.rdbNomal.TabStop = true;
            this.rdbNomal.Text = "Normale";
            this.rdbNomal.UseVisualStyleBackColor = false;
            // 
            // rdbUrgent
            // 
            this.rdbUrgent.AutoSize = true;
            this.rdbUrgent.BackColor = System.Drawing.Color.Transparent;
            this.rdbUrgent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUrgent.Location = new System.Drawing.Point(276, 239);
            this.rdbUrgent.Name = "rdbUrgent";
            this.rdbUrgent.Size = new System.Drawing.Size(68, 21);
            this.rdbUrgent.TabIndex = 20;
            this.rdbUrgent.TabStop = true;
            this.rdbUrgent.Text = "Urgent";
            this.rdbUrgent.UseVisualStyleBackColor = false;
            // 
            // FormDTldemande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Centre_D_affaire.Properties.Resources.dtlDemande;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 695);
            this.Controls.Add(this.rdbUrgent);
            this.Controls.Add(this.rdbNomal);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btnSigner);
            this.Controls.Add(this.btnSignature);
            this.Controls.Add(this.lblSignature);
            this.Controls.Add(this.txtresponsable);
            this.Controls.Add(this.txtLibele);
            this.Controls.Add(this.cmbDepartement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(150, 100);
            this.Name = "FormDTldemande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormDTldemande";
            this.Load += new System.EventHandler(this.FormDTldemande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartement;
        private System.Windows.Forms.TextBox txtLibele;
        private System.Windows.Forms.TextBox txtresponsable;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Button btnSignature;
        private System.Windows.Forms.Button btnSigner;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.RadioButton rdbNomal;
        private System.Windows.Forms.RadioButton rdbUrgent;
    }
}