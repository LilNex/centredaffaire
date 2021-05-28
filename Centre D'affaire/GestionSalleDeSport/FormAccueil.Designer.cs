
namespace Centre_D_affaire.GestionSalleDeSport
{
    partial class FormAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccueil));
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.BTNredire = new Bunifu.Framework.UI.BunifuTileButton();
            this.BTNfermer = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Purple;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.BTNredire);
            this.bunifuPanel2.Controls.Add(this.BTNfermer);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1278, 46);
            this.bunifuPanel2.TabIndex = 23;
            // 
            // BTNredire
            // 
            this.BTNredire.BackColor = System.Drawing.Color.Transparent;
            this.BTNredire.color = System.Drawing.Color.Transparent;
            this.BTNredire.colorActive = System.Drawing.Color.Red;
            this.BTNredire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNredire.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BTNredire.ForeColor = System.Drawing.Color.White;
            this.BTNredire.Image = ((System.Drawing.Image)(resources.GetObject("BTNredire.Image")));
            this.BTNredire.ImagePosition = 5;
            this.BTNredire.ImageZoom = 80;
            this.BTNredire.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTNredire.LabelPosition = 0;
            this.BTNredire.LabelText = "";
            this.BTNredire.Location = new System.Drawing.Point(1174, 1);
            this.BTNredire.Margin = new System.Windows.Forms.Padding(6);
            this.BTNredire.Name = "BTNredire";
            this.BTNredire.Size = new System.Drawing.Size(49, 45);
            this.BTNredire.TabIndex = 13;
            // 
            // BTNfermer
            // 
            this.BTNfermer.BackColor = System.Drawing.Color.Transparent;
            this.BTNfermer.color = System.Drawing.Color.Transparent;
            this.BTNfermer.colorActive = System.Drawing.Color.Red;
            this.BTNfermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNfermer.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BTNfermer.ForeColor = System.Drawing.Color.White;
            this.BTNfermer.Image = ((System.Drawing.Image)(resources.GetObject("BTNfermer.Image")));
            this.BTNfermer.ImagePosition = 5;
            this.BTNfermer.ImageZoom = 80;
            this.BTNfermer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BTNfermer.LabelPosition = 0;
            this.BTNfermer.LabelText = "";
            this.BTNfermer.Location = new System.Drawing.Point(1234, 1);
            this.BTNfermer.Margin = new System.Windows.Forms.Padding(6);
            this.BTNfermer.Name = "BTNfermer";
            this.BTNfermer.Size = new System.Drawing.Size(49, 45);
            this.BTNfermer.TabIndex = 12;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1278, 632);
            this.Controls.Add(this.bunifuPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccueil";
            this.Text = "FormAccueil";
            this.bunifuPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.Framework.UI.BunifuTileButton BTNredire;
        private Bunifu.Framework.UI.BunifuTileButton BTNfermer;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}