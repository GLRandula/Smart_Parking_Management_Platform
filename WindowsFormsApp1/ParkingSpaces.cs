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
    public partial class ParkingSpaces : Form
    {
        public ParkingSpaces()
        {
            InitializeComponent();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void label94_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParkingSpacesBike parkingSpacesBike = new ParkingSpacesBike();
            parkingSpacesBike.Show();
            this.Close();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            BookParking bookParking = new BookParking();
            bookParking.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void label89_Click(object sender, EventArgs e)
        {

        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void label92_Click(object sender, EventArgs e)
        {

        }

        private void label93_Click(object sender, EventArgs e)
        {

        }

        private void label82_Click(object sender, EventArgs e)
        {

        }

        private void label85_Click(object sender, EventArgs e)
        {

        }

        private void label86_Click(object sender, EventArgs e)
        {

        }

        private void label87_Click(object sender, EventArgs e)
        {

        }

        private void label88_Click(object sender, EventArgs e)
        {

        }

        private void label84_Click(object sender, EventArgs e)
        {

        }

        private void label83_Click(object sender, EventArgs e)
        {

        }

        private void label81_Click(object sender, EventArgs e)
        {

        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void label79_Click(object sender, EventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {

        }

        private void label77_Click(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void label75_Click(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BookCar_Click(object sender, EventArgs e)
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
