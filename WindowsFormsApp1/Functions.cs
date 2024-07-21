using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagementSystem
{
    class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private String ConStr;
        public Functions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\Vehicle_Parking.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        public DataTable GetDataTable(string Query)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query, ConStr);
            Sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query)
        {
            int Cnt = 0;
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
                //try
                //{
                //    Con.Open();
                //    Cmd.CommandText = Query;
                //    Cnt = Cmd.ExecuteNonQuery();
                //}
                //catch (Exception e)
                //{
                //    MessageBox.Show("Error connecting Database: " + e, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //finally
                //{
                //    Con.Close();
                //}
            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            
            //SqlConnection.Close();
            return Cnt;
        }
    }
}
