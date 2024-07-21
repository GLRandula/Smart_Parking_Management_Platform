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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ParkingSpaces parkingSpaces = new ParkingSpaces();
            parkingSpaces.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Problems problems = new Problems();
            problems.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if (imageNumber == 4) 
            {
                imageNumber = 1;
            }
            slidepic.ImageLocation = string.Format(@"Resources\{0}.png", imageNumber);
            imageNumber++;
        }

        private void slidepic_Click(object sender, EventArgs e)
        {
            //LoadNextImage();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
