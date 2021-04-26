/*
* 10. The ranking of creators whose productions are borrowed in most  in each asset type by year
*/
CREATE OR ALTER PROCEDURE [Library].RankingCreatorByAssetType

AS

WITH SourseCTE(CreatorID,AssetID,AssetName,AssetTypeID,CheckOutAssetsCount) AS
(
    SELECT C.CreatorID, COA.AssetID, A.[Name], A.AssetTypeID, COUNT(*)OVER(PARTITION BY C.CreatorID)
    FROM [Library].CheckedOutAsset COA
    INNER JOIN [Library].[Asset] A ON A.AssetID = COA.AssetID
    INNER JOIN [Library].Creator C ON C.CreatorID = A.CreatorID
    
)

SELECT 
      ROW_NUMBER() OVER(ORDER BY S.AssetTypeID ASC, S.CheckOutAssetsCount DESC) AS [RowNumber],
      (C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company, 
      [AT].[Name],
      RANK() OVER( PARTITION BY S.AssetTypeID ORDER BY S.CheckOutAssetsCount DESC) AS CheckOutRank,
      S.AssetName,  
      S.CheckOutAssetsCount AS CheckOutCount
FROM SourseCTE S
INNER JOIN [Library].[AssetType] [AT] ON [AT].AssetTypeID = S.AssetTypeID
INNER JOIN [Library].[Creator] C ON C.CreatorID = S.CreatorID
ORDER BY S.AssetTypeID ASC

GO

