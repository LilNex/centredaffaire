
namespace Centre_D_affaire.GestionSalleDeJeux
{
    partial class FrmEditArcardStreet
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
            this.PnlBillard = new System.Windows.Forms.Panel();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImageBillard = new System.Windows.Forms.Button();
            this.PnlBillard.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBillard
            // 
            this.PnlBillard.Controls.Add(this.btnAddGame);
            this.PnlBillard.Controls.Add(this.btnImageBillard);
            this.PnlBillard.Location = new System.Drawing.Point(12, 12);
            this.PnlBillard.Name = "PnlBillard";
            this.PnlBillard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PnlBillard.Size = new System.Drawing.Size(264, 171);
            this.PnlBillard.TabIndex = 35;
            // 
            // btnAddGame
            // 
            this.btnAddGame.BackColor = System.Drawing.Color.Transparent;
            this.btnAddGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddGame.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGame.Location = new System.Drawing.Point(34, 119);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(202, 43);
            this.btnAddGame.TabIndex = 1;
            this.btnAddGame.Text = "Game";
            this.btnAddGame.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(366, 12);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(264, 171);
            this.panel1.TabIndex = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Employee";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Centre_D_affaire.Properties.Resources.employee_icon_png_27;
            this.pictureBox1.Image = global::Centre_D_affaire.Properties.Resources.employee_icon_png_272;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnImageBillard
            // 
            this.btnImageBillard.BackColor = System.Drawing.Color.Transparent;
            this.btnImageBillard.FlatAppearance.BorderSize = 0;
            this.btnImageBillard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImageBillard.Image = global::Centre_D_affaire.Properties.Resources.queue_de_billard;
            this.btnImageBillard.Location = new System.Drawing.Point(3, 1);
            this.btnImageBillard.Name = "btnImageBillard";
            this.btnImageBillard.Size = new System.Drawing.Size(258, 112);
            this.btnImageBillard.TabIndex = 0;
            this.btnImageBillard.UseVisualStyleBackColor = false;
            // 
            // FrmEditArcardStreet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 198);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlBillard);
            this.Name = "FrmEditArcardStreet";
            this.Text = "FrmAddArcardStreet";
            this.PnlBillard.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBillard;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnImageBillard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}