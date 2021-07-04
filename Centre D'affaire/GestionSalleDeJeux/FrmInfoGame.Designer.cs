
namespace Centre_D_affaire.GestionSalleDeJeux
{
    partial class FrmInfoGame
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
            this.lblNameInfoGame = new System.Windows.Forms.Label();
            this.txtNameNewGame = new System.Windows.Forms.TextBox();
            this.checkBoxPs4InfoGame = new System.Windows.Forms.CheckBox();
            this.checkBoxBillardInfoGame = new System.Windows.Forms.CheckBox();
            this.checkBoxBabyFootInfoGame = new System.Windows.Forms.CheckBox();
            this.checkBoxArcardStreetInfoGame = new System.Windows.Forms.CheckBox();
            this.btnAddNewGame = new System.Windows.Forms.Button();
            this.EPAddGame = new System.Windows.Forms.ErrorProvider(this.components);
            this.NUDNumberAddGame = new System.Windows.Forms.NumericUpDown();
            this.lblumberAddGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EPAddGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberAddGame)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameInfoGame
            // 
            this.lblNameInfoGame.AutoSize = true;
            this.lblNameInfoGame.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameInfoGame.Location = new System.Drawing.Point(23, 102);
            this.lblNameInfoGame.Name = "lblNameInfoGame";
            this.lblNameInfoGame.Size = new System.Drawing.Size(81, 29);
            this.lblNameInfoGame.TabIndex = 0;
            this.lblNameInfoGame.Text = "Name";
            // 
            // txtNameNewGame
            // 
            this.txtNameNewGame.Location = new System.Drawing.Point(166, 103);
            this.txtNameNewGame.Multiline = true;
            this.txtNameNewGame.Name = "txtNameNewGame";
            this.txtNameNewGame.Size = new System.Drawing.Size(190, 28);
            this.txtNameNewGame.TabIndex = 1;
            // 
            // checkBoxPs4InfoGame
            // 
            this.checkBoxPs4InfoGame.AutoSize = true;
            this.checkBoxPs4InfoGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPs4InfoGame.Location = new System.Drawing.Point(168, 29);
            this.checkBoxPs4InfoGame.Name = "checkBoxPs4InfoGame";
            this.checkBoxPs4InfoGame.Size = new System.Drawing.Size(61, 24);
            this.checkBoxPs4InfoGame.TabIndex = 4;
            this.checkBoxPs4InfoGame.Text = "PS4";
            this.checkBoxPs4InfoGame.UseVisualStyleBackColor = true;
            // 
            // checkBoxBillardInfoGame
            // 
            this.checkBoxBillardInfoGame.AutoSize = true;
            this.checkBoxBillardInfoGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBillardInfoGame.Location = new System.Drawing.Point(28, 29);
            this.checkBoxBillardInfoGame.Name = "checkBoxBillardInfoGame";
            this.checkBoxBillardInfoGame.Size = new System.Drawing.Size(78, 24);
            this.checkBoxBillardInfoGame.TabIndex = 5;
            this.checkBoxBillardInfoGame.Text = "Billard";
            this.checkBoxBillardInfoGame.UseVisualStyleBackColor = true;
            // 
            // checkBoxBabyFootInfoGame
            // 
            this.checkBoxBabyFootInfoGame.AutoSize = true;
            this.checkBoxBabyFootInfoGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBabyFootInfoGame.Location = new System.Drawing.Point(28, 59);
            this.checkBoxBabyFootInfoGame.Name = "checkBoxBabyFootInfoGame";
            this.checkBoxBabyFootInfoGame.Size = new System.Drawing.Size(105, 24);
            this.checkBoxBabyFootInfoGame.TabIndex = 6;
            this.checkBoxBabyFootInfoGame.Text = "BabyFoot";
            this.checkBoxBabyFootInfoGame.UseVisualStyleBackColor = true;
            // 
            // checkBoxArcardStreetInfoGame
            // 
            this.checkBoxArcardStreetInfoGame.AutoSize = true;
            this.checkBoxArcardStreetInfoGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxArcardStreetInfoGame.Location = new System.Drawing.Point(168, 59);
            this.checkBoxArcardStreetInfoGame.Name = "checkBoxArcardStreetInfoGame";
            this.checkBoxArcardStreetInfoGame.Size = new System.Drawing.Size(131, 24);
            this.checkBoxArcardStreetInfoGame.TabIndex = 7;
            this.checkBoxArcardStreetInfoGame.Text = "ArcardStreet";
            this.checkBoxArcardStreetInfoGame.UseVisualStyleBackColor = true;
            // 
            // btnAddNewGame
            // 
            this.btnAddNewGame.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewGame.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewGame.Location = new System.Drawing.Point(46, 203);
            this.btnAddNewGame.Name = "btnAddNewGame";
            this.btnAddNewGame.Size = new System.Drawing.Size(280, 31);
            this.btnAddNewGame.TabIndex = 44;
            this.btnAddNewGame.Text = "Add Game";
            this.btnAddNewGame.UseVisualStyleBackColor = false;
            this.btnAddNewGame.Click += new System.EventHandler(this.btnAddNewGame_Click);
            // 
            // EPAddGame
            // 
            this.EPAddGame.ContainerControl = this;
            // 
            // NUDNumberAddGame
            // 
            this.NUDNumberAddGame.Location = new System.Drawing.Point(166, 152);
            this.NUDNumberAddGame.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NUDNumberAddGame.Name = "NUDNumberAddGame";
            this.NUDNumberAddGame.Size = new System.Drawing.Size(133, 20);
            this.NUDNumberAddGame.TabIndex = 45;
            this.NUDNumberAddGame.ValueChanged += new System.EventHandler(this.NUDNumberAddGame_ValueChanged);
            // 
            // lblumberAddGame
            // 
            this.lblumberAddGame.AutoSize = true;
            this.lblumberAddGame.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblumberAddGame.Location = new System.Drawing.Point(25, 143);
            this.lblumberAddGame.Name = "lblumberAddGame";
            this.lblumberAddGame.Size = new System.Drawing.Size(108, 29);
            this.lblumberAddGame.TabIndex = 46;
            this.lblumberAddGame.Text = "Number";
            // 
            // FrmInfoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 298);
            this.Controls.Add(this.lblumberAddGame);
            this.Controls.Add(this.NUDNumberAddGame);
            this.Controls.Add(this.btnAddNewGame);
            this.Controls.Add(this.checkBoxArcardStreetInfoGame);
            this.Controls.Add(this.checkBoxBabyFootInfoGame);
            this.Controls.Add(this.checkBoxBillardInfoGame);
            this.Controls.Add(this.checkBoxPs4InfoGame);
            this.Controls.Add(this.txtNameNewGame);
            this.Controls.Add(this.lblNameInfoGame);
            this.Name = "FrmInfoGame";
            this.Text = "FrmInfoGame";
            ((System.ComponentModel.ISupportInitialize)(this.EPAddGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberAddGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameInfoGame;
        private System.Windows.Forms.TextBox txtNameNewGame;
        private System.Windows.Forms.CheckBox checkBoxPs4InfoGame;
        private System.Windows.Forms.CheckBox checkBoxBillardInfoGame;
        private System.Windows.Forms.CheckBox checkBoxBabyFootInfoGame;
        private System.Windows.Forms.CheckBox checkBoxArcardStreetInfoGame;
        private System.Windows.Forms.Button btnAddNewGame;
        private System.Windows.Forms.ErrorProvider EPAddGame;
        private System.Windows.Forms.Label lblumberAddGame;
        private System.Windows.Forms.NumericUpDown NUDNumberAddGame;
    }
}