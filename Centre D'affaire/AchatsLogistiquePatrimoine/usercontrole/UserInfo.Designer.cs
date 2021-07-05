
namespace Centre_D_affaire
{
    partial class UserInfo
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfo));
            this.pnlhaut = new System.Windows.Forms.Panel();
            this.lblinfo = new System.Windows.Forms.Label();
            this.bunifunom = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifudescription = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifutelephone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuMetroTextbox2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlhaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlhaut
            // 
            this.pnlhaut.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlhaut.Controls.Add(this.label1);
            this.pnlhaut.Controls.Add(this.lblinfo);
            this.pnlhaut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlhaut.Location = new System.Drawing.Point(0, 0);
            this.pnlhaut.Name = "pnlhaut";
            this.pnlhaut.Size = new System.Drawing.Size(1347, 88);
            this.pnlhaut.TabIndex = 0;
            this.pnlhaut.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlhaut_Paint);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(111, 24);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(328, 40);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "DETAIL DEMANDE";
            // 
            // bunifunom
            // 
            this.bunifunom.BorderColorFocused = System.Drawing.Color.White;
            this.bunifunom.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.bunifunom.BorderColorMouseHover = System.Drawing.Color.White;
            this.bunifunom.BorderThickness = 3;
            this.bunifunom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifunom.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifunom.ForeColor = System.Drawing.Color.LightSlateGray;
            this.bunifunom.isPassword = false;
            this.bunifunom.Location = new System.Drawing.Point(86, 122);
            this.bunifunom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifunom.Name = "bunifunom";
            this.bunifunom.Size = new System.Drawing.Size(382, 48);
            this.bunifunom.TabIndex = 1;
            this.bunifunom.Text = "NOM  DEMANDEUR";
            this.bunifunom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifunom.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(492, 538);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifudescription
            // 
            this.bunifudescription.BorderColorFocused = System.Drawing.Color.Gray;
            this.bunifudescription.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.bunifudescription.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifudescription.BorderThickness = 3;
            this.bunifudescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifudescription.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifudescription.ForeColor = System.Drawing.Color.LightSlateGray;
            this.bunifudescription.isPassword = false;
            this.bunifudescription.Location = new System.Drawing.Point(86, 191);
            this.bunifudescription.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifudescription.Name = "bunifudescription";
            this.bunifudescription.Size = new System.Drawing.Size(382, 48);
            this.bunifudescription.TabIndex = 6;
            this.bunifudescription.Text = "DESCRIPTION";
            this.bunifudescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifutelephone
            // 
            this.bunifutelephone.BorderColorFocused = System.Drawing.Color.Gray;
            this.bunifutelephone.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.bunifutelephone.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifutelephone.BorderThickness = 3;
            this.bunifutelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifutelephone.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifutelephone.ForeColor = System.Drawing.Color.LightSlateGray;
            this.bunifutelephone.isPassword = false;
            this.bunifutelephone.Location = new System.Drawing.Point(86, 261);
            this.bunifutelephone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifutelephone.Name = "bunifutelephone";
            this.bunifutelephone.Size = new System.Drawing.Size(382, 48);
            this.bunifutelephone.TabIndex = 7;
            this.bunifutelephone.Text = "TELEPHONE";
            this.bunifutelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.SteelBlue;
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.bunifuMetroTextbox2.BorderThickness = 3;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(86, 328);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(382, 48);
            this.bunifuMetroTextbox2.TabIndex = 9;
            this.bunifuMetroTextbox2.Text = "E-MAIL";
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(569, 538);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(71, 70);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 11;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(761, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "DEMANDE FINAL";
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuMetroTextbox2);
            this.Controls.Add(this.bunifutelephone);
            this.Controls.Add(this.bunifudescription);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifunom);
            this.Controls.Add(this.pnlhaut);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(1347, 611);
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.pnlhaut.ResumeLayout(false);
            this.pnlhaut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlhaut;
        private System.Windows.Forms.Label lblinfo;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifunom;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifudescription;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifutelephone;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label label1;
    }
}
