
namespace Centre_D_affaire.GestionSalleDeJeux
{
    partial class FrmNewMember
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
            this.lblNomE = new System.Windows.Forms.Label();
            this.txtnomAdd = new System.Windows.Forms.TextBox();
            this.txtPrenomAdd = new System.Windows.Forms.TextBox();
            this.lblPrenomE = new System.Windows.Forms.Label();
            this.txtTelephoneAdd = new System.Windows.Forms.TextBox();
            this.lblTelphoneE = new System.Windows.Forms.Label();
            this.dateTimeAdd = new System.Windows.Forms.DateTimePicker();
            this.DateNaissance = new System.Windows.Forms.Label();
            this.btnAjouterE = new System.Windows.Forms.Button();
            this.DgvAddE = new System.Windows.Forms.DataGridView();
            this.EreurPNomAdd = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnNumberView = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtPasswordAdd = new System.Windows.Forms.TextBox();
            this.lblPasswordADD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EreurPNomAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomE
            // 
            this.lblNomE.AutoSize = true;
            this.lblNomE.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomE.Location = new System.Drawing.Point(11, 22);
            this.lblNomE.Name = "lblNomE";
            this.lblNomE.Size = new System.Drawing.Size(78, 33);
            this.lblNomE.TabIndex = 0;
            this.lblNomE.Text = "Nom";
            // 
            // txtnomAdd
            // 
            this.txtnomAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtnomAdd.Location = new System.Drawing.Point(194, 22);
            this.txtnomAdd.Multiline = true;
            this.txtnomAdd.Name = "txtnomAdd";
            this.txtnomAdd.Size = new System.Drawing.Size(190, 29);
            this.txtnomAdd.TabIndex = 1;
            this.txtnomAdd.TextChanged += new System.EventHandler(this.txtnomAdd_TextChanged);
            // 
            // txtPrenomAdd
            // 
            this.txtPrenomAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtPrenomAdd.Location = new System.Drawing.Point(194, 66);
            this.txtPrenomAdd.Multiline = true;
            this.txtPrenomAdd.Name = "txtPrenomAdd";
            this.txtPrenomAdd.Size = new System.Drawing.Size(190, 29);
            this.txtPrenomAdd.TabIndex = 3;
            this.txtPrenomAdd.TextChanged += new System.EventHandler(this.txtPrenomAdd_TextChanged);
            // 
            // lblPrenomE
            // 
            this.lblPrenomE.AutoSize = true;
            this.lblPrenomE.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblPrenomE.Location = new System.Drawing.Point(11, 64);
            this.lblPrenomE.Name = "lblPrenomE";
            this.lblPrenomE.Size = new System.Drawing.Size(120, 33);
            this.lblPrenomE.TabIndex = 2;
            this.lblPrenomE.Text = "Prenom";
            // 
            // txtTelephoneAdd
            // 
            this.txtTelephoneAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtTelephoneAdd.Location = new System.Drawing.Point(194, 110);
            this.txtTelephoneAdd.Multiline = true;
            this.txtTelephoneAdd.Name = "txtTelephoneAdd";
            this.txtTelephoneAdd.Size = new System.Drawing.Size(190, 29);
            this.txtTelephoneAdd.TabIndex = 5;
            this.txtTelephoneAdd.TextChanged += new System.EventHandler(this.txtTelephoneAdd_TextChanged);
            // 
            // lblTelphoneE
            // 
            this.lblTelphoneE.AutoSize = true;
            this.lblTelphoneE.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTelphoneE.Location = new System.Drawing.Point(12, 106);
            this.lblTelphoneE.Name = "lblTelphoneE";
            this.lblTelphoneE.Size = new System.Drawing.Size(157, 33);
            this.lblTelphoneE.TabIndex = 4;
            this.lblTelphoneE.Text = "Telephone";
            // 
            // dateTimeAdd
            // 
            this.dateTimeAdd.Location = new System.Drawing.Point(184, 270);
            this.dateTimeAdd.Name = "dateTimeAdd";
            this.dateTimeAdd.Size = new System.Drawing.Size(200, 20);
            this.dateTimeAdd.TabIndex = 8;
            // 
            // DateNaissance
            // 
            this.DateNaissance.AutoSize = true;
            this.DateNaissance.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold);
            this.DateNaissance.Location = new System.Drawing.Point(12, 234);
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Size = new System.Drawing.Size(274, 33);
            this.DateNaissance.TabIndex = 9;
            this.DateNaissance.Text = "Date De Naissance";
            // 
            // btnAjouterE
            // 
            this.btnAjouterE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouterE.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterE.Location = new System.Drawing.Point(12, 296);
            this.btnAjouterE.Name = "btnAjouterE";
            this.btnAjouterE.Size = new System.Drawing.Size(372, 38);
            this.btnAjouterE.TabIndex = 10;
            this.btnAjouterE.Text = "Ajouter";
            this.btnAjouterE.UseVisualStyleBackColor = true;
            this.btnAjouterE.Click += new System.EventHandler(this.btnAjouterE_Click);
            // 
            // DgvAddE
            // 
            this.DgvAddE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAddE.Location = new System.Drawing.Point(-3, 340);
            this.DgvAddE.Name = "DgvAddE";
            this.DgvAddE.Size = new System.Drawing.Size(399, 144);
            this.DgvAddE.TabIndex = 11;
            // 
            // EreurPNomAdd
            // 
            this.EreurPNomAdd.ContainerControl = this;
            // 
            // btnNumberView
            // 
            this.btnNumberView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNumberView.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberView.Location = new System.Drawing.Point(194, 193);
            this.btnNumberView.Name = "btnNumberView";
            this.btnNumberView.Size = new System.Drawing.Size(190, 33);
            this.btnNumberView.TabIndex = 12;
            this.btnNumberView.UseVisualStyleBackColor = true;
            this.btnNumberView.Click += new System.EventHandler(this.btnNumberView_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblNumber.Location = new System.Drawing.Point(11, 191);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(124, 33);
            this.lblNumber.TabIndex = 13;
            this.lblNumber.Text = "Numero";
            // 
            // txtPasswordAdd
            // 
            this.txtPasswordAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtPasswordAdd.Location = new System.Drawing.Point(194, 156);
            this.txtPasswordAdd.Multiline = true;
            this.txtPasswordAdd.Name = "txtPasswordAdd";
            this.txtPasswordAdd.Size = new System.Drawing.Size(190, 29);
            this.txtPasswordAdd.TabIndex = 15;
            this.txtPasswordAdd.TextChanged += new System.EventHandler(this.txtPasswordAdd_TextChanged);
            // 
            // lblPasswordADD
            // 
            this.lblPasswordADD.AutoSize = true;
            this.lblPasswordADD.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordADD.Location = new System.Drawing.Point(12, 153);
            this.lblPasswordADD.Name = "lblPasswordADD";
            this.lblPasswordADD.Size = new System.Drawing.Size(176, 28);
            this.lblPasswordADD.TabIndex = 14;
            this.lblPasswordADD.Text = "Mot De Passe";
            this.lblPasswordADD.Click += new System.EventHandler(this.lblPasswordADD_Click);
            // 
            // FrmNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(396, 483);
            this.Controls.Add(this.txtPasswordAdd);
            this.Controls.Add(this.lblPasswordADD);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnNumberView);
            this.Controls.Add(this.DgvAddE);
            this.Controls.Add(this.btnAjouterE);
            this.Controls.Add(this.DateNaissance);
            this.Controls.Add(this.dateTimeAdd);
            this.Controls.Add(this.txtTelephoneAdd);
            this.Controls.Add(this.lblTelphoneE);
            this.Controls.Add(this.txtPrenomAdd);
            this.Controls.Add(this.lblPrenomE);
            this.Controls.Add(this.txtnomAdd);
            this.Controls.Add(this.lblNomE);
            this.Name = "FrmNewMember";
            this.Text = "FrmNewMember";
            this.Load += new System.EventHandler(this.FrmNewMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAddE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EreurPNomAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomE;
        private System.Windows.Forms.TextBox txtnomAdd;
        private System.Windows.Forms.TextBox txtPrenomAdd;
        private System.Windows.Forms.Label lblPrenomE;
        private System.Windows.Forms.TextBox txtTelephoneAdd;
        private System.Windows.Forms.Label lblTelphoneE;
        private System.Windows.Forms.DateTimePicker dateTimeAdd;
        private System.Windows.Forms.Label DateNaissance;
        private System.Windows.Forms.Button btnAjouterE;
        private System.Windows.Forms.DataGridView DgvAddE;
        private System.Windows.Forms.ErrorProvider EreurPNomAdd;
        private System.Windows.Forms.Button btnNumberView;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtPasswordAdd;
        private System.Windows.Forms.Label lblPasswordADD;
    }
}