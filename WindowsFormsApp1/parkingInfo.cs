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
    public partial class parkingInfo : Form
    {
        DataTable dataTable;
        Database db;

        public parkingInfo()
        {
            InitializeComponent();
            db = new Database();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Update"].Index && e.RowIndex >= 0)
            {
                UpdateRow(e.RowIndex);
            }
            if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Are you sure to delete this row?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteRow(e.RowIndex);
                }
            }
        }
        private void UpdateRow(int rowIndex)
        {
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string slotNo = row.Cells["Slot No."].Value.ToString();
            string vehicleNo = row.Cells["Vehicle No."].Value.ToString();
            string vehicleType = row.Cells["Vehicle Type"].Value.ToString();
            string ownerName = row.Cells["Owner Name"].Value.ToString();

            // Open the BookParking form with pre-filled data
            BookParking bookParkingForm = new BookParking(slotNo, vehicleNo, vehicleType, ownerName);
            bookParkingForm.ShowDialog();

            // Refresh the data grid view after closing the BookParking form
            LoadData();
        }

        private void DeleteRow(int rowIndex)
        {
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string slotNo = row.Cells["Slot No."].Value.ToString();

            string query = "DELETE FROM VehicleBooking WHERE Slot_no = @SlotNo";

            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@SlotNo", slotNo);
                db.ExecuteNonQuery(cmd);
            }

            dataTable.Rows.RemoveAt(rowIndex);

            MessageBox.Show("Record Deleted Successfully!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.ToLower();
            var filteredData = dataTable.AsEnumerable()
                .Where(row => row.ItemArray.Any(field => field.ToString().ToLower().Contains(searchValue)))
                .CopyToDataTable();

            dataGridView1.DataSource = filteredData;
        }

        private void LoadData()
        {
            string query = "SELECT Slot_no AS 'Slot No.', Vehicle_no AS 'Vehicle No.', Vehicle_type AS 'Vehicle Type', Owner_name AS 'Owner Name' FROM VehicleBooking";
            dataTable = db.ExecuteQuery(query);

            dataGridView1.DataSource = dataTable;

            // Check if the "Update" and "Delete" columns already exist
            if (!dataGridView1.Columns.Contains("Update"))
            {
                // Add Update Button Column
                DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
                updateButtonColumn.Name = "Update";
                updateButtonColumn.Text = "Update";
                updateButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(updateButtonColumn);
            }

            if (!dataGridView1.Columns.Contains("Delete"))
            {
                // Add Delete Button Column
                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                deleteButtonColumn.Name = "Delete";
                deleteButtonColumn.Text = "Delete";
                deleteButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(deleteButtonColumn);
            }
            // Set initial column widths
            dataGridView1.Columns["Slot No."].Width = 100;
            dataGridView1.Columns["Vehicle No."].Width = 150;
            dataGridView1.Columns["Vehicle Type"].Width = 150;
            dataGridView1.Columns["Owner Name"].Width = 200;
            dataGridView1.Columns["Update"].Width = 100;
            dataGridView1.Columns["Delete"].Width = 100;
        }

        private void parkingInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
