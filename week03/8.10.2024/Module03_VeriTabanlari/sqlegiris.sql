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

CREATE TABLE Ogrenciler(
Id INT PRIMARY KEY IDENTITY(1,1),
Ad NVARCHAR(50) NOT NULL,
Soyad NVARCHAR(50) NOT NULL,
DogumTarihi DATE NULL,
BolumId INT NOT NULL,
FOREIGN KEY(BolumId) REFERENCES Bolumler(Id)
)
GO
INSERT INTO Ogrenciler(BolumId,Ad,Soyad)
VALUES
     (1,'Ali','Cabbar'),
	 (1,'Sezen','Kara'),
	 (1,'Mehmet','Kendir'),

	 (2,'Cavit','Tutan'),
	 (2,'Kemal','Tutan'),
	 (2,'Fatma','Tutan'),
	 (2,'Ero','Tutan'),

	 (3,'Cehey','Tutan'),
	 (3,'dahey','Tutan'),
	 (3,'ahey','Tutan')

GO
INSERT INTO Ogrenciler(BolumId,Ad,Soyad,DogumTarihi)
VALUES
     (3,'Sinem','Kocak','1999-07-19')

GO
--Bilgisayar bölümüne öðrenci atýyoruz(1,2,3)
--Öðrenciler:1-2-3
--Dersler:1-2-3
CREATE TABLE OgrenciDersler(
OgrenciId INT NOT NULL,
DersId INT NOT NULL,
PRIMARY KEY (OgrenciId,DersId),
FOREIGN KEY(OgrenciId) REFERENCES Ogrenciler(Id)

)
GO
INSERT INTO OgrenciDersler(OgrenciId,DersId)
VALUES
(1,1),(1,3),
(2,1),(2,2),(2,3)
(3,3)
GO
--Elektrik bölümü öðrencilerine ders atýyoruz
--Öðrenciler 4,5,6,7
--dERSLER:4-5-6-7
INSERT INTO OgrenciDersler(OgrenciId,DersId)
VALUES
(4,4),(4,7),
(5,5),(5,6),(5,7),
(6,4),(6,5),(6,6),(6,7),
(7,6),(7,7)
--Makine bölümümne öðrencilerine ders atýyoruz
--öðrenciler:8-9
--Dersler:8-9-10-11-12
INSERT INTO OgrenciDersler(OgrenciId,DersId)
VALUES
      (8,8),(8,9),(8,10),(8,11),
	  (9,10),(9,12)
	  GO





USE MASTER
GO