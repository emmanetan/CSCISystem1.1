using Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CSCISystem1._1
{
    public partial class Product : Form
    {
        SqlConnection con = new SqlConnection("Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");
        SqlCommand cmd;
        public Product()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            gridViewProductList.Columns.Add("ProductCode", "Item Code");
            gridViewProductList.Columns.Add("ProductName", "Item Name");
            gridViewProductList.Columns.Add("ExpDate", "Expiration Date");
            gridViewProductList.Columns.Add("Quantity", "Qty");
            gridViewProductList.Columns.Add("Price", "Unit Price");
            gridViewProductList.Columns.Add("TotalPrice", "Total Price");
            //gsghafd

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
        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }
    }
}
