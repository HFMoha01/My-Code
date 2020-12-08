/* Dynamic Data Masking 
  
*/


USE master;
GO
  
CREATE DATABASE EmpDB;
GO
  
USE EmpDB;
GO
  
CREATE TABLE EmpTbl(
   EmpID INT PRIMARY KEY,
   FirstName NVARCHAR(50) NOT NULL,
   LastName NVARCHAR(50) MASKED WITH (FUNCTION = 'default()') NOT NULL,
   Birthdate DATE MASKED WITH (FUNCTION = 'default()') NOT NULL,
   CurrentFlag BIT MASKED WITH (FUNCTION = 'default()') NOT NULL,
   SalesLastYear MONEY MASKED WITH (FUNCTION = 'default()') NOT NULL,
   EmailAddress NVARCHAR(50) MASKED WITH (FUNCTION = 'email()') NULL,
   SickLeave INT MASKED WITH (FUNCTION = 'random(1, 5)') NOT NULL,
   SalesYTD MONEY MASKED WITH (FUNCTION = 'random(101, 999)') NOT NULL,
   NatID NVARCHAR(15),
   PhoneNumber NVARCHAR(25));
GO
  
INSERT INTO EmpTbl 
SELECT e.BusinessEntityID,
   sp.FirstName, sp.LastName,
   e.BirthDate, e.CurrentFlag, sp.SalesLastYear,
   sp.EmailAddress, e.SickLeaveHours, sp.SalesYTD, 
   e.NationalIDNumber, sp.PhoneNumber
FROM AdventureWorks2016.HumanResources.Employee e
   INNER JOIN AdventureWorks2016.Sales.vSalesPerson sp
   ON e.BusinessEntityID = sp.BusinessEntityID
WHERE sp.CountryRegionName = 'United States';

SELECT TOP 5
   EmpID, FirstName, LastName, 
   Birthdate, CurrentFlag, SalesLastYear 
FROM EmpTbl;

CREATE USER CISUser1 WITHOUT LOGIN;  
GRANT SELECT ON EmpTbl TO CISUser1;    

EXECUTE AS USER = 'CISUser1';
SELECT TOP 5
   EmpID, FirstName, LastName, 
   Birthdate, CurrentFlag, SalesLastYear 
FROM EmpTbl;

EXECUTE AS USER = 'CISUser1';
SELECT TOP 5
    EmpID, FirstName, LastName, 
	EmailAddress, SickLeave, SalesYTD,
    Birthdate, CurrentFlag, SalesLastYear 
FROM EmpTbl;
  
EXECUTE AS USER = 'CISUser1';
SELECT TOP 5 *
FROM EmpTbl;

REVERT;

USE master;
GO

DROP DATABASE EmpDB
GO
