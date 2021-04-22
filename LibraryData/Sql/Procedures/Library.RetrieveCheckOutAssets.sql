CREATE OR ALTER PROCEDURE [Library].RetrieveCheckOutAsset
    @UserID INT
AS

SELECT 
      ROW_NUMBER() OVER(ORDER BY COA.CheckOutID ASC) AS [RowNumber],
      A.[Name] AS AssetName, [AT].TypeName AS AssetType, 
      C.FirstName + N' ' + C.LastName AS CreatorName, C.Company AS CompanyName,
      COA.CheckOutDate, COA.ReturnByDate, COA.IsReturned

FROM [Library].CheckedOutAsset COA
INNER JOIN [Library].[Asset] A ON A.AssetID = COA.AssetID
INNER JOIN [Library].[AssetType] [AT] ON [AT].AssetTypeID = A.AssetTypeID
INNER JOIN [Library].Creator C ON C.CreatorID = A.CreatorID


GO

