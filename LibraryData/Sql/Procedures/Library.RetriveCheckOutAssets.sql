CREATE OR ALTER PROCEDURE [Library].RetriveCheckOutAssets

AS

SELECT COA.CheckOutID, COA.AssetID, COA.UserID, COA.LibrarianID, COA.CheckOutDate, COA.ReturnByDate, COA.IsReturned
FROM [Library].CheckedOutAsset COA


GO