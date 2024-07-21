using ReaLTaiizor.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ParkingManagementSystem.Login;

namespace ParkingManagementSystem
{
    public partial class ParkingSpacesBike : Form
    {
        public ParkingSpacesBike()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ParkingSpaces parkingSpaces = new ParkingSpaces();
            parkingSpaces.Show();
            this.Close();
        }

        private void btnAddBike_Click(object sender, EventArgs e)
        {
            if (LoginState.IsLoggedIn)
            {
                AddVehicle addVehicle = new AddVehicle();
                addVehicle.Show();
            }
            else
            {
                // Show the login form
                Login loginForm = new Login();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // If login is successful, allow the action
                    AddVehicle addVehicle = new AddVehicle();
                    addVehicle.Show();
                }
                else
                {
                    // Display a message box indicating that login is required
                    MessageBox.Show("You must be logged in to perform this action.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnBookBike_Click(object sender, EventArgs e)
        {
            if (LoginState.IsLoggedIn)
            {
                BookParking bookParking = new BookParking();
                bookParking.Show();
            }
            else
            {
                // Show the login form
                Login loginForm = new Login();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // If login is successful, allow the action
                    BookParking bookParking = new BookParking();
                    bookParking.Show();
                }
                else
                {
                    // Display a message box indicating that login is required
                    MessageBox.Show("You must be logged in to perform this action.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
