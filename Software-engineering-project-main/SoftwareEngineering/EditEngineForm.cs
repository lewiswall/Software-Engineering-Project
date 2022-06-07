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
    public partial class EditEngineForm : Form
    {
        private int _engineid;
        public EditEngineForm(int engineid)
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

                /*TypeLabel.Text = "Type:  " + sReader["engineTypeName"].ToString();
                StrokeLabel.Text = "Stroke:  " + sReader["stroke"].ToString();
                AspirationLabel.Text = "Aspiration:  " + sReader["aspirationType"].ToString();
                CompLabel.Text = "Compression Ratio:  " + sReader["compressionRatio"].ToString();
                BoreLabel.Text = "Bore Ratio:  " + sReader["boreRatio"].ToString();
                SizeLabel.Text = "Size:  " + sReader["engineSize"].ToString();
                BHPLabel.Text = "BHP:  " + sReader["horsePower"].ToString();
                RPMLabel.Text = "Peak RPM:  " + sReader["peakRPM"].ToString();
                CylinderLabel.Text = "Cylinders:  " + sReader["cylinderNum"].ToString();

                FuelLabel.Text = "Fuel:  " + sReader["fuelTypeName"].ToString();
                SystemLabel.Text = "Fuel System:  " + sReader["fuelSystemName"].ToString();*/
                numBore.Value = (decimal)sReader["boreRatio"];
                numStroke.Value = (decimal)sReader["stroke"];
                numComp.Value = (decimal)sReader["compressionRatio"];
                numSize.Value = (decimal)sReader["engineSize"];
                numCylinder.Value = (int)sReader["cylinderNum"];
                numRPM.Value = (int)sReader["peakRPM"];
                numBHP.Value = (int)sReader["horsePower"];
                
                //Populating ComboBoxes
                comboAsp.SelectedItem = sReader["aspirationType"].ToString();
                comboEngType.SelectedItem = sReader["engineTypeName"].ToString();
                comboFuelSys.SelectedItem = sReader["fuelSystemName"].ToString();
                comboFuelType.SelectedItem = sReader["fuelTypeName"].ToString();
            }
            MainForm.cnn.Close();

        }

        public void LoadComboBoxes()
        {
            SqlConnection cnn = MainForm.cnn;
            SqlCommand cmd;
            DataTable dt;
            SqlDataAdapter da;
            cnn.Open();


            //EngineType Combo
            comboEngType.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT engineTypeName FROM engineType ORDER BY engineTypeID ASC;";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboEngType.Items.Add(dr["engineTypeName"].ToString());
            }

            //Aspiration Combo
            comboAsp.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT aspirationType FROM aspiration ORDER BY aspirationID ASC;";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboAsp.Items.Add(dr["aspirationType"].ToString());
            }

            //Fuel System Combo
            comboFuelSys.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT fuelSystemName FROM fuelSystem ORDER BY fuelSystemID ASC;";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboFuelSys.Items.Add(dr["fuelSystemName"].ToString());
            }
  

            // Fuel Type Combo
            comboFuelType.Items.Clear();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT fuelTypeName FROM fuelType ORDER BY fuelTypeID ASC;";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboFuelType.Items.Add(dr["fuelTypeName"].ToString());
            }
            cnn.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            EngineClass engine = new EngineClass(_engineid, comboAsp.SelectedIndex + 1, comboFuelSys.SelectedIndex + 1, comboFuelType.SelectedIndex + 1,
                                                 comboEngType.SelectedIndex + 1, numSize.Value, numBore.Value, numStroke.Value, numComp.Value,
                                                 (int)numBHP.Value, (int)numRPM.Value, (int)numCylinder.Value);
            engine.UpdateEngine();
            DialogResult = DialogResult.OK;
        }

        //Just need to add the edit form.


    }
}
