--DECLARE @adSoyad NVARCHAR(40)
--set @adSoyad = 'eren'

--SELECT @adSoyad
DECLARE @CategoryName NVARCHAR(50)
SET @CategoryName = 'Beverages'
SELECT
	p.ProductName,
	p.UnitPrice,
	c.CategoryName

FROM Products p JOIN Categories c
		ON p.CategoryID=c.CategoryID
WHERE c.CategoryName= @CategoryName