-- Select Sorgular�

--******************************--
-- TEMEL SELECT ��LEMLER�

--******************************--
--SELECT * FROM Bolumler
--SELECT * FROM Dersler
--SELECT Ad, Kredi FROM Dersler
--SELECT
	--Ad AS 'DERS ADI',
--	Ad AS [DERS ADI],
--	Kredi AS 'A��rl�k'
--	FROM Dersler

--SELECT
--		dbo.Ogrenciler.Ad,
--		dbo.Ogrenciler.Soyad,
--		dbo.Ogrenciler.DogumTarihi
--		FROM dbo.Ogrenciler

--SELECT

--	 o.Ad,
--	 o.Soyad,
--	 o.DogumTarihi
--FROM Ogrenciler o
--SELECT
--	o.Ad+' ' + o.Soyad AS ��renci,
--	o.DogumTarihi AS [Do�um Tarihi]
--FROM Ogrenciler o

--******************************--
-- F�LTRELEME ��LEMLER�

--******************************--
--SELECT
--      *
--FROM Dersler d
--WHERE d.BolumId=2

--SELECT *
--FROM Dersler d
--WHERE d.Kredi>=6 AND d.BolumId=3

--SELECT *
--FROM Dersler d
--WHERE d.Kredi>=4 AND d.Kredi<=6
--WHERE d.Kredi BETWEEN 4 AND 6
--SELECT *
--FROM Ogrenciler o
----WHERE o.DogumTarihi IS NULL
--WHERE o.DogumTarihi IS NOT NULL,

SELECT SUM(d.Kredi) AS Toplam
FROM Dersler d