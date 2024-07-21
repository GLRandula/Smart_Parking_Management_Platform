using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySqlConnector;
//using System.Data;
//using MySql.Data.MySqlClient;

namespace ParkingManagementSystem
{
    public partial class BookParking : Form
    {
        Functions Con;
        Database db;
        private bool isUpdate = false;
        private string slotNo;
        public BookParking()
        {
            InitializeComponent();
            Con = new Functions();
            db = new Database();
            SetCurrentDate();
            SetCurrentTime();
            SetCurrentId();
        }
        public BookParking(string slotNo, string vehicleNo, string vehicleType, string ownerName) : this()
        {
            this.isUpdate = true;
            this.slotNo = slotNo;
            txtParkingLotNumber.Text = slotNo;
            txtVehicleNumber.Text = vehicleNo;
            txtVehicleType.Text = vehicleType;
            txtOwnerId.Text = ownerName;

            // Disable the ID setting and booking ID text field for updates
            txtParkingLotNumber.Enabled = false;
        }

        private void SetCurrentDate()
        {
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void SetCurrentTime()
        {
            txtInTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void BookParking_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtVehicleNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void Date_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetCurrentId()
        {
            int lastBookingId = db.GetLastBookingId();
            Booking_id.Text = (lastBookingId + 1).ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParkingLotNumber.Text) ||
            string.IsNullOrWhiteSpace(txtVehicleNumber.Text) ||
            string.IsNullOrWhiteSpace(txtVehicleType.Text) ||
            string.IsNullOrWhiteSpace(txtOwnerId.Text))
            {
                MessageBox.Show("Missing Data!!!");
                return;
            }

            try
            {
                string slotNo = txtParkingLotNumber.Text;
                string vehicleNo = txtVehicleNumber.Text;
                string vehicleType = txtVehicleType.Text;
                string ownerName = txtOwnerId.Text;

                if (isUpdate)
                {
                    // Update query
                    string query = "UPDATE VehicleBooking SET Vehicle_no = @VehicleNo, Vehicle_type = @VehicleType, Owner_name = @OwnerName WHERE Slot_no = @SlotNo";

                    using (MySqlCommand cmd = new MySqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@SlotNo", slotNo);
                        cmd.Parameters.AddWithValue("@VehicleNo", vehicleNo);
                        cmd.Parameters.AddWithValue("@VehicleType", vehicleType);
                        cmd.Parameters.AddWithValue("@OwnerName", ownerName);

                        db.ExecuteNonQuery(cmd);
                    }

                    MessageBox.Show("Car Updated!");
                }
                else
                {
                    // Insert query
                    string query = "INSERT INTO VehicleBooking (Slot_no, Vehicle_no, Vehicle_type, Owner_name) VALUES (@SlotNo, @VehicleNo, @VehicleType, @OwnerName)";

                    using (MySqlCommand cmd = new MySqlCommand(query))
                    {
                        cmd.Parameters.AddWithValue("@SlotNo", slotNo);
                        cmd.Parameters.AddWithValue("@VehicleNo", vehicleNo);
                        cmd.Parameters.AddWithValue("@VehicleType", vehicleType);
                        cmd.Parameters.AddWithValue("@OwnerName", ownerName);

                        db.ExecuteNonQuery(cmd);
                    }

                    // Retrieve the last inserted booking_id
                    int bookingId = db.GetLastBookingId();
                    MessageBox.Show($"Car Added! Booking ID: {bookingId}");

                    // Clear all the fields
                    txtParkingLotNumber.Text = string.Empty;
                    txtVehicleNumber.Text = string.Empty;
                    txtVehicleType.Text = string.Empty;
                    txtOwnerId.Text = string.Empty;
                    txtDesignation.Text = string.Empty;
                    txtPhoneNumber.Text = string.Empty;
                    txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                    txtInTime.Text = DateTime.Now.ToString("HH:mm:ss");

                    SetCurrentId();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            SetCurrentDate();
        }

        private void txtParkingLotNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOwnerId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVehicleNumber_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtInTime_TextChanged(object sender, EventArgs e)
        {
            SetCurrentTime();
        }

        private void Booking_id_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtVehicleType_Click(object sender, EventArgs e)
        {

        }

        private void Booking_id_TextChanged_2(object sender, EventArgs e)
        {
            SetCurrentId();
        }

        private void txtVehicleNumber_TextChanged_2(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtVehicleNumber.Text))
            {
                DataRow vehicleDetails = db.GetVehicleDetails(txtVehicleNumber.Text);
                if (vehicleDetails != null)
                {
                    txtVehicleType.Text = vehicleDetails["Vehicle_type"].ToString();
                    txtOwnerId.Text = vehicleDetails["Emp_name"].ToString();
                    txtPhoneNumber.Text = vehicleDetails["Phone_no"].ToString();
                }
            }
        }
    }

    public class Database
    {
        private string connectionString;

        public Database()
        {
            // Read the connection string from App.config
            connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public int ExecuteNonQuery(MySqlCommand cmd)
        {
            int affectedRows = 0;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    cmd.Connection = connection;
                    affectedRows = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                throw;
            }
            return affectedRows; 
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                throw;
            }
            return dt;
        }
        public int GetLastBookingId()
        {
            int lastBookingId = 0;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand("SELECT MAX(Booking_id) FROM VehicleBooking", connection))
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            lastBookingId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            return lastBookingId;
        }
        public DataRow GetVehicleDetails(string vehicleNo)
        {
            DataRow vehicleDetails = null;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand("SELECT Vehicle_type, Emp_name, Phone_no FROM Vehicle WHERE Vehicle_no = @VehicleNo", connection))
                    {
                        cmd.Parameters.AddWithValue("@VehicleNo", vehicleNo);
                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            if (dt.Rows.Count > 0)
                            {
                                vehicleDetails = dt.Rows[0];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                throw;
            }
            return vehicleDetails;
        }
    }
}