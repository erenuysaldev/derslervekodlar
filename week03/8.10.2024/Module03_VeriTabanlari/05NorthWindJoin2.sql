--JOIN: sql'de birden fazla tabloyu birle�tirebilmek i�in kulland���m�z yap�ya JOIN diyoruz
--JOIN, ilgili tablolar�n ilgili alanlar� �zerinden ili�ki kurarak ger�ekle�tirilir.

--Join T�rleri:

--1) (INNER) JOIN: Her iki tablodaki e�le�en de�erlere sahip KAYITLARI d�nd�r�r.
--SELECT *
--FROM Categories c JOIN Products p ON c.CategoryID=p.CategoryID
--2) LEFT JOIN: Sol taraftaki t�m kay�tlar�, sa� taraftaki ise e�le�en kay�tlar� d�nd�r�r
--3) RIGHT JOIN: SA� taraftaki t�m kay�tlar�, SOLtaraftaki ise e�le�en kay�tlar� d�nd�r�r
--SELECT *
--FROM Categories c LEFT JOIN Products p ON c.CategoryID=p.CategoryID
--SELECT*
--FROM Categories c RIGHT JOIN Products p ON c.CategoryID=p.CategoryID
-- 4-OUTER(FULL) JOIN:Her iki taraftaki t�m kay�tlar� getirir.
--Select *
--FROM Categories c  FULL  JOIN Products p ON c.CategoryID=p.CategoryID

--Hangi Sipari�,hangi �al��an taraf�ndan , hangi m��teri i�in verilmi�tir?
--Sipari�Id         Sipari� Tarihi    �al��an       M��teri
--10240             2005-5-19        ero            eroo
--SELECT
--  o.OrderID AS [Sipari� Id],
--  o.orderDate AS [Sipari� Tarihi],
--  e.FirstName + ' ' + e.LastName AS [�al��an],
--  c.CompanyName AS [M��teri]
--FROM Orders o
--    JOIN Employees e ON o.EmployeeID=e.EmployeeID
--		JOIN Customers c ON o.CustomerID=c.CustomerID

--Bug�ne kadar hangi �lkelere kargo g�nderimi yapm���z
--SELECT DISTINCT o.ShipCountry
--FROM Orders o

--Bug�ne kadar hangi �lkelere ka� kez  kargo g�nderimi yapm���z

SELECT 
	o.ShipCountry
FROM Orders o
GROUP BY o.ShipCountry