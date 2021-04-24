/*
* Fetch all productions and their information by the given CreatorID
*/
CREATE OR ALTER PROCEDURE [Library].FetchProductionOfCreator
   @CreatorID INT
AS

SELECT ROW_NUMBER() OVER(ORDER BY A.AssetTypeID ASC),
	   (C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company, A.[Name], [AT].TypeName,  
	   A.Stock
FROM [Library].Creator C
INNER JOIN [Library].Asset A ON A.CreatorID = S.CreatorID
INNER JOIN [Library].AssetType [AT] ON [AT].AssetTypeID = A.AssetTypeID
GO



