﻿
namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class UCListePoste
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtEmployeNom = new System.Windows.Forms.TextBox();
            this.txtEmployeNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblText_Employé = new System.Windows.Forms.Label();
            this.dgvListeEmployes = new System.Windows.Forms.DataGridView();
            this.dgvListePostes = new System.Windows.Forms.DataGridView();
            this.txtPosteNom = new System.Windows.Forms.TextBox();
            this.txtPosteNum = new System.Windows.Forms.TextBox();
            this.lblText_ParNom = new System.Windows.Forms.Label();
            this.lblText_ParNumero = new System.Windows.Forms.Label();
            this.lblText_Poste = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListeEmployes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEmployes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePostes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployeNom
            // 
            this.txtEmployeNom.BackColor = System.Drawing.Color.DarkGray;
            this.txtEmployeNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmployeNom.Location = new System.Drawing.Point(687, 45);
            this.txtEmployeNom.Name = "txtEmployeNom";
            this.txtEmployeNom.Size = new System.Drawing.Size(124, 19);
            this.txtEmployeNom.TabIndex = 51;
            this.txtEmployeNom.TextChanged += new System.EventHandler(this.txtEmployeNom_TextChanged);
            // 
            // txtEmployeNum
            // 
            this.txtEmployeNum.BackColor = System.Drawing.Color.DarkGray;
            this.txtEmployeNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmployeNum.Location = new System.Drawing.Point(550, 45);
            this.txtEmployeNum.Name = "txtEmployeNum";
            this.txtEmployeNum.Size = new System.Drawing.Size(124, 19);
            this.txtEmployeNum.TabIndex = 50;
            this.txtEmployeNum.TextChanged += new System.EventHandler(this.txtEmployeNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(684, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Par nom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Par numéro :";
            // 
            // lblText_Employé
            // 
            this.lblText_Employé.AutoSize = true;
            this.lblText_Employé.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Employé.Location = new System.Drawing.Point(546, 0);
            this.lblText_Employé.Name = "lblText_Employé";
            this.lblText_Employé.Size = new System.Drawing.Size(104, 24);
            this.lblText_Employé.TabIndex = 47;
            this.lblText_Employé.Text = "Employés :";
            // 
            // dgvListeEmployes
            // 
            this.dgvListeEmployes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListeEmployes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeEmployes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListeEmployes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListeEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeEmployes.EnableHeadersVisualStyles = false;
            this.dgvListeEmployes.Location = new System.Drawing.Point(550, 70);
            this.dgvListeEmployes.Name = "dgvListeEmployes";
            this.dgvListeEmployes.RowHeadersVisible = false;
            this.dgvListeEmployes.Size = new System.Drawing.Size(402, 414);
            this.dgvListeEmployes.TabIndex = 46;
            // 
            // dgvListePostes
            // 
            this.dgvListePostes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListePostes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListePostes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListePostes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListePostes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListePostes.EnableHeadersVisualStyles = false;
            this.dgvListePostes.Location = new System.Drawing.Point(8, 70);
            this.dgvListePostes.Name = "dgvListePostes";
            this.dgvListePostes.RowHeadersVisible = false;
            this.dgvListePostes.Size = new System.Drawing.Size(402, 414);
            this.dgvListePostes.TabIndex = 45;
            this.dgvListePostes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListePostes_CellContentClick);
            // 
            // txtPosteNom
            // 
            this.txtPosteNom.BackColor = System.Drawing.Color.DarkGray;
            this.txtPosteNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPosteNom.Location = new System.Drawing.Point(145, 45);
            this.txtPosteNom.Name = "txtPosteNom";
            this.txtPosteNom.Size = new System.Drawing.Size(124, 19);
            this.txtPosteNom.TabIndex = 44;
            this.txtPosteNom.TextChanged += new System.EventHandler(this.txtPosteNom_TextChanged);
            // 
            // txtPosteNum
            // 
            this.txtPosteNum.BackColor = System.Drawing.Color.DarkGray;
            this.txtPosteNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosteNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPosteNum.Location = new System.Drawing.Point(8, 45);
            this.txtPosteNum.Name = "txtPosteNum";
            this.txtPosteNum.Size = new System.Drawing.Size(124, 19);
            this.txtPosteNum.TabIndex = 43;
            this.txtPosteNum.TextChanged += new System.EventHandler(this.txtPosteNum_TextChanged);
            // 
            // lblText_ParNom
            // 
            this.lblText_ParNom.AutoSize = true;
            this.lblText_ParNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_ParNom.Location = new System.Drawing.Point(142, 25);
            this.lblText_ParNom.Name = "lblText_ParNom";
            this.lblText_ParNom.Size = new System.Drawing.Size(64, 16);
            this.lblText_ParNom.TabIndex = 42;
            this.lblText_ParNom.Text = "Par nom :";
            // 
            // lblText_ParNumero
            // 
            this.lblText_ParNumero.AutoSize = true;
            this.lblText_ParNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_ParNumero.Location = new System.Drawing.Point(5, 25);
            this.lblText_ParNumero.Name = "lblText_ParNumero";
            this.lblText_ParNumero.Size = new System.Drawing.Size(83, 16);
            this.lblText_ParNumero.TabIndex = 41;
            this.lblText_ParNumero.Text = "Par numéro :";
            // 
            // lblText_Poste
            // 
            this.lblText_Poste.AutoSize = true;
            this.lblText_Poste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Poste.Location = new System.Drawing.Point(3, 0);
            this.lblText_Poste.Name = "lblText_Poste";
            this.lblText_Poste.Size = new System.Drawing.Size(76, 24);
            this.lblText_Poste.TabIndex = 40;
            this.lblText_Poste.Text = "Postes :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Centre_D_affaire.Properties.Resources.icons8_user_groups_32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(413, 440);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 42);
            this.button2.TabIndex = 54;
            this.button2.Text = "Liste";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Centre_D_affaire.Properties.Resources.icons8_user_groups_32px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(413, 398);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 42);
            this.button1.TabIndex = 53;
            this.button1.Text = "Liste";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnListeEmployes
            // 
            this.btnListeEmployes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnListeEmployes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeEmployes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeEmployes.ForeColor = System.Drawing.Color.White;
            this.btnListeEmployes.Image = global::Centre_D_affaire.Properties.Resources.icons8_user_groups_32px;
            this.btnListeEmployes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListeEmployes.Location = new System.Drawing.Point(413, 356);
            this.btnListeEmployes.Margin = new System.Windows.Forms.Padding(0);
            this.btnListeEmployes.Name = "btnListeEmployes";
            this.btnListeEmployes.Size = new System.Drawing.Size(134, 42);
            this.btnListeEmployes.TabIndex = 52;
            this.btnListeEmployes.Text = "Liste";
            this.btnListeEmployes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListeEmployes.UseVisualStyleBackColor = false;
            // 
            // UCListePoste
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListeEmployes);
            this.Controls.Add(this.txtEmployeNom);
            this.Controls.Add(this.txtEmployeNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblText_Employé);
            this.Controls.Add(this.dgvListeEmployes);
            this.Controls.Add(this.dgvListePostes);
            this.Controls.Add(this.txtPosteNom);
            this.Controls.Add(this.txtPosteNum);
            this.Controls.Add(this.lblText_ParNom);
            this.Controls.Add(this.lblText_ParNumero);
            this.Controls.Add(this.lblText_Poste);
            this.Name = "UCListePoste";
            this.Size = new System.Drawing.Size(952, 529);
            this.Load += new System.EventHandler(this.UCListePoste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEmployes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListePostes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListeEmployes;
        private System.Windows.Forms.TextBox txtEmployeNom;
        private System.Windows.Forms.TextBox txtEmployeNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblText_Employé;
        private System.Windows.Forms.DataGridView dgvListeEmployes;
        private System.Windows.Forms.DataGridView dgvListePostes;
        private System.Windows.Forms.TextBox txtPosteNom;
        private System.Windows.Forms.TextBox txtPosteNum;
        private System.Windows.Forms.Label lblText_ParNom;
        private System.Windows.Forms.Label lblText_ParNumero;
        private System.Windows.Forms.Label lblText_Poste;
    }
}