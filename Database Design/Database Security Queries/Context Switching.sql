


-- 1. Explicit Context Switching

--First, create TestUserExAs with sysadmin role
USE [master]
GO

CREATE LOGIN [TestUserExAs] WITH PASSWORD=N'password', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

EXEC master..sp_addsrvrolemember @loginame = N'TestUserExAs', @rolename = N'sysadmin'
GO

USE [AdventureWorks2016CTP3]
GO

CREATE USER [TestUserExAs] FOR LOGIN [TestUserExAs]
GO

CREATE LOGIN TestUserTmp WITH PASSWORD = 'password'
GO

CREATE USER TestUserTmp FOR LOGIN TestUserTmp
Go


Use AdventureWorks2016CTP3;

--Assume that you are connected as an administrator (DBO)
--and want to prevent members of the Public role from
--selecting from the Sales.Customer table
DENY SELECT ON sales.customer TO Public

-- Checking that a user TestUserTmp cannot select from the
-- Sales.Customer table using the EXECUTE AS statement
-- SELECT TOP number|percent column_name(s) FROM table_name
-- The TOP clause is used to specify the number of records to return
EXECUTE AS USER = 'TestUserTmp'
SELECT TOP 1 * FROM sales.customer
 

-- Revert to the previous execution context.
REVERT

Use master
go

--TestUserExAs grants the right to TestUserTmp to impersonate him
GRANT IMPERSONATE ON LOGIN::[TestUserExAs] TO [TestUserTmp]
GO
 
-- TestUserTmp can then connect with her login and use
-- the EXECUTE AS command to run commands that normally only TestUserExAs has permission to run
-- ## DBCC CHECKDB: Checks the logical and physical integrity of all the objects in the specified database
-- ## You need to Login as TestUserTmp for testing
EXECUTE AS LOGIN = 'TestUserExAs'
DBCC CHECKDB (AdventureWorks2016CTP3)
-- Screen shot required
SELECT USER_NAME()
--Revert back to TestUserTmp's execution context
REVERT

SELECT USER_NAME()

USE master
go


-- 2. Implicit Context Switching

CREATE PROCEDURE dbo.usp_TestExecutionContext
WITH EXECUTE AS 'TestUserTmp'
AS SELECT USER_NAME() as 'User'


-- Set the user to someone other than TestUserTmp to test the
-- implicit EXECUTE AS
SETUSER 'dbo'
EXEC usp_TestExecutionContext
SETUSER


USE master
go

DROP LOGIN TestUserExAs
DROP LOGIN TestUserTmp
GO

-- This shows that USER_NAME() retrieved in the SP is TestUserTmp, 
-- regardless of who executed the procedure
