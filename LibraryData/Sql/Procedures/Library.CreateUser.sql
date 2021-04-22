CREATE OR ALTER PROCEDURE [Library].CreateUser
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @PhoneNumber NVARCHAR(10),
   @UserID INT OUTPUT
AS

INSERT [Library].[User](FirstName, LastName, PhoneNumber)
VALUES(@FirstName, @LastName, @PhoneNumber);

SET @UserID = SCOPE_IDENTITY();
GO
