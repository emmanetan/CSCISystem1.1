using System;
using System.Drawing;
using System.IO;

using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CSCISystem1._1
{
    public partial class UserForm: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=EMMAN\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        SqlCommand cmd;


        public UserForm()
        {
            InitializeComponent();
            
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            InitializeDataUser();
            LoadFilter();
            
        }

        public void InitializeDataUser()
        {
            gridViewUserList.Columns.Add("Username", "Username");
            gridViewUserList.Columns.Add("Email", "Email");
            gridViewUserList.Columns.Add("FirstName", "First Name");
            gridViewUserList.Columns.Add("LastName", "Last Name");
            gridViewUserList.Columns.Add("UserType", "User Type");
            var imgCol = new DataGridViewImageColumn();
            imgCol.Name = "ProfilePicture";
            imgCol.HeaderText = "                       Profile";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            gridViewUserList.Columns.Add(imgCol); // Fixed syntax issues and corrected the column definition
            labelAction.Text = "Action";

            gridViewUserList.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0 && (e.ColumnIndex == gridViewUserList.Columns["EditAction"].Index ||
                                        e.ColumnIndex == gridViewUserList.Columns["DeleteAction"].Index))
                {
                    gridViewUserList.Cursor = Cursors.Hand;
                }
            };

            gridViewUserList.CellMouseLeave += (s, e) =>
            {
                gridViewUserList.Cursor = Cursors.Default;
            };

            var editIconColumn = new DataGridViewImageColumn
            {
                Name = "EditAction",
                HeaderText = "",
               Image = Image.FromFile(@"C:\Users\emman\Downloads\Icon\edit40.png"),
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            gridViewUserList.Columns.Add(editIconColumn);

            // Delete icon column
            var deleteIconColumn = new DataGridViewImageColumn
            {
                Name = "DeleteAction",
                HeaderText = "",
                Image = Image.FromFile(@"C:\Users\emman\Downloads\Icon\delete30r.png"), //edit this
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            gridViewUserList.Columns.Add(deleteIconColumn);
            LoadUserData();
            

        }

        private void LoadFilter()
        {
            filter.Items.Add("All");
            filter.Items.Add("Username");
            filter.Items.Add("Email");
            filter.Items.Add("First Name");
            filter.Items.Add("Last Name");
            filter.Items.Add("User Type");
        }

        private void LoadUserData()
        {
            gridViewUserList.Rows.Clear();
            con.Open();
            string query = "SELECT Username, Email, FirstName, LastName, UserType, ProfilePicture FROM tb_user";
            cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                gridViewUserList.Rows.Add(
                    reader["Username"].ToString(),
                    reader["Email"].ToString(),
                    reader["FirstName"].ToString(),
                    reader["LastName"].ToString(),
                    reader["UserType"].ToString(),
                    reader["ProfilePicture"] != DBNull.Value ? Image.FromStream(new MemoryStream((byte[])reader["ProfilePicture"])) : null
                );
            }
            reader.Close();
            con.Close();
        }

        private void DeleteUserFromDatabase(string username)
        {
            try
            {
                con.Open();
                string deleteQuery = "DELETE FROM tb_user WHERE Username = @Username";
                cmd = new SqlCommand(deleteQuery, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User deleted successfully.", "Deleted", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadUserData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                if (con.State == System.Data.ConnectionState.Open) con.Close();
            }
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addUserForm = new AddUser();
            addUserForm.ShowDialog();
            LoadUserData();
        }

        private void gridViewUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string username = gridViewUserList.Rows[e.RowIndex].Cells["Username"].Value.ToString();

            if (gridViewUserList.Columns[e.ColumnIndex].Name == "EditAction")
            {
                EditUser editUser = new EditUser(username);
                editUser.ShowDialog();

                //reload after editing
                LoadUserData();
            }
            else if (gridViewUserList.Columns[e.ColumnIndex].Name == "DeleteAction")
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {username}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteUserFromDatabase(username);

                }
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panel2.Focus();
        }

        private void breadcrumb1_ItemClick(object sender, AntdUI.BreadcrumbItemEventArgs e)
        {
            if (e.Item.Text == "Home")
            {
                this.Close();
            }
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            SearchUsers(txtSearchUser.Text.Trim());
        }

        private void SearchUsers(string searchText)
        {
            gridViewUserList.Rows.Clear();
            try
            {
                con.Open();
                string query;

                if (filter.SelectedValue == null || filter.SelectedValue.ToString() == "All")
                {
                    query = @"SELECT Username, Email, FirstName, LastName, UserType, ProfilePicture 
                      FROM tb_user 
                      WHERE Username LIKE @search OR 
                            Email LIKE @search OR 
                            FirstName LIKE @search OR 
                            LastName LIKE @search OR 
                            UserType LIKE @search";
                }
                else
                {
                    string column = filter.SelectedValue.ToString().Replace(" ", ""); // Remove space from "First Name"
                    query = $@"SELECT Username, Email, FirstName, LastName, UserType, ProfilePicture 
                       FROM tb_user 
                       WHERE {column} LIKE @search";
                }

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    gridViewUserList.Rows.Add(
                        reader["Username"].ToString(),
                        reader["Email"].ToString(),
                        reader["FirstName"].ToString(),
                        reader["LastName"].ToString(),
                        reader["UserType"].ToString(),
                        reader["ProfilePicture"] != DBNull.Value
                            ? Image.FromStream(new MemoryStream((byte[])reader["ProfilePicture"]))
                            : null
                    );
                }

                reader.Close();
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
