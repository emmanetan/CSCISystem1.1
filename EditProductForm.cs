using AntdUI;
using AntdUIDemo;
using Microsoft.Data.SqlClient;
using Siticone.UI.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCISystem1._1
{
    public partial class EditProductForm: Form
    {
        private string _productCodeToEdit;
        SqlConnection con = new SqlConnection(@"Data Source=EMMAN\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        SqlCommand _cmd = new SqlCommand();

        public EditProductForm(string productCodeToEdit)
        {
            InitializeComponent();
            RadiusForm();
            CalculateTotalPrice();
            _productCodeToEdit = productCodeToEdit;
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            ClearField();
            if (!string.IsNullOrEmpty(_productCodeToEdit))
            {
                LoadProductData(_productCodeToEdit);
            }
        }

        private void LoadProductData(string productCode)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM tb_product WHERE ProductCode = @ProductCode";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ProductCode", productCode);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtProductCode.Text = reader["ProductCode"].ToString();
                        txtProductName.Text = reader["ProductName"].ToString();
                        txtQuantity.Text = reader["Quantity"].ToString();
                        txtPrice.Text = reader["Price"].ToString();
                        txtTotalPrice.Text = reader["TotalPrice"].ToString();
                        datePicker.Value = Convert.ToDateTime(reader["ExpDate"]);
                        if (reader["Image"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])reader["Image"];
                            pictureBoxAddProduct.Image = Image.FromStream(new MemoryStream(imgBytes));
                        }
                        else
                        {
                            pictureBoxAddProduct.Image = null;
                        }

                        txtProductCode.Enabled = false; // Prevent editing the primary key
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product data: " + ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void EditProductDatabase()
        {
            var productCode = txtProductCode.Text.Trim();
            var productName = txtProductName.Text.Trim();
            var quantityText = txtQuantity.Text.Trim();
            var priceText = txtPrice.Text.Trim();
            var totalPriceText = txtTotalPrice.Text.Trim();
            var expDate = datePicker.Value;
            if (string.IsNullOrEmpty(productCode) || string.IsNullOrEmpty(productName) ||
                string.IsNullOrEmpty(quantityText) || string.IsNullOrEmpty(priceText) ||
                string.IsNullOrEmpty(totalPriceText) || expDate == DateTime.MinValue || expDate < DateTime.Today)
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the product information in the database
            var query =
                "UPDATE tb_product SET ProductName = @ProductName, ExpDate = @ExpDate, Quantity = @Quantity, Price = @Price, TotalPrice = @TotalPrice, Image = @Image WHERE ProductCode = @ProductCode";
            _cmd = new SqlCommand(query, con);
            _cmd.Parameters.AddWithValue("@ProductCode", productCode);
            _cmd.Parameters.AddWithValue("@ProductName", productName);
            _cmd.Parameters.AddWithValue("@ExpDate", expDate);
            _cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(quantityText));
            _cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(priceText));
            _cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(totalPriceText));
            if (pictureBoxAddProduct.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxAddProduct.Image.Save(ms, pictureBoxAddProduct.Image.RawFormat);
                    byte[] imageBytes = ms.ToArray();
                    _cmd.Parameters.AddWithValue("@Image", imageBytes);
                }
            }
            else
            {
                _cmd.Parameters.AddWithValue("@Image", DBNull.Value);
            }

            try
            {
                con.Open();
                int rowsAffected = _cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearField();
                }
                else
                {
                    MessageBox.Show("No product found with the specified code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }



        private void ClearField()
        {
            txtPrice.Clear();
            txtProductCode.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            txtTotalPrice.Clear();
            datePicker.Value = DateTime.Today;
            pictureBoxAddProduct.Image = null;

            txtProductCode.Focus();
        }
        private void RadiusForm()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            var radius = 18;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 272, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            Region = new Region(path);
        }

        private void CalculateTotalPrice()
        {
            var quantityText = txtQuantity.Text.Trim();
            var priceText = txtPrice.Text.Trim();

            if (int.TryParse(quantityText, out var quantity) &&
                decimal.TryParse(priceText, out var price) &&
                quantity > 0 && price > 0)
            {
                var totalPrice = quantity * price;
                txtTotalPrice.Text = totalPrice.ToString("0.00");
            }
            else
            {
                txtTotalPrice.Text = "0.00";
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            EditProductDatabase();
            this.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                pictureBoxAddProduct.Image = Image.FromFile(openFileDialog.FileName);
                pictureBoxAddProduct.ImageFit = TFit.Cover;
            }
        }

        
    }
}
