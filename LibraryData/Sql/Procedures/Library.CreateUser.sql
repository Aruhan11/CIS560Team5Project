CREATE OR ALTER PROCEDURE [Library].CreateUser
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @PhoneNumber NVARCHAR(10),
   @LastCheckedOutDATE DATETIME(2),
   @UserID INT OUTPUT
AS

INSERT [Library].[User](FirstName, LastName, PhoneNumber, LastCheckedOutDATE)
VALUES(@FirstName, @LastName, @PhoneNumber, @LastCheckedOutDATE);

SET @UserID = SCOPE_IDENTITY();
GO
