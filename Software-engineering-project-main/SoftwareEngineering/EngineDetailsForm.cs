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
    public partial class EngineDetailsForm : Form
    {
        private int _engineid;
        public EngineDetailsForm(int engineid)
        {
            InitializeComponent();
            _engineid = engineid;
        }

        public void LoadEngine()
        {
            string SQL = "SELECT fuelTypeName, engine.engineID, " +
                "engineSize, horsePower, aspirationType, fuelSystemName, " +
                "engineTypeName, cylinderNum, boreRatio, stroke, compressionRatio, " +
                "horsePower, peakRPM " +
                "FROM engine, fuelType, aspiration, " +
                "engineType, fuelSystem " +
                "WHERE fuelSystem.fuelSystemID = engine.fuelSystemID " +
                "AND aspiration.aspirationID = engine.aspirationID " +
                "AND engineType.engineTypeID = engine.engineTypeID " +
                "AND engine.fuelTypeID = fuelType.fuelTypeID " +
                "AND engine.engineID = " + _engineid.ToString() + ";";
            MainForm.cnn.Open();

            SqlCommand command = new SqlCommand(SQL, MainForm.cnn);
            SqlDataReader sReader;
            sReader = command.ExecuteReader();

            while (sReader.Read())
            {
                this.Text = "# " + _engineid.ToString();

                TypeLabel.Text = "Type:  " + sReader["engineTypeName"].ToString();
                StrokeLabel.Text = "Stroke:  " + sReader["stroke"].ToString();
                AspirationLabel.Text = "Aspiration:  " + sReader["aspirationType"].ToString();
                CompLabel.Text = "Compression Ratio:  " + sReader["compressionRatio"].ToString();
                BoreLabel.Text = "Bore Ratio:  " + sReader["boreRatio"].ToString();
                SizeLabel.Text = "Size:  " + sReader["engineSize"].ToString();
                BHPLabel.Text = "BHP:  " + sReader["horsePower"].ToString();
                RPMLabel.Text = "Peak RPM:  " + sReader["peakRPM"].ToString();
                CylinderLabel.Text = "Cylinders:  " + sReader["cylinderNum"].ToString();

                FuelLabel.Text = "Fuel:  " + sReader["fuelTypeName"].ToString();
                SystemLabel.Text = "Fuel System:  " + sReader["fuelSystemName"].ToString();
            }
            MainForm.cnn.Close();

        }

        private void editForm_Click(object sender, EventArgs e)
        {
            EditEngineForm editEngine = new EditEngineForm(_engineid);
            editEngine.LoadComboBoxes();
            editEngine.LoadEngine();
            if(editEngine.ShowDialog() == DialogResult.OK)
            {

            }
            editEngine.Dispose();
            LoadEngine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Deletion
            SqlCommand cmd;
            MainForm.cnn.Open();
            cmd = MainForm.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM engine WHERE engineID = '" + _engineid.ToString() + "';";
            cmd.ExecuteNonQuery();
            MainForm.cnn.Close();
            DialogResult = DialogResult.OK;
            MessageBox.Show("This engine has been deleted.");
        }

        //Just need to add the edit form.


    }
}
