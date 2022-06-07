using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace SoftwareEngineering
{
    public partial class AddEngine : UserControl
    {
        public AddEngine()
        {
            InitializeComponent();
        }

        public void StartTable()
        {
            FillCombo();
        }

        private void FillCombo()
        {
            SqlConnection cnn = MainForm.cnn;
            SqlCommand cmd;
            DataTable dt;
            SqlDataAdapter da;
            cnn.Open();

            //Engine Type
            TypeBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT engineTypeName FROM engineType ORDER BY engineTypeName ASC";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                TypeBox.Items.Add(dr["engineTypeName"]);
            }

            //Aspiration comboBox
            AspBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT aspirationType FROM aspiration order by aspirationType asc";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                AspBox.Items.Add(dr["aspirationType"].ToString());
            }

            //FuelType comboBox
            FuelBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT fuelTypeName FROM fuelType";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FuelBox.Items.Add(dr["fuelTypeName"].ToString());
            }

            //System comboBox
            SystemBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT fuelSystemName FROM fuelSystem";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                SystemBox.Items.Add(dr["fuelSystemName"].ToString());
            }
            cnn.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(MainForm.connectionString))
            {
                String query = "INSERT INTO engine (fuelTypeID, aspirationID, engineTypeID, cylinderNum, engineSize, fuelSystemID, boreRatio, stroke, compressionRatio, horsePower, peakRPM) VALUES (@fuelTypeID, @aspirationID, @engineTypeID, @cylinderNum, @engineSize, @fuelSystemID, @boreRatio, @stroke, @compressionRatio, @horsePower, @peakRPM)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    int fuelTypeID = 1;
                    int aspirationID = 0;
                    int engineTypeID = 0;
                    int fuelSystemID = 0;

                    if (FuelBox.Text == "Diesel")
                    {
                        fuelTypeID = 2;
                    }
                    string[] aspirationArray = { "filler", "Standard", "turbo"};
                    aspirationID = Array.FindIndex(aspirationArray, row => row.Contains(AspBox.Text));
                    string[] TypeArray = { "filler", "Double Inline Overhead Cam", "Overhead Cam", "Inline", "rotor"};
                    engineTypeID = Array.FindIndex(TypeArray, row => row.Contains(TypeBox.Text));


                    string[] SystemArray = { "Filler", "Multi Point Fuel Injection", "2 Barrel Carburators", "Multi Port Fuel Injection", "1 Barrel Carburators", "Spark Plug Fuel Injector", "4 Barrel Carburators", "Indirect Injection", "Squential Port Fuel Injection"};
                    fuelSystemID = Array.FindIndex(SystemArray, row => row.Contains(SystemBox.Text));

                    command.Parameters.AddWithValue("@engineTypeID", engineTypeID);
                    command.Parameters.AddWithValue("@fuelTypeID", fuelTypeID);
                    command.Parameters.AddWithValue("@aspirationID", aspirationID);
                    command.Parameters.AddWithValue("@fuelSystemID", fuelSystemID);
                    command.Parameters.AddWithValue("@cylinderNum", CylinderBox.Value);
                    command.Parameters.AddWithValue("@engineSize", SizeBox.Value);
                    command.Parameters.AddWithValue("@boreRatio", BoreBox.Value);
                    command.Parameters.AddWithValue("@stroke", StrokeBox.Value);
                    command.Parameters.AddWithValue("@compressionRatio", CompBox.Value);
                    command.Parameters.AddWithValue("@horsePower", BHPBox.Value);
                    command.Parameters.AddWithValue("@peakRPM", RPMBox.Value);
                    
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                    else
                        MessageBox.Show("Successfully added data!");
                }
            }
        }
        private void blabel_Click(object sender, EventArgs e)
        {

        }
    }
}
