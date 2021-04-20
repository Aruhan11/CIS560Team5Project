CREATE OR ALTER PROCEDURE [Library].DeleteUser
	@UserID
AS

DELETE FROM [Library].[User]
WHERE UserID = @UserID;

GO

