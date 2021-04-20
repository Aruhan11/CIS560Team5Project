IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[name] = N'Library'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [Library] AUTHORIZATION [dbo]');
END;