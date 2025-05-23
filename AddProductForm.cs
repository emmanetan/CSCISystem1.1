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
using Microsoft.Data.SqlClient;
using AntdUI;

namespace CSCISystem1._1
{
    public partial class AddProductForm: Form
    {
        SqlConnection _con = new SqlConnection("Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");
        SqlCommand _cmd = new SqlCommand();

        public AddProductForm()
        {
            InitializeComponent();
            RadiusForm();
            
        }
        //yahh

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            ClearField();
        }

        private void ClearField()
        {
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();



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
    }
}
