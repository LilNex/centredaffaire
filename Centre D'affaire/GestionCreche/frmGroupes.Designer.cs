
namespace Centre_D_affaire.GestionCreche
{
    partial class frmGroupes
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cmbGroupe = new System.Windows.Forms.ComboBox();
            this.lsvGroupe = new System.Windows.Forms.ListView();
            this.NumEnfant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomComplet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Groupe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomRechercher = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEnregitrer = new System.Windows.Forms.Button();
            this.txtNUm = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ModifiertoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SupprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Groupe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Complet d\'enfant :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 333);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(286, 26);
            this.txtNom.TabIndex = 2;
            // 
            // cmbGroupe
            // 
            this.cmbGroupe.FormattingEnabled = true;
            this.cmbGroupe.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "A4",
            "A5",
            "A6",
            "A7",
            "A6",
            "A9",
            "A10",
            "A12",
            "A13",
            "A14",
            "A15",
            "A16",
            "A17",
            "A18",
            "A19",
            "A20",
            "A21",
            "A22",
            "A23",
            "A24",
            "A25",
            "A26",
            "A27",
            "A28",
            "A29",
            "A30",
            "A31",
            "A32",
            "A33",
            "A34",
            "A35",
            "A36",
            "A37",
            "A38",
            "A39",
            "A40",
            "A41",
            "A42",
            "A43",
            "A44",
            "A45",
            "A46",
            "A47",
            "A48",
            "A49",
            "A50",
            ""});
            this.cmbGroupe.Location = new System.Drawing.Point(12, 245);
            this.cmbGroupe.Name = "cmbGroupe";
            this.cmbGroupe.Size = new System.Drawing.Size(286, 28);
            this.cmbGroupe.TabIndex = 3;
            // 
            // lsvGroupe
            // 
            this.lsvGroupe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumEnfant,
            this.NomComplet,
            this.Groupe});
            this.lsvGroupe.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvGroupe.GridLines = true;
            this.lsvGroupe.HideSelection = false;
            this.lsvGroupe.Location = new System.Drawing.Point(381, 216);
            this.lsvGroupe.Name = "lsvGroupe";
            this.lsvGroupe.Size = new System.Drawing.Size(906, 210);
            this.lsvGroupe.TabIndex = 4;
            this.lsvGroupe.UseCompatibleStateImageBehavior = false;
            this.lsvGroupe.View = System.Windows.Forms.View.Details;
            // 
            // NumEnfant
            // 
            this.NumEnfant.Text = "Num d\'enfant";
            this.NumEnfant.Width = 300;
            // 
            // NomComplet
            // 
            this.NomComplet.Text = "Nom Complet d\'enfant";
            this.NomComplet.Width = 300;
            // 
            // Groupe
            // 
            this.Groupe.Text = "Groupe";
            this.Groupe.Width = 300;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(348, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 64);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liste Groupes :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Num d\'enfant :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomRechercher);
            this.groupBox1.Controls.Add(this.btnRechercher);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Location = new System.Drawing.Point(861, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 146);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher";
            // 
            // txtNomRechercher
            // 
            this.txtNomRechercher.Location = new System.Drawing.Point(6, 64);
            this.txtNomRechercher.Name = "txtNomRechercher";
            this.txtNomRechercher.Size = new System.Drawing.Size(178, 26);
            this.txtNomRechercher.TabIndex = 15;
            this.txtNomRechercher.TextChanged += new System.EventHandler(this.txtNomRechercher_TextChanged);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(227, 25);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(154, 55);
            this.btnRechercher.TabIndex = 12;
            this.btnRechercher.Text = "Rechercher :";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(6, 29);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(172, 26);
            this.lbl.TabIndex = 14;
            this.lbl.Text = "Nom Complet :";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(381, 507);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(154, 55);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter :";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEnregitrer
            // 
            this.btnEnregitrer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEnregitrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregitrer.Location = new System.Drawing.Point(610, 507);
            this.btnEnregitrer.Name = "btnEnregitrer";
            this.btnEnregitrer.Size = new System.Drawing.Size(154, 55);
            this.btnEnregitrer.TabIndex = 13;
            this.btnEnregitrer.Text = "Enregitrer :";
            this.btnEnregitrer.UseVisualStyleBackColor = false;
            this.btnEnregitrer.Click += new System.EventHandler(this.btnEnregitrer_Click);
            // 
            // txtNUm
            // 
            this.txtNUm.Location = new System.Drawing.Point(12, 449);
            this.txtNUm.Name = "txtNUm";
            this.txtNUm.Size = new System.Drawing.Size(286, 26);
            this.txtNUm.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifiertoolStripMenuItem1,
            this.SupprimerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 68);
            // 
            // ModifiertoolStripMenuItem1
            // 
            this.ModifiertoolStripMenuItem1.Name = "ModifiertoolStripMenuItem1";
            this.ModifiertoolStripMenuItem1.Size = new System.Drawing.Size(167, 32);
            this.ModifiertoolStripMenuItem1.Text = "Modifier";
            this.ModifiertoolStripMenuItem1.Click += new System.EventHandler(this.ModifiertoolStripMenuItem1_Click);
            // 
            // SupprimerToolStripMenuItem
            // 
            this.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem";
            this.SupprimerToolStripMenuItem.Size = new System.Drawing.Size(167, 32);
            this.SupprimerToolStripMenuItem.Text = "Supprimer";
            this.SupprimerToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // frmGroupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1321, 722);
            this.Controls.Add(this.txtNUm);
            this.Controls.Add(this.btnEnregitrer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsvGroupe);
            this.Controls.Add(this.cmbGroupe);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGroupes";
            this.Text = "frmGroupes";
            this.Load += new System.EventHandler(this.frmGroupes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ComboBox cmbGroupe;
        private System.Windows.Forms.ListView lsvGroupe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnEnregitrer;
        private System.Windows.Forms.TextBox txtNomRechercher;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ColumnHeader NumEnfant;
        private System.Windows.Forms.ColumnHeader NomComplet;
        private System.Windows.Forms.ColumnHeader Groupe;
        private System.Windows.Forms.TextBox txtNUm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ModifiertoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SupprimerToolStripMenuItem;
    }
}