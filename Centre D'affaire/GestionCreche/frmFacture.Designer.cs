namespace Centre_D_affaire.GestionCreche
{
    partial class frmFacture
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxMois = new System.Windows.Forms.ComboBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.dtpDateEcheance = new System.Windows.Forms.DateTimePicker();
            this.dtpDateF = new System.Windows.Forms.DateTimePicker();
            this.btnMontant = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chbxRepas = new System.Windows.Forms.CheckBox();
            this.chbxTransporte = new System.Windows.Forms.CheckBox();
            this.chbxinscription = new System.Windows.Forms.CheckBox();
            this.chbxAssurqnces = new System.Windows.Forms.CheckBox();
            this.chbxMois = new System.Windows.Forms.CheckBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEnregitrer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtNomR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumFacture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mois = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateEcheance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModeRèglementFacture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvFacture = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbxMode = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MontantTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num Facture :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Complet d\'enfant :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mois :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Facture :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date d\'échéance Facture :";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(60, 342);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(243, 26);
            this.lblM.TabIndex = 7;
            this.lblM.Text = "                                 ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "Adresse :";
            // 
            // cbxMois
            // 
            this.cbxMois.FormattingEnabled = true;
            this.cbxMois.Location = new System.Drawing.Point(17, 224);
            this.cbxMois.Name = "cbxMois";
            this.cbxMois.Size = new System.Drawing.Size(143, 28);
            this.cbxMois.TabIndex = 11;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(17, 156);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(122, 26);
            this.txtnom.TabIndex = 13;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(17, 357);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(122, 26);
            this.txtAdresse.TabIndex = 14;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(17, 81);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(122, 26);
            this.txtnum.TabIndex = 15;
            // 
            // dtpDateEcheance
            // 
            this.dtpDateEcheance.Location = new System.Drawing.Point(17, 467);
            this.dtpDateEcheance.Name = "dtpDateEcheance";
            this.dtpDateEcheance.Size = new System.Drawing.Size(222, 26);
            this.dtpDateEcheance.TabIndex = 16;
            // 
            // dtpDateF
            // 
            this.dtpDateF.Location = new System.Drawing.Point(17, 305);
            this.dtpDateF.Name = "dtpDateF";
            this.dtpDateF.Size = new System.Drawing.Size(222, 26);
            this.dtpDateF.TabIndex = 17;
            // 
            // btnMontant
            // 
            this.btnMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMontant.Location = new System.Drawing.Point(65, 287);
            this.btnMontant.Name = "btnMontant";
            this.btnMontant.Size = new System.Drawing.Size(200, 47);
            this.btnMontant.TabIndex = 18;
            this.btnMontant.Text = "Montant Total :";
            this.btnMontant.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chbxRepas);
            this.groupBox1.Controls.Add(this.chbxTransporte);
            this.groupBox1.Controls.Add(this.chbxinscription);
            this.groupBox1.Controls.Add(this.chbxAssurqnces);
            this.groupBox1.Controls.Add(this.chbxMois);
            this.groupBox1.Controls.Add(this.btnMontant);
            this.groupBox1.Controls.Add(this.lblM);
            this.groupBox1.Location = new System.Drawing.Point(540, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 395);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facture :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "Num Facture :";
            // 
            // chbxRepas
            // 
            this.chbxRepas.AutoSize = true;
            this.chbxRepas.Location = new System.Drawing.Point(11, 228);
            this.chbxRepas.Name = "chbxRepas";
            this.chbxRepas.Size = new System.Drawing.Size(141, 24);
            this.chbxRepas.TabIndex = 23;
            this.chbxRepas.Text = "Repas 200 DH";
            this.chbxRepas.UseVisualStyleBackColor = true;
            // 
            // chbxTransporte
            // 
            this.chbxTransporte.AutoSize = true;
            this.chbxTransporte.Location = new System.Drawing.Point(11, 198);
            this.chbxTransporte.Name = "chbxTransporte";
            this.chbxTransporte.Size = new System.Drawing.Size(162, 24);
            this.chbxTransporte.TabIndex = 22;
            this.chbxTransporte.Text = "Transport 200 DH";
            this.chbxTransporte.UseVisualStyleBackColor = true;
            // 
            // chbxinscription
            // 
            this.chbxinscription.AutoSize = true;
            this.chbxinscription.Location = new System.Drawing.Point(11, 157);
            this.chbxinscription.Name = "chbxinscription";
            this.chbxinscription.Size = new System.Drawing.Size(167, 24);
            this.chbxinscription.TabIndex = 21;
            this.chbxinscription.Text = "Inscription 250 DH";
            this.chbxinscription.UseVisualStyleBackColor = true;
            // 
            // chbxAssurqnces
            // 
            this.chbxAssurqnces.AutoSize = true;
            this.chbxAssurqnces.Location = new System.Drawing.Point(11, 117);
            this.chbxAssurqnces.Name = "chbxAssurqnces";
            this.chbxAssurqnces.Size = new System.Drawing.Size(178, 24);
            this.chbxAssurqnces.TabIndex = 20;
            this.chbxAssurqnces.Text = "Assurances 300 DH";
            this.chbxAssurqnces.UseVisualStyleBackColor = true;
            // 
            // chbxMois
            // 
            this.chbxMois.AutoSize = true;
            this.chbxMois.Location = new System.Drawing.Point(11, 74);
            this.chbxMois.Name = "chbxMois";
            this.chbxMois.Size = new System.Drawing.Size(136, 24);
            this.chbxMois.TabIndex = 19;
            this.chbxMois.Text = "Mois 1300 DH";
            this.chbxMois.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(149, 669);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(211, 60);
            this.btnAjouter.TabIndex = 21;
            this.btnAjouter.Text = "Ajouter :";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // btnEnregitrer
            // 
            this.btnEnregitrer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnregitrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregitrer.Location = new System.Drawing.Point(427, 669);
            this.btnEnregitrer.Name = "btnEnregitrer";
            this.btnEnregitrer.Size = new System.Drawing.Size(211, 60);
            this.btnEnregitrer.TabIndex = 22;
            this.btnEnregitrer.Text = "Enregitrer :";
            this.btnEnregitrer.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(139, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 60);
            this.button3.TabIndex = 23;
            this.button3.Text = "Rechercher :";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // txtNomR
            // 
            this.txtNomR.Location = new System.Drawing.Point(31, 111);
            this.txtNomR.Name = "txtNomR";
            this.txtNomR.Size = new System.Drawing.Size(258, 26);
            this.txtNomR.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nom Complet d\'enfant :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.txtNomR);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(964, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 311);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rechercher :";
            // 
            // NumFacture
            // 
            this.NumFacture.Text = "Num Facture";
            this.NumFacture.Width = 300;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom Complet d\'enfant";
            this.Nom.Width = 300;
            // 
            // Mois
            // 
            this.Mois.Text = "Mois";
            this.Mois.Width = 300;
            // 
            // DateF
            // 
            this.DateF.Text = "Date Facture";
            this.DateF.Width = 300;
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse";
            this.Adresse.Width = 300;
            // 
            // DateEcheance
            // 
            this.DateEcheance.Text = "Date d\'échéance Facture";
            this.DateEcheance.Width = 300;
            // 
            // ModeRèglementFacture
            // 
            this.ModeRèglementFacture.Text = "Mode Règlement Facture";
            this.ModeRèglementFacture.Width = 300;
            // 
            // lsvFacture
            // 
            this.lsvFacture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumFacture,
            this.Nom,
            this.Mois,
            this.DateF,
            this.Adresse,
            this.DateEcheance,
            this.ModeRèglementFacture,
            this.MontantTotal});
            this.lsvFacture.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvFacture.GridLines = true;
            this.lsvFacture.HideSelection = false;
            this.lsvFacture.Location = new System.Drawing.Point(427, 453);
            this.lsvFacture.Name = "lsvFacture";
            this.lsvFacture.Size = new System.Drawing.Size(886, 196);
            this.lsvFacture.TabIndex = 19;
            this.lsvFacture.UseCompatibleStateImageBehavior = false;
            this.lsvFacture.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 68);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(167, 32);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(167, 32);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // cbxMode
            // 
            this.cbxMode.FormattingEnabled = true;
            this.cbxMode.Items.AddRange(new object[] {
            "Espèce"});
            this.cbxMode.Location = new System.Drawing.Point(22, 557);
            this.cbxMode.Name = "cbxMode";
            this.cbxMode.Size = new System.Drawing.Size(143, 28);
            this.cbxMode.TabIndex = 28;
            this.cbxMode.Text = "Mode Règlement facture :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 528);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(286, 26);
            this.label8.TabIndex = 27;
            this.label8.Text = "Mode Règlement facture :";
            // 
            // MontantTotal
            // 
            this.MontantTotal.Text = "Montant Total";
            // 
            // frmFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 722);
            this.Controls.Add(this.cbxMode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnEnregitrer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lsvFacture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDateF);
            this.Controls.Add(this.dtpDateEcheance);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.cbxMois);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFacture";
            this.Text = "frmFacture";
            this.Load += new System.EventHandler(this.frmFacture_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxMois;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.DateTimePicker dtpDateEcheance;
        private System.Windows.Forms.DateTimePicker dtpDateF;
        private System.Windows.Forms.Button btnMontant;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbxRepas;
        private System.Windows.Forms.CheckBox chbxTransporte;
        private System.Windows.Forms.CheckBox chbxinscription;
        private System.Windows.Forms.CheckBox chbxAssurqnces;
        private System.Windows.Forms.CheckBox chbxMois;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEnregitrer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNomR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader NumFacture;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Mois;
        private System.Windows.Forms.ColumnHeader DateF;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.ColumnHeader DateEcheance;
        private System.Windows.Forms.ColumnHeader ModeRèglementFacture;
        private System.Windows.Forms.ListView lsvFacture;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxMode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader MontantTotal;
    }
}