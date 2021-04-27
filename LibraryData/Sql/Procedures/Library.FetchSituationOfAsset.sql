/*
* 5. Fetch the situation of a asset  by the given AssetID
*/
CREATE OR ALTER PROCEDURE [Library].FetchSituationOfAsset
   @AssetID INT
AS

WITH SourceCTE(RowNumber,AssetID,CheckOutDate, ReturnByDate, InBorrowingTotal) AS
(
	SELECT ROW_NUMBER() OVER(ORDER BY COA.CheckOutDate ASC),
		   COA.AssetID, COA.CheckOutDate, COA.ReturnByDate, 
		   SUM(IIF(COA.IsReturned = 0,1,0))
	FROM [Library].CheckedOutAsset COA
	WHERE COA.AssetID = 78
	GROUP BY COA.AssetID, COA.CheckOutDate, COA.ReturnByDate
)

SELECT S.AssetID, A.[Name], [AT].[Name] AS TypeName, (C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company, 
	   S.CheckOutDate, S.ReturnByDate, A.Stock
FROM SourceCTE S
INNER JOIN [Library].Asset A ON A.AssetID = S.AssetID
INNER JOIN [Library].AssetType [AT] ON [AT].AssetTypeID = A.AssetTypeID
INNER JOIN [Library].Creator C ON C.CreatorID = A.AssetID
GO





