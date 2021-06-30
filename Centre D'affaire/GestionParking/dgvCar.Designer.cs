
namespace Centre_D_affaire.GestionParking
{
    partial class dgvCar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dgvCar));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDataGridView2 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParkingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuButton5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.bunifuDataGridView2;
            // 
            // bunifuDataGridView2
            // 
            this.bunifuDataGridView2.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
            this.bunifuDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.bunifuDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView2.ColumnHeadersHeight = 40;
            this.bunifuDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.CarType,
            this.ParkingTime});
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView2.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.Name = null;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView2.Enabled = false;
            this.bunifuDataGridView2.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView2.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView2.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView2.Location = new System.Drawing.Point(0, 0);
            this.bunifuDataGridView2.Name = "bunifuDataGridView2";
            this.bunifuDataGridView2.RowHeadersVisible = false;
            this.bunifuDataGridView2.RowTemplate.Height = 40;
            this.bunifuDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView2.Size = new System.Drawing.Size(620, 207);
            this.bunifuDataGridView2.TabIndex = 10;
            this.bunifuDataGridView2.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Car Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // CarType
            // 
            this.CarType.HeaderText = "Car Type";
            this.CarType.Name = "CarType";
            // 
            // ParkingTime
            // 
            this.ParkingTime.HeaderText = "Parking Time";
            this.ParkingTime.Name = "ParkingTime";
            // 
            // bunifuButton5
            // 
            this.bunifuButton5.AllowAnimations = true;
            this.bunifuButton5.AllowMouseEffects = true;
            this.bunifuButton5.AllowToggling = false;
            this.bunifuButton5.AnimationSpeed = 200;
            this.bunifuButton5.AutoGenerateColors = false;
            this.bunifuButton5.AutoRoundBorders = false;
            this.bunifuButton5.AutoSizeLeftIcon = true;
            this.bunifuButton5.AutoSizeRightIcon = true;
            this.bunifuButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton5.BackColor1 = System.Drawing.Color.SteelBlue;
            this.bunifuButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton5.BackgroundImage")));
            this.bunifuButton5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.ButtonText = "Exit";
            this.bunifuButton5.ButtonTextMarginLeft = 0;
            this.bunifuButton5.ColorContrastOnClick = 45;
            this.bunifuButton5.ColorContrastOnHover = 45;
            this.bunifuButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton5.CustomizableEdges = borderEdges1;
            this.bunifuButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton5.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton5.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton5.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton5.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton5.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton5.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton5.IconMarginLeft = 11;
            this.bunifuButton5.IconPadding = 10;
            this.bunifuButton5.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton5.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton5.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton5.IconSize = 25;
            this.bunifuButton5.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(77)))), ((int)(((byte)(237)))));
            this.bunifuButton5.IdleBorderRadius = 30;
            this.bunifuButton5.IdleBorderThickness = 1;
            this.bunifuButton5.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.bunifuButton5.IdleIconLeftImage = global::Centre_D_affaire.Properties.Resources.exit_32px;
            this.bunifuButton5.IdleIconRightImage = null;
            this.bunifuButton5.IndicateFocus = false;
            this.bunifuButton5.Location = new System.Drawing.Point(2, 209);
            this.bunifuButton5.Name = "bunifuButton5";
            this.bunifuButton5.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton5.OnDisabledState.BorderRadius = 30;
            this.bunifuButton5.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.OnDisabledState.BorderThickness = 1;
            this.bunifuButton5.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton5.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton5.OnDisabledState.IconLeftImage = null;
            this.bunifuButton5.OnDisabledState.IconRightImage = null;
            this.bunifuButton5.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(77)))), ((int)(((byte)(237)))));
            this.bunifuButton5.onHoverState.BorderRadius = 30;
            this.bunifuButton5.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.onHoverState.BorderThickness = 1;
            this.bunifuButton5.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(77)))), ((int)(((byte)(237)))));
            this.bunifuButton5.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuButton5.onHoverState.IconLeftImage = null;
            this.bunifuButton5.onHoverState.IconRightImage = null;
            this.bunifuButton5.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(77)))), ((int)(((byte)(237)))));
            this.bunifuButton5.OnIdleState.BorderRadius = 30;
            this.bunifuButton5.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.OnIdleState.BorderThickness = 1;
            this.bunifuButton5.OnIdleState.FillColor = System.Drawing.Color.SteelBlue;
            this.bunifuButton5.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.OnIdleState.IconLeftImage = global::Centre_D_affaire.Properties.Resources.exit_32px;
            this.bunifuButton5.OnIdleState.IconRightImage = null;
            this.bunifuButton5.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(206)))));
            this.bunifuButton5.OnPressedState.BorderRadius = 30;
            this.bunifuButton5.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton5.OnPressedState.BorderThickness = 1;
            this.bunifuButton5.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(206)))));
            this.bunifuButton5.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton5.OnPressedState.IconLeftImage = null;
            this.bunifuButton5.OnPressedState.IconRightImage = null;
            this.bunifuButton5.Size = new System.Drawing.Size(97, 36);
            this.bunifuButton5.TabIndex = 9;
            this.bunifuButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton5.TextMarginLeft = 0;
            this.bunifuButton5.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton5.UseDefaultRadiusAndThickness = true;
            this.bunifuButton5.Click += new System.EventHandler(this.bunifuButton5_Click);
            // 
            // dgvCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(620, 247);
            this.Controls.Add(this.bunifuDataGridView2);
            this.Controls.Add(this.bunifuButton5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dgvCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dgvCar";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParkingTime;
        public Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView2;
    }
}