CREATE OR ALTER PROCEDURE [Library].InsertBook
   @Name NVARCHAR(32),
   @Type NVARCHAR(32),
   @FirstName NVARCHAR(10),
   @LastName NVARCHAR(10),
   @ReleaseDate DATETIME(2)
AS

DECLARE @CreatorID TINYINT;


MERGE [Library].Author A
USING [Library].InsertBook I ON I.LastName = A.LastName

WHEN NOT MATCHED AND I. THEN



INSERT [Library].Author(FirstName, LastName,)
VALUES(@FirstName, @LastName, @PhoneNumber, @LastCheckedOutDATE);

INSERT [Library].Asset([Name], LastName, PhoneNumber, LastCheckedOutDATE)
VALUES(@FirstName, @LastName, @PhoneNumber, @LastCheckedOutDATE);

SET @UserID = SCOPE_IDENTITY();

GO

