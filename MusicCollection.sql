--CREATE DATABASE MusicCollection;

--USE MusicCollection;
--GO

--CREATE TABLE Artists 
--(
--    ArtistID INT PRIMARY KEY IDENTITY(1,1),
--    Name NVARCHAR(100) NOT NULL UNIQUE
--);

--CREATE TABLE Genres 
--(
--    GenreID INT PRIMARY KEY IDENTITY(1,1),
--    GenreName NVARCHAR(50) NOT NULL UNIQUE
--);

--CREATE TABLE Years 
--(
--    YearID INT PRIMARY KEY IDENTITY(1,1),
--    YearValue INT NOT NULL UNIQUE
--);

--CREATE TABLE Records 
--(
--    RecordID INT PRIMARY KEY IDENTITY(1,1),
--    Title NVARCHAR(100) NOT NULL,
--    ArtistID INT NOT NULL,
--    Publisher NVARCHAR(100) NOT NULL,
--    TracksCount INT NOT NULL,
--    GenreID INT NOT NULL,
--    YearID INT NOT NULL,
--    Cost DECIMAL(10, 2) NOT NULL,
--    SalePrice DECIMAL(10, 2) NOT NULL,
--    FOREIGN KEY (ArtistID) REFERENCES Artists(ArtistID),
--    FOREIGN KEY (GenreID) REFERENCES Genres(GenreID),
--    FOREIGN KEY (YearID) REFERENCES Years(YearID)
--);

--CREATE TABLE Users 
--(
--    UserID INT PRIMARY KEY IDENTITY(1,1),
--    Username NVARCHAR(50) NOT NULL UNIQUE,
--    Password NVARCHAR(50) NOT NULL,
--    AccessLevel INT NOT NULL
--);

--ALTER TABLE Records
--ADD StockCount INT NOT NULL DEFAULT 0,  -- Количество на складе для продажи
--    IsOnSale BIT NOT NULL DEFAULT 0;    -- Есть ли акция на данную запись

--INSERT INTO Artists (Name) VALUES
--('The Beatles'),
--('Pink Floyd'),
--('Michael Jackson'),
--('AC/DC'),
--('Fleetwood Mac');

--INSERT INTO Genres (GenreName) VALUES
--('Rock'),
--('Progressive Rock'),
--('Pop'),
--('Hard Rock'),
--('Classic');

--INSERT INTO Years (YearValue) VALUES
--(1969),
--(1973),
--(1982),
--(1980),
--(1977);

--INSERT INTO Records (Title, ArtistID, Publisher, TracksCount, GenreID, YearID, Cost, SalePrice, StockCount, IsOnSale) VALUES
--('Abbey Road', 1, 'Apple Records', 17, 1, 1, 10.00, 20.00, 50, 0),
--('Dark Side of the Moon', 2, 'Harvest Records', 10, 2, 2, 12.00, 25.00, 30, 0),
--('Thriller', 3, 'Epic Records', 9, 3, 3, 15.00, 30.00, 20, 1),  -- Есть акция
--('Back in Black', 4, 'Albert Productions', 10, 4, 4, 11.00, 22.00, 10, 1),  -- Есть акция
--('Rumours', 5, 'Reprise Records', 11, 1, 5, 14.00, 28.00, 5, 0);


--INSERT INTO Users (Username, Password, AccessLevel) VALUES
--('admin', 'admin', 1), -- максимальный уровень доступа
--('user1', 'password1', 0),
--('user2', 'password2', 0),
--('user3', 'password3', 0),
--('user4', 'password4', 0);


