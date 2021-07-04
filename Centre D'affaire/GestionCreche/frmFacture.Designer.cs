
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
            this.lsvFacture = new System.Windows.Forms.ListView();
            this.NumFacture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomCompletdenfant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mois = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateFacture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatedecheanceduReglement = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaimentDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MontantTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEnregitrer = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Rechercher = new System.Windows.Forms.GroupBox();
            this.txtNumRecherche = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.cbxPaiementde = new System.Windows.Forms.ComboBox();
            this.cbxMois = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.dtpDateEcheance = new System.Windows.Forms.DateTimePicker();
            this.dtpDateF = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.Rechercher.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvFacture
            // 
            this.lsvFacture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumFacture,
            this.NomCompletdenfant,
            this.Mois,
            this.DateFacture,
            this.Adresse,
            this.DatedecheanceduReglement,
            this.PaimentDe,
            this.MontantTotal});
            this.lsvFacture.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvFacture.GridLines = true;
            this.lsvFacture.HideSelection = false;
            this.lsvFacture.Location = new System.Drawing.Point(823, 54);
            this.lsvFacture.Name = "lsvFacture";
            this.lsvFacture.Size = new System.Drawing.Size(396, 215);
            this.lsvFacture.TabIndex = 0;
            this.lsvFacture.UseCompatibleStateImageBehavior = false;
            this.lsvFacture.View = System.Windows.Forms.View.Details;
            // 
            // NumFacture
            // 
            this.NumFacture.Text = "Num Facture";
            this.NumFacture.Width = 200;
            // 
            // NomCompletdenfant
            // 
            this.NomCompletdenfant.Text = "Nom Complet d\'enfant";
            this.NomCompletdenfant.Width = 200;
            // 
            // Mois
            // 
            this.Mois.Text = "Mois";
            this.Mois.Width = 200;
            // 
            // DateFacture
            // 
            this.DateFacture.Text = "Date Facture";
            this.DateFacture.Width = 200;
            // 
            // Adresse
            // 
            this.Adresse.Text = "Adresse";
            this.Adresse.Width = 200;
            // 
            // DatedecheanceduReglement
            // 
            this.DatedecheanceduReglement.Text = "Date d\'echeance du Règlement";
            this.DatedecheanceduReglement.Width = 200;
            // 
            // PaimentDe
            // 
            this.PaimentDe.Text = "Paiement De";
            this.PaimentDe.Width = 200;
            // 
            // MontantTotal
            // 
            this.MontantTotal.Text = "Montant Total";
            this.MontantTotal.Width = 200;
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
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(167, 32);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(387, 476);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(191, 46);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter :";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEnregitrer
            // 
            this.btnEnregitrer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnregitrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregitrer.Location = new System.Drawing.Point(635, 476);
            this.btnEnregitrer.Name = "btnEnregitrer";
            this.btnEnregitrer.Size = new System.Drawing.Size(191, 46);
            this.btnEnregitrer.TabIndex = 3;
            this.btnEnregitrer.Text = "Enregistrer";
            this.btnEnregitrer.UseVisualStyleBackColor = false;
            this.btnEnregitrer.Click += new System.EventHandler(this.btnEnregitrer_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(70, 128);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(191, 46);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 108);
            this.label1.TabIndex = 5;
            this.label1.Text = "Facture :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nom Complet d\'enfant .";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 690);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date d\'echeance du Règlement :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Montant Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Paiement DE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 587);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Adresse :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "Date Facture :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mois :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 801);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Mode Règlement :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 26);
            this.label11.TabIndex = 15;
            this.label11.Text = "Num Facture :";
            // 
            // Rechercher
            // 
            this.Rechercher.Controls.Add(this.txtNumRecherche);
            this.Rechercher.Controls.Add(this.label2);
            this.Rechercher.Controls.Add(this.btnRechercher);
            this.Rechercher.Location = new System.Drawing.Point(916, 348);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(314, 206);
            this.Rechercher.TabIndex = 16;
            this.Rechercher.TabStop = false;
            this.Rechercher.Text = "NomRechercher";
            this.Rechercher.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNumRecherche
            // 
            this.txtNumRecherche.Location = new System.Drawing.Point(11, 68);
            this.txtNumRecherche.Name = "txtNumRecherche";
            this.txtNumRecherche.Size = new System.Drawing.Size(239, 26);
            this.txtNumRecherche.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Num Facture :";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(17, 261);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(230, 26);
            this.txtnum.TabIndex = 17;
            // 
            // cbxPaiementde
            // 
            this.cbxPaiementde.FormattingEnabled = true;
            this.cbxPaiementde.Items.AddRange(new object[] {
            "Mois ",
            "Assurance  ",
            "Fais d\'inscription ",
            "Transport ",
            "Repas ",
            "Mois et Assurance ",
            "Mois et Fais d\'inscription ",
            "Mois et Fais d\'inscription et Assurance",
            "Mois et Repas ",
            "Mois et Transport",
            "Mois et Repas et Transport  ",
            "Mois et Fais d\'inscription et Assurance et Transport et Repas ",
            "Mois et Fais d\'inscription et Assurance et Transport ",
            "Mois et Fais d\'inscription et Assurance  et Repas "});
            this.cbxPaiementde.Location = new System.Drawing.Point(25, 65);
            this.cbxPaiementde.Name = "cbxPaiementde";
            this.cbxPaiementde.Size = new System.Drawing.Size(121, 28);
            this.cbxPaiementde.TabIndex = 18;
            this.cbxPaiementde.SelectedIndexChanged += new System.EventHandler(this.cbxPaiementde_SelectedIndexChanged);
            // 
            // cbxMois
            // 
            this.cbxMois.FormattingEnabled = true;
            this.cbxMois.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbxMois.Location = new System.Drawing.Point(12, 426);
            this.cbxMois.Name = "cbxMois";
            this.cbxMois.Size = new System.Drawing.Size(235, 28);
            this.cbxMois.TabIndex = 19;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 849);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 28);
            this.comboBox3.TabIndex = 20;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(12, 348);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(235, 26);
            this.txtnom.TabIndex = 22;
            this.txtnom.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(12, 630);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(235, 26);
            this.txtAdresse.TabIndex = 23;
            // 
            // dtpDateEcheance
            // 
            this.dtpDateEcheance.Location = new System.Drawing.Point(12, 737);
            this.dtpDateEcheance.Name = "dtpDateEcheance";
            this.dtpDateEcheance.Size = new System.Drawing.Size(235, 26);
            this.dtpDateEcheance.TabIndex = 24;
            // 
            // dtpDateF
            // 
            this.dtpDateF.Location = new System.Drawing.Point(12, 528);
            this.dtpDateF.Name = "dtpDateF";
            this.dtpDateF.Size = new System.Drawing.Size(235, 26);
            this.dtpDateF.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMontant);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbxPaiementde);
            this.groupBox2.Location = new System.Drawing.Point(362, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 253);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facture";
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(31, 209);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(33, 20);
            this.lblMontant.TabIndex = 27;
            this.lblMontant.Text = "      ";
            // 
            // frmFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 889);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtpDateF);
            this.Controls.Add(this.dtpDateEcheance);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.cbxMois);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnregitrer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lsvFacture);
            this.Name = "frmFacture";
            this.Text = "frmFacture";
            this.Load += new System.EventHandler(this.frmFacture_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.Rechercher.ResumeLayout(false);
            this.Rechercher.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvFacture;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEnregitrer;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox Rechercher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.ComboBox cbxPaiementde;
        private System.Windows.Forms.ComboBox cbxMois;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.DateTimePicker dtpDateEcheance;
        private System.Windows.Forms.DateTimePicker dtpDateF;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.ColumnHeader NumFacture;
        private System.Windows.Forms.ColumnHeader NomCompletdenfant;
        private System.Windows.Forms.ColumnHeader Mois;
        private System.Windows.Forms.ColumnHeader DateFacture;
        private System.Windows.Forms.ColumnHeader Adresse;
        private System.Windows.Forms.ColumnHeader DatedecheanceduReglement;
        private System.Windows.Forms.ColumnHeader PaimentDe;
        private System.Windows.Forms.ColumnHeader MontantTotal;
        private System.Windows.Forms.TextBox txtNumRecherche;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}