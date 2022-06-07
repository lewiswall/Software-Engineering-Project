using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace SoftwareEngineering
{
    public partial class EditForm : Form
    {
        private int _carid;
        private int _counter = 0;
        public EditForm(int carid)
        {
            InitializeComponent();
            _carid = carid;
        }

        public void LoadCar()
        {
            string SQL = "SELECT carID, carBrandName, carName, fuelTypeName, carBodyName, " + 
                "DriveWheelName, engineLocationName, wheelBase, carLength, "+
                "carWidth, carHeight, curbWeight, doorNumber, cityMPG, highwayMPG, "+
                "engineSize, horsePower, price, aspirationType, fuelSystemName, "+
                "engineTypeName, cylinderNum, boreRatio, stroke, compressionRatio, "+
                "horsePower, peakRPM, engine.engineID " +
                "FROM car, carBody, carBrand, engine, fuelType, aspiration, "+
                "engineType, fuelSystem, driveWheel, engineLocation "+
                "WHERE car.carBrandID = carBrand.carBrandID "+
                "AND car.engineID = engine.engineID "+
                "AND carBody.carBodyID = car.CarBodyID "+
                "AND fuelSystem.fuelSystemID = engine.fuelSystemID "+
                "AND driveWheel.driveWheelID = car.driveWheelID "+
                "AND aspiration.aspirationID = engine.aspirationID "+
                "AND engineType.engineTypeID = engine.engineTypeID "+
                "AND engineLocation.engineLocationID = car.engineLocationID "+
                "AND engine.fuelTypeID = fuelType.fuelTypeID "+
                "AND Car.carID = " + _carid.ToString() + ";";
            MainForm.cnn.Open();
           
            SqlCommand command = new SqlCommand(SQL, MainForm.cnn);
            SqlDataReader sReader;
            sReader = command.ExecuteReader();

            while (sReader.Read())
            {
                this.Text = "#Edit Form";
                

                //customiziable car values
                textModel.Text = sReader["carName"].ToString();
                numberPrice.Value = (decimal)sReader["price"];
                numberHighwayMPG.Value = (int)sReader["HighwayMPG"];
                numberCityMPG.Value = (int)sReader["CityMPG"];
                numberHeight.Value = (decimal)sReader["carHeight"];
                numberWeight.Value = (decimal)sReader["curbWeight"];
                numberWidth.Value = (decimal)sReader["carWidth"];
                numberWheelBase.Value = (decimal)sReader["wheelBase"];
                numberLength.Value = (decimal)sReader["carLength"];
                numberDoors.Value = (int)sReader["doorNumber"];

                //Comnbo boxes for customization
                comboBrand.SelectedItem = sReader["carBrandName"].ToString();
                comboBody.SelectedItem = sReader["carBodyName"].ToString();
                comboDriveWheel.SelectedItem = sReader["driveWheelName"].ToString();
                comboEngID.SelectedItem = (int)sReader["engineID"];
                comboEngLocation.SelectedItem = sReader["engineLocationName"].ToString();

                CylinderLabel.Text += sReader["cylinderNum"].ToString();
                HorseLabel.Text += sReader["horsePower"].ToString();
                CompLabel.Text += sReader["compressionRatio"].ToString();
                TypeLabel.Text += sReader["engineTypeName"].ToString();
                BoreLabel.Text += sReader["boreRatio"].ToString();
                SizeLabel.Text += sReader["engineSize"].ToString();
                StrokeLabel.Text += sReader["stroke"].ToString();
                RPMLabel.Text += sReader["peakRPM"].ToString();
                AspLabel.Text += sReader["aspirationType"].ToString();

                FuelSysLabel.Text += sReader["fuelSystemName"].ToString();
                FuelLabel.Text += sReader["fuelTypeName"].ToString();

            }
            MainForm.cnn.Close();
        }

        public void LoadComboBox()
        {
            SqlConnection cnn = MainForm.cnn;
            SqlCommand cmd;
            DataTable dt;
            SqlDataAdapter da;
            cnn.Open();

            //Brand comboBox
            comboBrand.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT carBrandName FROM carBrand ORDER BY carBrandID ASC;";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBrand.Items.Add(dr["carBrandName"].ToString());
            }

            //Body comboBox
            comboBody.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT carBodyName FROM carBody ORDER BY carbodyID ASC;";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBody.Items.Add(dr["carBodyName"].ToString());
            }


            //DriveWheel; comboBox
            comboDriveWheel.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT driveWheelName FROM driveWheel ORDER BY driveWheelID ASC;";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboDriveWheel.Items.Add(dr["driveWheelName"].ToString());
            }

            //EngineID comboBox
            comboEngID.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT engineID FROM engine ORDER BY engineID ASC;";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboEngID.Items.Add(dr["engineID"]);
            }

            //EngineLocation comboBox
            comboEngLocation.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT engineLocationName FROM engineLocation ORDER BY engineLocationID ASC;";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboEngLocation.Items.Add(dr["engineLocationName"]);
            }

            ////Aspiration comboBox
            //comboAsp.Items.Clear();
            //cmd = cnn.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT DISTINCT aspirationType FROM aspiration;";
            //cmd.ExecuteNonQuery();
            //dt = new DataTable();
            //da = new SqlDataAdapter(cmd);
            //da.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    comboAsp.Items.Add(dr["aspirationType"]);
            //}
            cnn.Close();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {

        }

        //When a user changes the engineID the engine and fuel specs will update with this method
        private void comboEngID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_counter >= 1)
            {
                SqlConnection cnn = MainForm.cnn;
                int engineID = (int)comboEngID.SelectedIndex + 1;
                string SQL = "SELECT engineSize, cylinderNum, compressionRatio, boreRatio, stroke, horsePower, peakRPM," +
                    " fuelSystemName, engineTypeName, fuelTypeName, aspirationType " +
                    "FROM engine, fuelSystem, engineType, fuelType, aspiration " +
                    "WHERE engine.engineID = " + engineID + " " +
                    "AND fuelSystem.fuelSystemID = engine.fuelSystemID " +
                    "AND engineType.engineTypeID = engine.engineTypeID " +
                    "AND fuelType.fuelTypeID = engine.fuelTypeID " +
                    "AND aspiration.aspirationID = engine.aspirationID;";
                cnn.Open();
                SqlCommand command = new SqlCommand(SQL, cnn);
                SqlDataReader Reader;
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    SizeLabel.Text = "Size: " + Reader["engineSize"].ToString();
                    CylinderLabel.Text = "Cylinders: " + Reader["cylinderNum"].ToString();
                    CompLabel.Text = "Compression Ratio: " + Reader["compressionRatio"].ToString();
                    FuelSysLabel.Text = "Fuel System: " + Reader["fuelSystemName"].ToString();
                    BoreLabel.Text = "Bore Ratio: " + Reader["boreRatio"].ToString();
                    HorseLabel.Text = "Horsepower: " + Reader["horsePower"].ToString();
                    RPMLabel.Text = "Peak RPM: " + Reader["peakRPM"].ToString();
                    TypeLabel.Text = "Type: " + Reader["engineTypeName"].ToString();
                    FuelLabel.Text = "Fuel: " + Reader["fuelTypeName"].ToString();
                    StrokeLabel.Text = "Stroke: " + Reader["stroke"].ToString();
                    AspLabel.Text = "Aspiration: " + Reader["aspirationType"].ToString();

                }
                cnn.Close();
            }

            _counter++;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            CarClass car = new CarClass(_carid, comboBrand.SelectedIndex + 1, comboBody.SelectedIndex + 1, comboDriveWheel.SelectedIndex + 1,
                                        comboEngID.SelectedIndex + 1, comboEngLocation.SelectedIndex + 1, textModel.Text, numberPrice.Value,
                                        numberWheelBase.Value, numberLength.Value, numberWidth.Value, numberHeight.Value,
                                        (int)numberDoors.Value, (int)numberCityMPG.Value, (int)numberHighwayMPG.Value, numberWeight.Value);
            car.UpdateCar();
            DialogResult = DialogResult.OK;
        }
    }
}
