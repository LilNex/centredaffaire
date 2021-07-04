
namespace Centre_D_affaire.GestionSalleDeSport
{
    partial class uccPresence
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uccPresence));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Cbgenre = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.DPdate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.TXTnumero = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblNOms = new System.Windows.Forms.Label();
            this.Attendance = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtstatu = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridMembre = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.IDMembre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Cbnom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridMembre)).BeginInit();
            this.SuspendLayout();
            // 
            // Cbgenre
            // 
            this.Cbgenre.FormattingEnabled = true;
            this.Cbgenre.Items.AddRange(new object[] {
            "Present",
            "Abscent"});
            this.Cbgenre.Location = new System.Drawing.Point(51, 264);
            this.Cbgenre.Name = "Cbgenre";
            this.Cbgenre.Size = new System.Drawing.Size(209, 28);
            this.Cbgenre.TabIndex = 227;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(607, 67);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 27);
            this.lblDate.TabIndex = 226;
            this.lblDate.Text = "Date ";
            // 
            // DPdate
            // 
            this.DPdate.BackColor = System.Drawing.Color.Transparent;
            this.DPdate.BorderRadius = 0;
            this.DPdate.CalendarForeColor = System.Drawing.Color.MediumVioletRed;
            this.DPdate.Color = System.Drawing.Color.Silver;
            this.DPdate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.DPdate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.DPdate.DisabledColor = System.Drawing.Color.Gray;
            this.DPdate.DisplayWeekNumbers = false;
            this.DPdate.DPHeight = 0;
            this.DPdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DPdate.FillDatePicker = false;
            this.DPdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DPdate.ForeColor = System.Drawing.Color.Violet;
            this.DPdate.Icon = ((System.Drawing.Image)(resources.GetObject("DPdate.Icon")));
            this.DPdate.IconColor = System.Drawing.Color.Gray;
            this.DPdate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.DPdate.LeftTextMargin = 5;
            this.DPdate.Location = new System.Drawing.Point(602, 97);
            this.DPdate.MinimumSize = new System.Drawing.Size(4, 32);
            this.DPdate.Name = "DPdate";
            this.DPdate.Size = new System.Drawing.Size(224, 32);
            this.DPdate.TabIndex = 225;
            this.DPdate.Value = new System.DateTime(2021, 5, 14, 0, 0, 0, 0);
            // 
            // TXTnumero
            // 
            this.TXTnumero.AcceptsReturn = false;
            this.TXTnumero.AcceptsTab = false;
            this.TXTnumero.AnimationSpeed = 200;
            this.TXTnumero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TXTnumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TXTnumero.BackColor = System.Drawing.Color.White;
            this.TXTnumero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TXTnumero.BackgroundImage")));
            this.TXTnumero.BorderColorActive = System.Drawing.Color.DarkMagenta;
            this.TXTnumero.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TXTnumero.BorderColorHover = System.Drawing.Color.Magenta;
            this.TXTnumero.BorderColorIdle = System.Drawing.Color.Plum;
            this.TXTnumero.BorderRadius = 1;
            this.TXTnumero.BorderThickness = 4;
            this.TXTnumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TXTnumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTnumero.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TXTnumero.DefaultText = "";
            this.TXTnumero.FillColor = System.Drawing.Color.White;
            this.TXTnumero.HideSelection = true;
            this.TXTnumero.IconLeft = null;
            this.TXTnumero.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTnumero.IconPadding = 10;
            this.TXTnumero.IconRight = null;
            this.TXTnumero.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTnumero.Lines = new string[0];
            this.TXTnumero.Location = new System.Drawing.Point(51, 97);
            this.TXTnumero.MaxLength = 32767;
            this.TXTnumero.MinimumSize = new System.Drawing.Size(1, 1);
            this.TXTnumero.Modified = false;
            this.TXTnumero.Multiline = false;
            this.TXTnumero.Name = "TXTnumero";
            stateProperties1.BorderColor = System.Drawing.Color.DarkMagenta;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TXTnumero.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TXTnumero.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Magenta;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TXTnumero.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Plum;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TXTnumero.OnIdleState = stateProperties4;
            this.TXTnumero.Padding = new System.Windows.Forms.Padding(3);
            this.TXTnumero.PasswordChar = '\0';
            this.TXTnumero.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TXTnumero.PlaceholderText = "";
            this.TXTnumero.ReadOnly = false;
            this.TXTnumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TXTnumero.SelectedText = "";
            this.TXTnumero.SelectionLength = 0;
            this.TXTnumero.SelectionStart = 0;
            this.TXTnumero.ShortcutsEnabled = true;
            this.TXTnumero.Size = new System.Drawing.Size(189, 35);
            this.TXTnumero.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.TXTnumero.TabIndex = 223;
            this.TXTnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TXTnumero.TextMarginBottom = 0;
            this.TXTnumero.TextMarginLeft = -9;
            this.TXTnumero.TextMarginTop = 0;
            this.TXTnumero.TextPlaceholder = "";
            this.TXTnumero.UseSystemPasswordChar = false;
            this.TXTnumero.WordWrap = true;
            // 
            // lblNOms
            // 
            this.lblNOms.AutoSize = true;
            this.lblNOms.BackColor = System.Drawing.Color.Transparent;
            this.lblNOms.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNOms.Location = new System.Drawing.Point(46, 148);
            this.lblNOms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNOms.Name = "lblNOms";
            this.lblNOms.Size = new System.Drawing.Size(142, 27);
            this.lblNOms.TabIndex = 222;
            this.lblNOms.Text = "Nom Complet";
            // 
            // Attendance
            // 
            this.Attendance.AutoSize = true;
            this.Attendance.BackColor = System.Drawing.Color.Transparent;
            this.Attendance.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Attendance.Location = new System.Drawing.Point(46, 228);
            this.Attendance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(72, 27);
            this.Attendance.TabIndex = 221;
            this.Attendance.Text = "Genre";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.Transparent;
            this.lblnumero.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblnumero.Location = new System.Drawing.Point(46, 67);
            this.lblnumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(88, 27);
            this.lblnumero.TabIndex = 220;
            this.lblnumero.Text = "Numéro";
            // 
            // txtstatu
            // 
            this.txtstatu.AcceptsReturn = false;
            this.txtstatu.AcceptsTab = false;
            this.txtstatu.AnimationSpeed = 200;
            this.txtstatu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtstatu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtstatu.BackColor = System.Drawing.Color.White;
            this.txtstatu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtstatu.BackgroundImage")));
            this.txtstatu.BorderColorActive = System.Drawing.Color.DarkMagenta;
            this.txtstatu.BorderColorDisabled = System.Drawing.Color.Azure;
            this.txtstatu.BorderColorHover = System.Drawing.Color.Magenta;
            this.txtstatu.BorderColorIdle = System.Drawing.Color.Plum;
            this.txtstatu.BorderRadius = 1;
            this.txtstatu.BorderThickness = 4;
            this.txtstatu.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtstatu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstatu.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtstatu.DefaultText = "";
            this.txtstatu.FillColor = System.Drawing.Color.White;
            this.txtstatu.HideSelection = true;
            this.txtstatu.IconLeft = null;
            this.txtstatu.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstatu.IconPadding = 10;
            this.txtstatu.IconRight = null;
            this.txtstatu.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstatu.Lines = new string[0];
            this.txtstatu.Location = new System.Drawing.Point(612, 205);
            this.txtstatu.MaxLength = 32767;
            this.txtstatu.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtstatu.Modified = false;
            this.txtstatu.Multiline = false;
            this.txtstatu.Name = "txtstatu";
            stateProperties5.BorderColor = System.Drawing.Color.DarkMagenta;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtstatu.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Azure;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtstatu.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.Magenta;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtstatu.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Plum;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtstatu.OnIdleState = stateProperties8;
            this.txtstatu.Padding = new System.Windows.Forms.Padding(3);
            this.txtstatu.PasswordChar = '\0';
            this.txtstatu.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtstatu.PlaceholderText = "Tapez ici ";
            this.txtstatu.ReadOnly = false;
            this.txtstatu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtstatu.SelectedText = "";
            this.txtstatu.SelectionLength = 0;
            this.txtstatu.SelectionStart = 0;
            this.txtstatu.ShortcutsEnabled = true;
            this.txtstatu.Size = new System.Drawing.Size(293, 87);
            this.txtstatu.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.txtstatu.TabIndex = 229;
            this.txtstatu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtstatu.TextMarginBottom = 0;
            this.txtstatu.TextMarginLeft = -9;
            this.txtstatu.TextMarginTop = 0;
            this.txtstatu.TextPlaceholder = "Tapez ici ";
            this.txtstatu.UseSystemPasswordChar = false;
            this.txtstatu.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(607, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 228;
            this.label1.Text = "Statut";
            // 
            // GridMembre
            // 
            this.GridMembre.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.GridMembre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridMembre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridMembre.BackgroundColor = System.Drawing.Color.Moccasin;
            this.GridMembre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridMembre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridMembre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMembre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridMembre.ColumnHeadersHeight = 40;
            this.GridMembre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMembre,
            this.Nom,
            this.Date,
            this.Prese,
            this.Statut});
            this.GridMembre.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(191)))));
            this.GridMembre.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridMembre.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GridMembre.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            this.GridMembre.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.GridMembre.CurrentTheme.BackColor = System.Drawing.Color.Orange;
            this.GridMembre.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(173)))));
            this.GridMembre.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Orange;
            this.GridMembre.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.GridMembre.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridMembre.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.GridMembre.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.GridMembre.CurrentTheme.Name = null;
            this.GridMembre.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            this.GridMembre.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.GridMembre.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.GridMembre.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            this.GridMembre.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMembre.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridMembre.EnableHeadersVisualStyles = false;
            this.GridMembre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(226)))), ((int)(((byte)(173)))));
            this.GridMembre.HeaderBackColor = System.Drawing.Color.Orange;
            this.GridMembre.HeaderBgColor = System.Drawing.Color.Empty;
            this.GridMembre.HeaderForeColor = System.Drawing.Color.White;
            this.GridMembre.Location = new System.Drawing.Point(19, 429);
            this.GridMembre.Name = "GridMembre";
            this.GridMembre.RowHeadersVisible = false;
            this.GridMembre.RowHeadersWidth = 62;
            this.GridMembre.RowTemplate.Height = 40;
            this.GridMembre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMembre.Size = new System.Drawing.Size(1044, 293);
            this.GridMembre.TabIndex = 230;
            this.GridMembre.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Orange;
            // 
            // IDMembre
            // 
            this.IDMembre.HeaderText = "IDMembre";
            this.IDMembre.MinimumWidth = 8;
            this.IDMembre.Name = "IDMembre";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            // 
            // Prese
            // 
            this.Prese.HeaderText = "Présence ";
            this.Prese.MinimumWidth = 8;
            this.Prese.Name = "Prese";
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut";
            this.Statut.MinimumWidth = 8;
            this.Statut.Name = "Statut";
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = true;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DarkOrange;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Ajouter";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleBorderRadius = 37;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DarkOrange;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(51, 335);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DarkOrange;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(156, 39);
            this.bunifuButton1.TabIndex = 231;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // Cbnom
            // 
            this.Cbnom.FormattingEnabled = true;
            this.Cbnom.Items.AddRange(new object[] {
            "Present",
            "Abscent"});
            this.Cbnom.Location = new System.Drawing.Point(51, 178);
            this.Cbnom.Name = "Cbnom";
            this.Cbnom.Size = new System.Drawing.Size(209, 28);
            this.Cbnom.TabIndex = 232;
            this.Cbnom.SelectedIndexChanged += new System.EventHandler(this.Cbnom_SelectedIndexChanged);
            this.Cbnom.TextChanged += new System.EventHandler(this.Cbnom_TextChanged);
            this.Cbnom.Click += new System.EventHandler(this.Cbnom_Click);
            // 
            // uccPresence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.Cbnom);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.GridMembre);
            this.Controls.Add(this.txtstatu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbgenre);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.DPdate);
            this.Controls.Add(this.TXTnumero);
            this.Controls.Add(this.lblNOms);
            this.Controls.Add(this.Attendance);
            this.Controls.Add(this.lblnumero);
            this.Name = "uccPresence";
            this.Size = new System.Drawing.Size(1100, 755);
            this.Load += new System.EventHandler(this.uccPresence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMembre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbgenre;
        private System.Windows.Forms.Label lblDate;
        private Bunifu.UI.WinForms.BunifuDatePicker DPdate;
        private Bunifu.UI.WinForms.BunifuTextBox TXTnumero;
        private System.Windows.Forms.Label lblNOms;
        private System.Windows.Forms.Label Attendance;
        private System.Windows.Forms.Label lblnumero;
        private Bunifu.UI.WinForms.BunifuTextBox txtstatu;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDataGridView GridMembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMembre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prese;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statut;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.ComboBox Cbnom;
    }
}
