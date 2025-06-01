namespace CSCISystem1._1
{
    partial class EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            this.titlebar = new AntdUI.PageHeader();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.txtUsername = new AntdUI.Input();
            this.txtEmail = new AntdUI.Input();
            this.updateBtn = new AntdUI.Button();
            this.panel2 = new AntdUI.Panel();
            this.pictureBoxAddUser = new AntdUI.Avatar();
            this.uploadBtn = new AntdUI.Button();
            this.resetBtn = new AntdUI.Button();
            this.panel1 = new AntdUI.Panel();
            this.labelEmail = new Siticone.UI.WinForms.SiticoneLabel();
            this.selectUsertype = new AntdUI.Select();
            this.txtLname = new AntdUI.Input();
            this.txtFname = new AntdUI.Input();
            this.txtPassword = new AntdUI.Input();
            this.siticoneLabel5 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel6 = new Siticone.UI.WinForms.SiticoneLabel();
            this.titlebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.CloseSize = 30;
            this.titlebar.Controls.Add(this.siticoneControlBox1);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Font = new System.Drawing.Font("Satoshi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebar.Icon = ((System.Drawing.Image)(resources.GetObject("titlebar.Icon")));
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.MaximizeBox = false;
            this.titlebar.Name = "titlebar";
            this.titlebar.ShowIcon = true;
            this.titlebar.Size = new System.Drawing.Size(846, 27);
            this.titlebar.SubText = "";
            this.titlebar.TabIndex = 5;
            this.titlebar.Text = "Edit User";
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.Location = new System.Drawing.Point(801, -1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.AllowClear = true;
            this.txtUsername.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(57, 87);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(485, 55);
            this.txtUsername.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.AllowClear = true;
            this.txtEmail.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(56, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(486, 55);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.updateBtn.Font = new System.Drawing.Font("Satoshi", 12F);
            this.updateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.updateBtn.Location = new System.Drawing.Point(159, 438);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(132, 42);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Back = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBoxAddUser);
            this.panel2.Controls.Add(this.uploadBtn);
            this.panel2.Location = new System.Drawing.Point(559, 161);
            this.panel2.Name = "panel2";
            this.panel2.Radius = 8;
            this.panel2.Size = new System.Drawing.Size(230, 319);
            this.panel2.TabIndex = 16;
            this.panel2.Text = "panel2";
            // 
            // pictureBoxAddUser
            // 
            this.pictureBoxAddUser.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddUser.Image")));
            this.pictureBoxAddUser.Location = new System.Drawing.Point(10, 15);
            this.pictureBoxAddUser.Name = "pictureBoxAddUser";
            this.pictureBoxAddUser.Radius = 6;
            this.pictureBoxAddUser.Size = new System.Drawing.Size(210, 210);
            this.pictureBoxAddUser.TabIndex = 32;
            this.pictureBoxAddUser.Text = "";
            // 
            // uploadBtn
            // 
            this.uploadBtn.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.uploadBtn.Font = new System.Drawing.Font("Satoshi", 12F);
            this.uploadBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uploadBtn.Icon = ((System.Drawing.Image)(resources.GetObject("uploadBtn.Icon")));
            this.uploadBtn.IconPosition = AntdUI.TAlignMini.Top;
            this.uploadBtn.IconRatio = 0.9F;
            this.uploadBtn.Location = new System.Drawing.Point(3, 234);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(224, 80);
            this.uploadBtn.TabIndex = 31;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.resetBtn.Font = new System.Drawing.Font("Satoshi", 12F);
            this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resetBtn.Location = new System.Drawing.Point(297, 438);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(132, 42);
            this.resetBtn.TabIndex = 30;
            this.resetBtn.Text = "Reset";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.selectUsertype);
            this.panel1.Controls.Add(this.txtLname);
            this.panel1.Controls.Add(this.txtFname);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.titlebar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 517);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // labelEmail
            // 
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.ForeColor = System.Drawing.Color.Red;
            this.labelEmail.Location = new System.Drawing.Point(68, 209);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(3, 2);
            this.labelEmail.TabIndex = 37;
            // 
            // selectUsertype
            // 
            this.selectUsertype.Font = new System.Drawing.Font("Satoshi", 12F);
            this.selectUsertype.Location = new System.Drawing.Point(561, 87);
            this.selectUsertype.Name = "selectUsertype";
            this.selectUsertype.PlaceholderText = "User Type";
            this.selectUsertype.Size = new System.Drawing.Size(227, 55);
            this.selectUsertype.TabIndex = 35;
            // 
            // txtLname
            // 
            this.txtLname.AllowClear = true;
            this.txtLname.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(56, 370);
            this.txtLname.Name = "txtLname";
            this.txtLname.PlaceholderText = "Last Name";
            this.txtLname.Size = new System.Drawing.Size(486, 55);
            this.txtLname.TabIndex = 33;
            // 
            // txtFname
            // 
            this.txtFname.AllowClear = true;
            this.txtFname.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(56, 299);
            this.txtFname.Name = "txtFname";
            this.txtFname.PlaceholderText = "First Name";
            this.txtFname.Size = new System.Drawing.Size(486, 55);
            this.txtFname.TabIndex = 32;
            // 
            // txtPassword
            // 
            this.txtPassword.AllowClear = true;
            this.txtPassword.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(56, 228);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(486, 55);
            this.txtPassword.TabIndex = 31;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // siticoneLabel5
            // 
            this.siticoneLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel5.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel5.Location = new System.Drawing.Point(74, 148);
            this.siticoneLabel5.Name = "siticoneLabel5";
            this.siticoneLabel5.Size = new System.Drawing.Size(40, 22);
            this.siticoneLabel5.TabIndex = 28;
            this.siticoneLabel5.Text = "Email";
            // 
            // siticoneLabel6
            // 
            this.siticoneLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel6.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel6.Location = new System.Drawing.Point(74, 59);
            this.siticoneLabel6.Name = "siticoneLabel6";
            this.siticoneLabel6.Size = new System.Drawing.Size(79, 22);
            this.siticoneLabel6.TabIndex = 29;
            this.siticoneLabel6.Text = "User Name";
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(866, 530);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditUser";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            this.titlebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader titlebar;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private AntdUI.Input txtUsername;
        private AntdUI.Input txtEmail;
        private AntdUI.Button updateBtn;
        private AntdUI.Panel panel2;
        private AntdUI.Avatar pictureBoxAddUser;
        private AntdUI.Button uploadBtn;
        private AntdUI.Button resetBtn;
        private AntdUI.Panel panel1;
        private AntdUI.Select selectUsertype;
        private AntdUI.Input txtLname;
        private AntdUI.Input txtFname;
        private AntdUI.Input txtPassword;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel5;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel6;
        private Siticone.UI.WinForms.SiticoneLabel labelEmail;
    }
}