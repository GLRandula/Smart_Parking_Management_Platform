using MySqlConnector;
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
    public partial class AddVehicle : Form
    {
        Functions con;
        Database db;
        public AddVehicle()
        {
            InitializeComponent();
            db = new Database();
        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVehicleNo.Text) ||
                string.IsNullOrWhiteSpace(txtVehicleType.Text) ||
                string.IsNullOrWhiteSpace(txtOwnerName.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNo.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            try
            {
                string vehicleNo = txtVehicleNo.Text;
                string vehicleType = txtVehicleType.Text;
                string ownerName = txtOwnerName.Text;
                string phoneNo = txtPhoneNo.Text;

                // Insert query for adding a vehicle
                string query = "INSERT INTO Vehicle (vehicle_no, vehicle_type, emp_name, phone_no) VALUES (@VehicleNo, @VehicleType, @OwnerName, @PhoneNo)";

                using (MySqlCommand cmd = new MySqlCommand(query))
                {
                    cmd.Parameters.AddWithValue("@VehicleNo", vehicleNo);
                    cmd.Parameters.AddWithValue("@VehicleType", vehicleType);
                    cmd.Parameters.AddWithValue("@OwnerName", ownerName);
                    cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);

                    db.ExecuteNonQuery(cmd);
                }

                MessageBox.Show("Vehicle added successfully.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearFields()
        {
            txtVehicleNo.Text = string.Empty;
            txtVehicleType.Text = string.Empty;
            txtOwnerName.Text = string.Empty;
            txtPhoneNo.Text = string.Empty;
        }
    }
}
