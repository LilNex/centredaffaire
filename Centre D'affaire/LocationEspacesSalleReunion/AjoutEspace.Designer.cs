
namespace Centre_D_affaire.LocationEspacesSalleReunion
{
    partial class AjoutEspace
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
            this.txtMontantJour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtMontantHeure = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbReunion = new System.Windows.Forms.RadioButton();
            this.rdbBureau = new System.Windows.Forms.RadioButton();
            this.btnAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ajout d\'espace à louer";
            // 
            // txtMontantJour
            // 
            this.txtMontantJour.Location = new System.Drawing.Point(92, 117);
            this.txtMontantJour.Name = "txtMontantJour";
            this.txtMontantJour.Size = new System.Drawing.Size(161, 20);
            this.txtMontantJour.TabIndex = 26;
            this.txtMontantJour.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 36);
            this.label5.TabIndex = 25;
            this.label5.Text = "Montant loyer par Jour:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Etage :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(369, 192);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 23;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(369, 58);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(161, 20);
            this.txtVille.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ville :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(369, 87);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(161, 99);
            this.txtAdresse.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Adresse :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(92, 88);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(161, 20);
            this.txtNom.TabIndex = 17;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(92, 62);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(161, 20);
            this.txtNum.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nom : ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(33, 65);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(53, 13);
            this.lblNom.TabIndex = 14;
            this.lblNom.Text = "Numero : ";
            // 
            // txtMontantHeure
            // 
            this.txtMontantHeure.Location = new System.Drawing.Point(92, 156);
            this.txtMontantHeure.Name = "txtMontantHeure";
            this.txtMontantHeure.Size = new System.Drawing.Size(161, 20);
            this.txtMontantHeure.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(9, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 36);
            this.label7.TabIndex = 30;
            this.label7.Text = "Montant loyer par Heure:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbReunion);
            this.groupBox1.Controls.Add(this.rdbBureau);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 58);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type : ";
            // 
            // rdbReunion
            // 
            this.rdbReunion.AutoSize = true;
            this.rdbReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbReunion.Location = new System.Drawing.Point(99, 24);
            this.rdbReunion.Name = "rdbReunion";
            this.rdbReunion.Size = new System.Drawing.Size(123, 20);
            this.rdbReunion.TabIndex = 1;
            this.rdbReunion.TabStop = true;
            this.rdbReunion.Text = "Salle de réunion";
            this.rdbReunion.UseVisualStyleBackColor = true;
            // 
            // rdbBureau
            // 
            this.rdbBureau.AutoSize = true;
            this.rdbBureau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBureau.Location = new System.Drawing.Point(6, 24);
            this.rdbBureau.Name = "rdbBureau";
            this.rdbBureau.Size = new System.Drawing.Size(69, 20);
            this.rdbBureau.TabIndex = 0;
            this.rdbBureau.TabStop = true;
            this.rdbBureau.Text = "Bureau";
            this.rdbBureau.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.AutoSize = true;
            this.btnAjouter.Image = global::Centre_D_affaire.Properties.Resources.icons8_add_24px;
            this.btnAjouter.Location = new System.Drawing.Point(471, 280);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(89, 38);
            this.btnAjouter.TabIndex = 22;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // AjoutEspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMontantHeure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMontantJour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNom);
            this.Name = "AjoutEspace";
            this.Text = "Ajout d\'un Espace";
            this.Load += new System.EventHandler(this.AjoutEspace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMontantJour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtMontantHeure;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbReunion;
        private System.Windows.Forms.RadioButton rdbBureau;
    }
}