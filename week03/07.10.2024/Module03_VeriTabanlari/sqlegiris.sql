USE master
GO
DROP DATABASE IF EXISTS OkulDb
GO
CREATE DATABASE OkulDb
GO
USE OkulDb
GO
CREATE TABLE Bolumler(
 Id INT PRIMARY KEY IDENTITY(1,1),
 Ad NVARCHAR(50) NOT NULL,
)
GO

INSERT INTO Bolumler(Ad)
VALUES
     ('Bilgisayar Mühendisliði'),
	 ('Elektrik Mühendisliði'),
	 ('Makine Mühendisliði')
GO
CREATE TABLE Dersler(
    Id INT PRIMARY KEY IDENTITY(1,1),
	Ad NVARCHAR(100) NOT NULL,
	Kredi TINYINT NOT NULL,
	BolumId INT NOT NULL,
	FOREIGN KEY(BolumId) REFERENCES Bolumler(Id)
)
GO

INSERT INTO Dersler(Ad,Kredi,BolumId)
VALUES
     ('Programlama Dilleri',6,1),
	 ('Veritabaný Yönetimi',4,1),
	 ('Algoritmalar',3,1),

	 ('Devre Teorisi',8,2),
	 ('Temel Elektronik',4,2),

	 ('Makine Mühendisliðine Giriþ',4,3),
	 ('Termodinamik',6,3),
	 ('Akýþkanlar Mekaniði',8,3),
	 ('Mesleki Ýngilizce',4,3)

