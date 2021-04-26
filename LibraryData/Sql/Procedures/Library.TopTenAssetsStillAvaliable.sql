/*
* 11.The top 10 assets which are borrowed in most  and still available to be borrowed in library  in each asset type
*/
CREATE OR ALTER PROCEDURE [Library].TopTenAssetsStillAvaliable

AS


SELECT TOP(10) ROW_NUMBER() OVER(ORDER BY COUNT(*) DESC) AS [RowNumber],
        A.[Name], [AT].[Name], 
        (C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company, 
        COUNT(*) AS BorrowedTimes
FROM [Library].CheckedOutAsset COA
INNER JOIN [Library].[Asset] A ON A.AssetID = COA.AssetID
INNER JOIN [Library].[AssetType] [AT] ON [AT].AssetTypeID = A.AssetTypeID
INNER JOIN [Library].[Creator] C ON C.CreatorID = A.CreatorID
WHERE A.Stock > 0
GROUP BY COA.AssetID, A.[Name], [AT].[Name], (C.FirstName + N' '+ C.LastName), C.Company
ORDER BY BorrowedTimes DESC

GO

