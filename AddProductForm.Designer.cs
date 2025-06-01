namespace CSCISystem1._1
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.panel1 = new AntdUI.Panel();
            this.panel2 = new AntdUI.Panel();
            this.pictureBoxAddProduct = new AntdUI.Avatar();
            this.uploadBtn = new AntdUI.Button();
            this.datePicker = new Siticone.UI.WinForms.SiticoneDateTimePicker();
            this.resetBtn = new AntdUI.Button();
            this.siticoneLabel6 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel5 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel4 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.txtTotalPrice = new AntdUI.InputNumber();
            this.txtPrice = new AntdUI.InputNumber();
            this.addBtn = new AntdUI.Button();
            this.txtQuantity = new AntdUI.InputNumber();
            this.txtProductName = new AntdUI.Input();
            this.txtProductCode = new AntdUI.Input();
            this.titlebar = new AntdUI.PageHeader();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.siticoneLabel6);
            this.panel1.Controls.Add(this.siticoneLabel5);
            this.panel1.Controls.Add(this.siticoneLabel4);
            this.panel1.Controls.Add(this.siticoneLabel3);
            this.panel1.Controls.Add(this.siticoneLabel1);
            this.panel1.Controls.Add(this.siticoneLabel2);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.txtProductCode);
            this.panel1.Controls.Add(this.titlebar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 674);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // panel2
            // 
            this.panel2.Back = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBoxAddProduct);
            this.panel2.Controls.Add(this.uploadBtn);
            this.panel2.Location = new System.Drawing.Point(498, 270);
            this.panel2.Name = "panel2";
            this.panel2.Radius = 8;
            this.panel2.Size = new System.Drawing.Size(230, 319);
            this.panel2.TabIndex = 32;
            this.panel2.Text = "panel2";
            // 
            // pictureBoxAddProduct
            // 
            this.pictureBoxAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddProduct.Image")));
            this.pictureBoxAddProduct.Location = new System.Drawing.Point(10, 15);
            this.pictureBoxAddProduct.Name = "pictureBoxAddProduct";
            this.pictureBoxAddProduct.Radius = 6;
            this.pictureBoxAddProduct.Size = new System.Drawing.Size(210, 210);
            this.pictureBoxAddProduct.TabIndex = 32;
            this.pictureBoxAddProduct.Text = "";
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
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.Transparent;
            this.datePicker.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.datePicker.BorderRadius = 6;
            this.datePicker.BorderThickness = 2;
            this.datePicker.CheckedState.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.datePicker.CheckedState.Parent = this.datePicker;
            this.datePicker.FillColor = System.Drawing.Color.White;
            this.datePicker.Font = new System.Drawing.Font("Satoshi", 12F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.HoveredState.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.datePicker.HoveredState.FillColor = System.Drawing.Color.White;
            this.datePicker.HoveredState.Parent = this.datePicker;
            this.datePicker.Location = new System.Drawing.Point(58, 270);
            this.datePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShadowDecoration.Parent = this.datePicker;
            this.datePicker.Size = new System.Drawing.Size(401, 55);
            this.datePicker.TabIndex = 31;
            this.datePicker.Value = new System.DateTime(2025, 5, 27, 0, 0, 0, 0);
            // 
            // resetBtn
            // 
            this.resetBtn.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.resetBtn.Font = new System.Drawing.Font("Satoshi", 12F);
            this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resetBtn.Location = new System.Drawing.Point(252, 602);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(132, 42);
            this.resetBtn.TabIndex = 30;
            this.resetBtn.Text = "Reset";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // siticoneLabel6
            // 
            this.siticoneLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel6.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel6.Location = new System.Drawing.Point(74, 59);
            this.siticoneLabel6.Name = "siticoneLabel6";
            this.siticoneLabel6.Size = new System.Drawing.Size(75, 22);
            this.siticoneLabel6.TabIndex = 29;
            this.siticoneLabel6.Text = "Item Code";
            // 
            // siticoneLabel5
            // 
            this.siticoneLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel5.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel5.Location = new System.Drawing.Point(74, 148);
            this.siticoneLabel5.Name = "siticoneLabel5";
            this.siticoneLabel5.Size = new System.Drawing.Size(77, 22);
            this.siticoneLabel5.TabIndex = 28;
            this.siticoneLabel5.Text = "Item Name";
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel4.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel4.Location = new System.Drawing.Point(74, 324);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(32, 22);
            this.siticoneLabel4.TabIndex = 27;
            this.siticoneLabel4.Text = "Qty.";
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.Location = new System.Drawing.Point(74, 411);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(38, 22);
            this.siticoneLabel3.TabIndex = 26;
            this.siticoneLabel3.Text = "Price";
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(74, 501);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(77, 22);
            this.siticoneLabel1.TabIndex = 25;
            this.siticoneLabel1.Text = "Total Price";
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.Location = new System.Drawing.Point(74, 236);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(107, 22);
            this.siticoneLabel2.TabIndex = 24;
            this.siticoneLabel2.Text = "Expiration Date";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.DecimalPlaces = 2;
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Font = new System.Drawing.Font("Satoshi", 12F);
            this.txtTotalPrice.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtTotalPrice.Location = new System.Drawing.Point(54, 529);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtTotalPrice.PlaceholderText = "";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(412, 55);
            this.txtTotalPrice.SuffixText = "";
            this.txtTotalPrice.TabIndex = 15;
            this.txtTotalPrice.Text = "0.00";
            this.txtTotalPrice.ThousandsSeparator = true;
            // 
            // txtPrice
            // 
            this.txtPrice.DecimalPlaces = 2;
            this.txtPrice.Font = new System.Drawing.Font("Satoshi", 12F);
            this.txtPrice.Location = new System.Drawing.Point(54, 439);
            this.txtPrice.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "Price";
            this.txtPrice.Size = new System.Drawing.Size(412, 55);
            this.txtPrice.SuffixText = "";
            this.txtPrice.TabIndex = 14;
            this.txtPrice.Text = "1.00";
            this.txtPrice.ThousandsSeparator = true;
            this.txtPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // addBtn
            // 
            this.addBtn.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(151)))), ((int)(((byte)(255)))));
            this.addBtn.Font = new System.Drawing.Font("Satoshi", 12F);
            this.addBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addBtn.Location = new System.Drawing.Point(114, 602);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(132, 42);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Satoshi", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(54, 352);
            this.txtQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "Quantity";
            this.txtQuantity.Size = new System.Drawing.Size(409, 55);
            this.txtQuantity.SuffixText = "";
            this.txtQuantity.TabIndex = 11;
            this.txtQuantity.Text = "1";
            this.txtQuantity.ThousandsSeparator = true;
            this.txtQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(56, 172);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderText = "\"Coke\"";
            this.txtProductName.Size = new System.Drawing.Size(672, 55);
            this.txtProductName.TabIndex = 7;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(57, 87);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PlaceholderText = "\"0001700D\"";
            this.txtProductCode.Size = new System.Drawing.Size(671, 55);
            this.txtProductCode.TabIndex = 6;
            this.txtProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCode_KeyPress);
            // 
            // titlebar
            // 
            this.titlebar.CloseSize = 30;
            this.titlebar.Controls.Add(this.siticoneControlBox1);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Font = new System.Drawing.Font("Satoshi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.MaximizeBox = false;
            this.titlebar.Name = "titlebar";
            this.titlebar.ShowIcon = true;
            this.titlebar.Size = new System.Drawing.Size(793, 27);
            this.titlebar.SubText = "";
            this.titlebar.TabIndex = 5;
            this.titlebar.Text = "Add Product";
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.Location = new System.Drawing.Point(748, -1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 6;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(813, 687);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProductForm";
            this.Padding = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.titlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.PageHeader titlebar;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private AntdUI.Input txtProductName;
        private AntdUI.Input txtProductCode;
        private AntdUI.InputNumber txtQuantity;
        private AntdUI.Button addBtn;
        private AntdUI.InputNumber txtPrice;
        private AntdUI.InputNumber txtTotalPrice;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel6;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel5;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel4;
        private AntdUI.Button resetBtn;
        private Siticone.UI.WinForms.SiticoneDateTimePicker datePicker;
        private AntdUI.Panel panel2;
        private AntdUI.Avatar pictureBoxAddProduct;
        private AntdUI.Button uploadBtn;
    }
}