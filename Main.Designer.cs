using System.Windows.Forms;

namespace CSCISystem1._1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new AntdUI.Panel();
            this.siticoneShadowPanel1 = new Siticone.UI.WinForms.SiticoneShadowPanel();
            this.UserCirclePictureBox = new Siticone.UI.WinForms.SiticoneCirclePictureBox();
            this.LogoutBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.labelUserType = new Siticone.UI.WinForms.SiticoneLabel();
            this.panelDropDown = new System.Windows.Forms.FlowLayoutPanel();
            this.HomeBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.ProductBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.UserBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.ReportBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.InventoryRBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.SalesBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.mainpanel = new AntdUI.Panel();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.dropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.titlebar = new AntdUI.PageHeader();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.backPanel = new AntdUI.Panel();
            this.panel1.SuspendLayout();
            this.siticoneShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserCirclePictureBox)).BeginInit();
            this.panelDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.titlebar.SuspendLayout();
            this.backPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siticoneShadowPanel1);
            this.panel1.Controls.Add(this.panelDropDown);
            this.panel1.Controls.Add(this.siticonePictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 10;
            this.panel1.Size = new System.Drawing.Size(316, 667);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // siticoneShadowPanel1
            // 
            this.siticoneShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.siticoneShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel1.Controls.Add(this.UserCirclePictureBox);
            this.siticoneShadowPanel1.Controls.Add(this.LogoutBtn);
            this.siticoneShadowPanel1.Controls.Add(this.labelUserType);
            this.siticoneShadowPanel1.FillColor = System.Drawing.Color.White;
            this.siticoneShadowPanel1.Location = new System.Drawing.Point(4, 600);
            this.siticoneShadowPanel1.Name = "siticoneShadowPanel1";
            this.siticoneShadowPanel1.Radius = 5;
            this.siticoneShadowPanel1.ShadowColor = System.Drawing.Color.Silver;
            this.siticoneShadowPanel1.ShadowDepth = 50;
            this.siticoneShadowPanel1.Size = new System.Drawing.Size(306, 64);
            this.siticoneShadowPanel1.TabIndex = 7;
            // 
            // UserCirclePictureBox
            // 
            this.UserCirclePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.UserCirclePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UserCirclePictureBox.Image")));
            this.UserCirclePictureBox.Location = new System.Drawing.Point(18, 18);
            this.UserCirclePictureBox.Name = "UserCirclePictureBox";
            this.UserCirclePictureBox.ShadowDecoration.Color = System.Drawing.Color.DimGray;
            this.UserCirclePictureBox.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.UserCirclePictureBox.ShadowDecoration.Parent = this.UserCirclePictureBox;
            this.UserCirclePictureBox.Size = new System.Drawing.Size(30, 29);
            this.UserCirclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserCirclePictureBox.TabIndex = 1;
            this.UserCirclePictureBox.TabStop = false;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.BorderColor = System.Drawing.Color.Turquoise;
            this.LogoutBtn.CheckedState.Parent = this.LogoutBtn;
            this.LogoutBtn.CustomImages.Parent = this.LogoutBtn;
            this.LogoutBtn.FillColor = System.Drawing.Color.Transparent;
            this.LogoutBtn.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.Black;
            this.LogoutBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.LogoutBtn.HoveredState.Parent = this.LogoutBtn;
            this.LogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("LogoutBtn.Image")));
            this.LogoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogoutBtn.ImageOffset = new System.Drawing.Point(1, 0);
            this.LogoutBtn.Location = new System.Drawing.Point(244, 11);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.ShadowDecoration.Parent = this.LogoutBtn;
            this.LogoutBtn.Size = new System.Drawing.Size(42, 42);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogoutBtn.TextOffset = new System.Drawing.Point(15, 0);
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // labelUserType
            // 
            this.labelUserType.BackColor = System.Drawing.Color.Transparent;
            this.labelUserType.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelUserType.Location = new System.Drawing.Point(66, 21);
            this.labelUserType.Name = "labelUserType";
            this.labelUserType.Size = new System.Drawing.Size(51, 22);
            this.labelUserType.TabIndex = 0;
            this.labelUserType.Text = "Admin";
            // 
            // panelDropDown
            // 
            this.panelDropDown.BackColor = System.Drawing.Color.Transparent;
            this.panelDropDown.Controls.Add(this.HomeBtn);
            this.panelDropDown.Controls.Add(this.ProductBtn);
            this.panelDropDown.Controls.Add(this.UserBtn);
            this.panelDropDown.Controls.Add(this.ReportBtn);
            this.panelDropDown.Controls.Add(this.InventoryRBtn);
            this.panelDropDown.Controls.Add(this.SalesBtn);
            this.panelDropDown.Location = new System.Drawing.Point(23, 227);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelDropDown.Size = new System.Drawing.Size(267, 185);
            this.panelDropDown.TabIndex = 1;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BorderColor = System.Drawing.Color.Lime;
            this.HomeBtn.CheckedState.Parent = this.HomeBtn;
            this.HomeBtn.CustomImages.Parent = this.HomeBtn;
            this.HomeBtn.FillColor = System.Drawing.Color.White;
            this.HomeBtn.Font = new System.Drawing.Font("Satoshi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HomeBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.HomeBtn.HoveredState.Parent = this.HomeBtn;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.HomeBtn.Location = new System.Drawing.Point(6, 3);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.HomeBtn.ShadowDecoration.Parent = this.HomeBtn;
            this.HomeBtn.Size = new System.Drawing.Size(258, 40);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = " Home";
            this.HomeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeBtn.TextOffset = new System.Drawing.Point(15, 0);
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProductBtn.BorderColor = System.Drawing.Color.Lime;
            this.ProductBtn.CheckedState.Parent = this.ProductBtn;
            this.ProductBtn.CustomImages.Parent = this.ProductBtn;
            this.ProductBtn.FillColor = System.Drawing.Color.White;
            this.ProductBtn.Font = new System.Drawing.Font("Satoshi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ProductBtn.HoveredState.Parent = this.ProductBtn;
            this.ProductBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProductBtn.Image")));
            this.ProductBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.ProductBtn.Location = new System.Drawing.Point(6, 49);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ProductBtn.ShadowDecoration.Parent = this.ProductBtn;
            this.ProductBtn.Size = new System.Drawing.Size(258, 40);
            this.ProductBtn.TabIndex = 1;
            this.ProductBtn.Text = " Product";
            this.ProductBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductBtn.TextOffset = new System.Drawing.Point(15, 0);
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // UserBtn
            // 
            this.UserBtn.BackColor = System.Drawing.Color.Transparent;
            this.UserBtn.BorderColor = System.Drawing.Color.Lime;
            this.UserBtn.CheckedState.Parent = this.UserBtn;
            this.UserBtn.CustomImages.Parent = this.UserBtn;
            this.UserBtn.FillColor = System.Drawing.Color.White;
            this.UserBtn.Font = new System.Drawing.Font("Satoshi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.UserBtn.HoveredState.Parent = this.UserBtn;
            this.UserBtn.Image = ((System.Drawing.Image)(resources.GetObject("UserBtn.Image")));
            this.UserBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.UserBtn.Location = new System.Drawing.Point(6, 95);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.UserBtn.ShadowDecoration.Parent = this.UserBtn;
            this.UserBtn.Size = new System.Drawing.Size(258, 40);
            this.UserBtn.TabIndex = 2;
            this.UserBtn.Text = " User";
            this.UserBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserBtn.TextOffset = new System.Drawing.Point(15, 0);
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReportBtn.BorderColor = System.Drawing.Color.Lime;
            this.ReportBtn.CheckedState.Parent = this.ReportBtn;
            this.ReportBtn.CustomImages.Parent = this.ReportBtn;
            this.ReportBtn.FillColor = System.Drawing.Color.White;
            this.ReportBtn.Font = new System.Drawing.Font("Satoshi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReportBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ReportBtn.HoveredState.Parent = this.ReportBtn;
            this.ReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReportBtn.Image")));
            this.ReportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.ReportBtn.Location = new System.Drawing.Point(6, 141);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ReportBtn.ShadowDecoration.Parent = this.ReportBtn;
            this.ReportBtn.Size = new System.Drawing.Size(258, 40);
            this.ReportBtn.TabIndex = 3;
            this.ReportBtn.Text = "Report";
            this.ReportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportBtn.TextOffset = new System.Drawing.Point(15, 0);
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // InventoryRBtn
            // 
            this.InventoryRBtn.BackColor = System.Drawing.Color.Transparent;
            this.InventoryRBtn.BorderColor = System.Drawing.Color.Turquoise;
            this.InventoryRBtn.CheckedState.Parent = this.InventoryRBtn;
            this.InventoryRBtn.CustomImages.Parent = this.InventoryRBtn;
            this.InventoryRBtn.FillColor = System.Drawing.Color.White;
            this.InventoryRBtn.Font = new System.Drawing.Font("Satoshi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InventoryRBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.InventoryRBtn.HoveredState.Parent = this.InventoryRBtn;
            this.InventoryRBtn.Image = ((System.Drawing.Image)(resources.GetObject("InventoryRBtn.Image")));
            this.InventoryRBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InventoryRBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.InventoryRBtn.Location = new System.Drawing.Point(47, 187);
            this.InventoryRBtn.Name = "InventoryRBtn";
            this.InventoryRBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.InventoryRBtn.ShadowDecoration.Parent = this.InventoryRBtn;
            this.InventoryRBtn.Size = new System.Drawing.Size(217, 40);
            this.InventoryRBtn.TabIndex = 4;
            this.InventoryRBtn.Text = "Inventory";
            this.InventoryRBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InventoryRBtn.TextOffset = new System.Drawing.Point(15, 0);
            this.InventoryRBtn.Click += new System.EventHandler(this.InventoryRBtn_Click);
            // 
            // SalesBtn
            // 
            this.SalesBtn.BackColor = System.Drawing.Color.Transparent;
            this.SalesBtn.BorderColor = System.Drawing.Color.Turquoise;
            this.SalesBtn.CheckedState.Parent = this.SalesBtn;
            this.SalesBtn.CustomImages.Parent = this.SalesBtn;
            this.SalesBtn.FillColor = System.Drawing.Color.White;
            this.SalesBtn.Font = new System.Drawing.Font("Satoshi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SalesBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.SalesBtn.HoveredState.Parent = this.SalesBtn;
            this.SalesBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalesBtn.Image")));
            this.SalesBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SalesBtn.ImageOffset = new System.Drawing.Point(10, 0);
            this.SalesBtn.Location = new System.Drawing.Point(47, 233);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.SalesBtn.ShadowDecoration.Parent = this.SalesBtn;
            this.SalesBtn.Size = new System.Drawing.Size(217, 40);
            this.SalesBtn.TabIndex = 5;
            this.SalesBtn.Text = "Sales";
            this.SalesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SalesBtn.TextOffset = new System.Drawing.Point(15, 0);
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.BorderRadius = 2;
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.Location = new System.Drawing.Point(68, 41);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(180, 180);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 3;
            this.siticonePictureBox1.TabStop = false;
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(326, 10);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.mainpanel.Radius = 10;
            this.mainpanel.Size = new System.Drawing.Size(952, 667);
            this.mainpanel.TabIndex = 1;
            this.mainpanel.Text = "panel2";
            // 
            // loadingTimer
            // 
            this.loadingTimer.Interval = 1000;
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // dropDownTimer
            // 
            this.dropDownTimer.Interval = 1;
            this.dropDownTimer.Tick += new System.EventHandler(this.dropDownTimer_Tick);
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.titlebar.CloseSize = 35;
            this.titlebar.Controls.Add(this.siticoneControlBox2);
            this.titlebar.Controls.Add(this.siticoneControlBox1);
            this.titlebar.DividerShow = true;
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.DragMove = false;
            this.titlebar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.MaximizeBox = false;
            this.titlebar.Name = "titlebar";
            this.titlebar.ShowIcon = true;
            this.titlebar.Size = new System.Drawing.Size(1288, 29);
            this.titlebar.SubGap = 5;
            this.titlebar.SubText = "Inventory Management";
            this.titlebar.TabIndex = 2;
            this.titlebar.Text = "STOREFLOW";
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox2.Location = new System.Drawing.Point(1191, -1);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(49, 29);
            this.siticoneControlBox2.TabIndex = 3;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1239, -1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(49, 29);
            this.siticoneControlBox1.TabIndex = 2;
            // 
            // backPanel
            // 
            this.backPanel.Back = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.backPanel.Controls.Add(this.mainpanel);
            this.backPanel.Controls.Add(this.panel1);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 29);
            this.backPanel.Name = "backPanel";
            this.backPanel.padding = new System.Windows.Forms.Padding(10);
            this.backPanel.Padding = new System.Windows.Forms.Padding(10);
            this.backPanel.Size = new System.Drawing.Size(1288, 687);
            this.backPanel.TabIndex = 3;
            this.backPanel.Text = "panel2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1288, 716);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreFlow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.siticoneShadowPanel1.ResumeLayout(false);
            this.siticoneShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserCirclePictureBox)).EndInit();
            this.panelDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.titlebar.ResumeLayout(false);
            this.backPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private Siticone.UI.WinForms.SiticoneRoundedButton HomeBtn;
        private System.Windows.Forms.FlowLayoutPanel panelDropDown;
        private Siticone.UI.WinForms.SiticoneRoundedButton ProductBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton UserBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton ReportBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton InventoryRBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton SalesBtn;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.UI.WinForms.SiticoneRoundedButton LogoutBtn;
        private Siticone.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel1;
        private Siticone.UI.WinForms.SiticoneLabel labelUserType;
        private Siticone.UI.WinForms.SiticoneCirclePictureBox UserCirclePictureBox;
        private System.Windows.Forms.Timer loadingTimer;
        private System.Windows.Forms.Timer dropDownTimer;
        private System.Windows.Forms.Timer timer2;
        private AntdUI.PageHeader titlebar;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private AntdUI.Panel backPanel;
        private AntdUI.Panel mainpanel;
    }
}

