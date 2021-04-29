CREATE OR ALTER PROCEDURE [Library].InsertAssetCategory
   
   @AssetID INT,
   @CategoryID INT,
   @AssetCategoryID INT OUTPUT
AS



MERGE [Library].AssetCategory AC
USING 
(
    VALUES(@AssetID, @CategoryID)
) S(AssetID, CategoryID) ON S.AssetID = AC.AssetID AND S.CategoryID = AC.CategoryID
WHEN NOT MATCHED THEN
INSERT(AssetID, CategoryID)
VALUES( S.AssetID, S.CategoryID);

SET @AssetCategoryID = 
(
    SELECT AC.AssetCategoryID
    FROM [Library].AssetCategory AC
    WHERE  AC.AssetID = @AssetID AND AC.CategoryID = @CategoryID 
);


GO

