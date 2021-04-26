/*
*  2. Fetch user’s personal information by the given UserID
*/
CREATE OR ALTER PROCEDURE [Library].FetchUser
   @UserID INT
AS

SELECT U.FirstName, U.LastName, U.PhoneNumber, U.LastCheckOutDate, U.IsDeleted
FROM [Library].[User] U
WHERE U.UserID = @UserID;
GO



