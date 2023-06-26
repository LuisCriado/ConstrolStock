namespace StockManagment
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuarioTb = new Bunifu.UI.WinForms.BunifuTextBox();
            this.PasswordTb = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LoginBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 564);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "WertyLand Produciones";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(24, 191);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(156, 156);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 2;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // UsuarioTb
            // 
            this.UsuarioTb.AcceptsReturn = false;
            this.UsuarioTb.AcceptsTab = false;
            this.UsuarioTb.AnimationSpeed = 200;
            this.UsuarioTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UsuarioTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UsuarioTb.AutoSizeHeight = true;
            this.UsuarioTb.BackColor = System.Drawing.Color.White;
            this.UsuarioTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UsuarioTb.BackgroundImage")));
            this.UsuarioTb.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.UsuarioTb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UsuarioTb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.UsuarioTb.BorderColorIdle = System.Drawing.Color.Silver;
            this.UsuarioTb.BorderRadius = 1;
            this.UsuarioTb.BorderThickness = 1;
            this.UsuarioTb.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.UsuarioTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UsuarioTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsuarioTb.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.UsuarioTb.DefaultText = "";
            this.UsuarioTb.FillColor = System.Drawing.Color.White;
            this.UsuarioTb.HideSelection = true;
            this.UsuarioTb.IconLeft = null;
            this.UsuarioTb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.UsuarioTb.IconPadding = 10;
            this.UsuarioTb.IconRight = null;
            this.UsuarioTb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.UsuarioTb.Lines = new string[0];
            this.UsuarioTb.Location = new System.Drawing.Point(359, 191);
            this.UsuarioTb.MaxLength = 32767;
            this.UsuarioTb.MinimumSize = new System.Drawing.Size(1, 1);
            this.UsuarioTb.Modified = false;
            this.UsuarioTb.Multiline = false;
            this.UsuarioTb.Name = "UsuarioTb";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UsuarioTb.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.UsuarioTb.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UsuarioTb.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UsuarioTb.OnIdleState = stateProperties4;
            this.UsuarioTb.Padding = new System.Windows.Forms.Padding(3);
            this.UsuarioTb.PasswordChar = '\0';
            this.UsuarioTb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.UsuarioTb.PlaceholderText = "UserName";
            this.UsuarioTb.ReadOnly = false;
            this.UsuarioTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsuarioTb.SelectedText = "";
            this.UsuarioTb.SelectionLength = 0;
            this.UsuarioTb.SelectionStart = 0;
            this.UsuarioTb.ShortcutsEnabled = true;
            this.UsuarioTb.Size = new System.Drawing.Size(260, 39);
            this.UsuarioTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.UsuarioTb.TabIndex = 3;
            this.UsuarioTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UsuarioTb.TextMarginBottom = 0;
            this.UsuarioTb.TextMarginLeft = 3;
            this.UsuarioTb.TextMarginTop = 1;
            this.UsuarioTb.TextPlaceholder = "UserName";
            this.UsuarioTb.UseSystemPasswordChar = false;
            this.UsuarioTb.WordWrap = true;
            // 
            // PasswordTb
            // 
            this.PasswordTb.AcceptsReturn = false;
            this.PasswordTb.AcceptsTab = false;
            this.PasswordTb.AnimationSpeed = 200;
            this.PasswordTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordTb.AutoSizeHeight = true;
            this.PasswordTb.BackColor = System.Drawing.Color.White;
            this.PasswordTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordTb.BackgroundImage")));
            this.PasswordTb.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.PasswordTb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PasswordTb.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.PasswordTb.BorderColorIdle = System.Drawing.Color.Silver;
            this.PasswordTb.BorderRadius = 1;
            this.PasswordTb.BorderThickness = 1;
            this.PasswordTb.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.PasswordTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PasswordTb.DefaultText = "";
            this.PasswordTb.FillColor = System.Drawing.Color.White;
            this.PasswordTb.HideSelection = true;
            this.PasswordTb.IconLeft = null;
            this.PasswordTb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.IconPadding = 10;
            this.PasswordTb.IconRight = null;
            this.PasswordTb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.Lines = new string[0];
            this.PasswordTb.Location = new System.Drawing.Point(359, 319);
            this.PasswordTb.MaxLength = 32767;
            this.PasswordTb.MinimumSize = new System.Drawing.Size(1, 1);
            this.PasswordTb.Modified = false;
            this.PasswordTb.Multiline = false;
            this.PasswordTb.Name = "PasswordTb";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTb.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PasswordTb.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTb.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTb.OnIdleState = stateProperties8;
            this.PasswordTb.Padding = new System.Windows.Forms.Padding(3);
            this.PasswordTb.PasswordChar = '\0';
            this.PasswordTb.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PasswordTb.PlaceholderText = "********";
            this.PasswordTb.ReadOnly = false;
            this.PasswordTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTb.SelectedText = "";
            this.PasswordTb.SelectionLength = 0;
            this.PasswordTb.SelectionStart = 0;
            this.PasswordTb.ShortcutsEnabled = true;
            this.PasswordTb.Size = new System.Drawing.Size(260, 39);
            this.PasswordTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.PasswordTb.TabIndex = 4;
            this.PasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordTb.TextMarginBottom = 0;
            this.PasswordTb.TextMarginLeft = 3;
            this.PasswordTb.TextMarginTop = 1;
            this.PasswordTb.TextPlaceholder = "********";
            this.PasswordTb.UseSystemPasswordChar = false;
            this.PasswordTb.WordWrap = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.AllowAnimations = true;
            this.LoginBtn.AllowMouseEffects = true;
            this.LoginBtn.AllowToggling = false;
            this.LoginBtn.AnimationSpeed = 200;
            this.LoginBtn.AutoGenerateColors = false;
            this.LoginBtn.AutoRoundBorders = false;
            this.LoginBtn.AutoSizeLeftIcon = true;
            this.LoginBtn.AutoSizeRightIcon = true;
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.LoginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBtn.BackgroundImage")));
            this.LoginBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginBtn.ButtonText = "Ingrese";
            this.LoginBtn.ButtonTextMarginLeft = 0;
            this.LoginBtn.ColorContrastOnClick = 45;
            this.LoginBtn.ColorContrastOnHover = 45;
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.LoginBtn.CustomizableEdges = borderEdges1;
            this.LoginBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoginBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.LoginBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.LoginBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.IconLeft = null;
            this.LoginBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LoginBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LoginBtn.IconMarginLeft = 11;
            this.LoginBtn.IconPadding = 10;
            this.LoginBtn.IconRight = null;
            this.LoginBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LoginBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LoginBtn.IconSize = 25;
            this.LoginBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.LoginBtn.IdleBorderRadius = 0;
            this.LoginBtn.IdleBorderThickness = 0;
            this.LoginBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.LoginBtn.IdleIconLeftImage = null;
            this.LoginBtn.IdleIconRightImage = null;
            this.LoginBtn.IndicateFocus = false;
            this.LoginBtn.Location = new System.Drawing.Point(403, 398);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoginBtn.OnDisabledState.BorderRadius = 1;
            this.LoginBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginBtn.OnDisabledState.BorderThickness = 1;
            this.LoginBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoginBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LoginBtn.OnDisabledState.IconLeftImage = null;
            this.LoginBtn.OnDisabledState.IconRightImage = null;
            this.LoginBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.LoginBtn.onHoverState.BorderRadius = 1;
            this.LoginBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginBtn.onHoverState.BorderThickness = 1;
            this.LoginBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.LoginBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.onHoverState.IconLeftImage = null;
            this.LoginBtn.onHoverState.IconRightImage = null;
            this.LoginBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.LoginBtn.OnIdleState.BorderRadius = 1;
            this.LoginBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginBtn.OnIdleState.BorderThickness = 1;
            this.LoginBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.LoginBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnIdleState.IconLeftImage = null;
            this.LoginBtn.OnIdleState.IconRightImage = null;
            this.LoginBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LoginBtn.OnPressedState.BorderRadius = 1;
            this.LoginBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginBtn.OnPressedState.BorderThickness = 1;
            this.LoginBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LoginBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.OnPressedState.IconLeftImage = null;
            this.LoginBtn.OnPressedState.IconRightImage = null;
            this.LoginBtn.Size = new System.Drawing.Size(150, 39);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBtn.TextMarginLeft = 0;
            this.LoginBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.LoginBtn.UseDefaultRadiusAndThickness = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sistema de Gestion Empresarial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Version:1.0.0";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 564);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.UsuarioTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextBox UsuarioTb;
        private Bunifu.UI.WinForms.BunifuTextBox PasswordTb;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LoginBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}