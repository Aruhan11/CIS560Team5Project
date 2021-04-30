/*
* 6. Fetch the Librarian’s  personal information by the given LibrarianID
*/
CREATE OR ALTER PROCEDURE [Library].FetchLibrarian
   @LibrarianID INT
AS

SELECT U.UserID, U.FirstName, U.LastName
FROM [Library].Librarian L
INNER JOIN [Library].[User] U ON U.UserID = L.UserID
WHERE L.LibrarianID = @LibrarianID;
GO



