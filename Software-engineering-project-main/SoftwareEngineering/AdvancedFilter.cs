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
    public partial class AdvancedFilter : UserControl
    {

        private string StartSQL = "SELECT carID, carBrandName AS Brand, carName AS Model, fuelTypeName AS Fuel_Type, carBodyName AS Body, " +
        "engineSize AS Engine_Size, horsePower AS BHP, ((cityMPG + highwayMPG)/2) AS Combined_MPG, price AS Price " +
        "FROM car, carBody, carBrand, engine, fuelType, aspiration, " +
        "engineType, fuelSystem, driveWheel, engineLocation " +
        "WHERE car.carBrandID = carBrand.carBrandID " +
        "AND car.engineID = engine.engineID " +
        "AND carBody.carBodyID = car.CarBodyID " +
        "AND fuelSystem.fuelSystemID = engine.fuelSystemID " +
        "AND driveWheel.driveWheelID = car.driveWheelID " +
        "AND aspiration.aspirationID = engine.aspirationID " +
        "AND engineType.engineTypeID = engine.engineTypeID " +
        "AND engineLocation.engineLocationID = car.engineLocationID " +
        "AND engine.fuelTypeID = fuelType.fuelTypeID ";
        private string BrandFilter = "";
        private string ModelFilter = "";
        private string FuelTypeFilter = "";
        private string BodyFilter = "";
        private string EngineFilter = "";
        private string BHPFilter = "";
        private string MPGFilter = "";
        private string CMPGFilter = "";
        private string HMPGFilter = "";
        private string PriceFilter = "";
        private string AspirationFilter = "";
        private string DoorFilter = "";
        private string DriveFilter = "";
        private string WheelbaseFilter = "";
        private string LengthFilter = "";
        private string WidthFilter = "";
        private string HeightFilter = "";
        private string WeightFilter = "";
        private string RPMFilter = "";
        private string CylinderFilter = "";
        private string SizeFilter = "";
        private string FuelSystemFilter = "";
        private string BoreFilter = "";
        private string StrokeFilter = "";
        private string CompressionFilter = "";

        //And other filters.
        private string EndSQL = "ORDER BY Brand;";


        public AdvancedFilter()
        {
            InitializeComponent();
        }

        public void StartTable()
        {
            updateTable();
            FillCombo();
        }

        //LOADING DATA FROM THE DATABASE
        //CALL THIS WHEN CHANGING THE COMBOBOXES.
        //AND SET THE APPROPRIATE FILTER.
        //SO SET BRANDFILTER, FOR EXAMPLE, TO "AND carBrand = combovalue "

        public void updateTable()
        {
            try
            {
                BrandFilter = "";
                ModelFilter = "";
                FuelTypeFilter = "";
                BodyFilter = "";
                EngineFilter = "";
                BHPFilter = "";
                MPGFilter = "";
                CMPGFilter = "";
                HMPGFilter = "";
                PriceFilter = "";
                AspirationFilter = "";
                DoorFilter = "";
                DriveFilter = "";
                WheelbaseFilter = "";
                LengthFilter = "";
                WidthFilter = "";
                HeightFilter = "";
                WeightFilter = "";
                RPMFilter = "";
                CylinderFilter = "";
                SizeFilter = "";
                FuelSystemFilter = "";
                BoreFilter = "";
                StrokeFilter = "";
                CompressionFilter = "";


                if (FilterBrand.SelectedIndex >= 1)
                {
                    BrandFilter = "AND carBrandName = '" + FilterBrand.Text + "' ";
                }
                if (FilterModel.SelectedIndex >= 1)
                {
                    ModelFilter = "AND carName = '" + FilterModel.Text + "' ";
                }
                if (FilterFuel.SelectedIndex >= 1)
                {
                    FuelTypeFilter = "AND FuelTypeName = '" + FilterFuel.Text + "' ";
                }
                if (FilterBody.SelectedIndex >= 1)
                {
                    BodyFilter = "AND carBodyName = '" + FilterBody.Text + "' ";
                }
                if (FilterEngSize.SelectedIndex >= 1)
                {
                    EngineFilter = "AND engineSize = '" + FilterEngSize.Text + "' ";
                }
                if (FilterBHP.SelectedIndex >= 1)
                {
                    BHPFilter = "AND horsePower = '" + FilterBHP.Text + "' ";
                }
                if (FilterCombinedMPG.SelectedIndex >= 1)
                {
                    MPGFilter = "AND ((cityMPG + highwayMPG) / 2) = '" + FilterCombinedMPG.Text + "' ";
                }
                if (FilterCityMPG.SelectedIndex >= 1)
                {
                    CMPGFilter = "AND cityMPG = '" + FilterCityMPG.Text + "' ";
                }
                if (FilterHighwayMPG.SelectedIndex >= 1)
                {
                    HMPGFilter = "AND highwayMPG = '" + FilterHighwayMPG.Text + "' ";
                }
                if (FilterPrice.SelectedIndex >= 1)
                {
                    PriceFilter = "AND price = '" + FilterPrice.Text + "' ";
                }
                if (FilterAsp.SelectedIndex >= 1)
                {
                    AspirationFilter = "AND aspirationType = '" + FilterAsp.Text + "' ";
                }
                if (FilterDoor.SelectedIndex >= 1)
                {
                    DoorFilter = "AND doorNumber = '" + FilterDoor.Text + "' ";
                }
                if (FilterDrive.SelectedIndex >= 1)
                {
                    DriveFilter = "AND driveWheelName = '" + FilterDrive.Text + "' ";
                }
                if (FilterWheelB.SelectedIndex >= 1)
                {
                    WheelbaseFilter = "AND wheelBase = '" + FilterWheelB.Text + "' ";
                }
                if (FilterCylinder.SelectedIndex >= 1)
                {
                    CylinderFilter = "AND cylinderNum = '" + FilterCylinder.Text + "' ";
                }
                if (FilterFuelSys.SelectedIndex >= 1)
                {
                    FuelSystemFilter = "AND fuelSystemName = '" + FilterFuelSys.Text + "' ";
                }
                if (FilterStroke.SelectedIndex >= 1)
                {
                    StrokeFilter = "AND stroke = '" + FilterStroke.Text + "' ";
                }
                if (FilterCompress.SelectedIndex >= 1)
                {
                    CompressionFilter = "AND compressionRatio = '" + FilterCompress.Text + "' ";
                }
                if (FilterRPM.SelectedIndex >= 1)
                {
                    RPMFilter = "AND peakRPM = '" + FilterRPM.Text + "' ";
                }
                if (FilterWidth.SelectedIndex >= 1)
                {
                    WidthFilter = "AND carWidth = '" + FilterWidth.Text + "' ";
                }
                if (FilterHeight.SelectedIndex >= 1)
                {
                    HeightFilter = "AND carHeight = '" + FilterHeight.Text + "' ";
                }
                if (FilterWeight.SelectedIndex >= 1)
                {
                    WeightFilter = "AND curbWeight = '" + FilterWeight.Text + "' ";
                }
                if (FilterEngType.SelectedIndex >= 1)
                {
                    EngineFilter = "AND engineTypeName = '" + FilterEngType.Text + "' ";
                }
                if (FilterBore.SelectedIndex >= 1)
                {
                    BoreFilter = "AND boreRatio = '" + FilterBore.Text + "' ";
                }
                if (FilterLength.SelectedIndex >= 1)
                {
                    LengthFilter = "AND carLength = '" + FilterLength.Text + "' ";
                }

                //BORE AND LENGTH.




                SqlDataAdapter adapter;
                string sql = StartSQL + BrandFilter + ModelFilter + FuelTypeFilter + BodyFilter +
                EngineFilter + BHPFilter + MPGFilter + CMPGFilter + HMPGFilter + PriceFilter +
                AspirationFilter + DoorFilter + DriveFilter + WheelbaseFilter + LengthFilter +
                WidthFilter + HeightFilter + WeightFilter + RPMFilter + CylinderFilter +
                SizeFilter + FuelSystemFilter + BoreFilter + StrokeFilter + CompressionFilter + EndSQL;
                adapter = new SqlDataAdapter(sql, MainForm.cnn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                adapter.Fill(table);
                MainForm.bindingSource1.DataSource = table;
                FilterGrid.DataSource = MainForm.bindingSource1;
                FilterGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                FilterGrid.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
                Application.Exit();
            }
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                var senderGrid = (DataGridView)sender;


                int id = (int)FilterGrid.Rows[e.RowIndex].Cells[0].Value;
                DetailsForm Detailsform = new DetailsForm(id);
                Detailsform.LoadCar();
                if (Detailsform.ShowDialog() == DialogResult.OK)
                {
                    //GO BACK TO MAIN FORM
                }
                Detailsform.Dispose();
                updateTable();

            }

        }

        private void FillCombo()
        {
            SqlConnection cnn = MainForm.cnn;
            SqlCommand cmd;
            DataTable dt;
            SqlDataAdapter da;
            cnn.Open();

            //Brand comboBox
            FilterBrand.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT carBrandName FROM carBrand order by carBrandID asc";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterBrand.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterBrand.Items.Add(dr["carBrandName"].ToString());
            }

            //Model comboBox
            FilterModel.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT carName FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterModel.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterModel.Items.Add(dr["carName"].ToString());
            }

            //Fuel Type comboBox
            FilterFuel.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT fuelTypeNAme FROM fuelType";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterFuel.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterFuel.Items.Add(dr["fuelTypeName"].ToString());
            }


            //Aspiration comboBox
            FilterAsp.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT aspirationType FROM aspiration";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterAsp.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterAsp.Items.Add(dr["aspirationType"].ToString());
            }

            //Door Number comboBox
            FilterDoor.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT doorNumber FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterDoor.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterDoor.Items.Add(dr["doorNumber"].ToString());
            }

            //Body Type comboBox
            FilterBody.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT carBodyName FROM carBody";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterBody.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterBody.Items.Add(dr["carBodyName"].ToString());
            }

            //Drive Wheel comboBox
            FilterDrive.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT driveWheelName FROM driveWheel";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterDrive.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterDrive.Items.Add(dr["driveWheelName"].ToString());
            }

            //Wheel Base comboBox
            FilterWheelB.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT wheelBase FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterWheelB.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterWheelB.Items.Add(dr["WheelBase"].ToString());
            }

            //Length comboBox
            FilterLength.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT carLength FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterLength.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterLength.Items.Add(dr["carLength"].ToString());
            }

            //Width comboBox
            FilterWidth.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT carWidth FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterWidth.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterWidth.Items.Add(dr["carWidth"].ToString());
            }

            //Height comboBox
            FilterHeight.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT carHeight FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterHeight.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterHeight.Items.Add(dr["carHeight"].ToString());
            }

            //Weight comboBox
            FilterWeight.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT curbWeight FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterWeight.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterWeight.Items.Add(dr["curbWeight"].ToString());
            }

            //Engine Type comboBox
            FilterEngType.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT engineTypeName FROM engineType";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterEngType.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterEngType.Items.Add(dr["engineTypeName"].ToString());
            }

            //Cylinder comboBox
            FilterCylinder.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT cylinderNum FROM engine";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterCylinder.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterCylinder.Items.Add(dr["cylinderNum"].ToString());
            }

            //Engine Size comboBox
            FilterEngSize.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT engineSize FROM engine";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterEngSize.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterEngSize.Items.Add(dr["engineSize"].ToString());
            }

            //Fuel System comboBox
            FilterFuelSys.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT fuelSystemName FROM fuelSystem";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterFuelSys.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterFuelSys.Items.Add(dr["fuelSystemName"].ToString());
            }

            //Bore Ratio comboBox
            FilterBore.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT boreRatio FROM engine";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterBore.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterBore.Items.Add(dr["boreRatio"].ToString());
            }

            //Stroke comboBox
            FilterStroke.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT stroke FROM engine";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterStroke.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterStroke.Items.Add(dr["stroke"].ToString());
            }

            //Compression comboBox
            FilterCompress.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT compressionRatio FROM engine";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterCompress.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterCompress.Items.Add(dr["compressionRatio"].ToString());
            }

            //BHP comboBox
            FilterBHP.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT horsePower FROM engine";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterBHP.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterBHP.Items.Add(dr["horsePower"].ToString());
            }

            //RPM comboBox
            FilterRPM.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT peakRPM FROM engine";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterRPM.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterRPM.Items.Add(dr["peakRPM"].ToString());
            }

            //City MPG comboBox
            FilterCityMPG.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT cityMPG FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterCityMPG.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterCityMPG.Items.Add(dr["cityMPG"].ToString());
            }
            //Highway MPG comboBox
            FilterHighwayMPG.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT highwayMPG FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterHighwayMPG.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterHighwayMPG.Items.Add(dr["highwayMPG"].ToString());
            }

            //Combined MPG comboBox
            FilterCombinedMPG.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT ((cityMPG + highwayMPG)/2) AS combinedMPG FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterCombinedMPG.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterCombinedMPG.Items.Add(dr["combinedMPG"].ToString());
            }

            //Price comboBox
            FilterPrice.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT price FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterPrice.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterPrice.Items.Add(dr["price"].ToString());
            }
            cnn.Close();
        }

        private void comboChange(object sender, EventArgs e)
        {
            updateTable();
        }
    }
}