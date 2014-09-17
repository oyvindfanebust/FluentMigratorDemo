USE [master]
GO

DECLARE @kill varchar(8000) = '';
SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), spid) + ';'
FROM master..sysprocesses 
WHERE dbid = db_id('FluentMigrator')

EXEC(@kill);

DROP DATABASE [FluentMigrator]
GO

CREATE DATABASE [FluentMigrator] ON
PRIMARY
(
	NAME = N'FluentMigrator', FILENAME = N'C:\DB\MSSQL11.MSSQLSERVER\MSSQL\DATA\FluentMigrator.mdf'--, SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB
)
LOG ON 
(
	NAME = N'FluentMigrator_log', FILENAME = N'C:\DB\MSSQL11.MSSQLSERVER\MSSQL\DATA\FluentMigrator_log.ldf'--, SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%
)
GO