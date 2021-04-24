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
	FROM [Library].CheckedOutAssets COA
	WHERE COA.AssetID = @AssetID
)

SELECT S.RowNumber, A.[Name], [AT].TypeName, (C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company, 
	   A.Stock, COA.CheckOutDate, COA.ReturnByDate, S.InBorrowingTotal
FROM SourceCTE S
INNER JOIN [Library].Asset A ON A.AssetID = S.AssetID
INNER JOIN [Library].AssetType [AT] ON [AT].AssetTypeID = A.AssetTypeID
INNER JOIN [Library].Creators C ON C.CreatorID = A.AssetID
GO



