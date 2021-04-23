--Scalar valued
select * 
from sales.orderdetails
where orderid=
(select max(orderid) as lastorder from Sales.Orders)

-- multivalued
-- select a product with second highest price
select min(unitprice) as Price from Production.Products where unitprice in
(select top 2 unitprice from [Production].[Products] order by unitprice desc)

-- find all orders where customer are from Mexico
select custid,orderid from Sales.orders where custid in
(select custid from Sales.Customers where country=N'Mexico')

-- multivalued subquery written with joins\
select c.custid, o.orderid from Sales.orders as o join Sales.customers as c 
on o.custid=c.custid
where c.country=N'mexico'

