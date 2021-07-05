
namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class UCAjoutPoste
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAjouterPoste = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTempPosteNom = new System.Windows.Forms.TextBox();
            this.txtTempPosteNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltext_ajoutposte = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDeparts = new System.Windows.Forms.ComboBox();
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
            this.btnAjouterPoste.Location = new System.Drawing.Point(829, 437);
            this.btnAjouterPoste.Name = "btnAjouterPoste";
            this.btnAjouterPoste.Size = new System.Drawing.Size(111, 39);
            this.btnAjouterPoste.TabIndex = 101;
            this.btnAjouterPoste.Text = "Ajouter le poste";
            this.btnAjouterPoste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouterPoste.UseVisualStyleBackColor = false;
            this.btnAjouterPoste.Click += new System.EventHandler(this.btnAjouterPoste_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Centre_D_affaire.Properties.Resources.icons8_multiply_26px_41;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(829, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 39);
            this.button1.TabIndex = 99;
            this.button1.Text = "Effacer";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTempPosteNom
            // 
            this.txtTempPosteNom.BackColor = System.Drawing.Color.DarkGray;
            this.txtTempPosteNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTempPosteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTempPosteNom.Location = new System.Drawing.Point(101, 98);
            this.txtTempPosteNom.Name = "txtTempPosteNom";
            this.txtTempPosteNom.Size = new System.Drawing.Size(137, 19);
            this.txtTempPosteNom.TabIndex = 107;
            // 
            // txtTempPosteNum
            // 
            this.txtTempPosteNum.BackColor = System.Drawing.Color.DarkGray;
            this.txtTempPosteNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTempPosteNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempPosteNum.Location = new System.Drawing.Point(101, 66);
            this.txtTempPosteNum.Name = "txtTempPosteNum";
            this.txtTempPosteNum.Size = new System.Drawing.Size(137, 19);
            this.txtTempPosteNum.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 103;
            this.label3.Text = "Numéro :";
            // 
            // lbltext_ajoutposte
            // 
            this.lbltext_ajoutposte.AutoSize = true;
            this.lbltext_ajoutposte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext_ajoutposte.Location = new System.Drawing.Point(3, 0);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Nom});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(413, 238);
            this.dataGridView1.TabIndex = 109;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 111;
            this.label1.Text = "Departement :";
            // 
            // cmbDeparts
            // 
            this.cmbDeparts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeparts.FormattingEnabled = true;
            this.cmbDeparts.Location = new System.Drawing.Point(101, 31);
            this.cmbDeparts.Name = "cmbDeparts";
            this.cmbDeparts.Size = new System.Drawing.Size(121, 21);
            this.cmbDeparts.TabIndex = 112;
            // 
            // UCAjoutPoste
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.cmbDeparts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTempPosteNom);
            this.Controls.Add(this.txtTempPosteNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltext_ajoutposte);
            this.Controls.Add(this.btnAjouterPoste);
            this.Controls.Add(this.button1);
            this.Name = "UCAjoutPoste";
            this.Size = new System.Drawing.Size(952, 529);
            this.Load += new System.EventHandler(this.UCAjoutDepartement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouterPoste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTempPosteNom;
        private System.Windows.Forms.TextBox txtTempPosteNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltext_ajoutposte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDeparts;
    }
}
