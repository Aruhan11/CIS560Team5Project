/*
* 3. Fetch the all check out history for a user by the given UserID
*/
CREATE OR ALTER PROCEDURE [Library].FetchCheckOutHistory
   @UserID INT
AS


SELECT 
	A.[Name] AS AssetName, [AT].[Name] AS TypeName, C.FirstName + N' '+ C.LastName AS CreatorName, C.Company, 
	COA.CheckOutDate, COA.ReturnByDate, COA.IsReturned
FROM [Library].CheckedOutAsset COA
INNER JOIN [Library].Asset A ON A.AssetID = COA.AssetID
INNER JOIN [Library].AssetType [AT] ON [AT].AssetTypeID = A.AssetTypeID
INNER JOIN [Library].Creator C ON C.CreatorID = A.CreatorID
WHERE COA.UserID = @UserID;
GO




