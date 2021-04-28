/*
* 7. Fetch all productions and their information by the given CreatorID
*/
CREATE OR ALTER PROCEDURE [Library].FetchProductionsOfCreator
   @CreatorID INT
AS


SELECT 
	   (C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company, A.[Name] As AssetName, [AT].[Name] AS AssetType,  
	   A.Stock as Stock
FROM [Library].Creator C
INNER JOIN [Library].Asset A ON A.CreatorID = C.CreatorID
INNER JOIN [Library].AssetType [AT] ON [AT].AssetTypeID = A.AssetTypeID
Where C.CreatorID = @CreatorID
GO




