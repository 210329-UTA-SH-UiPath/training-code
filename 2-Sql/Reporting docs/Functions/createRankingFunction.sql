USE jsrevature001;
GO  
SELECT p.LocationID, p.ProductID
    ,RANK() OVER (ORDER BY p.Quantity DESC) AS Rank
FROM Production AS p;