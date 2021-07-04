
namespace Centre_D_affaire.GestionPersonnel.CustomControls
{
    partial class frmAlert
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblMessage.ForeColor = System.Drawing.Color.Transparent;
            this.lblMessage.Location = new System.Drawing.Point(90, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(198, 75);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "$ex.message$";
            // 
            // pcbIcon
            // 
            this.pcbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbIcon.Image = global::Centre_D_affaire.Properties.Resources.icons8_error_60px;
            this.pcbIcon.Location = new System.Drawing.Point(12, 12);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(72, 72);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcon.TabIndex = 0;
            this.pcbIcon.TabStop = false;
            // 
            // frmAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(300, 96);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pcbIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlert";
            this.Text = "frmAlert";
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.Label lblMessage;
    }
}