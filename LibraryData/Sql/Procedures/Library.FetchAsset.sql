
CREATE OR ALTER PROCEDURE [Library].FetchAsset
   @AssetID INT
AS

SELECT A.[Name], A.AssetTypeID, A.CreatorID, A.ReleaseDate, A.Stock
FROM [Library].Asset A
WHERE A.AssetID = @AssetID;
GO



