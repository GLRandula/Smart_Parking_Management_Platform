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
    public partial class Home : Form
    {
        string location = "";
        Image activeTabImage = Properties.Resources.Rectangle_110 ; // Replace with your image resource

        public Home()
        {
            InitializeComponent();
            loadform(new HomeInfo());
            UpdateTabColors();
        }

        public void loadform(object Form)
        {
            if (this.pnlMain.Controls.Count > 0)
                this.pnlMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(f);
            this.pnlMain.Tag = f;
            f.Show();

            UpdateTabColors();
        }

        private void UpdateTabColors()
        {
            // Reset all button colors and images
            ResetButtonStyles();

            // Set the active button color and image
            switch (location)
            {
                case "home":
                    
                    btnHome.BackgroundImage = activeTabImage;
                    break;
                case "parkingSpaces":
                   
                    btnParkingSpaces.BackgroundImage = activeTabImage;
                    break;
                case "parkingInfo":
                   
                    btnParkingInfo.BackgroundImage = activeTabImage;
                    break;
                case "car":
                  
                    btnCar.BackgroundImage = activeTabImage;
                    break;
                case "bike":
                
                    btnBike.BackgroundImage = activeTabImage;
                    break;
            }
        }

        private void ResetButtonStyles()
        {
            btnHome.BackColor = Color.Transparent;
            btnHome.BackgroundImage = null;
            btnParkingSpaces.BackColor = Color.Transparent;
            btnParkingSpaces.BackgroundImage = null;
            btnParkingInfo.BackColor = Color.Transparent;
            btnParkingInfo.BackgroundImage = null;
            btnCar.BackColor = Color.Transparent;
            btnCar.BackgroundImage = null;
            btnBike.BackColor = Color.Transparent;
            btnBike.BackgroundImage = null;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            location = "home";
            loadform(new HomeInfo());
        }

        private void btnParkingSpaces_Click(object sender, EventArgs e)
        {
            location = "parkingSpaces";
            loadform(new ParkingSpaces());
        }

        private void btnParkingInfo_Click(object sender, EventArgs e)
        {
            if (LoginState.IsLoggedIn)
            {
                location = "parkingInfo";
                loadform(new parkingInfo());
            }
            else
            {
                // Show the login form
                Login loginForm = new Login();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // If login is successful, allow the action
                    location = "parkingInfo";
                    loadform(new parkingInfo());
                }
                else
                {
                    // Display a message box indicating that login is required
                    MessageBox.Show("You must be logged in to perform this action.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            location = "car";
            loadform(new ParkingSpaces());
        }

        private void btnBike_Click(object sender, EventArgs e)
        {
            location = "bike";
            loadform(new ParkingSpacesBike());
        }

        private void lblFilledNumber_Click(object sender, EventArgs e)
        {

        }

        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    using (Login loginForm = new Login())
        //    { 
        //        if (loginForm.ShowDialog() == DialogResult.OK)
        //        {
        //            // Login was successful
        //            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //}
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();
            //this.Close();
        }


        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();
            //this.Close();
        }
    }
}
