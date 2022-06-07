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
    public partial class AddVehicle : UserControl
    {
        private int _engine_id;
        private int _engine_index;
        private List<int> _engines = new List<int>(); 

        public AddVehicle()
        {
            InitializeComponent();
        }

        public void StartTable()
        {
            FillCombo();
        }
        private void LoadEngine(int id)
        {
            string SQL = "SELECT engineID, fuelTypeName, engineSize, horsePower, aspirationType, fuelSystemName, " +
                "engineTypeName, cylinderNum, boreRatio, stroke, compressionRatio, " +
                "horsePower, peakRPM " +
                "FROM engine, fuelType, aspiration, " +
                "engineType, fuelSystem " +
                "WHERE fuelSystem.fuelSystemID = engine.fuelSystemID " +
                "AND aspiration.aspirationID = engine.aspirationID " +
                "AND engineType.engineTypeID = engine.engineTypeID " +
                "AND engine.fuelTypeID = fuelType.fuelTypeID " +
                "AND engine.engineID = " + id.ToString() + ";";

            MainForm.cnn.Open();
            SqlCommand command = new SqlCommand(SQL, MainForm.cnn);
            SqlDataReader sReader;
            sReader = command.ExecuteReader();

            while (sReader.Read())
            {
                IDLabel.Text = "Engine " + sReader["engineID"].ToString();

                CylinderLabel.Text = "Cylinders: " + sReader["cylinderNum"].ToString();
                HorseLabel.Text = "BHP: " + sReader["horsePower"].ToString();
                AspirationLabel.Text = "Aspiration: " + sReader["aspirationType"].ToString();
                CompressionLabel.Text = "Compression Ratio: " + sReader["compressionRatio"].ToString();
                TypeLabel.Text = "Engine Type: " + sReader["engineTypeName"].ToString();
                BoreLabel.Text = "Bore Ratio: " + sReader["boreRatio"].ToString();
                SizeLabel.Text = "Engine Size: " + sReader["engineSize"].ToString();
                StrokeLabel.Text = "Stroke: " + sReader["stroke"].ToString();
                RPMLabel.Text = "Peak RPM: " + sReader["peakRPM"].ToString();

                SystemLabel.Text = "Fuel System: " + sReader["fuelSystemName"].ToString();
                FuelLabel.Text = "Fuel Type: " + sReader["fuelTypeName"].ToString();

            }
            MainForm.cnn.Close();

        }

        private void MoveEngine(string direction)
        {
            if (direction == "Forwards")
            {
                _engine_index++;
                if (_engine_index == _engines.Count())
                {
                    //Go to start of list.
                    _engine_index = 0;
                }
                _engine_id = _engines[_engine_index];
                LoadEngine(_engine_id);
            }
            else 
            {
                _engine_index--;
                if (_engine_index < 0)
                {
                    //Go to end of list.
                    _engine_index = _engines.Count() - 1;
                }
                _engine_id = _engines[_engine_index];
                LoadEngine(_engine_id);
            }
        }

        private void FillCombo()
        {
            SqlConnection cnn = MainForm.cnn;
            SqlCommand cmd;
            DataTable dt;
            SqlDataAdapter da;
            cnn.Open();

            //Engine List.
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT engineID FROM engine ORDER BY engineID ASC";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                _engines.Add((int)dr["engineID"]);
            }
            cnn.Close();
            try
            {
                _engine_index = 0;
                _engine_id = _engines[_engine_index];
                LoadEngine(_engine_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, we could not load the engines!");
            }
            cnn.Open();

            //Engine Location
            EngineLoco.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT engineLocationName FROM engineLocation ORDER BY engineLocationID ASC";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EngineLoco.Items.Add(dr["engineLocationName"]);
            }

           


            //Brand comboBox
            FilterBrandBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT carBrandName FROM carBrand order by carBrandID asc";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FilterBrandBox.Items.Add(dr["carBrandName"].ToString());
            }

            


            //Body Type comboBox
            BodyTypeBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT carBodyName FROM carBody";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BodyTypeBox.Items.Add(dr["carBodyName"].ToString());
            }

            //Drive Wheel comboBox
            DriveWheelBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT driveWheelName FROM driveWheel";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DriveWheelBox.Items.Add(dr["driveWheelName"].ToString());
            }
            cnn.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(MainForm.connectionString))
            {
                String query = "INSERT INTO car (engineLocationID, engineID, driveWheelID, carBodyID, carBrandID, carName,price,wheelBase,carLength,carWidth,carHeight,curbWeight,doorNumber,cityMPG,highwayMPG) VALUES (@engineLocationID, @engineID, @driveWheelID, @carBodyID, @carBrandID, @carName,@price,@wheelBase,@carLength,@carWidth,@carHeight,@curbWeight,@doorNumber,@cityMPG,@highwayMPG)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int EngineLocoID = 0;
                    int DriveWheelID = 0;
                    int CarBodyID = 0;
                    if (EngineLoco.Text == "front")
                    {
                        EngineLocoID = 1;
                    }
                    else if(EngineLoco.Text == "rear")
                    {
                        EngineLocoID = 2;
                    }
                    string[] driveWheelArray = { "filler", "Rear Wheel Drive", "Front Wheel Drive", "Four Wheel Drive" };
                    DriveWheelID = Array.FindIndex(driveWheelArray, row => row.Contains(DriveWheelBox.Text));
                    
                    string[] bodyArray = { "filler", "convertible", "hatchback", "saloon", "estate", "hardtop" };
                    CarBodyID = Array.FindIndex(bodyArray, row => row.Contains(BodyTypeBox.Text));
                   

                    string[] brandArray = { "Filler", "alfa-romero", "audi", "bmw", "chevrolet", "dodge", "honda", "isuzu", "jaguar", "mazda", "buick", "mercury", "mitsubishi", "Nissan", "peugeot", "plymouth", "porsche", "renault", "saab", "subaru", "toyota", "volkswagen", "volvo" };
                    int brandID = 0;
                    
                    brandID = Array.FindIndex(brandArray, row => row.Contains(FilterBrandBox.Text));

                    command.Parameters.AddWithValue("@engineLocationID", EngineLocoID);
                    command.Parameters.AddWithValue("@engineID", _engine_id);
                    command.Parameters.AddWithValue("@driveWheelID", DriveWheelID);
                    command.Parameters.AddWithValue("@carBodyID", CarBodyID);
                    command.Parameters.AddWithValue("@carBrandID", brandID);
                    command.Parameters.AddWithValue("@carName", CarModelText.Text);
                    command.Parameters.AddWithValue("@price", PriceNum.Value);
                    command.Parameters.AddWithValue("@wheelBase", WheelBaseNum.Value);
                    command.Parameters.AddWithValue("@carLength", CarLengthNum.Value);
                    command.Parameters.AddWithValue("@carWidth", CarWidthNum.Value);
                    command.Parameters.AddWithValue("@carHeight", CarHeightNum.Value);
                    command.Parameters.AddWithValue("@curbWeight", CurbWeightNum.Value);
                    command.Parameters.AddWithValue("@doorNumber", DoorNum.Value);
                    command.Parameters.AddWithValue("@cityMPG", CityMPGNum.Value);
                    command.Parameters.AddWithValue("@highwayMPG", HighwayMPGNum.Value);
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

        private void button1_Click(object sender, EventArgs e)
        {
            MoveEngine("Backwards");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoveEngine("Forwards");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
