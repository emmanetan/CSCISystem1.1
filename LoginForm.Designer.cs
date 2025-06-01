namespace LoginSignup
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.ShowPassword = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.PasswordTextBox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.UsernameTextBox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.LoginButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.Panel = new Siticone.UI.WinForms.SiticonePanel();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.SignUpButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.NewEmailTextBox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.NewPasswordTextBox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.ShowPassword2 = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.panelSignUp = new System.Windows.Forms.Panel();
            this.label2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.NewUsernameTextBox = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.Panel.SuspendLayout();
            this.panelSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.siticonePictureBox1);
            this.panelLogin.Controls.Add(this.ShowPassword);
            this.panelLogin.Controls.Add(this.PasswordTextBox);
            this.panelLogin.Controls.Add(this.UsernameTextBox);
            this.panelLogin.Controls.Add(this.LoginButton);
            this.panelLogin.Location = new System.Drawing.Point(58, 67);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(371, 469);
            this.panelLogin.TabIndex = 2;
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.Location = new System.Drawing.Point(107, 24);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(160, 144);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 5;
            this.siticonePictureBox1.TabStop = false;
            // 
            // ShowPassword
            // 
            this.ShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPassword.CheckedState.BorderRadius = 2;
            this.ShowPassword.CheckedState.BorderThickness = 0;
            this.ShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassword.Location = new System.Drawing.Point(101, 314);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(102, 17);
            this.ShowPassword.TabIndex = 4;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPassword.UncheckedState.BorderRadius = 2;
            this.ShowPassword.UncheckedState.BorderThickness = 0;
            this.ShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPassword.UseVisualStyleBackColor = false;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.DisabledState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.FocusedState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.HoveredState.Parent = this.PasswordTextBox;
            this.PasswordTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("PasswordTextBox.IconLeft")));
            this.PasswordTextBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.PasswordTextBox.Location = new System.Drawing.Point(79, 257);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '\0';
            this.PasswordTextBox.PlaceholderText = "";
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.ShadowDecoration.Parent = this.PasswordTextBox;
            this.PasswordTextBox.Size = new System.Drawing.Size(217, 44);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTextBox.DefaultText = "";
            this.UsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBox.DisabledState.Parent = this.UsernameTextBox;
            this.UsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextBox.FocusedState.Parent = this.UsernameTextBox;
            this.UsernameTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTextBox.HoveredState.Parent = this.UsernameTextBox;
            this.UsernameTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("UsernameTextBox.IconLeft")));
            this.UsernameTextBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.UsernameTextBox.Location = new System.Drawing.Point(79, 186);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PasswordChar = '\0';
            this.UsernameTextBox.PlaceholderText = "";
            this.UsernameTextBox.SelectedText = "";
            this.UsernameTextBox.ShadowDecoration.Parent = this.UsernameTextBox;
            this.UsernameTextBox.Size = new System.Drawing.Size(217, 44);
            this.UsernameTextBox.TabIndex = 2;
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.BorderColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.LoginButton.CheckedState.Parent = this.LoginButton;
            this.LoginButton.CustomImages.Parent = this.LoginButton;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoveredState.Parent = this.LoginButton;
            this.LoginButton.Location = new System.Drawing.Point(132, 349);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.ShadowDecoration.Parent = this.LoginButton;
            this.LoginButton.Size = new System.Drawing.Size(111, 45);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Log in";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.siticoneControlBox1);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.ShadowDecoration.Parent = this.Panel;
            this.Panel.Size = new System.Drawing.Size(486, 34);
            this.Panel.TabIndex = 3;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.Crimson;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.Location = new System.Drawing.Point(439, 1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.PressedColor = System.Drawing.Color.Crimson;
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(47, 31);
            this.siticoneControlBox1.TabIndex = 5;
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLabel.ForeColor = System.Drawing.Color.Gray;
            this.SignUpLabel.Location = new System.Drawing.Point(55, 63);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(176, 29);
            this.SignUpLabel.TabIndex = 0;
            this.SignUpLabel.Text = "Create Account";
            // 
            // SignUpButton
            // 
            this.SignUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUpButton.BorderColor = System.Drawing.Color.Transparent;
            this.SignUpButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SignUpButton.CheckedState.Parent = this.SignUpButton;
            this.SignUpButton.CustomImages.Parent = this.SignUpButton;
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.HoveredState.Parent = this.SignUpButton;
            this.SignUpButton.Location = new System.Drawing.Point(97, 334);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.ShadowDecoration.Parent = this.SignUpButton;
            this.SignUpButton.Size = new System.Drawing.Size(94, 45);
            this.SignUpButton.TabIndex = 1;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // NewEmailTextBox
            // 
            this.NewEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewEmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewEmailTextBox.DefaultText = "";
            this.NewEmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewEmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewEmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewEmailTextBox.DisabledState.Parent = this.NewEmailTextBox;
            this.NewEmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewEmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewEmailTextBox.FocusedState.Parent = this.NewEmailTextBox;
            this.NewEmailTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewEmailTextBox.HoveredState.Parent = this.NewEmailTextBox;
            this.NewEmailTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("NewEmailTextBox.IconLeft")));
            this.NewEmailTextBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.NewEmailTextBox.Location = new System.Drawing.Point(54, 182);
            this.NewEmailTextBox.Name = "NewEmailTextBox";
            this.NewEmailTextBox.PasswordChar = '\0';
            this.NewEmailTextBox.PlaceholderText = "";
            this.NewEmailTextBox.SelectedText = "";
            this.NewEmailTextBox.ShadowDecoration.Parent = this.NewEmailTextBox;
            this.NewEmailTextBox.Size = new System.Drawing.Size(180, 44);
            this.NewEmailTextBox.TabIndex = 2;
            this.NewEmailTextBox.Enter += new System.EventHandler(this.NewEmailTextBox_Enter);
            this.NewEmailTextBox.Leave += new System.EventHandler(this.NewEmailTextBox_Leave);
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPasswordTextBox.DefaultText = "";
            this.NewPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPasswordTextBox.DisabledState.Parent = this.NewPasswordTextBox;
            this.NewPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPasswordTextBox.FocusedState.Parent = this.NewPasswordTextBox;
            this.NewPasswordTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPasswordTextBox.HoveredState.Parent = this.NewPasswordTextBox;
            this.NewPasswordTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("NewPasswordTextBox.IconLeft")));
            this.NewPasswordTextBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.NewPasswordTextBox.Location = new System.Drawing.Point(54, 242);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PasswordChar = '\0';
            this.NewPasswordTextBox.PlaceholderText = "";
            this.NewPasswordTextBox.SelectedText = "";
            this.NewPasswordTextBox.ShadowDecoration.Parent = this.NewPasswordTextBox;
            this.NewPasswordTextBox.Size = new System.Drawing.Size(180, 44);
            this.NewPasswordTextBox.TabIndex = 3;
            this.NewPasswordTextBox.Enter += new System.EventHandler(this.NewPasswordTextBox_Enter);
            this.NewPasswordTextBox.Leave += new System.EventHandler(this.NewPasswordTextBox_Leave);
            // 
            // ShowPassword2
            // 
            this.ShowPassword2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowPassword2.AutoSize = true;
            this.ShowPassword2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPassword2.CheckedState.BorderRadius = 2;
            this.ShowPassword2.CheckedState.BorderThickness = 0;
            this.ShowPassword2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ShowPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassword2.Location = new System.Drawing.Point(58, 294);
            this.ShowPassword2.Name = "ShowPassword2";
            this.ShowPassword2.Size = new System.Drawing.Size(102, 17);
            this.ShowPassword2.TabIndex = 4;
            this.ShowPassword2.Text = "Show Password";
            this.ShowPassword2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPassword2.UncheckedState.BorderRadius = 2;
            this.ShowPassword2.UncheckedState.BorderThickness = 0;
            this.ShowPassword2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ShowPassword2.UseVisualStyleBackColor = false;
            this.ShowPassword2.CheckedChanged += new System.EventHandler(this.ShowPassword2_CheckedChanged);
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Comfortaa", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.linkLogin.Location = new System.Drawing.Point(163, 357);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(49, 19);
            this.linkLogin.TabIndex = 5;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Log in";
            // 
            // panelSignUp
            // 
            this.panelSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSignUp.BackColor = System.Drawing.Color.Transparent;
            this.panelSignUp.Controls.Add(this.label2);
            this.panelSignUp.Controls.Add(this.linkLogin);
            this.panelSignUp.Controls.Add(this.ShowPassword2);
            this.panelSignUp.Controls.Add(this.NewPasswordTextBox);
            this.panelSignUp.Controls.Add(this.NewEmailTextBox);
            this.panelSignUp.Controls.Add(this.SignUpButton);
            this.panelSignUp.Controls.Add(this.SignUpLabel);
            this.panelSignUp.Controls.Add(this.NewUsernameTextBox);
            this.panelSignUp.Location = new System.Drawing.Point(103, 67);
            this.panelSignUp.Name = "panelSignUp";
            this.panelSignUp.Size = new System.Drawing.Size(285, 469);
            this.panelSignUp.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Already have an account? ";
            // 
            // NewUsernameTextBox
            // 
            this.NewUsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewUsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewUsernameTextBox.DefaultText = "";
            this.NewUsernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewUsernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewUsernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewUsernameTextBox.DisabledState.Parent = this.NewUsernameTextBox;
            this.NewUsernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewUsernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewUsernameTextBox.FocusedState.Parent = this.NewUsernameTextBox;
            this.NewUsernameTextBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewUsernameTextBox.HoveredState.Parent = this.NewUsernameTextBox;
            this.NewUsernameTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("NewUsernameTextBox.IconLeft")));
            this.NewUsernameTextBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.NewUsernameTextBox.Location = new System.Drawing.Point(54, 120);
            this.NewUsernameTextBox.Name = "NewUsernameTextBox";
            this.NewUsernameTextBox.PasswordChar = '\0';
            this.NewUsernameTextBox.PlaceholderText = "";
            this.NewUsernameTextBox.SelectedText = "";
            this.NewUsernameTextBox.ShadowDecoration.Parent = this.NewUsernameTextBox;
            this.NewUsernameTextBox.Size = new System.Drawing.Size(180, 44);
            this.NewUsernameTextBox.TabIndex = 8;
            this.NewUsernameTextBox.Enter += new System.EventHandler(this.NewUsernameTextBox_Enter);
            this.NewUsernameTextBox.Leave += new System.EventHandler(this.NewUsernameTextBox_Leave);
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Comfortaa", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.Location = new System.Drawing.Point(34, 359);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(104, 20);
            this.siticoneLabel2.TabIndex = 4;
            this.siticoneLabel2.Text = "Have an account?";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 598);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.panelSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.LoginAndSignup_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.LoginAndSignup_ResizeEnd);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.LoginAndSignup_DragEnter);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.Panel.ResumeLayout(false);
            this.panelSignUp.ResumeLayout(false);
            this.panelSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogin;
        private Siticone.UI.WinForms.SiticoneRoundedButton LoginButton;
        private Siticone.UI.WinForms.SiticoneCheckBox ShowPassword;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox PasswordTextBox;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox UsernameTextBox;
        private Siticone.UI.WinForms.SiticonePanel Panel;
        private System.Windows.Forms.Label SignUpLabel;
        private Siticone.UI.WinForms.SiticoneRoundedButton SignUpButton;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox NewEmailTextBox;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox NewPasswordTextBox;
        private Siticone.UI.WinForms.SiticoneCheckBox ShowPassword2;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.Panel panelSignUp;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneLabel label2;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox NewUsernameTextBox;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
    }
}

