/*
* The ranking of assets which are borrowed the most in each  asset type by year and season.
*/
CREATE OR ALTER PROCEDURE [Library].RankingAssetByAssetType

AS

WITH SourseCTE(AssetID, AssetName, AssetTypeID, CheckOutAssetsCount) AS
(
    SELECT COA.AssetID, A.AssetName, A.AssetTypeID, COUNT(*)
    FROM [Library].CheckedOutAsset COA
    INNER JOIN [Library].[Asset] A ON A.AssetID = COA.AssetID
    GROUP BY COA.AssetID, A.[Name], A.AssetTypeID
)

SELECT 
      ROW_NUMBER() OVER(ORDER BY S.AssetTypeID ASC, S.CheckOutAssetsCount DESC) AS [RowNumber],
      [AT].TypeName,
      RANK() OVER( PARTITION BY S.AssetTypeID ORDER BY S.CheckOutAssetsCount DESC) AS CheckOutRank,
      S.AssetName,  
      S.CheckOutAssetsCount AS CheckOutCount
FROM SourseCTE S
INNER JOIN [Library].[AssetType] [AT] ON [AT].AssetTypeID = S.AssetTypeID
ORDER BY S.AssetTypeID ASC

GO

