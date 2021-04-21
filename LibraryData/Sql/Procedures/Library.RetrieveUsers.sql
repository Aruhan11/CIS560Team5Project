CREATE OR ALTER PROCEDURE [Library].RetrieveUsers
AS

SELECT U.UserID, U.FirstName, U.LastName, U.PhoneNumber, U.LastCheckoutDate
FROM [Library].[User] U;
GO

