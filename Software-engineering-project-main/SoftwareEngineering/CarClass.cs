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
    public class CarClass
    {
        int _id;
        int _brandId;
        int _carBodyId;
        int _driveWheelId;
        int _engineId;
        int _engineLocationId;

        string _name;
        decimal _price;
        decimal _wheelBase;
        decimal _length;
        decimal _width;
        decimal _height;
        int _doorNum;
        int _cityMPG;
        int _highwayMPG;
        decimal _curbWeight;

        public CarClass(int id, int brandID, int carBodyID, int driveWheelID, int engineID, int engineLocation,
                        string name, decimal price, decimal wheelBase, decimal length, decimal width,
                        decimal height, int doorNum, int cityMPG, int highwayMPG,
                        decimal curbWeight)
        {
            _id = id;
            _brandId = brandID;
            _carBodyId = carBodyID;
            _driveWheelId = driveWheelID;
            _engineId = engineID;
            _engineLocationId = engineLocation;

            _name = name;
            _price = price;
            _wheelBase = wheelBase;
            _length = length;
            _width = width;
            _height = height;
            _doorNum = doorNum;
            _cityMPG = cityMPG;
            _highwayMPG = highwayMPG;
            _curbWeight = curbWeight;
        }

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public int BrandID
        {
            get
            {
                return _brandId;
            }
            set
            {
                _brandId = value;
            }
        }

        public int CarBodyID
        {
            get
            {
                return _carBodyId;
            }
            set
            {
                _carBodyId = value;
            }
        }
        public int DriveWheelID
        {
            get
            {
                return _driveWheelId;
            }
            set
            {
                _driveWheelId = value;
            }
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

        public int EngineLocationID
        {
            get
            {
                return _engineLocationId;
            }
            set
            {
                _engineLocationId = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public decimal WheelBase
        {
            get
            {
                return _wheelBase;
            }
            set
            {
                _wheelBase = value;
            }
        }

        public decimal Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }

        public decimal Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public decimal Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public int DoorNumber
        {
            get
            {
                return _doorNum;
            }
            set
            {
                _doorNum = value;
            }
        }

        public int CityMPG
        {
            get
            {
                return _cityMPG;
            }
            set
            {
                _cityMPG = value;
            }
        }

        public int HighwayMPG
        {
            get
            {
                return _highwayMPG;
            }
            set
            {
                _highwayMPG = value;
            }
        }

        public decimal CurbWeight
        {
            get
            {
                return _curbWeight;
            }
            set
            {
                _curbWeight = value;
            }
        }

        public void UpdateCar()
        {
            string query = "UPDATE car SET carBrandID = " + this.BrandID + ", carName = '" + this.Name+ "', carBodyID = " + this.CarBodyID + ", driveWheelID = " + this.DriveWheelID +
                            ", engineID = " + this.EngineID + ", engineLocationID = " + this.EngineLocationID + ", price = " + this.Price + ", wheelBase = " + this.WheelBase +
                            ", carLength = " + this.Length + ", carWidth = " + this.Width + ", carHeight = " + this.Height + ", curbWeight = " + this.CurbWeight +
                            ", doorNumber = " + this.DoorNumber + ", cityMPG = " + this.CityMPG + ", highwayMPG = " + this.HighwayMPG +
                            " WHERE carID = " + this.ID + ";";
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

