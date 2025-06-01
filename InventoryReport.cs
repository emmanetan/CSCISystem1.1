using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace CSCISystem1._1
{
    public partial class InventoryReport : Form
    {
        private static DataTable soldItemsTable = new DataTable();
        private static DataTable removedItemsTable = new DataTable();

        private static string connectionString = "Data Source=EMMAN\\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        
        static InventoryReport()
        {
            if (soldItemsTable.Columns.Count == 0)
            {
                soldItemsTable.Columns.Add("Item Name", typeof(string));
                soldItemsTable.Columns.Add("Quantity", typeof(int));
                soldItemsTable.Columns.Add("Date Sold", typeof(DateTime));
                soldItemsTable.Columns.Add("Unit Price", typeof(double));
            }

            if (removedItemsTable.Columns.Count == 0)
            {
                removedItemsTable.Columns.Add("Item Code", typeof(string));
                removedItemsTable.Columns.Add("Item Name", typeof(string));
                removedItemsTable.Columns.Add("Quantity", typeof(int));
                removedItemsTable.Columns.Add("Unit Price", typeof(double));
                removedItemsTable.Columns.Add("Expiration Date", typeof(DateTime));
                removedItemsTable.Columns.Add("Date Removed", typeof(DateTime));
            }
        }

        public InventoryReport()
        {
            InitializeComponent();
            gridViewSoldList.DataSource = soldItemsTable;
            gridViewRemovedList.DataSource = removedItemsTable;
           
        }
        public static void AddSoldItem(string itemName, int quantity, double unitPrice)
        {
            soldItemsTable.Rows.Add(itemName, quantity, DateTime.Now, unitPrice);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO tb_soldItems (ItemName, Quantity, DateSold, UnitPrice) VALUES (@ItemName, @Quantity, @DateSold, @UnitPrice)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@DateSold", DateTime.Now);
                    cmd.Parameters.AddWithValue("@UnitPrice",unitPrice);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // NEW: Public static method to allow other classes (like SalesReport) to access soldItemsTable.
        public static DataTable GetSoldItemsTable()
        {
            return soldItemsTable;
        }

        // NEW: Public static method to allow other classes to access removedItemsTable (for consistency).
        public static DataTable GetRemovedItemsTable()
        {
            return removedItemsTable;
        }

        public static void AddRemovedItem(string itemCode, string itemName, int quantity, double unitPrice, DateTime expirationDate)
        {
            removedItemsTable.Rows.Add(itemCode, itemName, quantity, unitPrice, expirationDate, DateTime.Now);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO tb_removedItems 
                         (ItemCode, ItemName, Quantity, UnitPrice, ExpirationDate, DateRemoved) 
                         VALUES (@ItemCode, @ItemName, @Quantity, @UnitPrice, @ExpirationDate, @DateRemoved)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ItemCode", itemCode);
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                    cmd.Parameters.AddWithValue("@DateRemoved", DateTime.Now);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void InventoryReport_Load(object sender, EventArgs e)
        {
            LoadSoldItemsFromDB();
            LoadRemovedItemsFromDB();
        }
        private void LoadSoldItemsFromDB()
        {
            soldItemsTable.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ItemName, Quantity, DateSold, UnitPrice FROM tb_soldItems";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            soldItemsTable.Rows.Add(
                                reader["ItemName"],
                                reader["Quantity"],
                                reader["DateSold"],
                                reader["UnitPrice"]
                            );

                        }
                    }
                }
            }
        }
        private void LoadRemovedItemsFromDB()
        {
            removedItemsTable.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ItemCode, ItemName, Quantity, UnitPrice, ExpirationDate, DateRemoved FROM tb_removedItems";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            removedItemsTable.Rows.Add(
                                reader["ItemCode"],
                                reader["ItemName"],
                                reader["Quantity"],
                                reader["UnitPrice"],
                                reader["ExpirationDate"],
                                reader["DateRemoved"]
                            );
                        }
                    }
                }
            }
        }

        private void txtSearchSoldItem_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(txtSearchSoldItem.Text.Trim());
        }

        private void txtSearchRemovedItem_TextChanged(object sender, EventArgs e)
        {
            SearchRemovedItem(txtSearchRemovedItem.Text.Trim());
        }

        private void SearchProducts(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                gridViewSoldList.DataSource = soldItemsTable;
                return;
            }
            var filteredRows = soldItemsTable.AsEnumerable()
                .Where(row => row.Field<string>("Item Name").IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
            if (filteredRows.Any())
            {
                gridViewSoldList.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                gridViewSoldList.DataSource = null; // No results found
            }

        }

        private void SearchRemovedItem(string searchTxt)
        {
            if (string.IsNullOrEmpty(searchTxt))
            {
                gridViewRemovedList.DataSource = removedItemsTable;
                return;
            }
            var filteredRows = removedItemsTable.AsEnumerable()
                .Where(row => row.Field<string>("Item Name").IndexOf(searchTxt, StringComparison.OrdinalIgnoreCase) >= 0);


            if (filteredRows.Any())
            {
                gridViewRemovedList.DataSource = filteredRows.CopyToDataTable();
            }
            else
            {
                gridViewRemovedList.DataSource = null; // No results found
            }

        }

        private void ExportToCSV(DataGridView dgv, string fileName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
                   {
                       Filter = "CSV file (*.csv)|*.csv",
                       FileName = fileName
                   })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        // Write headers
                        var headers = dgv.Columns.Cast<DataGridViewColumn>();
                        sw.WriteLine(string.Join(",", headers.Select(c => "\"" + c.HeaderText + "\"")));

                        // Write data
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                var cells = row.Cells.Cast<DataGridViewCell>();
                                sw.WriteLine(string.Join(",", cells.Select(c => "\"" + c.Value?.ToString() + "\"")));
                            }
                        }
                    }
                    MessageBox.Show("CSV exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            ExportToCSV(gridViewSoldList, "SoldItemsReport.csv");
        }

        private void DownloadRemovedItemBtn_Click(object sender, EventArgs e)
        {
            ExportToCSV(gridViewRemovedList, "RemovedItemsReport.csv");
        }
    }
}