
CREATE OR ALTER PROCEDURE [Library].FetchCreator
   @CreatorID INT
AS

SELECT C.FirstName, C.LastName, C.Company
FROM [Library].Creator C
WHERE C.CreatorID = @CreatorID;
GO



