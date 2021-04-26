CREATE OR ALTER PROCEDURE [Library].InsertAsset
   @Name NVARCHAR(32),
   @AssetTypeID TINYINT,
   @FirstName NVARCHAR(10),
   @LastName NVARCHAR(10),
   @Company NVARCHAR(10),
   @ReleaseDate DATETIME2,
   @CategoryID INT,
   @AssetID INT OUTPUT
AS



/*
* merge Creator first
*/
MERGE [Library].Creator T
USING 
    (
        VALUES(@FirstName, @LastName, @Company)
    )S(FirstName, LastName, Company) ON T.FirstName = S.FirstName AND T.LastName <> S.LastName AND T.Company <> S.Company
WHEN NOT MATCHED 
 THEN
    INSERT(FirstName, LastName, Company)
    VALUES(S.FirstName, S.LastName, S.Company);



/*
* merge Asset second
*/
DECLARE @CreatorID INT= 
(
    SELECT C.CreatorID
    FROM [Library].Creator C
    WHERE C.FirstName = @FirstName AND C.LastName = @LastName AND C.Company = @Company
)

MERGE [Library].Asset T
USING
      (
         VALUES(@Name, @AssetTypeID, @CreatorID, @ReleaseDate, @CategoryID)
      ) S([Name], AssetTypeID, CreatorID, ReleaseDate, CategoryID)
   ON S.AssetTypeID = T.AssetTypeID
WHEN MATCHED AND EXISTS
      (
         SELECT T.[Name], T.CreatorID,T.ReleaseDate, AC.CategoryID
         FROM [Library].Asset T
         INNER JOIN [Library].AssetCategory AC ON AC.AssetID = T.AssetID
         
         INTERSECT

         SELECT S.[Name], S.CreatorID, S.ReleaseDate, S.CategoryID
      ) THEN
   UPDATE
   SET 
        T.Stock = T.Stock + 1 
WHEN NOT MATCHED THEN
   INSERT([Name], AssetTypeID, CreatorID, ReleaseDate, Stock)
   VALUES(S.[Name], S.AssetTypeID, S.CreatorID, S.ReleaseDate, 1);


SET @AssetID = SCOPE_IDENTITY();

/*
WITH SourceCte(AssetID, CategoryID) AS
   (
      SELECT R.AssetID, R.CategoryID
      FROM
            (
               VALUES
                  (@AssetID, @CategoryID)
            ) R(AssetId, CategoryID)
         INNER JOIN [Library].Asset A ON A.AssetID = R.AssetID
         INNER JOIN [Library].AssetCategory AC ON AC.CategoryID = R.CategoryID
   )
MERGE [Library].AssetCategory AC
USING SourceCte R ON R.AssetID = AC.AssetID
WHEN NOT MATCHED THEN    
    INSERT(CategoryID, AssetID)
    VALUES(R.CategoryID, R.AssetID);

*/

MERGE [Library].AssetCategory AC
USING 
(
    VALUES(@AssetID, @CategoryID)
) S(AssetID, CategoryID) ON S.AssetID = AC.AssetID AND (S.CategoryID <> AC.AssetID)
WHEN NOT MATCHED THEN
INSERT(AssetID, CategoryID)
VALUES( S.AssetID, S.CategoryID);

GO

