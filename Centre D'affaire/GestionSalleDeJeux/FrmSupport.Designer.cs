
namespace Centre_D_affaire.GestionSalleDeJeux
{
    partial class FrmSupport
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
            this.WebSupport = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // WebSupport
            // 
            this.WebSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebSupport.Location = new System.Drawing.Point(0, 0);
            this.WebSupport.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebSupport.Name = "WebSupport";
            this.WebSupport.Size = new System.Drawing.Size(857, 493);
            this.WebSupport.TabIndex = 0;
            this.WebSupport.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // FrmSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 493);
            this.Controls.Add(this.WebSupport);
            this.Name = "FrmSupport";
            this.Text = "FrmSupport";
            this.Load += new System.EventHandler(this.FrmSupport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebSupport;
    }
}