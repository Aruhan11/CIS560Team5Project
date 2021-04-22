/***************************** 
** Create a librarian 
*****************************/
CREATE OR ALTER PROCEDURE [Library].CreateLibrarian
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @PhoneNumber NVARCHAR(10),
   @LastCheckedOutDATE DATETIME(2),
   @UserID INT OUTPUT,
   @LibrarianID INT OUTPUT
AS

INSERT [Library].[User](FirstName, LastName, PhoneNumber, LastCheckedOutDATE)
VALUES(@FirstName, @LastName, @PhoneNumber, @LastCheckedOutDATE);

SET @UserID = SCOPE_IDENTITY();

INSERT [Library].Librarian(UserID)
VALUES(@UserID);

SET  @LibrarianID = SCOPE_IDENTITY();
GO

