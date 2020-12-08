
/* 
Ownership chaining
Example of Signing Procedures w/ Certificates

*/ 

USE master
go

-- Create a test login and test database
CREATE LOGIN TestUser WITH PASSWORD = 'CeRT=0=TeST'
CREATE DATABASE CertTest
go

-- Move to the test database.
USE CertTest
go

-- Create the test database user.
CREATE USER TestUser
go

-- Create the test table and add some data.
CREATE TABLE TestTBL (a int NOT NULL,
                      b int NOT NULL)
INSERT TestTBL (a, b) VALUES (47, 11)
go

-- Create two test stored procedures, and grant permission.
CREATE PROCEDURE Unsigned_SP AS
   SELECT SYSTEM_USER, USER, name, type, usage FROM sys.user_token
   EXEC ('SELECT a, b FROM TestTBL')
go

CREATE PROCEDURE Example_SP AS
   SELECT SYSTEM_USER, USER, name, type, usage FROM sys.user_token
   EXEC ('SELECT a, b FROM TestTBL')
   -- EXEC Unsigned_SP
go

GRANT EXECUTE ON Example_SP TO public
GRANT EXECUTE ON Unsigned_SP TO public
go

-- Create the certificate.
CREATE CERTIFICATE ExampleCert
   ENCRYPTION BY PASSWORD = 'All you need is love'
   WITH SUBJECT = 'Certificate for Example_SP',
   START_DATE = '20020101', EXPIRY_DATE = '20200101'
go

-- Create the certificate user and give it rights to access the test table.
CREATE USER ExampleCertUser FROM CERTIFICATE ExampleCert
GRANT SELECT ON TestTBL TO ExampleCertUser
go

-- Sign the procedure.
ADD SIGNATURE TO Example_SP BY CERTIFICATE ExampleCert
    WITH PASSWORD = 'All you need is love'
go

SELECT USER_NAME()

-- Run as the test user, to actually see that this works.
EXECUTE AS USER = 'TestUser'
go

SELECT USER_NAME()

-- First run the unsigned procedure. This gives a permission error.
EXEC Unsigned_SP
go


-- Then run the signed procedure. Now we get the data back.
EXEC Example_SP
go



REVERT
go

-- Clean up
USE master
DROP DATABASE CertTest
DROP LOGIN TestUser
