CREATE OR ALTER PROCEDURE [Library].InsertBook
   @Name NVARCHAR(32),
   @Type NVARCHAR(32),
   @FirstName NVARCHAR(10),
   @LastName NVARCHAR(10),
   @ReleaseDate DATETIME(2)
AS

DECLARE @CreatorID TINYINT;

INSERT [Library].Author(FirstName, LastName, CreatorTypeID)
VALUES(@FirstName, @LastName, 2);

SET @CreatorID

INSERT [Library].Asset([Name], LastName, PhoneNumber, LastCheckedOutDATE)
VALUES(@FirstName, @LastName, @PhoneNumber, @LastCheckedOutDATE);

SET @UserID = SCOPE_IDENTITY();

GO

