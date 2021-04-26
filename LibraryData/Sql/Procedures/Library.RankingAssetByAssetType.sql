/*
*  9. The ranking of assets which are borrowed the most in each  asset type by year and season.
*/
CREATE OR ALTER PROCEDURE [Library].RankingAssetByAssetType

AS

WITH SourceCTE(AssetID, [Name], AssetTypeID, CheckOutAssetsCount) AS
(
    SELECT COA.AssetID, A.[Name], A.AssetTypeID, COUNT(*)
    FROM [Library].CheckedOutAsset COA
    INNER JOIN [Library].[Asset] A ON A.AssetID = COA.AssetID
    GROUP BY COA.AssetID, A.[Name], A.AssetTypeID
)

SELECT 
      ROW_NUMBER() OVER(ORDER BY S.AssetTypeID ASC, S.CheckOutAssetsCount DESC) AS [RowNumber],
      [AT].[Name],
      RANK() OVER( PARTITION BY S.AssetTypeID ORDER BY S.CheckOutAssetsCount DESC) AS CheckOutRank,
      S.[Name],  
      S.CheckOutAssetsCount AS CheckOutCount
FROM SourceCTE S
INNER JOIN [Library].[AssetType] [AT] ON [AT].AssetTypeID = S.AssetTypeID
ORDER BY S.AssetTypeID ASC

GO

