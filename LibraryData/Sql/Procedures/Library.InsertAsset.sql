CREATE OR ALTER PROCEDURE [Library].InsertAsset
   @Name NVARCHAR(32),
   @AssetTypeID TINYINT,
   @CreatorID TINYINT,
   @ReleaseDate DATETIME(2),
   @AssetID INT OUTPUT
AS


MERGE [Library].Asset T
USING
      (
         VALUES(@Name, @AssetTypeID, @CreatorID, @ReleaseDate)
      ) S([Name], AssetTypeID, CreatorID, ReleaseDate)
   ON S.AssetTypeID = T.AssetTypeID
WHEN MATCHED AND EXISTS
      (
         SELECT T.AssetTypeID, T.CreatorID, T.ReleaseDate
         INTERSECT
         SELECT T.AssetTypeID, T.CreatorID, T.ReleaseDate
      ) THEN
   UPDATE
   SET 
        T.Stock = T.Stock + 1      
WHEN NOT MATCHED THEN
   INSERT([Name], AssetTypeID, CreatorID, ReleaseDate, Stock)
   VALUES(S.[Name], S.AssetTypeID, S.CreatorID, S.ReleaseDate, 1);
GO


SET @AssetID = SCOPE_IDENTITY();

GO

