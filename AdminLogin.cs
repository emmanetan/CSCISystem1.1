using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CSCISystem1._1
{
    public partial class AdminLogin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=EMMAN\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        SqlCommand cmd;
        public bool IsAuthenticated { get; private set; }
        public AdminLogin()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.AdminLogin_FormClosing);
        }
        private void AdminLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If DialogResult has not been set to OK (meaning login was not successful),
            // ensure it's set to Cancel when the form closes (e.g., via the 'X' button).
            if (this.DialogResult != DialogResult.OK)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            // IMPORTANT: Do NOT put 'e.Cancel = true;' here unless you specifically want to prevent the form from closing.
            // IMPORTANT: Do NOT put 'MessageBox.Show(...);' here, as it will cause the double-click issue.
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            // You can re-enable MessageBox.Show() here if it's necessary for other logic
            // For now, keep them commented if you are still troubleshooting the double-click issue.
            RadiusForm();
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

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string username = txtUserName.Text.Trim();
            string hashedPassword = HashPassword(txtPassword.Text);
            if (username == "" || hashedPassword == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM tb_user WHERE Username=@username AND Password=@password AND UserType='Admin'";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashedPassword);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    IsAuthenticated = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid admin credentials.");
                    IsAuthenticated = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}