CREATE OR ALTER PROCEDURE [Library].CreateUser
   @FirstName NVARCHAR(32),
   @LastName NVARCHAR(32),
   @PhoneNumber NVARCHAR(10),
   @LastCheckoutDate DATETIME2,
   @IsDeleted INT,
   @UserID INT OUTPUT
AS

INSERT [Library].[User](FirstName, LastName, PhoneNumber, LastCheckoutDate, IsDeleted)
VALUES(@FirstName, @LastName, @PhoneNumber, @LastCheckoutDate,@IsDeleted);

SET @UserID = SCOPE_IDENTITY();
GO
