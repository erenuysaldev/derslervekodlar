--SELECT*
 --  r.RegionDescription AS [B�lge],
	--SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS [Sat�� Tutar�]
	--FROM OrderDetails od JOIN Orders o
	--ON od.OrderID=o.OrderID JOIN Employees e
	--ON o.EmployeeID=e.EmployeeID.JOIN EmployeeTerritorries et
	--ON e.EmployeeID=et.EmployeeID JOIN Territories t
	--ON et.TerritoryID=t.TerritoryID JOIN Region r
	--ON t.RegionID=r.RegionID
	--GROUP BY r.RegionDescription
--SELECT 
--	p.ProductName AS [�r�n],
--	CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL (10,2)) AS [Sat�� Tutar�]
--	FROM OrderDetails od JOIN Products p
--	ON od.ProductID=p.ProductID
--	GROUP BY P.ProductName
--	ORDER BY [Sat�� Tutar�] DESC
-- En son sat��� yap�lan 5 �r�n� ve Sipari� Tarihini listeleyin,,
--SELECT 
-- TOP(9)
-- p.ProductName,
-- o.OrderDate
--FROM OrderDetails od JOIN Products p
--		ON od.ProductID=P.ProductID JOIN Orders o
--			ON od.OrderID=o.OrderID
--ORDER BY o.OrderDate DESC				
 --Hangi b�lgede hangi �r�nden ne kadarl�k sat�� olmu�
 --SELECT
 --   r.RegionDescription AS [B�lge],
	--p.ProductName AS [�r�n],
	--CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL (10,2)) [Sat�� Tutar�]
	--FROM OrderDetails od JOIN Orders o
	--ON od.OrderID=o.OrderID JOIN Employees e
	--ON o.EmployeeID=e.EmployeeID JOIN EmployeeTerritories et
	--ON e.EmployeeID=et.EmployeeID JOIN Territories t
	--ON et.TerritoryID=t.TerritoryID JOIN Region r
	--ON t.RegionID=r.RegionID JOIN Products p
	--ON od.ProductID=p.ProductID
	--GROUP BY r.RegionDescription,p.ProductName
	--Order BY r.RegionDescription,[Sat�� Tutar�] Desc		
	

--�r�nlere g�re ciro ??

SELECT
	p.ProductName AS [�r�n],
	CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL (10,2)) [Sat�� Tutar�]
	FROM OrderDetails od JOIN Products p
			ON od.ProductID=p.ProductID
GROUP BY p.ProductName
HAVING CAST(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) AS DECIMAL (10,2))>=50000
ORDER BY [Sat�� Tutar�]



