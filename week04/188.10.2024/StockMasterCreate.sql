-- StockMaster --

-- Varsa StockMaster veritaban�n� sil
IF EXISTS (SELECT * FROM sys.databases WHERE name='StockMaster')
BEGIN
	DROP DATABASE StockMaster
END
GO

-- StockMaster veritaban�n� olu�tur
CREATE DATABASE StockMaster
GO

-- StockMaster veritaban�n� se�, kullan�ma al
USE StockMaster
GO

-- Kategori tablosunu olu�tur
CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(100) NOT NULL,
	Description NVARCHAR(MAX)
)
GO

-- Tedarik�i tablosunu olu�tur
CREATE TABLE Suppliers(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(100) NOT NULL,
	ContactName NVARCHAR(100) NOT NULL,
	Phone VARCHAR(20),
	Address VARCHAR(250)
)
GO

-- �r�n tablosunu olu�tur
CREATE TABLE Products(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(100) NOT NULL,
	QuantityPerUnit VARCHAR(50),
	UnitPrice DECIMAL(18,2),
	UnitsInStock INT,
	Discounted BIT,
	ReorderLevel INT,
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	SupplierId INT FOREIGN KEY REFERENCES Suppliers(Id)
)
GO

-- Stok Hareketleri Tablosunu olu�turuyoruz
CREATE TABLE StockTransactions(
	Id INT PRIMARY KEY IDENTITY,
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	TransactionType VARCHAR(3) CHECK(TransactionType IN ('IN','OUT')),
	Quantity INT NOT NULL,
	TransactionDate DATETIME NOT NULL DEFAULT GETDATE()
)
GO

-- Kullan�c� tablosunu olu�turuyoruz
CREATE TABLE Users(
	Id INT PRIMARY KEY IDENTITY,
	UserName VARCHAR(50) NOT NULL,
	Password VARCHAR(100) NOT NULL,
	Role VARCHAR(50)
)
GO

