
namespace Centre_D_affaire.GestionPersonnel
{
    partial class FrmPaiement
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
            this.lblNom = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblRIB = new System.Windows.Forms.Label();
            this.lblHrt = new System.Windows.Forms.Label();
            this.lblSt = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtRIB = new System.Windows.Forms.TextBox();
            this.lblDp = new System.Windows.Forms.Label();
            this.dateTimePickerDp = new System.Windows.Forms.DateTimePicker();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.BtnRetour = new System.Windows.Forms.Button();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.dgvPaiement = new System.Windows.Forms.DataGridView();
            this.nomsl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeursTravail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salairetotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datepaie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtHrt = new System.Windows.Forms.TextBox();
            this.txtSt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaiement)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(25, 31);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 0;
            this.lblNom.Tag = "";
            this.lblNom.Text = "Nom";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(25, 84);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(42, 20);
            this.lblNum.TabIndex = 1;
            this.lblNum.Tag = "";
            this.lblNum.Text = "Num";
            // 
            // lblRIB
            // 
            this.lblRIB.AutoSize = true;
            this.lblRIB.Location = new System.Drawing.Point(25, 134);
            this.lblRIB.Name = "lblRIB";
            this.lblRIB.Size = new System.Drawing.Size(37, 20);
            this.lblRIB.TabIndex = 2;
            this.lblRIB.Tag = "";
            this.lblRIB.Text = "RIB";
            // 
            // lblHrt
            // 
            this.lblHrt.AutoSize = true;
            this.lblHrt.Location = new System.Drawing.Point(25, 184);
            this.lblHrt.Name = "lblHrt";
            this.lblHrt.Size = new System.Drawing.Size(119, 20);
            this.lblHrt.TabIndex = 3;
            this.lblHrt.Tag = "";
            this.lblHrt.Text = "Heurs de travail";
            // 
            // lblSt
            // 
            this.lblSt.AutoSize = true;
            this.lblSt.Location = new System.Drawing.Point(25, 238);
            this.lblSt.Name = "lblSt";
            this.lblSt.Size = new System.Drawing.Size(97, 20);
            this.lblSt.TabIndex = 4;
            this.lblSt.Tag = "";
            this.lblSt.Text = "Salaire Total";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(261, 28);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(112, 26);
            this.txtNom.TabIndex = 5;
            // 
            // txtRIB
            // 
            this.txtRIB.Location = new System.Drawing.Point(261, 128);
            this.txtRIB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRIB.Name = "txtRIB";
            this.txtRIB.Size = new System.Drawing.Size(112, 26);
            this.txtRIB.TabIndex = 6;
            // 
            // lblDp
            // 
            this.lblDp.AutoSize = true;
            this.lblDp.Location = new System.Drawing.Point(25, 294);
            this.lblDp.Name = "lblDp";
            this.lblDp.Size = new System.Drawing.Size(136, 20);
            this.lblDp.TabIndex = 10;
            this.lblDp.Text = "Date de paiement";
            // 
            // dateTimePickerDp
            // 
            this.dateTimePickerDp.Location = new System.Drawing.Point(261, 288);
            this.dateTimePickerDp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerDp.Name = "dateTimePickerDp";
            this.dateTimePickerDp.Size = new System.Drawing.Size(224, 26);
            this.dateTimePickerDp.TabIndex = 11;
            // 
            // BtnFermer
            // 
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.Location = new System.Drawing.Point(773, 2);
            this.BtnFermer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(112, 52);
            this.BtnFermer.TabIndex = 19;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = true;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // BtnRetour
            // 
            this.BtnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetour.Location = new System.Drawing.Point(773, 65);
            this.BtnRetour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(112, 39);
            this.BtnRetour.TabIndex = 18;
            this.BtnRetour.Text = "<<<";
            this.BtnRetour.UseVisualStyleBackColor = true;
            // 
            // BtnAjout
            // 
            this.BtnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjout.Location = new System.Drawing.Point(760, 256);
            this.BtnAjout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(125, 59);
            this.BtnAjout.TabIndex = 20;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // dgvPaiement
            // 
            this.dgvPaiement.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvPaiement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaiement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomsl,
            this.num,
            this.rib,
            this.HeursTravail,
            this.salairetotal,
            this.datepaie});
            this.dgvPaiement.GridColor = System.Drawing.Color.Blue;
            this.dgvPaiement.Location = new System.Drawing.Point(2, 385);
            this.dgvPaiement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPaiement.Name = "dgvPaiement";
            this.dgvPaiement.RowHeadersWidth = 51;
            this.dgvPaiement.Size = new System.Drawing.Size(903, 161);
            this.dgvPaiement.TabIndex = 53;
            // 
            // nomsl
            // 
            this.nomsl.HeaderText = "Nom";
            this.nomsl.MinimumWidth = 6;
            this.nomsl.Name = "nomsl";
            this.nomsl.Width = 125;
            // 
            // num
            // 
            this.num.HeaderText = "Num";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            this.num.Width = 125;
            // 
            // rib
            // 
            this.rib.HeaderText = "RIB";
            this.rib.MinimumWidth = 6;
            this.rib.Name = "rib";
            this.rib.Width = 125;
            // 
            // HeursTravail
            // 
            this.HeursTravail.HeaderText = "Heurs de travail";
            this.HeursTravail.MinimumWidth = 6;
            this.HeursTravail.Name = "HeursTravail";
            this.HeursTravail.Width = 125;
            // 
            // salairetotal
            // 
            this.salairetotal.HeaderText = "Salaire Total";
            this.salairetotal.MinimumWidth = 6;
            this.salairetotal.Name = "salairetotal";
            this.salairetotal.Width = 125;
            // 
            // datepaie
            // 
            this.datepaie.HeaderText = "Date de paiement";
            this.datepaie.MinimumWidth = 6;
            this.datepaie.Name = "datepaie";
            this.datepaie.Width = 125;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(261, 84);
            this.txtNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(112, 26);
            this.txtNum.TabIndex = 54;
            // 
            // txtHrt
            // 
            this.txtHrt.Location = new System.Drawing.Point(261, 178);
            this.txtHrt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHrt.Name = "txtHrt";
            this.txtHrt.Size = new System.Drawing.Size(112, 26);
            this.txtHrt.TabIndex = 55;
            this.txtHrt.TextChanged += new System.EventHandler(this.txtHrt_TextChanged);
            // 
            // txtSt
            // 
            this.txtSt.Location = new System.Drawing.Point(261, 231);
            this.txtSt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSt.Name = "txtSt";
            this.txtSt.Size = new System.Drawing.Size(112, 26);
            this.txtSt.TabIndex = 56;
            // 
            // FrmPaiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 562);
            this.Controls.Add(this.txtSt);
            this.Controls.Add(this.txtHrt);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.dgvPaiement);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.BtnRetour);
            this.Controls.Add(this.dateTimePickerDp);
            this.Controls.Add(this.lblDp);
            this.Controls.Add(this.txtRIB);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblSt);
            this.Controls.Add(this.lblHrt);
            this.Controls.Add(this.lblRIB);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblNom);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPaiement";
            this.Text = "FrmPaiement";
            this.Load += new System.EventHandler(this.FrmPaiement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaiement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblRIB;
        private System.Windows.Forms.Label lblHrt;
        private System.Windows.Forms.Label lblSt;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtRIB;
        private System.Windows.Forms.Label lblDp;
        private System.Windows.Forms.DateTimePicker dateTimePickerDp;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.DataGridView dgvPaiement;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn rib;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeursTravail;
        private System.Windows.Forms.DataGridViewTextBoxColumn salairetotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn datepaie;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtHrt;
        private System.Windows.Forms.TextBox txtSt;
    }
}