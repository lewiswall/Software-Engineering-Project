using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SoftwareEngineering
{
    class EngineClass
    {
        int _engineId;
        int _aspirationId;
        int _fuelSystemId;
        int _fuelId;
        int _engineTypeId;
        decimal _engineSize;
        decimal _boreRatio;
        decimal _stroke;
        decimal _compressionRatio;
        int _horsepower;
        int _peakRPM;
        int _cylinders;

        public EngineClass(int engineID, int aspirationID, int fuelSystemID, int fuelID,
                           int engineTypeID, decimal engineSize, decimal boreRatio, decimal stroke,
                           decimal compressionRatio, int horsepower, int peakRPM, int cylinders)
        {
            _engineId = engineID;
            _aspirationId = aspirationID;
            _fuelSystemId = fuelSystemID;
            _fuelId = fuelID;
            _engineTypeId = engineTypeID;
            _engineSize = engineSize;
            _boreRatio = boreRatio;
            _stroke = stroke;
            _compressionRatio = compressionRatio;
            _horsepower = horsepower;
            _peakRPM = peakRPM;
            _cylinders = cylinders;
        }

        public int EngineID
        {
            get
            {
                return _engineId;
            }
            set
            {
                _engineId = value;
            }
        }

        public int AspirationID
        {
            get
            {
                return _aspirationId;
            }
            set
            {
                _aspirationId = value;
            }
        }

        public int FuelSystemID
        {
            get
            {
                return _fuelSystemId;
            }
            set
            {
                _fuelSystemId = value;
            }
        }

        public int FuelID
        {
            get
            {
                return _fuelId;
            }
            set
            {
                _fuelId = value;
            }
        }

        public int EngineTypeID
        {
            get
            {
                return _engineTypeId;
            }
            set
            {
                _engineTypeId = value;
            }
        }

        public decimal EngineSize
        {
            get
            {
                return _engineSize;
            }
            set
            {
                _engineSize = value;
            }
        }

        public decimal BoreRatio
        {
            get
            {
                return _boreRatio;
            }
            set
            {
                _boreRatio = value;
            }
        }

        public decimal Stroke
        {
            get
            {
                return _stroke;
            }
            set
            {
                _stroke = value;
            }
        }

        public decimal CompressionRatio
        {
            get
            {
                return _compressionRatio;
            }
            set
            {
                _compressionRatio = value;
            }
        }

        public int Horsepower
        {
            get
            {
                return _horsepower;
            }
            set
            {
                _horsepower = value;
            }
        }

        public int PeakRPM
        {
            get
            {
                return _peakRPM;
            }
            set
            {
                _peakRPM = value;
            }
        }

        public int Cylinders
        {
            get
            {
                return _cylinders;
            }
            set
            {
                _cylinders = value;
            }
        }

        public void UpdateEngine()
        {
            string query = "UPDATE engine SET aspirationID = " + this.AspirationID + ", fuelTypeID = " + this.FuelID + ", fuelSystemID  = " + this.FuelSystemID +
                            ", engineTypeID = " + this.EngineTypeID + ", cylinderNum = " + this.Cylinders + ", engineSize = " + this.EngineSize +
                            ", boreRatio = " + this.BoreRatio + ", stroke = " + this.Stroke + ", compressionRatio = " + this.CompressionRatio +
                            ", horsePower = " + this.Horsepower + ", peakRPM = " + this.PeakRPM + " WHERE engineID = " + this.EngineID + ";";

            SqlConnection connection = MainForm.cnn;
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader sReader;
            try
            {
                connection.Open();
                sReader = command.ExecuteReader();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
}
