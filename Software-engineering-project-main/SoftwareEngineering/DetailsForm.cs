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
    public partial class DetailsForm : Form
    {
        private int _carid;
        
        public DetailsForm(int carid)
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
                "engineTypeName, cylinderNum,boreRatio, stroke, compressionRatio, "+
                "horsePower, peakRPM "+
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
                this.Text = "# " + _carid.ToString() +" "+ sReader["carName"].ToString();

                BrandLabel.Text = "Brand:  " + sReader["carBrandName"].ToString();
                ModelLabel.Text = "Model:  " + sReader["carName"].ToString();
                DriveLabel.Text = "Drive Wheel:  " + sReader["driveWheelName"].ToString();
                CityLabel.Text = "City MPG:  " + sReader["cityMPG"].ToString();
                HighwayLabel.Text = "Highway MPG:  " + sReader["highwayMPG"].ToString();
                PriceLabel.Text = "Price:  " + sReader["price"].ToString();
                LocationLabel.Text = "Engine Location:  " + sReader["engineLocationName"].ToString();

                BodyLabel.Text = "Body:  " + sReader["carBodyName"].ToString();
                DoorLabel.Text = "Door Number:  " + sReader["doorNumber"].ToString();
                HeightLabel.Text = "Height:  " + sReader["carHeight"].ToString();
                WidthLabel.Text = "Width:  " + sReader["carWidth"].ToString();
                WeightLabel.Text = "Weight:  " + sReader["curbWeight"].ToString();
                WheelLabel.Text = "Wheel base:  " + sReader["wheelBase"].ToString();

                CylinderLabel.Text = "Cylinders:  " + sReader["cylinderNum"].ToString();
                HorseLabel.Text = "BHP:  " + sReader["horsePower"].ToString();
                AspLabel.Text = "Aspiration:  " + sReader["aspirationType"].ToString();
                CompLabel.Text = "Compression Ratio:  " + sReader["compressionRatio"].ToString();
                TypeLabel.Text = "Engine Type:  " + sReader["engineTypeName"].ToString();
                BoreLabel.Text = "Bore Ratio:  " + sReader["boreRatio"].ToString();
                SizeLabel.Text = "Engine Size:  " + sReader["engineSize"].ToString();
                StrokeLabel.Text = "Stroke:  " + sReader["stroke"].ToString();
                RPMLabel.Text = "Peak RPM:  " + sReader["peakRPM"].ToString();

                FuelSysLabel.Text = "Fuel System:  " + sReader["fuelSystemName"].ToString();
                FuelLabel.Text = "Fuel Type:  " + sReader["fuelTypeName"].ToString();

            }
            MainForm.cnn.Close();

        }

       

        private void DetailsForm_Load(object sender, EventArgs e)
        {

        }


        private void editForm_Click(object sender, EventArgs e)
        {
            EditForm Editform = new EditForm(_carid);
            Editform.LoadComboBox();
            Editform.LoadCar();

            if (Editform.ShowDialog() == DialogResult.OK)
            {
                //GO BACK TO MAIN FORM
            }
            Editform.Dispose();
            LoadCar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Deletion
            SqlCommand cmd;
            MainForm.cnn.Open();
            cmd = MainForm.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM car WHERE carID = '" + _carid.ToString() + "';";
            cmd.ExecuteNonQuery();
            MainForm.cnn.Close();
            DialogResult = DialogResult.OK;
            MessageBox.Show("This car has been deleted.");

        }
    }
}
