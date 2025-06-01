using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Management; 
using System.Windows.Forms;
using AntdUI;
using AntdUIDemo;
using LoginSignup;
using Microsoft.Data.SqlClient;

namespace CSCISystem1._1
{

    public partial class Product : Form
    {
        string firstname;
        string userType;
        Image profileImage;
        SqlConnection con = new SqlConnection(@"Data Source=EMMAN\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        SqlCommand cmd;

        public Product()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadFilter();
            labelAction.Text = "Action";
        }

        private void InitializeDataGridView()
        {
            gridViewProductList.Columns.Clear();
            gridViewProductList.Rows.Clear();

            gridViewProductList.Columns.Add("ProductCode", "Item Code");
            gridViewProductList.Columns.Add("ProductName", "Item Name");
            gridViewProductList.Columns.Add("ExpDate", "Expiration Date"); // Corrected for consistency below
            gridViewProductList.Columns.Add("Quantity", "Qty");
            gridViewProductList.Columns.Add("Price", "Unit Price");
            gridViewProductList.Columns.Add("TotalPrice", "Total Price");
            // hand cursor for the edit and delete buttons
            gridViewProductList.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0 && (e.ColumnIndex == gridViewProductList.Columns["EditAction"].Index ||
                                        e.ColumnIndex == gridViewProductList.Columns["DeleteAction"].Index))
                {
                    gridViewProductList.Cursor = Cursors.Hand;
                }
            };

            gridViewProductList.CellMouseLeave += (s, e) =>
            {
                gridViewProductList.Cursor = Cursors.Default;
            };

            //edit button
            var editButton = new DataGridViewImageColumn
            {
                Name = "EditAction",
                HeaderText = "", 
                Image = Image.FromFile(@"C:\Users\emman\Downloads\Icon\edit20.png"),
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                
            };
            gridViewProductList.Columns.Add(editButton);

            //delete button
            var deleteButton = new DataGridViewImageColumn
            {
                Name = "DeleteAction",
                HeaderText = "",
                Image = Image.FromFile(@"C:\Users\emman\Downloads\Icon\delete30r.png"),
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            gridViewProductList.Columns.Add(deleteButton);

            LoadProductData();
        }

        private void LoadProductData()
        {
            try
            {
                con.Open();
                string query = "SELECT ProductCode, ProductName, ExpDate, Quantity, Price, TotalPrice FROM tb_product";
                cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    gridViewProductList.Rows.Add(
                        reader["ProductCode"].ToString(),
                        reader["ProductName"].ToString(),
                        Convert.ToDateTime(reader["ExpDate"]).ToString("yyyy-MM-dd"),
                        reader["Quantity"].ToString(),
                        reader["Price"].ToString(),
                        reader["TotalPrice"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void DeleteProductFromDatabase(string productCode)
        {
            try
            {
                con.Open();
                string deleteQuery = "DELETE FROM tb_product WHERE ProductCode = @ProductCode";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);
                deleteCmd.Parameters.AddWithValue("@ProductCode", productCode);
                deleteCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadFilter()
        {
            filter.Items.Add("All");
            filter.Items.Add("Item Code");
            filter.Items.Add("Item Name");
            filter.Items.Add("ExpDate");
        }
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            InitializeDataGridView();
        }

        private void gridViewProductList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string productCode = gridViewProductList.Rows[e.RowIndex].Cells["ProductCode"].Value.ToString();
            
            // Ensure a valid row is clicked and it's the "DeleteAction" column
            if (e.RowIndex >= 0 && gridViewProductList.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                // Get the clicked row
                var row = gridViewProductList.Rows[e.RowIndex];

                
                // THESE NAMES MUST MATCH THE FIRST STRING (NAME) OF THE COLUMNS ADDED IN InitializeDataGridView().
                // Also, ensure they match the InventoryReport.AddRemovedItem parameter order.
                string itemCode = row.Cells["ProductCode"].Value.ToString(); // Changed: "ItemCode" to "ProductCode"
                string itemName = row.Cells["ProductName"].Value.ToString(); // Changed: "ItemName" to "ProductName"
                int qty = int.Parse(row.Cells["Quantity"].Value.ToString());
                double unitPrice = double.Parse(row.Cells["Price"].Value.ToString()); // Changed: "UnitPrice" to "Price"
                DateTime expDate = DateTime.Parse(row.Cells["ExpDate"].Value.ToString()); // Changed: "ExpirationDate" to "ExpDate"

                // Send to InventoryReport.cs
                // This call uses the parameters that match InventoryReport's AddRemovedItem
                InventoryReport.AddRemovedItem(itemCode, itemName, qty, unitPrice, expDate);

                // Confirm and remove from grid
                DialogResult result = MessageBox.Show($"Are you sure you want to remove {itemName}?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    gridViewProductList.Rows.RemoveAt(e.RowIndex);
                    // Also delete from database if that's the intended action here
                    DeleteProductFromDatabase(itemCode);
                }
            }if (e.RowIndex >= 0 && gridViewProductList.Columns[e.ColumnIndex].Name == "EditAction")
            {

                EditProductForm editProduct = new EditProductForm(productCode);
                editProduct.ShowDialog();

                // reload after editing
                InitializeDataGridView();
            }
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txtSearchItem.Text.Trim());
        }

        private void SearchProducts(string searchText)
        {
            try
            {
                gridViewProductList.Rows.Clear();
                con.Open();

                string query = "";
                string column = "";

                if (filter.SelectedValue == null || filter.SelectedValue.ToString() == "All")
                {
                    query = @"SELECT ProductCode, ProductName, ExpDate, Quantity, Price, TotalPrice
                      FROM tb_product
                      WHERE ProductCode LIKE @search OR ProductName LIKE @search";
                }
                else
                {
                    column = filter.SelectedValue.ToString();
                    query = $@"SELECT ProductCode, ProductName, ExpDate, Quantity, Price, TotalPrice
                       FROM tb_product
                       WHERE {column} LIKE @search";
                }

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    gridViewProductList.Rows.Add(
                        reader["ProductCode"].ToString(),
                        reader["ProductName"].ToString(),
                        Convert.ToDateTime(reader["ExpDate"]).ToString("yyyy-MM-dd"),
                        reader["Quantity"].ToString(),
                        reader["Price"].ToString(),
                        reader["TotalPrice"].ToString()
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

        
    }
}