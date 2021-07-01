
using System;
using System.Windows.Forms;

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
            this.dgvGroupe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.grbModification = new System.Windows.Forms.GroupBox();
            this.btnAppliquer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewNom = new System.Windows.Forms.TextBox();
            this.txtNewNum = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtNumSERCHE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupe)).BeginInit();
            this.grbModification.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGroupe
            // 
            this.dgvGroupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvGroupe.Location = new System.Drawing.Point(725, -37);
            this.dgvGroupe.Name = "dgvGroupe";
            this.dgvGroupe.RowHeadersWidth = 62;
            this.dgvGroupe.RowTemplate.Height = 28;
            this.dgvGroupe.Size = new System.Drawing.Size(999, 505);
            this.dgvGroupe.TabIndex = 0;
            this.dgvGroupe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGroupe_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NumG";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NomG";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Num : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom : ";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(18, 246);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(396, 26);
            this.txtnom.TabIndex = 3;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(-2, 694);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(356, 109);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter :";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(824, 694);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(356, 109);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer : ";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(404, 694);
            this.btnNouveau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(356, 109);
            this.btnNouveau.TabIndex = 7;
            this.btnNouveau.Text = "Nouveau : ";
            this.btnNouveau.UseVisualStyleBackColor = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click_1);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuitter.Location = new System.Drawing.Point(1242, 691);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(356, 114);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "Quitter : ";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(13, 103);
            this.txtnum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(388, 26);
            this.txtnum.TabIndex = 9;
            this.txtnum.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            // 
            // grbModification
            // 
            this.grbModification.Controls.Add(this.btnAppliquer);
            this.grbModification.Controls.Add(this.label4);
            this.grbModification.Controls.Add(this.label3);
            this.grbModification.Controls.Add(this.txtNewNom);
            this.grbModification.Controls.Add(this.txtNewNum);
            this.grbModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbModification.Location = new System.Drawing.Point(18, 448);
            this.grbModification.Name = "grbModification";
            this.grbModification.Size = new System.Drawing.Size(727, 210);
            this.grbModification.TabIndex = 10;
            this.grbModification.TabStop = false;
            this.grbModification.Text = "Modification : ";
            // 
            // btnAppliquer
            // 
            this.btnAppliquer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAppliquer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppliquer.Location = new System.Drawing.Point(205, 133);
            this.btnAppliquer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAppliquer.Name = "btnAppliquer";
            this.btnAppliquer.Size = new System.Drawing.Size(267, 69);
            this.btnAppliquer.TabIndex = 14;
            this.btnAppliquer.Text = "Appliquer :  ";
            this.btnAppliquer.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nom : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Num : ";
            // 
            // txtNewNom
            // 
            this.txtNewNom.Location = new System.Drawing.Point(2, 81);
            this.txtNewNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewNom.Name = "txtNewNom";
            this.txtNewNom.Size = new System.Drawing.Size(193, 32);
            this.txtNewNom.TabIndex = 11;
            // 
            // txtNewNum
            // 
            this.txtNewNum.Location = new System.Drawing.Point(482, 81);
            this.txtNewNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewNum.Name = "txtNewNum";
            this.txtNewNum.Size = new System.Drawing.Size(197, 32);
            this.txtNewNum.TabIndex = 10;
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(306, 329);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(356, 109);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.Text = "Modifier : ";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtNumSERCHE
            // 
            this.txtNumSERCHE.Location = new System.Drawing.Point(13, 372);
            this.txtNumSERCHE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumSERCHE.Name = "txtNumSERCHE";
            this.txtNumSERCHE.Size = new System.Drawing.Size(240, 26);
            this.txtNumSERCHE.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Num : ";
            // 
            // frmGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 1050);
            this.Controls.Add(this.txtNumSERCHE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.grbModification);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGroupe);
            this.Name = "frmGroupe";
            this.Text = "frmGroupe";
            this.Load += new System.EventHandler(this.frmGroupe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupe)).EndInit();
            this.grbModification.ResumeLayout(false);
            this.grbModification.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvGroupe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           if(txtnom.Text == "" || txtnum.Text == "")
            {
                MessageBox.Show("Attention !! une information est vide ");
            }
            else
            {
                try
                {

                    this.dgvGroupe.Rows.Add(txtnom.Text, int.Parse(txtnum.Text));
                    this.txtnom.Text = " ";
                    this.txtnum.Clear();
                }
                catch (FormatException )
                {
                    MessageBox.Show("NUM INVALIDE ! ");
                }
            }
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGroupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox txtnum;
        private GroupBox grbModification;
        private TextBox txtNewNum;
        private Button btnModifier;
        private Label label4;
        private Label label3;
        private TextBox txtNewNom;
        private Button btnAppliquer;
        private TextBox txtNumSERCHE;
        private Label label5;
    }
}