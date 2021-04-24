/*
*  1. Get user’s personal information by the given phone number
*/

CREATE OR ALTER PROCEDURE [Library].GetUser
   @PhoneNumber NVARCHAR(10)
AS

SELECT U.UserID, U.FirstName, U.LastName, U.LastCheckOutDate, U.IsDeleted
FROM [Library].[User] U
WHERE U.PhoneNumber = @PhoneNumber;
GO


