CREATE OR ALTER PROCEDURE [Library].FetchCheckOutHistory
   @Name VARCHAR(10)
AS

SELECT ROW_NUMBER() OVER(ORDER BY A.ReleaseDate ASC) AS [RowNumber],
	A.[Name], [AT].TypeName, C.FirstName + N' '+ C.LastName, C.Company, A.ReleaseDate, A.Stock
FROM [Library].Asset A
INNER JOIN [Library].AssetType [AT] ON [AT].AssetTypeID = A.AssetTypeID
INNER JOIN [Library].Creator C ON C.CreatorID = A.CreatorID
WHERE A.[Name] = @Name;
GO



