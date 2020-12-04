/* Row level security
   This example is from the following: 
https://sqlwithmanoj.com/2015/07/13/implementing-row-level-security-rls-with-sql-server-2016/
*/ 

USE master;
GO
  
CREATE DATABASE EmpDB_RLS;
GO

USE EmpDB_RLS;
GO
  
-- Step 1.a. Let’s create some test accounts: I will create three users for:
CREATE USER userCEO WITHOUT LOGIN;
GO
CREATE USER userHR WITHOUT LOGIN;
GO
CREATE USER userFin WITHOUT LOGIN;
GO

-- Create a sample table [dbo].[Employee]: with a self-referencing Manager ID column.
CREATE TABLE dbo.Employees (
    [EmpCode] NVARCHAR(50),  -- Employee ID
    [EmpName] NVARCHAR(250), -- Employee/Manager Full Name
    [Salary]  MONEY,         -- Fictious Salary
    [MgrCode] NVARCHAR(50)   -- Manager ID
);
GO

-- Now insert some test records:

-- Top Boss CEO
INSERT INTO dbo.Employees VALUES ('userCEO', 'CEO Top Boss', 800, NULL)

-- Next 2 levels under CEO
INSERT INTO dbo.Employees VALUES ('userHR', 'HR User', 700, 'userCEO');
INSERT INTO dbo.Employees VALUES ('userFin', 'Finance User', 600, 'userCEO');

-- Employees under Kevin
INSERT INTO dbo.Employees VALUES ('HR1', 'Emily Green', 100, 'userHR');
INSERT INTO dbo.Employees VALUES ('HR2', 'Savannah James', 400, 'userHR');
INSERT INTO dbo.Employees VALUES ('HR3', 'Ryan Logue', 500, 'userHR');
 
-- Employees under Amy
INSERT INTO dbo.Employees VALUES ('FIN1', 'Nicole Smith', 200, 'userFin');
INSERT INTO dbo.Employees VALUES ('FIN2', 'Alex Uncleback', 300, 'userFin');
GO

SELECT * FROM dbo.Employees; -- 8 rows
GO

-- The Traditional way to setup the Row Level Security till now was as follows 

-- Stored Procedure with User-Name passed as parameter:
CREATE PROCEDURE dbo.uspGetEmployeeDetails (@userAccess NVARCHAR(50))
AS
BEGIN
    SELECT * 
    FROM dbo.Employees
    WHERE [MgrCode] = @userAccess
    OR @userAccess = 'userCEO'; -- CEO, the admin should see all rows
END
GO

-- Execute the SP with different parameter values:
EXEC dbo.uspGetEmployeeDetails @userAccess = 'userHR'  -- only 3 rows
GO
EXEC dbo.uspGetEmployeeDetails @userAccess = 'userFin' -- only 2 rows
GO
EXEC dbo.uspGetEmployeeDetails @userAccess = 'userCEO' -- all 8 rows
GO

-- Step 1.b. Grant Read/SELECT access on the dbo.Employee table to all 3 users:
GRANT SELECT ON dbo.Employees TO userCEO;
GO
GRANT SELECT ON dbo.Employees TO userHR;
GO
GRANT SELECT ON dbo.Employees TO userFin;
GO
 
-- Step 2. Let’s create an Inline Table-Valued Function to write our Filter logic:
/*This function returns value 1 when:
– a row in the MgrCode (i.e. the Manager Code) column is the same as the user executing the query (@@mgrCode = USER_NAME())
– or if the user executing the query is the Top Boss user (USER_NAME() = ‘userCEO’)
*/

CREATE FUNCTION dbo.fn_SecurityPredicateEmployee(@mgrCode AS sysname)
    RETURNS TABLE
WITH SCHEMABINDING
AS
    RETURN SELECT 1 AS fn_SecurityPredicateEmployee_result
    -- Predicate logic
    WHERE @mgrCode = USER_NAME() 
    OR USER_NAME() = 'userCEO'; -- CEO, the admin should see all rows
GO

-- Step 3. Create a security policy adding the function as a filter predicate

CREATE SECURITY POLICY ManagerFilter
ADD FILTER PREDICATE dbo.fn_SecurityPredicateEmployee(MgrCode)  -- Filter Column from dbo.Employee table
ON dbo.Employees
WITH (STATE = ON); -- The state must be set to ON to enable the policy.
GO

-- Now let’s again check the records after applying “Row Level Security”:
SELECT * FROM dbo.Employees; -- 0 rows, 
GO

-- Let’s check the 3 users we created and provided them customized access to the dbo.Employee table and rows in it:

-- Execute as our immediate boss userHR (3 rows): 
EXECUTE AS USER = 'userHR';
SELECT * FROM dbo.Employees; -- 3 rows
REVERT;
GO
 
-- Execute as our immediate boss userFin: 
EXECUTE AS USER = 'userFin';
SELECT * FROM dbo.Employees; -- 2 rows
REVERT;
GO
 
-- Execute as our Top boss userCEO (8): 
EXECUTE AS USER = 'userCEO';
SELECT * FROM dbo.Employees; -- 8 rows
REVERT;
GO

-- Final Cleanup
USE master;
GO

DROP DATABASE EmpDB_RLS
GO
