CREATE OR ALTER PROCEDURE [Library].RetrieveAssets
    @AssetID INT
AS

SELECT 
      ROW_NUMBER() OVER(ORDER BY COA.[Name] ASC) AS [RowNumber], 
      A.[Name] AS AssetName, A.Stock AS StockNumber, COA.UserID AS [CheckedOutUserID], COA.CheckOutDate, COA.ReturnByDate, COA.IsReturned
 
FROM [Library].Asset A
LEFT JOIN [Library].CheckedOutAsset COA ON A.AssetID = COA.AssetID
WHERE A.AssetID = @AssetID
GO

