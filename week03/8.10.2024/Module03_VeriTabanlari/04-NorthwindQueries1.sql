--Products tablosundaki b�t�n kay�tlar

--SELECT 
--	p.ProductID AS [Id],
--	p.ProductName AS [�r�n],
--	p.UnitPrice AS [Fiyat],
--	p.UnitsInStock AS [Stok Miktar�]
--FROM Products p
--Maksimum minimum ve ortalama fiyatlar� ve �r�n say�s�n� g�stermek

--SELECT
--	MAX(p.UnitPrice) AS [Maksimum Fiyat�],
--	MIN(p.UnitPrice) AS [Minimum Fiyat�],
--	AVG(p.UnitPrice) AS [Ortalama Fiyat],
--	COUNT(*) AS [�r�n Say�s�]
--FROM Products p

--elimizdeki �r�nlerin toplam de�erini g�stermek

--SELECT 
--	SUM(p.UnitPrice*p.UnitsInStock) AS [Toplam Stok De�eri],
--	AVG(p.UnitPrice*p.UnitsInStock) AS [Toplam Stok De�eri]
-- FROM Products p

--SELECT 
--	p.ProductName,
--	UPPER(p.ProductName) AS [B�y�k harf],
--	LOWER(p.ProductName) AS [k�c�k harf]
--From Products p  
SELECT
	c.ContactName,
	REPLACE(REPLACE(LOWER(c.ContactName), ' ','_'),'�','e') AS [User Name]
	FROM Customers c