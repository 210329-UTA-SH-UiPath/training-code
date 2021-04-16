--JOINS (INNER JOIN/JOIN, LEFT OUTER JOIN, RIGHT OUTER JOIN, FULL OUTER JOIN, SELF-JOIN, CROSS JOIN)
/*
A join query combines and filters data into columns alongside each other from 2 or more tables. (Self-join would use 1 table multiple times). 

You can join on 1 or more columns, but you must ensure the fields you are joining on are of the same type or you will get a Type Mismatch Error.
(This check is not necessary if you’re joining based on a primary key/foreign key relationship because data consistency is already insured.)

SELECT [what you wish to display from result query]
FROM [left table]
[JOIN TYPE] JOIN [right table]
ON [left table.field] = [right table.field]

*/

--INNER JOIN/JOIN returns only the matching records in both tables

SELECT * FROM Team;
SELECT * FROM Hero;

--Join based on one field between the two tables
SELECT *
FROM Hero
INNER JOIN Team
ON Hero.TeamID = Team.TeamID;

--You can use "and" to add extra conditions. 
--Not shown in the example below, but you could use "and" to even join based on additonal fields b/w the two tables
SELECT *
FROM Hero
INNER JOIN Team
ON Hero.TeamID = Team.TeamID and Hero.TeamID = 1;

--SELF JOIN is when a table is joined to itself. To do this, you need to temporarily rename at least one table in the SQL statement

--Useful when a table references data within itself:
SELECT * FROM Employees;

Select e1.EmpID, e1.EmpName, e1.ManagerID, e2.EmpName as ManagerName
FROM Employees e1
LEFT OUTER JOIN Employees e2
ON e1.ManagerID = e2.EmpID;

--CROSS JOIN returns cartesian product where the elements of left table are first and the elements of right table are second
/*
IF A has n rows and B has m rows then the resulting query will be n x m rows

For reference, the Cartesian Product of sets A and B (A x B) 
returns the set of all ordered pairs where the elements of A are first and the elements of B are second.
Eg. A = {1, 2} and B = {2, "banana"}. A x B = {(1, 2), (1, "banana"), (2, 2), (2, "banana")} 
*/

--Useful whenever you want to take the cartesian product of something (counting, grid problems, etc.)
--How many combinations of ice cream can I make (assuming a scoop of ice cream goes first with a topping on top)?
SELECT * FROM IceCream;
SELECT * FROM Topping;

SELECT *
FROM IceCream
CROSS JOIN Topping;

--SET OPERATORS (UNION, UNION ALL, INTERSECT, EXCEPT)
/*
Set Operations combine and filter data from 2 or more queries into rows on top of each other. 
Queries combined using set operators MUST have an equal number of columns and each column convertible to the same type.
*/

--UNION returns a result query that takes everything from both queries
SELECT Flavor Sweets FROM IceCream
UNION
SELECT Topping FROM Topping;

--Just a side note:
--This statement will fail because although there's the same number of columns in both queries, we can't covert TeamName (varchar) to HeroID (int)
SELECT HeroID, HeroName FROM Hero 
UNION
SELECT TeamName, Location FROM Team;

--This statement will work because there's the same number of columns and types in both queries
SELECT * FROM Team;
SELECT * FROM Hero;

SELECT HeroID Combined_HeroID_and_TeamID, HeroName Combined_HeroName_and_TeamLocation FROM Hero 
UNION
SELECT TeamID, Location FROM Team;

-- UNION vs UNION ALL: UNION ignores duplicates but UNION All does not.
SELECT * FROM IceCream;

SELECT * FROM IceCream
UNION
SELECT * FROM IceCream;

SELECT * FROM IceCream
UNION ALL
SELECT * FROM IceCream;

--INTERSECT returns a result query that takes only what both queries have in common
(
	--First query holds 1, 2, 3
    SELECT 1
    UNION
    SELECT 2
    UNION
    SELECT 3
)
INTERSECT
(
	--Second query holds 3, 4, 5
    SELECT 3
    UNION
    SELECT 4
    UNION
    SELECT 5
);

--EXCEPT returns a result query that takes everything from the first query that is not also in the second query
(
	--First query holds 1, 2, 3
    SELECT 1
    UNION
    SELECT 2
    UNION
    SELECT 3
)
EXCEPT
(
	--Second query holds 3, 4, 5
    SELECT 3
    UNION
    SELECT 4
    UNION
    SELECT 5
);
