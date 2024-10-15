--JOIN: sql'de birden fazla tabloyu birleþtirebilmek için kullandýðýmýz yapýya JOIN diyoruz
--JOIN, ilgili tablolarýn ilgili alanlarý üzerinden iliþki kurarak gerçekleþtirilir.

--Join Türleri:

--1) (INNER) JOIN: Her iki tablodaki eþleþen deðerlere sahip KAYITLARI döndürür.
--SELECT *
--FROM Categories c JOIN Products p ON c.CategoryID=p.CategoryID
--2) LEFT JOIN: Sol taraftaki tüm kayýtlarý, sað taraftaki ise eþleþen kayýtlarý döndürür
--3) RIGHT JOIN: SAÐ taraftaki tüm kayýtlarý, SOLtaraftaki ise eþleþen kayýtlarý döndürür
--SELECT *
--FROM Categories c LEFT JOIN Products p ON c.CategoryID=p.CategoryID
--SELECT*
--FROM Categories c RIGHT JOIN Products p ON c.CategoryID=p.CategoryID
-- 4-OUTER(FULL) JOIN:Her iki taraftaki tüm kayýtlarý getirir.
--Select *
--FROM Categories c  FULL  JOIN Products p ON c.CategoryID=p.CategoryID

--Hangi Sipariþ,hangi çalýþan tarafýndan , hangi müþteri için verilmiþtir?
--SipariþId         Sipariþ Tarihi    Çalýþan       Müþteri
--10240             2005-5-19        ero            eroo
--SELECT
--  o.OrderID AS [Sipariþ Id],
--  o.orderDate AS [Sipariþ Tarihi],
--  e.FirstName + ' ' + e.LastName AS [Çalýþan],
--  c.CompanyName AS [Müþteri]
--FROM Orders o
--    JOIN Employees e ON o.EmployeeID=e.EmployeeID
--		JOIN Customers c ON o.CustomerID=c.CustomerID

--Bugüne kadar hangi ülkelere kargo gönderimi yapmýþýz
--SELECT DISTINCT o.ShipCountry
--FROM Orders o

--Bugüne kadar hangi ülkelere kaç kez  kargo gönderimi yapmýþýz

--SELECT 
--	o.ShipCountry AS [Ülke],
--	COUNT(*) AS [Kargo Gönderim Sayisi],
--	SUM(o.Freight)AS [Kargo Masrafý]
	
--FROM Orders o
--GROUP BY o.ShipCountry
----ORDER BY o.ShipCountry DESC  -- order artan sýraya göre yani a dan z ye DESC YAZINCADA TAM TERSI
--ORDER BY [Kargo Gönderim Sayisi] desc, [Kargo Masrafý] desc

--kategorilerine göre toplam stok miktarýný gösterelim
--SELECT
-- c.CategoryName AS [Kategori],
-- SUM(p.UnitsInStock) AS [Toplam Stok Miktarý ]
--FROM Categories c
-- JOIN Products p ON c.CategoryID=p.CategoryID
-- GROUP BY c.CategoryName
-- Bugüne kadar ne kadarlýk satýþ yapmýþýz(ciro)
--SELECT
--	SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS [Ciro]
--	FROM OrderDetails od
	--ödev: Sonucu ondalýklý kýsmý 2 basamak gösterecek þekilde nasýl bir sorgu yazarýz ?
	SELECT
	od.ProductID AS [Ürün],
	SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS [Ciro]
	FROM OrderDetails od
	JOIN Products p ON od.ProductID=p.ProductID
	group by P.ProductName

	--Hnagi bölgede ne kadarlýk satýlmýþ

