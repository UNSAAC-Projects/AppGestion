
namespace CapaPresentacion
{
    partial class FrmLogin
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.elipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dcPanel = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnLogo = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pbLogo = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.dcPicture = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblInicieSesion = new Bunifu.UI.WinForms.BunifuLabel();
            this.tbContraseña = new Bunifu.UI.WinForms.BunifuTextBox();
            this.tbUsuario = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnIniciarSesion = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnCerrar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pnShadow = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnShadow.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseForm
            // 
            this.elipseForm.ElipseRadius = 30;
            this.elipseForm.TargetControl = this;
            // 
            // dcPanel
            // 
            this.dcPanel.Fixed = true;
            this.dcPanel.Horizontal = true;
            this.dcPanel.TargetControl = this.pnLogo;
            this.dcPanel.Vertical = true;
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnLogo.BackgroundImage")));
            this.pnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLogo.BorderRadius = 30;
            this.pnLogo.Controls.Add(this.pbLogo);
            this.pnLogo.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.pnLogo.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.pnLogo.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.pnLogo.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pnLogo.Location = new System.Drawing.Point(10, 11);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Quality = 10;
            this.pnLogo.Size = new System.Drawing.Size(320, 231);
            this.pnLogo.TabIndex = 3;
            // 
            // pbLogo
            // 
            this.pbLogo.AllowFocused = false;
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.AutoSizeHeight = true;
            this.pbLogo.BorderRadius = 101;
            this.pbLogo.Image = global::CapaPresentacion.Properties.Resources.Logo_unsaac1;
            this.pbLogo.IsCircle = true;
            this.pbLogo.Location = new System.Drawing.Point(58, 13);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(202, 202);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // dcPicture
            // 
            this.dcPicture.Fixed = true;
            this.dcPicture.Horizontal = true;
            this.dcPicture.TargetControl = this.pbLogo;
            this.dcPicture.Vertical = true;
            // 
            // lblInicieSesion
            // 
            this.lblInicieSesion.AllowParentOverrides = false;
            this.lblInicieSesion.AutoEllipsis = false;
            this.lblInicieSesion.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInicieSesion.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblInicieSesion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblInicieSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.lblInicieSesion.Location = new System.Drawing.Point(85, 249);
            this.lblInicieSesion.Name = "lblInicieSesion";
            this.lblInicieSesion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblInicieSesion.Size = new System.Drawing.Size(151, 32);
            this.lblInicieSesion.TabIndex = 4;
            this.lblInicieSesion.Text = "Iniciar sesión";
            this.lblInicieSesion.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblInicieSesion.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // tbContraseña
            // 
            this.tbContraseña.AcceptsReturn = false;
            this.tbContraseña.AcceptsTab = false;
            this.tbContraseña.AnimationSpeed = 200;
            this.tbContraseña.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbContraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbContraseña.AutoSizeHeight = true;
            this.tbContraseña.BackColor = System.Drawing.Color.Transparent;
            this.tbContraseña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbContraseña.BackgroundImage")));
            this.tbContraseña.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbContraseña.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbContraseña.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbContraseña.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbContraseña.BorderRadius = 20;
            this.tbContraseña.BorderThickness = 1;
            this.tbContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContraseña.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContraseña.DefaultText = "";
            this.tbContraseña.FillColor = System.Drawing.Color.White;
            this.tbContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.tbContraseña.HideSelection = true;
            this.tbContraseña.IconLeft = global::CapaPresentacion.Properties.Resources.lock_alt_regular_24;
            this.tbContraseña.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContraseña.IconPadding = 10;
            this.tbContraseña.IconRight = null;
            this.tbContraseña.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContraseña.Lines = new string[0];
            this.tbContraseña.Location = new System.Drawing.Point(25, 364);
            this.tbContraseña.MaxLength = 16;
            this.tbContraseña.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbContraseña.Modified = false;
            this.tbContraseña.Multiline = false;
            this.tbContraseña.Name = "tbContraseña";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbContraseña.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbContraseña.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbContraseña.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbContraseña.OnIdleState = stateProperties12;
            this.tbContraseña.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbContraseña.PasswordChar = '\0';
            this.tbContraseña.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.tbContraseña.PlaceholderText = "Contraseña";
            this.tbContraseña.ReadOnly = false;
            this.tbContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbContraseña.SelectedText = "";
            this.tbContraseña.SelectionLength = 0;
            this.tbContraseña.SelectionStart = 0;
            this.tbContraseña.ShortcutsEnabled = true;
            this.tbContraseña.Size = new System.Drawing.Size(269, 40);
            this.tbContraseña.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbContraseña.TabIndex = 2;
            this.tbContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbContraseña.TextMarginBottom = 0;
            this.tbContraseña.TextMarginLeft = 3;
            this.tbContraseña.TextMarginTop = 1;
            this.tbContraseña.TextPlaceholder = "Contraseña";
            this.tbContraseña.UseSystemPasswordChar = false;
            this.tbContraseña.WordWrap = true;
            this.tbContraseña.TextChange += new System.EventHandler(this.tbContraseña_TextChange);
            // 
            // tbUsuario
            // 
            this.tbUsuario.AcceptsReturn = false;
            this.tbUsuario.AcceptsTab = false;
            this.tbUsuario.AnimationSpeed = 200;
            this.tbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbUsuario.AutoSizeHeight = true;
            this.tbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.tbUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbUsuario.BackgroundImage")));
            this.tbUsuario.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbUsuario.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbUsuario.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbUsuario.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbUsuario.BorderRadius = 20;
            this.tbUsuario.BorderThickness = 1;
            this.tbUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsuario.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.DefaultText = "";
            this.tbUsuario.FillColor = System.Drawing.Color.White;
            this.tbUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.tbUsuario.HideSelection = true;
            this.tbUsuario.IconLeft = global::CapaPresentacion.Properties.Resources.user_regular_24;
            this.tbUsuario.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsuario.IconPadding = 10;
            this.tbUsuario.IconRight = null;
            this.tbUsuario.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsuario.Lines = new string[0];
            this.tbUsuario.Location = new System.Drawing.Point(25, 302);
            this.tbUsuario.MaxLength = 10;
            this.tbUsuario.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbUsuario.Modified = false;
            this.tbUsuario.Multiline = false;
            this.tbUsuario.Name = "tbUsuario";
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbUsuario.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbUsuario.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbUsuario.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbUsuario.OnIdleState = stateProperties16;
            this.tbUsuario.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbUsuario.PasswordChar = '\0';
            this.tbUsuario.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(89)))), ((int)(((byte)(94)))));
            this.tbUsuario.PlaceholderText = "Usuario";
            this.tbUsuario.ReadOnly = false;
            this.tbUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUsuario.SelectedText = "";
            this.tbUsuario.SelectionLength = 0;
            this.tbUsuario.SelectionStart = 0;
            this.tbUsuario.ShortcutsEnabled = true;
            this.tbUsuario.Size = new System.Drawing.Size(269, 40);
            this.tbUsuario.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUsuario.TextMarginBottom = 0;
            this.tbUsuario.TextMarginLeft = 3;
            this.tbUsuario.TextMarginTop = 1;
            this.tbUsuario.TextPlaceholder = "Usuario";
            this.tbUsuario.UseSystemPasswordChar = false;
            this.tbUsuario.WordWrap = true;
            this.tbUsuario.TextChange += new System.EventHandler(this.tbUsuario_TextChange);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AllowAnimations = true;
            this.btnIniciarSesion.AllowMouseEffects = true;
            this.btnIniciarSesion.AllowToggling = false;
            this.btnIniciarSesion.AnimationSpeed = 200;
            this.btnIniciarSesion.AutoGenerateColors = false;
            this.btnIniciarSesion.AutoRoundBorders = false;
            this.btnIniciarSesion.AutoSizeLeftIcon = true;
            this.btnIniciarSesion.AutoSizeRightIcon = true;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSesion.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.btnIniciarSesion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciarSesion.BackgroundImage")));
            this.btnIniciarSesion.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIniciarSesion.ButtonText = "Iniciar Sesión";
            this.btnIniciarSesion.ButtonTextMarginLeft = 0;
            this.btnIniciarSesion.ColorContrastOnClick = 45;
            this.btnIniciarSesion.ColorContrastOnHover = 45;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = false;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = false;
            borderEdges4.TopRight = true;
            this.btnIniciarSesion.CustomizableEdges = borderEdges4;
            this.btnIniciarSesion.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIniciarSesion.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.btnIniciarSesion.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.btnIniciarSesion.DisabledForecolor = System.Drawing.Color.White;
            this.btnIniciarSesion.Enabled = false;
            this.btnIniciarSesion.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSesion.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnIniciarSesion.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnIniciarSesion.IconMarginLeft = 11;
            this.btnIniciarSesion.IconPadding = 10;
            this.btnIniciarSesion.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciarSesion.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnIniciarSesion.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnIniciarSesion.IconSize = 25;
            this.btnIniciarSesion.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.btnIniciarSesion.IdleBorderRadius = 20;
            this.btnIniciarSesion.IdleBorderThickness = 1;
            this.btnIniciarSesion.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.btnIniciarSesion.IdleIconLeftImage = null;
            this.btnIniciarSesion.IdleIconRightImage = null;
            this.btnIniciarSesion.IndicateFocus = false;
            this.btnIniciarSesion.Location = new System.Drawing.Point(127, 436);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.btnIniciarSesion.OnDisabledState.BorderRadius = 20;
            this.btnIniciarSesion.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIniciarSesion.OnDisabledState.BorderThickness = 1;
            this.btnIniciarSesion.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(193)))), ((int)(((byte)(197)))));
            this.btnIniciarSesion.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.OnDisabledState.IconLeftImage = null;
            this.btnIniciarSesion.OnDisabledState.IconRightImage = null;
            this.btnIniciarSesion.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnIniciarSesion.onHoverState.BorderRadius = 20;
            this.btnIniciarSesion.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIniciarSesion.onHoverState.BorderThickness = 1;
            this.btnIniciarSesion.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnIniciarSesion.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.onHoverState.IconLeftImage = null;
            this.btnIniciarSesion.onHoverState.IconRightImage = null;
            this.btnIniciarSesion.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.btnIniciarSesion.OnIdleState.BorderRadius = 20;
            this.btnIniciarSesion.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIniciarSesion.OnIdleState.BorderThickness = 1;
            this.btnIniciarSesion.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(12)))), ((int)(((byte)(46)))));
            this.btnIniciarSesion.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.OnIdleState.IconLeftImage = null;
            this.btnIniciarSesion.OnIdleState.IconRightImage = null;
            this.btnIniciarSesion.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnIniciarSesion.OnPressedState.BorderRadius = 20;
            this.btnIniciarSesion.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnIniciarSesion.OnPressedState.BorderThickness = 1;
            this.btnIniciarSesion.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnIniciarSesion.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.OnPressedState.IconLeftImage = null;
            this.btnIniciarSesion.OnPressedState.IconRightImage = null;
            this.btnIniciarSesion.Size = new System.Drawing.Size(167, 39);
            this.btnIniciarSesion.TabIndex = 3;
            this.btnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIniciarSesion.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIniciarSesion.TextMarginLeft = 0;
            this.btnIniciarSesion.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnIniciarSesion.UseDefaultRadiusAndThickness = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.AllowAnimations = true;
            this.btnCerrar.AllowMouseEffects = true;
            this.btnCerrar.AllowToggling = false;
            this.btnCerrar.AnimationSpeed = 200;
            this.btnCerrar.AutoGenerateColors = false;
            this.btnCerrar.AutoRoundBorders = false;
            this.btnCerrar.AutoSizeLeftIcon = true;
            this.btnCerrar.AutoSizeRightIcon = true;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCerrar.ButtonText = "Cerrar";
            this.btnCerrar.ButtonTextMarginLeft = 0;
            this.btnCerrar.ColorContrastOnClick = 45;
            this.btnCerrar.ColorContrastOnHover = 45;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = false;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = false;
            this.btnCerrar.CustomizableEdges = borderEdges3;
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCerrar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCerrar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCerrar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCerrar.IconMarginLeft = 11;
            this.btnCerrar.IconPadding = 10;
            this.btnCerrar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCerrar.IconSize = 25;
            this.btnCerrar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnCerrar.IdleBorderRadius = 20;
            this.btnCerrar.IdleBorderThickness = 1;
            this.btnCerrar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnCerrar.IdleIconLeftImage = null;
            this.btnCerrar.IdleIconRightImage = null;
            this.btnCerrar.IndicateFocus = false;
            this.btnCerrar.Location = new System.Drawing.Point(25, 436);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCerrar.OnDisabledState.BorderRadius = 20;
            this.btnCerrar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCerrar.OnDisabledState.BorderThickness = 1;
            this.btnCerrar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCerrar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCerrar.OnDisabledState.IconLeftImage = null;
            this.btnCerrar.OnDisabledState.IconRightImage = null;
            this.btnCerrar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnCerrar.onHoverState.BorderRadius = 20;
            this.btnCerrar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCerrar.onHoverState.BorderThickness = 1;
            this.btnCerrar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.btnCerrar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.onHoverState.IconLeftImage = null;
            this.btnCerrar.onHoverState.IconRightImage = null;
            this.btnCerrar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btnCerrar.OnIdleState.BorderRadius = 20;
            this.btnCerrar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCerrar.OnIdleState.BorderThickness = 1;
            this.btnCerrar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnCerrar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnIdleState.IconLeftImage = null;
            this.btnCerrar.OnIdleState.IconRightImage = null;
            this.btnCerrar.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.btnCerrar.OnPressedState.BorderRadius = 20;
            this.btnCerrar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnCerrar.OnPressedState.BorderThickness = 1;
            this.btnCerrar.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.btnCerrar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.OnPressedState.IconLeftImage = null;
            this.btnCerrar.OnPressedState.IconRightImage = null;
            this.btnCerrar.Size = new System.Drawing.Size(96, 39);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCerrar.TextMarginLeft = 0;
            this.btnCerrar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCerrar.UseDefaultRadiusAndThickness = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnShadow
            // 
            this.pnShadow.BackColor = System.Drawing.Color.Transparent;
            this.pnShadow.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnShadow.BorderRadius = 20;
            this.pnShadow.BorderThickness = 1;
            this.pnShadow.Controls.Add(this.pnLogo);
            this.pnShadow.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnShadow.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.pnShadow.Location = new System.Drawing.Point(-11, -12);
            this.pnShadow.Name = "pnShadow";
            this.pnShadow.PanelColor = System.Drawing.Color.White;
            this.pnShadow.PanelColor2 = System.Drawing.Color.White;
            this.pnShadow.ShadowColor = System.Drawing.Color.DimGray;
            this.pnShadow.ShadowDept = 2;
            this.pnShadow.ShadowDepth = 10;
            this.pnShadow.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.pnShadow.ShadowTopLeftVisible = false;
            this.pnShadow.Size = new System.Drawing.Size(340, 255);
            this.pnShadow.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.pnShadow.TabIndex = 6;
            this.pnShadow.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.bunifuShadowPanel1_ControlAdded);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 502);
            this.Controls.Add(this.pnShadow);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblInicieSesion);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.btnIniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnShadow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnIniciarSesion;
        private Bunifu.UI.WinForms.BunifuTextBox tbUsuario;
        private Bunifu.UI.WinForms.BunifuTextBox tbContraseña;
        private Bunifu.UI.WinForms.BunifuGradientPanel pnLogo;
        private Bunifu.Framework.UI.BunifuElipse elipseForm;
        private Bunifu.UI.WinForms.BunifuPictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuDragControl dcPanel;
        private Bunifu.Framework.UI.BunifuDragControl dcPicture;
        private Bunifu.UI.WinForms.BunifuLabel lblInicieSesion;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnCerrar;
        private Bunifu.UI.WinForms.BunifuShadowPanel pnShadow;
    }
}