CREATE TABLE engineLocation(
engineLocationID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
engineLocationName VARCHAR(100) NOT NULL
);

CREATE TABLE driveWheel(
driveWheelID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
driveWheelName VARCHAR(100) NOT NULL
);

CREATE TABLE fuelType(
fuelTypeID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
fuelTypeName VARCHAR(100) NOT NULL
);

CREATE TABLE fuelSystem(
fuelSystemID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
fuelSystemName VARCHAR(100) NOT NULL
);

CREATE TABLE engineType(
engineTypeID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
engineTypeName VARCHAR(100) NOT NULL
);

CREATE TABLE aspiration(
aspirationID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
aspirationType VARCHAR(100) NOT NULL
);

CREATE TABLE carBrand(
carBrandID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
carBrandName VARCHAR(100) NOT NULL
);

CREATE TABLE carBody(
carBodyID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
carBodyName VARCHAR(100) NOT NULL
);

CREATE TABLE engine(
engineID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
aspirationID INT FOREIGN KEY REFERENCES aspiration(aspirationID),
fuelTypeID INT FOREIGN KEY REFERENCES fuelType(fuelTypeID),
fuelSystemID INT FOREIGN KEY REFERENCES fuelSystem(fuelSystemID),
engineTypeID INT FOREIGN KEY REFERENCES engineType(engineTypeID),
cylinderNum INT NOT NULL,
engineSize DECIMAL(4, 2) NOT NULL, 
boreRatio DECIMAL(4, 2) NOT NULL,
stroke DECIMAL(4, 2) NOT NULL,
compressionRatio DECIMAL(4, 2) NOT NULL,
horsePower INT NOT NULL,
peakRPM INT NOT NULL
);

CREATE TABLE car(
carID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
carBrandID INT FOREIGN KEY REFERENCES carBrand(carBrandID),
carBodyID INT FOREIGN KEY REFERENCES carBody(carBodyID),
driveWheelID INT FOREIGN KEY REFERENCES driveWheel(driveWheelID),
engineID INT FOREIGN KEY REFERENCES engine(engineID),
engineLocationID INT FOREIGN KEY REFERENCES engineLocation(engineLocationID),
carName VARCHAR(100) NOT NULL,
price MONEY NOT NULL,
wheelBase DECIMAL(8, 2) NOT NULL,
carLength DECIMAL(8, 2) NOT NULL,
carWidth DECIMAL(8, 2) NOT NULL,
carHeight DECIMAL(8, 2) NOT NULL,
curbWeight DECIMAL(10, 2) NOT NULL,
doorNumber INT NOT NULL,
cityMPG INT NOT NULL,
highwayMPG INT NOT NULL
);

