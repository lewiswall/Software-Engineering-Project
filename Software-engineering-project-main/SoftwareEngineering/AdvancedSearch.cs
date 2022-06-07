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

namespace SoftwareEngineering
{
    public partial class AdvancedSearch : UserControl
    {
        SqlConnection connection;
        private string connectionString;

        public AdvancedSearch()
        {
            InitializeComponent();
        }
        public void LoadDataString() 
        {
            connectionString = MainForm.connectionString;
        }

        public void updateTable()
        {
            string value = textBox1.Text;
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT carID, carBrandName AS Brand, carName AS Model, fuelTypeName AS Fuel_Type, carBodyName AS Body, engineSize AS Engine_Size, horsePower AS BHP, ((cityMPG + highwayMPG)/2) AS Combined_MPG, price AS Price " +
            "FROM car, carBody, carBrand, engine, fuelType WHERE car.carBrandID = carBrand.carBrandID " +
            "AND car.engineID = engine.engineID AND engine.fuelTypeID = fuelType.fuelTypeID AND car.carBodyID = carBody.carBodyID AND (carName LIKE '%" + value + "%' OR carBrandName LIKE '%" + value + "%');", connection))
            {
                DataTable carTable = new DataTable();
                adapter.Fill(carTable);

                dataGridView1.DataSource = carTable;
                dataGridView1.Columns[0].Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            updateTable();
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
    }
}
