CREATE OR ALTER PROCEDURE [Library].RetriveCreators
AS

SELECT C.CreatorID, C.FirstName, C.LastName, C.Company
FROM [Library].Creator C




GO