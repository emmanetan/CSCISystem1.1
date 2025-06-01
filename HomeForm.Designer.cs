namespace CSCISystem1._1
{
    partial class HomeForm
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
            AntdUI.BreadcrumbItem breadcrumbItem1 = new AntdUI.BreadcrumbItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.labelTime1 = new AntdUI.LabelTime();
            this.panel2 = new AntdUI.Panel();
            this.breadcrumb1 = new AntdUI.Breadcrumb();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel1 = new AntdUI.Panel();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.labelTotalProducts = new Siticone.UI.WinForms.SiticoneLabel();
            this.labelTotalInventoryValue = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel3 = new AntdUI.Panel();
            this.siticoneRoundedButton2 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.labelQuantityOfItems = new Siticone.UI.WinForms.SiticoneLabel();
            this.labelTotalItems = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel7 = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel5 = new AntdUI.Panel();
            this.siticoneRoundedButton3 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneLabel8 = new Siticone.UI.WinForms.SiticoneLabel();
            this.LabelOutOfStock = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel10 = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTime1
            // 
            this.labelTime1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime1.BackColor = System.Drawing.Color.Transparent;
            this.labelTime1.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime1.ForeColor = System.Drawing.Color.Gray;
            this.labelTime1.Location = new System.Drawing.Point(1345, 84);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(193, 46);
            this.labelTime1.TabIndex = 3;
            this.labelTime1.Text = "labelTime1";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.labelTime1);
            this.panel2.Controls.Add(this.breadcrumb1);
            this.panel2.Controls.Add(this.siticoneLabel2);
            this.panel2.Location = new System.Drawing.Point(11, 0);
            this.panel2.Name = "panel2";
            this.panel2.Radius = 10;
            this.panel2.Size = new System.Drawing.Size(1567, 161);
            this.panel2.TabIndex = 11;
            this.panel2.Text = "panel2";
            // 
            // breadcrumb1
            // 
            this.breadcrumb1.BackColor = System.Drawing.Color.Transparent;
            this.breadcrumb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            breadcrumbItem1.Icon = ((System.Drawing.Image)(resources.GetObject("breadcrumbItem1.Icon")));
            breadcrumbItem1.LocalizationText = "homebread";
            breadcrumbItem1.Text = "Home";
            this.breadcrumb1.Items.Add(breadcrumbItem1);
            this.breadcrumb1.Location = new System.Drawing.Point(38, 20);
            this.breadcrumb1.Name = "breadcrumb1";
            this.breadcrumb1.Size = new System.Drawing.Size(873, 40);
            this.breadcrumb1.TabIndex = 10;
            this.breadcrumb1.Text = "breadcrumb1";
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Satoshi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.Location = new System.Drawing.Point(38, 84);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(92, 42);
            this.siticoneLabel2.TabIndex = 9;
            this.siticoneLabel2.Text = "Home";
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Satoshi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(50, 28);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(189, 26);
            this.siticoneLabel1.TabIndex = 11;
            this.siticoneLabel1.Text = "Total Inventory Value";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.siticoneRoundedButton1);
            this.panel1.Controls.Add(this.labelTotalProducts);
            this.panel1.Controls.Add(this.labelTotalInventoryValue);
            this.panel1.Controls.Add(this.siticoneLabel1);
            this.panel1.Location = new System.Drawing.Point(61, 333);
            this.panel1.Name = "panel1";
            this.panel1.Radius = 10;
            this.panel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(76)))), ((int)(((byte)(222)))));
            this.panel1.ShadowOffsetX = 1;
            this.panel1.ShadowOffsetY = 1;
            this.panel1.ShadowOpacity = 1F;
            this.panel1.ShadowOpacityAnimation = true;
            this.panel1.ShadowOpacityHover = 1F;
            this.panel1.Size = new System.Drawing.Size(460, 219);
            this.panel1.TabIndex = 12;
            this.panel1.Text = "panel1";
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.Animated = false;
            this.siticoneRoundedButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedButton1.Image")));
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(362, 28);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.PressedColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedButton1.PressedDepth = 0;
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(50, 50);
            this.siticoneRoundedButton1.TabIndex = 14;
            // 
            // labelTotalProducts
            // 
            this.labelTotalProducts.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalProducts.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProducts.Location = new System.Drawing.Point(50, 133);
            this.labelTotalProducts.Name = "labelTotalProducts";
            this.labelTotalProducts.Size = new System.Drawing.Size(131, 21);
            this.labelTotalProducts.TabIndex = 13;
            this.labelTotalProducts.Text = "Across 10 products";
            // 
            // labelTotalInventoryValue
            // 
            this.labelTotalInventoryValue.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalInventoryValue.Font = new System.Drawing.Font("Satoshi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalInventoryValue.Location = new System.Drawing.Point(50, 65);
            this.labelTotalInventoryValue.Name = "labelTotalInventoryValue";
            this.labelTotalInventoryValue.Size = new System.Drawing.Size(237, 62);
            this.labelTotalInventoryValue.TabIndex = 12;
            this.labelTotalInventoryValue.Text = "P100,000";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.siticoneRoundedButton2);
            this.panel3.Controls.Add(this.labelQuantityOfItems);
            this.panel3.Controls.Add(this.labelTotalItems);
            this.panel3.Controls.Add(this.siticoneLabel7);
            this.panel3.Location = new System.Drawing.Point(547, 333);
            this.panel3.Name = "panel3";
            this.panel3.Radius = 10;
            this.panel3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(76)))), ((int)(((byte)(222)))));
            this.panel3.ShadowOffsetX = 1;
            this.panel3.ShadowOffsetY = 1;
            this.panel3.ShadowOpacity = 1F;
            this.panel3.ShadowOpacityAnimation = true;
            this.panel3.ShadowOpacityHover = 1F;
            this.panel3.Size = new System.Drawing.Size(470, 219);
            this.panel3.TabIndex = 14;
            this.panel3.Text = "panel3";
            // 
            // siticoneRoundedButton2
            // 
            this.siticoneRoundedButton2.Animated = false;
            this.siticoneRoundedButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedButton2.Image")));
            this.siticoneRoundedButton2.ImageSize = new System.Drawing.Size(25, 25);
            this.siticoneRoundedButton2.Location = new System.Drawing.Point(365, 28);
            this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
            this.siticoneRoundedButton2.PressedColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedButton2.PressedDepth = 0;
            this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Size = new System.Drawing.Size(50, 50);
            this.siticoneRoundedButton2.TabIndex = 15;
            // 
            // labelQuantityOfItems
            // 
            this.labelQuantityOfItems.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantityOfItems.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantityOfItems.Location = new System.Drawing.Point(50, 133);
            this.labelQuantityOfItems.Name = "labelQuantityOfItems";
            this.labelQuantityOfItems.Size = new System.Drawing.Size(114, 21);
            this.labelQuantityOfItems.TabIndex = 13;
            this.labelQuantityOfItems.Text = "Units in Inventory";
            // 
            // labelTotalItems
            // 
            this.labelTotalItems.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalItems.Font = new System.Drawing.Font("Satoshi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalItems.Location = new System.Drawing.Point(50, 65);
            this.labelTotalItems.Name = "labelTotalItems";
            this.labelTotalItems.Size = new System.Drawing.Size(99, 62);
            this.labelTotalItems.TabIndex = 12;
            this.labelTotalItems.Text = "200";
            // 
            // siticoneLabel7
            // 
            this.siticoneLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel7.Font = new System.Drawing.Font("Satoshi", 14.25F, System.Drawing.FontStyle.Bold);
            this.siticoneLabel7.Location = new System.Drawing.Point(50, 28);
            this.siticoneLabel7.Name = "siticoneLabel7";
            this.siticoneLabel7.Size = new System.Drawing.Size(144, 26);
            this.siticoneLabel7.TabIndex = 11;
            this.siticoneLabel7.Text = "Total Sold Items";
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.Controls.Add(this.siticoneRoundedButton3);
            this.panel5.Controls.Add(this.siticoneLabel8);
            this.panel5.Controls.Add(this.LabelOutOfStock);
            this.panel5.Controls.Add(this.siticoneLabel10);
            this.panel5.Location = new System.Drawing.Point(1041, 333);
            this.panel5.Name = "panel5";
            this.panel5.Radius = 10;
            this.panel5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(76)))), ((int)(((byte)(222)))));
            this.panel5.ShadowOffsetX = 1;
            this.panel5.ShadowOffsetY = 1;
            this.panel5.ShadowOpacity = 1F;
            this.panel5.ShadowOpacityAnimation = true;
            this.panel5.ShadowOpacityHover = 1F;
            this.panel5.Size = new System.Drawing.Size(460, 219);
            this.panel5.TabIndex = 15;
            this.panel5.Text = "panel5";
            // 
            // siticoneRoundedButton3
            // 
            this.siticoneRoundedButton3.Animated = false;
            this.siticoneRoundedButton3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedButton3.CheckedState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.CustomImages.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.FillColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton3.HoveredState.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Image = ((System.Drawing.Image)(resources.GetObject("siticoneRoundedButton3.Image")));
            this.siticoneRoundedButton3.ImageSize = new System.Drawing.Size(50, 50);
            this.siticoneRoundedButton3.Location = new System.Drawing.Point(360, 28);
            this.siticoneRoundedButton3.Name = "siticoneRoundedButton3";
            this.siticoneRoundedButton3.PressedColor = System.Drawing.Color.Transparent;
            this.siticoneRoundedButton3.PressedDepth = 0;
            this.siticoneRoundedButton3.ShadowDecoration.Parent = this.siticoneRoundedButton3;
            this.siticoneRoundedButton3.Size = new System.Drawing.Size(50, 50);
            this.siticoneRoundedButton3.TabIndex = 16;
            // 
            // siticoneLabel8
            // 
            this.siticoneLabel8.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel8.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel8.Location = new System.Drawing.Point(50, 133);
            this.siticoneLabel8.Name = "siticoneLabel8";
            this.siticoneLabel8.Size = new System.Drawing.Size(139, 21);
            this.siticoneLabel8.TabIndex = 13;
            this.siticoneLabel8.Text = "Products unavailable";
            // 
            // LabelOutOfStock
            // 
            this.LabelOutOfStock.BackColor = System.Drawing.Color.Transparent;
            this.LabelOutOfStock.Font = new System.Drawing.Font("Satoshi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOutOfStock.Location = new System.Drawing.Point(50, 65);
            this.LabelOutOfStock.Name = "LabelOutOfStock";
            this.LabelOutOfStock.Size = new System.Drawing.Size(99, 62);
            this.LabelOutOfStock.TabIndex = 12;
            this.LabelOutOfStock.Text = "200";
            // 
            // siticoneLabel10
            // 
            this.siticoneLabel10.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel10.Font = new System.Drawing.Font("Satoshi", 14.25F, System.Drawing.FontStyle.Bold);
            this.siticoneLabel10.Location = new System.Drawing.Point(50, 28);
            this.siticoneLabel10.Name = "siticoneLabel10";
            this.siticoneLabel10.Size = new System.Drawing.Size(110, 26);
            this.siticoneLabel10.TabIndex = 11;
            this.siticoneLabel10.Text = "Out of Stock";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1579, 696);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private AntdUI.LabelTime labelTime1;
        private AntdUI.Panel panel2;
        private AntdUI.Breadcrumb breadcrumb1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private AntdUI.Panel panel1;
        private Siticone.UI.WinForms.SiticoneLabel labelTotalProducts;
        private Siticone.UI.WinForms.SiticoneLabel labelTotalInventoryValue;
        private AntdUI.Panel panel3;
        private Siticone.UI.WinForms.SiticoneLabel labelQuantityOfItems;
        private Siticone.UI.WinForms.SiticoneLabel labelTotalItems;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel7;
        private AntdUI.Panel panel5;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel8;
        private Siticone.UI.WinForms.SiticoneLabel LabelOutOfStock;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel10;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton3;
    }
}