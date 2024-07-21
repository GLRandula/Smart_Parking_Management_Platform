using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static class LoginState
        {
            public static bool IsLoggedIn { get; set; } = false;
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUname.Text) || string.IsNullOrEmpty(txtPwd.Text))
            {
                // Display error message for uncompleted fields
                MessageBox.Show("Please fill in both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtUname.Text == "admin" && txtPwd.Text == "admin123")
            {
                // Display success message
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Set the login state to true
                LoginState.IsLoggedIn = true;

                // Set the DialogResult to OK to indicate a successful login
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Display error message
                MessageBox.Show("Login failed! Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
