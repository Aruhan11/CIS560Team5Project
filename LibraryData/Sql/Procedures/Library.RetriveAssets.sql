CREATE OR ALTER PROCEDURE [Library].RetriveAssets
AS

SELECT A.AssetID, A.[Name], A.AssetTypeID, A.CreatorID, A.ReleaseDate, A.Stock
FROM [Library].Asset A




GO