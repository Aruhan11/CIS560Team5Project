CREATE OR ALTER PROCEDURE [Library].DeleteUser
@UserID INT

AS

UPDATE [Library].[User]
SET
	IsDeleted = 1,
	UpdatedOn = SYSDATETIMEOFFSET()
WHERE UserID = @UserID;

GO

