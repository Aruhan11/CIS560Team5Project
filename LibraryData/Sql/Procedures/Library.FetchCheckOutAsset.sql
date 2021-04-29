
CREATE OR ALTER PROCEDURE [Library].FetchCheckOutAsset
   @CheckOutID INT
AS

SELECT COA.AssetID, COA.UserID, COA.LibrarianID, COA.CheckOutDate, COA.ReturnByDate, COA.IsReturned
FROM [Library].CheckedOutAsset COA
WHERE COA.CheckOutID = @CheckOutID;
GO



