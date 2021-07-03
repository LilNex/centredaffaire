
namespace Centre_D_affaire.GestionSalleDeJeux
{
    partial class FrmConnection
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.twtNumero = new System.Windows.Forms.TextBox();
            this.textPssword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.btnForgetPassword = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.errorProviderConnection = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(25, 75);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(96, 25);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero";
            // 
            // twtNumero
            // 
            this.twtNumero.Location = new System.Drawing.Point(195, 62);
            this.twtNumero.Multiline = true;
            this.twtNumero.Name = "twtNumero";
            this.twtNumero.Size = new System.Drawing.Size(173, 38);
            this.twtNumero.TabIndex = 2;
            this.twtNumero.TextChanged += new System.EventHandler(this.twtNumero_TextChanged);
            // 
            // textPssword
            // 
            this.textPssword.Location = new System.Drawing.Point(195, 110);
            this.textPssword.Multiline = true;
            this.textPssword.Name = "textPssword";
            this.textPssword.Size = new System.Drawing.Size(173, 38);
            this.textPssword.TabIndex = 4;
            this.textPssword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(25, 123);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(151, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "PASSWORD";
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.Location = new System.Drawing.Point(116, 19);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(155, 31);
            this.lblConnection.TabIndex = 5;
            this.lblConnection.Text = "Connection";
            // 
            // btnForgetPassword
            // 
            this.btnForgetPassword.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnForgetPassword.FlatAppearance.BorderSize = 0;
            this.btnForgetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForgetPassword.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgetPassword.Location = new System.Drawing.Point(130, 206);
            this.btnForgetPassword.Name = "btnForgetPassword";
            this.btnForgetPassword.Size = new System.Drawing.Size(141, 26);
            this.btnForgetPassword.TabIndex = 6;
            this.btnForgetPassword.Text = "Forget Password";
            this.btnForgetPassword.UseVisualStyleBackColor = false;
            this.btnForgetPassword.Click += new System.EventHandler(this.btnForgetPassword_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(130, 165);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(141, 35);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProviderConnection
            // 
            this.errorProviderConnection.ContainerControl = this;
            // 
            // FrmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(408, 244);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnForgetPassword);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.textPssword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.twtNumero);
            this.Controls.Add(this.lblNumero);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmConnection";
            this.Text = "FrmConnection";
            this.Load += new System.EventHandler(this.FrmConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox twtNumero;
        private System.Windows.Forms.TextBox textPssword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Button btnForgetPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ErrorProvider errorProviderConnection;
    }
}