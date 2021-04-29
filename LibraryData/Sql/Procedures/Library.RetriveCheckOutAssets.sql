CREATE OR ALTER PROCEDURE [Library].RetriveCheckOutAssets

AS

SELECT COA.CheckOutAssetID, COA.AssetID, COA.UserID, COA.CheckOutDate, COA.ReturnByDate, COA.IsReturned
FROM [Library].CheckOutAsset COA


GO