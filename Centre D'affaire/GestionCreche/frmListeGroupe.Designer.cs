
namespace Centre_D_affaire.GestionCreche
{
    partial class frmListeGroupe
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.cbGroupe = new System.Windows.Forms.ComboBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnrechercher = new System.Windows.Forms.Button();
            this.btnenregitrer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrechercherParNum = new System.Windows.Forms.TextBox();
            this.lsvListeGroupe = new System.Windows.Forms.ListView();
            this.colNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrénom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGroupe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Groupe :";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(17, 326);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(198, 26);
            this.txtnom.TabIndex = 1;
            this.txtnom.TextChanged += new System.EventHandler(this.txtnom_TextChanged);
            // 
            // cbGroupe
            // 
            this.cbGroupe.FormattingEnabled = true;
            this.cbGroupe.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.cbGroupe.Location = new System.Drawing.Point(16, 243);
            this.cbGroupe.Name = "cbGroupe";
            this.cbGroupe.Size = new System.Drawing.Size(198, 28);
            this.cbGroupe.TabIndex = 2;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(16, 419);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(198, 26);
            this.txtprenom.TabIndex = 6;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(16, 513);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(198, 26);
            this.txtnum.TabIndex = 7;
            this.txtnum.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(1099, 245);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(211, 46);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter :";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prénom  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Num :";
            // 
            // btnrechercher
            // 
            this.btnrechercher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnrechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrechercher.Location = new System.Drawing.Point(756, 289);
            this.btnrechercher.Name = "btnrechercher";
            this.btnrechercher.Size = new System.Drawing.Size(211, 46);
            this.btnrechercher.TabIndex = 13;
            this.btnrechercher.Text = "Rechercher :";
            this.btnrechercher.UseVisualStyleBackColor = false;
            this.btnrechercher.Click += new System.EventHandler(this.btnrechercher_Click);
            // 
            // btnenregitrer
            // 
            this.btnenregitrer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnenregitrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregitrer.Location = new System.Drawing.Point(1099, 400);
            this.btnenregitrer.Name = "btnenregitrer";
            this.btnenregitrer.Size = new System.Drawing.Size(211, 46);
            this.btnenregitrer.TabIndex = 15;
            this.btnenregitrer.Text = "Enregitrer :";
            this.btnenregitrer.UseVisualStyleBackColor = false;
            this.btnenregitrer.Click += new System.EventHandler(this.btnenregitrer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(703, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Num :";
            // 
            // txtrechercherParNum
            // 
            this.txtrechercherParNum.Location = new System.Drawing.Point(802, 245);
            this.txtrechercherParNum.Name = "txtrechercherParNum";
            this.txtrechercherParNum.Size = new System.Drawing.Size(198, 26);
            this.txtrechercherParNum.TabIndex = 17;
            // 
            // lsvListeGroupe
            // 
            this.lsvListeGroupe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum,
            this.colNom,
            this.colPrénom,
            this.colGroupe});
            this.lsvListeGroupe.FullRowSelect = true;
            this.lsvListeGroupe.GridLines = true;
            this.lsvListeGroupe.HideSelection = false;
            this.lsvListeGroupe.Location = new System.Drawing.Point(319, 365);
            this.lsvListeGroupe.MultiSelect = false;
            this.lsvListeGroupe.Name = "lsvListeGroupe";
            this.lsvListeGroupe.Size = new System.Drawing.Size(660, 305);
            this.lsvListeGroupe.TabIndex = 18;
            this.lsvListeGroupe.UseCompatibleStateImageBehavior = false;
            this.lsvListeGroupe.View = System.Windows.Forms.View.Details;
            // 
            // colNum
            // 
            this.colNum.Text = "Num";
            this.colNum.Width = 150;
            // 
            // colNom
            // 
            this.colNom.Text = "Nom";
            this.colNom.Width = 150;
            // 
            // colPrénom
            // 
            this.colPrénom.Text = "Prénom";
            this.colPrénom.Width = 150;
            // 
            // colGroupe
            // 
            this.colGroupe.Text = "Groupe";
            this.colGroupe.Width = 150;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(1099, 323);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(211, 46);
            this.btnSupprimer.TabIndex = 19;
            this.btnSupprimer.Text = "Supprimer  :";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(265, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(702, 108);
            this.label6.TabIndex = 20;
            this.label6.Text = "Listes Groupes";
            // 
            // frmListeGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 720);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.lsvListeGroupe);
            this.Controls.Add(this.txtrechercherParNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnenregitrer);
            this.Controls.Add(this.btnrechercher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.cbGroupe);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label1);
            this.Name = "frmListeGroupe";
            this.Text = "frmListeGroupe";
            this.Load += new System.EventHandler(this.frmListeGroupe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.ComboBox cbGroupe;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnrechercher;
        private System.Windows.Forms.Button btnenregitrer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrechercherParNum;
        private System.Windows.Forms.ListView lsvListeGroupe;
        private System.Windows.Forms.ColumnHeader colNum;
        private System.Windows.Forms.ColumnHeader colNom;
        private System.Windows.Forms.ColumnHeader colPrénom;
        private System.Windows.Forms.ColumnHeader colGroupe;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label label6;
    }
}