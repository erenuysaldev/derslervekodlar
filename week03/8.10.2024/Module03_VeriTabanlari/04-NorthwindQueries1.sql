--Products tablosundaki bütün kayýtlar

--SELECT 
--	p.ProductID AS [Id],
--	p.ProductName AS [Ürün],
--	p.UnitPrice AS [Fiyat],
--	p.UnitsInStock AS [Stok Miktarý]
--FROM Products p
--Maksimum minimum ve ortalama fiyatlarý ve ürün sayýsýný göstermek

--SELECT
--	MAX(p.UnitPrice) AS [Maksimum Fiyatý],
--	MIN(p.UnitPrice) AS [Minimum Fiyatý],
--	AVG(p.UnitPrice) AS [Ortalama Fiyat],
--	COUNT(*) AS [Ürün Sayýsý]
--FROM Products p

--elimizdeki ürünlerin toplam deðerini göstermek

--SELECT 
--	SUM(p.UnitPrice*p.UnitsInStock) AS [Toplam Stok Deðeri],
--	AVG(p.UnitPrice*p.UnitsInStock) AS [Toplam Stok Deðeri]
-- FROM Products p

--SELECT 
--	p.ProductName,
--	UPPER(p.ProductName) AS [Büyük harf],
--	LOWER(p.ProductName) AS [kücük harf]
--From Products p  
SELECT
	c.ContactName,
	REPLACE(REPLACE(LOWER(c.ContactName), ' ','_'),'é','e') AS [User Name]
	FROM Customers c