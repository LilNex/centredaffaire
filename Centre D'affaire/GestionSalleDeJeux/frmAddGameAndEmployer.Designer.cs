
namespace Centre_D_affaire.GestionSalleDeJeux
{
    partial class frmAddGameAndEmployer
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
            this.paneladdemplyoer = new System.Windows.Forms.Panel();
            this.btnemployer = new System.Windows.Forms.Button();
            this.PnlBillardaddall = new System.Windows.Forms.Panel();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.picEmployer = new System.Windows.Forms.PictureBox();
            this.btnImageBillard = new System.Windows.Forms.Button();
            this.paneladdemplyoer.SuspendLayout();
            this.PnlBillardaddall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployer)).BeginInit();
            this.SuspendLayout();
            // 
            // paneladdemplyoer
            // 
            this.paneladdemplyoer.Controls.Add(this.picEmployer);
            this.paneladdemplyoer.Controls.Add(this.btnemployer);
            this.paneladdemplyoer.Location = new System.Drawing.Point(366, 14);
            this.paneladdemplyoer.Name = "paneladdemplyoer";
            this.paneladdemplyoer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.paneladdemplyoer.Size = new System.Drawing.Size(264, 171);
            this.paneladdemplyoer.TabIndex = 36;
            // 
            // btnemployer
            // 
            this.btnemployer.BackColor = System.Drawing.Color.Transparent;
            this.btnemployer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnemployer.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemployer.Location = new System.Drawing.Point(34, 119);
            this.btnemployer.Name = "btnemployer";
            this.btnemployer.Size = new System.Drawing.Size(202, 43);
            this.btnemployer.TabIndex = 1;
            this.btnemployer.Text = "Employee";
            this.btnemployer.UseVisualStyleBackColor = false;
            this.btnemployer.Click += new System.EventHandler(this.btnemployer_Click);
            // 
            // PnlBillardaddall
            // 
            this.PnlBillardaddall.Controls.Add(this.btnAddGame);
            this.PnlBillardaddall.Controls.Add(this.btnImageBillard);
            this.PnlBillardaddall.Location = new System.Drawing.Point(12, 14);
            this.PnlBillardaddall.Name = "PnlBillardaddall";
            this.PnlBillardaddall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PnlBillardaddall.Size = new System.Drawing.Size(264, 171);
            this.PnlBillardaddall.TabIndex = 37;
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
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // picEmployer
            // 
            this.picEmployer.ErrorImage = global::Centre_D_affaire.Properties.Resources.employee_icon_png_27;
            this.picEmployer.Image = global::Centre_D_affaire.Properties.Resources.employee_icon_png_272;
            this.picEmployer.InitialImage = null;
            this.picEmployer.Location = new System.Drawing.Point(3, 1);
            this.picEmployer.Name = "picEmployer";
            this.picEmployer.Size = new System.Drawing.Size(258, 112);
            this.picEmployer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEmployer.TabIndex = 36;
            this.picEmployer.TabStop = false;
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
            this.btnImageBillard.Text = "<";
            this.btnImageBillard.UseVisualStyleBackColor = false;
            // 
            // frmAddGameAndEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 198);
            this.Controls.Add(this.paneladdemplyoer);
            this.Controls.Add(this.PnlBillardaddall);
            this.Name = "frmAddGameAndEmployer";
            this.Text = "frmAddGameAndEmployer";
            this.paneladdemplyoer.ResumeLayout(false);
            this.PnlBillardaddall.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEmployer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneladdemplyoer;
        private System.Windows.Forms.PictureBox picEmployer;
        private System.Windows.Forms.Button btnemployer;
        private System.Windows.Forms.Panel PnlBillardaddall;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Button btnImageBillard;
    }
}