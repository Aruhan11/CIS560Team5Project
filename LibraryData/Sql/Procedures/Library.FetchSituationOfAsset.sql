/*
* 5. Fetch the situation of a asset  by the given AssetID
*/
CREATE OR ALTER PROCEDURE [Library].FetchSituationOfAsset
   @AssetID INT
AS

WITH SourceCTE(AssetID,UserID, CheckOutDate, ReturnByDate, IsReturned) AS
(
	SELECT
		   COA.AssetID, COA.UserID, COA.CheckOutDate, COA.ReturnByDate, COA.IsReturned
	FROM [Library].CheckedOutAsset COA
	WHERE COA.AssetID = @AssetID
	GROUP BY COA.AssetID, COA.UserID, COA.CheckOutDate, COA.ReturnByDate, COA.IsReturned
)

SELECT S.AssetID, A.[Name], [AT].[Name] AS TypeName, (C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company, A.Stock,
	   S.UserID, S.CheckOutDate, S.ReturnByDate, S.Isreturned
FROM SourceCTE S
INNER JOIN [Library].Asset A ON A.AssetID = S.AssetID
INNER JOIN [Library].AssetType [AT] ON [AT].AssetTypeID = A.AssetTypeID
INNER JOIN [Library].Creator C ON C.CreatorID = A.AssetID
GO





