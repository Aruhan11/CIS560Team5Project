CREATE OR ALTER PROCEDURE [Library].InsertAsset
   @Name NVARCHAR(50),
   @AssetTypeID TINYINT,
   @CreatorID INT,
   @ReleaseDate DATETIME2,
   @Stock INT,
   @AssetID INT OUTPUT
AS



MERGE [Library].Asset T
USING
      (
         VALUES(@Name, @AssetTypeID, @CreatorID, @ReleaseDate, @Stock)
      ) S([Name], AssetTypeID, CreatorID, ReleaseDate, Stock)
   ON S.[Name] = T.[Name] AND  S.AssetTypeID = T.AssetTypeID AND S.CreatorID = T.CreatorID AND S.ReleaseDate = T.ReleaseDate
WHEN MATCHED THEN
   UPDATE
   SET 
        T.Stock = S.Stock + T.Stock
WHEN NOT MATCHED THEN
   INSERT([Name], AssetTypeID, CreatorID, ReleaseDate, Stock)
   VALUES(S.[Name], S.AssetTypeID, S.CreatorID, S.ReleaseDate, S.Stock);


SET @AssetID = (
    SELECT A.AssetID
    FROM [Library].Asset A
    WHERE A.[Name] = @Name AND A.AssetTypeID = @AssetTypeID AND A.CreatorID = @CreatorID AND A.ReleaseDate = @ReleaseDate
)


GO

