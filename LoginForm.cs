using Siticone.UI.WinForms.Suite;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using AntdUIDemo;
using CSCISystem1._1;
using System.IO;

namespace LoginSignup
{
    public partial class LoginForm: Form
    {


        int pw;
        bool hided;
        string firstname;
        string userType;
        public bool IsAuthenticated { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            PlaceholderLoader();

            pw = Panel.Width;
            hided = false;
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

        private void LoginAccountDatabase()
        {
            string connectionString = "Data Source=EMMAN\\SQLEXPRESS;Initial Catalog=DB_System;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string hashedPassword = HashPassword(PasswordTextBox.Text);
                string query = "SELECT UserType, Firstname, ProfilePicture FROM tb_user WHERE Username = @Username AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);
                    


                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userType = reader["UserType"].ToString();
                            firstname = reader["Firstname"].ToString();

                            MessageBox.Show("Login successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearField();

                            Image profileImage = null;

                            if (reader["ProfilePicture"] != DBNull.Value)
                            {
                                byte[] imgBytes = (byte[])reader["ProfilePicture"];
                                using (MemoryStream ms = new MemoryStream(imgBytes))
                                {
                                    profileImage = Image.FromStream(ms);
                                }
                            }

                            this.Hide();

                            if (userType == "Admin")
                            {
                                Main main = new Main(firstname, userType, profileImage);
                                main.Show();
                            }
                            else if (userType == "Cashier")
                            {
                                POS pos = new POS(firstname, profileImage); // Pass data here!
                                pos.Show();
                            }
                            else
                            {
                                MessageBox.Show("Unknown user type.");
                                this.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
            }
        }

        private void PlaceholderLoader()
        {
            UsernameTextBox.Text = "Username";
            UsernameTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            PasswordTextBox.Text = "Password";
            PasswordTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            NewUsernameTextBox.Text = "Username";
            NewUsernameTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            NewEmailTextBox.Text = "Email";
            NewEmailTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            NewPasswordTextBox.Text = "Password";
            NewPasswordTextBox.ForeColor = Color.FromArgb(125, 137, 149);
        }
        private void ClearField()
        {
            UsernameTextBox.Text = "Username";
            PasswordTextBox.Text = "Password";
            PasswordTextBox.UseSystemPasswordChar = false;
            ShowPassword.Checked = false;

            NewUsernameTextBox.Text = "Username";
            NewEmailTextBox.Text = "Email";
            NewPasswordTextBox.Text = "Password";
            NewPasswordTextBox.UseSystemPasswordChar = false;   
            ShowPassword2.Checked = false;
        }
        private void IncreaseOpacity(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.01;
            }
            if (this.Opacity == 1)
            {
                timer1.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 18; 

            path.AddArc(0, 0, radius, radius, 180, 90); 
            path.AddArc(this.Width - radius, 0, radius, radius, 272, 90); 
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); 
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); 
           
            path.CloseFigure();

            Region = new Region(path);

            this.Opacity = 01;
            timer1.Interval = 10;
            timer1.Tick += (IncreaseOpacity);
            timer1.Start();
        }
        
       
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
        
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]

        private extern static int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        private void LoginAndSignup_DragEnter(object sender, DragEventArgs e)
        {
            this.Opacity = 0.5;
        }
        private void LoginAndSignup_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1;   
        }
        private void LoginAndSignup_ResizeBegin(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (NewUsernameTextBox.Text == "Username")
            {
                MessageBox.Show("Please enter your username");
                return;
            }
           
            if (NewEmailTextBox.Text == "Email")
            {
                MessageBox.Show("Please enter your email");
                return;
            }
            if (NewPasswordTextBox.Text == "Password")
            {
                MessageBox.Show("Please enter your password");
                return;
            }

        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "Username")
            {
                MessageBox.Show("Please enter your username");
                return;
            }
            if (PasswordTextBox.Text == "Password")
            {
                MessageBox.Show("Please enter your password");
                return;
            }

            LoginAccountDatabase();
        }
        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "Username")
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }
        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "")
            {
                UsernameTextBox.Text = "Username";
                UsernameTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }
        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Password")
            {
                PasswordTextBox.Text = "";
                PasswordTextBox.UseSystemPasswordChar = true;
                PasswordTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }
        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.Text = "Password";
                PasswordTextBox.UseSystemPasswordChar = false;
                PasswordTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }
        private void NewUsernameTextBox_Enter(object sender, EventArgs e)
        {
            if (NewUsernameTextBox.Text == "Username")
            {
                NewUsernameTextBox.Text = "";
                NewUsernameTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }
        private void NewUsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (NewUsernameTextBox.Text == "")
            {
                NewUsernameTextBox.Text = "Username";
                NewUsernameTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }
        private void NewEmailTextBox_Enter(object sender, EventArgs e)
        {
            if (NewEmailTextBox.Text == "Email")
            {
                NewEmailTextBox.Text = "";
                NewEmailTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }
        private void NewEmailTextBox_Leave(object sender, EventArgs e)
        {
            if (NewEmailTextBox.Text == "")
            {
                NewEmailTextBox.Text = "Email";
                NewEmailTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }
        private void NewPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.Text == "Password")
            {
                NewPasswordTextBox.Text = "";
                NewPasswordTextBox.UseSystemPasswordChar = true;
                NewPasswordTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }
        private void NewPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.Text == "")
            {
                NewPasswordTextBox.Text = "Password";
                NewPasswordTextBox.UseSystemPasswordChar = false;
                NewPasswordTextBox.ForeColor = Color.FromArgb(125, 137, 149);
            }
        }
        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
            {
                PasswordTextBox.UseSystemPasswordChar = false;
            } else
            {
                PasswordTextBox.UseSystemPasswordChar = true;
            }
        }
        private void ShowPassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword2.Checked)
            {
                NewPasswordTextBox.UseSystemPasswordChar = false;
            } else
            {
                NewPasswordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}