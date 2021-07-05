
namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class UCAjoutEmploye
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
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblText_Prenom = new System.Windows.Forms.Label();
            this.lblText_Nom = new System.Windows.Forms.Label();
            this.lblText_Numero = new System.Windows.Forms.Label();
            this.lblText_Ajout = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.datePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblText_DateNaissance = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumTel = new System.Windows.Forms.TextBox();
            this.lblText_Adresse = new System.Windows.Forms.Label();
            this.lblText_Email = new System.Windows.Forms.Label();
            this.lblText_NumTel = new System.Windows.Forms.Label();
            this.lblText_Coords = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtCIN = new System.Windows.Forms.TextBox();
            this.lblText_Competence = new System.Windows.Forms.Label();
            this.lblText_CIN = new System.Windows.Forms.Label();
            this.lblText_CB = new System.Windows.Forms.Label();
            this.txtBanque = new System.Windows.Forms.TextBox();
            this.txtRIB = new System.Windows.Forms.TextBox();
            this.txtNomTitulaire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpSexe = new System.Windows.Forms.GroupBox();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.rdbH = new System.Windows.Forms.RadioButton();
            this.lblText_Dep = new System.Windows.Forms.Label();
            this.lblText_Poste = new System.Windows.Forms.Label();
            this.cmbDeparts = new System.Windows.Forms.ComboBox();
            this.cmbPoste = new System.Windows.Forms.ComboBox();
            this.lblText_Badge = new System.Windows.Forms.Label();
            this.txtIdBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTDirecteur = new System.Windows.Forms.RadioButton();
            this.rdbTSecretaire = new System.Windows.Forms.RadioButton();
            this.rdbTEmp = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.grpSexe.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.DarkGray;
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrenom.Location = new System.Drawing.Point(145, 134);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(137, 19);
            this.txtPrenom.TabIndex = 22;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.DarkGray;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNom.Location = new System.Drawing.Point(145, 91);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(137, 19);
            this.txtNom.TabIndex = 21;
            this.txtNom.TextChanged += new System.EventHandler(this.txtRechercheNom_TextChanged);
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.DarkGray;
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(145, 48);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(137, 19);
            this.txtNum.TabIndex = 20;
            // 
            // lblText_Prenom
            // 
            this.lblText_Prenom.AutoSize = true;
            this.lblText_Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Prenom.Location = new System.Drawing.Point(142, 114);
            this.lblText_Prenom.Name = "lblText_Prenom";
            this.lblText_Prenom.Size = new System.Drawing.Size(61, 16);
            this.lblText_Prenom.TabIndex = 19;
            this.lblText_Prenom.Text = "Prénom :";
            // 
            // lblText_Nom
            // 
            this.lblText_Nom.AutoSize = true;
            this.lblText_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Nom.Location = new System.Drawing.Point(142, 71);
            this.lblText_Nom.Name = "lblText_Nom";
            this.lblText_Nom.Size = new System.Drawing.Size(43, 16);
            this.lblText_Nom.TabIndex = 18;
            this.lblText_Nom.Text = "Nom :";
            // 
            // lblText_Numero
            // 
            this.lblText_Numero.AutoSize = true;
            this.lblText_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Numero.Location = new System.Drawing.Point(142, 28);
            this.lblText_Numero.Name = "lblText_Numero";
            this.lblText_Numero.Size = new System.Drawing.Size(62, 16);
            this.lblText_Numero.TabIndex = 17;
            this.lblText_Numero.Text = "Numéro :";
            // 
            // lblText_Ajout
            // 
            this.lblText_Ajout.AutoSize = true;
            this.lblText_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Ajout.Location = new System.Drawing.Point(3, 0);
            this.lblText_Ajout.Name = "lblText_Ajout";
            this.lblText_Ajout.Size = new System.Drawing.Size(183, 24);
            this.lblText_Ajout.TabIndex = 16;
            this.lblText_Ajout.Text = "Ajout d\'un employé :";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox.Image = global::Centre_D_affaire.Properties.Resources.icons8_male_user_32px1;
            this.pictureBox.Location = new System.Drawing.Point(8, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(131, 125);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox_DoubleClick);
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.datePicker.BorderRadius = 10;
            this.datePicker.ForeColor = System.Drawing.Color.White;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker.FormatCustom = null;
            this.datePicker.Location = new System.Drawing.Point(7, 175);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(274, 33);
            this.datePicker.TabIndex = 24;
            this.datePicker.Value = new System.DateTime(2021, 5, 5, 16, 29, 53, 912);
            // 
            // lblText_DateNaissance
            // 
            this.lblText_DateNaissance.AutoSize = true;
            this.lblText_DateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_DateNaissance.Location = new System.Drawing.Point(5, 156);
            this.lblText_DateNaissance.Name = "lblText_DateNaissance";
            this.lblText_DateNaissance.Size = new System.Drawing.Size(127, 16);
            this.lblText_DateNaissance.TabIndex = 25;
            this.lblText_DateNaissance.Text = "Date de naissance :";
            // 
            // txtAdresse
            // 
            this.txtAdresse.BackColor = System.Drawing.Color.DarkGray;
            this.txtAdresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAdresse.Location = new System.Drawing.Point(11, 306);
            this.txtAdresse.Multiline = true;
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(271, 65);
            this.txtAdresse.TabIndex = 32;
            this.txtAdresse.TextChanged += new System.EventHandler(this.txtAdresse_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.DarkGray;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(165, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(117, 19);
            this.txtEmail.TabIndex = 31;
            // 
            // txtNumTel
            // 
            this.txtNumTel.BackColor = System.Drawing.Color.DarkGray;
            this.txtNumTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumTel.Location = new System.Drawing.Point(11, 263);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(124, 19);
            this.txtNumTel.TabIndex = 30;
            // 
            // lblText_Adresse
            // 
            this.lblText_Adresse.AutoSize = true;
            this.lblText_Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Adresse.Location = new System.Drawing.Point(8, 286);
            this.lblText_Adresse.Name = "lblText_Adresse";
            this.lblText_Adresse.Size = new System.Drawing.Size(65, 16);
            this.lblText_Adresse.TabIndex = 29;
            this.lblText_Adresse.Text = "Adresse :";
            // 
            // lblText_Email
            // 
            this.lblText_Email.AutoSize = true;
            this.lblText_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Email.Location = new System.Drawing.Point(162, 243);
            this.lblText_Email.Name = "lblText_Email";
            this.lblText_Email.Size = new System.Drawing.Size(48, 16);
            this.lblText_Email.TabIndex = 28;
            this.lblText_Email.Text = "Email :";
            // 
            // lblText_NumTel
            // 
            this.lblText_NumTel.AutoSize = true;
            this.lblText_NumTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_NumTel.Location = new System.Drawing.Point(8, 243);
            this.lblText_NumTel.Name = "lblText_NumTel";
            this.lblText_NumTel.Size = new System.Drawing.Size(144, 16);
            this.lblText_NumTel.TabIndex = 27;
            this.lblText_NumTel.Text = "Numéro de téléphone :";
            // 
            // lblText_Coords
            // 
            this.lblText_Coords.AutoSize = true;
            this.lblText_Coords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Coords.Location = new System.Drawing.Point(4, 211);
            this.lblText_Coords.Name = "lblText_Coords";
            this.lblText_Coords.Size = new System.Drawing.Size(125, 24);
            this.lblText_Coords.TabIndex = 33;
            this.lblText_Coords.Text = "Coordonées :";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DarkGray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox5.Location = new System.Drawing.Point(301, 91);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(284, 63);
            this.textBox5.TabIndex = 38;
            // 
            // txtCIN
            // 
            this.txtCIN.BackColor = System.Drawing.Color.DarkGray;
            this.txtCIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCIN.Location = new System.Drawing.Point(301, 48);
            this.txtCIN.Name = "txtCIN";
            this.txtCIN.Size = new System.Drawing.Size(124, 19);
            this.txtCIN.TabIndex = 37;
            // 
            // lblText_Competence
            // 
            this.lblText_Competence.AutoSize = true;
            this.lblText_Competence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Competence.Location = new System.Drawing.Point(298, 71);
            this.lblText_Competence.Name = "lblText_Competence";
            this.lblText_Competence.Size = new System.Drawing.Size(92, 16);
            this.lblText_Competence.TabIndex = 35;
            this.lblText_Competence.Text = "Compétences";
            // 
            // lblText_CIN
            // 
            this.lblText_CIN.AutoSize = true;
            this.lblText_CIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_CIN.Location = new System.Drawing.Point(298, 28);
            this.lblText_CIN.Name = "lblText_CIN";
            this.lblText_CIN.Size = new System.Drawing.Size(36, 16);
            this.lblText_CIN.TabIndex = 34;
            this.lblText_CIN.Text = "CIN :";
            // 
            // lblText_CB
            // 
            this.lblText_CB.AutoSize = true;
            this.lblText_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_CB.Location = new System.Drawing.Point(299, 211);
            this.lblText_CB.Name = "lblText_CB";
            this.lblText_CB.Size = new System.Drawing.Size(165, 24);
            this.lblText_CB.TabIndex = 40;
            this.lblText_CB.Text = "Compte Bancaire :";
            // 
            // txtBanque
            // 
            this.txtBanque.BackColor = System.Drawing.Color.DarkGray;
            this.txtBanque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBanque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBanque.Location = new System.Drawing.Point(304, 349);
            this.txtBanque.Name = "txtBanque";
            this.txtBanque.Size = new System.Drawing.Size(281, 19);
            this.txtBanque.TabIndex = 46;
            // 
            // txtRIB
            // 
            this.txtRIB.BackColor = System.Drawing.Color.DarkGray;
            this.txtRIB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRIB.Location = new System.Drawing.Point(304, 306);
            this.txtRIB.Name = "txtRIB";
            this.txtRIB.Size = new System.Drawing.Size(281, 19);
            this.txtRIB.TabIndex = 45;
            // 
            // txtNomTitulaire
            // 
            this.txtNomTitulaire.BackColor = System.Drawing.Color.DarkGray;
            this.txtNomTitulaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomTitulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNomTitulaire.Location = new System.Drawing.Point(304, 263);
            this.txtNomTitulaire.Name = "txtNomTitulaire";
            this.txtNomTitulaire.Size = new System.Drawing.Size(281, 19);
            this.txtNomTitulaire.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Banque :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "RIB :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(301, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nom Titulaire :";
            // 
            // grpSexe
            // 
            this.grpSexe.Controls.Add(this.rdbF);
            this.grpSexe.Controls.Add(this.rdbH);
            this.grpSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSexe.Location = new System.Drawing.Point(431, 28);
            this.grpSexe.Name = "grpSexe";
            this.grpSexe.Size = new System.Drawing.Size(154, 42);
            this.grpSexe.TabIndex = 47;
            this.grpSexe.TabStop = false;
            this.grpSexe.Text = "Sexe";
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.FlatAppearance.BorderSize = 0;
            this.rdbF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbF.Location = new System.Drawing.Point(84, 17);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(71, 20);
            this.rdbF.TabIndex = 1;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "Femme";
            this.rdbF.UseVisualStyleBackColor = true;
            this.rdbF.CheckedChanged += new System.EventHandler(this.rdbF_CheckedChanged);
            // 
            // rdbH
            // 
            this.rdbH.AutoSize = true;
            this.rdbH.FlatAppearance.BorderSize = 0;
            this.rdbH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbH.Location = new System.Drawing.Point(6, 17);
            this.rdbH.Name = "rdbH";
            this.rdbH.Size = new System.Drawing.Size(73, 20);
            this.rdbH.TabIndex = 0;
            this.rdbH.TabStop = true;
            this.rdbH.Text = "Homme";
            this.rdbH.UseVisualStyleBackColor = true;
            this.rdbH.CheckedChanged += new System.EventHandler(this.rdbH_CheckedChanged);
            // 
            // lblText_Dep
            // 
            this.lblText_Dep.AutoSize = true;
            this.lblText_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Dep.Location = new System.Drawing.Point(6, 374);
            this.lblText_Dep.Name = "lblText_Dep";
            this.lblText_Dep.Size = new System.Drawing.Size(128, 24);
            this.lblText_Dep.TabIndex = 49;
            this.lblText_Dep.Text = "Departement :";
            // 
            // lblText_Poste
            // 
            this.lblText_Poste.AutoSize = true;
            this.lblText_Poste.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Poste.Location = new System.Drawing.Point(6, 426);
            this.lblText_Poste.Name = "lblText_Poste";
            this.lblText_Poste.Size = new System.Drawing.Size(67, 24);
            this.lblText_Poste.TabIndex = 50;
            this.lblText_Poste.Text = "Poste :";
            // 
            // cmbDeparts
            // 
            this.cmbDeparts.BackColor = System.Drawing.SystemColors.Control;
            this.cmbDeparts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeparts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeparts.FormattingEnabled = true;
            this.cmbDeparts.Location = new System.Drawing.Point(11, 402);
            this.cmbDeparts.Name = "cmbDeparts";
            this.cmbDeparts.Size = new System.Drawing.Size(145, 21);
            this.cmbDeparts.TabIndex = 51;
            this.cmbDeparts.SelectedIndexChanged += new System.EventHandler(this.cmbDeparts_SelectedIndexChanged);
            // 
            // cmbPoste
            // 
            this.cmbPoste.BackColor = System.Drawing.SystemColors.Control;
            this.cmbPoste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPoste.FormattingEnabled = true;
            this.cmbPoste.Location = new System.Drawing.Point(11, 454);
            this.cmbPoste.Name = "cmbPoste";
            this.cmbPoste.Size = new System.Drawing.Size(145, 21);
            this.cmbPoste.TabIndex = 52;
            // 
            // lblText_Badge
            // 
            this.lblText_Badge.AutoSize = true;
            this.lblText_Badge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText_Badge.Location = new System.Drawing.Point(604, 0);
            this.lblText_Badge.Name = "lblText_Badge";
            this.lblText_Badge.Size = new System.Drawing.Size(75, 24);
            this.lblText_Badge.TabIndex = 54;
            this.lblText_Badge.Text = "Badge :";
            // 
            // txtIdBox
            // 
            this.txtIdBox.BackColor = System.Drawing.Color.DarkGray;
            this.txtIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdBox.Enabled = false;
            this.txtIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIdBox.Location = new System.Drawing.Point(609, 48);
            this.txtIdBox.Name = "txtIdBox";
            this.txtIdBox.Size = new System.Drawing.Size(124, 19);
            this.txtIdBox.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "ID Badge : ";
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
            this.btnEffacer.Location = new System.Drawing.Point(827, 435);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(113, 39);
            this.btnEffacer.TabIndex = 59;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(174)))), ((int)(((byte)(238)))));
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Image = global::Centre_D_affaire.Properties.Resources.icons8_add_user_male_32px;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(827, 390);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(113, 39);
            this.btnAjouter.TabIndex = 60;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTDirecteur);
            this.groupBox1.Controls.Add(this.rdbTSecretaire);
            this.groupBox1.Controls.Add(this.rdbTEmp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(609, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 42);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexe";
            // 
            // rdbTDirecteur
            // 
            this.rdbTDirecteur.AutoSize = true;
            this.rdbTDirecteur.FlatAppearance.BorderSize = 0;
            this.rdbTDirecteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbTDirecteur.Location = new System.Drawing.Point(177, 16);
            this.rdbTDirecteur.Name = "rdbTDirecteur";
            this.rdbTDirecteur.Size = new System.Drawing.Size(79, 20);
            this.rdbTDirecteur.TabIndex = 2;
            this.rdbTDirecteur.TabStop = true;
            this.rdbTDirecteur.Text = "Directeur";
            this.rdbTDirecteur.UseVisualStyleBackColor = true;
            // 
            // rdbTSecretaire
            // 
            this.rdbTSecretaire.AutoSize = true;
            this.rdbTSecretaire.FlatAppearance.BorderSize = 0;
            this.rdbTSecretaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbTSecretaire.Location = new System.Drawing.Point(84, 17);
            this.rdbTSecretaire.Name = "rdbTSecretaire";
            this.rdbTSecretaire.Size = new System.Drawing.Size(87, 20);
            this.rdbTSecretaire.TabIndex = 1;
            this.rdbTSecretaire.TabStop = true;
            this.rdbTSecretaire.Text = "Secretaire";
            this.rdbTSecretaire.UseVisualStyleBackColor = true;
            // 
            // rdbTEmp
            // 
            this.rdbTEmp.AutoSize = true;
            this.rdbTEmp.FlatAppearance.BorderSize = 0;
            this.rdbTEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbTEmp.Location = new System.Drawing.Point(6, 17);
            this.rdbTEmp.Name = "rdbTEmp";
            this.rdbTEmp.Size = new System.Drawing.Size(79, 20);
            this.rdbTEmp.TabIndex = 0;
            this.rdbTEmp.TabStop = true;
            this.rdbTEmp.Text = "Employe";
            this.rdbTEmp.UseVisualStyleBackColor = true;
            // 
            // UCAjoutEmploye
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdBox);
            this.Controls.Add(this.lblText_Badge);
            this.Controls.Add(this.cmbPoste);
            this.Controls.Add(this.cmbDeparts);
            this.Controls.Add(this.lblText_Poste);
            this.Controls.Add(this.lblText_Dep);
            this.Controls.Add(this.grpSexe);
            this.Controls.Add(this.txtBanque);
            this.Controls.Add(this.txtRIB);
            this.Controls.Add(this.txtNomTitulaire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblText_CB);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtCIN);
            this.Controls.Add(this.lblText_Competence);
            this.Controls.Add(this.lblText_CIN);
            this.Controls.Add(this.lblText_Coords);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNumTel);
            this.Controls.Add(this.lblText_Adresse);
            this.Controls.Add(this.lblText_Email);
            this.Controls.Add(this.lblText_NumTel);
            this.Controls.Add(this.lblText_DateNaissance);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblText_Prenom);
            this.Controls.Add(this.lblText_Nom);
            this.Controls.Add(this.lblText_Numero);
            this.Controls.Add(this.lblText_Ajout);
            this.Name = "UCAjoutEmploye";
            this.Size = new System.Drawing.Size(952, 529);
            this.Load += new System.EventHandler(this.UCAjoutEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.grpSexe.ResumeLayout(false);
            this.grpSexe.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblText_Prenom;
        private System.Windows.Forms.Label lblText_Nom;
        private System.Windows.Forms.Label lblText_Numero;
        private System.Windows.Forms.Label lblText_Ajout;
        private System.Windows.Forms.PictureBox pictureBox;
        private Bunifu.Framework.UI.BunifuDatepicker datePicker;
        private System.Windows.Forms.Label lblText_DateNaissance;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumTel;
        private System.Windows.Forms.Label lblText_Adresse;
        private System.Windows.Forms.Label lblText_Email;
        private System.Windows.Forms.Label lblText_NumTel;
        private System.Windows.Forms.Label lblText_Coords;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtCIN;
        private System.Windows.Forms.Label lblText_Competence;
        private System.Windows.Forms.Label lblText_CIN;
        private System.Windows.Forms.Label lblText_CB;
        private System.Windows.Forms.TextBox txtBanque;
        private System.Windows.Forms.TextBox txtRIB;
        private System.Windows.Forms.TextBox txtNomTitulaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpSexe;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.RadioButton rdbH;
        private System.Windows.Forms.Label lblText_Dep;
        private System.Windows.Forms.Label lblText_Poste;
        private System.Windows.Forms.ComboBox cmbDeparts;
        private System.Windows.Forms.ComboBox cmbPoste;
        private System.Windows.Forms.Label lblText_Badge;
        private System.Windows.Forms.TextBox txtIdBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTDirecteur;
        private System.Windows.Forms.RadioButton rdbTSecretaire;
        private System.Windows.Forms.RadioButton rdbTEmp;
    }
}
