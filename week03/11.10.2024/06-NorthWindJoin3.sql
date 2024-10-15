--SELECT*
 --  r.RegionDescription AS [Bölge],
	--SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS [Satýþ Tutarý]
	--FROM OrderDetails od JOIN Orders o
	--ON od.OrderID=o.OrderID JOIN Employees e
	--ON o.EmployeeID=e.EmployeeID.JOIN EmployeeTerritorries et
	--ON e.EmployeeID=et.EmployeeID JOIN Territories t
	--ON et.TerritoryID=t.TerritoryID JOIN Region r
	--ON t.RegionID=r.RegionID
	--GROUP BY r.RegionDescription
--SELECT 
--	p.ProductName AS [Ürün],
--	CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL (10,2)) AS [Satýþ Tutarý]
--	FROM OrderDetails od JOIN Products p
--	ON od.ProductID=p.ProductID
--	GROUP BY P.ProductName
--	ORDER BY [Satýþ Tutarý] DESC
-- En son satýþý yapýlan 5 ürünü ve Sipariþ Tarihini listeleyin,,
--SELECT 
-- TOP(9)
-- p.ProductName,
-- o.OrderDate
--FROM OrderDetails od JOIN Products p
--		ON od.ProductID=P.ProductID JOIN Orders o
--			ON od.OrderID=o.OrderID
--ORDER BY o.OrderDate DESC				
 --Hangi bölgede hangi üründen ne kadarlýk satýþ olmuþ
 --SELECT
 --   r.RegionDescription AS [Bölge],
	--p.ProductName AS [Ürün],
	--CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL (10,2)) [Satýþ Tutarý]
	--FROM OrderDetails od JOIN Orders o
	--ON od.OrderID=o.OrderID JOIN Employees e
	--ON o.EmployeeID=e.EmployeeID JOIN EmployeeTerritories et
	--ON e.EmployeeID=et.EmployeeID JOIN Territories t
	--ON et.TerritoryID=t.TerritoryID JOIN Region r
	--ON t.RegionID=r.RegionID JOIN Products p
	--ON od.ProductID=p.ProductID
	--GROUP BY r.RegionDescription,p.ProductName
	--Order BY r.RegionDescription,[Satýþ Tutarý] Desc		
	

--Ürünlere göre ciro ??

SELECT
	p.ProductName AS [Ürün],
	CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL (10,2)) [Satýþ Tutarý]
	FROM OrderDetails od JOIN Products p
			ON od.ProductID=p.ProductID
GROUP BY p.ProductName
HAVING CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL (10,2))>=50000
ORDER BY [Satýþ Tutarý]



