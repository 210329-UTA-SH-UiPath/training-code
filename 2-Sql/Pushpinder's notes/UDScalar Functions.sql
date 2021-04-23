--- Scalar 
create function Sales.GetNetSale(
	@quantity int,	
	@unitprice dec(10,2),
	@discount dec(10,2)
)
returns dec(10,2)
as 
begin
	return @quantity*@unitprice*(1-@discount);
end

-- call function

select Sales.GetNetSale(10,100.00,0.1) as netSale;


--- TVF

CREATE FUNCTION Sales.fn_LineTotal (@orderid INT)
RETURNS TABLE
AS 
	RETURN SELECT orderid, CAST((qty * unitprice * (1 - discount)) AS DECIMAL(8, 2)) AS line_total 
	FROM Sales.OrderDetails 
	WHERE orderid = @orderid ;

select orderid as Id, line_total as LineTotal from Sales.fn_LineTotal(10294) 
select orderid from Sales.OrderDetails