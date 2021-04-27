/*
* 4. Get the information of possible  assets by the given asset name
*/
CREATE OR ALTER PROCEDURE [Library].GetPossibleAssets
   @assetName VARCHAR(10)
AS

SELECT 
	 [AT].[Name] AS AssetType, C.FirstName + N' '+ C.LastName AS CreatorName, C.Company, A.ReleaseDate, A.Stock
FROM [Library].Asset A
INNER JOIN [Library].AssetType [AT] ON [AT].AssetTypeID = A.AssetTypeID
INNER JOIN [Library].Creator C ON C.CreatorID = A.CreatorID
WHERE A.[Name] = @assetName;
GO



