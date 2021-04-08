# Stored Procedures and Functions in SQL
# Stored Procedures
## What are store procedures?
  + Pre-compiled objects that are saved and able to be executed anywhere.
  + Allow us to store repeated queries for reuse.
    ## Advantages
      ### Performance
          + Compiled once stored in executable form.
            + Allows for quick and efficient procedure calls
          + Exe. is automatically cached 
            + Increases application speed
      ### Productivity and Ease
          + Logic can be handled in stored procedures
          + Called by programmatic interfaces 
      ### Security Controls
          + Can grant user permission to execute a store procedure, independently
      ### Exception Handling
          + Can use Try-Catch blocks to handle exceptions
      ### Returning Multiple Values
          + Can have an output parameter which allows for the function to effectively return multiple values
      ### Variety
          + Can perform transactions on the database
          + Can call functions
      ### 
    ## Example
      + NOTE: Requires CREATE PROCEDURE permission in the DB and ALTER permission on the schema you are creating it in 
    
      + Can be made in 2 different ways
        + Query

                CREATE PROCEDURE myProcedure AS PRINT 'This is my store procedure:)'
        ![plot](./IMG/CreateStoredProcedure.png)

        
        + SSMS
            + Databases -> Database -> Programmability
            + Right click Stored Procedures -> New Stored Procedure
            + Control + Shift + M will allow you to setup parameters
    ## Execute store procedure
        exec myProcedure
    ![plot](./IMG/ExecuteStoredProcedure.png)


# Functions
  ## What is function?
  + Functions allow us to create functions to perform complex calculations
  + Return result as a value
      + Has to return either a scalar or table

    ### Built-in functions
        + Cannot be modified
        + Can be referenced only in Transact-SQL statements
    ### User-defined functions
        + Use *CREATE FUNCTION* to generate a function
        + Can take 0+ parameters
        + returns a single data value
  ## Advantages
  + Advantages of functions

    ### Modularity
        + Can create a function once that is stored in your database
        + You can use the function anywhere
      ### Execution
        + Reduces compilation cost **Transact-SQL** by caching the statments and reuse them.
      ### Usage
        + Can be used in SELECT/WHERE/HAVING statements

  ## Examples
  + Function examples
    ### Returning a Table
        CREATE FUNCTION fxn_example (
          @varName Type
        )
        RETURNS TABLE AS
        RETURN
              SELECT * FROM Table_name WHERE table_name.varName >= @varName;
        
        **Usage**
        SELECT * FROM database_object.fxn_example(20)

    ![plot](./IMG/CreateTableReturnFunction.png)
    ![plot](./IMG/ExecuteTableReturnFunction.png)



    ### Returns a SCALAR
        CREATE FUNCTION number_people_over_equal(
          @age INT
        )
        RETURNS INT AS
        BEGIN
          DECLARE @returnvalue INT;

          SELECT @returnvalue = COUNT(*) 
            FROM PERSONS
            WHERE Age >= @age;
          
          RETURN(@returnvalue)
        END;
    ![plot](./IMG/CreateScalarReturnFunction.png)
    ![plot](./IMG/ExecuteScalarReturnFunction.png)




# Summary
| Difference       | Stored Procedure (SP)          | Functions (Fxn)          |
|------------------|--------------------------------|--------------------------|
| Return Type      | Optional. Can even return 0    | Must return a value type |
| Calls            | Cannot be called from Fxn      | Can be called in SP      |
| Statements Usage | INSERT, UPDATE, DELETE, SELECT | Only SELECT statement    |





####################################################################################

# Error handling
  + Control over Transact - SQL code
  + Translate message into more readable and understandable text
    + Makes logging easy to track

    ## Two types
      ### System-defined exceptions
        + Predefined exceptions 
          + ArithmeticException
         

      ### User-defined exceptions
        + When you call **Throw**
      ### Example
        THROW [ { error_number | @local_variable },  
        { message | @local_variable },  
        { state | @local_variable } ]

        + error_number - Is a constant or variable that represents the exception. error_number is int and must be greater than or equal to 50000 and less than or equal to 2147483647.

        + message - Is a string or variable that describes the exception. message is nvarchar(2048).

        + state - Is a constant or variable between 0 and 255 that indicates the state to associate with the message. state is tinyint.



    ## Structure
        BEGIN TRY  
        --code to try 
        END TRY  
        BEGIN CATCH  
            --code to run if an error occurs
        --is generated in try
        END CATCH

    ## Key terms
        + *ERROR_NUMBER* – Returns the internal number of the error
        + *ERROR_STATE* – Returns the information about the source
        + *ERROR_SEVERITY* – Returns the information about anything from informational errors to errors user of DBA can fix, etc.
        + *ERROR_LINE* – Returns the line number at which an error happened on
        + *ERROR_PROCEDURE* – Returns the name of the stored procedure or function
        + *ERROR_MESSAGE* – Returns the most essential information and that is the message text of the error


    ## Examples of Error Handling
      ### System Exception
        BEGIN TRY
        -- Generate a divide-by-zero error  
          SELECT
            1 / 0 AS Error;
        END TRY
        BEGIN CATCH
          SELECT
            ERROR_NUMBER() AS ErrorNumber,
            ERROR_STATE() AS ErrorState,
            ERROR_SEVERITY() AS ErrorSeverity,
            ERROR_PROCEDURE() AS ErrorProcedure,
            ERROR_LINE() AS ErrorLine,
            ERROR_MESSAGE() AS ErrorMessage;
        END CATCH;
      ![plot](./IMG/SystemException.png)

      ### User Exception
        BEGIN TRY
            THROW 1000, 'Encountered an exception', 2
        END TRY
        BEGIN CATCH
            SELECT 
                ERROR_NUMBER() AS ErrorNumber,
                ERROR_MESSAGE() AS ErrorMessage,
                ERROR_STATE() AS ErrorState;
        END CATCH
      ![plot](./IMG/UserException.png)