CREATE OR ALTER PROCEDURE [Library].RetriveUsers

AS

SELECT U.UserID, U.FirstName, U.LastName, U.LastCheckOutDate, U.IsDeleted
FROM [Library].[User] U


GO