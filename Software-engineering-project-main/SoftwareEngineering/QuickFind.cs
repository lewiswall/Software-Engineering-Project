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
    public partial class QuickFind : UserControl
    {
        private string StartSQL = "SELECT carID, carBrandName AS Brand, carName AS Model, fuelTypeName AS Fuel_Type, carBodyName AS Body, " +
        "engineSize AS Engine_Size, horsePower AS BHP, ((cityMPG + highwayMPG)/2) AS Combined_MPG, price AS Price " +
        "FROM car, carBody, carBrand, engine, fuelType " +
        "WHERE car.carBrandID = carBrand.carBrandID " +
        "AND car.engineID = engine.engineID " +
        "AND engine.fuelTypeID = fuelType.fuelTypeID " +
        "AND car.carBodyID = carBody.carBodyID ";

        private string BrandFilter;
        private string ModelFilter;
        private string FuelTypeFilter;
        private string BodyFilter;
        private string EngineFilter;
        private string BHPFilter;
        private string MPGFilter;
        private string PriceFilter;
        private string EndSQL = "ORDER BY carBrandName;";

        public QuickFind()
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
                PriceFilter = "";

                if (FilterBrandBox.SelectedIndex >= 1)
                {
                    BrandFilter = "AND carBrandName = '" + FilterBrandBox.Text + "' ";
                }
                if (FilterModelBox.SelectedIndex >= 1)
                {
                    ModelFilter = "AND carName = '" + FilterModelBox.Text + "' ";
                }
                if (FilterFuelBox.SelectedIndex >= 1)
                {
                    FuelTypeFilter = "AND FuelTypeName = '" + FilterFuelBox.Text + "' ";
                }
                if (FilterBodyBox.SelectedIndex >= 1)
                {
                    BodyFilter = "AND carBodyName = '" + FilterBodyBox.Text + "' ";
                }
                if (FilterEngineBox.SelectedIndex >= 1)
                {
                    EngineFilter = "AND engineSize = '" + FilterEngineBox.Text + "' ";
                }
                if (FilterBHPBox.SelectedIndex >= 1)
                {
                    BHPFilter = "AND horsePower = '" + FilterBHPBox.Text + "' ";
                }
                if (FilterMPGBox.SelectedIndex >= 1)
                {
                    BHPFilter = "AND ((cityMPG + highwayMPG) / 2) = '" + FilterMPGBox.Text + "' ";
                }
                if (FilterPriceBox.SelectedIndex >= 1)
                {
                    PriceFilter = "AND price = '" + FilterPriceBox.Text + "' ";
                }

                SqlDataAdapter adapter;
                string sql = StartSQL + BrandFilter + ModelFilter + FuelTypeFilter + BodyFilter +
                EngineFilter + BHPFilter + MPGFilter + PriceFilter + EndSQL;
                adapter = new SqlDataAdapter(sql, MainForm.cnn);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                adapter.Fill(table);
                MainForm.bindingSource1.DataSource = table;
                dataGridView1.DataSource = MainForm.bindingSource1;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns[0].Visible = false;

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


                int id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
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
            FilterBrandBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT carBrandName FROM carBrand;";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterBrandBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterBrandBox.Items.Add(dr["carBrandName"].ToString());
            }

            //Model comboBox
            FilterModelBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT carName FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterModelBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterModelBox.Items.Add(dr["carName"].ToString());
            }

            //FuelType comboBox
            FilterFuelBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT fuelTypeName FROM fuelType";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterFuelBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterFuelBox.Items.Add(dr["fuelTypeName"].ToString());
            }

            //BodyType comboBox
            FilterBodyBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT carBodyName FROM carBody";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterBodyBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterBodyBox.Items.Add(dr["carBodyName"].ToString());
            }

            //EngineSize comboBox
            FilterEngineBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT engineSize FROM engine";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterEngineBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterEngineBox.Items.Add(dr["engineSize"].ToString());
            }

            //Horsepower comboBox
            FilterBHPBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT horsePower FROM engine";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterBHPBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterBHPBox.Items.Add(dr["horsePower"].ToString());
            }

            //Combined MPG comboBox
            FilterMPGBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT ((cityMPG + highwayMPG)/2) AS combinedMPG FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterMPGBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterMPGBox.Items.Add(dr["combinedMPG"].ToString());
            }

            //Price comboBox
            FilterPriceBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT price FROM car";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterPriceBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterPriceBox.Items.Add(dr["price"].ToString());
            }

            cnn.Close();
        }



        private void comboChange(object sender, EventArgs e)
        {
            updateTable();
        }
    }
}
