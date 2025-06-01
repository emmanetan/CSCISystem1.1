using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using Microsoft.Data.SqlClient;
using CSCISystem1._1;
using static System.Net.WebRequestMethods;
using LoginSignup;

namespace AntdUIDemo
{
    public partial class POS : AntdUI.Window
    {
        private string _cashierName;
        private Image _profileImage;
        public bool IsAuthenticated { get; private set; }

        // This is your global connection string

        SqlConnection con =
            new SqlConnection(
                @"Data Source=EMMAN\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        public POS()
        {
            InitializeComponent();
            LoadMoP();
        }

        public POS(string cashierName, Image profileImage)
        {
            InitializeComponent();
            _cashierName = cashierName;
            _profileImage = profileImage;
            LoadMoP();
        }

        private void LoadMoP()
        {
            mopDropdown.Items.Add("Cash");
            mopDropdown.SelectedIndex = 0;
            txtBarcode.Focus();
        }

        private void LoadCartHeader()
        {
            siticoneDataGridView2.Columns.Clear();
            siticoneDataGridView2.Rows.Clear();
            siticoneDataGridView2.Columns.Add("ItemName", "Item");
            siticoneDataGridView2.Columns.Add("Qty", "Qty.");
            siticoneDataGridView2.Columns.Add("Price", "Price");
        }

        private void POS_Load(object sender, EventArgs e)
        {
            labelUser.Text = _cashierName;

            if (_profileImage != null)
            {
                circlePictureBoxUser.Image = _profileImage;
                circlePictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage; // optional
            }

            LoadReceipt();
            LoadProductDataHeader();
            LoadProductDatabase();
            LoadCartHeader();


            txtBarcode.KeyDown += txtBarcode_KeyDown;
        }

        private void SearchProducts(string searchText)
        {
            try
            {
                gridDataProductList.Rows.Clear();
                con.Open();

                string query = @"SELECT ProductCode, ProductName, Quantity, Price, Image
                         FROM tb_product
                         WHERE ProductCode LIKE @search OR ProductName LIKE @search";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    object imageObj = reader["Image"];
                    Image img = null;

                    if (imageObj != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])imageObj;
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            img = Image.FromStream(ms);
                        }
                    }

                    gridDataProductList.Rows.Add(
                        reader["ProductCode"].ToString(),
                        reader["ProductName"].ToString(),
                        reader["Quantity"].ToString(),
                        reader["Price"].ToString(),
                        img
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void LoadReceipt()
        {
            receiptTextBox.Clear();
            receiptTextBox.Text += "                    STOREFLOW\n";
            receiptTextBox.Text += "           Brgy. 2, Legazpi City 4500\n";
            receiptTextBox.Text += "                 Tel: 999-685-0001\n";
            receiptTextBox.Text += "-----------------------------------------\n";
            receiptTextBox.Text += $"Cashier: {_cashierName}\n";
            receiptTextBox.Text += $"Date: {DateTime.Now:MMMM dd, yyyy hh:mm tt}\n";
            receiptTextBox.Text += "-----------------------------------------\n";
            receiptTextBox.Text += "Item                 Qty  Price   Subtotal\n";
            receiptTextBox.Text += "-----------------------------------------\n";

            decimal subtotal = 0;

            foreach (DataGridViewRow row in siticoneDataGridView2.Rows)
            {
                if (row.Cells["ItemName"].Value != null)
                {
                    string name = row.Cells["ItemName"].Value.ToString();
                    int qty = Convert.ToInt32(row.Cells["Qty"].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells["Price"].Value) / qty;
                    decimal itemTotal = unitPrice * qty;

                    subtotal += itemTotal;

                    receiptTextBox.Text +=
                        $"{name.PadRight(16).Substring(0, 16)} {qty,3}  ₱{unitPrice,6:0.00}  ₱{itemTotal,6:0.00}\n";
                }
            }

            decimal tax = subtotal * 0.12m;
            decimal total = subtotal + tax;

            receiptTextBox.Text += "-----------------------------------------\n";
            receiptTextBox.Text += $"Subtotal:" + $"₱{subtotal,7:0.00}\n";
            receiptTextBox.Text += $"VAT (12%):" + $"₱{tax,7:0.00}\n";
            receiptTextBox.Text += $"Total:" + $"₱{total,7:0.00}\n";

            // 🟢 Add cash and change here
            if (decimal.TryParse(txtCash.Text, out decimal cash))
            {
                decimal change = cash - total;
                receiptTextBox.Text += $"Cash:" + $"₱{cash,7:0.00}\n";
                receiptTextBox.Text += $"Change:" + $"₱{(change >= 0 ? change : 0),7:0.00}\n";
            }
            else
            {
                receiptTextBox.Text += $"Cash:" + $"₱0.00\n";
                receiptTextBox.Text += $"Change:" + $"₱0.00\n";
            }

            receiptTextBox.Text += "-----------------------------------------\n";
            receiptTextBox.Text += "       Thank you for shopping!\n";
            receiptTextBox.Text += "    This serves as your receipt.\n";
        }


        private void LoadProductDataHeader()
        {
            gridDataProductList.Columns.Clear();
            gridDataProductList.Rows.Clear();

            gridDataProductList.Columns.Add("ProductCode", "Item Code");
            gridDataProductList.Columns.Add("ProductName", "Item Name");
            gridDataProductList.Columns.Add("Quantity", "Stock");
            gridDataProductList.Columns.Add("Price", "Unit Price");
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "ImageProduct";
            imgCol.HeaderText = "              Image";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            gridDataProductList.Columns.Add(imgCol);
        }
        // added by zeus pogi

        private void UpdateTotals()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in siticoneDataGridView2.Rows)
            {
                if (row.Cells["Price"].Value != null &&
                    decimal.TryParse(row.Cells["Price"].Value.ToString(), out decimal price))
                {
                    subtotal += price;
                }
            }

