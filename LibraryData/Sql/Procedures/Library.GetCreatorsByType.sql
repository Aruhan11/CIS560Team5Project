/*
* 8. Get the list of craters and their name and company  by the given creator type
*/

CREATE OR ALTER PROCEDURE [Library].GetCreatorsByType
   @creatorType VARCHAR(10)
AS



SELECT
	    C.CreatorID,(C.FirstName + N' '+ C.LastName) AS CreatorName, C.Company, A.Stock AS Stock, COA.CheckOutDate, COA.ReturnByDate, COUNT(COA.CheckOutID) AS InBorrowingTotal
	   
FROM  [Library].CreatorType CT 
INNER JOIN [Library].CreatorCreatorType CCT ON CCT.CreatorTypeID = CT.CreatorTypeID
INNER JOIN [Library].Creator C ON C.CreatorID = CCT.CreatorID
INNER JOIN [Library].Asset A ON A.CreatorID = C.CreatorID
INNER JOIN [Library].CheckedOutAsset COA ON COA.AssetID = A.AssetID
WHERE CT.[Name] = @creatorType
GROUP BY C.CreatorID, FirstName, LastName, Company, Stock, CheckOutDate, ReturnByDate
GO




