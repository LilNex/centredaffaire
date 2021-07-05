
namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class UCAjoutDepartement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAjouterPoste = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.txtDepManager = new System.Windows.Forms.TextBox();
            this.txtDepNom = new System.Windows.Forms.TextBox();
            this.txtDepNum = new System.Windows.Forms.TextBox();
            this.lblText_Prenom = new System.Windows.Forms.Label();
            this.lblText_Nom = new System.Windows.Forms.Label();
            this.lblText_Numero = new System.Windows.Forms.Label();
            this.lblText_Ajout = new System.Windows.Forms.Label();
            this.txtTempPosteNom = new System.Windows.Forms.TextBox();
            this.txtTempPosteNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltext_ajoutposte = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouterDep = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouterPoste
            // 
            this.btnAjouterPoste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterPoste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnAjouterPoste.FlatAppearance.BorderSize = 0;
            this.btnAjouterPoste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPoste.ForeColor = System.Drawing.Color.White;
            this.btnAjouterPoste.Image = global::Centre_D_affaire.Properties.Resources.icons8_add_user_male_32px;
            this.btnAjouterPoste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterPoste.Location = new System.Drawing.Point(308, 182);
            this.btnAjouterPoste.Name = "btnAjouterPoste";
            this.btnAjouterPoste.Size = new System.Drawing.Size(111, 39);
            this.btnAjouterPoste.TabIndex = 101;
            this.btnAjouterPoste.Text = "Ajouter le poste";
            this.btnAjouterPoste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterPoste.UseVisualStyleBackColor = false;
            this.btnAjouterPoste.Click += new System.EventHandler(this.btnAjouterPoste_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEffacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnEffacer.FlatAppearance.BorderSize = 0;
            this.btnEffacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer.ForeColor = System.Drawing.Color.White;
            this.btnEffacer.Image = global::Centre_D_affaire.Properties.Resources.icons8_multiply_26px_4;
            this.btnEffacer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEffacer.Location = new System.Drawing.Point(836, 481);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(113, 39);
            this.btnEffacer.TabIndex = 100;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEffacer.UseVisualStyleBackColor = false;
            // 
            // txtDepManager
            // 
            this.txtDepManager.BackColor = System.Drawing.Color.DarkGray;
            this.txtDepManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDepManager.Location = new System.Drawing.Point(72, 94);
            this.txtDepManager.Name = "txtDepManager";
            this.txtDepManager.Size = new System.Drawing.Size(137, 19);
            this.txtDepManager.TabIndex = 67;
            // 
            // txtDepNom
            // 
            this.txtDepNom.BackColor = System.Drawing.Color.DarkGray;
            this.txtDepNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDepNom.Location = new System.Drawing.Point(72, 63);
            this.txtDepNom.Name = "txtDepNom";
            this.txtDepNom.Size = new System.Drawing.Size(137, 19);
            this.txtDepNom.TabIndex = 66;
            // 
            // txtDepNum
            // 
            this.txtDepNum.BackColor = System.Drawing.Color.DarkGray;
            this.txtDepNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepNum.Location = new System.Drawing.Point(72, 31);
            this.txtDepNum.Name = "txtDepNum";
            this.txtDepNum.Size = new System.Drawing.Size(137, 19);
            this.txtDepNum.TabIndex = 65;
            // 
            // lblText_Prenom
            // 
            this.lblText_Prenom.AutoSize = true;
            this.lblText_Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Prenom.Location = new System.Drawing.Point(3, 97);
            this.lblText_Prenom.Name = "lblText_Prenom";
            this.lblText_Prenom.Size = new System.Drawing.Size(68, 16);
            this.lblText_Prenom.TabIndex = 64;
            this.lblText_Prenom.Text = "Manager :";
            // 
            // lblText_Nom
            // 
            this.lblText_Nom.AutoSize = true;
            this.lblText_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Nom.Location = new System.Drawing.Point(3, 66);
            this.lblText_Nom.Name = "lblText_Nom";
            this.lblText_Nom.Size = new System.Drawing.Size(43, 16);
            this.lblText_Nom.TabIndex = 63;
            this.lblText_Nom.Text = "Nom :";
            // 
            // lblText_Numero
            // 
            this.lblText_Numero.AutoSize = true;
            this.lblText_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Numero.Location = new System.Drawing.Point(3, 34);
            this.lblText_Numero.Name = "lblText_Numero";
            this.lblText_Numero.Size = new System.Drawing.Size(62, 16);
            this.lblText_Numero.TabIndex = 62;
            this.lblText_Numero.Text = "Numéro :";
            // 
            // lblText_Ajout
            // 
            this.lblText_Ajout.AutoSize = true;
            this.lblText_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Ajout.Location = new System.Drawing.Point(3, 0);
            this.lblText_Ajout.Name = "lblText_Ajout";
            this.lblText_Ajout.Size = new System.Drawing.Size(216, 24);
            this.lblText_Ajout.TabIndex = 61;
            this.lblText_Ajout.Text = "Ajout d\'un département :";
            // 
            // txtTempPosteNom
            // 
            this.txtTempPosteNom.BackColor = System.Drawing.Color.DarkGray;
            this.txtTempPosteNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTempPosteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTempPosteNom.Location = new System.Drawing.Point(72, 223);
            this.txtTempPosteNom.Name = "txtTempPosteNom";
            this.txtTempPosteNom.Size = new System.Drawing.Size(137, 19);
            this.txtTempPosteNom.TabIndex = 107;
            // 
            // txtTempPosteNum
            // 
            this.txtTempPosteNum.BackColor = System.Drawing.Color.DarkGray;
            this.txtTempPosteNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTempPosteNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempPosteNum.Location = new System.Drawing.Point(72, 191);
            this.txtTempPosteNum.Name = "txtTempPosteNum";
            this.txtTempPosteNum.Size = new System.Drawing.Size(137, 19);
            this.txtTempPosteNum.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 103;
            this.label3.Text = "Numéro :";
            // 
            // lbltext_ajoutposte
            // 
            this.lbltext_ajoutposte.AutoSize = true;
            this.lbltext_ajoutposte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext_ajoutposte.Location = new System.Drawing.Point(3, 160);
            this.lbltext_ajoutposte.Name = "lbltext_ajoutposte";
            this.lbltext_ajoutposte.Size = new System.Drawing.Size(297, 24);
            this.lbltext_ajoutposte.TabIndex = 102;
            this.lbltext_ajoutposte.Text = "Ajout des postes du département :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Nom});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(413, 238);
            this.dataGridView1.TabIndex = 109;
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // btnAjouterDep
            // 
            this.btnAjouterDep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnAjouterDep.FlatAppearance.BorderSize = 0;
            this.btnAjouterDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterDep.ForeColor = System.Drawing.Color.White;
            this.btnAjouterDep.Image = global::Centre_D_affaire.Properties.Resources.icons8_add_user_male_32px;
            this.btnAjouterDep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouterDep.Location = new System.Drawing.Point(836, 436);
            this.btnAjouterDep.Name = "btnAjouterDep";
            this.btnAjouterDep.Size = new System.Drawing.Size(113, 39);
            this.btnAjouterDep.TabIndex = 110;
            this.btnAjouterDep.Text = "Ajouter";
            this.btnAjouterDep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterDep.UseVisualStyleBackColor = false;
            this.btnAjouterDep.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.DarkGray;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox4.Location = new System.Drawing.Point(346, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 19);
            this.textBox4.TabIndex = 116;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DarkGray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox5.Location = new System.Drawing.Point(346, 63);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(137, 19);
            this.textBox5.TabIndex = 115;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.DarkGray;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(346, 31);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(137, 19);
            this.textBox6.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 113;
            this.label4.Text = "Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(277, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 112;
            this.label5.Text = "Fax :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 111;
            this.label6.Text = "Tel :";
            // 
            // UCAjoutDepartement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAjouterDep);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTempPosteNom);
            this.Controls.Add(this.txtTempPosteNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltext_ajoutposte);
            this.Controls.Add(this.btnAjouterPoste);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.txtDepManager);
            this.Controls.Add(this.txtDepNom);
            this.Controls.Add(this.txtDepNum);
            this.Controls.Add(this.lblText_Prenom);
            this.Controls.Add(this.lblText_Nom);
            this.Controls.Add(this.lblText_Numero);
            this.Controls.Add(this.lblText_Ajout);
            this.Name = "UCAjoutDepartement";
            this.Size = new System.Drawing.Size(952, 529);
            this.Load += new System.EventHandler(this.UCAjoutDepartement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterPoste;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.TextBox txtDepManager;
        private System.Windows.Forms.TextBox txtDepNom;
        private System.Windows.Forms.TextBox txtDepNum;
        private System.Windows.Forms.Label lblText_Prenom;
        private System.Windows.Forms.Label lblText_Nom;
        private System.Windows.Forms.Label lblText_Numero;
        private System.Windows.Forms.Label lblText_Ajout;
        private System.Windows.Forms.TextBox txtTempPosteNom;
        private System.Windows.Forms.TextBox txtTempPosteNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltext_ajoutposte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjouterDep;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
    }
}
