/* Database Oldhouse Creation
- On the Proxmox server, you have to create the Oldhouse database if you don't have it.
- Use the attached script "Oldhouse-Table-Create (Encryption).sql" to create the Oldhouse database. 
*/ 
 
-- Check out the existence of Service Master Key, Database Master Key
USE master; 
GO

SELECT * FROM sys.symmetric_keys

USE Oldhouse;
GO

--If there is no database master key, create one now.
IF NOT EXISTS
(SELECT * FROM sys.symmetric_keys
WHERE symmetric_key_id = 101)
CREATE MASTER KEY ENCRYPTION
BY PASSWORD = 'Th15i$aS7riN&ofR@nD0m!T3%t'
GO

-----------------------------------
-- 1. Encryption using a Passphrase
-----------------------------------

-- Display the original table
select * from dbo.cust
go
/* Task #1: Show the original table in a screen shot. */


-- Create a copy of the dbo.cust table into cust_encrypt table
-- and define the cardnumber_encrypt column as a varbinary(256)
select fname,
	   lname, 
       cardnumber_encrypt = CONVERT(varbinary(256), cardnumber)
into dbo.cust_encrypt       
from dbo.cust   
where 1 = 2

select  * from dbo.cust_encrypt
go

-- Now, you can populate the cust_encrypt table with rows 
-- from the original table after encrypting using EncryptByPassPhrase function
-- Populate the cust_encrypt table 
declare @passphrase varchar(128)
set @passphrase = 'unencrypted credit card numbers are bad, um-kay'
insert dbo.cust_encrypt
(
       fname, 
       lname, 
       cardnumber_encrypt
)
select 
       fname, 
       lname, 
       cardnumber_encrypt = EncryptByPassPhrase(@passphrase, cardnumber)
from dbo.cust

-- Display the encrypted table
select * from dbo.cust_encrypt
go
/* Task #2: Show the encrypted table in a screen shot. Also, explain why we need to change the data type for encryption. */


--------------------------------------------------------------------------
-- 2. Encryption using Certificate 
-- OPEN MASTER KEY DECRYPTION BY PASSWORD = 'Th15i$aS7riN&ofR@nD0m!T3%t';
-- The DB master key is already open.  
--------------------------------------------------------------------------

-- Create the certificate
USE Oldhouse;
CREATE CERTIFICATE BillingCert 
   WITH SUBJECT = 'Credit Card Billing'
GO

-- Create a symmetric key and encrypt it using the BillingCert certificate
USE Oldhouse;
CREATE SYMMETRIC KEY BillingSymKey WITH ALGORITHM = AES_256
    ENCRYPTION BY CERTIFICATE BillingCert;
GO

-- Empty out the cust_encrypt table by truncating it
USE Oldhouse;
Truncate table dbo.cust_encrypt

USE Oldhouse;

-- First, decrypt the key using the BillingCert certificate
OPEN SYMMETRIC KEY BillingSymKey
     DECRYPTION BY CERTIFICATE BillingCert

-- Now, insert the rows using the symmetric key encrypted by the certificate
insert dbo.cust_encrypt (
       fname,
       lname,
       cardnumber_encrypt
       )
select 
       fname,
       lname,
       cardnumber_encrypt = EncryptByKey(KEY_GUID('BillingSymKey'),cardnumber)
from dbo.cust

-- Display the encrypted table
select * from dbo.cust_encrypt
go
/* Task #3: Show the encrypted table in a screen shot. Also, explain the encryption process after Task #2. */


-- Now, an authorized user can retrieve the data
USE Oldhouse;
OPEN SYMMETRIC KEY BillingSymKey
     DECRYPTION BY CERTIFICATE BillingCert

-- Display the decrypted table
select fname,
	   lname,
	   cardnumber = convert(nvarchar(25), DecryptByKey(cardnumber_encrypt))
from dbo.cust_encrypt
go
/* Task #4: Show the encrypted table in a screen shot. Also, explain the decryption process after Task #3. 	*/
/* Did you get the original data back? If not, explain what's going on? 												*/ 
/* Hint: Check out the current data type of cardnumber with the original one 								*/


CLOSE SYMMETRIC KEY BillingSymKey

CLOSE MASTER KEY

-- Display the certificates
select * from sys.certificates

-- Display the symmetric keys
select * from sys.symmetric_keys

DROP SYMMETRIC KEY BillingSymKey

DROP CERTIFICATE BillingCert

DROP MASTER KEY


-----------------------------------------------------------------
-- 3. Transparent Data Encryption
-- Test TDE at home. Do not execute TDE in the Lab. 
-----------------------------------------------------------------

USE master;
GO

--Create the master key which is stored in the master database
CREATE MASTER KEY ENCRYPTION BY PASSWORD = 'mystrongpassword$$';
GO

-- Create a certificate that is also stored in the master
-- database. This certificate will be used to encrypt a user database
CREATE CERTIFICATE TDECert
 with SUBJECT = 'Certificate stored in Master Db'
GO

-- Create a Database Encryption Key (DEK) that is based
-- on the previously created certificate
-- The DEK is stored in the user database
USE Oldhouse
GO

CREATE DATABASE ENCRYPTION KEY
WITH ALGORITHM = AES_256
ENCRYPTION BY SERVER CERTIFICATE TDECert
GO

-- Turn the encryption on for the Oldhouse
ALTER DATABASE Oldhouse
SET ENCRYPTION ON
GO

-- sys.dm_database_encryption_keys: http://technet.microsoft.com/en-us/library/bb677274.aspx
SELECT DBName = DB_NAME(database_id), encryption_state
FROM sys.dm_database_encryption_keys ;
GO

/*
DBName               encryption_state
-------------------- ----------------
tempdb							3
Oldhouse						3
*/ 
-- Turn the encryption on for the Oldhouse

ALTER DATABASE Oldhouse
SET ENCRYPTION OFF
GO
DROP CERTIFICATE TDECertDROP MASTER KEY
/* Warning: The certificate used for encrypting the database encryption key has not been backed up. You should immediately back up the certificate and the private key associated with the certificate. If the certificate ever becomes unavailable or if you must restore or attach the database on another server, you must have backups of both the certificate and the private key or you will not be able to open the database.
*/

BACKUP MASTER KEY TO FILE = 'c:\MSSQL2016\backup\masterkey'
    ENCRYPTION BY PASSWORD = 'somekeybackuppassword$$'

BACKUP CERTIFICATE TDECert TO FILE = 'c:\MSSQL2016\backup\TDECert'
    WITH PRIVATE KEY ( FILE = 'c:\mssql2008\backup\TDECertPrivateKey' ,
    ENCRYPTION BY PASSWORD = 'somecertbackuppassword$$' )

CREATE CERTIFICATE TDECert
     FROM FILE = 'c:\mssql2008\backup\TDECert'
     WITH PRIVATE KEY (FILE = 'c:\MSSQL2016\backup\TDECertPrivateKey',
     DECRYPTION BY PASSWORD = 'somecertbackuppassword$$')

