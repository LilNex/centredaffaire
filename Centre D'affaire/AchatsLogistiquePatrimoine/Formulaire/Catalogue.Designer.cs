
namespace Centre_D_affaire.AchatsLogistiquePatrimoine
{
    partial class Catalogue
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsuivant = new System.Windows.Forms.Button();
            this.btnRetirer = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.dgvFinal = new System.Windows.Forms.DataGridView();
            this.lblChoi = new System.Windows.Forms.Label();
            this.dgvCHoi = new System.Windows.Forms.DataGridView();
            this.cmbProduit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlHaut = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHoi)).BeginInit();
            this.pnlHaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATALOGUE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(421, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "BIENVENUE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnsuivant);
            this.panel1.Controls.Add(this.btnRetirer);
            this.panel1.Controls.Add(this.btnVider);
            this.panel1.Controls.Add(this.btnChoisir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblFinal);
            this.panel1.Controls.Add(this.dgvFinal);
            this.panel1.Controls.Add(this.lblChoi);
            this.panel1.Controls.Add(this.dgvCHoi);
            this.panel1.Location = new System.Drawing.Point(53, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 402);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnsuivant
            // 
            this.btnsuivant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsuivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuivant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuivant.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsuivant.Location = new System.Drawing.Point(730, 330);
            this.btnsuivant.Name = "btnsuivant";
            this.btnsuivant.Size = new System.Drawing.Size(80, 53);
            this.btnsuivant.TabIndex = 19;
            this.btnsuivant.Text = "Suivant";
            this.btnsuivant.UseVisualStyleBackColor = false;
            this.btnsuivant.Click += new System.EventHandler(this.btnsuivant_Click);
            // 
            // btnRetirer
            // 
            this.btnRetirer.BackColor = System.Drawing.Color.Transparent;
            this.btnRetirer.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirer.Location = new System.Drawing.Point(372, 225);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(117, 53);
            this.btnRetirer.TabIndex = 17;
            this.btnRetirer.Text = "<< RETIRER";
            this.btnRetirer.UseVisualStyleBackColor = false;
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirer_Click);
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.Color.Transparent;
            this.btnVider.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.Location = new System.Drawing.Point(521, 330);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(81, 53);
            this.btnVider.TabIndex = 16;
            this.btnVider.Text = "VIDER LISTE";
            this.btnVider.UseVisualStyleBackColor = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnChoisir
            // 
            this.btnChoisir.BackColor = System.Drawing.Color.Transparent;
            this.btnChoisir.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoisir.Location = new System.Drawing.Point(372, 166);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(117, 53);
            this.btnChoisir.TabIndex = 15;
            this.btnChoisir.Text = "CHOISIR >>";
            this.btnChoisir.UseVisualStyleBackColor = false;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(324, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFinal.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(518, 18);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(153, 17);
            this.lblFinal.TabIndex = 13;
            this.lblFinal.Text = "Commande Finale :";
            // 
            // dgvFinal
            // 
            this.dgvFinal.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvFinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinal.Location = new System.Drawing.Point(521, 43);
            this.dgvFinal.Name = "dgvFinal";
            this.dgvFinal.RowHeadersWidth = 51;
            this.dgvFinal.Size = new System.Drawing.Size(289, 285);
            this.dgvFinal.TabIndex = 1;
            this.dgvFinal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinal_CellClick);
            this.dgvFinal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinal_CellContentClick);
            this.dgvFinal.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgvFinal_ColumnAdded);
            // 
            // lblChoi
            // 
            this.lblChoi.AutoSize = true;
            this.lblChoi.BackColor = System.Drawing.Color.Transparent;
            this.lblChoi.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoi.Location = new System.Drawing.Point(26, 18);
            this.lblChoi.Name = "lblChoi";
            this.lblChoi.Size = new System.Drawing.Size(153, 17);
            this.lblChoi.TabIndex = 12;
            this.lblChoi.Text = "Faites votre choix :";
            this.lblChoi.Click += new System.EventHandler(this.lblChoi_Click);
            // 
            // dgvCHoi
            // 
            this.dgvCHoi.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvCHoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCHoi.Location = new System.Drawing.Point(29, 43);
            this.dgvCHoi.Name = "dgvCHoi";
            this.dgvCHoi.RowHeadersWidth = 51;
            this.dgvCHoi.Size = new System.Drawing.Size(289, 285);
            this.dgvCHoi.TabIndex = 0;
            this.dgvCHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCHoi_CellClick);
            this.dgvCHoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCHoi_CellContentClick);
            this.dgvCHoi.Click += new System.EventHandler(this.dgvCHoi_Click);
            // 
            // cmbProduit
            // 
            this.cmbProduit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbProduit.FormattingEnabled = true;
            this.cmbProduit.Location = new System.Drawing.Point(219, 112);
            this.cmbProduit.Name = "cmbProduit";
            this.cmbProduit.Size = new System.Drawing.Size(214, 21);
            this.cmbProduit.TabIndex = 4;
            this.cmbProduit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbProduit.Click += new System.EventHandler(this.cmbProduit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CHOISIR CATEGORIE";
            // 
            // pnlHaut
            // 
            this.pnlHaut.Controls.Add(this.label1);
            this.pnlHaut.Controls.Add(this.label2);
            this.pnlHaut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHaut.Location = new System.Drawing.Point(0, 0);
            this.pnlHaut.Name = "pnlHaut";
            this.pnlHaut.Size = new System.Drawing.Size(982, 80);
            this.pnlHaut.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Centre_D_affaire.Properties.Resources.WhatsApp_Image_2021_07_03_at_12_23_06;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 151);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.LocationChanged += new System.EventHandler(this.pictureBox2_LocationChanged);
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Centre_D_affaire.Properties.Resources.depositphotos_18595071_stock_photo_light_room;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 638);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlHaut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbProduit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catalogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Catalogue_Load);
            this.Click += new System.EventHandler(this.Catalogue_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHoi)).EndInit();
            this.pnlHaut.ResumeLayout(false);
            this.pnlHaut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbProduit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlHaut;
        private System.Windows.Forms.Label lblChoi;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.DataGridView dgvFinal;
        private System.Windows.Forms.DataGridView dgvCHoi;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.Button btnsuivant;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}