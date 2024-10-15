CREATE FUNCTION GetTotal(@price MONEY, @quantity SMALLINT, @discount REAL)
RETURNS DECIMAL(10,2) AS
BEGIN
	DECLARE @total DECIMAL (10,2) = CAST(@price*@quantity*(1-@discount) AS
		DECIMAL(10,2))
		RETURN @total
END
SELECT
	SUM(dbo.GetTotal(od.UnitPrice,od.Quantity,od.Discount))AS [Ciro]
	FROM OrderDetails od
