/*  create a Login using Windows Authentication     */

CREATE LOGIN [test_domain\techonthenet] 
FROM WINDOWS;

/*  create a Login using SQL Server Authentication.     */
CREATE LOGIN techonthenet
WITH PASSWORD = 'pwd123' MUST_CHANGE, 
CHECK_EXPIRATION = ON;

/*  create a Login from a certificate in SQL Server  */
CREATE LOGIN techonthenet
FROM CERTIFICATE certificate1;



/*  create a Login from a certificate in SQL Server  */
CREATE LOGIN techonthenet
FROM ASYMMETRIC KEY asym_key1;


