namespace CSCISystem1._1
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            AntdUI.BreadcrumbItem breadcrumbItem2 = new AntdUI.BreadcrumbItem();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainpanelProduct = new AntdUI.Panel();
            this.panel3 = new AntdUI.Panel();
            this.filter = new AntdUI.Dropdown();
            this.txtSearchItem = new AntdUI.Input();
            this.panel2 = new AntdUI.Panel();
            this.breadcrumb1 = new AntdUI.Breadcrumb();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.AddProductBtn = new AntdUI.Button();
            this.panel1 = new AntdUI.Panel();
            this.labelAction = new AntdUI.Label();
            this.gridViewProductList = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.mainpanelProduct.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanelProduct
            // 
            this.mainpanelProduct.Back = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.mainpanelProduct.Controls.Add(this.panel3);
            this.mainpanelProduct.Controls.Add(this.panel2);
            this.mainpanelProduct.Controls.Add(this.panel1);
            this.mainpanelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanelProduct.Location = new System.Drawing.Point(10, 0);
            this.mainpanelProduct.Name = "mainpanelProduct";
            this.mainpanelProduct.Radius = 20;
            this.mainpanelProduct.Size = new System.Drawing.Size(942, 696);
            this.mainpanelProduct.TabIndex = 0;
            this.mainpanelProduct.Text = "panel1";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.filter);
            this.panel3.Controls.Add(this.txtSearchItem);
            this.panel3.Location = new System.Drawing.Point(0, 177);
            this.panel3.Name = "panel3";
            this.panel3.Radius = 10;
            this.panel3.RadiusAlign = AntdUI.TAlignRound.Top;
            this.panel3.Size = new System.Drawing.Size(942, 71);
            this.panel3.TabIndex = 11;
            this.panel3.Text = "panel3";
            // 
            // filter
            // 
            this.filter.AutoSizeMode = AntdUI.TAutoSize.Auto;
            this.filter.IconHoverSvg = "";
            this.filter.LoadingRespondClick = true;
            this.filter.Location = new System.Drawing.Point(315, 18);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(57, 38);
            this.filter.TabIndex = 8;
            this.filter.Text = "Filter";
            this.filter.ToggleIconHoverSvg = "";
            this.filter.ToggleIconSvg = "";
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItem.Location = new System.Drawing.Point(17, 18);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.PlaceholderText = "Search";
            this.txtSearchItem.PrefixSvg = "SearchOutlined";
            this.txtSearchItem.Radius = 10;
            this.txtSearchItem.Size = new System.Drawing.Size(292, 38);
            this.txtSearchItem.TabIndex = 7;
            this.txtSearchItem.WaveSize = 0;
            this.txtSearchItem.TextChanged += new System.EventHandler(this.txtSearchItem_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.breadcrumb1);
            this.panel2.Controls.Add(this.siticoneLabel1);
            this.panel2.Controls.Add(this.AddProductBtn);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Radius = 10;
            this.panel2.Size = new System.Drawing.Size(942, 161);
            this.panel2.TabIndex = 10;
            this.panel2.Text = "panel2";
            // 
            // breadcrumb1
            // 
            this.breadcrumb1.BackColor = System.Drawing.Color.Transparent;
            this.breadcrumb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            breadcrumbItem1.Icon = ((System.Drawing.Image)(resources.GetObject("breadcrumbItem1.Icon")));
            breadcrumbItem1.LocalizationText = "homebread";
            breadcrumbItem1.Text = "Home";
            breadcrumbItem2.LocalizationText = "productbread";
            breadcrumbItem2.Text = "Product";
            this.breadcrumb1.Items.Add(breadcrumbItem1);
            this.breadcrumb1.Items.Add(breadcrumbItem2);
            this.breadcrumb1.Location = new System.Drawing.Point(38, 20);
            this.breadcrumb1.Name = "breadcrumb1";
            this.breadcrumb1.Size = new System.Drawing.Size(873, 40);
            this.breadcrumb1.TabIndex = 10;
            this.breadcrumb1.Text = "breadcrumb1";

            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Satoshi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.Location = new System.Drawing.Point(38, 84);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(123, 42);
            this.siticoneLabel1.TabIndex = 9;
            this.siticoneLabel1.Text = "Product";
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductBtn.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddProductBtn.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AddProductBtn.Icon = ((System.Drawing.Image)(resources.GetObject("AddProductBtn.Icon")));
            this.AddProductBtn.IconRatio = 1F;
            this.AddProductBtn.IconSize = new System.Drawing.Size(25, 25);
            this.AddProductBtn.Location = new System.Drawing.Point(732, 87);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Radius = 9;
            this.AddProductBtn.Size = new System.Drawing.Size(179, 39);
            this.AddProductBtn.TabIndex = 2;
            this.AddProductBtn.Text = "New Product";
            this.AddProductBtn.WaveSize = 1;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Back = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.labelAction);
            this.panel1.Controls.Add(this.gridViewProductList);
            this.panel1.Location = new System.Drawing.Point(0, 248);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Radius = 10;
            this.panel1.RadiusAlign = AntdUI.TAlignRound.Bottom;
            this.panel1.Size = new System.Drawing.Size(942, 448);
            this.panel1.TabIndex = 6;
            this.panel1.Text = "panel1";
            // 
            // labelAction
            // 
            this.labelAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.labelAction.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAction.Location = new System.Drawing.Point(869, 11);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(53, 23);
            this.labelAction.TabIndex = 10;
            this.labelAction.Text = "";
            // 
            // gridViewProductList
            // 
            this.gridViewProductList.AllowUserToAddRows = false;
            this.gridViewProductList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridViewProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewProductList.BackgroundColor = System.Drawing.Color.White;
            this.gridViewProductList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewProductList.ColumnHeadersHeight = 40;
            this.gridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewProductList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewProductList.EnableHeadersVisualStyles = false;
            this.gridViewProductList.GridColor = System.Drawing.Color.White;
            this.gridViewProductList.Location = new System.Drawing.Point(20, 0);
            this.gridViewProductList.MultiSelect = false;
            this.gridViewProductList.Name = "gridViewProductList";
            this.gridViewProductList.ReadOnly = true;
            this.gridViewProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridViewProductList.RowHeadersVisible = false;
            this.gridViewProductList.RowTemplate.Height = 40;
            this.gridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewProductList.Size = new System.Drawing.Size(902, 419);
            this.gridViewProductList.TabIndex = 4;
            this.gridViewProductList.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewProductList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewProductList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridViewProductList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gridViewProductList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.gridViewProductList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewProductList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewProductList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViewProductList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewProductList.ThemeStyle.HeaderStyle.Height = 40;
            this.gridViewProductList.ThemeStyle.ReadOnly = true;
            this.gridViewProductList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewProductList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewProductList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewProductList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViewProductList.ThemeStyle.RowsStyle.Height = 40;
            this.gridViewProductList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridViewProductList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridViewProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewProductList_CellClick_1);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(952, 696);
            this.Controls.Add(this.mainpanelProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.mainpanelProduct.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel mainpanelProduct;
        private AntdUI.Button AddProductBtn;
        private AntdUI.Panel panel1;
        private Siticone.UI.WinForms.SiticoneDataGridView gridViewProductList;
        private AntdUI.Input txtSearchItem;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private AntdUI.Panel panel2;
        private AntdUI.Panel panel3;
        private AntdUI.Dropdown filter;
        private AntdUI.Label labelAction;
        private AntdUI.Breadcrumb breadcrumb1;
    }
}