            decimal tax = subtotal * 0.12m;
            decimal total = subtotal + tax;

            input4.Text = "₱" + subtotal.ToString("0.00"); // Subtotal
            input5.Text = "₱" + tax.ToString("0.00"); // Tax
            input6.Text = "₱" + total.ToString("0.00"); // Total
        }

        private void gridDataProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string name = gridDataProductList.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                decimal price = Convert.ToDecimal(gridDataProductList.Rows[e.RowIndex].Cells["Price"].Value);

                // Get available stock from grid
                
                // You must ensure Quantity is added as a column in gridDataProductList
                int availableQty = 0;
                if (gridDataProductList.Columns.Contains("Quantity"))
                {
                    availableQty = Convert.ToInt32(gridDataProductList.Rows[e.RowIndex].Cells["Quantity"].Value);
                }
                else
                {
                    MessageBox.Show("Quantity column not found in grid.");
                    return;
                    LoadProductDatabase();
                }

                bool found = false;
                foreach (DataGridViewRow row in siticoneDataGridView2.Rows)
                {
                    if (row.Cells["ItemName"].Value?.ToString() == name)
                    {
                        int qtyInCart = Convert.ToInt32(row.Cells["Qty"].Value);
                        if (qtyInCart + 1 > availableQty)
                        {
                            MessageBox.Show("Cannot add more. Stock limit reached.");
                            return;
                        }

                        row.Cells["Qty"].Value = qtyInCart + 1;
                        row.Cells["Price"].Value = (qtyInCart + 1) * price;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    if (availableQty < 1)
                    {
                        MessageBox.Show("Out of stock.");
                        return;
                    }

                    siticoneDataGridView2.Rows.Add(name, 1, price);
                }

                UpdateTotals();
                LoadReceipt();
                
            }
        }

        private void LoadProductDatabase()
        {
            using (SqlConnection localCon =
                   new SqlConnection(
                       @"Data Source=EMMAN\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                try
                {
                    localCon.Open();
                    string query =
                        "SELECT ProductCode, ProductName, ExpDate, Quantity, Price, TotalPrice, Image FROM tb_product";

                    using (SqlCommand cmd = new SqlCommand(query, localCon))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        gridDataProductList.Rows.Clear(); // clear existing rows
                        while (reader.Read())
                        {
                            object imageObj = reader["Image"];
                            Image img = null;

                            if (imageObj != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])imageObj;
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    img = Image.FromStream(ms);
                                }
                            }

                            gridDataProductList.Rows.Add(
                                reader["ProductCode"].ToString(),
                                reader["ProductName"].ToString(),
                                reader["Quantity"].ToString(),
                                reader["Price"].ToString(),
                                img
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void RemoveVoidBtn(object sender, EventArgs e)
        {
            AdminLogin loginForm = new AdminLogin();
            DialogResult result = loginForm.ShowDialog();

            if (result == DialogResult.OK && loginForm.IsAuthenticated)
            {
                foreach (DataGridViewRow row in siticoneDataGridView2.SelectedRows)
                {
                    siticoneDataGridView2.Rows.Remove(row);
                }

                MessageBox.Show("Item removed by admin.");
                UpdateTotals();
                LoadReceipt();
            }
            else
            {
                MessageBox.Show("Action canceled or unauthorized.", "Not Authorized", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txtSearchItem.Text.Trim());
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = txtBarcode.Text.Trim();
                if (!string.IsNullOrEmpty(barcode))
                {
                    AddItemToCartFromBarcode(barcode);
                    txtBarcode.Clear(); // ready for next scan
                }
            }
        }

        private void AddItemToCartFromBarcode(string barcode)
        {
            try
            {
                con.Open();
                string query = "SELECT ProductName, Quantity, Price FROM tb_product WHERE ProductCode = @code";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@code", barcode);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string name = reader["ProductName"].ToString();
                        int stock = Convert.ToInt32(reader["Quantity"]);
                        decimal price = Convert.ToDecimal(reader["Price"]);

                        // Check if already in cart
                        bool found = false;
                        foreach (DataGridViewRow row in siticoneDataGridView2.Rows)
                        {
                            if (row.Cells["ItemName"].Value?.ToString() == name)
                            {
                                int qtyInCart = Convert.ToInt32(row.Cells["Qty"].Value);
                                if (qtyInCart + 1 > stock)
                                {
                                    MessageBox.Show("Cannot add more. Stock limit reached.");
                                    return;
                                }

                                row.Cells["Qty"].Value = qtyInCart + 1;
                                row.Cells["Price"].Value = (qtyInCart + 1) * price;
                                found = true;
                                break;
                            }
                        }

                        if (!found)
                        {
                            if (stock < 1)
                            {
                                MessageBox.Show("Out of stock.");
                                return;
                            }

                            siticoneDataGridView2.Rows.Add(name, 1, price);
                        }

                        UpdateTotals();
                        LoadReceipt();
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error scanning barcode: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            if (mopDropdown.SelectedValue == null) // safer than .SelectedValue
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            if (!decimal.TryParse(txtCash.Text, out decimal cash))
            {
                MessageBox.Show("Invalid cash amount.");
                return;
            }

            decimal total = decimal.Parse(input6.Text.Replace("₱", ""));
            if (cash < total)
            {
                MessageBox.Show("Insufficient cash.");
                return;
            }

            foreach (DataGridViewRow row in siticoneDataGridView2.Rows)
            {
                if (row.Cells["ItemName"].Value != null)
                {
                    string name = row.Cells["ItemName"].Value.ToString();
                    int qty = Convert.ToInt32(row.Cells["Qty"].Value);
                    double unitPrice = 0;

                    // Find the unit price from the product list
                    foreach (DataGridViewRow gridRow in gridDataProductList.Rows)
                    {
                        if (gridRow.Cells["ProductName"].Value?.ToString() == name)
                        {
                            unitPrice = Convert.ToDouble(gridRow.Cells["Price"].Value);
                            break;
                        }
                    }

                    InventoryReport.AddSoldItem(name, qty, unitPrice);
                }
            }


            try
            {
                con.Open(); // This uses the global 'con' connection

                foreach (DataGridViewRow row in siticoneDataGridView2.Rows)
                {
                    string productName = row.Cells["ItemName"].Value.ToString();
                    int qtyPurchased = Convert.ToInt32(row.Cells["Qty"].Value);
                    double unitPrice =
                        Convert.ToDouble(row.Cells["Price"].Value) / qtyPurchased; // Calculate unit price

                    string updateQuery = @"
                        UPDATE tb_product
                        SET Quantity = Quantity - @Qty
                        WHERE ProductName = @Name AND Quantity >= @Qty";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Qty", qtyPurchased);
                        cmd.Parameters.AddWithValue("@Name", productName);



                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show($"Error updating stock for {productName}. It may be out of stock.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating stock: " + ex.Message);
            }
            finally
            {
                // Make sure the connection is closed even if there's an error
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }

            // Step 4: Clear UI and reload stock
            MessageBox.Show("Payment Successful!");
            siticoneDataGridView2.Rows.Clear();
            txtCash.Text = "";
            input3.Text = "₱0.00";
            UpdateTotals();
            LoadReceipt();
            LoadProductDatabase(); // Reload product list with updated stock



        }

        private void txtCash_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCash.Text, out decimal cash))
            {
                decimal total = decimal.Parse(input6.Text.Replace("₱", ""));
                decimal change = cash - total;
                input3.Text = "₱" + (change >= 0 ? change.ToString("0.00") : "0.00");
            }
            else
            {
                input3.Text = "₱0.00";
            }
            LoadReceipt();
        }

        private void siticoneRoundedButton7_Click(object sender, EventArgs e)
        {

            //Logout
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}
    
