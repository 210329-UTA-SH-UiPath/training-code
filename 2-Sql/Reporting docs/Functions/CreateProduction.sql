IF OBJECT_ID (N'dbo.Production', N'U') IS NOT NULL
	DROP TABLE Production;

CREATE TABLE Production (LocationID int, ProductID int, ProductName VARCHAR(50), Quantity int)
INSERT INTO Production (LocationID, ProductID, ProductName, Quantity) VALUES ('6','1','one','10')
INSERT INTO Production (LocationID, ProductID, ProductName, Quantity) VALUES ('6','2','two','20')
INSERT INTO Production (LocationID, ProductID, ProductName, Quantity) VALUES ('6','3','three','30')
INSERT INTO Production (LocationID, ProductID, ProductName, Quantity) VALUES ('6','4','four','40')

SELECT * FROM Production