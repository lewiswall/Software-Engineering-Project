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
    public partial class ViewEngine : UserControl
    {
        private string StartSQL = "SELECT engine.engineID AS Engine_Number, engineTypeName AS Type, cylinderNum AS Cylinders, fuelTypeName AS Fuel_Type, fuelSystemName AS Fuel_System, " +
        "horsePower AS BHP " +
        "FROM engineType, fuelSystem, engine, fuelType, aspiration " +
        "WHERE engine.fuelSystemID = fuelSystem.fuelSystemID " +
        "AND engineType.engineTypeID = engine.engineTypeID "+
        "AND engine.fuelTypeID = fuelType.fuelTypeID "+
        "AND engine.aspirationID = aspiration.aspirationID "+
        "AND engine.fuelSystemID = fuelSystem.fuelSystemID ";

        private string EngTypeFilter;
        private string AspirationFilter;
        private string FuelTypeFilter;
        private string FuelSystemFilter;
        private string StrokeFilter;
        private string BHPFilter;
        private string SizeFilter;
        private string CylindersFilter;
        private string EndSQL = "ORDER BY Engine_Number;";


        public ViewEngine()
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
                EngTypeFilter = "";
                AspirationFilter = "";
                FuelTypeFilter = "";
                FuelSystemFilter = "";
                StrokeFilter = "";
                CylindersFilter = "";
                SizeFilter = "";
                BHPFilter = "";
                

                if (FilterTypeBox.SelectedIndex >= 1)
                {
                    EngTypeFilter = "AND engineTypeName = '" + FilterTypeBox.Text + "' ";
                }
                if (FilterAspBox.SelectedIndex >= 1)
                {
                    AspirationFilter = "AND aspirationType = '" + FilterAspBox.Text + "' ";
                }
                if (FilterFuelTypeBox.SelectedIndex >= 1)
                {
                    FuelTypeFilter = "AND fuelTypeName = '" + FilterFuelTypeBox.Text + "' ";
                }
                if (FilterFuelSysBox.SelectedIndex >= 1)
                {
                    FuelSystemFilter = "AND fuelSystemName = '" + FilterFuelSysBox.Text + "' ";
                }
                if (FilterStrokeBox.SelectedIndex >= 1)
                {
                    StrokeFilter = "AND stroke = '" + FilterStrokeBox.Text + "' ";
                }
                if (FilterBHPBox.SelectedIndex >= 1)
                {
                    BHPFilter = "AND horsePower = '" + FilterBHPBox.Text + "' ";
                }
                if (FilterCylinderBox.SelectedIndex >= 1)
                {
                    CylindersFilter = "AND cylinderNum = '" + FilterCylinderBox.Text + "' ";
                }
                if (FilterSizeBox.SelectedIndex >= 1)
                {
                    SizeFilter = "AND engineSize = '" + FilterSizeBox.Text + "' ";
                }

                SqlDataAdapter adapter;
                string sql = StartSQL + EngTypeFilter + AspirationFilter + FuelTypeFilter + FuelSystemFilter +
                StrokeFilter + BHPFilter + CylindersFilter + SizeFilter + EndSQL;
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
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
                Application.Exit();
            }
        }


        private void FilterGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                var senderGrid = (DataGridView)sender;

                int id = (int)FilterGrid.Rows[e.RowIndex].Cells[0].Value;
                EngineDetailsForm EngineDetailsform = new EngineDetailsForm(id);
                EngineDetailsform.LoadEngine();
                if (EngineDetailsform.ShowDialog() == DialogResult.OK)
                {
                    //GO BACK TO MAIN FORM
                }
                EngineDetailsform.Dispose();
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
            FilterTypeBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT engineTypeName FROM engineType;";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterTypeBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterTypeBox.Items.Add(dr["engineTypeName"].ToString());
            }

            //Model comboBox
            FilterAspBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT aspirationType FROM aspiration";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterAspBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterAspBox.Items.Add(dr["aspirationType"].ToString());
            }

            //FuelType comboBox
            FilterFuelTypeBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT fuelTypeName FROM fuelType";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterFuelTypeBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterFuelTypeBox.Items.Add(dr["fuelTypeName"].ToString());
            }

            //BodyType comboBox
            FilterFuelSysBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT fuelSystemName FROM fuelSystem";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterFuelSysBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterFuelSysBox.Items.Add(dr["fuelSystemName"].ToString());
            }

            //EngineSize comboBox
            FilterStrokeBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT stroke FROM engine";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterStrokeBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterStrokeBox.Items.Add(dr["stroke"].ToString());
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
            FilterCylinderBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT cylinderNum FROM engine";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterCylinderBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterCylinderBox.Items.Add(dr["cylinderNum"].ToString());
            }

            //Price comboBox
            FilterSizeBox.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT engineSize FROM engine";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            FilterSizeBox.Items.Add("ALL");
            foreach (DataRow dr in dt.Rows)
            {
                FilterSizeBox.Items.Add(dr["engineSize"].ToString());
            }

            cnn.Close();
        }



        private void comboChange(object sender, EventArgs e)
        {
            updateTable();
        }

    }
}
