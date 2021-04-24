CREATE OR ALTER PROCEDURE [Library].FetchLibrarian
   @LibrarianID INT
AS

SELECT U.FirstName, U.LastName, U.PhoneNumber, U.LastCheckOutDate, U.IsDeleted
FROM [Library].Librarian L
INNER JOIN [Library].[User] U ON U.UserID = L.UserID
WHERE U.LibrarianID = @LibrarianID;
GO



