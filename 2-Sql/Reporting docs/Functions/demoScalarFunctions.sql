--Configuration Functions
SELECT @@LANGUAGE AS 'Language Name';

--Conversion Functions
SELECT PARSE('Monday, 13 December 2010' AS datetime2 USING 'en-US') AS Result;

--Cursor Functions
DECLARE cur CURSOR  
FOR SELECT * FROM Production
--Display the status of the cursor before and after opening  
--closing the cursor.
SELECT CURSOR_STATUS('global','cur') AS 'After declare'  
OPEN cur  
SELECT CURSOR_STATUS('global','cur') AS 'After Open'  
CLOSE cur  
SELECT CURSOR_STATUS('global','cur') AS 'After Close'  
--Remove the cursor.  
DEALLOCATE cur  
--Drop the table.  

--Date and Time Data Types and Functions
SELECT SYSDATETIME()  
    ,SYSDATETIMEOFFSET()  
    ,SYSUTCDATETIME()  
    ,CURRENT_TIMESTAMP  
    ,GETDATE()  
    ,GETUTCDATE();

--JSON Functions
SELECT ProductID
FROM Production
WHERE ISJSON(ProductID) > 0 

--Logical Functions
DECLARE @a INT = 45, @b INT = 40;
SELECT [Result] = IIF( @a > @b, 'TRUE', 'FALSE' );
SELECT CHOOSE ( 3, 'Manager', 'Director', 'Developer', 'Tester' ) AS Result; 

--Mathematical Functions
DECLARE @counter SMALLINT;  
SET @counter = 1;  
WHILE @counter < 5  
   BEGIN  
      SELECT RAND() Random_Number  
      SET @counter = @counter + 1  
   END;  
GO  

--Metadata Functions
SELECT COL_NAME(OBJECT_ID('dbo.Production'), 1) AS ColumnName;

--Security Functions
DECLARE @sys_usr CHAR(30);  
SET @sys_usr = SYSTEM_USER;  
SELECT 'The current system user is: '+ @sys_usr;  
GO

--String Functions
SELECT FirstName, REVERSE(FirstName) AS Reverse  
FROM Production.ProductID  
ORDER BY FirstName;  
GO 

--System Functions
--System Statistical Functions
--Text and Image Functions