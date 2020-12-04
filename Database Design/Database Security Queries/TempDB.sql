/* to view the temporary database file in the system */
USE tempdb
SELECT * FROM sys.database_files
/* to create local temp tables. ‘#’means temp table.*/
/* available only to the current connection for the user */
CREATE TABLE #TempTableA (colA CHAR(8000))
CREATE TABLE #TempTableB (colB CHAR(8000))
CREATE TABLE #TempTableC (colC CHAR(8000))
/* to create global temp tables */
/* available to any user by any connection */
CREATE TABLE ##GlobTempTable (colD CHAR(8000))
/* to view the existence of the temp tables that were just created */
SELECT * FROM sys.objects
SELECT * FROM sys.objects WHERE name like '#%'
/* to insert values into the table */
DECLARE @i INT
SET @i = 1
WHILE @i < 5000
BEGIN
INSERT #TempTableA values ('Database Security is Fun!!' )
SET @i = @i +1
END
/* to view the inserted entries*/
SELECT * FROM #TempTableA
/* to drop temp tables */
DROP TABLE #TempTableA
DROP TABLE #TempTableB
DROP TABLE #TempTableC
DROP TABLE ##GlobTempTable