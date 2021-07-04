
namespace Centre_D_affaire.GestionCreche
{
    partial class frmGroupe
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
            this.lsvGroupe = new System.Windows.Forms.ListView();
            this.Groupe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomComplet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumEnfant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxGroupe = new System.Windows.Forms.ComboBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnEnregistre = new System.Windows.Forms.Button();
            this.txtNomR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvGroupe
            // 
            this.lsvGroupe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Groupe,
            this.NomComplet,
            this.NumEnfant});
            this.lsvGroupe.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvGroupe.GridLines = true;
            this.lsvGroupe.HideSelection = false;
            this.lsvGroupe.Location = new System.Drawing.Point(281, 58);
            this.lsvGroupe.Name = "lsvGroupe";
            this.lsvGroupe.Size = new System.Drawing.Size(477, 209);
            this.lsvGroupe.TabIndex = 0;
            this.lsvGroupe.UseCompatibleStateImageBehavior = false;
            this.lsvGroupe.View = System.Windows.Forms.View.Details;
            // 
            // Groupe
            // 
            this.Groupe.Text = "Groupe";
            this.Groupe.Width = 150;
            // 
            // NomComplet
            // 
            this.NomComplet.Text = "Nom Complet d\'enfant";
            this.NomComplet.Width = 150;
            // 
            // NumEnfant
            // 
            this.NumEnfant.Text = "Num Enfant";
            this.NumEnfant.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 101);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAjouter.Location = new System.Drawing.Point(22, 317);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(154, 57);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter :";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSupprimer.Location = new System.Drawing.Point(221, 317);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(154, 57);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer :";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom Complet :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(55, 96);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 26);
            this.txtNom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Groupe :";
            // 
            // cbxGroupe
            // 
            this.cbxGroupe.FormattingEnabled = true;
            this.cbxGroupe.Location = new System.Drawing.Point(55, 176);
            this.cbxGroupe.Name = "cbxGroupe";
            this.cbxGroupe.Size = new System.Drawing.Size(121, 28);
            this.cbxGroupe.TabIndex = 6;
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRechercher.Location = new System.Drawing.Point(52, 118);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(154, 57);
            this.btnRechercher.TabIndex = 7;
            this.btnRechercher.Text = "Rechercher :";
            this.btnRechercher.UseVisualStyleBackColor = false;
            // 
            // btnEnregistre
            // 
            this.btnEnregistre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnregistre.Location = new System.Drawing.Point(442, 317);
            this.btnEnregistre.Name = "btnEnregistre";
            this.btnEnregistre.Size = new System.Drawing.Size(154, 57);
            this.btnEnregistre.TabIndex = 8;
            this.btnEnregistre.Text = "Enregitrer :";
            this.btnEnregistre.UseVisualStyleBackColor = false;
            // 
            // txtNomR
            // 
            this.txtNomR.Location = new System.Drawing.Point(20, 72);
            this.txtNomR.Name = "txtNomR";
            this.txtNomR.Size = new System.Drawing.Size(100, 26);
            this.txtNomR.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nom Complet :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomR);
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Location = new System.Drawing.Point(1089, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 219);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher :";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(54, 259);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 26);
            this.txtNum.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Num Enfant :";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(165, 32);
            this.supprimerToolStripMenuItem.Text = "supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // frmGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 450);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnregistre);
            this.Controls.Add(this.cbxGroupe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lsvGroupe);
            this.Name = "frmGroupe";
            this.Text = "frmGroupe";
            this.Load += new System.EventHandler(this.frmGroupe_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvGroupe;
        private System.Windows.Forms.ColumnHeader Groupe;
        private System.Windows.Forms.ColumnHeader NomComplet;
        private System.Windows.Forms.ColumnHeader NumEnfant;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxGroupe;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnEnregistre;
        private System.Windows.Forms.TextBox txtNomR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}