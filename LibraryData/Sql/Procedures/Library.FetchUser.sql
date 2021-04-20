CREATE OR ALTER PROCEDURE [Library].FetchUser
   @UserID INT
AS

SELECT U.FirstName, U.LastName, U.PhoneNumber, U.LastCheckOutDate
FROM [Library].[User] U
WHERE U.UserID = @UserID;
GO



