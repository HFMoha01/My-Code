/* to see the entire SPIDs */
SELECT *
FROM sys.dm_exec_sessions
/* to see your SPID */
Select * from sysprocesses
Where spid=@@spid
/* to see the connections */
SELECT * FROM sys.dm_exec_connections
/* to see the principals */
select * from sys.server_principals