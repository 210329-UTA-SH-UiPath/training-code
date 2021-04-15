IF OBJECT_ID (N'dbo.ufnGetInventoryStock', N'FN') IS NOT NULL  
    DROP FUNCTION ufnGetInventoryStock;  
GO -- Scalar function definition 
CREATE FUNCTION dbo.ufnGetInventoryStock(@ProductID int)
RETURNS int
AS   
-- Returns the stock level for the product.
BEGIN  
    DECLARE @ret int;  
    SELECT @ret = SUM(p.Quantity)
	FROM Production p   
    WHERE p.ProductID = @ProductID   
        AND p.LocationID = '6';
     IF (@ret IS NULL)   
        SET @ret = 0;  
	--print @ret
    RETURN @ret;
END;
GO
SELECT dbo.ufnGetInventoryStock ('2');