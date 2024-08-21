using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ParkingManagementSystem.Login;

namespace ParkingManagementSystem
{

    public partial class ParkingSpaces : Form
    {
        Database db;
        Dictionary<string, Panel> panels = new Dictionary<string, Panel>();

        public ParkingSpaces()
        {
            InitializeComponent();
            db = new Database();

            InitializePanels();
            LoadParkingSlots();
        }

        private void InitializePanels()
        {
            panels.Add("CA1", panelCA1);
            panels.Add("CA2", panelCA2);
            panels.Add("CA3", panelCA3);
            panels.Add("CA4", panelCA4);
            panels.Add("CA5", panelCA5);
            panels.Add("CA6", panelCA6);
            panels.Add("CA7", panelCA7);
            panels.Add("CA8", panelCA8);
            panels.Add("CA9", panelCA9);
            panels.Add("CA10", panelCA10);
            panels.Add("CB1", panelCB1);
            panels.Add("CB2", panelCB2);
            panels.Add("CB3", panelCB3);
            panels.Add("CB4", panelCB4);
            panels.Add("CB5", panelCB5);
            panels.Add("CB6", panelCB6);
            panels.Add("CB7", panelCB7);
            panels.Add("CB8", panelCB8);
            panels.Add("CB9", panelCB9);
            panels.Add("CB10", panelCB10);
            panels.Add("CC1", panelCC1);
            panels.Add("CC2", panelCC2);
            panels.Add("CC3", panelCC3);
            panels.Add("CC4", panelCC4);
            panels.Add("CC5", panelCC5);
            panels.Add("CC6", panelCC6);
            panels.Add("CC7", panelCC7);
            panels.Add("CC8", panelCC8);
            panels.Add("CC9", panelCC9);
            panels.Add("CC10", panelCC10);
            panels.Add("CD1", panelCD1);
            panels.Add("CD2", panelCD2);
            panels.Add("CD3", panelCD3);
            panels.Add("CD4", panelCD4);
            panels.Add("CD5", panelCD5);
            panels.Add("CD6", panelCD6);
            panels.Add("CD7", panelCD7);
            panels.Add("CD8", panelCD8);
            panels.Add("CD9", panelCD9);
            panels.Add("CD10", panelCD10);
        }

        private void LoadParkingSlots()
        {
            DataTable slots = db.GetParkingSlots();

            foreach (DataRow row in slots.Rows)
            {
                string slotNo = row["Slot_no"].ToString();
                if (db.IsSlotBooked(slotNo))
                {
                    System.Console.WriteLine(slotNo);
                    AddCarImageToSlot(slotNo);
                }
            }
        }

        //public void AddCarImageToSlot(string slotId)
        //{
        //    if (panels.ContainsKey(slotId.ToUpper()))
        //    {
        //        Panel panel = panels[slotId.ToUpper()];
        //        panel.Paint += new PaintEventHandler((sender, e) =>
        //        {
        //            string imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\car2.png");
        //            Image carImage = Image.FromFile(imagePath);
        //            e.Graphics.DrawImage(carImage, new Point(0, 0));
        //        });
        //        panel.Invalidate(); // Force the panel to repaint
        //    }
        //}

        public void AddCarImageToSlot(string slotId)
        {
            if (panels.ContainsKey(slotId.ToUpper()))
            {
                Panel panel = panels[slotId.ToUpper()];

                try
                {
                    // Download the image from the URL
                    string imageUrl = "https://png.pngtree.com/png-vector/20230110/ourmid/pngtree-car-top-view-image-png-image_6557068.png";
                    using (WebClient client = new WebClient())
                    {
                        byte[] imageData = client.DownloadData(imageUrl);
                        using (var ms = new System.IO.MemoryStream(imageData))
                        {
                            Image carImage = Image.FromStream(ms);

                            // Set the downloaded image as the background of the panel
                            panel.BackgroundImage = carImage;
                            panel.BackgroundImageLayout = ImageLayout.Stretch; // Adjust the image layout as needed
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur while loading the image
                    MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Force the panel to repaint to ensure the background image is applied
                panel.Invalidate();
            }
        }


        private void pictureBox19_Click(object sender, EventArgs e) { }

        private void label94_Click(object sender, EventArgs e) { }

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

        private void button4_Click(object sender, EventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void button5_Click(object sender, EventArgs e) { }

        private void pictureBox17_Click(object sender, EventArgs e) { }

        private void pictureBox16_Click(object sender, EventArgs e) { }

        private void pictureBox15_Click(object sender, EventArgs e) { }

        private void label89_Click(object sender, EventArgs e) { }

        private void label90_Click(object sender, EventArgs e) { }

        private void label91_Click(object sender, EventArgs e) { }

        private void label92_Click(object sender, EventArgs e) { }

        private void label93_Click(object sender, EventArgs e) { }

        private void label82_Click(object sender, EventArgs e) { }

        private void label85_Click(object sender, EventArgs e) { }

        private void label86_Click(object sender, EventArgs e) { }

        private void label87_Click(object sender, EventArgs e) { }

        private void label88_Click(object sender, EventArgs e) { }

        private void label84_Click(object sender, EventArgs e) { }

        private void label83_Click(object sender, EventArgs e) { }

        private void label81_Click(object sender, EventArgs e) { }

        private void label80_Click(object sender, EventArgs e) { }

        private void label79_Click(object sender, EventArgs e) { }

        private void label78_Click(object sender, EventArgs e) { }

        private void label77_Click(object sender, EventArgs e) { }

        private void label76_Click(object sender, EventArgs e) { }

        private void label75_Click(object sender, EventArgs e) { }

        private void label74_Click(object sender, EventArgs e) { }

        private void pictureBox14_Click(object sender, EventArgs e) { }

        private void label73_Click(object sender, EventArgs e) { }

        private void label72_Click(object sender, EventArgs e) { }

        private void panel5_Paint(object sender, PaintEventArgs e) { }

        private void panel3_Paint(object sender, PaintEventArgs e) { }

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

        private void panelCA4_Paint(object sender, PaintEventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }

        private void panel4_Paint(object sender, PaintEventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void panel7_Paint(object sender, PaintEventArgs e) { }

        private void BookCar_Click(object sender, EventArgs e) { }

        private void btnBookCar_Click(object sender, EventArgs e)
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
