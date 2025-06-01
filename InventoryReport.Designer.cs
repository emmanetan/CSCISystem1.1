using System;

namespace CSCISystem1._1
{
    partial class InventoryReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            AntdUI.BreadcrumbItem breadcrumbItem1 = new AntdUI.BreadcrumbItem();
            AntdUI.BreadcrumbItem breadcrumbItem2 = new AntdUI.BreadcrumbItem();
            this.panel5 = new AntdUI.Panel();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel2 = new AntdUI.Panel();
            this.gridViewSoldList = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.txtSearchSoldItem = new AntdUI.Input();
            this.DownloadBtn = new AntdUI.Button();
            this.panel4 = new AntdUI.Panel();
            this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel3 = new AntdUI.Panel();
            this.DownloadRemovedItemBtn = new AntdUI.Button();
            this.txtSearchRemovedItem = new AntdUI.Input();
            this.gridViewRemovedList = new Siticone.UI.WinForms.SiticoneDataGridView();
            this.panel6 = new AntdUI.Panel();
            this.breadcrumb1 = new AntdUI.Breadcrumb();
            this.siticoneLabel4 = new Siticone.UI.WinForms.SiticoneLabel();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSoldList)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRemovedList)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.siticoneLabel2);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Location = new System.Drawing.Point(12, 185);
            this.panel5.Name = "panel5";
            this.panel5.Radius = 10;
            this.panel5.Size = new System.Drawing.Size(924, 169);
            this.panel5.TabIndex = 16;
            this.panel5.Text = "panel5";
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel2.Location = new System.Drawing.Point(26, 27);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(73, 22);
            this.siticoneLabel2.TabIndex = 13;
            this.siticoneLabel2.Text = "Sold Item";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Back = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.gridViewSoldList);
            this.panel2.Controls.Add(this.txtSearchSoldItem);
            this.panel2.Controls.Add(this.DownloadBtn);
            this.panel2.Location = new System.Drawing.Point(11, 51);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Radius = 20;
            this.panel2.Size = new System.Drawing.Size(898, 95);
            this.panel2.TabIndex = 11;
            this.panel2.Text = "panel2";
            // 
            // gridViewSoldList
            // 
            this.gridViewSoldList.AllowUserToAddRows = false;
            this.gridViewSoldList.AllowUserToResizeColumns = false;
            this.gridViewSoldList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridViewSoldList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewSoldList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewSoldList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewSoldList.BackgroundColor = System.Drawing.Color.White;
            this.gridViewSoldList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewSoldList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewSoldList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewSoldList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewSoldList.ColumnHeadersHeight = 40;
            this.gridViewSoldList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Satoshi", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewSoldList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewSoldList.EnableHeadersVisualStyles = false;
            this.gridViewSoldList.GridColor = System.Drawing.Color.White;
            this.gridViewSoldList.Location = new System.Drawing.Point(0, 64);
            this.gridViewSoldList.Name = "gridViewSoldList";
            this.gridViewSoldList.ReadOnly = true;
            this.gridViewSoldList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridViewSoldList.RowHeadersVisible = false;
            this.gridViewSoldList.RowTemplate.Height = 30;
            this.gridViewSoldList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewSoldList.Size = new System.Drawing.Size(901, 39);
            this.gridViewSoldList.TabIndex = 4;
            this.gridViewSoldList.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridViewSoldList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewSoldList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewSoldList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewSoldList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewSoldList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewSoldList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridViewSoldList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gridViewSoldList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.gridViewSoldList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewSoldList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridViewSoldList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViewSoldList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewSoldList.ThemeStyle.HeaderStyle.Height = 40;
            this.gridViewSoldList.ThemeStyle.ReadOnly = true;
            this.gridViewSoldList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewSoldList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewSoldList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Satoshi", 11.25F);
            this.gridViewSoldList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViewSoldList.ThemeStyle.RowsStyle.Height = 30;
            this.gridViewSoldList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridViewSoldList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // txtSearchSoldItem
            // 
            this.txtSearchSoldItem.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSoldItem.Location = new System.Drawing.Point(0, 10);
            this.txtSearchSoldItem.Name = "txtSearchSoldItem";
            this.txtSearchSoldItem.PlaceholderText = "Search";
            this.txtSearchSoldItem.PrefixSvg = "SearchOutlined";
            this.txtSearchSoldItem.Radius = 10;
            this.txtSearchSoldItem.Size = new System.Drawing.Size(292, 38);
            this.txtSearchSoldItem.TabIndex = 14;
            this.txtSearchSoldItem.WaveSize = 0;
            this.txtSearchSoldItem.TextChanged += new System.EventHandler(this.txtSearchSoldItem_TextChanged);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadBtn.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(40)))));
            this.DownloadBtn.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBtn.Icon = ((System.Drawing.Image)(resources.GetObject("DownloadBtn.Icon")));
            this.DownloadBtn.IconRatio = 1F;
            this.DownloadBtn.IconSize = new System.Drawing.Size(15, 15);
            this.DownloadBtn.Location = new System.Drawing.Point(820, 9);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Radius = 9;
            this.DownloadBtn.Size = new System.Drawing.Size(43, 39);
            this.DownloadBtn.TabIndex = 2;
            this.DownloadBtn.WaveSize = 1;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.siticoneLabel3);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(12, 371);
            this.panel4.Name = "panel4";
            this.panel4.Radius = 10;
            this.panel4.Size = new System.Drawing.Size(924, 286);
            this.panel4.TabIndex = 15;
            this.panel4.Text = "panel4";
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel3.Location = new System.Drawing.Point(26, 20);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(112, 22);
            this.siticoneLabel3.TabIndex = 14;
            this.siticoneLabel3.Text = "Removed Item";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Back = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.DownloadRemovedItemBtn);
            this.panel3.Controls.Add(this.txtSearchRemovedItem);
            this.panel3.Controls.Add(this.gridViewRemovedList);
            this.panel3.Location = new System.Drawing.Point(11, 31);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Radius = 20;
            this.panel3.Size = new System.Drawing.Size(898, 232);
            this.panel3.TabIndex = 12;
            this.panel3.Text = "panel3";
            // 
            // DownloadRemovedItemBtn
            // 
            this.DownloadRemovedItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadRemovedItemBtn.DefaultBack = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(40)))));
            this.DownloadRemovedItemBtn.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadRemovedItemBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadRemovedItemBtn.Icon = ((System.Drawing.Image)(resources.GetObject("DownloadRemovedItemBtn.Icon")));
            this.DownloadRemovedItemBtn.IconRatio = 1F;
            this.DownloadRemovedItemBtn.IconSize = new System.Drawing.Size(15, 15);
            this.DownloadRemovedItemBtn.Location = new System.Drawing.Point(820, 22);
            this.DownloadRemovedItemBtn.Name = "DownloadRemovedItemBtn";
            this.DownloadRemovedItemBtn.Radius = 9;
            this.DownloadRemovedItemBtn.Size = new System.Drawing.Size(43, 39);
            this.DownloadRemovedItemBtn.TabIndex = 11;
            this.DownloadRemovedItemBtn.WaveSize = 1;
            this.DownloadRemovedItemBtn.Click += new System.EventHandler(this.DownloadRemovedItemBtn_Click);
            // 
            // txtSearchRemovedItem
            // 
            this.txtSearchRemovedItem.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRemovedItem.Location = new System.Drawing.Point(0, 23);
            this.txtSearchRemovedItem.Name = "txtSearchRemovedItem";
            this.txtSearchRemovedItem.PlaceholderText = "Search";
            this.txtSearchRemovedItem.PrefixSvg = "SearchOutlined";
            this.txtSearchRemovedItem.Radius = 10;
            this.txtSearchRemovedItem.Size = new System.Drawing.Size(292, 38);
            this.txtSearchRemovedItem.TabIndex = 9;
            this.txtSearchRemovedItem.WaveSize = 0;
            this.txtSearchRemovedItem.TextChanged += new System.EventHandler(this.txtSearchRemovedItem_TextChanged);
            // 
            // gridViewRemovedList
            // 
            this.gridViewRemovedList.AllowUserToAddRows = false;
            this.gridViewRemovedList.AllowUserToResizeColumns = false;
            this.gridViewRemovedList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridViewRemovedList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewRemovedList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewRemovedList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewRemovedList.BackgroundColor = System.Drawing.Color.White;
            this.gridViewRemovedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewRemovedList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewRemovedList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewRemovedList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewRemovedList.ColumnHeadersHeight = 40;
            this.gridViewRemovedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Satoshi", 11.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewRemovedList.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewRemovedList.EnableHeadersVisualStyles = false;
            this.gridViewRemovedList.GridColor = System.Drawing.Color.White;
            this.gridViewRemovedList.Location = new System.Drawing.Point(0, 76);
            this.gridViewRemovedList.Name = "gridViewRemovedList";
            this.gridViewRemovedList.ReadOnly = true;
            this.gridViewRemovedList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridViewRemovedList.RowHeadersVisible = false;
            this.gridViewRemovedList.RowTemplate.Height = 30;
            this.gridViewRemovedList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewRemovedList.Size = new System.Drawing.Size(901, 166);
            this.gridViewRemovedList.TabIndex = 4;
            this.gridViewRemovedList.Theme = Siticone.UI.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gridViewRemovedList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewRemovedList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewRemovedList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewRemovedList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewRemovedList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewRemovedList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridViewRemovedList.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gridViewRemovedList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.gridViewRemovedList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewRemovedList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Satoshi", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridViewRemovedList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViewRemovedList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewRemovedList.ThemeStyle.HeaderStyle.Height = 40;
            this.gridViewRemovedList.ThemeStyle.ReadOnly = true;
            this.gridViewRemovedList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewRemovedList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewRemovedList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Satoshi", 11.25F);
            this.gridViewRemovedList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gridViewRemovedList.ThemeStyle.RowsStyle.Height = 30;
            this.gridViewRemovedList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.gridViewRemovedList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.breadcrumb1);
            this.panel6.Controls.Add(this.siticoneLabel4);
            this.panel6.Location = new System.Drawing.Point(12, 0);
            this.panel6.Name = "panel6";
            this.panel6.Radius = 10;
            this.panel6.Size = new System.Drawing.Size(924, 168);
            this.panel6.TabIndex = 11;
            this.panel6.Text = "panel6";
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
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel4.Font = new System.Drawing.Font("Satoshi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel4.Location = new System.Drawing.Point(38, 84);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(256, 42);
            this.siticoneLabel4.TabIndex = 9;
            this.siticoneLabel4.Text = "Inventory Report";
            // 
            // InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(936, 657);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventoryReport_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSoldList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRemovedList)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private AntdUI.Panel panel3;
        private Siticone.UI.WinForms.SiticoneDataGridView gridViewRemovedList;
        private AntdUI.Panel panel2;
        private Siticone.UI.WinForms.SiticoneDataGridView gridViewSoldList;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;
        private AntdUI.Panel panel4;
        private AntdUI.Panel panel5;
        private AntdUI.Panel panel6;
        private AntdUI.Breadcrumb breadcrumb1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel4;
        private AntdUI.Button DownloadBtn;
        private AntdUI.Input txtSearchSoldItem;
        private AntdUI.Input txtSearchRemovedItem;
        private AntdUI.Button DownloadRemovedItemBtn;
    }
}