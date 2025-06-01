using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CSCISystem1._1
{
    public partial class EditUser: Form
    {
        private string _usernameToEdit;
        SqlConnection con = new SqlConnection(@"Data Source=EMMAN\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        SqlCommand _cmd = new SqlCommand();

        public EditUser(string usernameToEdit)
        {
            InitializeComponent();
            RadiusForm();
            _usernameToEdit = usernameToEdit;
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            LoadUserType();
            ClearField();
            LoadUserType();
            if (!string.IsNullOrEmpty(_usernameToEdit))
            {
                LoadUserData(_usernameToEdit);
            }
        }

        private void LoadUserData(string username)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM tb_user WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtUsername.Text = reader["Username"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtPassword.Text = reader["Password"].ToString();
                        txtFname.Text = reader["FirstName"].ToString();
                        txtLname.Text = reader["LastName"].ToString();
                        selectUsertype.SelectedValue = reader["UserType"].ToString();
                        if (reader["ProfilePicture"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])reader["ProfilePicture"];
                            pictureBoxAddUser.Image = Image.FromStream(new MemoryStream(imgBytes));
                        }
                        else
                        {
                            pictureBoxAddUser.Image = null;
                        }

                        txtUsername.Enabled = false; //disable editing primary key
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void EditUserDatabase()
        {
            
            var username = txtUsername.Text.Trim();
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text.Trim();
            var firstName = txtFname.Text.Trim();
            var lastName = txtLname.Text.Trim();
            var userType = selectUsertype.SelectedValue.ToString();
            
            if (string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(userType))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                labelEmail.Text = "Please enter a valid Email Address.";
                return;
            }

            try
            {
                string query =
                    "UPDATE tb_user SET Email = @Email, Password = @Password, FirstName = @FirstName, LastName = @LastName, UserType = @UserType, ProfilePicture = @ProfilePicture WHERE Username = @Username";
                using (SqlCommand _cmd = new SqlCommand(query, con))
                {
                    _cmd.Parameters.AddWithValue("@Username", username);
                    _cmd.Parameters.AddWithValue("@Email", email);
                    _cmd.Parameters.AddWithValue("@Password", password);
                    _cmd.Parameters.AddWithValue("@FirstName", firstName);
                    _cmd.Parameters.AddWithValue("@LastName", lastName);
                    _cmd.Parameters.AddWithValue("@UserType", userType);
                    if (pictureBoxAddUser.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBoxAddUser.Image.Save(ms, pictureBoxAddUser.Image.RawFormat);
                            byte[] imageBytes = ms.ToArray();
                            _cmd.Parameters.AddWithValue("@ProfilePicture", imageBytes);
                        }
                    }
                    else
                    {
                        _cmd.Parameters.AddWithValue("@ProfilePicture", DBNull.Value);
                    }

                    con.Open();
                    int rowsAffected = _cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearField();
                    }
                    else
                    {
                        MessageBox.Show("No user found with the specified username.", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void LoadUserType()
        {
            selectUsertype.Items.Clear();
            selectUsertype.Items.Add("Admin");
            selectUsertype.Items.Add("Cashier");
            selectUsertype.SelectedIndex = -1;
        }

        private void ClearField()
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtFname.Clear();
            txtLname.Clear();
            selectUsertype.SelectedIndex = -1;
            pictureBoxAddUser.Image = null;



            string defaultImagePath = @"C:\Users\emman\OneDrive\Pictures\Icon Black small\23.png"; 
            if (File.Exists(defaultImagePath))
            {
                pictureBoxAddUser.Image = Image.FromFile(defaultImagePath);
            }
            else
            {
                pictureBoxAddUser.Image = null; // in case file is missing
            }

            txtUsername.Focus();
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            EditUserDatabase();
            this.Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxAddUser.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            labelEmail.Text = "";
        }
    }
}
