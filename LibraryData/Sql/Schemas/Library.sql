IF NOT EXISTS
   (
      SELECT *
      FROM sys.schemas s
      WHERE s.[Name] = N'Library'
   )
BEGIN
   EXEC(N'CREATE SCHEMA [Library] AUTHORIZATION [dbo]');
END;