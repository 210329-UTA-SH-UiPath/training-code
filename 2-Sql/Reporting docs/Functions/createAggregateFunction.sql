IF OBJECT_ID (N'dbo.ufnGetTotalStock', N'FN') IS NOT NULL  
    DROP FUNCTION ufnGetTotalStock;  
GO -- Aggregate function definition 
CREATE FUNCTION dbo.ufnGetTotalStock(@LocationID int)
RETURNS int
AS   
-- Returns the stock level for the product.
BEGIN  
    DECLARE @ret int;  
    SELECT @ret = SUM(p.Quantity)
	FROM Production p   
    WHERE p.LocationID = @LocationID;
     IF (@ret IS NULL)   
        SET @ret = 0;  
    RETURN @ret;  
END;
GO
SELECT dbo.ufnGetTotalStock ('6');