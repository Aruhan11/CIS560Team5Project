/*
* 8. Get the list of craters and their name and company  by the given creator type
*/

CREATE OR ALTER PROCEDURE [Library].GetCreatorsByType
   @CreatorTypeName VARCHAR(10)
AS


SELECT ROW_NUMBER() OVER(ORDER BY C.CreatorID ASC) AS [RowNumber],
	   CT.[Name], (C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company
	   
FROM  CreatorType CT 
INNER JOIN [Library].CreatorCreatorType CCT ON CCT.CreatorTypeID = CT.CreatorTypeID
INNER JOIN [Library].Creator C ON C.CreatorID = CCT.CreatorID

WHERE CT.[Name] = @CreatorTypeName
GO



