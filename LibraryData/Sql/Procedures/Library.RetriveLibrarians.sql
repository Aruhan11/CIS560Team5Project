CREATE OR ALTER PROCEDURE [Library].RetriveLibrarians

AS

SELECT L.LibrarianID, L.UserID
FROM [Library].Librarian L


GO