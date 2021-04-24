/*
* 3. Fetch the all check out history for a user by the given UserID
*/
CREATE OR ALTER PROCEDURE [Library].FetchCheckOutHistory
   @UserID INT
AS

SELECT ROW_NUMBER() OVER(ORDER BY COA.CheckOutDate ASC) AS [RowNumber],
	A.[Name], [AT].TypeName, C.FirstName + N' '+ C.LastName, C.Company, 
	COA.CheckOutDate, COA.ReturnByDate, COA.IsReturned
FROM [Library].CheckedOutAssets COA
INNER JOIN [Library].Assets A ON A.AssetID = COA.AssetID
INNER JOIN [Library].AssetType [AT] ON [AT].AssetTypeID = A.AssetTypeID
INNER JOIN [Library].Creator C ON C.CreatorID = A.CreatorID
WHERE COA.UserID = @UserID;
GO



